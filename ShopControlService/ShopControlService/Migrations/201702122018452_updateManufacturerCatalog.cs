namespace ShopControlService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateManufacturerCatalog : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ManufacturerCatalogs", "INN", c => c.String(maxLength: 8));
            AlterColumn("dbo.ManufacturerCatalogs", "EDERPOU", c => c.String(maxLength: 8));
            AlterColumn("dbo.ManufacturerCatalogs", "MFO", c => c.String(maxLength: 6));
            AlterColumn("dbo.ManufacturerCatalogs", "RR", c => c.String(maxLength: 16));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ManufacturerCatalogs", "RR", c => c.Int(nullable: false));
            AlterColumn("dbo.ManufacturerCatalogs", "MFO", c => c.Int(nullable: false));
            AlterColumn("dbo.ManufacturerCatalogs", "EDERPOU", c => c.Int(nullable: false));
            AlterColumn("dbo.ManufacturerCatalogs", "INN", c => c.Int(nullable: false));
        }
    }
}
