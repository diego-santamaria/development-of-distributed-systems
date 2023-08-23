using System.Collections.Generic;
using System.ServiceModel;
using WCFServiceCliente.Dominio;
using WCFServiceCliente.Enums;
using WCFServiceCliente.Errores;
using WCFServiceCliente.Persistencia;

namespace WCFServiceCliente
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ClienteService : IClienteService
    {
        private BusinessPartnerDAO partnerDAO = new BusinessPartnerDAO();

        public BusinessPartner CrearCliente(BusinessPartner businessPartner)
        {           
            ValidarDatosCliente(businessPartner, bo_OperationType.ot_Create);

            return partnerDAO.Create(businessPartner);
        }

        public BusinessPartner ModificarCliente(BusinessPartner businessPartner)
        {
            ValidarDatosCliente(businessPartner, bo_OperationType.ot_Update);

            return partnerDAO.Update(businessPartner);
        }

        public BusinessPartner ObtenerCliente(string cardCode)
        {
            return partnerDAO.Get(cardCode);
        }

        public void EliminarCliente(string cardCode)
        {
            ValidarDatosCliente(new BusinessPartner() { CardCode = cardCode }, bo_OperationType.ot_Delete);

            partnerDAO.Delete(cardCode);
        }

        public List<BusinessPartner> ListarClientes()
        {
            return partnerDAO.List();
        }

        private void ValidarDatosCliente(BusinessPartner businessPartner, bo_OperationType bo_Operation)
        {
            if (bo_Operation == bo_OperationType.ot_Create)
            {
                if (partnerDAO.Get(businessPartner.CardCode) != null)
                {
                    throw new FaultException<RepetidoException>(
                            new RepetidoException()
                            {
                                Codigo = "101",
                                Descripcion = "El código de cliente '" + businessPartner.CardCode + "' ya está asignado" +
                                " a un socio de negocios; indique un código de socio de negocios unívoco."
                            }
                            , new FaultReason("Ha surgido un error mientras se intentaba crear el cliente"));
                }
            }
            if (bo_Operation == bo_OperationType.ot_Update)
            {
                if (partnerDAO.Get(businessPartner.CardCode) == null)
                {
                    throw new FaultException<InexistenteException>(
                            new InexistenteException()
                            {
                                Codigo = "201",
                                Descripcion = "El código de cliente '" + businessPartner.CardCode + "' no ha sido identificado."
                            }
                            , new FaultReason("Ha surgido un error mientras se intentaba actualizar el cliente"));
                }
            }
            if (bo_Operation == bo_OperationType.ot_Create || bo_Operation == bo_OperationType.ot_Update)
            {
                if (string.IsNullOrEmpty(businessPartner.LicTradNum))
                {
                    throw new FaultException<ClienteException>(
                            new ClienteException()
                            {
                                Codigo = "301",
                                Descripcion = "Debe especificar el número de documento de identificación."
                            }
                            , new FaultReason("Ha surgido un error mientras se intentaba crear/actualizar el cliente"));
                }
                else if (!long.TryParse(businessPartner.LicTradNum, out long i64))
                {
                    throw new FaultException<ClienteException>(
                            new ClienteException()
                            {
                                Codigo = "302",
                                Descripcion = "El número de documento de identificación especificado es inválido."
                            }
                            , new FaultReason("Ha surgido un error mientras se intentaba crear/actualizar el cliente"));
                }
                if (string.IsNullOrEmpty(businessPartner.CardName))
                {
                    throw new FaultException<ClienteException>(
                            new ClienteException()
                            {
                                Codigo = "303",
                                Descripcion = "Debe especificar el nombre o razón social del socio de negocio."
                            }
                            , new FaultReason("Ha surgido un error mientras se intentaba crear/actualizar el cliente"));
                }
                if (string.IsNullOrEmpty(businessPartner.TipoDoc))
                {
                    throw new FaultException<ClienteException>(
                            new ClienteException()
                            {
                                Codigo = "304",
                                Descripcion = "Debe especificar el tipo de documento."
                            }
                            , new FaultReason("Ha surgido un error mientras se intentaba crear/actualizar el cliente"));
                }
                if (string.IsNullOrEmpty(businessPartner.TipoPer))
                {
                    throw new FaultException<ClienteException>(
                            new ClienteException()
                            {
                                Codigo = "305",
                                Descripcion = "Debe especificar el tipo de persona del cliente."
                            }
                            , new FaultReason("Ha surgido un error mientras se intentaba crear/actualizar el cliente"));
                }
                else if (businessPartner.TipoPer.Equals("TPN"))
                {
                    if (string.IsNullOrEmpty(businessPartner.ApellidoPat))
                    {
                        throw new FaultException<ClienteException>(
                                new ClienteException()
                                {
                                    Codigo = "3051",
                                    Descripcion = "Debe especificar el apellido paterno/materno."
                                }
                                , new FaultReason("Ha surgido un error mientras se intentaba crear/actualizar el cliente"));
                    }
                }
                else if (businessPartner.TipoPer.Equals("TPJ"))
                {
                    if (!businessPartner.TipoDoc.Equals("6"))
                    {
                        throw new FaultException<ClienteException>(
                                new ClienteException()
                                {
                                    Codigo = "3052",
                                    Descripcion = "Para el cliente con persona jurídica, el tipo de documento debe " +
                                    "ser siempre 6 - Registro Único de Contribuyentes."
                                }
                                , new FaultReason("Ha surgido un error mientras se intentaba crear/actualizar el cliente"));
                    }
                }
                if (string.IsNullOrEmpty(businessPartner.Cellular) && string.IsNullOrEmpty(businessPartner.Telephone1) && string.IsNullOrEmpty(businessPartner.Telephone2))
                {
                    throw new FaultException<ClienteException>(
                        new ClienteException()
                        {
                            Codigo = "306",
                            Descripcion = "Debe especificar al menos un número telefónico para el contacto."
                        }
                        , new FaultReason("Ha surgido un error mientras se intentaba crear/actualizar el cliente"));
                }
                if (string.IsNullOrEmpty(businessPartner.Email))
                {
                    throw new FaultException<ClienteException>(
                        new ClienteException()
                        {
                            Codigo = "307",
                            Descripcion = "Debe especificar el correo electrónico del cliente."
                        }
                        , new FaultReason("Ha surgido un error mientras se intentaba crear/actualizar el cliente"));
                }
            }
            if (bo_Operation == bo_OperationType.ot_Delete)
            {
                var bp = ObtenerCliente(businessPartner.CardCode);
                if (bp == null)
                {
                    throw new FaultException<InexistenteException>(
                           new InexistenteException()
                           {
                               Codigo = "201",
                               Descripcion = "El código de cliente '" + businessPartner.CardCode + "' no ha sido identificado."
                           }
                           , new FaultReason("Ha surgido un error mientras se intentaba eliminar el cliente"));
                }
                else if (bp.Active == "Y")
                {
                    throw new FaultException<ClienteException>(
                            new ClienteException()
                            {
                                Codigo = "401",
                                Descripcion = "Un cliente activo no puede ser eliminado."
                            }
                            , new FaultReason("Ha surgido un error mientras se intentaba eliminar el cliente"));
                }
            }
        }

        public List<BusinessPartner> ObtenerClientes(string cardcode = null, string cardname = null, string docnum = null, string telephone = null)
        {
            if (string.IsNullOrEmpty(cardcode) 
                && string.IsNullOrEmpty(cardname)
                && string.IsNullOrEmpty(docnum)
                && string.IsNullOrEmpty(telephone))
            {
                return partnerDAO.List();
            }
            else
            {
                return partnerDAO.ListWithParameters(cardcode, cardname, docnum, telephone);
            }
        }
    }
}
