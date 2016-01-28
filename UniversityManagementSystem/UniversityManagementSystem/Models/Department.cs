using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Code")]
        [Required(ErrorMessage = "Code Field is required")]
        [Index(IsUnique = true)]
        [Remote("DoesDepartmentCodeExist", "Departments", HttpMethod = "POST", ErrorMessage = "Code already exist")]
        [MaxLength(50)]
        [StringLength(7, ErrorMessage = "The {0} must be at least {2} characters long and less then 8 characters.", MinimumLength = 2)]
        public string Code { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Field is required")]
        [Index(IsUnique = true)]
        [Remote("DoesDepartmentNameExist", "Departments", HttpMethod = "POST", ErrorMessage = "Name already exist")]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public virtual ICollection<RegisterStudent> RegStudent { get; set; }

        public virtual ICollection<RoomNoAllocat> RoomAllocates { get; set; }
    }
}