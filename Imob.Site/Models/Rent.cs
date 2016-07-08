using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Imob.Site.Models
{
    public class Rent
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public Customer Inquilino { get; set; }
        public Owner Dono { get; set; }
        public ICollection<Payment> Pagamentos { get; set; }

    }
}