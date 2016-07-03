using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Imob.Site.Models.Repository
{
    public class OwnerRepository : IRepository<Owner>
    {
        public Owner Editar(Owner obj)
        {
            using (Context.Context c = new Context.Context())
            {
                c.Proprietario.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Owner Excluir(Owner obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Owner proprietarioExcluido = c.Proprietario.Remove(obj);
                c.SaveChanges();
                return proprietarioExcluido;
            }
        }

        public List<Owner> Obter()
        {
            using (Context.Context c = new Context.Context())
            {
                return c.Proprietario.ToList();
            }
        }

        public Owner Salvar(Owner obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Owner novoProprietario = c.Proprietario.Add(obj);
                c.SaveChanges();
                return novoProprietario;
            }
        }
    }
}