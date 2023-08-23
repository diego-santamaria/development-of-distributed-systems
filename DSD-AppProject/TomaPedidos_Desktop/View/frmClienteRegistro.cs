using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaPedidos.Bean;
using TomaPedidos.Commons;

namespace TomaPedidos.View
{
    public partial class frmClienteRegistro : Form
    {
        public bool flagRegistroExitoso = false;
        //private DataTable TipoDocDataSource;
        //private DataTable TipoPerDataSource;
        public frmClienteRegistro()
        {
            InitializeComponent();
            LlenarcomboTipoDocumento();
            LlenarcomboTipoPersona();
            this.SuspendLayout();
            //backgroundWorkerCustomerRegister.RunWorkerAsync();
            //BackgroundWorker();
        }

        private void FrmClienteRegistro_Load(object sender, EventArgs e)
        {
            CmbTipoPersona_SelectionChangeCommitted(null, null);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            OfertaVentaWS.OfertaVentaServiceClient proxy = null;
            try
            {
                if (ValidarRegistroCliente())
                {
                    Useful.SuspendLayout(this);
                    proxy = new OfertaVentaWS.OfertaVentaServiceClient();
                    OfertaVentaWS.BusinessPartner objCliente = new OfertaVentaWS.BusinessPartner();
                    objCliente.CardCode = "C" + txtDocNumber.Text.Trim();

                    objCliente.CardName = string.IsNullOrEmpty(txtRazonSocial.Text) || txtRazonSocial.Enabled == false ? txtNombres.Text.ToUpper() + " " + txtApePaterno.Text.ToUpper().Trim() + " " + txtApeMaterno.Text.ToUpper().Trim() : txtRazonSocial.Text.ToUpper();
                    //objCliente.CardForeignName = txtRazonSocial.Text == null || txtRazonSocial.Text == "" || txtRazonSocial.Enabled == false ? txtNombres.Text.ToUpper() + " " + txtApePaterno.Text.ToUpper().Trim() + " " + txtApeMaterno.Text.ToUpper().Trim() : txtRazonSocial.Text.ToUpper();
                    objCliente.LicTradNum = txtDocNumber.Text.Trim();
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
                    objCliente.Active = "Y";

                    //string json = Conversion.Serialize(objCliente);
                    string sResult = proxy.RegistrarCliente(objCliente);
                    if (sResult.Equals(Constant.OK))
                    {
                        //MessageBox.Show("El cliente "+ txtClientName.Text + " se registró satisfactoriamente.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flagRegistroExitoso = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(sResult, Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FaultException<OfertaVentaWS.EntityException> ex)
            {
                Useful.ShowErrorMsg(null, fEEex: ex);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                if (proxy != null) proxy.Close();
                Useful.ResumeLayout(this);
            }
        }

        public void LimpiarFormulario()
        {
            txtRazonSocial.Clear();
            txtDocNumber.Clear();
            txtDocNumber.Clear();
            txtDocNumber.Clear();
            txtDocNumber.Clear();
            txtDocNumber.Clear();
            txtDocNumber.Clear();

        }

        private void TxtClientName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtRazonSocial.Text.Trim().Equals(string.Empty) && txtRazonSocial.Enabled == true)
                {
                    errorProvider.SetError(txtRazonSocial, "El nombre o razón social del cliente es requerido");
                }
                errorProvider.SetError(txtRazonSocial, "");
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void TxtDocNumber_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtDocNumber.Text.Trim().Equals(string.Empty))
                {
                    errorProvider.SetError(txtDocNumber, "El número del documento del cliente especificado es requerido");
                    return;
                }
                errorProvider.SetError(txtDocNumber, "");
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private bool ValidarRegistroCliente()
        {
            bool flagRegistrar = false;
            try
            {
                if (cmbTipoPersona.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione el tipo de persona del cliente especificado.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return flagRegistrar;
                }

                if (cmbTipoDoc.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione el tipo de documento del cliente.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return flagRegistrar;
                }
                else
                {
                    if ((cmbTipoPersona.SelectedValue.ToString().Equals("TPJ") & cmbTipoDoc.SelectedValue.ToString().Equals("0")) ||
                        (cmbTipoPersona.SelectedValue.ToString().Equals("TPN") & cmbTipoDoc.SelectedValue.ToString().Equals("1")))
                    {
                        MessageBox.Show("Especifique el tipo de documento correcto para este cliente.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return flagRegistrar;
                    }
                }
                if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()) &&
                    cmbTipoPersona.SelectedValue.ToString().Equals("TPJ"))
                {
                    MessageBox.Show("Por favor, indique la razón social del cliente jurídico.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider.SetError(txtRazonSocial, "La razón social del cliente jurídico es requerida");
                    return flagRegistrar;
                }
                if (string.IsNullOrEmpty(txtPersonaContact.Text.Trim()) &&
                   cmbTipoPersona.SelectedValue.ToString().Equals("TPJ"))
                {
                    MessageBox.Show("Por favor, indique la persona de contacto para el cliente jurídico.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider.SetError(txtPersonaContact, "La persona de contacto del cliente jurídico es requerida");
                    return flagRegistrar;
                }
                if ((string.IsNullOrEmpty(txtNombres.Text.Trim()) ||
                    string.IsNullOrEmpty(txtApePaterno.Text.Trim()) ||
                    string.IsNullOrEmpty(txtApeMaterno.Text.Trim())) &&
                    cmbTipoPersona.SelectedValue.ToString().Equals("TPN"))
                {
                    MessageBox.Show("Por favor, indique el nombre del cliente natural.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider.SetError(txtNombres, "El nombre del cliente natural es requerido");
                    return flagRegistrar;
                }
                if (string.IsNullOrEmpty(txtDocNumber.Text.Trim()))
                {
                    MessageBox.Show("Por favor, indique el número del documento del cliente.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider.SetError(txtDocNumber, "El número del documento del cliente especificado es requerido");
                    return flagRegistrar;
                }
                if (string.IsNullOrEmpty(txtCelular.Text.Trim()) &&
                    string.IsNullOrEmpty(txtTelf1.Text.Trim()) &&
                    string.IsNullOrEmpty(txtTelf2.Text.Trim()))
                {
                    MessageBox.Show("Por favor, ingrese al menos un número telefónico del cliente.", Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //errorProvider.SetError(txtCelular, "Debe ingresar al menos un número telefónico");
                    return flagRegistrar;
                }
                //else
                //{
                //    errorProvider.SetError(txtCelular,"");
                //}

                flagRegistrar = true;
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            return flagRegistrar;
        }

        //private void DataSourceComboTipoPer()
        //{
        //    try
        //    {
        //        // ServicioTomaPedidos.ServicioTomaPedidos serv = new ServicioTomaPedidos.ServicioTomaPedidos();
        //        //cmbTipoDoc.DataSource = serv.llenarDatosComboEspecificado("TipoPer");
        //        //cmbTipoDoc.ValueMember = "Codigo";
        //        //cmbTipoDoc.DisplayMember = "Descripcion";

        //        ServicioTomaPedidos.ServicioTomaPedidos serv = new ServicioTomaPedidos.ServicioTomaPedidos();
        //        TipoPerDataSource = serv.ObtenerValoresComboBoxDtable("TipoPer");

        //    }
        //    catch (Exception ex)
        //    {
        //        Useful.ShowErrorMsg(ex);
        //    }
        //}

        //private void DataSourceComboTipoDoc()
        //{
        //    try
        //    {
        //        // ServicioTomaPedidos.ServicioTomaPedidos serv = new ServicioTomaPedidos.ServicioTomaPedidos();
        //        //cmbTipoDoc.DataSource = serv.llenarDatosComboEspecificado("TipoDoc");
        //        //cmbTipoDoc.ValueMember = "Codigo";
        //        //cmbTipoDoc.DisplayMember = "Descripcion";
        //        ServicioTomaPedidos.ServicioTomaPedidos serv = new ServicioTomaPedidos.ServicioTomaPedidos();
        //        TipoDocDataSource = serv.ObtenerValoresComboBoxDtable("TipoDoc");
        //        foreach (var item in TipoDocDataSource.Rows)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Useful.ShowErrorMsg(ex);
        //    }
        //}

        //private void BackgroundWorkerCustomerRegister_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    DataSourceComboTipoPer();
        //    DataSourceComboTipoDoc();
        //}

        //private void BackgroundWorkerCustomerRegister_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    if (e.Error != null)
        //    {
        //        LlenarcomboTipoDocumento();
        //        LlenarcomboTipoPersona();
        //    }
        //    else
        //    {
        //        cmbTipoDoc.DataSource = TipoDocDataSource;
        //        cmbTipoDoc.ValueMember = "Codigo";
        //        cmbTipoDoc.DisplayMember = "Descripcion";
        //        cmbTipoPersona.DataSource = TipoPerDataSource;
        //        cmbTipoPersona.ValueMember = "Codigo";
        //        cmbTipoPersona.DisplayMember = "Descripcion";

        //        if (cmbTipoDoc.DataSource == null)
        //        {
        //            LlenarcomboTipoDocumento();
        //        }

        //        if (cmbTipoPersona.DataSource == null)
        //        {
        //            LlenarcomboTipoPersona();
        //        }
        //        cmbTipoDoc.SelectedIndex = -1;
        //        cmbTipoPersona.SelectedIndex = -1;
        //        cmbTipoPersona.Focus();
        //        this.ResumeLayout();
        //    }
        //}

        private void LlenarcomboTipoDocumento()
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

        private void LlenarcomboTipoPersona()
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

        private void CmbTipoPersona_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoPersona.SelectedValue != null)
                {
                    this.SuspendLayout();
                    FlagViewfrm(true);
                    switch (cmbTipoPersona.SelectedValue.ToString())
                    {
                        case "TPJ":
                            txtRazonSocial.Enabled = true;
                            txtPersonaContact.Enabled = true;
                            txtNombres.Enabled = false;
                            txtApeMaterno.Enabled = false;
                            txtApePaterno.Enabled = false;
                            cmbTipoDoc.SelectedValue = "1";
                            break;
                        case "TPN":
                            txtRazonSocial.Enabled = false;
                            txtPersonaContact.Enabled = false;
                            txtNombres.Enabled = true;
                            txtApeMaterno.Enabled = true;
                            txtApePaterno.Enabled = true;
                            cmbTipoDoc.SelectedValue = "0";
                            break;
                        default:
                            txtRazonSocial.Enabled = false;
                            txtPersonaContact.Enabled = false;
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

        private void FlagViewfrm(bool flag)
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
            btnSave.Enabled = flag;
        }

        private void TxtNombres_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtNombres.Text.Trim().Equals(string.Empty) && txtNombres.Enabled == true)
                {
                    errorProvider.SetError(txtNombres, "El nombre o razón social del cliente es requerido");
                }
                errorProvider.SetError(txtNombres, "");
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void TxtOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Useful.onlyNumbers(e);
        }



    }
}
