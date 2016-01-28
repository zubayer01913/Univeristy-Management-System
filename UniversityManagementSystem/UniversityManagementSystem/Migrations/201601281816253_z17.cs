namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "IsActive");
        }
    }
}
