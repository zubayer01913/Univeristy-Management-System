using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        //[Required]
        //[DataType(DataType.Text)]
        //[StringLength(maximumLength: 20, MinimumLength = 5)]
        public String TeacherName { get; set; }

        public string Address { get; set; }

        //[Required]
        //[DataType(DataType.Text)]
        //[StringLength(maximumLength: 13, MinimumLength = 11)]

        public string ContactNO { get; set; }
        public string Designation { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public float CreditToBeTaken { get; set; }

    }
}