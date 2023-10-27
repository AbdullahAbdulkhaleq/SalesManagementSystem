using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Presenters.Services;
using SalesManagementSystem.Views.Functions;
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
    public partial class UCCustomer : UCChild,ICustomer
    {
        CustomerPresenter presenter = null;

        public int CustomerId { get => 0; set =>TxtCustomerName.Text = value.ToString(); }
        public string CustomerName { get => TxtCustomerName.Text; set => TxtCustomerName.Text = value; }
        public string CustomerEmail { get => TxtCustomerEmail.Text; set => TxtCustomerEmail.Text = value; }
        public string CustomerPhone { get => TxtCustomerPhone.Text; set => TxtCustomerPhone.Text = value; }
        public string CustomerType { get => ComBCustomerType.Text; set => ComBCustomerType.Text = value; }

        public UCCustomer()
        {
            InitializeComponent();
            this.presenter = new CustomerPresenter(this);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCustomerName.Text != string.Empty && TxtCustomerEmail.Text != string.Empty && TxtCustomerPhone.Text != string.Empty)
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
            TxtCustomerName.Text = string.Empty;
            TxtCustomerEmail.Text = string.Empty;
            TxtCustomerPhone.Text = string.Empty;
        }

        private void BtnRefersh_Click(object sender, EventArgs e)
        {
            try
            {
                DGV.DataSource = presenter.Select();
                LabCountRow.Text = (DGV.RowCount-1).ToString();
            }
            catch
            {
                FunMessage.Print();
            }
        }

    }
}
