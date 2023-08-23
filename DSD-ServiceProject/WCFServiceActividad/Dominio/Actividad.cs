using System;
using System.Runtime.Serialization;

namespace WCFServiceActividad.Dominio
{
    [DataContract]
    public class Actividad
    {
        [DataMember]
        public string nActividad { get; set; }
        [DataMember]
        public string cOportunidad { get; set; }
        [DataMember]
        public string cCliente { get; set; }
        [DataMember]
        public string dRazonSocial { get; set; }
        [DataMember]
        public string dPersonaContacto { get; set; }
        [DataMember]
        public string nTelefono { get; set; }
        [DataMember]
        public Nullable<DateTime> fInicio { get; set; }
        [DataMember]
        public Nullable<DateTime> fFin { get; set; }
        [DataMember]
        public string cTipoActividad { get; set; }
        [DataMember]
        public string cNivelPrioridad { get; set; }
        [DataMember]
        public string cTipoRepeticion { get; set; }
        [DataMember]
        public string dComentarios { get; set; }
        [DataMember]
        public string sEstado { get; set; }
        [DataMember]
        public Nullable<DateTime> fRegistro { get; set; }
        [DataMember]
        public Nullable<DateTime> fModificacion { get; set; }
        [DataMember]
        public string cUsuario { get; set; }
    }
}