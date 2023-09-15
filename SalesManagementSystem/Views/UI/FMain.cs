using SalesManagementSystem.Views.UI.Access;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void TMain_Tick(object sender, System.EventArgs e)
        {

            if (this.Opacity < 100)
            {
                if (PBMain.Value != 100)
                {

                    PBMain.Value = PBMain.Value + 5;
                }
                else
                {
                    PBMain.Value = 100;
                    TMain.Stop();
                    this.Hide();
                    FLogin fLogin = new FLogin();
                    fLogin.Show();

                }

                this.Opacity += 0.1;
            }
        }
    }
}
