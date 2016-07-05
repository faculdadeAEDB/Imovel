namespace Imob.Site.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Imob.Site.Models.Repository;
    using Imob.Site.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<Imob.Site.Models.Context.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Imob.Site.Models.Context.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            /*Customer c = new Customer();
            c.Nome = "Jose";
            c.Idade = "20";
            c.Telefone = "999707070";
            c.cpf = 1234;

            CustomerRepository qualquer = (new CustomerRepository());
            qualquer.Salvar(c);*/
         }
    }
}
