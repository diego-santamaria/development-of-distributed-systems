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
    public partial class FrmClienteBusqueda : Form
    {
        private FrmPedidoRegistro objPedfrm = null;
        private FrmConversiones objConv = null;
        private bool flagClickDGTrealizado = false;
        private string MemoName = string.Empty, 
                    MemoCode = string.Empty, 
                    MemoDocNum = string.Empty;
        public FrmClienteBusqueda()
        {
            InitializeComponent();
        }

        public FrmClienteBusqueda(FrmPedidoRegistro objPedidofrm)
        {
            this.objPedfrm = objPedidofrm;
            InitializeComponent();           
        }

        public FrmClienteBusqueda(FrmConversiones objConversiones)
        {
            this.objConv = objConversiones;
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmClienteRegistro frmRegister = new frmClienteRegistro();
            try
            {
                Useful.SuspendLayout(this);
                frmRegister.ShowDialog();
                if (frmRegister.flagRegistroExitoso)
                {
                    txtClientDoc.Text = frmRegister.txtDocNumber.Text;
                    BtnSearch_Click(null, null);
                    this.Close();
                }          
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally {
                frmRegister.LimpiarFormulario();
                Useful.ResumeLayout(this); }
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public OfertaVentaWS.BusinessPartner ObtenerCliente(string code)
        {
            OfertaVentaWS.OfertaVentaServiceClient proxy = null;
            try
            {
                OfertaVentaWS.BusinessPartner[] lstClients;
                proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                if (code == null || code.Trim().Length == 0)
                    return null;
                else
                {
                    lstClients = proxy.BusquedaClienteList(code, null, null, null);
                    if (lstClients != null && lstClients.GetLength(0) > 0)
                        return lstClients.ElementAt(0);
                    else
                        return null;
                }
            }
            catch (Exception)
            {                
                throw;
            }
            finally
            {
                if (proxy != null) proxy.Close();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtClientName.Text.Length < 2 &&
                //    txtClientCode.Text.Length < 2 &&
                //    txtClientDoc.Text.Length < 2)
                //{
                //    MessageBox.Show("El nombre o código del cliente a buscar debe tener 2 caracteres como mínimo.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                Useful.SuspendLayout(this);
                BuscarClientes();
                if (dgtClientes.RowCount > 0)
                {
                    lblInformar.Visible = false;
                    btnSelect.Enabled = true;
                    btnSelect.Focus();
                    if (dgtClientes.RowCount == 1)
                        btnSelect_Click(null, null);
                    else
                    {
                        //this.Height = 360;
                        //this.Width = 629;
                        lblTotal.Text = dgtClientes.RowCount.ToString();
                        lblTexto.Visible = true;
                        lblTotal.Visible = true;
                    }
                }
                else
                {
                    lblInformar.Visible = true;
                    btnSelect.Enabled = false;
                    lblTotal.Text = dgtClientes.RowCount.ToString();
                }             
                Useful.ResumeLayout(this);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }  
        }

        private void BuscarClientes()
        {
            OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
            bussinesPartnerBindingSource.DataSource = proxy.BusquedaClienteList(txtClientCode.Text, txtClientName.Text, txtClientDoc.Text, txtClientPhone.Text);
            proxy.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try{
                Useful.SuspendLayout(this);
                if (this.objPedfrm != null)
                {
                    this.objPedfrm.InsertarCliente((OfertaVentaWS.BusinessPartner)bussinesPartnerBindingSource.Current);
                }
                else if (this.objConv != null)
                {
                    this.objConv.insertarCliente((OfertaVentaWS.BusinessPartner)bussinesPartnerBindingSource.Current);
                }
                
                Useful.ResumeLayout(this);
                objPedfrm =  null;
                objConv = null;
                this.Close();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void SearchClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txtClientName.Text.Length < 2 &&
                        txtClientCode.Text.Length < 2 &&
                        txtClientDoc.Text.Length < 2)
                    {
                        MessageBox.Show("El nombre o código del cliente a buscar debe tener 3 caracteres como mínimo.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                     Useful.SuspendLayout(this);
                     BuscarClientes();
                     if (dgtClientes.RowCount > 0)
                     {
                         btnSelect.Enabled = true;
                         btnSelect.Focus();
                         if (dgtClientes.RowCount == 1)
                             btnSelect_Click(null, null);
                         else
                         {
                             this.Height = 360;
                             //this.Width = 629;
                             lblTotal.Text = dgtClientes.RowCount.ToString();
                             lblTexto.Visible = true;
                             lblTotal.Visible = true;
                         }
                     }
                     else
                     {
                         lblTotal.Text = dgtClientes.RowCount.ToString();
                         btnSelect.Enabled = false;
                     }                        
                     Useful.ResumeLayout(this);
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void dgtClientes_DoubleClick(object sender, EventArgs e)
        {            
            if (dgtClientes.CurrentRow != null)
                btnSelect_Click(null, null);                       
        }

        private void dgtClientes_Click(object sender, EventArgs e)
        {            
            try
            {
                if (dgtClientes.CurrentRow != null)
                {
                    if (!flagClickDGTrealizado)
                    {
                        MemoCode = txtClientCode.Text;
                        MemoName = txtClientName.Text;
                        MemoDocNum = txtClientDoc.Text;
                        flagClickDGTrealizado = true;
                    }               
                    txtClientCode.Text = dgtClientes.CurrentRow.Cells[0].Value.ToString();
                    txtClientName.Text = dgtClientes.CurrentRow.Cells[1].Value.ToString();
                    txtClientDoc.Text = dgtClientes.CurrentRow.Cells[2].Value.ToString();
                    txtClientPhone.Text = dgtClientes.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void llenarTextboxConDatosEnMemoria_Click(object sender, EventArgs e)
        {
            if (flagClickDGTrealizado)
            {
                txtClientCode.Text = MemoCode;
                txtClientName.Text = MemoName;
                txtClientDoc.Text = MemoDocNum;
                flagClickDGTrealizado = false;
            }
            lblInformar.Visible = false;
        }       
    }
}
