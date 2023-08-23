using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaPedidos.View
{
    public partial class frmInfoApp : Form
    {
        public frmInfoApp()
        {
            InitializeComponent();
            lblUsuario.Text = frmLogin.infoApp.Username;
            lblAppVersion.Text = frmLogin.infoApp.AppVersion;
            lblServName.Text = frmLogin.infoApp.WebServName;
            lblServVersion.Text = frmLogin.infoApp.WebServVersion;
            lblDataBaseName.Text = frmLogin.infoApp.DataBaseName;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
