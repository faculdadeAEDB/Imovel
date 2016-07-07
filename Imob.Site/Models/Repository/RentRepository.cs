using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Imob.Site.Models.Repository
{
    public class RentRepository : IRepository<Rent>
    {
        public Rent Editar(Rent obj)
        {
            using (Context.Context c = new Context.Context())
            {
                c.Aluguel.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Rent Excluir(Rent obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Rent aluguelExcluido = c.Aluguel.Remove(obj);
                c.SaveChanges();
                return aluguelExcluido;
            }
        }

        public List<Rent> Obter()
        {
            using (Context.Context c = new Context.Context())
            {
                return c.Aluguel.ToList();
            }
        }

        public Rent Obter(int id)
        {
            using (Context.Context c = new Context.Context())
            {
                return c.Aluguel.Where(item => item.ID == id).First();
            }
        }

        public Rent Salvar(Rent obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Rent novoAluguel = c.Aluguel.Add(obj);
                c.SaveChanges();
                return novoAluguel;
            }
        }
    }
}