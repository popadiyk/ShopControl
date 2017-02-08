namespace ShopControlService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeClientCatalog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientCatalogs", "CreateDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.ClientCatalogs", "Descripton", c => c.String(maxLength: 500));
            AddColumn("dbo.ClientCatalogs", "PhoneNumber", c => c.String(maxLength: 15));
            AddColumn("dbo.ClientCatalogs", "BirthDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientCatalogs", "BirthDate");
            DropColumn("dbo.ClientCatalogs", "PhoneNumber");
            DropColumn("dbo.ClientCatalogs", "Descripton");
            DropColumn("dbo.ClientCatalogs", "CreateDate");
        }
    }
}
