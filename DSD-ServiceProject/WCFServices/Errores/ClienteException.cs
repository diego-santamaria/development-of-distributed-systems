using System.Runtime.Serialization;

namespace WCFServiceCliente.Errores
{
    [DataContract]
    public class ClienteException
    {
        [DataMember]
        public string Codigo { get; set; }

        [DataMember]
        public string Descripcion { get; set; }
    }
}