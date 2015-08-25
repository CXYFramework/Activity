namespace Activity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMenu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuRoleMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        MenuId = c.Int(nullable: false),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.MenuId, cascadeDelete: true)
                .ForeignKey("dbo.AbpRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DisplayName = c.String(),
                        ParentId = c.Int(nullable: false),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuRoleMappings", "RoleId", "dbo.AbpRoles");
            DropForeignKey("dbo.MenuRoleMappings", "MenuId", "dbo.Menus");
            DropIndex("dbo.MenuRoleMappings", new[] { "MenuId" });
            DropIndex("dbo.MenuRoleMappings", new[] { "RoleId" });
            DropTable("dbo.Menus");
            DropTable("dbo.MenuRoleMappings");
        }
    }
}
