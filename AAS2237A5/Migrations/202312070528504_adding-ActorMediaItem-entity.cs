namespace AAS2237A5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingActorMediaItementity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActorMediaItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.Binary(),
                        ContentType = c.String(maxLength: 200),
                        Caption = c.String(nullable: false, maxLength: 100),
                        Actor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Actor", t => t.Actor_Id)
                .Index(t => t.Actor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActorMediaItems", "Actor_Id", "dbo.Actor");
            DropIndex("dbo.ActorMediaItems", new[] { "Actor_Id" });
            DropTable("dbo.ActorMediaItems");
        }
    }
}
