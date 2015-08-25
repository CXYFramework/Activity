namespace Activity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMenu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Text", c => c.String(nullable: false));
            DropColumn("dbo.Menus", "Name");
            DropColumn("dbo.Menus", "DisplayName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menus", "DisplayName", c => c.String());
            AddColumn("dbo.Menus", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Menus", "Text");
        }
    }
}
