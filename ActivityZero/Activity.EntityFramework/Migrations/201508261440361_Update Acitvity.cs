namespace Activity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAcitvity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Discusses", "LastModificationTime", c => c.DateTime());
            AddColumn("dbo.Discusses", "LastModifierUserId", c => c.Long());
            AddColumn("dbo.Discusses", "CreationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Discusses", "CreatorUserId", c => c.Long());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Discusses", "CreatorUserId");
            DropColumn("dbo.Discusses", "CreationTime");
            DropColumn("dbo.Discusses", "LastModifierUserId");
            DropColumn("dbo.Discusses", "LastModificationTime");
        }
    }
}
