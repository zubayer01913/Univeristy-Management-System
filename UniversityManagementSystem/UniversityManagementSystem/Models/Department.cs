using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }

        //[Required]
        //[DataType(DataType.Text)]
        //[StringLength(maximumLength: 3, MinimumLength = 5)]
        public string Code { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}