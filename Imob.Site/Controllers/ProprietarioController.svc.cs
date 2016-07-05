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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PropriedadeController" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PropriedadeController.svc or PropriedadeController.svc.cs at the Solution Explorer and start debugging.
    public class ProprietarioController : IProprietarioController
    {
        private OwnerRepository repository = new OwnerRepository();
        public Owner Editar(Owner obj)
        {
            return repository.Editar(obj);
        }

        public Owner Excluir(Owner obj)
        {
            return repository.Excluir(obj);
        }

        public List<Owner> Obter()
        {
            return repository.Obter();
        }

        public Owner Salvar(Owner obj)
        {
            return repository.Salvar(obj);
        }
    }
}
