using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceOportunidad.Dominio
{
    [DataContract]
    public class Oportunidad
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public string CodCliente { get; set; }
        [DataMember]
        public string NombreCliente { get; set; }
        [DataMember]
        public string PersonaContact { get; set; }
        [DataMember]
        public string TelefCliente { get; set; }
        [DataMember]
        public string EmailCliente { get; set; }

        [DataMember]
        public string NroPlaca { get; set; }
        [DataMember]
        public string NroSerie { get; set; }
        [DataMember]
        public string NroVIN { get; set; }
        [DataMember]
        public string NroMotor { get; set; }
        [DataMember]
        public string Marca { get; set; }
        [DataMember]
        public string Modelo { get; set; }
        [DataMember]
        public string PlacaVigente { get; set; }
        [DataMember]
        public string Anotaciones { get; set; }
    }
}