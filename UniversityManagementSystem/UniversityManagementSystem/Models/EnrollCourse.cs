using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class EnrollCourse
    {
        public int Id { get; set; }
        public string RegisterNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string Department { get; set; }
        public string SelectCourse { get; set; }
        public DateTime EnrollDate { get; set; }
    }
}