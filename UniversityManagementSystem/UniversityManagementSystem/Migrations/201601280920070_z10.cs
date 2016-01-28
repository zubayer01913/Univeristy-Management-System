namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teachers", "TeacherName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Teachers", "TeacherEmail", c => c.String());
            AlterColumn("dbo.Teachers", "ContactNO", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Teachers", "Designation", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teachers", "Designation", c => c.String());
            AlterColumn("dbo.Teachers", "ContactNO", c => c.String());
            AlterColumn("dbo.Teachers", "TeacherEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Teachers", "TeacherName", c => c.String());
        }
    }
}
