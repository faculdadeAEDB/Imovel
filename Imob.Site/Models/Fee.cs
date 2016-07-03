using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Imob.Site.Models
{
    public class Fee
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }

        public Payment Pagamento { get; set; }
    }
}