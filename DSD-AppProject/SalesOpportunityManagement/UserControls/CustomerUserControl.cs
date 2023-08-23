using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesOpportunityManagement.Enums;
using SalesOpportunityManagement.Commons;
using System.ServiceModel;

namespace SalesOpportunityManagement.UserControls
{
    public partial class CustomerUserControl : BaseUserControl
    {
        private DashboardForm dashboardForm;
        public UserControl uc;
        public OperationType ot = OperationType.ot_None;

        public CustomerUserControl(DashboardForm dashboardForm)
        {
            this.dashboardForm = dashboardForm;
            InitializeComponent();
            SetDropDownItemsDocumento();
            SetDropDownItemsPersona();
            SetModeControl(OperationType.ot_Find);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                SetModeControl(OperationType.ot_Find);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                if (!string.IsNullOrEmpty(txtClientCode.Text.Trim()) /*&& ActionBtn.Text.Contains("BUSCAR")*/ && dgtClientes.RowCount > 0)
                {
                    SetModeControl(OperationType.ot_Update);
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar un cliente antes de realizar esta operación."
                        , Properties.Resources.FullAppName
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                SetModeControl(OperationType.ot_Add);
                CmbTipoPersona_SelectionChangeCommitted(null, null);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                if (!string.IsNullOrEmpty(txtClientCode.Text.Trim()) /*&& ActionBtn.Text.Contains("BUSCAR")*/ && dgtClientes.RowCount > 0)
                {
                    SetModeControl(OperationType.ot_Delete);
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar un cliente antes de realizar esta operación."
                        , Properties.Resources.FullAppName
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void PinUpButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                if (!string.IsNullOrEmpty(txtClientCode.Text.Trim()) && ActionBtn.Text.Contains("BUSCAR") && dgtClientes.RowCount > 0)
                {

                    if (MessageBox.Show("¿Está seguro que desea fijar al cliente " + txtClientCode.Text.Trim() + "?"
                                 , Properties.Resources.FullAppName
                                 , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar un cliente antes de realizar esta operación."
                        , Properties.Resources.FullAppName
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string clave = ActionBtn.Text.Replace("CLIENTE", "").Trim();
                switch (clave)
                {
                    case "BUSCAR":
                        DoWorkBgwBuscarClientes();
                        break;
                    case "CREAR":
                        if (ValidarRegistroCliente())
                        {
                            DoWorkBgwCrearModificarCliente(OperationType.ot_Add);
                        }
                        break;
                    case "ACTUALIZAR":
                        if (MessageBox.Show("¿Está seguro que desea actualizar al cliente " + txtClientCode.Text.Trim() + "?"
                            , Properties.Resources.FullAppName
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DoWorkBgwCrearModificarCliente(OperationType.ot_Update);
                        }
                        break;
                    case "ELIMINAR":
                        if (MessageBox.Show("¿Está seguro que desea eliminar al cliente " + txtClientCode.Text.Trim() + "? " + Environment.NewLine 
                            + "Esta operación no se podrá deshacer."
                            , Properties.Resources.FullAppName
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DoWorkBgwEliminarCliente();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void DoWorkBgwEliminarCliente()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;

            string ClientCode = string.Empty;

            try
            {
                ClientCode = txtClientCode.Text;

                this.Cursor = Cursors.WaitCursor;  
                this.SuspendLayout();
                CustomerInfoPanel.Enabled = false;

                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        proxy.EliminarCliente(txtClientCode.Text.Trim());
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        proxy.Close();
                    }
                };
                worker.RunWorkerCompleted += (sender, e) =>
                {                    
                    CustomerInfoPanel.Enabled = true;
                    this.Cursor = Cursors.Default;

                    if (e.Error != null)
                    {
                        Useful.ShowErrorMsg(e.Error, ExceptionType.et_EntityException);
                    }
                    else
                    {
                        MessageBox.Show("El cliente " + txtClientCode.Text.Trim() + " ha sido eliminado satisfactoriamente."
                                       , Properties.Resources.FullAppName
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        bussinesPartnerBindingSource.DataSource = null;
                        lblInformar.Visible = true;
                        SetModeControl(OperationType.ot_Delete, BeforeAction: false);
                    }
                    ResumeLayout();
                };
                worker.RunWorkerAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DoWorkBgwCrearModificarCliente(OperationType operationType)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;
            OfertaVentaWS.BusinessPartner objCliente =  null;
            string sResult = string.Empty;

            try
            {
                this.SuspendLayout();
                CustomerInfoPanel.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                objCliente = new OfertaVentaWS.BusinessPartner();
                switch (operationType)
                {
                    case OperationType.ot_Add:
                        objCliente.CardCode = "C" + txtClientDoc.Text.Trim();
                        objCliente.Active = "Y";
                        break;
                    case OperationType.ot_Update:
                        objCliente.CardCode = txtClientCode.Text.Trim();
                        objCliente.Active = ActiveChk.Checked ? "Y" : "N";
                        break;
                    case OperationType.ot_Delete:
                        break;
                    default:
                        break;
                }

                objCliente.CardName = string.IsNullOrEmpty(txtRazonSocial.Text) || txtRazonSocial.Enabled == false ? txtNombres.Text.ToUpper() + " " + txtApePaterno.Text.ToUpper().Trim() + " " + txtApeMaterno.Text.ToUpper().Trim() : txtRazonSocial.Text.ToUpper();
               
                objCliente.LicTradNum = txtClientDoc.Text.Trim();
                objCliente.Address = txtDireccion.Text;
                objCliente.Notes = txtNotas.Text;

                objCliente.Cellular = txtCelular.Text.Trim();
                objCliente.Telephone1 = txtTelf1.Text.Trim();
                objCliente.Telephone2 = txtTelf2.Text.Trim();
                objCliente.Email = txtEmail.Text.Trim();

                string cntctPrsn = (string.IsNullOrEmpty(txtPersonaContact.Text) || txtPersonaContact.Enabled == false ? objCliente.CardName : txtPersonaContact.Text.ToUpper());
                if (cntctPrsn.Length > 35) cntctPrsn = cntctPrsn.Substring(0, 35);
                objCliente.ContctPrsn = cntctPrsn;

                objCliente.TipoPer = ((cmbTipoPersona.SelectedValue == null || cmbTipoPersona.SelectedValue.ToString() == "") ? "" : cmbTipoPersona.SelectedValue.ToString());
                objCliente.TipoDoc = ((cmbTipoDoc.SelectedValue == null || cmbTipoDoc.SelectedValue.ToString() == "") ? "" : cmbTipoDoc.SelectedValue.ToString());
                objCliente.Nombres = txtNombres.Text.ToUpper().Trim();
                objCliente.ApellidoPat = txtApePaterno.Text.ToUpper().Trim();
                objCliente.ApellidoMat = txtApeMaterno.Text.ToUpper().Trim();


                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        switch (operationType)
                        {
                            case OperationType.ot_Add:
                                sResult = proxy.RegistrarCliente(objCliente);
                                break;
                            case OperationType.ot_Update:
                                sResult = proxy.ActualizarCliente(objCliente);
                                break;
                            case OperationType.ot_Delete:
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        proxy.Close();
                    }                    
                };
                worker.RunWorkerCompleted += (sender, e) =>
                {
                    try
                    {
                        this.Cursor = Cursors.Default;
                        if (e.Error != null)
                        {
                            Useful.ShowErrorMsg(e.Error, ExceptionType.et_EntityException);
                        }
                        else
                        {
                            if (sResult.Equals("OK"))
                            {
                                txtClientCode.Text = objCliente.CardCode;
                                switch (operationType)
                                {
                                    case OperationType.ot_Add:
                                        MessageBox.Show("El cliente " + objCliente.CardName + " se registró satisfactoriamente."
                                            , Properties.Resources.FullAppName
                                            , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        DoWorkBgwBuscarClientes();
                                        break;
                                    case OperationType.ot_Update:
                                        MessageBox.Show("El cliente " + objCliente.CardName + " ha sido actualizado satisfactoriamente."
                                        , Properties.Resources.FullAppName
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    case OperationType.ot_Delete:
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show(sResult, Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        CustomerInfoPanel.Enabled = true;
                        this.ResumeLayout();
                    }
                };
                worker.RunWorkerAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
               
        private void DoWorkBgwBuscarClientes()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;
            OfertaVentaWS.BusinessPartner[] businessPartners = null;

            string ClientCode = string.Empty
                , RazonSocial = string.Empty
                , ClientDoc = string.Empty
                , Celular = string.Empty;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                ClientCode = txtClientCode.Text;
                RazonSocial = txtRazonSocial.Text;
                ClientDoc = txtClientDoc.Text;
                Celular = txtCelular.Text;

                this.SuspendLayout();
                CustomerInfoPanel.Enabled = false;
                
                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        businessPartners = proxy.BusquedaClienteList(txtClientCode.Text, txtRazonSocial.Text, txtClientDoc.Text, txtCelular.Text);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        proxy.Close();
                    }
                };
                worker.RunWorkerCompleted += (sender, e) =>
                {
                    bussinesPartnerBindingSource.DataSource = businessPartners;
                    CustomerInfoPanel.Enabled = true;
                    this.Cursor = Cursors.Default;
                    
                    if (e.Error != null)
                    {
                        Useful.ShowErrorMsg(e.Error, ExceptionType.et_EntityException);
                    }
                    else
                    {
                        if (dgtClientes.RowCount > 0)
                        {
                            lblInformar.Visible = false;
                            if (dgtClientes.RowCount == 1)
                                dgtClientes_Click(null, null);
                        }
                        else
                        {
                            lblInformar.Visible = true;
                        }
                    }
                    this.ResumeLayout();
                };
                worker.RunWorkerAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SetModeControl(OperationType operationType, bool BeforeAction = true)
        {
            switch (operationType)
            {
                case OperationType.ot_Find:

                    if (BeforeAction)
                    {
                        foreach (Control ctrl in CustomerInfoPanel.Controls)
                        {
                            ctrl.Enabled = false;
                            if (ctrl is TextBox)
                            {
                                ctrl.Text = string.Empty;
                            }
                        }

                        ActionBtn.Text = "BUSCAR CLIENTE";
                        ActionBtn.Enabled = true;
                        lblRazonSocial.Text = "Nombre / Razón social";
                        txtRazonSocial.Enabled = true;
                        txtRazonSocial.BackColor = SystemColors.Info;
                        txtClientDoc.Enabled = true;
                        txtClientDoc.BackColor = SystemColors.Info;
                        txtClientCode.Enabled = true;
                        txtClientCode.BackColor = SystemColors.Info;
                        lblCelular.Text = "Telef. fijo / Celular";
                        txtCelular.Enabled = true;
                        txtCelular.BackColor = SystemColors.Info;
                        TitleLabel.Text = "Mantenimiento de clientes";

                        ActionBtn.Focus();
                    }

                    break;
                case OperationType.ot_DialogFind:
                    if (BeforeAction)
                    {
                        foreach (Control ctrl in CustomerInfoPanel.Controls)
                        {
                            ctrl.Enabled = false;
                            if (ctrl is TextBox)
                            {
                                ctrl.Text = string.Empty;
                            }
                        }

                        ActionBtn.Text = "BUSCAR CLIENTE";
                        ActionBtn.Enabled = true;
                        lblRazonSocial.Text = "Nombre / Razón social";
                        txtRazonSocial.Enabled = true;
                        txtRazonSocial.BackColor = SystemColors.Info;
                        txtClientDoc.Enabled = true;
                        txtClientDoc.BackColor = SystemColors.Info;
                        txtClientCode.Enabled = true;
                        txtClientCode.BackColor = SystemColors.Info;
                        lblCelular.Text = "Telef. fijo / Celular";
                        txtCelular.Enabled = true;
                        txtCelular.BackColor = SystemColors.Info;
                        TitleLabel.Text = "Busqueda de clientes";

                        ControlsMenuHandler(operationType);

                        ActionBtn.Focus();
                    }
                    break;
                case OperationType.ot_Add:
                    if (BeforeAction)
                    {
                        foreach (Control ctrl in CustomerInfoPanel.Controls)
                        {
                            ctrl.Enabled = true;
                            ctrl.BackColor = SystemColors.Window;
                            if (ctrl is TextBox)
                            {
                                ctrl.Text = string.Empty;
                            }
                        }

                        txtClientCode.Enabled = false;
                        ActionBtn.Text = "CREAR CLIENTE";
                        lblRazonSocial.Text = "Razón social";
                        lblCelular.Text = "Celular";
                        ActiveChk.Checked = true;
                        ActiveChk.Enabled = false;
                        TitleLabel.Text = "Mantenimiento de clientes";
                    }

                    break;
                case OperationType.ot_Update:

                    if (BeforeAction)
                    {
                        foreach (Control ctrl in CustomerInfoPanel.Controls)
                        {
                            ctrl.Enabled = true;
                        }

                        txtClientCode.Enabled = false;
                        ActionBtn.Text = "ACTUALIZAR CLIENTE";
                        TitleLabel.Text = "Mantenimiento de clientes";
                    }

                    break;
                case OperationType.ot_Delete:
                    if (BeforeAction)
                    {
                        foreach (Control ctrl in CustomerInfoPanel.Controls)
                        {
                            ctrl.Enabled = true;
                        }

                        txtClientCode.Enabled = false;
                        ActionBtn.Text = "ELIMINAR CLIENTE";
                        TitleLabel.Text = "Mantenimiento de clientes";
                    }
                    else
                    {
                        goto case OperationType.ot_Find;
                    }
                    break;
                case OperationType.ot_Anchor:
                    break;
                default:
                    break;
            }
        }

        public void ControlsMenuHandler(OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.ot_DialogFind:
                    FindButton.Enabled = true;
                    AddButton.Enabled = false;
                    UpdButton.Enabled = false;
                    DelButton.Enabled = false;
                    PinUpButton.Enabled = false;
                    ChooseButton.Enabled = true;
                    break;
                case OperationType.ot_Find:              
                case OperationType.ot_Add:
                case OperationType.ot_Update:
                case OperationType.ot_Delete:
                case OperationType.ot_Anchor:
                    FindButton.Enabled = true;
                    AddButton.Enabled = true;
                    UpdButton.Enabled = true;
                    DelButton.Enabled = true;
                    PinUpButton.Enabled = true;
                    ChooseButton.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void CmbTipoPersona_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoPersona.SelectedValue != null)
                {
                    this.SuspendLayout();
                    EnabledViewForm(true);
                    switch (cmbTipoPersona.SelectedValue.ToString())
                    {
                        case "TPJ":
                            txtRazonSocial.Enabled = true;
                            txtPersonaContact.Enabled = true;
                            txtNombres.Enabled = false;
                            txtApeMaterno.Enabled = false;
                            txtApePaterno.Enabled = false;
                            //txtNombres.Text = string.Empty;
                            //txtApeMaterno.Text = string.Empty;
                            //txtApePaterno.Text = string.Empty;
                            cmbTipoDoc.SelectedValue = "1";
                            break;
                        case "TPN":
                            txtRazonSocial.Enabled = false;
                            txtPersonaContact.Enabled = false;
                            //txtRazonSocial.Text = string.Empty;
                            //txtPersonaContact.Text = string.Empty;
                            txtNombres.Enabled = true;
                            txtApeMaterno.Enabled = true;
                            txtApePaterno.Enabled = true;
                            cmbTipoDoc.SelectedValue = "0";
                            break;
                        default:
                            txtRazonSocial.Enabled = false;
                            txtPersonaContact.Enabled = false;
                            //txtRazonSocial.Text = string.Empty;
                            //txtPersonaContact.Text = string.Empty;
                            txtNombres.Enabled = true;
                            txtApeMaterno.Enabled = true;
                            txtApePaterno.Enabled = true;
                            cmbTipoDoc.SelectedValue = "0";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                this.ResumeLayout();
            }
        }

        private void EnabledViewForm(bool flag)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = flag;
                }
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = flag;
                }
            }
            ActionBtn.Enabled = flag;
        }

        private void SetDropDownItemsDocumento()
        {
            DataRow dr;
            DataTable dt = new DataTable("Tabla");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");


            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "DOCUMENTO NACIONAL DE IDENTIDAD(DNI)";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "0";
            dr["Descripcion"] = "OTRO TIPO DE DOCUMENTO";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "4";
            dr["Descripcion"] = "CARNET DE EXTRANJERIA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "6";
            dr["Descripcion"] = "REGISTRO ÚNICO DE CONTRIBUYENTES(RUC)";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "7";
            dr["Descripcion"] = "PASAPORTE";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "A";
            dr["Descripcion"] = "CÉDULA DIPLOMÁTICA";
            dt.Rows.Add(dr);

            cmbTipoDoc.DataSource = dt;
            cmbTipoDoc.ValueMember = "Codigo";
            cmbTipoDoc.DisplayMember = "Descripcion";
            cmbTipoDoc.Enabled = true;
        }

        private void SetDropDownItemsPersona()
        {
            DataRow dr;
            DataTable dt = new DataTable("Tabla");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");

            dr = dt.NewRow();
            dr["Codigo"] = "TPN";
            dr["Descripcion"] = "Persona natural";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "TPJ";
            dr["Descripcion"] = "Persona jurídica";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "SDN";
            dr["Descripcion"] = "Sujeto no domiciliado";
            dt.Rows.Add(dr);

            cmbTipoPersona.DataSource = dt;
            cmbTipoPersona.ValueMember = "Codigo";
            cmbTipoPersona.DisplayMember = "Descripcion";
        }
        
        private bool ValidarRegistroCliente()
        {
            
            if (cmbTipoPersona.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione el tipo de persona del cliente especificado.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (cmbTipoDoc.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione el tipo de documento del cliente.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if ((cmbTipoPersona.SelectedValue.ToString().Equals("TPJ") & cmbTipoDoc.SelectedValue.ToString().Equals("0")) ||
                    (cmbTipoPersona.SelectedValue.ToString().Equals("TPN") & cmbTipoDoc.SelectedValue.ToString().Equals("1")))
                {
                    MessageBox.Show("Especifique el tipo de documento correcto para este cliente.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()) &&
                cmbTipoPersona.SelectedValue.ToString().Equals("TPJ"))
            {
                MessageBox.Show("Por favor, indique la razón social del cliente jurídico.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txtRazonSocial, "La razón social del cliente jurídico es requerida");
                return false;
            }
            if (string.IsNullOrEmpty(txtPersonaContact.Text.Trim()) &&
                cmbTipoPersona.SelectedValue.ToString().Equals("TPJ"))
            {
                MessageBox.Show("Por favor, indique la persona de contacto para el cliente jurídico.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txtPersonaContact, "La persona de contacto del cliente jurídico es requerida");
                return false;
            }
            if ((string.IsNullOrEmpty(txtNombres.Text.Trim()) ||
                string.IsNullOrEmpty(txtApePaterno.Text.Trim()) ||
                string.IsNullOrEmpty(txtApeMaterno.Text.Trim())) &&
                cmbTipoPersona.SelectedValue.ToString().Equals("TPN"))
            {
                MessageBox.Show("Por favor, indique el nombre del cliente natural.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txtNombres, "El nombre del cliente natural es requerido");
                return false;
            }
            if (string.IsNullOrEmpty(txtClientDoc.Text.Trim()))
            {
                MessageBox.Show("Por favor, indique el número del documento del cliente.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txtClientDoc, "El número del documento del cliente especificado es requerido");
                return false;
            }
            if (string.IsNullOrEmpty(txtCelular.Text.Trim()) &&
                string.IsNullOrEmpty(txtTelf1.Text.Trim()) &&
                string.IsNullOrEmpty(txtTelf2.Text.Trim()))
            {
                MessageBox.Show("Por favor, ingrese al menos un número telefónico del cliente.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }      

            return true;
        }

        private void dgtClientes_Click(object sender, EventArgs e)
        {
            try
            {
                SuspendLayout();
                if (dgtClientes.CurrentRow != null)
                {
                    ActiveChk.Checked = dgtClientes.CurrentRow.Cells[0].Value.ToString() == "Y" ? true : false;
                    txtDireccion.Text = dgtClientes.CurrentRow.Cells[1].Value.ToString();
                    txtApeMaterno.Text = dgtClientes.CurrentRow.Cells[2].Value.ToString();
                    txtApePaterno.Text = dgtClientes.CurrentRow.Cells[3].Value.ToString();
                    txtClientCode.Text = dgtClientes.CurrentRow.Cells[4].Value.ToString();
                    txtRazonSocial.Text = dgtClientes.CurrentRow.Cells[5].Value.ToString();
                    txtCelular.Text = dgtClientes.CurrentRow.Cells[6].Value.ToString();
                    txtPersonaContact.Text = dgtClientes.CurrentRow.Cells[7].Value.ToString();
                    txtEmail.Text = dgtClientes.CurrentRow.Cells[8].Value.ToString();
                    txtClientDoc.Text = dgtClientes.CurrentRow.Cells[9].Value.ToString();
                    txtNombres.Text = dgtClientes.CurrentRow.Cells[10].Value.ToString();
                    txtNotas.Text = dgtClientes.CurrentRow.Cells[11].Value.ToString();
                    txtTelf1.Text = dgtClientes.CurrentRow.Cells[12].Value.ToString();
                    txtTelf2.Text = dgtClientes.CurrentRow.Cells[13].Value.ToString();
                    cmbTipoDoc.SelectedValue = dgtClientes.CurrentRow.Cells[14].Value.ToString();
                    cmbTipoPersona.SelectedValue = dgtClientes.CurrentRow.Cells[15].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void dgtClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgtClientes.CurrentRow != null)
                dgtClientes_Click(null, null);
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (ot == OperationType.ot_DialogFind && uc != null)
            {
                if (!string.IsNullOrEmpty(txtClientCode.Text))
                {
                    switch (uc.Name)
                    {
                        case "OpportUserControl":
                            dashboardForm.opport.SetDataClient(new OfertaVentaWS.BusinessPartner()
                            {
                                CardCode = txtClientCode.Text,
                                CardName = txtRazonSocial.Text,
                                Cellular = txtCelular.Text,
                                Telephone1 = txtTelf1.Text,
                                Telephone2 = txtTelf2.Text,
                                Email = txtEmail.Text,
                                ContctPrsn = txtPersonaContact.Text
                            });
                            dashboardForm.ShowUserControl(dashboardForm.opport);
                            break;
                        case "ActivityUserControl":
                            dashboardForm.activity.SetDataClient(new OfertaVentaWS.BusinessPartner()
                            {
                                CardCode = txtClientCode.Text,
                                CardName = txtRazonSocial.Text,
                                Cellular = txtCelular.Text,
                                Telephone1 = txtTelf1.Text,
                                Telephone2 = txtTelf2.Text,
                                Email = txtEmail.Text,
                                ContctPrsn = txtPersonaContact.Text
                            });
                            dashboardForm.ShowUserControl(dashboardForm.activity);
                            break;
                        default:
                            break;
                    }
                    
                }
                else
                {
                    switch (uc.Name)
                    {
                        case "OpportUserControl":
                            dashboardForm.opport.SetDataClient(null);
                            dashboardForm.ShowUserControl(dashboardForm.opport);
                            break;
                        case "ActivityUserControl":
                            dashboardForm.activity.SetDataClient(null);
                            dashboardForm.ShowUserControl(dashboardForm.activity);
                            break;
                        default:
                            break;
                    }

                }

            }   
        }

        private void CustomerUserControl_VisibleChanged(object sender, EventArgs e)
        {
            //if (ot != OperationType.ot_None && this.Visible)
            //{
            //    SetModeControl(ot);
            //}
        }

        private void CustomerUserControl_Leave(object sender, EventArgs e)
        {
            uc = null;
            ot = OperationType.ot_None;
        }
    }
}
