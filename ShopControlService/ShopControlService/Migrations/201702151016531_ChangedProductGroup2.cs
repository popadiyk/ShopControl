namespace ShopControlService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedProductGroup2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ProductGroups", new[] { "Parent_ID" });
            AlterColumn("dbo.ProductGroups", "Parent_ID", c => c.Int());
            CreateIndex("dbo.ProductGroups", "Parent_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ProductGroups", new[] { "Parent_ID" });
            AlterColumn("dbo.ProductGroups", "Parent_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductGroups", "Parent_ID");
        }
    }
}
