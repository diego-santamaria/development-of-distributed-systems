using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidos.Bean
{
    public class ParamsItemSelector
    {
        public string Combustible { get; set; }
        public string Generacion { get; set; }
        public string NroCilMotor { get; set; }
        public string Cilindrada { get; set; }
        public string TipoMultiValvula { get; set; }//capacidadtanque
        public string ModeloMultiValvula { get; set; }//ubicacion
        public string TipoToma { get; set; }
    }
}
