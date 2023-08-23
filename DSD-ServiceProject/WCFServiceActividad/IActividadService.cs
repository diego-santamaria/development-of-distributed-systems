using WCFServiceActividad.Dominio;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFServiceActividad
{
    [ServiceContract]
    public interface IActividadService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Actividades", ResponseFormat = WebMessageFormat.Json)]
        Actividad CrearActividad(Actividad actividadACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Actividades/{nActividad}", ResponseFormat = WebMessageFormat.Json)]
        Actividad ObtenerActividad(string nActividad);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Actividades", ResponseFormat = WebMessageFormat.Json)]
        Actividad ModificarActividad(Actividad actividadAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Actividades/{nActividad}/{cOportunidad}/{cCliente}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarActividad(string nActividad, string cOportunidad, string cCliente);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Actividades", ResponseFormat = WebMessageFormat.Json)]
        List<Actividad> ListarActividades();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Actividades/{cUsuario}/{cOportunidad}/{cCliente}", ResponseFormat = WebMessageFormat.Json)]
        List<Actividad> ListarActividadesPorUsuarioEstado(string cUsuario, string cOportunidad, string cCliente);
    }
}
