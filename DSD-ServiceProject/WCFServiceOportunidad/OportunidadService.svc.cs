using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServiceOportunidad.Dominio;
using WCFServiceOportunidad.Errores;
using WCFServiceOportunidad.Persistencia;

namespace WCFServiceOportunidad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "OportunidadService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione OportunidadService.svc o OportunidadService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class OportunidadService : IOportunidadService
    {
        private OpportunityDAO oppotDAO = new OpportunityDAO();

        public List<Oportunidad> BuscarOportunidads(string codigo, string codcliente, string nombcliente, string personacontact)
        {
            if (string.IsNullOrEmpty(codigo)
               && string.IsNullOrEmpty(codcliente)
               && string.IsNullOrEmpty(nombcliente)
               && string.IsNullOrEmpty(personacontact))
            {
                return oppotDAO.List();
            }
            else
            {
                return oppotDAO.ListWithParameters(
                    string.IsNullOrEmpty(codigo) ? null : codigo,
                    string.IsNullOrEmpty(codcliente) ? null : codcliente,
                    string.IsNullOrEmpty(nombcliente) ? null : nombcliente,
                    string.IsNullOrEmpty(personacontact) ? null : personacontact);
            }
        }

        public Oportunidad CrearOportunidad(Oportunidad oportunidad)
        {
            if (oppotDAO.Get(oportunidad.Codigo) != null)
            {
                throw new WebFaultException<OpportunityException>(
                        new OpportunityException()
                        {
                            Codigo = "101",
                            Descripcion = "El código de oportunidad '" + oportunidad.Codigo + "' ya está asignado."
                        }, HttpStatusCode.Conflict);
            }

            return oppotDAO.Create(oportunidad);
        }

        public void EliminarOportunidad(string codigo)
        {
            var bp = ObtenerOportunidad(codigo);
            if (bp == null)
            {
                throw new WebFaultException<OpportunityException>(
                       new OpportunityException()
                       {
                           Codigo = "201",
                           Descripcion = "El código de oportunidad '" + codigo + "' no ha sido identificado."
                       }, HttpStatusCode.Conflict);
            }
            else if (bp.Estado == "P")
            {
                throw new WebFaultException<OpportunityException>(
                        new OpportunityException()
                        {
                            Codigo = "401",
                            Descripcion = "Una oportunidad en proceso no puede ser eliminada."
                        }, HttpStatusCode.Conflict);
            }
            oppotDAO.Delete(codigo);
        }

        public Oportunidad ModificarOportunidad(Oportunidad oportunidad)
        {
            if (oppotDAO.Get(oportunidad.Codigo) == null)
            {
                throw new WebFaultException<OpportunityException>(
                        new OpportunityException()
                        {
                            Codigo = "201",
                            Descripcion = "El código de oportunidad '" + oportunidad.Codigo + "' no ha sido identificado."
                        }, HttpStatusCode.Conflict);
            }

            return oppotDAO.Update(oportunidad);
        }

        public Oportunidad ObtenerOportunidad(string codigo)
        {
            return oppotDAO.Get(codigo);
        }
    }
}
