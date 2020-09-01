using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using uttarakhand_project_front.Services;
using uttarakhand_project_front.Models;
using Microsoft.AspNetCore.Http;

namespace uttarakhand_project_front.Controllers
{
    public class PaymentController : Controller
    {
        private readonly DapperService _dapperService;
        private readonly ICenterService _centerService;
        private readonly IPaymentService _paymentService;

        public PaymentController(DapperService dapperService, IPaymentService paymentService,
            ICenterService centerService)
        {
            _dapperService = dapperService;
            _centerService = centerService;
            _paymentService = paymentService;
        }

        public async Task<IActionResult> ViewPayment(string id)
        {
            PaymentViewModel paymentViewModel = new PaymentViewModel();
            paymentViewModel.paymentList = await _paymentService.GetAllPaymentMasterByRefNo(id);
            return View(paymentViewModel);
        }

        [AllowAnonymous]
        public async Task<IActionResult> ViewPaymentSlip(string id)
        {
            Payment paymentData = await _paymentService.GetPaymentMasterByOrderIdAsync(id);
            PaymentSuccessModel _PaymentSuccessModel = new PaymentSuccessModel();

            if (paymentData != null)
            {
                _PaymentSuccessModel = new PaymentSuccessModel()
                {
                    OrderId = paymentData.OrderId,
                    ReferenceNumber = paymentData.MerchantRefNo,
                    PaymentMethod = paymentData.PaymentMethod,
                    TransactionId = paymentData.TransactionId,
                    PaymentStatus = "Success",
                    PaymentDate = paymentData.PaidOn.ToString("dd/MM/yyyy hh:mm tt"),
                    Amount = paymentData.TotalFee.ToString(),
                    BankName = "HDFC"
                };
            }

            return View(_PaymentSuccessModel);
        }

        //[Authorize(Roles = "User, Admin, SuperAdmin")]
        public async Task<IActionResult> RegistrationPayment(string id)
        {
            Payment checkPayment = await _dapperService.CheckPaymentPaidAgainstRefNo(id);
            if (checkPayment == null)
            {
                var registrationData = await _centerService.GetRegistrationDetailsByRefIdAsync(id);
                if (registrationData != null)
                {
                    Payment paymentModel = await _paymentService.InsertPaymentMasterAsync(id);
                    string amountTotalFee = paymentModel.TotalFee.ToString();
                    if (paymentModel != null && registrationData != null)
                    {
                        string CheckoutUrl = _paymentService.GetPayU_PAYMENT_URL();
                        NameValueCollection nameValue = PaymentRequestParametersNameValueNew(paymentModel.OrderId,
                            registrationData.RefNo,
                            paymentModel.TotalFee.ToString(), registrationData.Name, registrationData.EmailAddress,
                            registrationData.MobileNo);

                        if (nameValue != null)
                        {
                            return View("../Payment/PaymentCheckoutUrl", new PayUViewModel(CheckoutUrl, nameValue));
                        }
                    }
                }
            }

            return RedirectToAction("PrintFinalDownload", "Service", new {id = checkPayment.RefNo});
        }


