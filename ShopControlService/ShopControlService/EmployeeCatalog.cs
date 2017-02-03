using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class EmployeeCatalog : EntityId
    {
        public virtual CreatorCatalog Creator { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public float Salary { get; set; }
    }
}