namespace Activity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAcitvity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Createtime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Catagory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActivityCatagories", t => t.Catagory_Id)
                .Index(t => t.Catagory_Id);
            
            CreateTable(
                "dbo.ActivityItems",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        Place = c.String(),
                        DoWhat = c.String(),
                        Budget = c.Int(nullable: false),
                        SequenceNO = c.Int(nullable: false),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Activity_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.Activity_Id)
                .Index(t => t.Activity_Id);
            
            CreateTable(
                "dbo.ActivityCatagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Discusses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SequenceNO = c.Int(nullable: false),
                        Content = c.String(),
                        Activity_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.Activity_Id)
                .Index(t => t.Activity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Discusses", "Activity_Id", "dbo.Activities");
            DropForeignKey("dbo.Activities", "Catagory_Id", "dbo.ActivityCatagories");
            DropForeignKey("dbo.ActivityItems", "Activity_Id", "dbo.Activities");
            DropIndex("dbo.Discusses", new[] { "Activity_Id" });
            DropIndex("dbo.ActivityItems", new[] { "Activity_Id" });
            DropIndex("dbo.Activities", new[] { "Catagory_Id" });
            DropTable("dbo.Discusses");
            DropTable("dbo.ActivityCatagories");
            DropTable("dbo.ActivityItems");
            DropTable("dbo.Activities");
        }
    }
}
