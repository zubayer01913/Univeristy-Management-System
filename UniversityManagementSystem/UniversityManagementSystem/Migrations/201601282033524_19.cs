namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseAssignToTeachers", "IsAssigned", c => c.Boolean(nullable: false));
            AddColumn("dbo.RoomNoAllocats", "IsAssigned", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RoomNoAllocats", "IsAssigned");
            DropColumn("dbo.CourseAssignToTeachers", "IsAssigned");
        }
    }
}
