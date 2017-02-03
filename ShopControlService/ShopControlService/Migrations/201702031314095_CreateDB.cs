namespace ShopControlService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientCatalogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Discount = c.Int(nullable: false),
                        TotalSum = c.Single(nullable: false),
                        CardNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CreatorCatalogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Rights = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EmployeeCatalogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Description = c.String(maxLength: 500),
                        Salary = c.Single(nullable: false),
                        Creator_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CreatorCatalogs", t => t.Creator_ID)
                .Index(t => t.Creator_ID);
            
            CreateTable(
                "dbo.InvoiceCatalogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Description = c.String(maxLength: 1000),
                        SummaTotal = c.Single(nullable: false),
                        Client_ID = c.Int(nullable: false),
                        Creator_ID = c.Int(nullable: false),
                        Manufacturer_ID = c.Int(nullable: false),
                        StatusPayType_ID = c.Int(nullable: false),
                        TypeInvoice_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ClientCatalogs", t => t.Client_ID, cascadeDelete: true)
                .ForeignKey("dbo.CreatorCatalogs", t => t.Creator_ID, cascadeDelete: true)
                .ForeignKey("dbo.ManufacturerCatalogs", t => t.Manufacturer_ID, cascadeDelete: true)
                .ForeignKey("dbo.StatusPayTypes", t => t.StatusPayType_ID, cascadeDelete: true)
                .ForeignKey("dbo.InvoiceTypes", t => t.TypeInvoice_ID, cascadeDelete: true)
                .Index(t => t.Client_ID)
                .Index(t => t.Creator_ID)
                .Index(t => t.Manufacturer_ID)
                .Index(t => t.StatusPayType_ID)
                .Index(t => t.TypeInvoice_ID);
            
            CreateTable(
                "dbo.ManufacturerCatalogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Phone = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100),
                        WebSite = c.String(maxLength: 100),
                        IsRealization = c.Boolean(nullable: false),
                        INN = c.Int(nullable: false),
                        EDERPOU = c.Int(nullable: false),
                        MFO = c.Int(nullable: false),
                        RR = c.Int(nullable: false),
                        Bank = c.String(),
                        SumDebt = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StatusPayTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InvoiceTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        GroupPush = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductsCatalogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Marking = c.String(maxLength: 10),
                        Quantity = c.Int(nullable: false),
                        PurchasePrice = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                        Description = c.String(maxLength: 1000),
                        AdressPhoto = c.String(maxLength: 250),
                        IsRealization = c.Boolean(nullable: false),
                        Group_ID = c.Int(),
                        Manufacturer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductGroups", t => t.Group_ID)
                .ForeignKey("dbo.ManufacturerCatalogs", t => t.Manufacturer_ID)
                .Index(t => t.Group_ID)
                .Index(t => t.Manufacturer_ID);
            
            CreateTable(
                "dbo.ProductsMoves",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        SummaForProducts = c.Single(nullable: false),
                        Invoice_ID = c.Int(),
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.InvoiceCatalogs", t => t.Invoice_ID)
                .ForeignKey("dbo.ProductsCatalogs", t => t.Product_ID)
                .Index(t => t.Invoice_ID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.SpendCatalogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Description = c.String(maxLength: 1000),
                        Regularity = c.Int(nullable: false),
                        Summa = c.Single(nullable: false),
                        EndDay = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Employee_ID = c.Int(),
                        TypeTax_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EmployeeCatalogs", t => t.Employee_ID)
                .ForeignKey("dbo.TaxTypes", t => t.TypeTax_ID)
                .Index(t => t.Employee_ID)
                .Index(t => t.TypeTax_ID);
            
            CreateTable(
                "dbo.TaxTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SpendMoneys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 500),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Spend_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SpendCatalogs", t => t.Spend_ID)
                .Index(t => t.Spend_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpendMoneys", "Spend_ID", "dbo.SpendCatalogs");
            DropForeignKey("dbo.SpendCatalogs", "TypeTax_ID", "dbo.TaxTypes");
            DropForeignKey("dbo.SpendCatalogs", "Employee_ID", "dbo.EmployeeCatalogs");
            DropForeignKey("dbo.ProductsMoves", "Product_ID", "dbo.ProductsCatalogs");
            DropForeignKey("dbo.ProductsMoves", "Invoice_ID", "dbo.InvoiceCatalogs");
            DropForeignKey("dbo.ProductsCatalogs", "Manufacturer_ID", "dbo.ManufacturerCatalogs");
            DropForeignKey("dbo.ProductsCatalogs", "Group_ID", "dbo.ProductGroups");
            DropForeignKey("dbo.InvoiceCatalogs", "TypeInvoice_ID", "dbo.InvoiceTypes");
            DropForeignKey("dbo.InvoiceCatalogs", "StatusPayType_ID", "dbo.StatusPayTypes");
            DropForeignKey("dbo.InvoiceCatalogs", "Manufacturer_ID", "dbo.ManufacturerCatalogs");
            DropForeignKey("dbo.InvoiceCatalogs", "Creator_ID", "dbo.CreatorCatalogs");
            DropForeignKey("dbo.InvoiceCatalogs", "Client_ID", "dbo.ClientCatalogs");
            DropForeignKey("dbo.EmployeeCatalogs", "Creator_ID", "dbo.CreatorCatalogs");
            DropIndex("dbo.SpendMoneys", new[] { "Spend_ID" });
            DropIndex("dbo.SpendCatalogs", new[] { "TypeTax_ID" });
            DropIndex("dbo.SpendCatalogs", new[] { "Employee_ID" });
            DropIndex("dbo.ProductsMoves", new[] { "Product_ID" });
            DropIndex("dbo.ProductsMoves", new[] { "Invoice_ID" });
            DropIndex("dbo.ProductsCatalogs", new[] { "Manufacturer_ID" });
            DropIndex("dbo.ProductsCatalogs", new[] { "Group_ID" });
            DropIndex("dbo.InvoiceCatalogs", new[] { "TypeInvoice_ID" });
            DropIndex("dbo.InvoiceCatalogs", new[] { "StatusPayType_ID" });
            DropIndex("dbo.InvoiceCatalogs", new[] { "Manufacturer_ID" });
            DropIndex("dbo.InvoiceCatalogs", new[] { "Creator_ID" });
            DropIndex("dbo.InvoiceCatalogs", new[] { "Client_ID" });
            DropIndex("dbo.EmployeeCatalogs", new[] { "Creator_ID" });
            DropTable("dbo.SpendMoneys");
            DropTable("dbo.TaxTypes");
            DropTable("dbo.SpendCatalogs");
            DropTable("dbo.ProductsMoves");
            DropTable("dbo.ProductsCatalogs");
            DropTable("dbo.ProductGroups");
            DropTable("dbo.InvoiceTypes");
            DropTable("dbo.StatusPayTypes");
            DropTable("dbo.ManufacturerCatalogs");
            DropTable("dbo.InvoiceCatalogs");
            DropTable("dbo.EmployeeCatalogs");
            DropTable("dbo.CreatorCatalogs");
            DropTable("dbo.ClientCatalogs");
        }
    }
}
