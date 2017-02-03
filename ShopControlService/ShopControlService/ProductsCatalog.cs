using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class ProductsCatalog : EntityId
    {
        public virtual ProductGroup Group { get; set; }
        public virtual ManufacturerCatalog Manufacturer { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Marking { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float PurchasePrice { get; set; }
        [Required]
        public float Price { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [MaxLength(250)]
        public string AdressPhoto { get; set; }
        public bool IsRealization { get; set; }
    }
}