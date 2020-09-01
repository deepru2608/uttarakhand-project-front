using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uttarakhand_project_front.Models
{
    public class UserInfo
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public string UserId { get; set; }
    }
}
