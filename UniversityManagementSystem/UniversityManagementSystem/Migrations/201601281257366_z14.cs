namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z14 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RoomNoAllocats", "CourseName", c => c.String(nullable: false));
            AlterColumn("dbo.RoomNoAllocats", "DateOfSaven", c => c.String(nullable: false));
            AlterColumn("dbo.RoomNoAllocats", "Start", c => c.String(nullable: false));
            AlterColumn("dbo.RoomNoAllocats", "End", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RoomNoAllocats", "End", c => c.String());
            AlterColumn("dbo.RoomNoAllocats", "Start", c => c.String());
            AlterColumn("dbo.RoomNoAllocats", "DateOfSaven", c => c.String());
            AlterColumn("dbo.RoomNoAllocats", "CourseName", c => c.String());
        }
    }
}
