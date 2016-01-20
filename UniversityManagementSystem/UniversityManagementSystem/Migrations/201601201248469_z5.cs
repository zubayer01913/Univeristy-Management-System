namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z5 : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegisterStudents", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.RegisterStudents", new[] { "DepartmentID" });
            DropTable("dbo.RegisterStudents");
            DropTable("dbo.CourseAssignToTeachers");
        }
    }
}
