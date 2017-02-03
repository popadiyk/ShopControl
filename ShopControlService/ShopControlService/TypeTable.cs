using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopControlService
{
    public class TypeTable
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}