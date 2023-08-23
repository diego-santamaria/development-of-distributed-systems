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

namespace TomaPedidos.View
{
    public partial class frmOportunidades : Form
    {
        public frmOportunidades()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Useful.SuspendLayout(this);
                BuscarOportunidades();
                if(dgtOportunidades.RowCount > 0)
                {
                    lblInformar.Visible = false;
                    btnOpen.Enabled = true;
                    btnOpen.Focus();
                    if (dgtOportunidades.RowCount == 1)
                        btnOpen_Click(null, null);
                }
                else
                {
                    lblInformar.Visible = true;
                    btnOpen.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                Useful.ResumeLayout(this);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Useful.SuspendLayout(this);
                FrmConversiones objfrmConversion = new FrmConversiones();
                objfrmConversion.llenarConversion(new ServicioTomaPedidos.ServicioTomaPedidos().ObtenerOportunidad(int.Parse((( ServicioTomaPedidos.Opportunity)opportunityBindingSource.Current).OpprId)));
                //objfrmConversion.llenarConversion((TomaPedidosAGN. ServicioTomaPedidos.Opportunity)opportunityBindingSource.Current);
                Useful.ResumeLayout(this);
                objfrmConversion.Show();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void BuscarOportunidades()
        {
            ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
            opportunityBindingSource.DataSource = servicio.BusquedaOportunidadesList(txtDocNum.Text, txtCardCode.Text, txtCardName.Text, /*frmLogin.infoApp.UserSapCode*/null);
        }

        private void dgtOportunidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOpen_Click(null, null);
        }

    }
}
