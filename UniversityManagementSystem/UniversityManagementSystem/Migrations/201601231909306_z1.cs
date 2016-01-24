namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseAssignTeachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        TeacherName = c.String(),
                        CreditToTaken = c.String(),
                        RemainingCredit = c.String(),
                        CouseCode = c.String(),
                        CourseName = c.String(),
                        CourseCredit = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseAssignToTeachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepatmentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        CreditCanBeTaken = c.Double(nullable: false),
                        RemainingCredit = c.Double(nullable: false),
                        CourseId = c.Int(nullable: false),
                        cod = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseCode = c.String(),
                        Name = c.String(),
                        Credit = c.Single(nullable: false),
                        Descriptio = c.String(),
                        DepartmentID = c.Int(nullable: false),
                        SemesterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Semesters", t => t.SemesterID, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.SemesterID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegisterStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        StudentEmail = c.String(nullable: false),
                        ContactNumber = c.String(),
                        CurrentDate = c.DateTime(nullable: false),
                        StudentAddress = c.String(),
                        DepartmentID = c.Int(nullable: false),
                        RegistrotionNo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.RoomNoAllocats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentID = c.Int(nullable: false),
                        CourseName = c.String(),
                        RoomId = c.Int(nullable: false),
                        DateOfSaven = c.String(),
                        Start = c.String(),
                        End = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        Address = c.String(),
                        ContactNO = c.String(),
                        Designation = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        CreditToBeTaken = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SemesterName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EnrollCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegisterNumber = c.String(),
                        StudentName = c.String(),
                        StudentEmail = c.String(),
                        Department = c.String(),
                        SelectCourse = c.String(),
                        EnrollDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentReg = c.String(),
                        StudentName = c.String(),
                        StudentEmail = c.String(),
                        DepartmentName = c.String(),
                        SelectCourse = c.String(),
                        SelectGradLetter = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "SemesterID", "dbo.Semesters");
            DropForeignKey("dbo.Teachers", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.RoomNoAllocats", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.RoomNoAllocats", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.RegisterStudents", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "DepartmentId" });
            DropIndex("dbo.RoomNoAllocats", new[] { "RoomId" });
            DropIndex("dbo.RoomNoAllocats", new[] { "DepartmentID" });
            DropIndex("dbo.RegisterStudents", new[] { "DepartmentID" });
            DropIndex("dbo.Courses", new[] { "SemesterID" });
            DropIndex("dbo.Courses", new[] { "DepartmentID" });
            DropTable("dbo.StudentResults");
            DropTable("dbo.EnrollCourses");
            DropTable("dbo.Semesters");
            DropTable("dbo.Teachers");
            DropTable("dbo.Rooms");
            DropTable("dbo.RoomNoAllocats");
            DropTable("dbo.RegisterStudents");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
            DropTable("dbo.CourseAssignToTeachers");
            DropTable("dbo.CourseAssignTeachers");
        }
    }
}
