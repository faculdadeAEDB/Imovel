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
    public class PropriedadeController : IPropriedadeController
    {
        private HabitationRepository repository = new HabitationRepository();
        public Habitation Editar(Habitation obj)
        {
            return repository.Editar(obj);
        }

        public Habitation Excluir(Habitation obj)
        {
            return repository.Excluir(obj);
        }

        public List<Habitation> Obter()
        {
            return repository.Obter();
        }

        public Habitation Salvar(Habitation obj)
        {
            return repository.Salvar(obj);
        }
    }
}
