using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Imob.Site.Models;
using Imob.Site.Models.Repository;

namespace Imob.Site.Controllers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PagamentoController" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PagamentoController.svc or PagamentoController.svc.cs at the Solution Explorer and start debugging.
    public class PagamentoController : IPagamentoController
    {
        private PaymentRepository respository = new PaymentRepository();

        public Payment Editar(Payment obj)
        {
            return respository.Editar(obj);
        }

        public Payment Excluir(Payment obj)
        {
            return respository.Excluir(obj);
        }

        public List<Payment> Obter()
        {
            return respository.Obter();
        }

        public Payment Salvar(Payment obj)
        {
            return respository.Salvar(obj);
        }
    }
}
