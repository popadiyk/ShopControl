using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class InvoiceCatalog : EntityId
    {
        [Required]
        public virtual InvoiceType TypeInvoice { get; set; }
        [Required]
        public virtual ClientCatalog Client { get; set; }
        [Required]
        public virtual ManufacturerCatalog Manufacturer { get; set; }
        [Required]
        public virtual CreatorCatalog Creator { get; set; }
        [Required]
        public virtual StatusPayType StatusPayType { get; set; }
        [Required]
        [Column(TypeName ="datetime2")]
        public DateTime Date { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public float SummaTotal { get; set; }

    }
}