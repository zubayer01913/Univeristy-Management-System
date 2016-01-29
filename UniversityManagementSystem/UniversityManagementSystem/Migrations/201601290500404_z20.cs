namespace UniversityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z20 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ViewResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentReg = c.String(),
                        StudentName = c.String(),
                        StudentEmail = c.String(),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ViewResults");
        }
    }
}
