namespace MyCricket.WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TeamBirthDay = c.DateTime(nullable: false),
                        CurrentRecord = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Int(nullable: false),
                        JoinedDate = c.DateTime(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
        }
    }
}
