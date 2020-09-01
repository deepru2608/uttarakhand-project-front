using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace uttarakhand_project_front.Models
{
    public class Payment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegPayId { get; set; }
        [Key]
        [Required]
        public string UniqueId { get; set; }
        [ForeignKey("Registration")]
        public string RefNo { get; set; }
        public Registration Registration { get; set; }
        [Required]
        public string OrderId { get; set; }
        public int Fee { get; set; }
        public int ServiceCharge { get; set; }
        public int TotalFee { get; set; }
        public int PaidStatus { get; set; }
        public string PaidBy { get; set; }
        public DateTime PaidOn { get; set; }
        public string TransactionId { get; set; }
        public string TransactionPaymentId { get; set; }
        public string PaymentMethod { get; set; }
        public string RequestId { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string MerchantRefNo { get; set; }
    }


    public class PaymentViewModel
    {
        public List<Payment> paymentList { get; set; }
    }
}