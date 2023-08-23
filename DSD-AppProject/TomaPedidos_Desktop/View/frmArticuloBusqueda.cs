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
using TomaPedidos.ServicioTomaPedidos;

namespace TomaPedidos.View
{
    public partial class frmArticuloBusqueda : Form
    {
        public FrmPedidoRegistro objPedidoRegistro = null;
        private bool flagClickDGTrealizado = false;
        private string MemoCode = string.Empty, MemoName = string.Empty;
        public frmArticuloBusqueda()
        {
            InitializeComponent();
        }

        public frmArticuloBusqueda(FrmPedidoRegistro objRePe)
        {
            this.objPedidoRegistro = objRePe;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {                
                if (txtItemCode.Text.Trim().Length < 2 &&
                    txtItemName.Text.Trim().Length < 2)
                {
                    MessageBox.Show("El nombre o código a buscar debe tener 2 caracteres como mínimo.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Useful.SuspendLayout(this);
                BuscarArticulos();
                if (dgvItems.RowCount > 0)
                {
                    lblInformar.Visible = false;
                    btnSelect.Enabled = true;
                    btnSelect.Focus();
                    if (dgvItems.RowCount == 1)
                        btnSelect_Click(null, null);
                    else
                    {
                        this.Height = 429;
                        lblTotal.Text = dgvItems.RowCount.ToString();
                        lblTexto.Visible = true;
                        lblTotal.Visible = true;
                    }
                }
                else
                {
                    lblTotal.Text = dgvItems.RowCount.ToString();
                    lblInformar.Visible = true; 
                    btnSelect.Enabled = false;
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                Useful.SuspendLayout(this);
                this.objPedidoRegistro.InsertarArticuloDataGridView((Item)itemBindingSource.Current, false, -1); //-1 No darle valor
                Useful.ResumeLayout(this);
                objPedidoRegistro.dgtOrderDetails.BeginEdit(true);
                //objPedidoRegistro.dgtOrderDetails.CurrentCell = objPedidoRegistro.dgtOrderDetails[1, objPedidoRegistro.dgtOrderDetails.RowCount - 2];

                this.Close();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void BuscarArticulos()
        {
            ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
            itemBindingSource.DataSource = servicio.BusquedaArticulosList(txtItemCode.Text, txtItemName.Text, "");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txtItemCode.Text.Length < 2 &&
                        txtItemName.Text.Length < 2)
                    {
                        MessageBox.Show("El nombre o código del artículo a buscar debe tener 3 caracteres como mínimo.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Useful.SuspendLayout(this);
                    BuscarArticulos();
                    if (dgvItems.RowCount > 0)
                    {
                        lblInformar.Visible = false;
                        btnSelect.Enabled = true;
                        btnSelect.Focus();
                        if (dgvItems.RowCount == 1)
                            btnSelect_Click(null, null);
                        else
                        {
                            this.Height = 429;
                            lblTotal.Text = dgvItems.RowCount.ToString();
                            lblTexto.Visible = true;
                            lblTotal.Visible = true;
                        }
                    }
                    else
                    {
                        lblTotal.Text = dgvItems.RowCount.ToString();
                        lblInformar.Visible = true;
                        btnSelect.Enabled = false;
                    }
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

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txtItemCode.Text.Length < 2 &&
                        txtItemName.Text.Length < 2)
                    {
                        MessageBox.Show("El nombre o código del artículo a buscar debe tener 3 caracteres como mínimo.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Useful.SuspendLayout(this);
                    BuscarArticulos();
                    if (dgvItems.RowCount > 0)
                    {
                        lblInformar.Visible = false;
                        btnSelect.Enabled = true;
                        btnSelect.Focus();
                        if (dgvItems.RowCount == 1)
                            btnSelect_Click(null, null);
                        else
                        {
                            this.Height = 429;
                            lblTotal.Text = dgvItems.RowCount.ToString();
                            lblTexto.Visible = true;
                            lblTotal.Visible = true;
                        }
                    }
                    else
                    {
                        lblTotal.Text = dgvItems.RowCount.ToString();
                        lblInformar.Visible = true;
                        btnSelect.Enabled = false;
                    }
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

        private void llenarTextboxConDatosEnMemoria_Click(object sender, EventArgs e)
        {
            if(flagClickDGTrealizado)
            {
                txtItemName.Text = MemoName;
                txtItemCode.Text = MemoCode;
                flagClickDGTrealizado = false;
            }
            lblInformar.Visible = false;
        }
          
        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow != null)
                btnSelect_Click(null, null);   
        }

        private void dgvItems_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow != null)
            {
                if (!flagClickDGTrealizado)
                {
                    MemoCode = txtItemCode.Text;
                    MemoName = txtItemName.Text;
                    flagClickDGTrealizado = true;
                }

                txtItemCode.Text = dgvItems.CurrentRow.Cells[0].Value.ToString();
                txtItemName.Text = dgvItems.CurrentRow.Cells[1].Value.ToString();
            }
        }

        public Item ObtenerArticulo(string code)
        {
            try
            {
                Item[] lstItems;
                ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
                if (code == null || code.Trim().Length == 0)
                    return null;
                else
                {
                    lstItems = servicio.BusquedaArticulosList(code, null, null);
                    if (lstItems != null && lstItems.GetLength(0) > 0)
                        return lstItems.ElementAt<Item>(0);
                    else
                        return null;
                }
            }
            catch (Exception)
            {                
                throw;
            }            
        }
    }
}
