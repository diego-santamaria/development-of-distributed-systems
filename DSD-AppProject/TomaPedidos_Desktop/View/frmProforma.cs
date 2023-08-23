using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaPedidos.Bean;
using TomaPedidos.Commons;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
using System.IO;

using Spire.Xls;

namespace TomaPedidos.View
{
    public partial class frmProforma : Form
    {
        private Offer objOferta;
        private Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        private Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        private Microsoft.Office.Interop.Excel.Application xlApp;
        private string docName = "ModeloProforma.xlsx";
        private string exePath;
        private string pdfDocCurrentName = string.Empty; 
        private string ExcelDocCurrentPath = string.Empty;
        private string ultimaOferta = string.Empty;

        public frmProforma()
        {
            InitializeComponent();
            string dayname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.ToString("dddd"));
            lblDate.Text = dayname + ", " + DateTime.Now.ToString("dd") 
                + " de " + DateTime.Now.ToString("MMMM") 
                + " de " + DateTime.Now.ToString("yyyy");
            timer.Enabled = true;
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void frmProforma_Load(object sender, EventArgs e)
        {
            try
            {
                string Code = string.Empty;
                int CodeInt;
                ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
                Code = servicio.ObtenerNumeroCotizacion();

                lblCotiNum.Text = "";
                if (int.TryParse(Code, out CodeInt))
                {
                    Code = (CodeInt + 1).ToString();
                    txtCodigoSAP.Text = Code;
                    while (lblCotiNum.Text.Length < 7)
                    {
                        lblCotiNum.Text += "0";
                    }
                    lblCotiNum.Text += Code;
                }
                else
                {
                    throw (new Exception(message: Code));
                }
                
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
        }

        public void llenarProforma(Offer objOfert)
        {
            try
            {
                this.objOferta = objOfert;
                txtCardName.Text = objOfert.CardName;
                txtCardEmail.Text = objOfert.CardEmail;
                txtCardDoc.Text = objOfert.CardDoc;
                txtCardPhone.Text = objOfert.CardPhone;
                txtPlaca.Text = objOfert.Placa;
                txtMarca.Text = objOfert.Marca;
                txtModelo.Text = objOfert.Modelo;

                txtObservaciones.Text = objOfert.Observaciones;
                if (objOfert.TipoComprobante != null)
                {
                    if (cmbTipoComprobante.Items.Contains(objOfert.TipoComprobante))
                        cmbTipoComprobante.SelectedIndex = cmbTipoComprobante.Items.IndexOf(objOfert.TipoComprobante);
                    else
                        cmbTipoComprobante.SelectedIndex = 0;
                }
                else { cmbTipoComprobante.SelectedIndex = 0; }
                
                ultimaOferta = objOfert.TipoCombustible == "GNV" ? " - Tanque lleno." : " - S/20.00 de GLP.";
                lblInfoOferta.Text = "Los precios incluyen: " + Environment.NewLine + " - IGV e instalación." + Environment.NewLine +
                    " - Certificado de conversión." + Environment.NewLine + ultimaOferta + "";
            } catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }        
        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de registrar esta cotización como una Oportunidad de venta?" + Environment.NewLine + "Nota: Este formulario se cerrará.", Properties.Resources.FullAppName,
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                Opportunity objOp = new Opportunity();
                ConstruirDocumentoSAP(ref objOp);
                AddSalesOpportunityToDataBase(objOp);
                Imprimir();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                Useful.SuspendLayout(this);
                MakePreview();
                ExportToPdf();
                frmProformaPreview objfrm = new frmProformaPreview(exePath + pdfDocCurrentName + ".pdf", this);
                objfrm.ShowDialog();               

            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }
            finally
            {
                DeleteDocument(ExcelDocCurrentPath); //Borramos el excel generado
                DeleteDocument(exePath + pdfDocCurrentName + ".pdf"); //Borramos el pdf generado
                Useful.ResumeLayout(this);
                FinalizarProcesoExcel();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (MessageBox.Show("¿Está seguro de registrar esta cotización como una Oportunidad de venta?" + Environment.NewLine + "Nota: Este formulario se cerrará.", Properties.Resources.FullAppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                Opportunity objOp = new Opportunity();
                ConstruirDocumentoSAP(ref objOp);  
                AddSalesOpportunityToDataBase(objOp);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void ConstruirDocumentoSAP(ref Opportunity objOp)
        {
            Offer objOf = new Offer();
            //var rnd = new Random(DateTime.Now.Millisecond);
            //int random = rnd.Next(0, 999999999);
            //objOf.CardCode = Constant.GenericClient;
            //objOf.Identifier = Useful.isText(random);
            objOf.ItemCode = "EMI-10018343";
            objOf.Price = 1231;

            //Oportunidad
            objOp.CardCode = Constant.GenericClient;
            objOp.OfertaVenta = objOf;
        }

        public static void AddSalesOpportunityToDataBase(Opportunity objOp)
        {
            string jsonOp, sResult;
            ServicioTomaPedidos.ServicioTomaPedidos servicio = new ServicioTomaPedidos.ServicioTomaPedidos();
            
            jsonOp = Conversion.Serialize<Opportunity>(objOp);
            sResult = servicio.GuardarOportunidadDeVenta(jsonOp);
            if (sResult.Equals(Constant.OK))
            {
                MessageBox.Show("Oportunidad de venta registrada exitosamente.", Properties.Resources.FullAppName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(sResult, Properties.Resources.FullAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        public void Imprimir()
        {
            try
            {
                Useful.SuspendLayout(this);
                MakePreview();
                ExportToPdf();
                frmProformaPreview objfrm = new frmProformaPreview(exePath + pdfDocCurrentName + ".pdf", this);
                objfrm.imprimir();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DeleteDocument(ExcelDocCurrentPath); //Borramos el excel generado
                DeleteDocument(exePath + pdfDocCurrentName + ".pdf"); //Borramos el pdf generado
                Useful.ResumeLayout(this);
                FinalizarProcesoExcel();
            }
        }

        private void MakePreview()
        {
            try 
	        {
                exePath = string.Empty;
                string docPath = string.Empty;
                string pathDest = string.Empty;
                ExcelDocCurrentPath = string.Empty;
                exePath = AppDomain.CurrentDomain.BaseDirectory;
                docPath = exePath + "Resources\\PlantillaExcel\\";
                pathDest = exePath + "Resources\\";
                //Trabajamos con una copia
                if (!File.Exists(docPath + docName))
                {
                    throw (new Exception(message: "La plantilla base no se encuentra disponible."));
                }
                pdfDocCurrentName = "Proforma" + lblCotiNum.Text;
                ExcelDocCurrentPath = pathDest + "Proforma" + lblCotiNum.Text + ".xlsx";
                File.Copy(docPath + docName, ExcelDocCurrentPath, true);
                CompletarExcelProforma();       
	        }
	        catch (Exception)
	        {		
		        throw;
	        }            
            finally{
                timer.Enabled = true;
            }
        }

        private void CompletarExcelProforma()
        {
            try
            {
                Range xlRange;
                xlApp = new Microsoft.Office.Interop.Excel.Application();               
                xlWorkBook = (Microsoft.Office.Interop.Excel.Workbook)xlApp.Workbooks.Open(ExcelDocCurrentPath);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Sheets["PlantillaCotizacion"];
                timer.Enabled = false;

                //Número de cotización
                xlRange = xlWorkSheet.get_Range("D2");                
                xlRange.Value = lblCotiNum.Text;

                //Fecha y hora de la impresión
                xlRange = xlWorkSheet.get_Range("G2");
                xlRange.Value = lblDate.Text + "   " + lblTime.Text;

                //Datos del cliente
                xlRange = xlWorkSheet.get_Range("D5");
                xlRange.Value = txtCardName.Text;
                xlRange = xlWorkSheet.get_Range("D7");
                xlRange.Value = txtCardAddress.Text;
                xlRange = xlWorkSheet.get_Range("D9");
                xlRange.Value = txtCardEmail.Text;
                xlRange = xlWorkSheet.get_Range("D11");
                xlRange.Value = txtCardDoc.Text;
                xlRange = xlWorkSheet.get_Range("D13");
                xlRange.Value = txtCardPhone.Text;

                //Datos del pedido
                xlRange = xlWorkSheet.get_Range("E17");
                xlRange.Value = txtPlaca.Text;
                xlRange = xlWorkSheet.get_Range("E19");
                xlRange.Value = txtMarca.Text;
                xlRange = xlWorkSheet.get_Range("E21");
                xlRange.Value = txtModelo.Text;
                xlRange = xlWorkSheet.get_Range("E23");
                xlRange.Value = txtDescrip.Text;
                xlRange = xlWorkSheet.get_Range("E25");
                xlRange.Value = txtCapHidraTanque.Text;
                xlRange = xlWorkSheet.get_Range("E27");
                xlRange.Value = txtEquiEnergGasolina.Text;
                xlRange = xlWorkSheet.get_Range("E29");
                xlRange.Value = txtPrecioConv.Text;
                xlRange = xlWorkSheet.get_Range("E31");
                xlRange.Value = txtCodigoSAP.Text;

                //Detalles adicionales
                xlRange = xlWorkSheet.get_Range("B37");
                xlRange.Value = ultimaOferta;
                xlRange = xlWorkSheet.get_Range("G39");
                xlRange.Value = cmbTipoComprobante.Text;
                xlRange = xlWorkSheet.get_Range("B42");
                xlRange.Value = txtObservaciones.Text;
                xlWorkBook.Save();
            }
            catch (Exception)
            {                
                throw;
            }
            finally
            {   // Close the workbook object.
                if (xlWorkBook != null)
                {
                    xlWorkBook.Close(false, Type.Missing, Type.Missing);
                    xlWorkBook = null;
                }
                // Quit Excel and release the ApplicationClass object.
                if (xlApp != null)
                {
                    xlApp.Quit();
                    xlApp = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers(); 
            }  
        }

        private void FinalizarProcesoExcel()
        {
            Useful.ReleaseObject(xlApp);
            Useful.ReleaseObject(xlWorkBook);
            Useful.ReleaseObject(xlWorkSheet);
        }

        private void DeleteDocument(string docPath)
        {
            if (System.IO.File.Exists(docPath))
            {
                try
                {
                    System.IO.File.Delete(docPath);
                }
                catch (System.IO.IOException e)
                {
                    throw e;
                }
            }
        }    

        private void frmProforma_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ExcelDocCurrentPath = string.Empty;
                pdfDocCurrentName = string.Empty;
                FinalizarProcesoExcel();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }
                
        private void ExportToPdf()
        {
            try
            {
                using (Spire.Xls.Workbook workbook = new Spire.Xls.Workbook())
                {
                    workbook.LoadFromFile(ExcelDocCurrentPath);
                    workbook.ConverterSetting.SheetFitToPage = true;                    
                    workbook.SaveToFile(pdfDocCurrentName + ".pdf", FileFormat.PDF);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Useful.ResumeLayout(this);
            }
        }       
    }
}
