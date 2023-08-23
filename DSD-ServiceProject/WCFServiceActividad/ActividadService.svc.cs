using WCFServiceActividad.Dominio;
using WCFServiceActividad.Errores;
using WCFServiceActividad.Persistencia;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Web;

namespace WCFServiceActividad
{
    public class ActividadService : IActividadService
    {
        private ActividadDAO actividadDAO = new ActividadDAO();

        public Actividad CrearActividad(Actividad actividadACrear)
        {
            Actividad actividadExistente = actividadDAO.Obtener(actividadACrear.nActividad);
            if (actividadExistente != null)
            {
                throw new WebFaultException<ActividadException>(new ActividadException()
                {
                    Codigo = 101,
                    Descripcion = "Actividad duplicada"
                }, HttpStatusCode.Conflict);
            }

            return actividadDAO.Crear(actividadACrear);
        }

        public Actividad ObtenerActividad(string nActividad)
        {
            return actividadDAO.Obtener(nActividad);
        }

        public Actividad ModificarActividad(Actividad actividadAModificar)
        {
            Actividad actividadExistente = actividadDAO.Obtener(actividadAModificar.nActividad);

            if (actividadExistente != null)
            {
                throw new WebFaultException<ActividadException>(new ActividadException()
                {
                    Codigo = 102,
                    Descripcion = "Actividad no existe"
                }, HttpStatusCode.Conflict);
            }

            return actividadDAO.Modificar(actividadAModificar);
        }

        public void EliminarActividad(string nActividad, string coportunidad, string ccliente)
        {
            Actividad actividadExistente = actividadDAO.Obtener(nActividad);

            if (actividadExistente.sEstado != "C")
            {
                throw new WebFaultException<ActividadException>(new ActividadException()
                {
                    Codigo = 103,
                    Descripcion = "Actividad con movimientos"
                }, HttpStatusCode.Conflict);
            }

            actividadDAO.Eliminar(nActividad);
        }

        public List<Actividad> ListarActividades()
        {
            return actividadDAO.Listar();
        }

        public List<Actividad> ListarActividadesPorUsuarioEstado(string cUsuario, string cOportunidad, string cCliente)
        {
            return actividadDAO.ListarActividadesPorUsuarioEstado(cUsuario, cOportunidad, cCliente);
        }
    }
}
