using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class ManufacturerCatalog : EntityId
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string WebSite { get; set; }
        public bool IsRealization { get; set; }
        [MinLength(8)]
        [MaxLength(8)]
        public string INN { get; set; }
        [MinLength(8)]
        [MaxLength(8)]
        public string EDERPOU { get; set; }
        [MinLength(6)]
        [MaxLength(6)]
        public string MFO { get; set; }
        [MinLength(14)]
        [MaxLength(16)]
        public string RR { get; set; }
        public string Bank { get; set; }
        public float SumDebt { get; set; }

    }
}