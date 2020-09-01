using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace uttarakhand_project_front.Models
{
    public class Course
    {
        [Key]
        public string Id { get; set; }
        public string CourseName { get; set; }
        public bool IsActive { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}