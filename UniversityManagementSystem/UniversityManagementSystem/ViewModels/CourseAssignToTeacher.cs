using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.ViewModels
{
    public class CourseAssignToTeacher
    {
        public int Id { get; set; }
        public int DepatmentId { get; set; }
        public int TeacherId { get; set; }
        public double CreditCanBeTaken { get; set; }
        public double RemainingCredit { get; set; }
        public int CourseId { get; set; }
        public string cod { get; set; }

        
    }
}