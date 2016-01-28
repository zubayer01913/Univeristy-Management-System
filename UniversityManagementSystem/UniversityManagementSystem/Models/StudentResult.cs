using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class StudentResult
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Select Registation number can't be Rgister Number")]
        public string StudentReg { get; set; }
        public string StudentName { get; set; }
        public string   StudentEmail { get; set; }
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "Select Course can't be Rgister Number")]
        public string SelectCourse { get; set; }

        [Required(ErrorMessage = "Select Grad can't be Rgister Number")]
        public string SelectGradLetter { get; set; }
        
    }
}