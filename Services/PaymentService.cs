using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uttarakhand_project_front.Data;
using uttarakhand_project_front.ViewModels;
using uttarakhand_project_front.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using Syncfusion.Blazor.Inputs.Internal;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net;
using System.Net.Http;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;

namespace uttarakhand_project_front.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly FrontAppDbContext dbContext;
        private readonly DapperService dapperService;
        private readonly HttpClient httpClient;
        private readonly ICenterService _centerService;

        private IWebHostEnvironment hostingEnvironment { get; }
        public IConfiguration Configuration { get; }

        public PaymentService(FrontAppDbContext dbContext, IWebHostEnvironment hostingEnvironment, DapperService dapperService, HttpClient httpClient, 
            IConfiguration configuration, ICenterService centerService)
        {
            this.dbContext = dbContext;
            this.hostingEnvironment = hostingEnvironment;
            Configuration = configuration;
            this.dapperService = dapperService;
            this.httpClient = httpClient;
            _centerService = centerService;
        }


       
        public string GetPayU_SALT()
        {
           // return "6jk0tDKX";
           return Configuration.GetSection("PaymentKeys:PayU_Salt").Value;
        }
        public string GetPayU_Merhant_Key()
        {
            //return "sfQXC2";
            return Configuration.GetSection("PaymentKeys:PayU_Merchant_Key").Value;
        }

        public string GetPayU_PAYMENT_URL()
        {
            return "https://test.payu.in/_payment";
            //return "https://secure.payu.in/_payment";
        }
        public string GetPayU_RETURN_URL()
        {
            // return "https://localhost:44370/Payment/PayUPaymentResponse";
            return "https://kuentrance.co.in/Payment/PayUPaymentResponse";
        }
        public  string GetPayU_CANCEL_URL()
        {
            //return "https://localhost:44370/Payment/PayUPaymentCancel";
            return "https://kuentrance.co.in/Payment/PayUPaymentCancel";
        }

        public string Generatehash512(string text)
        {

            byte[] message = Encoding.UTF8.GetBytes(text);

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            SHA512Managed hashString = new SHA512Managed();
            string hex = "";
            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;

        }

        public string GetPayU_HashSequence()
        {
            return "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";
        }



        public async Task<Payment> InsertPaymentMasterAsync(string Id)
        {
            Payment payment;
            //RegistrationViewModel model;
            var registrationMasterData = (await dapperService.GetAllRegistrationDetailsAsync()).FirstOrDefault(f => f.RefNo == Id);

            if (registrationMasterData != null)
            {
                payment = new Payment()
                {

                    UniqueId = Guid.NewGuid().ToString().GetHashCode().ToString("x"),
                    RegPayId = 0,
                    RefNo = registrationMasterData.RefNo,
                    OrderId =  registrationMasterData.RefNo.ToString() + DateTime.Now.ToString("ddMMyyyyhhmm"),
                    Fee = 1200,
                    ServiceCharge = 50,
                    TotalFee = 1250,
                    PaidStatus = 0,
                    PaidBy = "USER",
                    PaidOn = DateTime.Now
                };

                await dbContext.PaymentMaster.AddAsync(payment);
                var result = await dbContext.SaveChangesAsync();

                return await GetPaymentMasterByOrderIdAsync(payment.OrderId);
            }

            return null;
        }


        public async Task<Payment> GetPaymentMasterByOrderIdAsync(string Id)
        {
            Payment paymentData = await dbContext.PaymentMaster.Where(s => s.OrderId.ToUpper().Trim() == Id.ToUpper().Trim()).FirstOrDefaultAsync();
            if (paymentData != null)
            {
                return paymentData;
            }
            return null;
        }

        public async Task<Payment> CheckPaymentPaidAgainstRefNo(string Id)
        {
            Payment paymentData = new Payment();
            paymentData = await dbContext.PaymentMaster.Where(s => s.RefNo.ToUpper().Trim() == Id.ToUpper().Trim() && s.PaidStatus == 1).FirstOrDefaultAsync();
            if (paymentData != null)
            {
                return paymentData;
            }
            return paymentData;
        }

        public async Task<List<Payment>> GetAllPaymentMasterByRefNo(string Id)
        {
            List<Payment> paymentData = await dbContext.PaymentMaster.Where(s => s.RefNo.ToUpper().Trim() == Id.ToUpper().Trim() && s.PaidStatus == 1).ToListAsync();
            if (paymentData != null)
            {
                return paymentData;
            }
            return null;
        }

        public async Task<Payment> UpdatePaymentMasterByOrderIdAsync(string OrderId, PaymentSuccessModel paymentSuccessModel)
        {
            Payment paymentData = dbContext.PaymentMaster.Where(s => s.OrderId.ToUpper().Trim() == OrderId.ToUpper().Trim()).FirstOrDefault();
            if (paymentData != null)
            {

                paymentData.TransactionPaymentId = paymentSuccessModel.TransactionId.ToString();
                paymentData.PaymentMethod = paymentSuccessModel.PaymentMethod.ToString();
                paymentData.ResponseCode = "0";
                paymentData.ResponseMessage = paymentSuccessModel.PaymentStatus.ToUpper().ToString();
                paymentData.TransactionId = paymentSuccessModel.TransactionId.ToString();
                paymentData.MerchantRefNo = paymentSuccessModel.ReferenceNumber.ToString();
                paymentData.PaidStatus = 1;
                paymentData.PaidBy = paymentSuccessModel.BankName;
                paymentData.PaidOn = DateTime.Now;
                try
                {
                    dbContext.PaymentMaster.Attach(paymentData);
                    dbContext.Entry(paymentData).Property(x => x.TransactionPaymentId).IsModified = true;
                    dbContext.Entry(paymentData).Property(x => x.PaymentMethod).IsModified = true;
                    dbContext.Entry(paymentData).Property(x => x.ResponseMessage).IsModified = true;
                    dbContext.Entry(paymentData).Property(x => x.TransactionId).IsModified = true;
                    dbContext.Entry(paymentData).Property(x => x.MerchantRefNo).IsModified = true;
                    dbContext.Entry(paymentData).Property(x => x.PaidStatus).IsModified = true;
                    dbContext.Entry(paymentData).Property(x => x.PaidBy).IsModified = true;
                    dbContext.Entry(paymentData).Property(x => x.PaidOn).IsModified = true;
                    var result = await dbContext.SaveChangesAsync();


                    try
                    {
                        Registration registrationMasterData = dbContext.RegistrationMaster.Where(s => s.RefNo.ToUpper().Trim() == paymentData.RefNo.ToUpper().Trim()).FirstOrDefault();
                        if (registrationMasterData != null)
                        {
                            registrationMasterData.FinalSubmitTimeStamp = paymentData.PaidOn;
                            registrationMasterData.PaymentDoneTimeStamp = paymentData.PaidOn;
                            registrationMasterData.IsFinalSubmit = "Yes";
                            registrationMasterData.IsPaymentDone = "Yes";
                            dbContext.RegistrationMaster.Attach(registrationMasterData);
                            dbContext.Entry(registrationMasterData).Property(x => x.IsFinalSubmit).IsModified = true;
                            dbContext.Entry(registrationMasterData).Property(x => x.FinalSubmitTimeStamp).IsModified = true;
                            dbContext.Entry(registrationMasterData).Property(x => x.IsPaymentDone).IsModified = true;
                            dbContext.Entry(registrationMasterData).Property(x => x.PaymentDoneTimeStamp).IsModified = true;

                            var resultRegData = await dbContext.SaveChangesAsync();


                            string sms = "We have received Rs. " + paymentData.TotalFee.ToString() + " with Transaction Id: " + paymentSuccessModel.TransactionId + " against Refno " + paymentData.RefNo + ". Thanks KU NAINITAL";
                            //string answer = GenFx.gosms(registrationMasterData.MobileNo, sms);
                            await _centerService.SendSmsAsync(registrationMasterData.MobileNo, sms);
                        }


                    }
                    catch (Exception ex1)
                    {
                        Console.WriteLine(ex1.Message);
                    }
                    //dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return null;
        }
    }
}
