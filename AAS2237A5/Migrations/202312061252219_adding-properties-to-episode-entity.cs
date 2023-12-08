namespace AAS2237A5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingpropertiestoepisodeentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Episode", "VideoContentType", c => c.String(maxLength: 200));
            AddColumn("dbo.Episode", "Video", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Episode", "Video");
            DropColumn("dbo.Episode", "VideoContentType");
        }
    }
}
