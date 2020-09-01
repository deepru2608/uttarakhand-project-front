using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Syncfusion.Blazor.Inputs.Internal;
using uttarakhand_project_front.Models;

namespace uttarakhand_project_front.ViewModels
{
    public class RegistrationViewModel
    {
        public string UserId { get; set; }
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
        [Phone]
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
        [NotMapped]
        public UploadFiles PhohoFile { get; set; }
        [NotMapped]
        public UploadFiles SignatureFile { get; set; }
        public string GradutionName { get; set; }
        
        public string GradutionStream { get; set; }
        
        public string GradutionUniversity { get; set; }
        
        public string GradutionPassingYear { get; set; }
        
        public string GradutionMaxMarks { get; set; }
        
        public string GradutionObtMarks { get; set; }
        //public IFileListEntry file;
        public string GradutionPercentageMarks { get; set; }
        public string PostGradutionName { get; set; }
        public string PGradutionStream { get; set; }
        public string PGradutionUniversity { get; set; }
        public string PGradutionPassingYear { get; set; }
        public string PGradutionMaxMarks { get; set; }
        public string PGradutionObtMarks { get; set; }
        public string PGradutionPercentageMarks { get; set; }
        
        public string TheoryExamName { get; set; }
        public string TheoryExamMaxMarks { get; set; }
        public string TheoryExamObtMarks { get; set; }
        
        public string PracticalExamName { get; set; }
        public string PracticalExamMaxMarks { get; set; }
        public string PracticalExamObtMarks { get; set; }

        public string M_EdExamUniversity { get; set; }
        public string M_EdExamPassingYear { get; set; }
        public string M_EdTotalPercentage { get; set; }

        public string IsKumaunUniversity { get; set; }
        public bool IsAppearing { get; set; }

        public string PhotoPath { get; set; }
        public string SignaturePath { get; set; }

        public Payment PaymentDetail { get; set; }
    }
}