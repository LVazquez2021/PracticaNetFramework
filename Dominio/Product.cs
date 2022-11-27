using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NET_Framework.Dominio
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(70)]
        public string Description { get; set; }
        public long Price { get; set; }
        public long Tax { get; set; }

        [NotMapped]
        public long TotalPrice { get; set; }
    }
}