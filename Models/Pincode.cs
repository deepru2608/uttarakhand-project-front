using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace uttarakhand_project_front.Models
{
    public class Pincode
    {
        [Key]
        public string PincodeValue { get; set; }
    }
}