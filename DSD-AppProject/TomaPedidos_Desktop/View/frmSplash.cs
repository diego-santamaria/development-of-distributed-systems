using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaPedidos.Commons;
using System.Runtime.InteropServices;

namespace TomaPedidos.View
{    
    public partial class frmSplash : Form
    {
        public static string sResultMsg = string.Empty;
        private ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
        private bool flagConexionRealizada;
        public frmSplash()
        {

            InitializeComponent();
            try
            {
                flagConexionRealizada = false;
               if(servicio.TryConnectionSBO().Equals(Constant.OK))
               {
                   sResultMsg = servicio.ObtenerVersionYServidor();

                   if (sResultMsg.StartsWith("Service"))
                   {
                       Hide();
                       frmLogin frmLog = new frmLogin();
                       frmLog.Show();
                       flagConexionRealizada = true;
                   }
                   else
                   {                      
                       Hide();
                       frmLogin frmLog = new frmLogin();
                       frmLog.Show();
                   }
               }
            } //Si cae al catch es porque el Servicio web está deshabilitado
            catch (Exception)
            {  }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            if (flagConexionRealizada) { Hide(); return; }
            MyProgressBar.Style = ProgressBarStyle.Marquee;
            MyProgressBar.MarqueeAnimationSpeed = 20;
            lblstate.Text = "Comprobando disponibilidad del Servicio Web";
        }       

        private void BackgroundWorker_TryConnectionAll()
        {
            try
            {             
                System.ComponentModel.BackgroundWorker BackWorkerConnection = new System.ComponentModel.BackgroundWorker();
                BackWorkerConnection.WorkerReportsProgress = true;
                BackWorkerConnection.DoWork += (o, parametros) =>
                {
                    sResultMsg = servicio.TryConnection();
                    if (sResultMsg.StartsWith(Constant.OK))
                    {
                        BackWorkerConnection.ReportProgress(1);
                        sResultMsg = servicio.ObtenerVersionYServidor();
                        if (sResultMsg.StartsWith("Service"))
                        {
                            BackWorkerConnection.ReportProgress(2);
                        }                        
                    }
                    
                    parametros.Result = "Nothing";
                };
                BackWorkerConnection.ProgressChanged += (o, parametros) =>
                {
                    switch (parametros.ProgressPercentage)
                    {
                        case 1:
                            lblstate.Text = "Conectando con el Cliente SBO";
                            break;
                        case 2:
                            lblstate.Text = "Conexión exitosa";
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
                        Hide();
                        frmLogin frmLog = new frmLogin();
                        frmLog.Show();  
                    }
                    else
                    {
                        Hide();
                        frmLogin frmLog = new frmLogin();
                        frmLog.Show();                        
                    }
                };
                //Se pone a funcionar la tarea
                Application.UseWaitCursor = false;
                BackWorkerConnection.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constant.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            if (flagConexionRealizada) { Hide(); return; }
            BackgroundWorker_TryConnectionAll();
        }
    }
}
