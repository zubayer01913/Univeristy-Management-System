using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }

        public virtual ICollection<RoomNoAllocat> RoomAllocate { get; set; }
    }
}