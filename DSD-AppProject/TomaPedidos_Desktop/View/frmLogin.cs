using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaPedidos.Bean;
using TomaPedidos.Commons;
using TomaPedidos.View;

namespace TomaPedidos
{
    public partial class frmLogin : Form
    {
        //public static InfoApp infoApp;
        //public static bool flagWSdisponible;
        public frmLogin()
        {
            
            InitializeComponent();

            //if (frmSplash.sResultMsg.StartsWith("Service"))
            //{
            //    btnReintentar.Visible = false;
            //    btnSignIn.Enabled = true;
            //    lblVersionWebService.ForeColor = System.Drawing.SystemColors.HotTrack;
            //    lblVersionWebService.Text = frmSplash.sResultMsg;
            //}
            //else
            //{
            //    btnReintentar.Visible = true;
            //    btnSignIn.Enabled = false;
            //    lblVersionWebService.ForeColor = System.Drawing.Color.Red;
            //    lblVersionWebService.Text = frmSplash.sResultMsg;
            //}
        }

        private void toggleViewLogin(bool flag)
        {
            txtPassw.Visible = flag;
            txtUserName.Visible = flag;
            btnSignIn.Visible = flag;
            btnConversiones.Visible = !flag;
            btnVentaEquipos.Visible = !flag;
            btnOportunidades.Visible = !flag;
            btnSalir.Visible = !flag;
            picbUser.Visible = flag;
            picbPassw.Visible = flag;
            //btnInfoApp.Visible = !flag;
            if (flag) { txtPassw.Clear(); txtUserName.Clear(); txtUserName.Focus(); }
        }

        //private void GetWebServiceVersion()
        //{
        //    ServicioTomaPedidos.ServicioTomaPedidos servicio;
        //    servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
        //    string sResultMsg = string.Empty;
        //    try
        //    {
        //        //flagWSdisponible = false;
        //        servicio.TryConnection();                
        //        sResultMsg = servicio.ObtenerVersionYServidor();
        //        if (sResultMsg.StartsWith("Service"))
        //        {
        //            btnReintentar.Visible = false;
        //            btnSignIn.Enabled = true;
        //            lblVersionWebService.ForeColor = System.Drawing.SystemColors.HotTrack;
        //            lblVersionWebService.Text = sResultMsg;
        //            //flagWSdisponible = true;
        //        }
        //        else
        //        {
        //            btnReintentar.Visible = true;
        //            btnSignIn.Enabled = false;
        //            lblVersionWebService.ForeColor = System.Drawing.Color.Red;
        //            lblVersionWebService.Text = sResultMsg;
        //        }   
        //    }
        //    catch
        //    {
        //        btnSignIn.Enabled = false;
        //        lblVersionWebService.ForeColor = System.Drawing.Color.Red;
        //        lblVersionWebService.Text = "Sin conexión con el Servicio Web";
        //        btnReintentar.Visible = true;
        //    }
        //}

        //private void BackgroundWorker_GetElements()
        //{
        //    try
        //    {
        //        flagWSdisponible = false;
        //        ServicioTomaPedidos.ServicioTomaPedidos servicio;
        //        servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
        //        System.ComponentModel.BackgroundWorker GetElementsWS = new System.ComponentModel.BackgroundWorker();
        //        GetElementsWS.DoWork += (o, parametros) =>
        //        {
        //            servicio.TryConnection();                                                        
        //            parametros.Result = "Nothing";
        //        };
        //        GetElementsWS.RunWorkerCompleted += (o, parametros) =>
        //        {
        //            if (parametros.Error != null)
        //            {//Ponemos mensaje de error
        //                btnSignIn.Enabled = false;
        //                lblVersionWebService.ForeColor = System.Drawing.Color.Red;
        //                lblVersionWebService.Text = "Sin conexión con el Servicio Web";
        //                btnReintentar.Visible = true;
        //            }
        //            else
        //            {//Ponemos mensaje de éxito
        //                string VersionServ = string.Empty;
        //                VersionServ = servicio.ObtenerVersionYServidor();
        //                if (VersionServ.StartsWith("Service"))
        //                {
        //                    btnReintentar.Visible = false;
        //                    btnSignIn.Enabled = true;
        //                    lblVersionWebService.ForeColor = System.Drawing.SystemColors.ControlText;
        //                    lblVersionWebService.Text = VersionServ;
        //                    flagWSdisponible = true;                                     
        //                }
        //                else
        //                {
        //                    btnReintentar.Visible = true;
        //                    btnSignIn.Enabled = false;
        //                    lblVersionWebService.ForeColor = System.Drawing.Color.Red;
        //                    lblVersionWebService.Text = VersionServ;
        //                }                       
        //            }
        //        };               
        //        //Se pone a funcionar la tarea
        //        Application.UseWaitCursor = false;
        //        GetElementsWS.RunWorkerAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        Useful.ShowErrorMsg(ex);
        //    }
        //}

