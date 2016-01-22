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

        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public string CourseName { get; set; }

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        public string DateOfSaven { get; set; }


        public string Start { get; set; }

        public string End { get; set; }

    }
}