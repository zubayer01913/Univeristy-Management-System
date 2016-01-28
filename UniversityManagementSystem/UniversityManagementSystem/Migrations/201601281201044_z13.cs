namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RegisterStudents", "StudentName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.RegisterStudents", "ContactNumber", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RegisterStudents", "ContactNumber", c => c.String());
            AlterColumn("dbo.RegisterStudents", "StudentName", c => c.String());
        }
    }
}
