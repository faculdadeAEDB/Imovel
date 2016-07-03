using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Imob.Site.Models.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        public Customer Editar(Customer obj)
        {
            using (Context.Context c = new Context.Context())
            {
                c.Cliente.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Customer Excluir(Customer obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Customer clienteExcluido = c.Cliente.Remove(obj);
                c.SaveChanges();
                return clienteExcluido;
            }
        }

        public List<Customer> Obter()
        {
            using (Context.Context c = new Context.Context())
            {
                return c.Cliente.ToList();
            }
        }

        public Customer Salvar(Customer obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Customer novoCliente = c.Cliente.Add(obj);
                c.SaveChanges();
                return novoCliente;
            }
        }
    }
}