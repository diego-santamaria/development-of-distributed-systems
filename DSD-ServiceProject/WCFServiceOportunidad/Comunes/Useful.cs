using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFServiceOportunidad.Comunes
{
    public class Useful
    {
        public static void ReleaseComObject(object oObject)
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

        public static String isText(Object textoOrigen)
        {
            if (textoOrigen == null)
            {
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
    }
}