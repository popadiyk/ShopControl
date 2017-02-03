using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class ProductsMove : EntityId
    {
        public virtual ProductsCatalog Product { get; set; }
        public virtual InvoiceCatalog Invoice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float SummaForProducts { get; set; }
    }
}