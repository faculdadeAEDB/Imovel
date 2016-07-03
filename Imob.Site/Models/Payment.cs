using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Imob.Site.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public string DataPagament { get; set; }
        public Rent Alguel { get; set; }

        public ICollection<Fee> Taxas { get; set; }

    }
}