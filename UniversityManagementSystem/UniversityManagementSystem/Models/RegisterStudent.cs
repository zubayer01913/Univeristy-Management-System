using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSystem.Models
{
    public class RegisterStudent
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Field is required")]
        [MaxLength(100)]
        public string StudentName { get; set; }

        [Required]
        [EmailAddress]
        public string StudentEmail { get; set; }

        [DisplayName("Contact No.")]
        [Required(ErrorMessage = "Contact No. Field is required")]
        [MaxLength(20)]
        public string ContactNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Current Date")]
        public DateTime CurrentDate { get; set; }


        [DisplayName("Address")]
        [DataType(DataType.MultilineText)]
        public string StudentAddress { get; set; }


        [Required(ErrorMessage = "Department can't empty")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        [DisplayName("Registration")]
        public virtual string RegistrotionNo { get; set; }


    }
}