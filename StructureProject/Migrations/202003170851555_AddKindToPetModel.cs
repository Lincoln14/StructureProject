namespace StructureProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKindToPetModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kinds",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kinds");
        }
    }
}
