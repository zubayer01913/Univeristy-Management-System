using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class RegisterStudent
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        [Required]
        [EmailAddress]
        public string StudentEmail { get; set; }

        public string ContactNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Current Date")]
        public DateTime CurrentDate { get; set; }

        public string StudentAddress { get; set; }

        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public string RegistrotionNo { get; set; }


    }
}