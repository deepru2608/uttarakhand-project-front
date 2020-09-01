using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uttarakhand_project_front.ViewModels
{
    public class ViewAllApplicationViewModel
    {
        public int SerialNo { get; set; }
        public string RefNo { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Year { get; set; }
        public string ExamCenter { get; set; }
        public string CourseName { get; set; }
        public string IsPaymentDone { get; set; }
    }
}
