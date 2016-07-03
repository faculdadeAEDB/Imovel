using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Imob.Site.Models
{
    public class Habitation
    {
        public int ID { get; set; }
        public string Endereco { get; set; }
        public string Tipo { get; set; }
        public Owner Dono { get; set; }
    
        public ICollection<Rent> Algueis { get; set; }
    }
}