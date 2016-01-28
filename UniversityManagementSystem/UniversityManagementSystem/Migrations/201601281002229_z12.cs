namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CourseAssignToTeachers", "DepartmentName", c => c.String(nullable: false));
            AlterColumn("dbo.CourseAssignToTeachers", "TeacherName", c => c.String(nullable: false));
            AlterColumn("dbo.CourseAssignToTeachers", "CouseCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CourseAssignToTeachers", "CouseCode", c => c.String());
            AlterColumn("dbo.CourseAssignToTeachers", "TeacherName", c => c.String());
            AlterColumn("dbo.CourseAssignToTeachers", "DepartmentName", c => c.String());
        }
    }
}
