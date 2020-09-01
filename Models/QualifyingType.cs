using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace uttarakhand_project_front.Models
{
    public class QualifyingType
    {
        [Key]
        public int Id { get; set; }
        public string QualifyingTypeName { get; set; }
    }
}