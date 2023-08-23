using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceOfertaVenta.Dominio
{
    [DataContract]
    public class Email
    {
        [DataMember]
        public string EmailFrom { get; set; }

        [DataMember]
        public string NameFrom { get; set; }

        [DataMember]
        public string EmailTo { get; set; }

        [DataMember]
        public string NameTo { get; set; }

        [DataMember]
        public string Subject { get; set; }

        [DataMember]
        public string TextPart { get; set; }

        [DataMember]
        public string HTMLPart { get; set; }

        [DataMember]
        public string MessageUUID { get; set; }

        [DataMember]
        public string MessageID { get; set; }

        [DataMember]
        public string MessageHref { get; set; }

        [DataMember]
        public string ContentType { get; set; }

        [DataMember]
        public string Filename { get; set; }

        [DataMember]
        public string Base64Content { get; set; }

        [DataMember]
        public bool ReceiveConfirmation { get; set; }
    }
}