namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsAssigned", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsAssigned");
        }
    }
}
