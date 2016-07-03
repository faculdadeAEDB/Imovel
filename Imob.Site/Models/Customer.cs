using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Imob.Site.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int cpf { get; set; }
        public string MyProperty { get; set; }

        public ICollection<Rent> Alugueis { get; set; }
    }
}