namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Code", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Departments", "Code", unique: true);
            CreateIndex("dbo.Departments", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Departments", new[] { "Name" });
            DropIndex("dbo.Departments", new[] { "Code" });
            AlterColumn("dbo.Departments", "Name", c => c.String());
            AlterColumn("dbo.Departments", "Code", c => c.String());
        }
    }
}
