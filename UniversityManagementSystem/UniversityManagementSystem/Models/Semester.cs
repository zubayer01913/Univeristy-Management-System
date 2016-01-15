using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Semester
    {
        public int Id { get; set; }
        public String SemesterName { get; set; }

        public virtual ICollection<Course> courses { get; set; }
    }
}