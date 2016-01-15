namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CourseCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "CourseCode");
        }
    }
}
