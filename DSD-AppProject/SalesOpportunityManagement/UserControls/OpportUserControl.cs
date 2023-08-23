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

namespace SalesOpportunityManagement.UserControls
{
    public partial class OpportUserControl : BaseUserControl
    {
        private DashboardForm dashboardForm;
        public UserControl uc;
        private OperationType ot = OperationType.ot_None;
        public OpportUserControl(DashboardForm dashboardForm)
        {
            this.dashboardForm = dashboardForm;
            InitializeComponent();
            SetDropDownItemsEstadoOpor();
            SetModeControl(OperationType.ot_Find);
        }

        private void SetDropDownItemsEstadoOpor()
        {
            DataRow dr;
            DataTable dt = new DataTable("Tabla");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");

            dr = dt.NewRow();
            dr["Codigo"] = "0";
            dr["Descripcion"] = "Abierto";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "Creado";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "2";
            dr["Descripcion"] = "En seguimiento";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "3";
            dr["Descripcion"] = "Cerrado";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "4";
            dr["Descripcion"] = "Cancelado";
            dt.Rows.Add(dr);

            cmbEstado.DataSource = dt;
            cmbEstado.ValueMember = "Codigo";
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.Enabled = true;
        }

        private void btnFindOp_Click(object sender, EventArgs e)
        {
            dashboardForm.customer.ot = OperationType.ot_DialogFind;
            dashboardForm.customer.SetModeControl(OperationType.ot_DialogFind);
            dashboardForm.customer.uc = this;
            dashboardForm.ShowUserControl(dashboardForm.customer);
        }

