using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Imob.Site.Models;

namespace Imob.Site.Controllers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClienteController" in both code and config file together.
    [ServiceContract]
    public interface IClienteController
    {
        [OperationContract]
        Customer Salvar(Customer obj);

        [OperationContract]
        List<Customer> Obter();

        [OperationContract]
        Customer Editar(Customer obj);

        [OperationContract]
        Customer Excluir(Customer obj);
    }
}
