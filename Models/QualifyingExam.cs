using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace uttarakhand_project_front.Models
{
    public class QualifyingExam
    {
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public int Id { get; set; }
        [Key]
        public string UniqueId { get; set; }
        [Required]
        public string RefNo { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string QualifyingType { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Stream { get; set; }
        [Required]
        public string University { get; set; }
        [Required]
        public string PassingYear { get; set; }
        [Required]
        public string MaxMarks { get; set; }
        [Required]
        public string ObtMarks { get; set; }
        [Required]
        public string PercentageMarks { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}