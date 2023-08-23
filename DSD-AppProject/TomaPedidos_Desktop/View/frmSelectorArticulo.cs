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
    public partial class frmSelectorArticulo : Form
    {
        public ServicioTomaPedidos.ServicioTomaPedidos webService { get; set; }
        public FrmPedidoRegistro objPedidoRegistro = null;
        public frmSelectorArticulo()
        {
            if (webService == null)
                webService = new ServicioTomaPedidos.ServicioTomaPedidos();
            InitializeComponent();
        }

        public frmSelectorArticulo(FrmPedidoRegistro objRePe)
        {
            if (webService == null)
                webService = new ServicioTomaPedidos.ServicioTomaPedidos();
            this.objPedidoRegistro = objRePe;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Useful.SuspendLayout(this);
                BuscarArticulos();
                if (dgvItems.RowCount > 0)
                {
                    lblInformar.Visible = false;
                    btnSelect.Enabled = true;
                    btnSelect.Focus();
                    if (dgvItems.RowCount == 1)
                    {
                        //btnSelect_Click(null, null);
                    }
                    else
                    {
                        //this.Height = 429;
                        //lblTotal.Text = dgvItems.RowCount.ToString();
                        //lblTexto.Visible = true;
                        //lblTotal.Visible = true;
                    }
                }
                else
                {
                    //lblTotal.Text = dgvItems.RowCount.ToString();
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

        private void BuscarArticulos()
        {
            ParamsItemSelector objParams = new ParamsItemSelector();
            objParams.Combustible = cmbGasType.SelectedValue.ToString();
            objParams.Generacion = cmbGeneration.SelectedValue.ToString();
            objParams.NroCilMotor = cmbCilMotorNumber.SelectedValue.ToString();
            objParams.Cilindrada = cmbCylinderCapacity.SelectedItem.ToString();
            objParams.TipoMultiValvula = cmbValveType.SelectedItem.ToString();
            objParams.ModeloMultiValvula = cmbValveModel.SelectedValue.ToString();
            objParams.TipoToma = cmbTipoDeToma.SelectedValue != null ? cmbTipoDeToma.SelectedValue.ToString() : "";

            ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
            itemBindingSource.DataSource = servicio.BusquedaArticulosSelectorListSAP(Conversion.Serialize<ParamsItemSelector>(objParams), "");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                Useful.SuspendLayout(this);
                this.objPedidoRegistro.InsertarArticuloDataGridView((TomaPedidos. ServicioTomaPedidos.Item)itemBindingSource.Current, false, -1); //-1 No darle valor
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSelectorArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                if (webService == null)
                    webService = new ServicioTomaPedidos.ServicioTomaPedidos();
                CargarComboTomaCarga();
                CargarComboCombustible();
                CargarComboListaPrecios();
                CargarComboGeneracion();
                CargarComboNumCilindros();
                CargarComboUbicacionTanque();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void CargarComboListaPrecios()
        {
            try
            {
                cmbListaPrecios.DataSource = Conversion.Deserialize<List<ParamsComboBoxAux>>(webService.ObtenerListaPrecios());
                cmbListaPrecios.ValueMember = "Value";
                cmbListaPrecios.DisplayMember = "Description";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarComboCombustible()
        {
            cmbGasType.DataSource = webService.ObtenerValoresComboBoxDtable("TipoComb");
            cmbGasType.ValueMember = "Codigo";
            cmbGasType.DisplayMember = "Descripcion";
            cmbGasType_SelectionChangeCommitted(null, null);
        }

        private void CargarComboGeneracion()
        {
            cmbGeneration.DataSource = webService.ObtenerValoresComboBoxDtable("Generacion");
            cmbGeneration.ValueMember = "Codigo";
            cmbGeneration.DisplayMember = "Descripcion";
        }

        private void CargarComboNumCilindros()
        {
            cmbCilMotorNumber.DataSource = webService.ObtenerValoresComboBoxDtable("NmCilMotor");
            cmbCilMotorNumber.ValueMember = "Codigo";
            cmbCilMotorNumber.DisplayMember = "Descripcion";
            cmbCilMotorNumber_SelectionChangeCommitted(null, null);
        }

        private void CargarComboUbicacionTanque()
        {
            cmbValveModel.DataSource = webService.ObtenerValoresComboBoxDtable("UbiTanque");
            cmbValveModel.ValueMember = "Codigo";
            cmbValveModel.DisplayMember = "Descripcion";
        }

        private void CargarComboTomaCarga()
        {
            cmbTipoDeToma.DataSource = webService.ObtenerValoresComboBoxDtable("TomaCarga");
            cmbTipoDeToma.ValueMember = "Codigo";
            cmbTipoDeToma.DisplayMember = "Descripcion";
        }

        private void cmbCilMotorNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cmbCylinderCapacity.Items.Clear();
                switch (cmbCilMotorNumber.SelectedIndex)
                {
                    case 0:
                        for (int i = 0; i < Constant.ArrayListCilMotor3.Length; i++)
                        {
                            cmbCylinderCapacity.Items.Add(Constant.ArrayListCilMotor3[i].ToString());
                        }
                        break;
                    case 1:
                        for (int i = 0; i < Constant.ArrayListCilMotor4.Length; i++)
                        {
                            cmbCylinderCapacity.Items.Add(Constant.ArrayListCilMotor4[i].ToString());
                        }
                        break;
                    case 2:
                        for (int i = 0; i < Constant.ArrayListCilMotor6.Length; i++)
                        {
                            cmbCylinderCapacity.Items.Add(Constant.ArrayListCilMotor6[i].ToString());
                        }
                        break;
                    case 3:
                        for (int i = 0; i < Constant.ArrayListCilMotor8.Length; i++)
                        {
                            cmbCylinderCapacity.Items.Add(Constant.ArrayListCilMotor8[i].ToString());
                        }
                        break;
                    default:
                        break;
                }
                cmbCylinderCapacity.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void cmbGasType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cmbValveType.Items.Clear();
                if (cmbGasType.SelectedValue.Equals(TomaPedidos.Commons.Constant.OFFER.TIPO_COMBUSTIBLE.GNV))
                {
                    for (int i = 0; i < Constant.ArrayListGNV.Length; i++)
                    {
                        cmbValveType.Items.Add(Constant.ArrayListGNV[i]);
                    }
                    cmbTipoDeToma.Enabled = false;
                    cmbTipoDeToma.SelectedIndex = -1;
                }
                else
                {
                    for (int i = 0; i < Constant.ArrayListGLP.Length; i++)
                    {
                        cmbValveType.Items.Add(Constant.ArrayListGLP[i]);
                    }
                    cmbTipoDeToma.Enabled = true;
                    cmbTipoDeToma.SelectedIndex = 0;
                }
                cmbValveType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }
    }
}
