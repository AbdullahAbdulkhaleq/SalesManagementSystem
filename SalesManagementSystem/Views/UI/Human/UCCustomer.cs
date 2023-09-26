using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Presenters.Services;
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

namespace SalesManagementSystem.Views.UI.Human
{
    public partial class UCCustomer : UCMain, ICustomer
    {
        CustomerPresenter presenter;
        public UCCustomer()
        {
            InitializeComponent();
            presenter = new CustomerPresenter(this);
        }
        

        public int CustomerId { get => int.Parse(TCustomerId.Text); set => TCustomerId.Text = value.ToString(); }
        public string CustomerName { get => TCustomerName.Text; set => TCustomerName.Text = value; }
        public string CustomerEmail { get => TCustomerEmail.Text; set => TCustomerEmail.Text = value; }
        public string CustomerType { get => TCustomerType.Text; set => TCustomerType.Text = value; }
        public string CustomerPhone { get => TCustomerPhone.Text; set => TCustomerPhone.Text = value; }

        private void BDeleteAll_Click(object sender, EventArgs e)
        {
            presenter.DeleteAll();
        }

        private void BSelect_Click(object sender, EventArgs e)
        {
            presenter.Select();
        }

        private void BDeltete_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        private void BInsert_Click(object sender, EventArgs e)
        {
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            presenter.Update();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (presenter.Insert())
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("NO");
            }
        }

        private void TCustomerId_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TCustomerId.Text == "")
                TCustomerId.Text = CustomerServices.GetCustomerId().ToString();
        }
    }
}
