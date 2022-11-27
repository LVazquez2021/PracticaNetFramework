using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NET_Framework.Dominio
{
    public class Client
    {
        [Key]
        public int ClienteId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}