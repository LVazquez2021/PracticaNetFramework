using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NET_Framework.Dominio
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }

        [StringLength(35)]
        public string Name { get; set; }
        [StringLength(60)]
        public string Description { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}