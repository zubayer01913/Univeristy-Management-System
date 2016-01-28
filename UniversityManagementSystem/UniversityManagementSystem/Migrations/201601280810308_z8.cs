namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Courses", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "Name" });
            AlterColumn("dbo.Courses", "Name", c => c.String());
        }
    }
}
