using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServiceOfertaVenta.Dominio;
using WCFServiceOfertaVenta.Errores;

namespace WCFServiceOfertaVenta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IOfertaVentaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOfertaVentaService
    {
        [OperationContract]
        List<BusinessPartner> BusquedaClienteList(string cardcode, string cardname, string docnum, string telephone);

        [OperationContract]
        [FaultContract(typeof(EntityException))]
        string RegistrarCliente(BusinessPartner businessPartner);

        [OperationContract]
        [FaultContract(typeof(EntityException))]
        string ActualizarCliente(BusinessPartner businessPartner);

        [OperationContract]
        [FaultContract(typeof(EntityException))]
        string EliminarCliente(string CardCode);

        [OperationContract]
        List<Actividad> BusquedaActividadList(string nActividad, string codOport, string codCliente, string nombCliente);

        [OperationContract]
        [FaultContract(typeof(EntityException))]
        string RegistrarActividad(Actividad actividad);

        [OperationContract]
        [FaultContract(typeof(EntityException))]
        string ActualizarActividad(Actividad actividad);

        [OperationContract]
        [FaultContract(typeof(EntityException))]
        string EliminarActividad(string nActividad, string cOportunidad, string cCliente);

        [OperationContract]
        List<Oportunidad> BusquedaOportunidadList(string codigo, string codcliente, string nombcliente, string personacontact);

        [OperationContract]
        [FaultContract(typeof(EntityException))]
        string RegistrarOportunidad(Oportunidad oportunidad);

        [OperationContract]
        [FaultContract(typeof(EntityException))]
        string ActualizarOportunidad(Oportunidad oportunidad);

        [OperationContract]
        [FaultContract(typeof(EntityException))]
        string EliminarOportunidad(string codigo);

        [OperationContract]
        [FaultContract(typeof(NotificationException))]
        string EnviarCorreoElectronico(Email email);
        
        [OperationContract]
        [FaultContract(typeof(NotificationException))]
        string EnviarMensajeTexto(SMS sms);


    }
}
