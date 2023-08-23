using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaPedidos.Bean;
using TomaPedidos.Commons;

namespace TomaPedidos.View
{
    public partial class FrmConversiones : Form
    {
        private bool flagfrmServAdfueAbierto = false;
        bool flagModoLimpieza = false;
        private ServicioTomaPedidos.ServicioTomaPedidos webService = new ServicioTomaPedidos.ServicioTomaPedidos();

        public FrmConversiones()
        {
            //flagModoNuevaConversion = true;
            InitializeComponent();
        }

        private void frmConversions_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
        }

        private void CargarComboBoxes()
        {
            CargarCmbCilMotor();
            CargarCmbGeneracion();
            CargarCmbGasolina();
            CargarCmbTomaCarga();
            CargarCmbMarcaEquipo();
            //CargarCmbEnterarse();
        }

        private void CargarCmbCilMotor()
        {
            cmbCilMotor.Items.Clear();
            cmbCilMotor.DataSource = webService.ObtenerValoresComboBoxDtable("NmCilMotor");
            cmbCilMotor.ValueMember = "Codigo";
            cmbCilMotor.DisplayMember = "Descripcion";
            cmbCilMotor.SelectedIndex = -1;
        }

        private void CargarCmbGeneracion()
        {
            cmbGeneracion.Items.Clear();
            cmbGeneracion.DataSource = webService.ObtenerValoresComboBoxDtable("Generacion");
            cmbGeneracion.ValueMember = "Codigo";
            cmbGeneracion.DisplayMember = "Descripcion";
            cmbGeneracion.SelectedIndex = -1;
        }

        private void CargarCmbGasolina()
        {
            cmbGasolina.Items.Clear();
            cmbGasolina.DataSource = webService.ObtenerValoresComboBoxDtable("GasUtil");
            cmbGasolina.ValueMember = "Codigo";
            cmbGasolina.DisplayMember = "Descripcion";
            cmbGasolina.SelectedIndex = -1;
        }

        private void CargarCmbTomaCarga()
        {
            cmbTomaCarga.Items.Clear();
            cmbTomaCarga.DataSource = webService.ObtenerValoresComboBoxDtable("TomaCarga");
            cmbTomaCarga.ValueMember = "Codigo";
            cmbTomaCarga.DisplayMember = "Descripcion";
            cmbTomaCarga.SelectedIndex = -1;
        }

        private void CargarCmbMarcaEquipo()
        {
            cmbMarcaEquipo.Items.Clear();
            cmbMarcaEquipo.DataSource = webService.ObtenerValoresComboBoxDtable("MarEqConv");
            cmbMarcaEquipo.ValueMember = "Codigo";
            cmbMarcaEquipo.DisplayMember = "Descripcion";
            cmbMarcaEquipo.SelectedIndex = -1;
        }

        private void CargarCmbEnterarse()
        {
            cmbEnterarse.Items.Clear();
            cmbEnterarse.DataSource = webService.ObtenerValoresComboBoxDtable("Enterar");
            cmbEnterarse.ValueMember = "Codigo";
            cmbEnterarse.DisplayMember = "Descripcion";
            cmbEnterarse.SelectedIndex = -1;
        }
      
        private void cmbCilMotor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int seleccion;
            
