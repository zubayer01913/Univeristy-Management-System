namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teachers", "TeacherEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "TeacherEmail", c => c.String());
        }
    }
}
