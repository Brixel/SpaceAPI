namespace SpaceAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iauditable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StateLogs", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.StateLogs", "CreatedBy", c => c.String());
            AddColumn("dbo.StateLogs", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.StateLogs", "UpdatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StateLogs", "UpdatedBy");
            DropColumn("dbo.StateLogs", "UpdatedDate");
            DropColumn("dbo.StateLogs", "CreatedBy");
            DropColumn("dbo.StateLogs", "CreatedDate");
        }
    }
}
