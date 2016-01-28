using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSystem.ViewModels
{
    public class CourseAssignToTeacher
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Department can't be empty")]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "Teacher can't be empty")]
        public string TeacherName { get; set; }
        public string CreditToTaken { get; set; }
        public string RemainingCredit { get; set; }

        [DisplayName("Code")]
        [Required(ErrorMessage = "Course Code Field is required")]
        public string CouseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseCredit { get; set; }

        public bool IsAssigned { get; set; }
    }
}