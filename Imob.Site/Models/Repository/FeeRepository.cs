using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Imob.Site.Models.Repository
{
    public class FeeRepository : IRepository<Fee>
    {
        public Fee Editar(Fee obj)
        {
            using (Context.Context c = new Context.Context())
            {
                c.Taxa.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Fee Excluir(Fee obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Fee taxaExcluido = c.Taxa.Remove(obj);
                c.SaveChanges();
                return taxaExcluido;
            }
        }

        public List<Fee> Obter()
        {
            using (Context.Context c = new Context.Context())
            {
                return c.Taxa.ToList();
            }
        }

        public Fee Obter(int id)
        {
            using (Context.Context c = new Context.Context())
            {
                return c.Taxa.Where(item => item.ID == id).First();
            }
        }

        public Fee Salvar(Fee obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Fee novoTaxa = c.Taxa.Add(obj);
                c.SaveChanges();
                return novoTaxa;
            }
        }
    }
}