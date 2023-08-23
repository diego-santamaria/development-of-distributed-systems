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
using TomaPedidos.Bean;

namespace TomaPedidos.View
{
    public partial class frmActividadesRelacionadas : Form
    {
        private FrmConversiones objfrmConversiones;
        public frmActividadesRelacionadas(FrmConversiones objfrm)
        {
            InitializeComponent();
            this.objfrmConversiones = objfrm;
            listarAtividades(objfrmConversiones.txtClientCode.Text, objfrmConversiones.txtCodigoSAPoffer.Text);

        }

        private void listarAtividades(string CardCode, string DocEntry)
        {
            ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
            activityBindingSource.DataSource = servicio.BusquedaActividadesList(CardCode, DocEntry);
        }

        private void frmActividadesRelacionadas_Load(object sender, EventArgs e)
        {
            evaluarDataGridView();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvActivities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (dgvActivities.CurrentRow != null)
            //    {

            //        this.btnActivity.Image = global::TomaPedidosAGN.Properties.Resources.img_check;
            //        this.btnActivity.Text = "Elegir";
            //    }
            //    else
            //    {
            //        this.btnActivity.Image = global::TomaPedidosAGN.Properties.Resources.img_bell_plus;
            //        this.btnActivity.Text = "Agregar Actividad";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Useful.ShowErrorMsg(ex);
            //}
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            try
            {
                frmActividadRegistro objAct = new frmActividadRegistro(objfrmConversiones);
                //if (btnActivity.Text.StartsWith("Agregar"))
                //{                    
                objAct.ShowDialog();
                listarAtividades(objfrmConversiones.txtClientCode.Text, objfrmConversiones.txtCodigoSAPoffer.Text);
                //}
                //else
                //{
                //    objAct.cargarActividad((ServicioTomaPedidos.Activity)activityBindingSource.Current);
                //    objAct.ShowDialog();
                //}
                evaluarDataGridView();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void dgvActivities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvActivities.CurrentRow != null)
                {
                    frmActividadRegistro objAct = new frmActividadRegistro(objfrmConversiones);
                    objAct.cargarActividad(new ServicioTomaPedidos.ServicioTomaPedidos().ObtenerActividad(int.Parse(((ServicioTomaPedidos.Activities)activityBindingSource.Current).NumActividad)));
                    objAct.ShowDialog();
                    listarAtividades(objfrmConversiones.txtClientCode.Text, objfrmConversiones.txtCodigoSAPoffer.Text);
                }
                evaluarDataGridView();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void evaluarDataGridView()
        {
            if (dgvActivities.RowCount > 0)
            {
                lblInformar.Visible = false;
                btnElegirActividad.Enabled = true;
            }
            else
            {
                lblInformar.Visible = true;
                btnElegirActividad.Enabled = false;
            }
        }

        private void btnElegirActividad_Click(object sender, EventArgs e)
        {
            try
            {
                frmActividadRegistro objAct = new frmActividadRegistro(objfrmConversiones);
                var asdf = (ServicioTomaPedidos.Activities)activityBindingSource.Current;
                objAct.cargarActividad((ServicioTomaPedidos.Activities)activityBindingSource.Current);
                objAct.ShowDialog();

                evaluarDataGridView();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void chkVisualizarPendientes_CheckedChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = activityBindingSource;
            if (!chkVisualizarPendientes.Checked)
            {
                //Visualizar pendientes
                //activityBindingSource.Filter = dgvActivities.Columns[6].HeaderText.ToString() + "LIKE 'No iniciado'";
                //(dgvActivities.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Estado] = '{0}'", "No iniciado");
                bs.Filter = dgvActivities.Columns[5].HeaderText.ToString() + " LIKE 'No iniciado'";
            }
            else
            {
                //Visualizar todo
                //activityBindingSource.Filter = dgvActivities.Columns[6].HeaderText.ToString() + "LIKE ''";
                //(dgvActivities.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Estado] = '{0}'", "");
                bs.Filter = dgvActivities.Columns[5].HeaderText.ToString() + " LIKE 'Cerrado'";
            }
            dgvActivities.DataSource = bs.DataSource;
            //dgvActivities.DataBindings = bs.DataSource;
        }
    }
}