        private bool ValidarLogin()
        {
            try
            {
                if (txtUserName.Text.Trim() == string.Empty)
                {
                    txtUserName.Focus();
                    errorProvider.SetError(txtUserName, "El nombre de usuario es requerido");
                    return false;
                }
                else if (txtPassw.Text.Trim() == string.Empty)
                {
                    txtPassw.Focus();
                    errorProvider.SetError(txtPassw, "La contraseña de usuario es requerida");
                    return false;
                }
                else
                {
                    Useful.SuspendLayout(this);
                    return new ControlAccesoWS.ControlAccesoServiceClient().ValidarAcceso(txtUserName.Text, txtPassw.Text);
                //if (!new ControlAccesoWS.ControlAccesoServiceClient().ValidarAcceso(txtUserName.Text, txtPassw.Text))
                // {
                //     errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                //     errorProvider.SetError(txtUserName, "Credenciales incorrectas");
                //     errorProvider.SetError(txtPassw, "Credenciales incorrectas");
                //     errorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                //     return false;
                // }
                // else
                // {
                //     infoApp.AppVersion = Constant.AppVersion;
                // }
                //ServicioTomaPedidos.ServicioTomaPedidos service = new ServicioTomaPedidos.ServicioTomaPedidos();
                //infoApp = Conversion.Deserialize<InfoApp>(service.ValidateLogIn(txtUserName.Text, txtPassw.Text, ""));
                //service.Dispose();

                //if (null == infoApp.Userid)
                //{
                //    errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                //    errorProvider.SetError(txtUserName, "Credenciales incorrectas");
                //    errorProvider.SetError(txtPassw, "Credenciales incorrectas");
                //    flagLoginSuccessful = false;
                //    errorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
                //}
                //else
                //{
                //    infoApp.AppVersion = Constant.AppVersion;                                                
                //}         
                }   
            }
            catch (FaultException<ControlAccesoWS.ControlAccesoException> ex)
            {
                MessageBox.Show(string.Format("{0}:{1}[{2}] {3}", ex.Message, Environment.NewLine, ex.Detail.Codigo, ex.Detail.Descripcion), Properties.Resources.FullAppName);
                return false;
            }           
            finally
            {
                Useful.ResumeLayout(this);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSignIn.Enabled == false) return;
                if (ValidarLogin())
                {
                    //infoApp.AppVersion = Constant.AppVersion;
                    toggleViewLogin(false);
                }
                else
                {
                    errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    errorProvider.SetError(txtUserName, "Credenciales incorrectas");
                    errorProvider.SetError(txtPassw, "Credenciales incorrectas");
                    errorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;                  
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.FullAppName;
            txtUserName.Focus();
            //Temporal
            txtUserName.Text = "wpaima";
            txtPassw.Text = "1234";
            btnSignIn.Focus();
        }

        private void btnConversiones_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConversiones frm = new FrmConversiones();
                frm.Show();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }           
        }

