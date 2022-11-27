using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NET_Framework.Dominio
{
    public class Adress
    {
        [Key]
        public int AdressId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Localidad { get; set; }
        
        [StringLength(50)]
        public string Provincia { get; set; }

        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Client Client { get; set; }
    }
}