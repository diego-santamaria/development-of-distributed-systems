using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaPedidos.Bean;
using TomaPedidos.Commons;

namespace TomaPedidos.View
{
    public partial class frmActividadRegistro : Form
    {
        private FrmConversiones objFrmConv;
        public string sResultMsg = string.Empty;
        public frmActividadRegistro(FrmConversiones objfrm)
        {
            InitializeComponent(); 
            this.objFrmConv = objfrm;
            txtCodCliente.Text = objFrmConv.txtClientCode.Text;
            txtNombreCliente.Text = objFrmConv.txtClientName.Text;
            txtTlf.Text = objFrmConv.txtClientPhone.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Useful.SuspendLayout(this);
            try
            {
                var pregunta = "";
                if (btnCrear.Text == "Actualizar")
                {
                    pregunta = "¿Está seguro de actualizar esta actividad?";
                }
                else if (btnCrear.Text == "Crear")
                {
                    pregunta = "¿Está seguro de asociar esta actividad a la cotización?";
                }
                if (MessageBox.Show(pregunta, Properties.Resources.FullAppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (validarDatosActividad())
                {
                    if (chkCerrarActividad.Checked)
                    {
                        if (MessageBox.Show("El cierre de una es irreversible (actividades cerradas no pueden ser modificadas). "+
                            "¿Continuar?", Properties.Resources.FullAppName,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;
                    }
                    Activity objAct = new Activity();
                    objAct.NumActividad = txtNumActividad.Text;
                    objAct.Actividad = cmbActividad.SelectedIndex.ToString();
                    objAct.Tipo = cmbTipo.SelectedIndex.ToString();
                    //objAct.Asunto = cmbAsunto.SelectedIndex == -1 ? "" : cmbAsunto.SelectedIndex.ToString();
                    objAct.Asunto = cmbTipo.SelectedIndex.ToString();
                    objAct.CodCliente = txtCodCliente.Text;
                    objAct.Telefono = txtTlf.Text;
                    objAct.DiaIni = dtpDiaInicio.Value;
                    objAct.DiaFin = dtpDiafin.Value;
                    objAct.HoraIni = dtpHoraInicio.Text.Substring(0, 8);
                    objAct.HoraFin = dtpHorafin.Text.Substring(0, 8);
                    //objAct.HoraFin = dtpHorafin.Value.ToString("00:00:00");
                    objAct.Prioridad = cmbPrioridad.SelectedIndex == -1 ? "" : cmbPrioridad.SelectedIndex.ToString();
                    objAct.Repeticion = cmbRepetición.SelectedIndex == -1 ? "" : cmbRepetición.SelectedIndex.ToString();
                    //objAct.Detalle = txtCodCliente.Text == Constant.GenericClient ? "Nombre del cliente: " + txtNombreCliente.Text + ". | " + txtDetalle.Text : txtDetalle.Text;
                    objAct.Detalle = txtDetalle.Text;
                    objAct.Notas = txtNotas.Text;
                    objAct.CodDocAsocOffer = objFrmConv.txtCodigoSAPoffer.Text; //Código de Oferta de Venta
                    objAct.NombreCliente = txtNombreCliente.Text;
                    objAct.HandledByEmployee = /*frmLogin.infoApp.UserSapCode*/null; //Empleado asignado  
                    objAct.SalesOpportunityId = objFrmConv.txtCodigoSAPoppor.Text; //Código de la oportunidad
                    objAct.Cerrado = chkCerrarActividad.Checked;

                    ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
                    string Result = servicio.GuardarActividad(Conversion.Serialize<Activity>(objAct));
                    if (Result.StartsWith(Constant.OK))
                    {
                        sResultMsg = Constant.OK;
                        if (btnCrear.Text == "Actualizar")
                        {
                            MessageBox.Show("Actividad actualizada " + (chkCerrarActividad.Checked ? "y cerrada " : "") + "exitosamente." + Environment.NewLine + "Actividad Nro " + Result.Substring(2) + ". ", Properties.Resources.FullAppName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (btnCrear.Text == "Crear")
                        {
                            MessageBox.Show("Actividad registrada exitosamente." + Environment.NewLine + "Actividad Nro " + Result.Substring(2) + ". ", Properties.Resources.FullAppName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                    else
                    {
                        sResultMsg = Constant.ERR;
                        throw (new Exception(message: Result));
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
                
        private bool validarDatosActividad()
        {
            bool flagIsCorrect = true;
            try
            {
                if (cmbActividad.SelectedIndex.ToString().Equals(-1))
                {
                    cmbActividad.Focus();
                    errorProvAct.SetError(cmbActividad, "Debe indicar la actividad a realizar");
                    return flagIsCorrect = false;
                }
                if (cmbTipo.SelectedIndex.ToString().Equals(-1))
                {
                    cmbTipo.Focus();
                    errorProvAct.SetError(cmbTipo, "El tipo de actividad es requerida");
                    return flagIsCorrect = false;
                } 
                //if (null == cmbAsunto.SelectedIndex)
                //{
                //    cmbAsunto.Focus();
                //    errorProvAct.SetError(cmbAsunto, "El tipo de actividad es requerida");
                //    return flagIsCorrect = false;
                //}
                if (string.IsNullOrEmpty(txtCodCliente.Text.Trim()))
                {
                    txtCodCliente.Focus();
                    errorProvAct.SetError(txtCodCliente, "El código de cliente es requerido");
                    return flagIsCorrect = false;
                }
            }
            catch (Exception ex)
            {
                flagIsCorrect = false;
                Useful.ShowErrorMsg(ex);                
            }
            return flagIsCorrect;
        }

        private void frmActividad_Load(object sender, EventArgs e)
        {
            cmbActividad.DisplayMember = "Text";
            cmbActividad.ValueMember = "Value";
            cmbActividad.DataSource = Constant.ACTIVIDAD.COMBO_BOX.Actividades;

            cmbRepetición.DisplayMember = "Text";
            cmbRepetición.ValueMember = "Value";
            cmbRepetición.DataSource = Constant.ACTIVIDAD.COMBO_BOX.Repeticiones;

            cmbPrioridad.DisplayMember = "Text";
            cmbPrioridad.ValueMember = "Value";
            cmbPrioridad.DataSource = Constant.ACTIVIDAD.COMBO_BOX.Prioridades;
        }

        public void cargarActividad(ServicioTomaPedidos.Activities objActivity)
        {
            try
            {
                frmActividad_Load(null, null);
                txtNumActividad.Text = objActivity.NumActividad;

                cmbActividad.SelectedValue = objActivity.Actividad;
                txtActividadAux.Text = cmbActividad.Text;
                //cmbTipo.SelectedValue = objActivity.Tipo;
                //cmbAsunto.SelectedValue = objActivity.Asunto;
                txtCodCliente.Text = objActivity.CodCliente;
                txtNombreCliente.Text = objFrmConv.txtClientName.Text;
                txtTlf.Text = objActivity.Telefono;
                //dtpDiaInicio.Value = objActivity.DiaIni;
                //txtDiaInicioAux.Text = objActivity.DiaIni.ToShortDateString();
                //dtpDiafin.Value = objActivity.DiaFin;
                //txtDiaFinAux.Text = objActivity.DiaFin.ToShortDateString();
                dtpHoraInicio.Value = DateTime.Parse(objActivity.HoraIni);
                txtHoraInicioAux.Text = objActivity.HoraIni;
                dtpHorafin.Value = DateTime.Parse(objActivity.HoraFin);
                txtHoraFinAux.Text = objActivity.HoraFin;
                cmbPrioridad.SelectedValue = objActivity.Prioridad;
                txtPrioridadAux.Text = cmbPrioridad.Text;
                cmbRepetición.SelectedValue = objActivity.Repeticion;
                txtRepeticionAux.Text = cmbRepetición.Text;
                txtDetalle.Text = objActivity.Detalle;
                txtNotas.Text = objActivity.Notas;
                chkCerrarActividad.Checked = objActivity.Cerrado;

                btnCrear.Text = "Actualizar";
                chkCerrarActividad.Visible = true;
                if (objActivity.Cerrado)
                    DeshabilitarComponentes();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void limpiarFormulario()
        {
            try
            {
                cmbActividad.SelectedIndex = 0;
                //cmbTipo.SelectedIndex = 0;
                //cmbAsunto.SelectedIndex = -1;
                cmbPrioridad.SelectedIndex = 1;
                cmbRepetición.SelectedIndex = 0;
                txtDetalle.Clear();
                txtNotas.Clear();
                this.Update();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void DeshabilitarComponentes()
        {
            cmbActividad.Enabled = false;
            cmbActividad.Visible = false;
            txtActividadAux.Visible = true;
            cmbTipo.Enabled = false;
            cmbTipo.Visible = false;
            cmbAsunto.Enabled = false;
            cmbAsunto.Visible = false;
            txtTlf.ReadOnly = true;
            dtpDiaInicio.Enabled = false;
            dtpDiaInicio.Visible = false;
            txtDiaInicioAux.Visible = true;
            dtpDiafin.Enabled = false;
            dtpDiafin.Visible = false;
            txtDiaFinAux.Visible = true;
            dtpHoraInicio.Enabled = false;
            dtpHoraInicio.Visible = false;
            txtHoraInicioAux.Visible = true;
            dtpHorafin.Enabled = false;
            dtpHorafin.Visible=false;
            txtHoraFinAux.Visible = true;
            cmbPrioridad.Enabled = false;
            cmbPrioridad.Visible = false;
            txtPrioridadAux.Visible = true;
            cmbRepetición.Enabled = false;
            cmbRepetición.Visible = false;
            txtRepeticionAux.Visible = true;
            txtDetalle.ReadOnly = true;
            txtNotas.ReadOnly = true;
            chkCerrarActividad.Enabled = false;

            btnCrear.Visible = false;
            btnCancelar.Text = "Cerrar";
            btnCancelar.Top = 253;
            btnCancelar.Left = 14;
        }
    }
}
