using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framework.Dominio
{
    public class SalesLine
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string LineName { get; set; }

        public int SaleId { get; set; }

        [ForeignKey("SaleId")]
        public Sale Sale { get; set; }

        //public virtual Sale Sales { get; set; }
    }
}