using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI.Designer
{
    public partial class FDMain : Form
    {
        public FDMain()
        {
            InitializeComponent();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
