namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z4 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CourseAssignTeachers");
        }
        
        public override void Down()
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
            
        }
    }
}
