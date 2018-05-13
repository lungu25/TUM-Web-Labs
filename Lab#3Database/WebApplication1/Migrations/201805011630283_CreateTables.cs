namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Smartphones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        PicturePath = c.String(),
                        Price = c.Int(nullable: false),
                        OperatingSystem = c.String(nullable: false),
                        Camera = c.String(),
                        Display = c.String(),
                        CPU = c.String(),
                        Memory = c.String(),
                        Battery = c.String(),
                        Dimension = c.String(),
                        Weight = c.String(),
                        Port = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Smartphones");
        }
    }
}
