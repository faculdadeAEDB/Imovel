using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Imob.Site.Models.Repository
{
    public class PaymentRepository : IRepository<Payment>
    {
        public Payment Editar(Payment obj)
        {
            using (Context.Context c = new Context.Context())
            {
                c.Pagamento.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Payment Excluir(Payment obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Payment pagamentoExcluido = c.Pagamento.Remove(obj);
                c.SaveChanges();
                return pagamentoExcluido;
            }
        }

        public List<Payment> Obter()
        {
            using (Context.Context c = new Context.Context())
            {
                return c.Pagamento.ToList();
            }
        }

        public Payment Obter(int id)
        {
            using (Context.Context c = new Context.Context())
            {
                return c.Pagamento.Where(item => item.ID == id).First();
            }
        }

        public Payment Salvar(Payment obj)
        {
            using (Context.Context c = new Context.Context())
            {
                Payment novoPagamento = c.Pagamento.Add(obj);
                c.SaveChanges();
                return novoPagamento;
            }
        }
    }
}