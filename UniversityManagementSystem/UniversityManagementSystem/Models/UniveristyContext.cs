using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class UniveristyContext : DbContext
    {
        public DbSet<Department> Depatments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<RegisterStudent> RegisterStudents { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomNoAllocat> RoomNoAllocates { get; set; }
        public DbSet<StudentResult> StudentResults { get; set; }
        public DbSet<EnrollCourse> EnrollCourses { get; set; }

        public System.Data.Entity.DbSet<UniversityManagementSystem.ViewModels.CourseAssignToTeacher> CourseAssignToTeachers { get; set; }

    }
    
}