using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }

        public String Name { get; set; }
        
        //[Required]
        //[RegularExpression(@"^[0-9]{.5,5}$", ErrorMessage = "PhoneNumber should contain only numbers")]

        public float Credit { get; set; }
        public string Descriptio { get; set; }

        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public int SemesterID { get; set; }
        public virtual Semester Semester { get; set; }
       
    }
}