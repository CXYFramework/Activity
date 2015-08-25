namespace Activity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMenu2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Parent", c => c.Int(nullable: false));
            DropColumn("dbo.Menus", "ParentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menus", "ParentId", c => c.Int(nullable: false));
            DropColumn("dbo.Menus", "Parent");
        }
    }
}
