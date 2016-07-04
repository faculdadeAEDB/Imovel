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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TaxaController" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TaxaController.svc or TaxaController.svc.cs at the Solution Explorer and start debugging.
    public class TaxaController : ITaxaController
    {
        FeeRepository repository = new FeeRepository();

        public Fee Editar(Fee obj)
        {
            return repository.Editar(obj);
        }

        public Fee Excluir(Fee obj)
        {
            return repository.Excluir(obj);
        }

        public List<Fee> Obter()
        {
            return repository.Obter();
        }

        public Fee Salvar(Fee obj)
        {
            return repository.Salvar(obj);
        }
    }
}
