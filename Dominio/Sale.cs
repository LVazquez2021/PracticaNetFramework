using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NET_Framework.Dominio
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public DateTime CreationDate { get; set; }
        public int SaleNumber { get; set; }
        public bool IsClosed { get; set; }
        [NotMapped]
        public long TotalSale { get; set; }

        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

    }
}