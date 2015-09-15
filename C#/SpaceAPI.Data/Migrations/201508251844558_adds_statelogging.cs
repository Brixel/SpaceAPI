namespace SpaceAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adds_statelogging : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StateLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Open = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StateLogs");
        }
    }
}
