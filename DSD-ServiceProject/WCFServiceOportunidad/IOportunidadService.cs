using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServiceOportunidad.Dominio;

namespace WCFServiceOportunidad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IOportunidadService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOportunidadService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Oportunidades", ResponseFormat = WebMessageFormat.Json)]
        Oportunidad CrearOportunidad(Oportunidad oportunidad);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Oportunidades?codigo={codigo}&codcliente={codcliente}&nombcliente={nombcliente}&personacontact={personacontact}"
            , ResponseFormat = WebMessageFormat.Json)]
        List<Oportunidad> BuscarOportunidads(string codigo, string codcliente, string nombcliente, string personacontact);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Oportunidades", ResponseFormat = WebMessageFormat.Json)]
        Oportunidad ModificarOportunidad(Oportunidad oportunidad);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Oportunidades?codigo={codigo}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarOportunidad(string codigo);
    }
}
