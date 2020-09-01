using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace uttarakhand_project_front.Models
{
    public class OtpTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [Key]
        public string UniqueId { get; set; }
        [Required]
        public string Otp { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public bool IsValid { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
    }
}