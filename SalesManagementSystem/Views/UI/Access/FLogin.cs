using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Views.Functions;
using SalesManagementSystem.Views.UI.Inventory;
using SalesManagementSystem.Views.UI.Purchasing;
using SalesManagementSystem.Views.UI.Sales;
using SalesManagementSystem.Views.Interface;
using SalesManagementSystem.Views.UI.Designer;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI.Access
{
    public partial class FLogin : FDMain, ILogin
    {
        LoginPresenter Presenter;

        public string UserName { get => TUserName.Text; set => TUserName.Text = value; }
        public string UserPassword { get => TUserPassword.Text; set => TUserPassword.Text = value; }

        private int LoginCount = 1;
        private bool Logined = false;

        public FLogin()
        {
            InitializeComponent();
            Presenter = new LoginPresenter(this);

        }


        private void LinFrgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FFrgotPassword frgotPassw = new FFrgotPassword();
            frgotPassw.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.LoginCount <=3)
                {
                    int Message = Presenter.Login();

                    FMessage.Print(Presenter.Login());
                    if(Message >5)
                    {

                        if (Message == 1)
                        {
                            FHomePurchasing fHome = new FHomePurchasing();
                            fHome.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"User {UserName} is Block place ");
                    }
                }
                else
                {
                    FMessage.Print(UserName);
                }
            }
             catch
            {
               
            }
            finally
            {
                this.LoginCount++;
            }
        }
    }
}
