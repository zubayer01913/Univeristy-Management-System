using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class RoomNoAllocat
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department can't be empty")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        [Required(ErrorMessage = "Course Name can't be empty")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Room can't be empty")]
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        [Required(ErrorMessage = "Day can't be empty")]
        public string DateOfSaven { get; set; }

        [Required(ErrorMessage = "Start time is required")]
        [Display(Name = "From (Formate HH:MM) (24 Hours)")]
        public string Start { get; set; }

        
        [Required(ErrorMessage = "End time is required")]
        [Display(Name = "To (Formate HH:MM) (24 Hours)")]
        public string End { get; set; }

        public bool IsAssigned { get; set; }
    }
}