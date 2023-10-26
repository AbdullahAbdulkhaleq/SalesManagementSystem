using SalesManagementSystem.Views.UI.Access;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI.Designer
{
    public partial class FDMain : Form
    {
        public FDMain()
        {
            InitializeComponent();
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.FromArgb(40,180,0,0);
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.BackColor = Color.Transparent;
        }

        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public virtual void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuUser_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.Show();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.Show();
        }
    }
}
