﻿using System.Runtime.Serialization;

namespace WCFServiceCliente.Errores
{
    [DataContract]
    public class RepetidoException
    {
        [DataMember]
        public string Codigo { get; set; }

        [DataMember]
        public string Descripcion { get; set; }
    }
}