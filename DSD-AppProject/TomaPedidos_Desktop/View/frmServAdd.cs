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
    public partial class frmServAdd : Form
    {
        public frmServAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton rdbServ = control as RadioButton;
                        if (rdbServ.Checked)
                            rdbServ.Checked = false;
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Useful.ShowErrorMsg(ex);
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
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
    }
}
