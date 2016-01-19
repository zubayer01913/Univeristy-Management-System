using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.ViewModels
{
    public class CourseStatic
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string Name { get; set; }
        public string SemesterName { get; set; }
        public string TeacherName { get; set; }
    }
}