using System;
using Microsoft.AspNetCore.Identity;

namespace uttarakhand_project_front.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserFlag { get; set; }
        public DateTime RegistrationTime { get; set; }
    }
}