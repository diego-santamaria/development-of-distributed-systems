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

namespace TomaPedidos.View
{
    public partial class frmProformaPreview : Form
    {
        private frmProforma objfrm;
        public frmProformaPreview(string path, frmProforma objfrm)
        {
            InitializeComponent();
            this.objfrm = objfrm;
            this.Text = "  Proforma N° " + objfrm.lblCotiNum.Text;
            axAcroPDF.src = path;
            axAcroPDF.setZoom(65);
            
        }

        public void imprimir()
        {
            try
            {
                axAcroPDF.printAll();
                //Wait(5);
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            } 
        }

        private void Wait(int seconds)
        {
            DateTime start = DateTime.Now;
            while (start.AddSeconds(seconds) >= DateTime.Now)
            {
                Application.DoEvents();
            }
        }
    }
}
