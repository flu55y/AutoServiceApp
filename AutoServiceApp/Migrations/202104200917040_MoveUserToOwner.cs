namespace AutoServiceApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoveUserToOwner : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Owners", "Login", c => c.String());
            AddColumn("dbo.Owners", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Owners", "Password");
            DropColumn("dbo.Owners", "Login");
        }
    }
}