        private void btnVentaEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPedidoRegistro frm = new FrmPedidoRegistro();
                frm.Show();
            } catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                int openedForms = Application.OpenForms.Count;
                if (openedForms >= 2)
                {
                    if (openedForms == 2) {
                        toggleViewLogin(true);
                        txtUserName.Focus();
                        return;
                    }
                    Form frmCnv = null;
                    Form frmSale = null;
                    String Mensaje = openedForms == 3 ? "Existe un (1) formulario abierto todavía ¿Desea cerrarlo de todos modos?" : "Existen " + (openedForms - 2) + " formularios abiertos. ¿Desea cerrarlos de todos modos?";
                    if (MessageBox.Show(Mensaje, Properties.Resources.FullAppName,
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Useful.SuspendLayout(this);
                        for (int i = 1; i <= openedForms; i++)
                        {
                            frmCnv = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmConversiones);
                            frmSale = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmPedidoRegistro);                               
                            if (frmCnv != null)
                            {
                                frmCnv.Close();
                                frmCnv = null;
                                continue;
                            }
                            if (frmSale != null)
                            {
                                frmSale.Close();
                                frmSale = null;
                                continue;
                            }    
                        }
                        toggleViewLogin(true);
                        txtUserName.Focus();
                    }                    
                }
            } catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            { Useful.ResumeLayout(this); }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    if (MessageBox.Show("¿Está seguro que desea salir del sistema?", Properties.Resources.FullAppName,
            //           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)   
            //        e.Cancel = true;               
            //    else
            //    {
            //        Environment.Exit(0);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Useful.ShowErrorMsg(ex);
            //}
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                    txtPassw.Focus();                
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void txtPassw_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {              
                if (e.KeyChar == (char)Keys.Enter)
                    btnSignIn_Click(null, null);             
            } catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (btnSignIn.Enabled == false) return;
            try
            {
                if(txtUserName.Text.Trim() == string.Empty) {
                    errorProvider.SetError(txtUserName, "El nombre de usuario es requerido");//e.Cancel = true;
                    return;
                }
                errorProvider.SetError(txtUserName, "");
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        } 
          
        private void txtPassw_Validating(object sender, CancelEventArgs e)
        {
            if (btnSignIn.Enabled == false) return;
            try
            {
                if (txtPassw.Text.Trim() == string.Empty)
                {
                    errorProvider.SetError(txtPassw, "La contraseña de usuario es requerida"); //e.Cancel = true;
                    return;
                }
                errorProvider.SetError(txtPassw, "");
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void btnInfoApp_Click(object sender, EventArgs e)
        {
            try
            {
                //frmInfoApp frm = new frmInfoApp();
                //frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void btnReintentar_Click(object sender, EventArgs e)
        {
            lblVersionWebService.Text = "";
            lblVersionWebService.ForeColor = System.Drawing.SystemColors.HotTrack;
            BackgroundWorker_TryConnectionAll();
            //Useful.SuspendLayout(this);
            //GetWebServiceVersion();
            //Useful.ResumeLayout(this);
        }

        private void btnOportunidades_Click(object sender, EventArgs e)
        {
            try
            {
                frmOportunidades objOpor = new frmOportunidades();
                objOpor.Show();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void lblVersionWebService_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip.SetToolTip(lblVersionWebService, lblVersionWebService.Text);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void BackgroundWorker_TryConnectionAll()
        {
            try
            {
                Useful.SuspendLayout(this);
                string sResultMsg = string.Empty;
                ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
                System.ComponentModel.BackgroundWorker BackWorkerConnection = new System.ComponentModel.BackgroundWorker();
                BackWorkerConnection.WorkerReportsProgress = true;
                BackWorkerConnection.DoWork += (o, parametros) =>
                {
                    //BackWorkerConnection.ReportProgress(1);
                    sResultMsg = servicio.TryConnection();
                    if (sResultMsg.StartsWith(Constant.OK))
                    {
                        //BackWorkerConnection.ReportProgress(2);
                        sResultMsg = servicio.ObtenerVersionYServidor();
                        if (sResultMsg.StartsWith("Service"))
                        {
                            BackWorkerConnection.ReportProgress(3);
                        }
                        else
                        {
                            BackWorkerConnection.ReportProgress(4);
                        }
                    }

                    parametros.Result = "Nothing";
                };
                BackWorkerConnection.ProgressChanged += (o, parametros) =>
                {
                    switch (parametros.ProgressPercentage)
                    {
                        //case 1:
                        //    lblVersionWebService.Text = "Comprobando disponibilidad del Servicio Web...";
                        //    break;
                        //case 2:
                        //    lblVersionWebService.Text = "Conectando con el Cliente SBO...";
                        //    break;
                        case 3:
                            lblVersionWebService.Text = sResultMsg;
                            break;
                        case 4:
                            lblVersionWebService.Text = sResultMsg;
                            lblVersionWebService.ForeColor = System.Drawing.Color.Red;
                            break;
                        default:
                            break;
                    }
                };
                BackWorkerConnection.RunWorkerCompleted += (o, parametros) =>
                {
                    if (parametros.Error != null)
                    {
                        //Ponemos mensaje de error
                        sResultMsg = "Sin conexión con el Servicio Web";
                        lblVersionWebService.Text = sResultMsg;
                        lblVersionWebService.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        if (lblVersionWebService.ForeColor != System.Drawing.Color.Red)
                        {
                            btnReintentar.Visible = false;
                            btnSignIn.Enabled = true;
                        }
                        else
                        {
                            btnReintentar.Visible = true;
                            btnSignIn.Enabled = false;
                        }
                        //lblVersionWebService.Text = sResultMsg;
                        //lblVersionWebService.ForeColor = System.Drawing.SystemColors.HotTrack;
                    }
                    Useful.ResumeLayout(this);
                };
                //Se pone a funcionar la tarea
                Application.UseWaitCursor = false;
                BackWorkerConnection.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }        
    }
}
