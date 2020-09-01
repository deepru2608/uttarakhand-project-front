using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace uttarakhand_project_front.Models
{
    
    public class PayUViewModel
    {
        public PayUViewModel(string checkoutUrl, NameValueCollection nameValue)
        {
            CheckoutUrl = checkoutUrl;
            NameValue = nameValue;
        }

        public string CheckoutUrl { get; set; }
        public NameValueCollection NameValue { get; set; }

    }

    public class PaymentSuccessModel
    {
        public string OrderId { get; set; }
        public string ReferenceNumber { get; set; }
        public string TransactionId { get; set; }
        public string PaymentStatus { get; set; }

        public string PaymentDate { get; set; }
        public string Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string BankName { get; set; }

        public string REFNO { get; set; }

    }

  
}
