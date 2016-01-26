namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "TeacherEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "TeacherEmail");
        }
    }
}
