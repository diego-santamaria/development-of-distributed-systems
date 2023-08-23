using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServiceCliente.Commons
{
    public static class Useful
    {
        public static void ReleaseComObject( object oObject)
        {
            try
            {
                if (oObject != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oObject);
                }
                oObject = null;
                GC.Collect();
            }
            catch { }          
        }

        public static String isText(Object textoOrigen) {
            if (textoOrigen == null) {
                return "";
            }  
            if (textoOrigen == DBNull.Value)
            {
                return "";
            }
            return textoOrigen.ToString();
        }

        public static Double isDouble(Object textoOrigen)
        {
            if (textoOrigen == null)
            {
                return 0;
            }
            if (textoOrigen == DBNull.Value)
            {
                return 0;
            }
            if (textoOrigen.ToString().Equals(""))
            {
                return 0;
            }
            return Double.Parse(textoOrigen.ToString());
        }

        public static int isInt(Object textoOrigen)
        {
            if (textoOrigen == null)
            {
                return 0;
            }
            if (textoOrigen == DBNull.Value)
            {
                return 0;
            }
            if (textoOrigen.ToString().Equals(""))
            {
                return 0;
            }
            return int.Parse(textoOrigen.ToString());
        }

        /*
         public static string obtenerNombreActividad(SAPbobsCOM.BoActivities Activity)
        {
            var nombreActividad = "";
            switch (Activity)
            {
                case SAPbobsCOM.BoActivities.cn_Campaign:
                    nombreActividad= "Campaña";
                    break;
                case SAPbobsCOM.BoActivities.cn_Conversation:
                    nombreActividad= "Llamada telefónica";
                    break;
                case SAPbobsCOM.BoActivities.cn_Meeting:
                    nombreActividad= "Reunión";
                    break;
                case SAPbobsCOM.BoActivities.cn_Note:
                    nombreActividad= "Nota";
                    break;
                case SAPbobsCOM.BoActivities.cn_Other:
                    nombreActividad = "Otros";
                    break;
                case SAPbobsCOM.BoActivities.cn_Task:
                    nombreActividad = "Tarea";
                    break;
                default:
                    break;
            }
            return nombreActividad;
        }

        public static string obtenerNombrePrioridad(SAPbobsCOM.BoMsgPriorities Priority)
        {
            var nombrePrioridad = "";
            switch (Priority)
            {
                case SAPbobsCOM.BoMsgPriorities.pr_High:
                    nombrePrioridad = "Alto";
                    break;
                case SAPbobsCOM.BoMsgPriorities.pr_Low:
                    nombrePrioridad = "Bajo";
                    break;
                case SAPbobsCOM.BoMsgPriorities.pr_Normal:
                    nombrePrioridad = "Normal";
                    break;
                default:
                    break;
            }
            return nombrePrioridad;
        }

        public static string obtenerNombreRepiticion(SAPbobsCOM.RecurrencePatternEnum RecurrencePattern)
        {
            var nombreRepeticion = "";
            switch (RecurrencePattern)
            {
                case SAPbobsCOM.RecurrencePatternEnum.rpAnnually:
                    nombreRepeticion = "";
                    break;
                case SAPbobsCOM.RecurrencePatternEnum.rpDaily:
                    nombreRepeticion = "Diario";
                    break;
                case SAPbobsCOM.RecurrencePatternEnum.rpMonthly:
                    nombreRepeticion = "Mensual";
                    break;
                case SAPbobsCOM.RecurrencePatternEnum.rpNone:
                    nombreRepeticion = "Ninguno";
                    break;
                case SAPbobsCOM.RecurrencePatternEnum.rpWeekly:
                    nombreRepeticion = "Semanal";
                    break;
                default:
                    break;
            }
            return nombreRepeticion;
        }

        public static string obtenerNombreEstado(SAPbobsCOM.BoYesNoEnum estado)
        {
            var nombreEstado = "";
            switch (estado)
            {
                case SAPbobsCOM.BoYesNoEnum.tNO:
                    nombreEstado = "No iniciado";
                    break;
                case SAPbobsCOM.BoYesNoEnum.tYES:
                    nombreEstado = "Cerrado";
                    break;
                default:
                    break;
            }
            return nombreEstado;
        }

        public static string obtenerNombreEstadoOportunidad(SAPbobsCOM.BoSoOsStatus estado)
        {
            var nombreEstado = "";
            switch (estado)
            {
                case SAPbobsCOM.BoSoOsStatus.sos_Missed:
                    nombreEstado = "Perdido";
                    break;
                case SAPbobsCOM.BoSoOsStatus.sos_Open:
                    nombreEstado = "Abierto";
                    break;
                case SAPbobsCOM.BoSoOsStatus.sos_Sold:
                    nombreEstado = "Ganado";
                    break;
                default:
                    break;
            }
            return nombreEstado;
        }
         */
    }

}