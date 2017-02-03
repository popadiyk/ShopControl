using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class ClientCatalog : EntityId
    {
        [MaxLength(250)]
        public string Name { get; set; }
        public int Discount { get; set; }
        public float TotalSum { get; set; }
        [Required]
        public int CardNumber { get; set; }

    }
}