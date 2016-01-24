using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class StudentResult
    {
        public int Id { get; set; }
        public string StudentReg { get; set; }
        public string StudentName { get; set; }
        public string   StudentEmail { get; set; }
        public string DepartmentName { get; set; }
        public string SelectCourse { get; set; }
        public string SelectGradLetter { get; set; }
        
    }
}