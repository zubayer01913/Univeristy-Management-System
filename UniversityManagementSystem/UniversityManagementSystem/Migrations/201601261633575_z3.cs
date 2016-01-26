namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseAssignToTeachers", "DepartmentName", c => c.String());
            AddColumn("dbo.CourseAssignToTeachers", "TeacherName", c => c.String());
            AddColumn("dbo.CourseAssignToTeachers", "CreditToTaken", c => c.String());
            AddColumn("dbo.CourseAssignToTeachers", "CouseCode", c => c.String());
            AddColumn("dbo.CourseAssignToTeachers", "CourseName", c => c.String());
            AddColumn("dbo.CourseAssignToTeachers", "CourseCredit", c => c.String());
            AlterColumn("dbo.CourseAssignToTeachers", "RemainingCredit", c => c.String());
            DropColumn("dbo.CourseAssignToTeachers", "DepatmentId");
            DropColumn("dbo.CourseAssignToTeachers", "TeacherId");
            DropColumn("dbo.CourseAssignToTeachers", "CreditCanBeTaken");
            DropColumn("dbo.CourseAssignToTeachers", "CourseId");
            DropColumn("dbo.CourseAssignToTeachers", "cod");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseAssignToTeachers", "cod", c => c.String());
            AddColumn("dbo.CourseAssignToTeachers", "CourseId", c => c.Int(nullable: false));
            AddColumn("dbo.CourseAssignToTeachers", "CreditCanBeTaken", c => c.Double(nullable: false));
            AddColumn("dbo.CourseAssignToTeachers", "TeacherId", c => c.Int(nullable: false));
            AddColumn("dbo.CourseAssignToTeachers", "DepatmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.CourseAssignToTeachers", "RemainingCredit", c => c.Double(nullable: false));
            DropColumn("dbo.CourseAssignToTeachers", "CourseCredit");
            DropColumn("dbo.CourseAssignToTeachers", "CourseName");
            DropColumn("dbo.CourseAssignToTeachers", "CouseCode");
            DropColumn("dbo.CourseAssignToTeachers", "CreditToTaken");
            DropColumn("dbo.CourseAssignToTeachers", "TeacherName");
            DropColumn("dbo.CourseAssignToTeachers", "DepartmentName");
        }
    }
}
