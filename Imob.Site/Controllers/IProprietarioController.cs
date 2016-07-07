using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Imob.Site.Models;

namespace Imob.Site.Controllers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProprietarioController" in both code and config file together.
    [ServiceContract]
    public interface IProprietarioController
    {
        [OperationContract]
        Owner Salvar(Owner obj);

        [OperationContract]
        List<Owner> Obter();

        [OperationContract]
        Owner ObterPorId(int id);

        [OperationContract]
        Owner Editar(Owner obj);

        [OperationContract]
        Owner Excluir(Owner obj);
    }
}
