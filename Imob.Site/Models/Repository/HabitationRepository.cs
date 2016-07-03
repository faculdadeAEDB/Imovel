using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Imob.Site.Models.Repository
{
    public class HabitationRepository : IRepository<Habitation>
    {
        public Habitation Editar(Habitation obj)
        {
            using (Context.Context c = new Context.Context())
            {
                c.Propriedade.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Habitation Excluir(Habitation obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Habitation propriedadeExcluido = c.Propriedade.Remove(obj);
                c.SaveChanges();
                return propriedadeExcluido;
            }
        }

        public List<Habitation> Obter()
        {
            using (Context.Context c = new Context.Context())
            {
                return c.Propriedade.ToList();
            }
        }

        public Habitation Salvar(Habitation obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Habitation novoPropriedade = c.Propriedade.Add(obj);
                c.SaveChanges();
                return novoPropriedade;
            }
        }
    }
}