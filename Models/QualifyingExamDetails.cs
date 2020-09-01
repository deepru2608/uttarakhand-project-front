using System;

namespace uttarakhand_project_front.Models
{
    public class QualifyingExamDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public bool IsActive { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}