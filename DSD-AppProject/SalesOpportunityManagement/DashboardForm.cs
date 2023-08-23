using SalesOpportunityManagement.Enums;
using SalesOpportunityManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesOpportunityManagement
{
    public partial class DashboardForm : Form
    {
        int PanelWidth;
        public HomeUserControl home;
        public SalesUserControl sales;
        public CustomerUserControl customer;
        public ActivityUserControl activity;
        public OpportUserControl opport;

        public DashboardForm()
        {
            InitializeComponent();
            SetInfoUser("Gerardo Sandoval Echevarría", "Administrador");
            home = new HomeUserControl();
            sales = new SalesUserControl();
            customer = new CustomerUserControl(this);
            activity = new ActivityUserControl(this);
            opport = new OpportUserControl(this);

            PanelWidth = LeftPanel.Width;
            ShowUserControl(home);
        }

        private void SetInfoUser(string name, string rol)
        {
            lblUserName.Text = name;
            lblRol.Text = rol;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MoveSidePanel(Control btn)
        {
            SidePanel.Top = btn.Top;
            SidePanel.Height = btn.Height;
        }

        public void ShowUserControl(UserControl uc)
        {
            this.SuspendLayout();
            uc.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            uc.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(uc);
            this.ResumeLayout();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(HomeButton);
            ShowUserControl(home);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(SalesButton);
            ShowUserControl(sales);
        }

        private void OpporButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(OpporButton);
            opport.ControlsMenuHandler(OperationType.ot_Find);
            ShowUserControl(opport);
        }

        private void ActivityButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(ActivityButton);
            ShowUserControl(activity);
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(CustomerButton);
            customer.ControlsMenuHandler(OperationType.ot_Find);
            ShowUserControl(customer);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(UsersButton);
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(ConfigButton);
        }
    }
}
