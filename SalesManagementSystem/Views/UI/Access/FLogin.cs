using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Views.Interface;
using SalesManagementSystem.Views.UI.Designer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI.Access
{
    public partial class FLogin : FDMain, ILogin
    {
        LoginPresenter Presenter;

        public string UserName { get => TUserName.Text; set => TUserName.Text = value; }
        public string UserPassword { get => TUserPassword.Text; set => TUserPassword.Text = value; }

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
            if(Presenter.Login())
            {
                FHome fHome = new FHome();
                fHome.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
