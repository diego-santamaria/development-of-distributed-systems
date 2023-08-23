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
//using TomaPedidos.OfertaVentaWS;
//using TomaPedidos.ServicioTomaPedidos;

namespace TomaPedidos.View
{
    public partial class FrmPedidoRegistro : Form
    {
        public FrmPedidoRegistro()
        {
            InitializeComponent();
        }
        
        public void InsertarCliente(OfertaVentaWS.BusinessPartner objBp)
        {
            try
            {
                txtClientCode.Text = objBp.CardCode;
                txtClientName.Text = objBp.CardName;
                txtClientDoc.Text = objBp.LicTradNum;
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        public void InsertarArticuloDataGridView(ServicioTomaPedidos.Item objItem, bool flagInsercionManual, int fila)
        {
            if (!flagInsercionManual)
            {
                fila = dgtOrderDetails.RowCount - 2;
                dgtOrderDetails.Rows.Add();
                fila += 1;
            }
            try
            {

                dgtOrderDetails.Rows[fila].Cells[columCodigo.Name].Value = objItem.Itemcode;
                dgtOrderDetails.Rows[fila].Cells[columDescription.Name].Value = objItem.Itemdescrip;
                dgtOrderDetails.Rows[fila].Cells[columPrice.Name].Value = string.Format("{0}.00",objItem.Itemprice);
                dgtOrderDetails.Rows[fila].Cells[columCantidad.Name].Value = string.Format("{0}.00", "1");
                dgtOrderDetails.Rows[fila].Cells[columTotal.Name].Value = string.Format("{0}.00", objItem.Itemprice);

                dgtOrderDetails.Rows[fila].Cells[filaSinConfirmar.Name].Value = true;
           
                btnSave.Enabled = true;

                ActualizarDocumento();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void ConstruirDocumentoSAP(ref Bean.Order objOrden)
        {
            List<Bean.Item> objItemList = new List<Bean.Item>();
            Bean.Item objItem = null;
            try
            {
                objOrden.Cardcode = txtClientCode.Text;
                objOrden.DocDueDate = Convert.ToString(DateTime.Today);


                for (int fila = 0; fila <= dgtOrderDetails.Rows.Count - 2; fila++)
                {
                    objItem = new Bean.Item();
                    objItem.Itemcode = dgtOrderDetails.Rows[fila].Cells[columCodigo.Name].Value.ToString();
                    objItem.Itemprice = dgtOrderDetails.Rows[fila].Cells[columPrice.Name].Value.ToString();
                    objItemList.Add(objItem);
                }

                objOrden.ObjItemList = objItemList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AddSalesOrderToDataBase(Bean.Order objOrden)
        {
            try
            {
                string json, sResult;
                ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();

                json = Conversion.Serialize<Bean.Order>(objOrden);
                sResult = servicio.RegistrarOrdenDeVenta(json);
                if (sResult.Equals(Constant.OK))
                {
                    if (MessageBox.Show("Pedido registrado exitosamente ¿Desea realizar otro pedido?", Properties.Resources.FullAppName,
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        this.Close();
                    else
                        ClearData();                    //MessageBox.Show("Pedido registrado exitosamente.", Properties.Resources.FullAppName,
                    //MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(sResult, Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ClearData()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = string.Empty;
                if (ctrl is ComboBox)
                {
                    ComboBox cmbox = ctrl as ComboBox;
                    cmbox.SelectedIndex = -1;
                }                
            }
            dgtOrderDetails.Rows.Clear();
            dgtOrderDetails.Refresh();

            txtSubTotal.Clear();
            txtIGV.Clear();
            txtTotalGeneral.Clear();
            lblTotalItems.Text = "0";

            FrmSale_Load(null, null);
           
        }
        
        private void InicioHabilitarFormulario(bool flag)
        {
            btnSearchItem.Enabled = flag;
            btnSelector.Enabled = flag;
            dgtOrderDetails.Enabled = flag;
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            try
            {
                //ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
                //txtDocNum.Text = servicio.ObtenerNumeroOrden();
                dtpDuoDate.Value = DateTime.Today;
                InicioHabilitarFormulario(false);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void BtnSearchClient_Click(object sender, EventArgs e)
        {
            errorPrPedido.SetError(txtClientCode, "");
            FrmClienteBusqueda frmClient = new FrmClienteBusqueda(this);
            frmClient.ShowDialog();
            TxtClientCode_Leave(null, null);
        }

        private void BtnGenerico_Click(object sender, EventArgs e)
        {
            try
            {
                Useful.SuspendLayout(this);
                txtClientCode.Text = Constant.GenericClient;
                TxtClientCode_Leave(null, null);
                Useful.ResumeLayout(this);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void TxtClientCode_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtClientCode.Text.Trim() == string.Empty)
                {
                    errorPrPedido.SetError(txtClientCode, "El código del cliente es requerido");//e.Cancel = true;                    
                    return;
                }
                errorPrPedido.SetError(txtClientCode, "");

                OfertaVentaWS.BusinessPartner objBP;
                FrmClienteBusqueda frmClient = new FrmClienteBusqueda();
                objBP = frmClient.ObtenerCliente(txtClientCode.Text);
                if(objBP != null)
                {
                    txtClientCode.Text = objBP.CardCode;
                    txtClientDoc.Text = objBP.LicTradNum;
                    txtClientName.Text = objBP.CardName;
                    InicioHabilitarFormulario(true);
                    errorPrPedido.SetError(txtClientCode, "");
                }
                else
                {
                    txtClientCode.Text = string.Empty;
                    txtClientDoc.Text = string.Empty;
                    txtClientName.Text = string.Empty;
                    InicioHabilitarFormulario(false);
                    errorPrPedido.SetError(txtClientCode, "El código del cliente especificado es inválido");
                }
                
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }  
        }        

        private void BtnSearchItem_Click(object sender, EventArgs e)
        {
            dgtOrderDetails.ClearSelection();

            frmArticuloBusqueda frmItem = new frmArticuloBusqueda(this);
            frmItem.ShowDialog();
        }

        private void TxtItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ServicioTomaPedidos.Item objItem = null;
                    frmArticuloBusqueda frmArti = new frmArticuloBusqueda();
                    if (objItem != null)
                    {                       
                        btnSave.Enabled = true;
                    }
                    else
                    {
                        btnSave.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea registrar este pedido?", Properties.Resources.FullAppName,
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                else
                {
                    Bean.Order objOrden = new Bean.Order();
                    ConstruirDocumentoSAP(ref objOrden);
                    AddSalesOrderToDataBase(objOrden);
                    ClearData();
                    txtClientCode.Focus();
                }                
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void DgtOrderDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                string RowsNumber = (e.RowIndex + 1).ToString();
                while (RowsNumber.Length < dgtOrderDetails.RowCount.ToString().Length)
                {
                    RowsNumber = "0" + RowsNumber;
                }
                SizeF size = e.Graphics.MeasureString(RowsNumber, this.Font);
                if (dgtOrderDetails.RowHeadersWidth < Convert.ToInt32(size.Width + 20))
                {
                    dgtOrderDetails.RowHeadersWidth = Convert.ToInt32(size.Width + 20);
                }
                Brush ob = SystemBrushes.ControlText;
                e.Graphics.DrawString(RowsNumber, this.Font, ob, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
                lblTotalItems.Text = (dgtOrderDetails.RowCount - 1).ToString();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void DgtOrderDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (dgtOrderDetails.CurrentCell != null)
                {
                    int columna = dgtOrderDetails.CurrentCell.ColumnIndex;
                    int fila = dgtOrderDetails.CurrentCell.RowIndex;

                    if(dgtOrderDetails.Columns[columna].Name.Equals("columCodigo"))
                    {
                        if (Useful.isText(e.FormattedValue).Equals(Useful.isText(dgtOrderDetails.Rows[fila].Cells[columCodigo.Name].Value)))
                        {
                            dgtOrderDetails.CancelEdit();
                            return;
                        }

                        ServicioTomaPedidos.Item objItem;
                        frmArticuloBusqueda frmArti = new frmArticuloBusqueda();
                        objItem = frmArti.ObtenerArticulo(Useful.isText(e.FormattedValue));

                        InsertarArticuloDataGridView(objItem, true, fila);
                        if (objItem != null)
                        {
                            dgtOrderDetails.Rows[fila].Cells[columCodigo.Name].Value = objItem.Itemcode;
                            dgtOrderDetails.Rows[fila].Cells[columDescription.Name].Value = objItem.Itemdescrip;
                            dgtOrderDetails.Rows[fila].Cells[columPrice.Name].Value = objItem.Itemprice;
                            dgtOrderDetails.Rows[fila].Cells[filaSinConfirmar.Name].Value = true;

                            btnSave.Enabled = true;
                        }
                        else
                        {
                            dgtOrderDetails.CancelEdit();
                            btnSave.Enabled = false;
                        }

                    }   
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void EliminarFilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgtOrderDetails.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione primero una fila.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgtOrderDetails.ClearSelection();
                    return;
                }
                int fila = dgtOrderDetails.CurrentCell.RowIndex;

                if ( Convert.ToBoolean(dgtOrderDetails.Rows[fila].Cells[filaSinConfirmar.Name].Value) == false)
                {
                    MessageBox.Show("Lo sentimos, la nueva fila sin confirmar no se puede eliminar.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgtOrderDetails.ClearSelection();
                    return;
                }

                string itemName = Useful.isText(dgtOrderDetails.Rows[fila].Cells[columDescription.Name].Value);
                if (itemName.Equals(string.Empty))
                {

                }
                if (MessageBox.Show("¿Está seguro que desea eliminar el artículo: '"+ itemName +"'?", Properties.Resources.FullAppName,
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgtOrderDetails.CurrentCell != null)
                    {
                        dgtOrderDetails.Rows.RemoveAt(fila);

                    }
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void DgtOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgtOrderDetails.CurrentRow != null)
                {
                    //txtItemCode.Text = dgtOrderDetails.CurrentRow.Cells[0].Value.ToString();
                    //txtItemName.Text = dgtOrderDetails.CurrentRow.Cells[1].Value.ToString();
                    //txtItemPrice.Text = dgtOrderDetails.CurrentRow.Cells[2].Value.ToString();
                    //txtItemCode.Text = dgtOrderDetails.CurrentRow.Cells[0].Value == null ? string.Empty : dgtOrderDetails.CurrentRow.Cells[0].Value.ToString();
                    //txtItemName.Text = dgtOrderDetails.CurrentRow.Cells[1].Value == null ? string.Empty : dgtOrderDetails.CurrentRow.Cells[1].Value.ToString();
                    //txtItemPrice.Text = dgtOrderDetails.CurrentRow.Cells[2].Value == null ? string.Empty : dgtOrderDetails.CurrentRow.Cells[2].Value.ToString();

                    //if (dgtOrderDetails.CurrentRow.Cells[0].Value != null)
                    //{
                    //    gboxDetalle.Text = string.Format(" Detalle: Línea {0} ", dgtOrderDetails.CurrentRow.Index + 1);
                    //}
                    //else
                    //{
                    //    gboxDetalle.Text = " Detalle ";
                    //}
                }
                else
                {
                    //txtItemCode.Text = string.Empty;
                    //txtItemName.Text = string.Empty;
                    //txtItemPrice.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void BtnSelector_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectorArticulo objfrmSelector = new frmSelectorArticulo(this);
                objfrmSelector.ShowDialog();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void ActualizarDocumento()
        {
            Useful.SuspendLayout(this);
            try
            {
                double Subtotal = 0;
                for (int fila = 0; fila <= dgtOrderDetails.Rows.Count - 2; fila++)
                {
                    Subtotal += double.Parse(dgtOrderDetails.Rows[fila].Cells[columTotal.Name].Value.ToString());
                }

                txtSubTotal.Text = string.Format("{0}.00", Subtotal);
                txtIGV.Text = string.Format("{0}.00", Subtotal * 18 / 100);
                txtTotalGeneral.Text = string.Format("{0}.00", (Subtotal * 18 / 100) + Subtotal);
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
    }
}
