namespace GoD.WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActivePropertyToPlayerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Active");
        }
    }
}
