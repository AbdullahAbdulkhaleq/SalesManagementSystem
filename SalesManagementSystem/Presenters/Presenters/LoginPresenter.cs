using SalesManagementSystem.Models;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Interface;

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
            return LoginServices.Login(this.loginModel.UserName, this.loginModel.UserPassword);
        }
    }
}
