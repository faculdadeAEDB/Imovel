using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Imob.Site.Models;

namespace Imob.Site.Controllers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITaxaController" in both code and config file together.
    [ServiceContract]
    public interface ITaxaController
    {
        [OperationContract]
        Fee Salvar(Fee obj);

        [OperationContract]
        List<Fee> Obter();

        [OperationContract]
        Fee Editar(Fee obj);

        [OperationContract]
        Fee Excluir(Fee obj);
    }
}
