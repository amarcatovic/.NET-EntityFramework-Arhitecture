namespace Commands.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Commands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false),
                        ProgrammingLanguageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProgrammingLanguages", t => t.ProgrammingLanguageId)
                .Index(t => t.ProgrammingLanguageId);
            
            CreateTable(
                "dbo.ProgrammingLanguages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commands", "ProgrammingLanguageId", "dbo.ProgrammingLanguages");
            DropIndex("dbo.Commands", new[] { "ProgrammingLanguageId" });
            DropTable("dbo.ProgrammingLanguages");
            DropTable("dbo.Commands");
        }
    }
}
