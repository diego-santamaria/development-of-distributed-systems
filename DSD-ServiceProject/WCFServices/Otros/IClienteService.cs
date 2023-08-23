using System.Collections.Generic;
using System.ServiceModel;
using WCFServiceCliente.Dominio;
using WCFServiceCliente.Errores;

namespace WCFServiceCliente
{   
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        //[FaultContract(typeof(RepetidoException))]
        [FaultContract(typeof(ClienteException))]
        BusinessPartner CrearCliente(BusinessPartner businessPartner);

        [OperationContract]
        BusinessPartner ObtenerCliente(string cardCode);

        [OperationContract]
        List<BusinessPartner> ObtenerClientes(string cardcode = null, string cardname = null, string docnum = null, string telephone = null);

        [OperationContract]
        //[FaultContract(typeof(InexistenteException))]
        [FaultContract(typeof(ClienteException))]
        BusinessPartner ModificarCliente(BusinessPartner businessPartner);

        [OperationContract]
        //[FaultContract(typeof(InexistenteException))]
        [FaultContract(typeof(ClienteException))]
        void EliminarCliente(string cardCode);
                
        //[OperationContract]
        //List<BusinessPartner> ListarClientes();
    }
}
