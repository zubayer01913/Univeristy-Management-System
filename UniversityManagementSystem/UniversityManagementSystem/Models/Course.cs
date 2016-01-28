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
    public class Course
    {
        public int Id { get; set; }

        [DisplayName("Code")]
        [Required(ErrorMessage = "Course Code Field is required")]
        [Index(IsUnique = true)]
        [Remote("DoesCourseCodeExist", "Courses", HttpMethod = "POST", ErrorMessage = "Course Code already exist")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "{0} must be at least {2} characters long", MinimumLength = 5)]
        public string CourseCode { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Course Name Field is required")]
        [Index(IsUnique = true)]
        [Remote("DoesCourseNameExist", "Courses", HttpMethod = "POST", ErrorMessage = "Course Name already exist")]
        [MaxLength(100)]
        public String Name { get; set; }

        [DisplayName("Credit")]
        [Required(ErrorMessage = "Course Credit Field is required")]
        [Range(.5, 5, ErrorMessage = "Course Credit must be lies between 0.5  to 5.0")]
        public float Credit { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Descriptio { get; set; }

        [Required(ErrorMessage = "Department can't empty")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public int SemesterID { get; set; }
        public virtual Semester Semester { get; set; }

        public bool IsAssigned { get; set; }
       
    }
}

