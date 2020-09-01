using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace uttarakhand_project_front.ViewModels
{
    public class AssignUserRoleViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string RoleName { get; set; }
        public string Action { get; set; }
    }
}
