using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NET_Framework.Dominio
{
    public class Stock
    {
        [Key]
        public int StockId { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationDate { get; set; }



    }
}