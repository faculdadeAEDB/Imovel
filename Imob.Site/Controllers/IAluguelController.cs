using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Imob.Site.Models;

namespace Imob.Site.Controllers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAluguelController" in both code and config file together.
    [ServiceContract]
    public interface IAluguelController
    {
        [OperationContract]
        Rent Salvar(Rent obj);

        [OperationContract]
        List<Rent> Obter();

        [OperationContract]
        Rent Editar(Rent obj);

        [OperationContract]
        Rent Excluir(Rent obj);
    }
}
