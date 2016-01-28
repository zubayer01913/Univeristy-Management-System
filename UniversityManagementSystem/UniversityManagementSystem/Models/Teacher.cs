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
    public class Teacher
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Teacher Name Field is required")]
        [MaxLength(100)]
        public String TeacherName { get; set; }


        [DisplayName("Address")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }


        //[DisplayName("Email")]
        ////[Required(ErrorMessage = "Email Field is required")]
        //[Index(IsUnique = true)]
        //[Remote("DoesTeacherEmailExist", "Teachers", HttpMethod = "POST", ErrorMessage = "Email already exist")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        //[MaxLength(100)]    
        [Required]
        [EmailAddress]
        public string TeacherEmail { get; set; }

        [DisplayName("Contact No.")]
        [Required(ErrorMessage = "Contact No. Field is required")]
        [MaxLength(20)]
        public string ContactNO { get; set; }


        [Required(ErrorMessage = "Designation can't empty")]
        public string Designation { get; set; }


        [Required(ErrorMessage = "Department can't empty")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }


        [DisplayName("Credit")]
        [Required(ErrorMessage = "Course Credit Field is required")]
        [Range(1, 36, ErrorMessage = "Course Credit must be lies between 1  to 36")]
        public float CreditToBeTaken { get; set; }

    }
}