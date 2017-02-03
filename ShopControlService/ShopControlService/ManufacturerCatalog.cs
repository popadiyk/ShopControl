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
        public int INN { get; set; }
        public int EDERPOU { get; set; }
        public int MFO { get; set; }
        public int RR { get; set; }
        public string Bank { get; set; }
        public float SumDebt { get; set; }

    }
}