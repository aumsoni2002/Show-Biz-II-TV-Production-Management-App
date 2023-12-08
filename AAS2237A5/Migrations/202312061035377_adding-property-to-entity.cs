namespace AAS2237A5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingpropertytoentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Actor", "Biography", c => c.String());
            AddColumn("dbo.Show", "Premise", c => c.String());
            AddColumn("dbo.Episode", "Premise", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Episode", "Premise");
            DropColumn("dbo.Show", "Premise");
            DropColumn("dbo.Actor", "Biography");
        }
    }
}
