using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceNotificacion.Domain
{
    [DataContract]
    public class SMS
    {
        [DataMember]
        public string Number { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string SID { get; set; }
    }
}