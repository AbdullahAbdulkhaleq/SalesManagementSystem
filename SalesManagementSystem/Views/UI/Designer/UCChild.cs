using SalesManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI.Designer
{
    public partial class UCChild : UCParent
    {
        public UCChild()
        {
            InitializeComponent();
        }
        #region
        public event EventHandler ClickItems;
        #endregion

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerModel Customer =new CustomerModel();
            Customer.CustomerId = e.RowIndex;
            Customer.CustomerName = "Abdullah";
            Customer.CustomerEmail = "AbdullahAbdullah";
            Customer.CustomerPhone = "Abdullah";
            Customer.CustomerType = "Abdullah";

            if (e.RowIndex >= 0 && e != null)
            {
                FUpdateDelete fUpdateDelete = new FUpdateDelete("Customer", Customer);
                fUpdateDelete.ShowDialog();
            }
        }
    }
}
