using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Imob.Site.Models
{
    public class Owner
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public virtual ICollection<Habitation> Propriedades { get; set; }
    }
}