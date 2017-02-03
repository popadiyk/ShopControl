using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class SpendCatalog : EntityId
    {
        public virtual TaxType TypeTax { get; set; }
        public virtual EmployeeCatalog Employee { get; set; }
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public int Regularity { get; set; }
        [Required]
        public float Summa { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime EndDay { get; set; }
    }
}