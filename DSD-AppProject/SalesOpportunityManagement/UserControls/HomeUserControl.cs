using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesOpportunityManagement.UserControls
{
    public partial class HomeUserControl : BaseUserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
            ShowDate();
        }

        private void ShowDate()
        {
            label4.Text = string.Format("¡Bienvenido! Hoy es {0}, {1} de {2} de {3}"
                , DateTime.Today.ToString("dddd")
                , DateTime.Today.ToString("dd")
                , DateTime.Today.ToString("MMMM")
                , DateTime.Today.ToString("yyyy")); 
        }
    }
}
