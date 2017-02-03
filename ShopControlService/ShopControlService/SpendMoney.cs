using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class SpendMoney : EntityId
    {
        public virtual SpendCatalog Spend { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
    }
}