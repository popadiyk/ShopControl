using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class ProductGroup : EntityId
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public int GroupPush { get; set; }
    }
}