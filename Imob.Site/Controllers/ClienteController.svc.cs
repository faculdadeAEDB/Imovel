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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClienteController" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClienteController.svc or ClienteController.svc.cs at the Solution Explorer and start debugging.
    public class ClienteController : IClienteController
    {
        private CustomerRepository respository = new CustomerRepository();

        public Customer Editar(Customer obj)
        {
            return respository.Editar(obj);
        }

        public Customer Excluir(Customer obj)
        {
            return respository.Excluir(obj);
        }

        public List<Customer> Obter()
        {
            return respository.Obter();
        }

        public Customer Salvar(Customer obj)
        {
            return respository.Salvar(obj);
        }
    }
}
