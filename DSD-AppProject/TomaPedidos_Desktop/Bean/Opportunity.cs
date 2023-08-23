using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidos.Bean
{
    public class Opportunity
    {
        public Offer OfertaVenta { get; set; }
        public string OpprId { get; set; }
        public string Status { get; set; }
        public string OpenDate { get; set; }
        public string Owner { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string DocEntryOffer { get; set; }
        public string PorcantajeCierre { get; set; }
    }
}
