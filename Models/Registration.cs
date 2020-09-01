using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Syncfusion.Blazor.Inputs.Internal;

namespace uttarakhand_project_front.Models
{
    public class Registration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UniqueKey { get; set; }
        public string UserId { get; set; }
        [Key]
        public string RefNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string MotherName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? Dob { get; set; }
        [Required]
        [MaxLength(10)]
        public string MobileNo { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string ExamCenter { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string StudentGroup { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string IsDomicileOfUttarakhand { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string IsFreedomFighter { get; set; }
        [Required]
        public string IsDefencePersonal { get; set; }
        [Required]
        public string IsPhysicallyChallenged { get; set; }
        [Required]
        public string PhysicallyChallengedType { get; set; }
        [Required]
        public string IsPunishedByCourt { get; set; }
        public string IsEconomicallyWeakerSection { get; set; }
        [Required]
        public string IsDebarredByUniversity { get; set; }
        [Required]
        public string StateName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Pincode { get; set; }
        
        public string PhotoPath { get; set; }
        public string SignaturePath { get; set; }
        public int IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime UpdatedTimeStamp { get; set; }
        public string IsFinalSubmit { get; set; }
        public string IsPaymentDone { get; set; }
        public DateTime FinalSubmitTimeStamp { get; set; }
        public DateTime PaymentDoneTimeStamp { get; set; }
        public bool IsAppearing { get; set; }
        public string IsKumaunUniversity { get; set; }
    }
}