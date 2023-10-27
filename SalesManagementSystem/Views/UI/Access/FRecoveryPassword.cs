using SalesManagementSystem.Views.UI.Designer;
using System;
using SalesManagementSystem.Views.Functions;

namespace SalesManagementSystem.Views.UI.Access
{
    public partial class FRecoveryPassword : FDMain
    {
        public FRecoveryPassword()
        {
            InitializeComponent();
        }
        private void btnRecovery_Click(object sender, EventArgs e)
        {
            try
            {
                FunMessage.Print(int.Parse(TxtRecoveryQuestionsThree.Text));

                TxtRecoveryQuestionsThree.Text = String.Empty;
                TxtUserName.Text = String.Empty;
            }
            catch
            {
            }
        }

        public override void BtnExit_Click(object sender, EventArgs e)
        {
            FRecoveryPassword.ActiveForm.Close();
        }


        private void FFrgotPassword_Load(object sender, EventArgs e)
        {
            CBRecoveryQuestionsOne.SelectedIndex = 0;
            CBRecoveryQuestionsTow.SelectedIndex = 1;
            CBRecoveryQuestionsThree.SelectedIndex = 2;
        }
    }
}
