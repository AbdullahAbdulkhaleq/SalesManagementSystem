using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Views.Functions;
using SalesManagementSystem.Views.UI.Inventory;
using SalesManagementSystem.Views.UI.Purchasing;
using SalesManagementSystem.Views.UI.Sales;
using SalesManagementSystem.Views.Interface;
using SalesManagementSystem.Views.UI.Designer;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace SalesManagementSystem.Views.UI.Access
{
    public partial class FLogin : FDMain, ILogin
    {
        LoginPresenter Presenter;

        public string UserName { get => TUserName.Text; set => TUserName.Text = value; }
        public string UserPassword { get => TUserPassword.Text; set => TUserPassword.Text = value; }

        private int LoginCount = 1;

        public FLogin()
        {
            InitializeComponent();
            Presenter = new LoginPresenter(this);

        }
        public override void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinFrgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRecoveryPassword frgotPassw = new FRecoveryPassword();
            frgotPassw.Show();
        }
/*
        private void TaskLogin()
        {


            try
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    BtnLogin.Visible = false;
                    PBLogin.Visible = true;
                }));
                if (TUserPassword.Text != "" && TUserName.Text != "")
                {
                    FDMain F = FunLogin.Login(Presenter.Login());
                    if (F != null)
                    {
                        F.LabWelcome.Visible = true;
                        F.LabWelcome.Text = "Welcome :" + TUserName.Text.ToUpper();
                        F.Show();
                        this.Invoke((MethodInvoker)(() =>
                        {
                            this.Hide();
                        }));
                    }
                    else
                    {

                        this.LoginCount++;
                        MessageBox.Show("ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Set ALL DATA");
                }
            }
            catch
            {

            }
            finally
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    TUserName.Text = "";
                    TUserPassword.Text = "";
                    TUserName.Focus();
                    PBLogin.Visible = false;
                    BtnLogin.Visible = true;
                }));
            }
   
          }*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.LoginCount==3)
            {
                MessageBox.Show($"لقد ادخلت عدت مرات من المحاولات الخطائة ");
                Application.Exit();
            }
            else
            {
                /*                Thread t1 = new Thread(TaskLogin);
                                t1.Start();*/
                try
                {
                    BtnLogin.Visible = false;
                    PBLogin.Visible = true;
                    if (TUserPassword.Text != "" && TUserName.Text != "")
                    {
                        FDMain F = FunLogin.Login(Presenter.Login());
                        if (F != null)
                        {
                            F.LabWelcome.Visible = true;
                            F.LabWelcome.Text = "Welcome :" + (TUserName.Text.ToUpper());
                            F.Show();
                            this.Hide();
                        }
                        else
                        {
                            this.LoginCount++;
                            MessageBox.Show("خطاء في كلمة المرور او اسم المستخدم","خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        FunMessage.Print("يرجاء ادخال اسم المستخدم وكلمة المرور", "تنبيه");
                    }
                }
                catch
                {

                }
                finally
                {
                        TUserName.Text = "";
                        TUserPassword.Text = "";
                        TUserName.Focus();
                        PBLogin.Visible = false;
                        BtnLogin.Visible = true;
                }

            }
        //    try
        //    {
        //        if(this.LoginCount <=3)
        //        {
        //            int Message = Presenter.Login();

        //            FMessage.Print(Presenter.Login());
        //            if(Message >5)
        //            {

        //                if (Message == 1)
        //                {
        //                    FHomePurchasing fHome = new FHomePurchasing();
        //                    fHome.Show();
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show($"User {UserName} is Block place ");
        //            }
        //        }
        //        else
        //        {
        //            FMessage.Print(UserName);
        //        }
        //    }
        //     catch
        //    {
               
        //    }
        //    finally
        //    {
        //        this.LoginCount++;
        //    }
        }
    }
}
