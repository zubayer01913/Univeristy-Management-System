namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z15 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EnrollCourses", "RegisterNumber", c => c.String(nullable: false));
            AlterColumn("dbo.EnrollCourses", "SelectCourse", c => c.String(nullable: false));
            AlterColumn("dbo.StudentResults", "StudentReg", c => c.String(nullable: false));
            AlterColumn("dbo.StudentResults", "SelectCourse", c => c.String(nullable: false));
            AlterColumn("dbo.StudentResults", "SelectGradLetter", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentResults", "SelectGradLetter", c => c.String());
            AlterColumn("dbo.StudentResults", "SelectCourse", c => c.String());
            AlterColumn("dbo.StudentResults", "StudentReg", c => c.String());
            AlterColumn("dbo.EnrollCourses", "SelectCourse", c => c.String());
            AlterColumn("dbo.EnrollCourses", "RegisterNumber", c => c.String());
        }
    }
}
