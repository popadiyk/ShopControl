using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShopControlService
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DbConnection")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<ProductsCatalog> TProductsCatalog { get; set; }
        public DbSet<ProductGroup> TProductGroup { get; set;}
        public DbSet<ManufacturerCatalog> TManufacturerCatalog { get; set; }
        public DbSet<InvoiceCatalog> TInvoiceCatalog { get; set; }
        public DbSet<EmployeeCatalog> TEmployeeCatalog { get; set; }
        public DbSet<ProductsMove> TProductsMove { get; set; }
        public DbSet<InvoiceType> TInvoiceType { get; set; }
        public DbSet<ClientCatalog> TClientCatalog { get; set; }
        public DbSet<StatusPayType> TStatusPayType { get; set; }
        public DbSet<CreatorCatalog> TCreatorCatalog { get; set; }
        public DbSet<SpendMoney> TSpendMoney { get; set; }
        public DbSet<TaxType> TTaxType { get; set; }
        public DbSet<SpendCatalog> TSpendCatalog { get; set; }

    }
}