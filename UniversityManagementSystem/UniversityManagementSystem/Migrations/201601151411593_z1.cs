namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Departments", new[] { "Course_Id" });
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SemesterName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Courses", "DepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Courses", "SemesterID", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "DepartmentID");
            CreateIndex("dbo.Courses", "SemesterID");
            AddForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "SemesterID", "dbo.Semesters", "Id", cascadeDelete: true);
            DropColumn("dbo.Courses", "Semester");
            DropColumn("dbo.Departments", "Course_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Course_Id", c => c.Int());
            AddColumn("dbo.Courses", "Semester", c => c.String());
            DropForeignKey("dbo.Courses", "SemesterID", "dbo.Semesters");
            DropForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "SemesterID" });
            DropIndex("dbo.Courses", new[] { "DepartmentID" });
            DropColumn("dbo.Courses", "SemesterID");
            DropColumn("dbo.Courses", "DepartmentID");
            DropTable("dbo.Semesters");
            CreateIndex("dbo.Departments", "Course_Id");
            AddForeignKey("dbo.Departments", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
