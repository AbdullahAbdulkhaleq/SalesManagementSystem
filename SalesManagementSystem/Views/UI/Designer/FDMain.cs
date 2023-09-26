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

        private void BExit_MouseEnter(object sender, EventArgs e)
        {
            BExit.BackColor = Color.FromArgb(40,180,0,0);
        }

        private void BExit_MouseLeave(object sender, EventArgs e)
        {
            BExit.BackColor = Color.Transparent;
        }


        private void BMini_Click(object sender, EventArgs e)
        {

        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Size = MinimumSize;
        }
    }
}
