namespace ShopControlService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedProductsCatalog : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductsCatalogs", "Group_ID", "dbo.ProductGroups");
            DropForeignKey("dbo.ProductsCatalogs", "Manufacturer_ID", "dbo.ManufacturerCatalogs");
            DropIndex("dbo.ProductsCatalogs", new[] { "Group_ID" });
            DropIndex("dbo.ProductsCatalogs", new[] { "Manufacturer_ID" });
            AlterColumn("dbo.ProductsCatalogs", "Group_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductsCatalogs", "Manufacturer_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductsCatalogs", "Group_ID");
            CreateIndex("dbo.ProductsCatalogs", "Manufacturer_ID");
            AddForeignKey("dbo.ProductsCatalogs", "Group_ID", "dbo.ProductGroups", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ProductsCatalogs", "Manufacturer_ID", "dbo.ManufacturerCatalogs", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsCatalogs", "Manufacturer_ID", "dbo.ManufacturerCatalogs");
            DropForeignKey("dbo.ProductsCatalogs", "Group_ID", "dbo.ProductGroups");
            DropIndex("dbo.ProductsCatalogs", new[] { "Manufacturer_ID" });
            DropIndex("dbo.ProductsCatalogs", new[] { "Group_ID" });
            AlterColumn("dbo.ProductsCatalogs", "Manufacturer_ID", c => c.Int());
            AlterColumn("dbo.ProductsCatalogs", "Group_ID", c => c.Int());
            CreateIndex("dbo.ProductsCatalogs", "Manufacturer_ID");
            CreateIndex("dbo.ProductsCatalogs", "Group_ID");
            AddForeignKey("dbo.ProductsCatalogs", "Manufacturer_ID", "dbo.ManufacturerCatalogs", "ID");
            AddForeignKey("dbo.ProductsCatalogs", "Group_ID", "dbo.ProductGroups", "ID");
        }
    }
}