            try
            {
                cmbCilindrada.Enabled = true;
                seleccion = cmbCilMotor.SelectedIndex;               
                cmbCilindrada.Text = string.Empty;
                cmbCilindrada.Items.Clear();
                switch (seleccion)
                {
                    case 0:
                        for (int i = 0; i < Constant.ArrayListCilMotor3.Length; i++)
                        {
                            cmbCilindrada.Items.Add(Constant.ArrayListCilMotor3[i].ToString());
                        }
                        break;
                    case 1:
                        for (int i = 0; i < Constant.ArrayListCilMotor4.Length; i++)
                        {
                            cmbCilindrada.Items.Add(Constant.ArrayListCilMotor4[i].ToString());
                        }
                        break;
                    case 2:
                        for (int i = 0; i < Constant.ArrayListCilMotor6.Length; i++)
                        {
                            cmbCilindrada.Items.Add(Constant.ArrayListCilMotor6[i].ToString());
                        }
                        break;
                    case 3:
                        for (int i = 0; i < Constant.ArrayListCilMotor8.Length; i++)
                        {
                            cmbCilindrada.Items.Add(Constant.ArrayListCilMotor8[i].ToString());
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

        private void rdbTiposCombustible_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (flagModoLimpieza) return;
                cmbCapTanque.Enabled = true;
                //cmbCapTanque.Text = string.Empty;
                cmbCapTanque.SelectedIndex = -1;
                cmbCapTanque.Items.Clear();
                //cmbTomaCarga.Text = string.Empty;
                cmbTomaCarga.SelectedIndex = -1;
                var checkedButton = panelTipoCombustiblex.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (checkedButton.Text.Equals("GNV"))
                {
                    for (int i = 0; i < Constant.ArrayListGNV.Length; i++)
                    {
                        cmbCapTanque.Items.Add(Constant.ArrayListGNV[i]);
                    }
                    cmbTomaCarga.Enabled = false;
                }
                else
                {
                    for (int i = 0; i < Constant.ArrayListGLP.Length; i++)
                    {
                        cmbCapTanque.Items.Add(Constant.ArrayListGLP[i]);
                    }
                    cmbTomaCarga.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                flagModoLimpieza = false;
            }
        }

        private void cmbEnterarse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int seleccion;
            try
            {
                cmbSubEnterarse.Items.Clear();
                cmbSubEnterarse.Text = string.Empty;              
                seleccion = cmbEnterarse.SelectedIndex;
                switch (seleccion)
                {
                    case 2:
                        for (int i = 0; i < Constant.ArrayListPeriodico.Length; i++)
                        {
                            cmbSubEnterarse.Items.Add(Constant.ArrayListPeriodico[i]);      
                        }
                        cmbSubEnterarse.Enabled = true;
                        break;
                    case 3:
                        for (int i = 1; i <= 15; i++) //Numero de volanteros (15)
                        {
                            cmbSubEnterarse.Items.Add(i); 
                        }
                        //for (int i = 0; i < Constant.ArrayListVolantero.Length; i++)
                        //{
                        //    cmbSubEnterarse.Items.Add(Constant.ArrayListVolantero[i]);
                        //}
                        cmbSubEnterarse.Enabled = true;
                        break;
                    default:
                        cmbSubEnterarse.Enabled = false;
                        break;
                }

            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void rdbSIserv_CheckedChanged(object sender, EventArgs e)
        {
            try
            {                
                var checkedRadioButton = panelServicio.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if ( null != checkedRadioButton)
                {
                    if (checkedRadioButton.Text.Equals("Si"))
                    {
                        if (flagfrmServAdfueAbierto) return;
                        frmServAdd objfrm = new frmServAdd();
                        flagfrmServAdfueAbierto = true;
                        objfrm.btnCancel.Visible = true;
                        objfrm.ShowDialog();
                        var checkedServ = objfrm.Controls.OfType<CheckBox>().FirstOrDefault(r => r.Checked);
                        if (null != checkedServ)
                        {
                            txtServSeleccionados.Text = checkedServ.Name;
                        }
                        else
                        {
                            rdbSIserv.Checked = false;
                            rdbNOserv.Checked = true;
                            flagfrmServAdfueAbierto = false;
                        }
                    }
                    else
                    {
                        flagfrmServAdfueAbierto = false;
                        txtServSeleccionados.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }                

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Display a MsgBox asking the user to save changes or abort. 
                if (e != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea desechar la conversión actual?", Properties.Resources.FullAppName,
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        //flagModoLimpieza = true;
                        //clearData();
                        //btnNew.Enabled = false;
                        //this.Refresh();
                        //txtClientCode.Focus();
                        return;

                    }
                }
                    //Limpieza directa: Previa consulta no incluida en este método.
                //else{
                    flagModoLimpieza = true;
                    clearData();
                    flagViewfrm(true);
                    btnCalc.Enabled = false;
                    btnSave.Enabled = false;
                    btnSave.Text = "Guardar";
                    //btnNew.Enabled = false;
                    btnConvPedido.Enabled = false;
                    btnConvProforma.Enabled = false;
                    btnActividad.Enabled = false;
                    btnActividad.Visible = false;
                    txtClientCode.Focus();
                    this.Update();
                //}
               
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            { flagModoLimpieza = false; }
        }

        private void clearData()
        {
            try
            {// Nota: El 'Modo Limpieza' se lanza desde fuera de éste método.
                foreach (Control ctrl in this.gBoxResumen.Controls)
                {
                    if (ctrl is TextBox) ctrl.Text = "";
                    if (ctrl is ComboBox)
                    {
                        ComboBox cmbox = ctrl as ComboBox;
                        cmbox.SelectedIndex = -1;
                    }
                }
                lblArticuloSeleccionado.Text = "";
                foreach (Control ctrl in this.Controls) {
                    if (ctrl is TextBox) ctrl.Text = "";                    
                    if (ctrl is ComboBox) {
                        ComboBox cmbox = ctrl as ComboBox;
                        cmbox.SelectedIndex = -1;
                    }
                }                
                foreach (Control ctrl in panelTipoCombustiblex.Controls) {
                    
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        radioButton.Checked = false;                    
                }
                foreach (Control ctrl in panelUbicacionTanque.Controls){
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        radioButton.Checked = false;
                }
                foreach (Control ctrl in panelUsoVehiculo.Controls){
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        radioButton.Checked = false;
                }
                foreach (Control ctrl in panelComprobante.Controls){
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        radioButton.Checked = false;
                }
                foreach (Control ctrl in panelInspeccion.Controls){
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        radioButton.Checked = false;
                }
                foreach (Control ctrl in panelPropietario.Controls){
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        radioButton.Checked = false;
                }
                foreach (Control ctrl in panelConVehiculo.Controls){
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        radioButton.Checked = false;
                }
                foreach (Control ctrl in panelServicio.Controls){
                    if (ctrl is RadioButton){
                        RadioButton radioButton = ctrl as RadioButton;
                        if (radioButton.Checked)
                            radioButton.Checked = false;
                    }
                    if (ctrl is TextBox) ctrl.Text = "";   
                }
                foreach (Control ctrl in panelCondicionVenta.Controls){
                    RadioButton radioButton = ctrl as RadioButton;
                    if (radioButton.Checked)
                        radioButton.Checked = false;
                }
            }
            catch (Exception) {
                throw;
            }
            
        }

        private void Allcomponents_ValueChanged(object sender, EventArgs e)
        {
            if (!btnNew.Enabled)
                btnNew.Enabled = true;
        }

        private void btnConvPedido_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPedidoRegistro objfrm = new FrmPedidoRegistro();
                objfrm.Show();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void btnConvertirProforma_Click(object sender, EventArgs e)
        {
            try {
                Offer objOf = new Offer();
                RecolectarDatosConversion(ref objOf);               
                frmProforma frmProf = new frmProforma();
                frmProf.llenarProforma(objOf);
                frmProf.ShowDialog();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void RecolectarDatosConversion(ref Offer objOf)
        {
            try
            {
                objOf.CardName = txtClientName.Text;
                objOf.CardEmail = txtClientEmail.Text;
                objOf.CardDoc = txtClientDoc.Text;
                objOf.CardPhone = txtClientPhone.Text;
                objOf.Placa = txtPlaca.Text;
                objOf.Clase = txtClase.Text;
                objOf.Marca = txtMarca.Text;
                objOf.Modelo = txtModelo.Text;
                objOf.Carroceria = txtCarroceria.Text;
                objOf.AnoFabricacion = txtAnoFab.Text;
                objOf.Recorrido = txtRecorrido.Text;
                objOf.Observaciones = txtObs.Text;
                objOf.NumCilMotor = cmbCilMotor.Text;
                objOf.Cilindrada = cmbCilindrada.Text;
                objOf.GasUtilizada = cmbGasolina.Text;
                objOf.CapTanque = cmbCapTanque.Text;
                objOf.TomaCarga = cmbTomaCarga.Text;
                objOf.MarcaEquipoConv = cmbMarcaEquipo.Text;
                objOf.Generacion = cmbGeneracion.Text;
                objOf.ComoSeEntero = cmbEnterarse.Text;
                objOf.subComoSeEntero = cmbSubEnterarse.Text;
                var radioChecked = panelTipoCombustiblex.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioChecked != null)
                {
                    objOf.TipoCombustible = radioChecked.Text;
                    radioChecked = null;
                }
                radioChecked = panelUbicacionTanque.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioChecked != null)
                {
                    objOf.UbiTanque = radioChecked.Text;
                    radioChecked = null;
                }
                radioChecked = panelUsoVehiculo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioChecked != null)
                {
                    objOf.UsoVehiculo = radioChecked.Text;
                    radioChecked = null;
                }
                radioChecked = panelComprobante.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioChecked != null)
                {
                    objOf.TipoComprobante = radioChecked.Text;
                    radioChecked = null;
                }
                radioChecked = panelInspeccion.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioChecked != null)
                {
                    objOf.flagInspeccionTecnica = radioChecked.Text == "Si" ? true : false;
                    radioChecked = null;
                }
                radioChecked = panelPropietario.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioChecked != null)
                {
                    objOf.flagEsPropietario = radioChecked.Text == "Si" ? true : false;
                    radioChecked = null;
                } 
                radioChecked = panelConVehiculo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioChecked != null)
                {
                    objOf.flagConVehiculo = radioChecked.Text == "Si" ? true : false;
                    radioChecked = null;
                }
                radioChecked = panelCondicionVenta.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioChecked != null)
                {
                    objOf.CondicionVenta = radioChecked.Text;
                    radioChecked = null;
                }
            }
            catch (Exception)
            {                
                throw;
            }
                
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Useful.SuspendLayout(this);
            try {

                //**Para la Presentación:

                txtCantEquivGas.Text = rdbGNV.Checked == true ? "3.16 m3" : "4.58 litros";
                txtAutonomia.Text = "1603200";
                txtPrecioEquivGas.Text = "3400.00";
                txtPorcentaje.Text = "30%";
                txtAhorroMensual.Text = "500.00";
                txtAhorroAnual.Text = string.Format("{0}.00", double.Parse(txtAhorroMensual.Text) * 12);
                txtAhorro5.Text = string.Format("{0}.00", double.Parse(txtAhorroAnual.Text) * 5);
                txtRetornoInversion.Text = "37000";
                lblArticuloSeleccionado.Visible = true;
                lblArticuloSeleccionado.Text = "KIT N° 1891 CONVERSION GNV MODULAR SIN ADICIONALES PRIMARIOS";
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
          
        private void txtAny_OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            Useful.onlyNumbers(e);           
        }

        private void txtAnoFab_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (flagModoLimpieza) return;
                if (txtAnoFab.TextLength == 4)
                {
                    if (int.Parse(txtAnoFab.Text) > int.Parse(DateTime.Now.ToString("yyyy")))
                    {
                        errorProviderConv.SetError(txtAnoFab, "El año de fabricación no puede ser mayor al año actual");
                        e.Cancel = true;
                        return;
                    }                    
                }
                if (txtAnoFab.TextLength < 4 && txtAnoFab.TextLength != 0)
                {
                    errorProviderConv.SetError(txtAnoFab, "El año de fabricación especificado es inválido");
                    e.Cancel = true;
                    return;
                }
                errorProviderConv.SetError(txtAnoFab, "");
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //GUARDAR COMO OPORTUNIDAD DE VENTA Y OFERTA DE VENTA
            Useful.SuspendLayout(this);
            try
            {
                if (MessageBox.Show("¿Está seguro de registrar esta cotización como una Oportunidad de venta?", Properties.Resources.FullAppName,
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                Opportunity objOp = new Opportunity();
                if (validarDatosOportunidadYOferta())
                {
                    ConstruirDocumentoSAP(ref objOp);
                    AddSalesOpportunityToDataBase(objOp);
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

        private bool validarDatosOportunidadYOferta()
        {
            //**Incompleto. Falta docuementación
            bool flagIsCorrect = false;
            try
            {
                if (txtClientCode.Text.Trim() == string.Empty)
                {
                    errorProviderConv.SetError(txtClientCode, "El código del cliente es requerido");  
                    txtClientCode.Width = 122;
                    return flagIsCorrect;
                }
                errorProviderConv.SetError(txtClientCode, "");
                txtClientCode.Width = 132;  
                if (txtClientCode.Text.Trim().Equals(Constant.GenericClient) && (txtClientName.Text.Trim().Equals("*") || string.IsNullOrEmpty(txtClientName.Text.Trim())))
                {
                    //MessageBox.Show("Por favor, especifique un nombre para el cliente genérico.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProviderConv.SetError(txtClientName, "Por favor, especifique un nombre para el cliente genérico");
                    return flagIsCorrect;
                }
                errorProviderConv.SetError(txtClientName, "");
                flagIsCorrect = true;
            }
            catch (Exception ex)
            {
                flagIsCorrect = false;
                Useful.ShowErrorMsg(ex);
            }
            return flagIsCorrect;
        }

        private void ConstruirDocumentoSAP(ref Opportunity objOp)
        {
            //Oferta - Pruebas
            Offer objOf = new Offer();
            objOf.ItemCode = "EMI-10018343";
            objOf.Price = 1500;
            //
            objOf.Placa = txtPlaca.Text;
            objOf.Clase = txtClase.Text;
            objOf.Marca = txtMarca.Text;
            objOf.Modelo = txtModelo.Text;
            objOf.Carroceria = txtCarroceria.Text;
            objOf.AnoFabricacion = txtAnoFab.Text;
            objOf.NumCilMotor = cmbCilMotor.SelectedValue != null ? cmbCilMotor.SelectedValue.ToString() : "";
            objOf.Cilindrada = cmbCilindrada.SelectedItem != null ? cmbCilindrada.SelectedItem.ToString() : "";
            objOf.GasUtilizada = cmbGasolina.SelectedValue != null ? cmbGasolina.SelectedValue.ToString() : "";
            objOf.Recorrido = txtRecorrido.Text;
            objOf.TipoCombustible = rdbGNV.Checked ? Constant.OFFER.TIPO_COMBUSTIBLE.GNV : rdbGLP.Checked ? Constant.OFFER.TIPO_COMBUSTIBLE.GLP : "";
            objOf.CapTanque = cmbCapTanque.SelectedItem != null ? cmbCapTanque.SelectedItem.ToString() : "";
            objOf.UbiTanque = rdbAbajo.Checked ? Constant.OFFER.UBICACION_TANQUE.ABAJO : rdbArriba.Checked ? Constant.OFFER.UBICACION_TANQUE.ARRIBA : "";
            objOf.TomaCarga = cmbTomaCarga.SelectedValue != null ? cmbTomaCarga.SelectedValue.ToString() : "";
            objOf.MarcaEquipoConv = cmbMarcaEquipo.SelectedValue != null ? cmbMarcaEquipo.SelectedValue.ToString() : "";
            objOf.Generacion = cmbGeneracion.SelectedValue != null ? cmbGeneracion.SelectedValue.ToString() : "";
            objOf.UsoVehiculo = rdbTaxi.Checked ? Constant.OFFER.USO_VEHICULO.TAXI : rdbParticular.Checked ? Constant.OFFER.USO_VEHICULO.PARTICULAR : "";
            objOf.TipoComprobante = rdbBoleta.Checked ? "B" : rdbFactura.Checked ? "F" : "";
            objOf.CondicionVenta = rdbContado.Checked ? "CT" : rdbCredito.Checked ? "CR" : "";
            //Servicio adicional cuenta como productos adicionales, así que no es propiedad del objeto oferta
            objOf.flagInspeccionTecnica = rdvSIinspeccion.Checked ? true : false;
            objOf.flagEsPropietario = rdbSIprop.Checked ? true : false;
            objOf.flagConVehiculo = rdbSIvehi.Checked ? true : false;
            objOf.ComoSeEntero = cmbEnterarse.SelectedValue != null ? cmbEnterarse.SelectedValue.ToString() : "";
            objOf.subComoSeEntero = cmbSubEnterarse.SelectedValue != null ? cmbSubEnterarse.SelectedValue.ToString() : "";
            objOf.Observaciones = txtObs.Text;

            //Oportunidad
            objOp.OpprId = txtCodigoSAPoffer.Text;
            objOp.DocEntryOffer = txtCodigoSAPoffer.Text;
            objOp.CardCode = txtClientCode.Text;
            objOp.CardName = txtClientName.Text;
            objOp.Owner = /*frmLogin.infoApp.UserSapCode*/null;
            objOp.OfertaVenta = objOf;
        }

        public void AddSalesOpportunityToDataBase(Opportunity objOp)
        {
            string jsonOp, sResult;
            ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();

            jsonOp = Conversion.Serialize<Opportunity>(objOp);
            sResult = servicio.GuardarOportunidadDeVenta(jsonOp);
            if (sResult.StartsWith(Constant.OK) & sResult != Constant.OK)
            {
                btnActividad.Enabled = true;
                btnActividad.Visible = true;
                string[] rpta = sResult.Substring(2).Split('|');
                txtCodigoSAPoffer.Text = rpta[0];
                txtCodigoSAPoppor.Text = rpta[1];
                MsgBoxUtil.HackMessageBox("Crear", "Nuevo", "Cancelar");
                DialogResult result = MessageBox.Show("Cotización registrada exitosamente. ¿Desea crear una actividad o realizar un nuevo proceso?", Properties.Resources.FullAppName,
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Abort:
                        btnActividad_Click(null, null);
                        btnNew.Enabled = true;
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Ignore:
                        flagViewfrm(false);
                        btnNew.Enabled = true;
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Retry:
                        btnClear_Click(null, null);
                        break;
                    case DialogResult.Yes:
                        break;
                    default:
                        flagViewfrm(false);
                        btnNew.Enabled = true;
                        break;
                }
            }
            else
            {
                MessageBox.Show(sResult, Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActividad_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnActividad.Enabled == true)
                {
                    if (!btnActividad.Text.StartsWith("Actividades")) //Actividades enlazadas
                    {
                        if (string.IsNullOrEmpty(txtCodigoSAPoffer.Text))
                        {
                            MessageBox.Show("La cotización debe ser registrada primero para poder agregar una nueva actividad.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (txtClientCode.Text.Trim().Equals(Constant.GenericClient) & txtClientName.Text.Trim().Equals("*"))
                        {
                            //MessageBox.Show("Por favor, especifique un nombre para el cliente genérico.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            errorProviderConv.SetError(txtClientName, "Por favor, especifique un nombre para el cliente genérico");
                            return;
                        }
                        errorProviderConv.SetError(txtClientName, "");
                        flagViewfrm(false);
                        frmActividadRegistro objActivityReg = new frmActividadRegistro(this);
                        objActivityReg.ShowDialog();
                        if (objActivityReg.sResultMsg.Equals(Constant.OK))
                        {
                            this.btnActividad.Image = global::TomaPedidos.Properties.Resources.img_bells;
                            this.btnActividad.Text = "Actividades enlazadas";
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtCodigoSAPoffer.Text))
                        {
                            MessageBox.Show("La cotización debe estar registrada primero para poder agregar/visualizar una actividad nueva/relacionada.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        frmActividadesRelacionadas objActivityRel = new frmActividadesRelacionadas(this);
                        objActivityRel.ShowDialog();
                        btnNew.Enabled = true;
                    }
                }                
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void btnGeneric_Click(object sender, EventArgs e)
        {
            try
            {
                txtClientCode_Leave(null, null);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void txtClientCode_Leave(object sender, EventArgs e)
        {
            Useful.SuspendLayout(this);
            FrmClienteBusqueda frmClient = new FrmClienteBusqueda(this);
            try
            {
                if (btnBusqCliente.Focused)
                {                   
                    frmClient.ShowDialog();
                }
                if (btnGeneric.Focused)
                {
                    txtClientCode.Text = Constant.GenericClient;
                    txtClientName.Text = string.Empty;
                    txtClientPhone.Text = string.Empty;
                    txtClientEmail.Text = string.Empty;
                    txtPersonContact.Text = string.Empty;
                    rdbBoleta.Checked = true;
                    //txtPersonContact.Text = string.Empty;
                }

                //ServicioTomaPedidos.BusinessPartner objBP;
                OfertaVentaWS.BusinessPartner objBP;
                objBP = frmClient.ObtenerCliente(txtClientCode.Text);
                if (objBP != null)
                {
                    txtClientCode.Text = objBP.CardCode;
                    txtClientDoc.Text = objBP.LicTradNum;
                    txtClientName.Text = objBP.CardName;
                    txtClientEmail.Text = objBP.Email;
                    txtPersonContact.Text = objBP.ContctPrsn;
                    txtClientPhone.Text = objBP.Telephone1;
                    errorProviderConv.SetError(txtClientCode, "");
                    flagViewfrm(true);
                }
                else
                {
                    txtClientCode.Text = string.Empty;
                    txtClientDoc.Text = string.Empty;
                    txtClientName.Text = string.Empty;
                    txtPersonContact.Text = string.Empty;
                    txtClientEmail.Text = string.Empty;
                    txtClientPhone.Text = string.Empty;
                    errorProviderConv.SetError(txtClientCode, "El código del cliente especificado es inválido o no existe");
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

        private void btnBusqCliente_Click(object sender, EventArgs e)
        {
            //frmClienteBusqueda frmClient = new frmClienteBusqueda(this);
            //frmClient.ShowDialog();
            txtClientCode_Leave(null, null);
        }

        public void insertarCliente(OfertaVentaWS.BusinessPartner objBp)
        {
            try
            {
                txtClientCode.Text = objBp.CardCode;
                txtClientName.Text = objBp.CardName;
                txtClientDoc.Text = objBp.LicTradNum;
                txtClientPhone.Text = objBp.Telephone1;
                txtClientEmail.Text = objBp.Email;
                txtPersonContact.Text = objBp.ContctPrsn;
                flagViewfrm(true);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void flagViewfrm(bool flag)
        {
            try
            {// Nota: El 'Modo Limpieza' se lanza desde fuera de éste método.
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox) ctrl.Enabled = flag;
                    if (ctrl is ComboBox)
                    {
                        //ComboBox cmbox = ctrl as ComboBox;
                        //cmbox.Enabled = flag;
                    }
                }
                foreach (Control ctrl in panelTipoCombustiblex.Controls)
                {

                    RadioButton radioButton = ctrl as RadioButton;
                    radioButton.Enabled = flag;
                }
                foreach (Control ctrl in panelUbicacionTanque.Controls)
                {
                    RadioButton radioButton = ctrl as RadioButton;
                    radioButton.Enabled = flag;
                }
                foreach (Control ctrl in panelUsoVehiculo.Controls)
                {
                    RadioButton radioButton = ctrl as RadioButton;
                    radioButton.Enabled = flag;
                }
                foreach (Control ctrl in panelComprobante.Controls)
                {
                    RadioButton radioButton = ctrl as RadioButton;
                    radioButton.Enabled = flag;
                }
                foreach (Control ctrl in panelInspeccion.Controls)
                {
                    RadioButton radioButton = ctrl as RadioButton;
                    radioButton.Enabled = flag;
                }
                foreach (Control ctrl in panelPropietario.Controls)
                {
                    RadioButton radioButton = ctrl as RadioButton;
                    radioButton.Enabled = flag;
                }
                foreach (Control ctrl in panelConVehiculo.Controls)
                {
                    RadioButton radioButton = ctrl as RadioButton;
                    radioButton.Enabled = flag;
                }
                foreach (Control ctrl in panelServicio.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        RadioButton radioButton = ctrl as RadioButton;
                        radioButton.Enabled = flag;
                    }
                }
                foreach (Control ctrl in panelCondicionVenta.Controls)
                {
                    RadioButton radioButton = ctrl as RadioButton;
                    radioButton.Enabled = flag;
                }
                var comboBoxTipo = new ComboBox();
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.GetType() == comboBoxTipo.GetType())
                    {
                        ComboBox comboBox = ctrl as ComboBox;
                        comboBox.Enabled = flag;
                    }
                }
                cmbCilindrada.Enabled = false;
                cmbCapTanque.Enabled = false;
                cmbSubEnterarse.Enabled = false;

                btnBusqCliente.Enabled = flag;
                btnGeneric.Enabled = flag;
                btnCalc.Enabled = flag;
                btnNew.Enabled = flag;
                btnSave.Enabled = flag;
                btnConvPedido.Enabled = flag;
                btnConvProforma.Enabled = flag;
                btnActividad.Enabled = !flag;
                btnActividad.Visible = !flag;

            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }

        }

        private void txtClientName_Validating(object sender, CancelEventArgs e)
        {
            if (txtClientName.Text.Trim() == string.Empty)
            {
                errorProviderConv.SetError(txtClientName, "El nombre del cliente es requerido");
                return;
            }
            errorProviderConv.SetError(txtClientName, "");
        }

        private void txtClientCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtClientCode.Text.Trim() == string.Empty)
            {
                errorProviderConv.SetError(txtClientCode, "El código del cliente es requerido");//e.Cancel = true;  
                txtClientCode.Width = 122;
                return;
            }
            errorProviderConv.SetError(txtClientCode, "");
            txtClientCode.Width = 132;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        /// <summary>
        /// Function to set the progress bar color
        /// </summary>
        /// <param name="state">1 = normal (green); 2 = error (red); 3 = warning (yellow)</param>
        public void SetProgressBarState(int state)
        {
            SendMessage(pbAvance.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }

        public void llenarConversion(ServicioTomaPedidos.Opportunity objOpportunity)
        {
            try
            {
                CargarComboBoxes();

                this.Text = "Oportunidad N° " + objOpportunity.OpprId;
                txtClientCode.Text = objOpportunity.CardCode;
                txtClientCode_Leave(null, null);
                txtClientName.Text = objOpportunity.CardName;

                //objoffer = objOpportunity.OfertaVenta;
                //if (objoffer != null)
                //{
                //    txtCodigoSAPoffer.Text = objoffer.DocEntry;
                //}
                txtCodigoSAPoffer.Text = objOpportunity.DocEntryOffer;
                txtCodigoSAPoppor.Text = objOpportunity.OpprId;

                //Cargar datos
                txtClientCode.Text = objOpportunity.CardCode;
                txtClientName.Text = objOpportunity.OfertaVenta.CardName;
                txtClientEmail.Text = objOpportunity.OfertaVenta.CardEmail;
                txtClientDoc.Text = objOpportunity.OfertaVenta.CardDoc;
                //txtPersonContact.Text = objOpportunity.OfertaVenta.card;
                txtClientPhone.Text = objOpportunity.OfertaVenta.CardPhone;

                txtPlaca.Text = objOpportunity.OfertaVenta.Placa;
                txtClase.Text = objOpportunity.OfertaVenta.Clase;
                txtMarca.Text = objOpportunity.OfertaVenta.Marca;
                txtModelo.Text = objOpportunity.OfertaVenta.Modelo;
                txtCarroceria.Text = objOpportunity.OfertaVenta.Carroceria;
                txtAnoFab.Text = objOpportunity.OfertaVenta.AnoFabricacion;
                cmbCilMotor.SelectedValue = objOpportunity.OfertaVenta.NumCilMotor;
                cmbCilMotor_SelectionChangeCommitted(null, null);
                cmbCilindrada.SelectedItem = objOpportunity.OfertaVenta.Cilindrada;
                cmbGasolina.SelectedValue = objOpportunity.OfertaVenta.GasUtilizada;
                txtRecorrido.Text = objOpportunity.OfertaVenta.Recorrido;
                if (objOpportunity.OfertaVenta.TipoCombustible == "V")
                {
                    rdbGNV.Checked = true;
                    rdbGLP.Checked = false;
                }
                else if (objOpportunity.OfertaVenta.TipoCombustible == "P")
                {
                    rdbGNV.Checked = false;
                    rdbGLP.Checked = true;
                }
                else
                {
                    rdbGNV.Checked = false;
                    rdbGLP.Checked = false;
                }
                rdbTiposCombustible_CheckedChanged(null, null);
                cmbCapTanque.SelectedItem = objOpportunity.OfertaVenta.CapTanque;
                if (objOpportunity.OfertaVenta.UbiTanque == "A")
                {
                    rdbAbajo.Checked = false;
                    rdbArriba.Checked = true;
                }
                else if (objOpportunity.OfertaVenta.UbiTanque == "O")
                {
                    rdbAbajo.Checked = true;
                    rdbArriba.Checked = false;
                }
                else
                {
                    rdbAbajo.Checked = false;
                    rdbArriba.Checked = false;
                }
                cmbTomaCarga.SelectedValue = objOpportunity.OfertaVenta.TomaCarga;
                cmbMarcaEquipo.SelectedValue = objOpportunity.OfertaVenta.MarcaEquipoConv;
                cmbGeneracion.SelectedValue = objOpportunity.OfertaVenta.Generacion;
                if (objOpportunity.OfertaVenta.UsoVehiculo == "T")
                {
                    rdbTaxi.Checked = true;
                    rdbParticular.Checked = false;
                }
                else if (objOpportunity.OfertaVenta.UsoVehiculo == "P")
                {
                    rdbTaxi.Checked = false;
                    rdbParticular.Checked = true;
                }
                else
                {
                    rdbTaxi.Checked = false;
                    rdbParticular.Checked = false;
                }
                if (objOpportunity.OfertaVenta.TipoComprobante == "B")
                {
                    rdbBoleta.Checked = true;
                    rdbFactura.Checked = false;
                }
                else if (objOpportunity.OfertaVenta.TipoComprobante == "F")
                {
                    rdbBoleta.Checked = false;
                    rdbFactura.Checked = true;
                }
                else
                {
                    rdbBoleta.Checked = false;
                    rdbFactura.Checked = false;
                }
                if (objOpportunity.OfertaVenta.flagInspeccionTecnica)
                {
                    rdvSIinspeccion.Checked = true;
                    rdbNOinspeccion.Checked = false;
                }
                else
                {
                    rdvSIinspeccion.Checked = false;
                    rdbNOinspeccion.Checked = true;
                }
                if (objOpportunity.OfertaVenta.flagEsPropietario)
                {
                    rdbSIprop.Checked = true;
                    rdbNOprop.Checked = false;
                }
                else
                {
                    rdbSIprop.Checked = false;
                    rdbNOprop.Checked = true;
                }
                if (objOpportunity.OfertaVenta.flagConVehiculo)
                {
                    rdbSIvehi.Checked = true;
                    rdbNOvehi.Checked = false;
                }
                else
                {
                    rdbSIvehi.Checked = false;
                    rdbNOvehi.Checked = true;
                }
                //if (objOpportunity.OfertaVenta.servicioadicional)
                //{
                //    rdbSIvehi.Checked = true;
                //    rdbNOvehi.Checked = false;
                //}
                //else
                //{
                //    rdbSIvehi.Checked = false;
                //    rdbNOvehi.Checked = true;
                //}
                if (objOpportunity.OfertaVenta.CondicionVenta == "CT")
                {
                    rdbContado.Checked = true;
                    rdbCredito.Checked = false;
                }
                else if (objOpportunity.OfertaVenta.CondicionVenta == "CR")
                {
                    rdbContado.Checked = false;
                    rdbCredito.Checked = true;
                }
                else
                {
                    rdbContado.Checked = false;
                    rdbCredito.Checked = false;
                }
                //cmbEnterarse.SelectedText = objOpportunity.OfertaVenta.ComoSeEntero;
                //cmbSubEnterarse.SelectedText = objOpportunity.OfertaVenta.subComoSeEntero;
                txtObs.Text = objOpportunity.OfertaVenta.Observaciones;
                //
                double porcentaje = 0;
                //Double.TryParse(objOpportunity.PorcantajeCierre, out porcentaje);
                pbAvance.Value = (int)porcentaje;
                lblPorcentajeAvance.Text = pbAvance.Value.ToString() + "%";
                if (porcentaje <= 30)
                {
                    lblPorcentajeAvance.BackColor = Color.Red;
                    SetProgressBarState(2);
                }
                else if (porcentaje <= 90)
                {
                    lblPorcentajeAvance.BackColor = Color.Yellow;
                    SetProgressBarState(3);
                }
                else
                {
                    lblPorcentajeAvance.BackColor = Color.Green;
                    SetProgressBarState(1);
                }

                //Visualización:
                txtClientCode.Enabled = false;
                txtClientName.Enabled = false;
                txtClientEmail.Enabled = false;
                txtClientDoc.Enabled = false;
                txtPersonContact.Enabled = false;
                txtClientPhone.Enabled = false;
                btnBusqCliente.Enabled = false;
                btnGeneric.Enabled = false;
                btnCalc.Enabled = true;
                btnSave.Enabled = true;
                btnSave.Text = "Actualizar";
                btnConvPedido.Enabled = true;
                btnConvProforma.Enabled = true;
                btnActividad.Enabled = true;
                btnActividad.Visible = true;
                this.btnActividad.Text = "Actividades enlazadas";
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void rdbBoleta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var checkedRadioButton = panelComprobante.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (null != checkedRadioButton)
                {
                    if (checkedRadioButton.Name.Equals("rdbBoleta"))
                    {
                        //if (flagfrmServAdfueAbierto) return;
                        //frmServAdd objfrm = new frmServAdd();
                        //flagfrmServAdfueAbierto = true;
                        //objfrm.btnCancel.Visible = true;
                        //objfrm.ShowDialog();
                        //var checkedServ = objfrm.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                        //if (null != checkedServ)
                        //{
                        //    txtServSeleccionados.Text = checkedServ.Name;
                        //}
                        //else
                        //{
                        //    rdbSIserv.Checked = false;
                        //    rdbNOserv.Checked = true;
                        //    flagfrmServAdfueAbierto = false;
                        //}

                        //Validar si el cliente es genérico - Boleta de Venta
                        //                      no es genérico - Factura o boleta según Tipo de Persona
                        if (!txtClientCode.Text.Equals(Constant.GenericClient))
                        {

                        }
                    }
                    else
                    {
                        if (txtClientCode.Text.Equals(Constant.GenericClient))
                        {
                            MessageBox.Show("Al cliente genérico le corresponde el tipo de comprobante 'Boleta'.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                        //flagfrmServAdfueAbierto = false;
                        //txtServSeleccionados.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.Resources.FullAppName + ": " + System.Environment.NewLine + ex.Message);
            }
        }
    }
}
