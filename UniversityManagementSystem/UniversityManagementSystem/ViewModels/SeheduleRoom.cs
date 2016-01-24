using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.ViewModels
{
    public class SeheduleRoom
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string Name { get; set; }
        public string Room { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}