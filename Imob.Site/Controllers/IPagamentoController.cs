using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Imob.Site.Models;

namespace Imob.Site.Controllers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPagamentoController" in both code and config file together.
    [ServiceContract]
    public interface IPagamentoController
    {
        [OperationContract]
        Payment Salvar(Payment obj);

        [OperationContract]
        List<Payment> Obter();

        [OperationContract]
        Payment Editar(Payment obj);

        [OperationContract]
        Payment Excluir(Payment obj);
    }
}
