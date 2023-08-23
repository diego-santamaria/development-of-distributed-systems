using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidos.Bean
{
    public class Activity
    {
        public string Actividad { get; set; }
        public string Tipo { get; set; }
        public string Asunto { get; set; }
        public DateTime DiaIni { get; set; }
        public DateTime DiaFin { get; set; }
        public string HoraIni { get; set; }
        public string HoraFin { get; set; }
        public string Detalle { get; set; }
        public string CodCliente { get; set; }
        public string Telefono { get; set; }
        public string Prioridad { get; set; }
        public string Repeticion { get; set; }
        public string CodDocAsocOffer { get; set; }
        public string Notas { get; set; }
        public string HandledByEmployee { get; set; }
        public bool Cerrado { get; set; }

        /* Adicionales para la lista de actividades*/
        public string NumActividad { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }

        public string SalesOpportunityId { get; set; }
    }
}
