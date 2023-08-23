using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidos.Bean
{
    public class BusinessPartner
    {
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string LicTradNum { get; set; } //Documento
        public string Telephone1 { get; set; }
        public string Email { get; set; }
        public string Telephone2 { get; set; }
        public string Cellular { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string CardForeignName { get; set; }

        public string Nombres { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public string TipoDoc { get; set; }
        public string TipoPer { get; set; }

        public string ContctPrsn { get; set; }
    }
}
