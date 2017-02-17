namespace ShopControlService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeProductGroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductGroups", "Parent_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductGroups", "Parent_ID");
            AddForeignKey("dbo.ProductGroups", "Parent_ID", "dbo.ProductGroups", "ID");
            DropColumn("dbo.ProductGroups", "GroupPush");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductGroups", "GroupPush", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProductGroups", "Parent_ID", "dbo.ProductGroups");
            DropIndex("dbo.ProductGroups", new[] { "Parent_ID" });
            DropColumn("dbo.ProductGroups", "Parent_ID");
        }
    }
}
