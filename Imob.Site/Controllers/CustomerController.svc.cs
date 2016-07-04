using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Imob.Site.Models.Repository;
using Imob.Site.Models;

namespace Imob.Site.Controllers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Customer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Customer.svc or Customer.svc.cs at the Solution Explorer and start debugging.
    public class CustomerController : ICustomerController
    {
        public List<Customer> Obter()
        {
            return (new CustomerRepository()).Obter();
        }

        public Customer Salvar(Customer obj)
        {
            return (new CustomerRepository()).Salvar(obj);
        }
    }
}
