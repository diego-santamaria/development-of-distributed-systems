using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.ServiceModel.Web;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using WCFServiceNotificacion.Domain;
using WCFServiceNotificacion.Errores;

namespace WCFServiceNotificacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "NotificacionesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione NotificacionesService.svc o NotificacionesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class NotificacionesService : INotificacionesService
    {
        public SMS SendSMS(SMS smsData)
        {
            MessageResource messageResource = null;
            try
            {
                TwilioClient.Init(Properties.Settings.Default.SMSAccountSid, Properties.Settings.Default.SMSAuthToken);

                messageResource = MessageResource.Create(
                    body: smsData.Message,
                    from: new Twilio.Types.PhoneNumber(Properties.Settings.Default.SMSNumberFrom),
                    to: new Twilio.Types.PhoneNumber(smsData.Number)
                );
            }
            catch (Exception ex)
            {
                throw new WebFaultException<SMSexception>(
                           new SMSexception()
                           {
                               Codigo = "-4",
                               Descripcion = ex.Message

                           }, HttpStatusCode.Conflict);
            }
            smsData.SID = messageResource.Sid;
            return smsData;
        }

        public Email SendEmail(Email email)
        {
            SendEmailAsync(email).Wait();
            email.MessageID = "200 OK";
            return email;
        }

        private async Task SendEmailAsync(Email email)
        {
            bool withAttach = false;
            MailjetRequest request = null;
            MailjetClient client = null;
            try
            {
                if (!string.IsNullOrEmpty(email.Base64Content)) withAttach = true;

                client = new MailjetClient(
                        Properties.Settings.Default.EmailApiPublicKey,
                        Properties.Settings.Default.EmailApiPrivateKey)
                {
                    Version = ApiVersion.V3_1,
                };

                if (withAttach)
                {
                    request = new MailjetRequest
                    {
                        Resource = Send.Resource,
                    }
                    .Property(Send.Messages, new JArray {
                        new JObject {
                            {"From", new JObject {
                                {"Email", email.EmailFrom},
                                {"Name", email.NameFrom}
                            }},
                            {"To", new JArray {
                                new JObject {
                                    {"Email", email.EmailTo},
                                    {"Name", email.NameTo}
                            }
                            }},
                            {"Subject", email.Subject},
                            {"TextPart", email.TextPart},
                            {"HTMLPart", email.HTMLPart /*"<h3>Dear passenger 1, welcome to Mailjet!</h3><br />May the delivery force be with you!"*/},
                            {"Attachments", new JArray {
                                new JObject {
                                    {"ContentType", email.ContentType/*"text/plain"*/},
                                    {"Filename", email.Filename/*"test.txt"*/},
                                    {"Base64Content", email.Base64Content/*"VGhpcyBpcyB5b3VyIGF0dGFjaGVkIGZpbGUhISEK"*/}
                                }
                            }}
                        }
                    });
                }
                else
                {
                    request = new MailjetRequest
                    {
                        Resource = Send.Resource,
                    }
                    .Property(Send.Messages, new JArray {
                        new JObject {
                            {"From", new JObject {
                                {"Email", email.EmailFrom},
                                {"Name", email.NameFrom}
                            }},
                            {"To", new JArray {
                                new JObject {
                                    {"Email", email.EmailTo},
                                    {"Name", email.NameTo}
                                }
                            }},
                            {"Subject", email.Subject},
                            {"TextPart", email.TextPart},
                            {"HTMLPart", email.HTMLPart/*"<h3>Dear passenger 1, welcome to Mailjet!</h3><br/>May the delivery force be with you!"*/}
                        }
                    });
                }

                MailjetResponse response = await client.PostAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    if (email.ReceiveConfirmation)
                    {
                        SendEmailAsync(new Email()
                        {
                            EmailFrom = Properties.Settings.Default.SupportEmail,
                            NameFrom = "Service Support",
                            EmailTo = email.EmailFrom,
                            NameTo = email.NameFrom,
                            Subject = "Email sent successfully to " + email.EmailTo,
                            TextPart = string.Format("Total: {0}, Count: {1}\n", response.GetTotal(), response.GetCount())
                                + response.GetData(),
                            HTMLPart = string.Format("<h3>Total:</h3> {0}<br/><h3>Count:</h3> {1}<br/>", response.GetTotal(), response.GetCount())
                                + response.GetData(),
                        }).Wait();
                    }
                }
                else
                {
                    if (email.ReceiveConfirmation)
                    {
                        SendEmailAsync(new Email()
                        {
                            EmailFrom = Properties.Settings.Default.SupportEmail,
                            NameFrom = "Service Support",
                            EmailTo = email.EmailFrom,
                            NameTo = email.NameFrom,
                            Subject = "Error during sending email to " + email.EmailTo,
                            TextPart = string.Format("StatusCode: {0}\n", response.StatusCode)
                                                + string.Format("ErrorInfo: {0}\n", response.GetErrorInfo())
                                                + string.Format("ErrorMessage: {0}\n", response.GetErrorMessage())
                                                + response.GetData(),
                            HTMLPart = string.Format("<h3>StatusCode</h3><br>{0}<br/>", response.StatusCode)
                                                + string.Format("<h3>ErrorInfo</h3><br>{0}<br/>", response.GetErrorInfo())
                                                + string.Format("<h3>ErrorMessage</h3><br>{0}<br/>", response.GetErrorMessage())
                                                + response.GetData(),
                        }).Wait();
                    }

                    throw new WebFaultException<EmailException>(
                               new EmailException()
                               {
                                   Codigo = response.StatusCode.ToString(),
                                   Descripcion = string.Format("ErrorInfo: {0}, ErrorMessage: {1}", response.GetErrorInfo(), response.GetErrorMessage())

                               }, HttpStatusCode.Conflict);

                }
            }
            catch (Exception ex)
            {
                throw new WebFaultException<EmailException>(
                           new EmailException()
                           {
                               Codigo = "-5",
                               Descripcion = ex.Message

                           }, HttpStatusCode.Conflict);
            }
        }
    }
}
