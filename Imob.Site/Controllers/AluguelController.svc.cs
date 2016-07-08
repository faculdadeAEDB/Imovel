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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AluguelController" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AluguelController.svc or AluguelController.svc.cs at the Solution Explorer and start debugging.
    public class AluguelController : IAluguelController
    {
        private RentRepository respository = new RentRepository();

        public Rent Editar(Rent obj)
        {
            return respository.Editar(obj);
        }

        public Rent Excluir(Rent obj)
        {
            return respository.Excluir(obj);
        }

        public List<Rent> Obter()
        {
            return respository.Obter();
        }

        public List<string> ObterIdEInquilinos()
        {
            List<Rent> list = Obter();
            List<string> listFormatada = new List<string>();
            foreach (var item in list)
            {
                listFormatada.Add(item.ID + " - ");
            }

            return listFormatada;
        }

        public Rent Salvar(Rent obj)
        {
            return respository.Salvar(obj);
        }
    }
}
