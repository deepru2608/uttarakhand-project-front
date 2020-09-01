using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace uttarakhand_project_front.ViewModels
{
    public class ChangePasswordRazorModel
    {
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword", ErrorMessage = "New and confirm password should be matched.")]
        public string ConfirmPassword { get; set; }
        public string userId { get; set; }
    }
}