        public void SetDataClient(OfertaVentaWS.BusinessPartner bp)
        {
            if (bp != null)
            {
                txtCodigoCliente.Text = bp.CardCode;
                txtNombreCliente.Text = bp.CardName;
                txtContacto.Text = bp.ContctPrsn;
                txtTelefono.Text = !string.IsNullOrEmpty(bp.Cellular) ? bp.Cellular : !string.IsNullOrEmpty(bp.Telephone1) ? bp.Telephone1 : bp.Telephone2;
                txtCorreo.Text = bp.Email; 
            }
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                SetModeControl(OperationType.ot_Add);
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
                if (!string.IsNullOrEmpty(txtCodOpportunidad.Text.Trim()) && dgtOportunidades.RowCount > 0)
                {
                    SetModeControl(OperationType.ot_Update);
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar una oportunidad antes de realizar esta operación."
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

        private void DelButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                if (!string.IsNullOrEmpty(txtCodOpportunidad.Text.Trim()) && dgtOportunidades.RowCount > 0)
                {
                    SetModeControl(OperationType.ot_Delete);
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar una oportunidad antes de realizar esta operación."
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

        private void PrioButto_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                if (!string.IsNullOrEmpty(txtCodOpportunidad.Text.Trim()) && dgtOportunidades.RowCount > 0)
                {
                    SetModeControl(OperationType.ot_Priority);
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar una oportunidad antes de realizar esta operación."
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

        private void SendEmail_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                if (!string.IsNullOrEmpty(txtCodOpportunidad.Text.Trim()) && dgtOportunidades.RowCount > 0)
                {
                    if (!string.IsNullOrEmpty(txtCorreo.Text.Trim()))
                    {
                        if (MessageBox.Show("¿Está seguro que desea enviar esta cotización por correo electrónico al cliente " + txtCodigoCliente.Text.Trim() + "?"
                                             , Properties.Resources.FullAppName
                                             , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DoWorkBgwEnviarCotizacion();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe especificar un correo electrónico para el envío."
                        , Properties.Resources.FullAppName
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar una oportunidad antes de realizar esta operación."
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

        public void SetModeControl(OperationType operationType, bool BeforeAction = true)
        {
            ot = operationType;
            switch (operationType)
            {
                case OperationType.ot_Find:

                    if (BeforeAction)
                    {
                        foreach (Control ctrl in InfoPanel.Controls)
                        {
                            ctrl.Enabled = false;
                            if (ctrl is TextBox)
                            {
                                ctrl.Text = string.Empty;
                            }
                        }

                        ActionBtn.Text = "BUSCAR OPORTUNIDAD";
                        ActionBtn.Enabled = true;
                        txtCodOpportunidad.Enabled = true;
                        txtCodOpportunidad.BackColor = SystemColors.Info;
                        txtCodigoCliente.Enabled = true;
                        txtCodigoCliente.BackColor = SystemColors.Info;
                        txtNombreCliente.Enabled = true;
                        txtNombreCliente.BackColor = SystemColors.Info;
                        txtContacto.Enabled = true;
                        txtContacto.BackColor = SystemColors.Info;                      
                     
                        TitleLabel.Text = "Gestión de oportunidades";

                        ActionBtn.Focus();
                    }

                    break;
                case OperationType.ot_DialogFind:
                    if (BeforeAction)
                    {
                        foreach (Control ctrl in InfoPanel.Controls)
                        {
                            ctrl.Enabled = false;
                            if (ctrl is TextBox)
                            {
                                ctrl.Text = string.Empty;
                            }
                        }

                        ActionBtn.Text = "BUSCAR OPORTUNIDAD";
                        ActionBtn.Enabled = true;
                        txtCodOpportunidad.Enabled = true;
                        txtCodOpportunidad.BackColor = SystemColors.Info;
                        txtCodigoCliente.Enabled = true;
                        txtCodigoCliente.BackColor = SystemColors.Info;
                        txtNombreCliente.Enabled = true;
                        txtNombreCliente.BackColor = SystemColors.Info;
                        txtContacto.Enabled = true;
                        txtContacto.BackColor = SystemColors.Info;
                        TitleLabel.Text = "Búsqueda de oportunidades";

                        ControlsMenuHandler(operationType);

                        ActionBtn.Focus();
                    }
                    break;
                case OperationType.ot_Add:
                    if (BeforeAction)
                    {
                        foreach (Control ctrl in InfoPanel.Controls)
                        {
                            ctrl.Enabled = true;
                            ctrl.BackColor = SystemColors.Window;
                            if (ctrl is TextBox)
                            {
                                ctrl.Text = string.Empty;
                            }
                        }

                        txtCodOpportunidad.Text = string.Format("GOV{0:0000000000}", new Random().Next(0, 1000));
                        txtCodOpportunidad.Enabled = false;
                        ActionBtn.Text = "CREAR OPORTUNIDAD";
                        cmbEstado.Enabled = false;
                        cmbEstado.SelectedValue = 0;
                      
                        TitleLabel.Text = "Gestión de oportunidades";
                    }

                    break;
                case OperationType.ot_Update:

                    if (BeforeAction)
                    {
                        foreach (Control ctrl in InfoPanel.Controls)
                        {
                            ctrl.Enabled = true;
                        }

                        txtCodOpportunidad.Enabled = false;
                        ActionBtn.Text = "ACTUALIZAR OPORTUNIDAD";
                        TitleLabel.Text = "Gestión de oportunidades";
                    }

                    break;
                case OperationType.ot_Delete:
                    if (BeforeAction)
                    {
                        foreach (Control ctrl in InfoPanel.Controls)
                        {
                            ctrl.Enabled = true;
                        }

                        txtCodOpportunidad.Enabled = false;
                        ActionBtn.Text = "ELIMINAR OPORTUNIDAD";
                        TitleLabel.Text = "Gestión de oportunidades";
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
                    AddActButton.Enabled = false;
                    SendEmailBut.Enabled = false;
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
                    AddActButton.Enabled = true;
                    SendEmailBut.Enabled = true;
                    ChooseButton.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string clave = ActionBtn.Text.Replace("OPORTUNIDAD", "").Trim();
                switch (clave)
                {
                    case "BUSCAR":
                        DoWorkBgwBuscarOportunidades();
                        break;
                    case "CREAR":
                        if (ValidarRegistro())
                        {
                            DoWorkBgwCrearModificarOportunidad(OperationType.ot_Add);
                        }
                        break;
                    case "ACTUALIZAR":
                        if (MessageBox.Show("¿Está seguro que desea actualizar esta oportunidad?"
                            , Properties.Resources.FullAppName
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DoWorkBgwCrearModificarOportunidad(OperationType.ot_Update);
                        }
                        break;
                    case "ELIMINAR":
                        if (MessageBox.Show("¿Está seguro que desea eliminar esta oportunidad?" + Environment.NewLine
                            + "Esta operación no se podrá deshacer."
                            , Properties.Resources.FullAppName
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DoWorkBgwEliminarOportunidad();
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

        private bool ValidarRegistro()
        {
            return true;
            throw new NotImplementedException();
        }

        private void DoWorkBgwEliminarOportunidad()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;

            string codigo = string.Empty;

            try
            {
                codigo = txtCodOpportunidad.Text;

                this.Cursor = Cursors.WaitCursor;
                this.SuspendLayout();
                InfoPanel.Enabled = false;

                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        proxy.EliminarOportunidad(codigo);
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
                    InfoPanel.Enabled = true;
                    this.Cursor = Cursors.Default;

                    if (e.Error != null)
                    {
                        Useful.ShowErrorMsg(e.Error, ExceptionType.et_EntityException);
                    }
                    else
                    {
                        MessageBox.Show("La oportunidad " + codigo + " ha sido eliminada satisfactoriamente."
                                       , Properties.Resources.FullAppName
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        oportunidadBindingSource.DataSource = null;
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

        private void DoWorkBgwCrearModificarOportunidad(OperationType operationType)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;
            OfertaVentaWS.Oportunidad obj = null;
            string sResult = string.Empty;

            try
            {
                this.SuspendLayout();
                InfoPanel.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                obj = new OfertaVentaWS.Oportunidad();
                switch (operationType)
                {
                    case OperationType.ot_Add:
                        obj.Codigo = txtCodOpportunidad.Text.Trim();
                        obj.Estado = "0";
                        break;
                    case OperationType.ot_Update:
                        obj.Codigo = txtCodOpportunidad.Text.Trim();
                        obj.Estado = cmbEstado.SelectedValue.ToString();
                        break;
                    case OperationType.ot_Delete:
                        break;
                    default:
                        break;
                }

                obj.CodCliente = txtCodigoCliente.Text;
                obj.NombreCliente = txtNombreCliente.Text;
                obj.PersonaContact = txtContacto.Text;
                obj.TelefCliente = txtTelefono.Text;
                obj.EmailCliente = txtCorreo.Text.Trim();

                obj.NroPlaca = txtNroPlaca.Text.Trim();
                obj.NroSerie = txtNroSerie.Text.Trim();
                obj.NroVIN = txtNroVIN.Text.Trim();
                obj.NroMotor = txtNroMotor.Text.Trim();
                obj.Marca = txtMarca.Text;
                obj.Modelo = txtModelo.Text;
                obj.PlacaVigente = txtPlacaVigente.Text;
                obj.Anotaciones = txtNotas.Text;

                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        switch (operationType)
                        {
                            case OperationType.ot_Add:
                                sResult = proxy.RegistrarOportunidad(obj);
                                break;
                            case OperationType.ot_Update:
                                sResult = proxy.ActualizarOportunidad(obj);
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
                                txtCodOpportunidad.Text = obj.Codigo;
                                switch (operationType)
                                {
                                    case OperationType.ot_Add:
                                        MessageBox.Show("La oportunidad " + obj.Codigo + " se registró satisfactoriamente."
                                            , Properties.Resources.FullAppName
                                            , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        DoWorkBgwBuscarOportunidades();
                                        break;
                                    case OperationType.ot_Update:
                                        MessageBox.Show("La oportunidad " + obj.Codigo + " ha sido actualizada satisfactoriamente."
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
                        InfoPanel.Enabled = true;
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

        private void DoWorkBgwBuscarOportunidades()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;
            OfertaVentaWS.Oportunidad[] objList = null;

            string Codigo = string.Empty
                , CodCliente = string.Empty
                , NombCliente = string.Empty
                , PersonaContac = string.Empty;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Codigo = txtCodOpportunidad.Text;
                CodCliente = txtCodigoCliente.Text;
                NombCliente = txtNombreCliente.Text;
                PersonaContac = txtContacto.Text;

                this.SuspendLayout();
                InfoPanel.Enabled = false;

                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        objList = proxy.BusquedaOportunidadList(Codigo, CodCliente, NombCliente, PersonaContac);
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
                    oportunidadBindingSource.DataSource = objList;
                    InfoPanel.Enabled = true;
                    this.Cursor = Cursors.Default;

                    if (e.Error != null)
                    {
                        Useful.ShowErrorMsg(e.Error, ExceptionType.et_EntityException);
                    }
                    else
                    {
                        if (dgtOportunidades.RowCount > 0)
                        {
                            lblInformar.Visible = false;
                            if (dgtOportunidades.RowCount == 1)
                                dgtOportunidades_Click(null, null);
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

        private void DoWorkBgwEnviarCotizacion()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;

            string codigo = string.Empty;
            try
            {
                codigo = txtCodOpportunidad.Text;

                this.Cursor = Cursors.WaitCursor;
                this.SuspendLayout();
                InfoPanel.Enabled = false;

                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        string response = 
                        proxy.EnviarCorreoElectronico(new OfertaVentaWS.Email() {
                            EmailFrom = "unknownguest@outlook.es",
                            NameFrom = "Gerardo Sandoval Echevarría",
                            EmailTo = txtCorreo.Text,
                            NameTo = txtNombreCliente.Text,
                            Subject = "Cotización solicitada",
                            TextPart = string.Format("Estimado cliente:\n Adjunto la cotización solicitada por usted hoy {0}", DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")),
                            HTMLPart = string.Format("<h3>Estimado cliente:</h3><br/>Adjunto la cotización solicitada por usted hoy {0}", DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")),                           
                            ReceiveConfirmation = true
                        });

                        if (response.Equals("OK"))
                        {
                            proxy.EnviarMensajeTexto(new OfertaVentaWS.SMS()
                            {
                                Message = "Estimado usuario. Este mensaje confirma la recepción del correo electrónico en su bandeja de entrada. Por favor, le sugerimos que revise su carpeta de correos spam.",
                                Number = txtTelefono.Text                                
                            });
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
                    InfoPanel.Enabled = true;
                    this.Cursor = Cursors.Default;

                    if (e.Error != null)
                    {
                        Useful.ShowErrorMsg(e.Error, ExceptionType.et_NotifiException);
                    }
                    else
                    {
                        MessageBox.Show("La cotización " + codigo + " ha sido enviada satisfactoriamente."
                                       , Properties.Resources.FullAppName
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);                        
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

        private void btnGen_Click(object sender, EventArgs e)
        {

        }

        private void OpportUserControl_Leave(object sender, EventArgs e)
        {
            ot = OperationType.ot_None;
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (ot == OperationType.ot_DialogFind && uc != null)
            {
                if (!string.IsNullOrEmpty(txtCodOpportunidad.Text))
                {
                    switch (uc.Name)
                    {
                        case "ActivityUserControl":
                            dashboardForm.activity.SetDataOportunidad(new OfertaVentaWS.Oportunidad()
                            {
                                Codigo = txtCodOpportunidad.Text,
                                CodCliente = txtCodigoCliente.Text,
                                NombreCliente = txtNombreCliente.Text,
                                PersonaContact = txtContacto.Text,
                                TelefCliente = txtTelefono.Text
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
                        case "ActivityUserControl":
                            dashboardForm.activity.SetDataOportunidad(null);
                            dashboardForm.ShowUserControl(dashboardForm.activity);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void dgtOportunidades_Click(object sender, EventArgs e)
        {
            try
            {
                SuspendLayout();
                if (dgtOportunidades.CurrentRow != null)
                {
                    txtNotas.Text = dgtOportunidades.CurrentRow.Cells[0].Value.ToString();
                    txtCodOpportunidad.Text = dgtOportunidades.CurrentRow.Cells[1].Value.ToString();
                    txtCodigoCliente.Text = dgtOportunidades.CurrentRow.Cells[2].Value.ToString();
                    txtCorreo.Text = dgtOportunidades.CurrentRow.Cells[3].Value.ToString();
                    cmbEstado.SelectedValue = dgtOportunidades.CurrentRow.Cells[4].Value.ToString();
                    txtMarca.Text = dgtOportunidades.CurrentRow.Cells[5].Value.ToString();
                    txtModelo.Text = dgtOportunidades.CurrentRow.Cells[6].Value.ToString();
                    txtNombreCliente.Text = dgtOportunidades.CurrentRow.Cells[7].Value.ToString();
                    txtNroMotor.Text = dgtOportunidades.CurrentRow.Cells[8].Value.ToString();
                    txtNroPlaca.Text = dgtOportunidades.CurrentRow.Cells[9].Value.ToString();
                    txtNroSerie.Text = dgtOportunidades.CurrentRow.Cells[10].Value.ToString();
                    txtNroVIN.Text = dgtOportunidades.CurrentRow.Cells[11].Value.ToString();
                    txtContacto.Text = dgtOportunidades.CurrentRow.Cells[12].Value.ToString();
                    txtPlacaVigente.Text = dgtOportunidades.CurrentRow.Cells[13].Value.ToString();
                    txtTelefono.Text = dgtOportunidades.CurrentRow.Cells[14].Value.ToString();
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

        private void dgtOportunidades_DoubleClick(object sender, EventArgs e)
        {
            if (dgtOportunidades.CurrentRow != null)
                dgtOportunidades_Click(null, null);
        }
    }
}
