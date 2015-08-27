namespace Activity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActivityEntities : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Activities", "Createtime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Activities", "Createtime", c => c.DateTime(nullable: false));
        }
    }
}
