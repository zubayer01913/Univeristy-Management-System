using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSystem.Models
{
    //[Validators (typeof(Validator))]
    public class Department
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Place Name is required and lengnth 3-5")]
        //[StringLength(maximumLength: 3, MinimumLength = 5)]
        public string Code { get; set; }

        //[Required]
        //[StringLength(50, MinimumLength = 2, ErrorMessage = "* A valid Department name is required.")]
        //[Display(Name = "Department Name")]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public virtual ICollection<RegisterStudent> RegStudent { get; set; }

        public virtual ICollection<RoomNoAllocat> RoomAllocates { get; set; }
    }
}