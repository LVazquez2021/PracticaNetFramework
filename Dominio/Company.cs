using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace NET_Framework.Dominio
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(15)]
        public string Cuit { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [StringLength(25)]
        public string Direccion { get; set; }


    }

}