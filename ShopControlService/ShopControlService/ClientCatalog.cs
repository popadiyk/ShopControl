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
        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Descripton { get; set; }
        public int Discount { get; set; }
        public float TotalSum { get; set; }
        [Required]
        public int CardNumber { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

    }
}