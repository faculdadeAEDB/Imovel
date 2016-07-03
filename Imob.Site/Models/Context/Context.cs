using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Imob.Site.Models.Context
{
    public class Context : DbContext
    {
        public DbSet<Customer> Cliente { get; set; }
        public DbSet<Fee> Taxa { get; set; }
        public DbSet<Habitation> Propriedade { get; set; }
        public DbSet<Owner> Proprietario { get; set; }
        public DbSet<Payment> Pagamento { get; set; }
        public DbSet<Rent> Aluguel { get; set; }


    }
}