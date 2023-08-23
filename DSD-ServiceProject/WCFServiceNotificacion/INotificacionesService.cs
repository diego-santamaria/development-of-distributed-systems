using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServiceNotificacion.Domain;

namespace WCFServiceNotificacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "INotificacionesService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface INotificacionesService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SMS", ResponseFormat = WebMessageFormat.Json)]
        SMS SendSMS(SMS sms);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Email", ResponseFormat = WebMessageFormat.Json)]
        Email SendEmail(Email email);
    }
}
