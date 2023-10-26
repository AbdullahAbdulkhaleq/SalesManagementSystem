using SalesManagementSystem.Models;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Interface;
using System.Data;

namespace SalesManagementSystem.Presenters.Presenters
{
    public class UserPresenter
    {
        private UserModle userModle = null;
        private IUser iuser =null;

        public UserPresenter(IUser iuser)
        {
            this.iuser = iuser;
            this.userModle = new UserModle();
        }
        private void ConnectInterfaceToModle()
        {
            this.userModle.UserId = this.iuser.UserId;
            this.userModle.UserName = this.iuser.UserName;
            this.userModle.UserPassword = this.iuser.UserPassword;
            this.userModle.DepartmentId = this.iuser.DepartmentId;
            this.userModle.UserStatus = this.iuser.UserStatus;
        }

        public int Insert()
        {
            ConnectInterfaceToModle();
            return UserServices.Insert(this.userModle);
        }
        public DataTable Select()
        {
            return UserServices.Select();
        }
        public int Delete()
        {
            ConnectInterfaceToModle();
            return UserServices.Delete(this.userModle);
        }
        public int Update()
        {
            ConnectInterfaceToModle();
            return UserServices.Update(this.userModle);
        }
    }
}
