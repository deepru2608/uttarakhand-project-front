using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace uttarakhand_project_front.Models
{
    public class ExamCenter
    {
        [Key]
        public int Id { get; set; }

        public string CenterName { get; set; }
    }
}