        public NameValueCollection PaymentRequestParametersNameValueNew(string OrderId, string Refno, string amount,
            string name, string email, string mobile)
        {
            string[] hashVarsSeq;
            string hash_string = string.Empty;

            string MERCHANT_KEY = _paymentService.GetPayU_Merhant_Key(); //sonepat
            string salt = _paymentService.GetPayU_SALT(); //sonepat
            string productInfo = "REFNO_" + Refno;

            //  string hashString = MERCHANT_KEY + "|" + OrderId + "|" + Convert.ToDecimal(amount).ToString("g29") + "|" + productInfo + "|" + name + "|" + email + "|||||||||||" + salt;

            //string hash = _paymentService.Generatehash512(hashString);
            string PayU_RETURN_URL = _paymentService.GetPayU_RETURN_URL();
            string PayU_CANCEL_URL = _paymentService.GetPayU_CANCEL_URL();


            string HashSequence = _paymentService.GetPayU_HashSequence();

            hashVarsSeq = HashSequence.Split('|');
            hash_string = "";
            foreach (string hash_var in hashVarsSeq)
            {
                if (hash_var == "key")
                {
                    hash_string = hash_string + MERCHANT_KEY;
                    hash_string = hash_string + '|';
                }
                else if (hash_var == "txnid")
                {
                    hash_string = hash_string + OrderId;
                    hash_string = hash_string + '|';
                }
                else if (hash_var == "amount")
                {
                    hash_string = hash_string + Convert.ToDecimal(amount).ToString("g29");
                    hash_string = hash_string + '|';
                }
                else if (hash_var == "productinfo")
                {
                    hash_string = hash_string + productInfo;
                    hash_string = hash_string + '|';
                }
                else if (hash_var == "firstname")
                {
                    hash_string = hash_string + name;
                    hash_string = hash_string + '|';
                }
                else if (hash_var == "email")
                {
                    hash_string = hash_string + email;
                    hash_string = hash_string + '|';
                }
                else
                {
                    hash_string = hash_string + ""; // isset if else
                    hash_string = hash_string + '|';
                }
            }

            hash_string += salt; // appending SALT            
            string hash1 = _paymentService.Generatehash512(hash_string).ToLower(); //generating hash


            var queryParameters = new NameValueCollection
            {
                {"hash", hash1},
                {"txnid", OrderId},
                {"key", MERCHANT_KEY},
                {"amount", amount},
                {"firstname", name},
                {"email", email},
                {"phone", mobile},
                {"productinfo", productInfo},
                {"surl", PayU_RETURN_URL},
                {"furl", PayU_RETURN_URL},
                {"curl", PayU_CANCEL_URL},
                {"lastname", OrderId},
                {"address1", Refno},
                {"address2", ""},
                {"city", ""},
                {"state", ""},
                {"country", ""},
                {"zipcode", OrderId},
                {"udf1", ""},
                {"udf2", ""},
                {"udf3", ""},
                {"udf4", ""},
                {"udf5", ""},
                {"pg", ""}
            };
            return queryParameters;
        }

        [HttpPost]
        public async Task<IActionResult> PayUPaymentResponse(IFormCollection form)
        {
            PaymentSuccessModel _PaymentSuccessModel = new PaymentSuccessModel();

            try
            {
                //string[] merc_hash_vars_seq;
                string merc_hash_string = string.Empty;
                string merc_hash = string.Empty;
                string order_id = string.Empty;
                // string hash_seq =
                //     "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";

                if (form["status"].ToString() == "success")

                {
                    string email = form["email"].ToString();
                    string name = form["firstname"].ToString();
                    string amount = form["amount"].ToString();
                    string txnid = form["txnid"].ToString();
                    string oid = Request.Form["txnid"];

                    order_id = Request.Form["txnid"];
                    string mihpayid = Request.Form["mihpayid"];
                    string mode = Request.Form["mode"];
                    string bank_ref_num = Request.Form["bank_ref_num"];
                    string DateCreated = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                    string PaymentID = Request.Form["mihpayid"];


                    ViewData["Message"] = "Status is successful. Hash value is matched";
                    ViewData["response"] = "success";

                    _PaymentSuccessModel = new PaymentSuccessModel()
                    {
                        OrderId = order_id,
                        ReferenceNumber = bank_ref_num,
                        PaymentMethod = mode,
                        TransactionId = PaymentID,
                        PaymentStatus = "Success",
                        PaymentDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"),
                        Amount = amount,
                        BankName = "HDFC"
                    };
                    // Update in Payemnt  Master

                    try
                    {
                        Payment paymentModel =
                            await _paymentService.UpdatePaymentMasterByOrderIdAsync(order_id, _PaymentSuccessModel);
                    }
                    catch (Exception ex1)
                    {
                        Console.WriteLine(ex1.Message);
                    }
                }

                else
                {
                    _PaymentSuccessModel = new PaymentSuccessModel()
                    {
                        OrderId = order_id,
                        ReferenceNumber = "",
                        PaymentMethod = "",
                        TransactionId = "",
                        PaymentStatus = "Failure",
                        PaymentDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"),
                        Amount = "",
                        BankName = "HDFC"
                    };
                }
            }

            catch (Exception ex)
            {
                // Response.Write("<span style='color:red'>" + ex.Message + "</span>");
                Console.WriteLine(ex.Message);
            }

            return View(_PaymentSuccessModel);
        }


        [HttpPost]
        public IActionResult PayUPaymentCancel(FormCollection form)
        {
            return View();
        }
    }
}