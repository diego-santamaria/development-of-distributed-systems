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
using System.Globalization;

namespace SalesOpportunityManagement.UserControls
{
    public partial class ActivityUserControl : BaseUserControl
    {
        private DashboardForm dashboardForm;
        public ActivityUserControl(DashboardForm dashboardForm)
        {
            this.dashboardForm = dashboardForm;
            InitializeComponent();
            SetDropDownItemsActividad();
            SetDropDownItemsPrioridad();
            SetDropDownItemsRepeticion();
            SetModeControl(OperationType.ot_Find);
        }

        private void SetModeControl(object operationType, bool BeforeAction = true)
        {
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

                        btnFindOp.Enabled = true;
                        ActionBtn.Text = "BUSCAR ACTIVIDAD";
                        ActionBtn.Enabled = true;
                        txtCodOpportunidad.Enabled = true;
                        txtCodOpportunidad.BackColor = SystemColors.Info;
                        txtCodActividad.Enabled = true;
                        txtCodActividad.BackColor = SystemColors.Info;
                        txtCodigoCliente.Enabled = true;
                        txtCodigoCliente.BackColor = SystemColors.Info;
                        txtNombreCliente.Enabled = true;
                        txtNombreCliente.BackColor = SystemColors.Info;
                        cmbActividad.Enabled = true;
                        cmbActividad.BackColor = SystemColors.Info;
                        cmbPrioridad.Enabled = true;
                        cmbPrioridad.BackColor = SystemColors.Info;

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

                        txtCodActividad.Text = string.Format("GOV{0:0000000000}", new Random().Next(0, 1000));
                        txtCodActividad.Enabled = false;
                        ActionBtn.Text = "CREAR ACTIVIDAD";
                        chkCerrado.Checked = false;
                        chkCerrado.Enabled = false;
                    }
                    break;
                case OperationType.ot_Update:
                    if (BeforeAction)
                    {
                        foreach (Control ctrl in InfoPanel.Controls)
                        {
                            ctrl.Enabled = true;
                        }
                        txtCodActividad.Enabled = false;
                        ActionBtn.Text = "ACTUALIZAR ACTIVIDAD";
                    }
                    break;
                case OperationType.ot_Delete:
                    if (BeforeAction)
                    {
                        foreach (Control ctrl in InfoPanel.Controls)
                        {
                            ctrl.Enabled = true;
                        }
                        txtCodActividad.Enabled = false;
                        ActionBtn.Text = "ELIMINAR ACTIVIDAD";
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

        private void SetDropDownItemsRepeticion()
        {

            DataRow dr;
            DataTable dt = new DataTable("Tabla");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");


            dr = dt.NewRow();
            dr["Codigo"] = "0";
            dr["Descripcion"] = "Diario";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "Semanal";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "2";
            dr["Descripcion"] = "Mensual";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "3";
            dr["Descripcion"] = "Anual";
            dt.Rows.Add(dr);

            cmbRepeticion.DataSource = dt;
            cmbRepeticion.ValueMember = "Codigo";
            cmbRepeticion.DisplayMember = "Descripcion";
            cmbRepeticion.Enabled = true;
        }

        private void SetDropDownItemsPrioridad()
        {

            DataRow dr;
            DataTable dt = new DataTable("Tabla");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");


            dr = dt.NewRow();
            dr["Codigo"] = "0";
            dr["Descripcion"] = "Baja";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "Normal";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "3";
            dr["Descripcion"] = "Alta";
            dt.Rows.Add(dr);

            cmbPrioridad.DataSource = dt;
            cmbPrioridad.ValueMember = "Codigo";
            cmbPrioridad.DisplayMember = "Descripcion";
            cmbPrioridad.Enabled = true;
        }

        private void SetDropDownItemsActividad()
        {
            DataRow dr;
            DataTable dt = new DataTable("Tabla");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");

            dr = dt.NewRow();
            dr["Codigo"] = "0";
            dr["Descripcion"] = "Llamada telefónica";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "1";
            dr["Descripcion"] = "Reunión";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "2";
            dr["Descripcion"] = "Tarea";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "3";
            dr["Descripcion"] = "Nota";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "4";
            dr["Descripcion"] = "Campaña";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "5";
            dr["Descripcion"] = "Otro";
            dt.Rows.Add(dr);

            cmbActividad.DataSource = dt;
            cmbActividad.ValueMember = "Codigo";
            cmbActividad.DisplayMember = "Descripcion";
            cmbActividad.Enabled = true;
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
                if (!string.IsNullOrEmpty(txtCodActividad.Text.Trim()) && dgtActividades.RowCount > 0)
                {
                    SetModeControl(OperationType.ot_Update);
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar una actividad antes de realizar esta operación."
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
                if (!string.IsNullOrEmpty(txtCodActividad.Text.Trim()) /*&& ActionBtn.Text.Contains("BUSCAR")*/ && dgtActividades.RowCount > 0)
                {
                    SetModeControl(OperationType.ot_Delete);
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar una actividad antes de realizar esta operación."
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

        private void PrioButton_Click(object sender, EventArgs e)
        {
            SuspendLayout();
            try
            {
                if (!string.IsNullOrEmpty(txtCodActividad.Text.Trim()) && ActionBtn.Text.Contains("BUSCAR") && dgtActividades.RowCount > 0)
                {

                    if (MessageBox.Show("¿Está seguro que desea establecer una mayor prioridad a esta actividad?"
                                 , Properties.Resources.FullAppName
                                 , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Debe buscar y seleccionar una actividad antes de realizar esta operación."
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

        private void btnFindOp_Click(object sender, EventArgs e)
        {
            //dashboardForm.opport.ot = OperationType.ot_DialogFind;
            dashboardForm.opport.SetModeControl(OperationType.ot_DialogFind);
            dashboardForm.opport.uc = this;
            dashboardForm.ShowUserControl(dashboardForm.opport);
        }

        private void btnFindCli_Click(object sender, EventArgs e)
        {
            dashboardForm.customer.ot = OperationType.ot_DialogFind;
            dashboardForm.customer.SetModeControl(OperationType.ot_DialogFind);
            dashboardForm.customer.uc = this;
            dashboardForm.ShowUserControl(dashboardForm.customer);
        }

        internal void SetDataOportunidad(OfertaVentaWS.Oportunidad obj)
        {
            if (obj != null)
            {
                txtCodOpportunidad.Text = obj.Codigo;
                txtCodigoCliente.Text = obj.CodCliente;
                txtNombreCliente.Text = obj.NombreCliente;
                txtContacto.Text = obj.PersonaContact;
                txtTelefono.Text = obj.TelefCliente;
            }
        }

        internal void SetDataClient(OfertaVentaWS.BusinessPartner bp)
        {
            if (bp != null)
            {
                txtCodigoCliente.Text = bp.CardCode;
                txtNombreCliente.Text = bp.CardName;
                txtContacto.Text = bp.ContctPrsn;
                txtTelefono.Text = !string.IsNullOrEmpty(bp.Cellular) ? bp.Cellular : !string.IsNullOrEmpty(bp.Telephone1) ? bp.Telephone1 : bp.Telephone2;
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string clave = ActionBtn.Text.Replace("ACTIVIDAD", "").Trim();
                switch (clave)
                {
                    case "BUSCAR":
                        DoWorkBgwBuscarActividades();
                        break;
                    case "CREAR":
                        if (ValidarRegistro())
                        {
                            DoWorkBgwCrearModificarActividad(OperationType.ot_Add);
                        }
                        break;
                    case "ACTUALIZAR":
                        if (MessageBox.Show("¿Está seguro que desea actualizar esta actividad?"
                            , Properties.Resources.FullAppName
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DoWorkBgwCrearModificarActividad(OperationType.ot_Update);
                        }
                        break;
                    case "ELIMINAR":
                        if (MessageBox.Show("¿Está seguro que desea eliminar esta actividad?" + Environment.NewLine
                            + "Esta operación no se podrá deshacer."
                            , Properties.Resources.FullAppName
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DoWorkBgwEliminarActividad();
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

        private void DoWorkBgwEliminarActividad()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;

            string codigo = string.Empty, codigoOpor = string.Empty, codCliente;

            try
            {
                codigo = txtCodOpportunidad.Text;
                codigoOpor = txtCodOpportunidad.Text;
                codCliente = txtCodigoCliente.Text;

                this.Cursor = Cursors.WaitCursor;
                this.SuspendLayout();
                InfoPanel.Enabled = false;

                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        proxy.EliminarActividad(codigo, codigoOpor, codCliente);
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
                        MessageBox.Show("La actividad " + codigo + " ha sido eliminada satisfactoriamente."
                                       , Properties.Resources.FullAppName
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        actividadBindingSource.DataSource = null;
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

        private void DoWorkBgwCrearModificarActividad(OperationType operationType)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;
            OfertaVentaWS.Actividad obj = null;
            string sResult = string.Empty;

            try
            {
                this.SuspendLayout();
                InfoPanel.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                obj = new OfertaVentaWS.Actividad();
                switch (operationType)
                {
                    case OperationType.ot_Add:
                        obj.nActividad = txtCodOpportunidad.Text.Trim();
                        obj.sEstado = "Y";
                        break;
                    case OperationType.ot_Update:
                        obj.nActividad = txtCodOpportunidad.Text.Trim();
                        obj.sEstado = chkCerrado.Checked ? "Y"  : "N";
                        break;
                    case OperationType.ot_Delete:
                        break;
                    default:
                        break;
                }

                obj.cOportunidad = txtCodOpportunidad.Text;
                obj.cCliente = txtCodigoCliente.Text;
                obj.dRazonSocial = txtNombreCliente.Text;
                obj.dPersonaContacto = txtContacto.Text;
                obj.nTelefono = txtTelefono.Text.Trim();


                CultureInfo provider = CultureInfo.InvariantCulture;

                obj.fInicio = DateTime.ParseExact(dtpDiaInicio.Value.ToString("dd/MM/yyyy") + " " + dtpHoraInicio.Value.ToString("HH:mm"), "g", provider) ;
                obj.fFin = DateTime.ParseExact(dtpDiafin.Value.ToString("dd/MM/yyyy") + " " + dtpHorafin.Value.ToString("HH:mm"), "g", provider);

                obj.cTipoActividad = cmbActividad.SelectedValue.ToString();
                obj.cNivelPrioridad = cmbPrioridad.SelectedValue.ToString();
                obj.cTipoRepeticion = cmbRepeticion.SelectedValue.ToString();
                obj.dComentarios = txtNotas.Text;

                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        switch (operationType)
                        {
                            case OperationType.ot_Add:
                                sResult = proxy.RegistrarActividad(obj);
                                break;
                            case OperationType.ot_Update:
                                sResult = proxy.ActualizarActividad(obj);
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
                                txtCodActividad.Text = obj.nActividad;
                                switch (operationType)
                                {
                                    case OperationType.ot_Add:
                                        MessageBox.Show("La actividad " + obj.nActividad + " se registró satisfactoriamente."
                                            , Properties.Resources.FullAppName
                                            , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        DoWorkBgwBuscarActividades();
                                        break;
                                    case OperationType.ot_Update:
                                        MessageBox.Show("La actividad " + obj.nActividad + " ha sido actualizada satisfactoriamente."
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

        private bool ValidarRegistro()
        {
            return true;
            throw new NotImplementedException();
        }

        private void DoWorkBgwBuscarActividades()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = false;
            OfertaVentaWS.Actividad[] actividades = null;

            string nActividad = string.Empty
                , codOportunidad = string.Empty
                , codCliente = string.Empty
                , nombCliente = string.Empty;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                nActividad = txtCodActividad.Text;
                codOportunidad = txtCodOpportunidad.Text;
                codCliente = txtCodigoCliente.Text;
                nombCliente = txtNombreCliente.Text;

                this.SuspendLayout();
                InfoPanel.Enabled = false;

                worker.DoWork += (sender, e) =>
                {
                    OfertaVentaWS.OfertaVentaServiceClient proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    try
                    {
                        actividades = proxy.BusquedaActividadList(nActividad, codOportunidad, codCliente, nombCliente);
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
                    actividadBindingSource.DataSource = actividades;
                    InfoPanel.Enabled = true;
                    this.Cursor = Cursors.Default;

                    if (e.Error != null)
                    {
                        Useful.ShowErrorMsg(e.Error, ExceptionType.et_EntityException);
                    }
                    else
                    {
                        if (dgtActividades.RowCount > 0)
                        {
                            lblInformar.Visible = false;
                            if (dgtActividades.RowCount == 1)
                                dgtActividades_Click(null, null);
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

        private void dgtActividades_Click(object sender, EventArgs e)
        {
            try
            {
                SuspendLayout();
                if (dgtActividades.CurrentRow != null)
                {
                    txtCodActividad.Text = dgtActividades.CurrentRow.Cells[0].Value.ToString();
                    cmbPrioridad.SelectedValue = dgtActividades.CurrentRow.Cells[1].Value.ToString();
                    txtCodOpportunidad.Text = dgtActividades.CurrentRow.Cells[2].Value.ToString();
                    txtCodigoCliente.Text = dgtActividades.CurrentRow.Cells[3].Value.ToString();
                    cmbActividad.SelectedValue = dgtActividades.CurrentRow.Cells[4].Value.ToString();
                    cmbRepeticion.SelectedValue = dgtActividades.CurrentRow.Cells[5].Value.ToString();
                    //txtCodigoCliente.Text = dgtActividades.CurrentRow.Cells[5].Value.ToString();
                    txtNotas.Text = dgtActividades.CurrentRow.Cells[7].Value.ToString();
                    txtContacto.Text = dgtActividades.CurrentRow.Cells[8].Value.ToString();
                    txtNombreCliente.Text = dgtActividades.CurrentRow.Cells[9].Value.ToString();

                    dtpDiaInicio.Value = DateTime.Parse(dgtActividades.CurrentRow.Cells[10].Value.ToString());
                    dtpHoraInicio.Value = DateTime.Parse(dgtActividades.CurrentRow.Cells[11].Value.ToString());
                    dtpDiafin.Value = DateTime.Parse(dgtActividades.CurrentRow.Cells[12].Value.ToString());
                    dtpHorafin.Value = DateTime.Parse(dgtActividades.CurrentRow.Cells[13].Value.ToString());

                    txtTelefono.Text = dgtActividades.CurrentRow.Cells[14].Value.ToString();
                    chkCerrado.Checked = dgtActividades.CurrentRow.Cells[15].Value.ToString() == "Y" ? true : false;
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

        private void ActivityUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
