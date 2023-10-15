using SalesManagementSystem.Views.UI.Designer;
using System;
using SalesManagementSystem.Views.Functions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI.Access
{
    public partial class FFrgotPassword : FDMain
    {
        public FFrgotPassword()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            try
            {
                FunMessage.Print(int.Parse(TAnswer.Text));

                TAnswer.Text = String.Empty;
                TUserName.Text = String.Empty;
            }
            catch
            {
            }
        }

        private void FFrgotPassword_Load(object sender, EventArgs e)
        {

        }

    }
}
