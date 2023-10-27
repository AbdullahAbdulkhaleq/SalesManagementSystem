using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Functions;
using SalesManagementSystem.Views.Interface;
using SalesManagementSystem.Views.UI.Designer;
using System;

namespace SalesManagementSystem.Views.UI.Human
{
    public partial class UCUser : UCChild, IUser
    {
        private UserPresenter presenter = null;
        public int UserId { get => 0; set => ComBDepartmentId.SelectedIndex = value; }
        public string UserName { get => TxtUserName.Text; set => TxtUserName.Text = value; }
        public string UserPassword { get => TxtUserPassword.Text; set => TxtUserPassword.Text = value; }
        public int UserStatus { get => ComBUserStatus.SelectedIndex; set => ComBUserStatus.SelectedIndex = value; }
        public int DepartmentId { get => ComBDepartmentId.SelectedIndex; set => ComBDepartmentId.SelectedIndex = value; }

        public UCUser()
        {
            InitializeComponent();
            presenter = new UserPresenter(this);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUserName.Text != string.Empty && TxtUserPassword.Text != string.Empty)
                {
                    FunMessage.Print(presenter.Insert(), "Insert");
                }
                else
                {
                    FunMessage.Print();
                }
            }
            catch
            {
                FunMessage.Print();
            }
            finally
            {
                Clear();
            }
        }
        void Clear()
        {
            TxtUserName.Text = string.Empty;
            TxtUserPassword.Text = string.Empty;
        }

        private void UCUser_Load(object sender, EventArgs e)
        {
            ComBUserStatus.SelectedIndex = 0;
            ComBDepartmentId.SelectedIndex = 1;
        }


        private void BtnRefersh_Click(object sender, EventArgs e)
        {
            DGV.DataSource = presenter.Select();
            LabCountRow.Text = (DGV.RowCount-1).ToString();
        }

    }
}
