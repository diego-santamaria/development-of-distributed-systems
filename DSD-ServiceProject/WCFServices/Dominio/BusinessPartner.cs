using System.Runtime.Serialization;

namespace WCFServiceCliente.Dominio
{
    [DataContract]
    public class BusinessPartner
    {
        [DataMember(IsRequired = false)]
        public string Active { get; set; }
        [DataMember]
        public string ContctPrsn { get; set; }
        [DataMember]
        public string TipoPer { get; set; }
        [DataMember]
        public string TipoDoc { get; set; }
        [DataMember]
        public string ApellidoMat { get; set; }
        [DataMember]
        public string ApellidoPat { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string Notes { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Cellular { get; set; }
        [DataMember]
        public string Telephone2 { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Telephone1 { get; set; }
        [DataMember]
        public string LicTradNum { get; set; }
        [DataMember(IsRequired = true)]
        public string CardName { get; set; }
        [DataMember(IsRequired = true)]
        public string CardCode { get; set; }        
    }
}