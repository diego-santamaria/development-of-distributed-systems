using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WCFServiceCliente.Dominio;

namespace WCFServiceCliente
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        [WebInvoke(Method ="POST", UriTemplate ="Clientes", ResponseFormat =WebMessageFormat.Json)]
        BusinessPartner CrearCliente(BusinessPartner cliente);
        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Clientes?cardcode={cardcode}&cardname={cardname}&docnum={docnum}&telephone={telephone}"
            , ResponseFormat = WebMessageFormat.Json)]
        List<BusinessPartner> BuscarClientes(string cardcode, string cardname, string docnum, string telephone);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Clientes", ResponseFormat = WebMessageFormat.Json)]
        BusinessPartner ModificarCliente(BusinessPartner cliente);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Clientes?cardcode={cardcode}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarCliente(string cardcode);
    }
}
