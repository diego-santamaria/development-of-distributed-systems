﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceNotificacion.Errores
{
    [DataContract]
    public class SMSexception
    {
        [DataMember]
        public string Codigo { get; set; }

        [DataMember]
        public string Descripcion { get; set; }
    }
}