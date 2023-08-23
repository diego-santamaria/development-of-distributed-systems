using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;
using WCFServiceOfertaVenta.Dominio;
//using WCFServiceOfertaVenta.ClienteWS;
using WCFServiceOfertaVenta.Errores;

namespace WCFServiceOfertaVenta
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class OfertaVentaService : IOfertaVentaService
    {
        private static readonly string urlWSClientes = "http://localhost:58947/CustomerService.svc/Clientes";
        private static readonly string urlWSActividades = "http://localhost:8518/ActividadService.svc/Actividades";
        private static readonly string urlWSOportunidades = "http://localhost:52989/OportunidadService.svc/Oportunidades";
        private static readonly string urlWSNotificacionesSMS = "http://localhost:55656/NotificacionesService.svc/SMS";
        private static readonly string urlWSNotificacionesEMAIL = "http://localhost:55656/NotificacionesService.svc/Email";

        #region Clientes
        public List<BusinessPartner> BusquedaClienteList(string cardcode, string cardname, string docnum, string telephone)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create(string.Format("{0}?cardcode={1}&cardname={2}&docnum={3}&telephone={4}", urlWSClientes, cardcode, cardname, docnum, telephone));
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();

            List<BusinessPartner> BPBusquedaList = js.Deserialize<List<BusinessPartner>>(tramaJson);
            return BPBusquedaList;
        }

        public string RegistrarCliente(BusinessPartner businessPartner)
        {
            JavaScriptSerializer js = null;
            HttpWebResponse response = null;
            try
            {
                js = new JavaScriptSerializer();
                string postData = js.Serialize(businessPartner);
                byte[] data = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlWSClientes);
                request.Method = "POST";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";

                request.GetRequestStream().Write(data, 0, data.Length);

                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string tramaJson = reader.ReadToEnd();

                BusinessPartner bpCreated = js.Deserialize<BusinessPartner>(tramaJson);
                if (bpCreated != null && bpCreated.CardCode.Trim() == businessPartner.CardCode) return "OK";
                else return null;
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                ClienteException error = js.Deserialize<ClienteException>(tramajson);

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = error.Codigo,
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }

        public string ActualizarCliente(BusinessPartner businessPartner)
        {
            JavaScriptSerializer js = null;
            HttpWebResponse response = null;
            try
            {
                js = new JavaScriptSerializer();
                string postData = js.Serialize(businessPartner);
                byte[] data = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlWSClientes);
                request.Method = "PUT";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";

                request.GetRequestStream().Write(data, 0, data.Length);

                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string tramaJson = reader.ReadToEnd();

                BusinessPartner bpCreated = js.Deserialize<BusinessPartner>(tramaJson);
                if (bpCreated != null && bpCreated.CardCode.Trim() == businessPartner.CardCode) return "OK";
                else return null;
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                ClienteException error = js.Deserialize<ClienteException>(tramajson);

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = error.Codigo,
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }

        public string EliminarCliente(string CardCode)
        {
            JavaScriptSerializer js = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("{0}?cardcode={1}", urlWSClientes, CardCode));
                request.Method = "DELETE";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return "OK";
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                js = new JavaScriptSerializer();
                ClienteException error = js.Deserialize<ClienteException>(tramajson);

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = error.Codigo,
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }
        #endregion

        #region Actividades
        public List<Actividad> BusquedaActividadList(string nActividad, string codOport, string codCliente, string nombCliente)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create(string.Format("{0}?{1}/{2}/{3}/{4}", urlWSActividades, nActividad, codOport, codCliente, nombCliente));
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();

            List<Actividad> ActBusqList = js.Deserialize<List<Actividad>>(tramaJson);
            return ActBusqList;
        }

        public string RegistrarActividad(Actividad actividad)
        {
            JavaScriptSerializer js = null;
            HttpWebResponse response = null;
            try
            {
                js = new JavaScriptSerializer();
                string postData = js.Serialize(actividad);
                byte[] data = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlWSActividades);
                request.Method = "POST";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";

                request.GetRequestStream().Write(data, 0, data.Length);

                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string tramaJson = reader.ReadToEnd();

                Actividad actCreated = js.Deserialize<Actividad>(tramaJson);
                if (actCreated != null && actCreated.nActividad.Trim() == actCreated.nActividad) return "OK";
                else return null;
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                ActividadException error = js.Deserialize<ActividadException>(tramajson);

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = error.Codigo.ToString(),
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }

        public string ActualizarActividad(Actividad actividad)
        {
            JavaScriptSerializer js = null;
            HttpWebResponse response = null;
            try
            {
                js = new JavaScriptSerializer();
                string postData = js.Serialize(actividad);
                byte[] data = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlWSActividades);
                request.Method = "PUT";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";

                request.GetRequestStream().Write(data, 0, data.Length);

                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string tramaJson = reader.ReadToEnd();

                Actividad obj = js.Deserialize<Actividad>(tramaJson);
                if (obj != null && obj.nActividad.Trim() == actividad.nActividad) return "OK";
                else return null;
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                ActividadException error = js.Deserialize<ActividadException>(tramajson);

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = error.Codigo.ToString(),
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }

        public string EliminarActividad(string nActividad, string cOportunidad, string cCliente)
        {
            JavaScriptSerializer js = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("{0}?{1}/{2}/{3}", urlWSActividades, nActividad, cOportunidad, cCliente));
                request.Method = "DELETE";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return "OK";
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                js = new JavaScriptSerializer();
                ActividadException error = js.Deserialize<ActividadException>(tramajson);

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = error.Codigo.ToString(),
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }
        #endregion

        #region Oportunidad
        public List<Oportunidad> BusquedaOportunidadList(string codigo, string codcliente, string nombcliente, string personacontact)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
               .Create(string.Format("{0}?codigo={1}&codcliente={2}&nombcliente={3}&personacontact={4}", urlWSOportunidades, codigo, codcliente, nombcliente, personacontact));
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string tramaJson = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();

            List<Oportunidad> objList = js.Deserialize<List<Oportunidad>>(tramaJson);
            return objList;
        }

        public string RegistrarOportunidad(Oportunidad oportunidad)
        {
            JavaScriptSerializer js = null;
            HttpWebResponse response = null;
            try
            {
                js = new JavaScriptSerializer();
                string postData = js.Serialize(oportunidad);
                byte[] data = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlWSOportunidades);
                request.Method = "POST";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";

                request.GetRequestStream().Write(data, 0, data.Length);

                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string tramaJson = reader.ReadToEnd();

                Oportunidad objCreated = js.Deserialize<Oportunidad>(tramaJson);
                if (objCreated != null && objCreated.Codigo.Trim() == oportunidad.Codigo) return "OK";
                else return null;
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                OpportunityException error = js.Deserialize<OpportunityException>(tramajson);

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = error.Codigo,
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }

        public string ActualizarOportunidad(Oportunidad oportunidad)
        {
            JavaScriptSerializer js = null;
            HttpWebResponse response = null;
            try
            {
                js = new JavaScriptSerializer();
                string postData = js.Serialize(oportunidad);
                byte[] data = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlWSOportunidades);
                request.Method = "PUT";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";

                request.GetRequestStream().Write(data, 0, data.Length);

                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string tramaJson = reader.ReadToEnd();

                Oportunidad bpCreated = js.Deserialize<Oportunidad>(tramaJson);
                if (bpCreated != null && bpCreated.Codigo.Trim() == oportunidad.Codigo) return "OK";
                else return null;
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                OpportunityException error = js.Deserialize<OpportunityException>(tramajson);

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = error.Codigo,
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }

        public string EliminarOportunidad(string codigo)
        {
            JavaScriptSerializer js = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("{0}?codigo={1}", urlWSOportunidades, codigo));
                request.Method = "DELETE";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return "OK";
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                js = new JavaScriptSerializer();
                OpportunityException error = js.Deserialize<OpportunityException>(tramajson);

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = error.Codigo,
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }

        #endregion

        #region Notificaciones
        public string EnviarCorreoElectronico(Email email)
        {
            JavaScriptSerializer js = null;
            HttpWebResponse response = null;
            try
            {
                js = new JavaScriptSerializer();
                string postData = js.Serialize(email);
                byte[] data = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlWSNotificacionesEMAIL);
                request.Method = "POST";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";

                request.GetRequestStream().Write(data, 0, data.Length);

                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string tramaJson = reader.ReadToEnd();

                Email objCreated = js.Deserialize<Email>(tramaJson);
                if (objCreated != null && objCreated.MessageID.Trim() == "200 OK")
                {
                    return "OK";
                }
                else return null;
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                EmailException error = js.Deserialize<EmailException>(tramajson);

                throw new FaultException<NotificationException>(
                            new NotificationException()
                            {
                                Codigo = error.Codigo,
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }

        public string EnviarMensajeTexto(SMS sms)
        {
            JavaScriptSerializer js = null;
            HttpWebResponse response = null;
            try
            {
                js = new JavaScriptSerializer();
                string postData = js.Serialize(sms);
                byte[] data = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlWSNotificacionesSMS);
                request.Method = "POST";
                request.ContentLength = data.Length;
                request.ContentType = "application/json";

                request.GetRequestStream().Write(data, 0, data.Length);

                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string tramaJson = reader.ReadToEnd();

                SMS objCreated = js.Deserialize<SMS>(tramaJson);
                if (objCreated != null && !string.IsNullOrEmpty(objCreated.SID))
                {
                    return "OK";
                }
                else return null;
            }
            catch (WebException we)
            {
                HttpStatusCode cod = ((HttpWebResponse)we.Response).StatusCode;
                StreamReader reader = new StreamReader(we.Response.GetResponseStream());
                string tramajson = reader.ReadToEnd();

                SMSexception error = js.Deserialize<SMSexception>(tramajson);

                throw new FaultException<NotificationException>(
                            new NotificationException()
                            {
                                Codigo = error.Codigo,
                                Descripcion = error.Descripcion
                            }
                            , new FaultReason(cod.ToString()));
            }
        }


        #endregion

        #region backupSOAP
        /*
        #region MyRegion
		 public List<ClienteWS.BusinessPartner> BusquedaClienteList(string cardcode, string cardname, string docnum, string telephone)
        {
            ClienteWS.ClienteServiceClient proxy = new ClienteWS.ClienteServiceClient();
            var result = proxy.ObtenerClientes(
                string.IsNullOrEmpty(cardcode) ? null : cardcode, 
                 string.IsNullOrEmpty(cardname) ? null : cardname, 
                 string.IsNullOrEmpty(docnum) ? null : docnum,
                 string.IsNullOrEmpty(telephone) ? null : telephone
            ).ToList(); 
#endregion
        proxy.Close();
            return result;
        }

        public string RegistrarCliente(ClienteWS.BusinessPartner businessPartner)
        {
            try
            {
                ClienteWS.ClienteServiceClient proxy = new ClienteWS.ClienteServiceClient();
                ClienteWS.BusinessPartner newBP = proxy.CrearCliente(businessPartner);
                proxy.Close();

                if (newBP != null && newBP.CardCode.Trim() == businessPartner.CardCode) return "OK";
                else return null;
            }
            catch (FaultException<ClienteWS.RepetidoException> ex)
            {
                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = ex.Detail.Codigo,
                                 Descripcion = ex.Detail.Descripcion
                            }
                            , new FaultReason(ex.Reason.ToString()));

            }
            catch (FaultException<ClienteWS.ClienteException> ex)
            {
                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = ex.Detail.Codigo,
                                Descripcion = ex.Detail.Descripcion
                            }
                            , new FaultReason(ex.Reason.ToString()));
            }
            catch (Exception ex)
            {

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = ex.TargetSite.ToString(),
                                Descripcion = ex.Message
                            }
                            , new FaultReason("Se ha producido un error durante el registro del cliente"));
            }
        }

        public string ActualizarCliente(ClienteWS.BusinessPartner businessPartner)
        {
            try
            {
                ClienteWS.ClienteServiceClient proxy = new ClienteWS.ClienteServiceClient();
                ClienteWS.BusinessPartner newBP = proxy.ModificarCliente(businessPartner);
                proxy.Close();

                if (newBP != null && newBP.CardCode.Trim() == businessPartner.CardCode) return "OK";
                else return null;
            }
            catch (FaultException<ClienteWS.RepetidoException> ex)
            {
                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = ex.Detail.Codigo,
                                Descripcion = ex.Detail.Descripcion
                            }
                            , new FaultReason(ex.Reason.ToString()));

            }
            catch (FaultException<ClienteWS.ClienteException> ex)
            {
                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = ex.Detail.Codigo,
                                Descripcion = ex.Detail.Descripcion
                            }
                            , new FaultReason(ex.Reason.ToString()));
            }
            catch (Exception ex)
            {

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = ex.TargetSite.ToString(),
                                Descripcion = ex.Message
                            }
                            , new FaultReason("Se ha producido un error durante el registro del cliente"));
            }
        }

        public string EliminarCliente(string CardCode)
        {
            try
            {
                ClienteWS.ClienteServiceClient proxy = new ClienteWS.ClienteServiceClient();
                proxy.EliminarCliente(CardCode);
                proxy.Close();
                return "OK";
            }
            catch (FaultException<ClienteWS.InexistenteException> ex)
            {
                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = ex.Detail.Codigo,
                                Descripcion = ex.Detail.Descripcion
                            }
                            , new FaultReason(ex.Reason.ToString()));

            }
            catch (FaultException<ClienteWS.ClienteException> ex)
            {
                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = ex.Detail.Codigo,
                                Descripcion = ex.Detail.Descripcion
                            }
                            , new FaultReason(ex.Reason.ToString()));
            }
            catch (Exception ex)
            {

                throw new FaultException<EntityException>(
                            new EntityException()
                            {
                                Codigo = ex.TargetSite.ToString(),
                                Descripcion = ex.Message
                            }
                            , new FaultReason("Se ha producido un error durante el registro del cliente"));
            }
        }
         
         */
        #endregion
    }
}
