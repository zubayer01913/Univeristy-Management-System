using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.ViewModels
{
    public class CourseAssignToTeacher
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string TeacherName { get; set; }
        public string CreditToTaken { get; set; }
        public string RemainingCredit { get; set; }
        public string CouseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseCredit { get; set; }

        
    }
}