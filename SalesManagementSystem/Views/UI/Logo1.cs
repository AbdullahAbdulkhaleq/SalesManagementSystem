using SalesManagementSystem.Views.UI.Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI
{
    public partial class Logo1 : Form
    {
        public Logo1()
        {
            InitializeComponent();
        }

        private void TLogo_Tick(object sender, EventArgs e)
        {
            if (PBMain.Value != 100)
            {

                PBMain.Value += 1;
                LTimer.Text = PBMain.Value.ToString()+"%";
                if (PBMain.Value == 75)
                {
                    pictureBox1.Visible = true;
                }
            }
            else
            {
                TLogo.Stop();
                FLogin fLogin = new FLogin();
                fLogin.Show();
                this.Hide();
            }
        }
    }
}
