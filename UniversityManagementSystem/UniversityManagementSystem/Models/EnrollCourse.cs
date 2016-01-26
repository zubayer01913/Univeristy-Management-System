using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class EnrollCourse
    {
        public int Id { get; set; }
        public string RegisterNumber { get; set; }
        public string StudentName { get; set; }
        [EmailAddress]
        public string StudentEmail { get; set; }
        public string Department { get; set; }
        public string SelectCourse { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Current Date")]
        public DateTime EnrollDate { get; set; }
    }
}