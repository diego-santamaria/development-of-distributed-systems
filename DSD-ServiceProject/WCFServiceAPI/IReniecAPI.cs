using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFServiceAPI
{
    [ServiceContract]
    public interface IReniecAPI
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Consultar/{dni}", ResponseFormat = WebMessageFormat.Json)]
        Tecactus.Api.Reniec.Person Consultar(string dni);
    }
}
