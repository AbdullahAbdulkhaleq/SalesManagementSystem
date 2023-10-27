using SalesManagementSystem.Models;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Interface;
using System.Net;
using System.IO;
using System.Text;
using System;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class LoginPresenter
    {
        ILogin ilogin;
        LoginModel loginModel;

        public LoginPresenter(ILogin ilogin)
        {
            this.ilogin = ilogin;
            loginModel = new LoginModel();
        }
        private void connectedInterfaceAndModel()
        {
            this.loginModel.UserName = this.ilogin.UserName;
            this.loginModel.UserPassword = this.ilogin.UserPassword;
        }
        public int Login()
        {
            connectedInterfaceAndModel();
            int MessageNumber = LoginServices.Login(this.loginModel.UserName, this.loginModel.UserPassword);
            try
            {
                if (MessageNumber > 0 && MessageNumber < 5)
                {
                    WebRequest ApiLog = WebRequest.Create("http://localhost/salesmanagementsystemlog/LogIn.php");
                    ApiLog.Method = "POST";
                    ApiLog.ContentType = "application/x-www-form-urlencoded";

                    string Log = $"LogIn={this.loginModel.UserName}";
                    ASCIIEncoding enLogIn = new ASCIIEncoding();
                    byte[] by = enLogIn.GetBytes(Log);
                    Stream S = ApiLog.GetRequestStream();
                    S.Write(by, 0, by.Length);

                    WebResponse LogMessagOut = ApiLog.GetResponse();
                    Stream stream = LogMessagOut.GetResponseStream();
                    StreamReader reader = new StreamReader(stream);

                    string line = reader.ReadToEnd();
                    Console.Write(line);

                }
            }
            catch
            {
                return 40404;
            }
            return MessageNumber;
        }
    }
}
