using SalesOpportunityManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesOpportunityManagement.Commons
{
    public class Useful
    {
        public static void onlyNumbers(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void onlyLetters(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
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

        public static void SuspendLayout(Form objfrm)
        {
            try
            {
                objfrm.Cursor = Cursors.WaitCursor;
                objfrm.SuspendLayout();
            }
            catch (Exception)
            { }

        }

        public static void ResumeLayout(Form objfrm)
        {
            try
            {
                objfrm.ResumeLayout();
                objfrm.Cursor = Cursors.Default;
            }
            catch (Exception)
            { }
        }

        public static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        public static void ShowErrorMsg(Exception ex, ExceptionType exceptionType = ExceptionType.et_None)
        {
            try
            {
                switch (exceptionType)
                {
                    case ExceptionType.et_None:
                        MessageBox.Show(string.Format("{0} \n\n[TargetSite]: {1}", ex.Message, ex.TargetSite.ToString()),
                                   Properties.Resources.FullAppName,
                                   MessageBoxButtons.OK/*, MessageBoxIcon.Error*/);
                        break;
                    case ExceptionType.et_FaultException:
                        FaultException fex = (FaultException)ex;
                        if (fex != null)
                        {
                            MessageBox.Show(string.Format("{0} \n\n{1}", fex.Reason, fex.Message),
                                  Properties.Resources.FullAppName,
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            goto case ExceptionType.et_None;
                        }

                        break;
                    case ExceptionType.et_EntityException:
                        FaultException<OfertaVentaWS.EntityException> fEEex = (FaultException<OfertaVentaWS.EntityException>)ex;
                        if (fEEex != null)
                        {
                            MessageBox.Show(string.Format("{0}: \n\n[{1}] {2}", fEEex.Reason, fEEex.Detail.Codigo, fEEex.Detail.Descripcion),
                                           Properties.Resources.FullAppName,
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            goto case ExceptionType.et_None;
                        }
                        break;
                    case ExceptionType.et_NotifiException:
                        FaultException<OfertaVentaWS.NotificationException> nte = (FaultException<OfertaVentaWS.NotificationException>)ex;
                        if (nte != null)
                        {
                            MessageBox.Show(string.Format("{0}: \n\n[{1}] {2}", nte.Reason, nte.Detail.Codigo, nte.Detail.Descripcion),
                                           Properties.Resources.FullAppName,
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            goto case ExceptionType.et_None;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("{0} \n\n[TargetSite]: {1}", ex.Message, ex.TargetSite.ToString()),
                                      Properties.Resources.FullAppName,
                                      MessageBoxButtons.OK/*, MessageBoxIcon.Error*/);
            }            
        }
    }
}
