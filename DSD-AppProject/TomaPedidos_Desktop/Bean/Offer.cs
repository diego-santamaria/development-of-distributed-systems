using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaPedidos.Bean
{
    public class Offer
    {
        //Artículos
        public string ItemCode { get; set; }
        public double Price { get; set; }

        //Campos de Usuario
        public string Placa { get; set; }
        public string Clase { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Carroceria { get; set; }
        public string AnoFabricacion { get; set; }
        public string NumCilMotor { get; set; }
        public string Cilindrada { get; set; }
        public string GasUtilizada { get; set; }
        public string Recorrido { get; set; }
        public string TipoCombustible { get; set; }
        public string CapTanque { get; set; }
        public string UbiTanque { get; set; }
        public string TomaCarga { get; set; }
        public string MarcaEquipoConv { get; set; }
        public string Generacion { get; set; }
        public string UsoVehiculo { get; set; }
        public string TipoComprobante { get; set; }
        public bool flagInspeccionTecnica { get; set; }
        public bool flagEsPropietario { get; set; }
        public bool flagConVehiculo { get; set; }
        public string CondicionVenta { get; set; }
        public string ComoSeEntero { get; set; }
        public string subComoSeEntero { get; set; }
        public string Observaciones { get; set; }

        //Para efectos locales
        public string CardName { get; set; }
        public string CardEmail { get; set; }
        public string CardDoc { get; set; }
        public string CardPhone { get; set; }
    }
}
