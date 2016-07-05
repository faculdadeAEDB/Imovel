using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Imob.Site.Models;

namespace Imob.Site.Controllers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPropriedadeController" in both code and config file together.
    [ServiceContract]
    public interface IPropriedadeController
    {
        [OperationContract]
        Habitation Salvar(Habitation obj);

        [OperationContract]
        List<Habitation> Obter();

        [OperationContract]
        Habitation Editar(Habitation obj);

        [OperationContract]
        Habitation Excluir(Habitation obj);
    }
}
