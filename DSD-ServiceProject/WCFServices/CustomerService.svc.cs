using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Web;
using WCFServiceCliente.Dominio;
using WCFServiceCliente.Errores;
using WCFServiceCliente.Persistencia;

namespace WCFServiceCliente
{
    public class CustomerService : ICustomerService
    {
        private BusinessPartnerDAO partnerDAO = new BusinessPartnerDAO();

        public List<BusinessPartner> BuscarClientes(string cardcode, string cardname, string docnum, string telephone)
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
                return partnerDAO.ListWithParameters(
                    string.IsNullOrEmpty(cardcode) ? null : cardcode,
                    string.IsNullOrEmpty(cardname) ? null : cardname,
                    string.IsNullOrEmpty(docnum) ? null : docnum, 
                    string.IsNullOrEmpty(telephone) ? null : telephone);
            }
        }

        public BusinessPartner CrearCliente(BusinessPartner cliente)
        {
            if (partnerDAO.Get(cliente.CardCode) != null)
            {
                throw new WebFaultException<ClienteException>(
                        new ClienteException()
                        {
                            Codigo = "101",
                            Descripcion = "El código de cliente '" + cliente.CardCode + "' ya está asignado" +
                            " a un socio de negocios; indique un código de socio de negocios unívoco."
                        }, HttpStatusCode.Conflict);
            }

            return partnerDAO.Create(cliente);
        }

        public void EliminarCliente(string cardcode)
        {
            var bp = ObtenerCliente(cardcode);
            if (bp == null)
            {
                throw new WebFaultException<ClienteException>(
                       new ClienteException()
                       {
                           Codigo = "201",
                           Descripcion = "El código de cliente '" + cardcode + "' no ha sido identificado."
                       }, HttpStatusCode.Conflict);
            }
            else if (bp.Active == "Y")
            {
                throw new WebFaultException<ClienteException>(
                        new ClienteException()
                        {
                            Codigo = "401",
                            Descripcion = "Un cliente activo no puede ser eliminado."
                        }, HttpStatusCode.Conflict);
            }
            partnerDAO.Delete(cardcode);
        }

        public BusinessPartner ModificarCliente(BusinessPartner cliente)
        {
            if (partnerDAO.Get(cliente.CardCode) == null)
            {
                throw new WebFaultException<ClienteException>(
                        new ClienteException()
                        {
                            Codigo = "201",
                            Descripcion = "El código de cliente '" + cliente.CardCode + "' no ha sido identificado."
                        }, HttpStatusCode.Conflict);
            }

            return partnerDAO.Update(cliente);
        }

        public BusinessPartner ObtenerCliente(string cardcode)
        {
            return partnerDAO.Get(cardcode);
        }
    }
}
