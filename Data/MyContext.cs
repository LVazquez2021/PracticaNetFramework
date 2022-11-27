using NET_Framework.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace NET_Framework.Data
{
    public class MyContext : DbContext
    {

        public MyContext() : base("Data Source=localhost; Initial Catalog=NetFramework2.0; Integrated Security=True")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Company> Companies { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesLine> SalesLines { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet <Rol>Rols { get; set; }
        public DbSet<Stock>Stocks  { get; set; }

        public DbSet<User> Users { get; set; }

    }
}