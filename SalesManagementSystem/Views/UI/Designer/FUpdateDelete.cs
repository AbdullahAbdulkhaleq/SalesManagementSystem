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
    public partial class FUpdateDelete : FDMain
    {
        public FUpdateDelete(string Type,object e)
        {
            InitializeComponent();
            Switch(Type,e);
        }
        private void Switch(string Type, object e)
        {
            switch (Type)
            {
                case "Customer":
                    CustomerModel UpdateDeleteCustomer = (CustomerModel)e;
                    TxtId.Text = UpdateDeleteCustomer.CustomerId.ToString();
                    TxtName.Text = UpdateDeleteCustomer.CustomerName.ToString();
                    TxtThree.Text = UpdateDeleteCustomer.CustomerEmail.ToString();
                    TxtFour.Text = UpdateDeleteCustomer.CustomerPhone.ToString();
                    TxtFive.Text = UpdateDeleteCustomer.CustomerType.ToString();
                    
                    break;
                case "Supplier":
                    SupplierModel UpdateDeleteSupplier = (SupplierModel)e;
                    TxtId.Text = UpdateDeleteSupplier.SupplierId.ToString();
                    TxtName.Text = UpdateDeleteSupplier.SupplierName.ToString();
                    TxtThree.Text = UpdateDeleteSupplier.SupplierEmail.ToString();
                    TxtFour.Text = UpdateDeleteSupplier.SupplierPhone.ToString();
                    TxtFive.Text = UpdateDeleteSupplier.SupplierType.ToString();
                    break;
                case "User":
                    UserModle UpdateDeleteUser = (UserModle)e;

                    break;
                case "Category":
                    CategoryModel UpdateDeleteCategory = (CategoryModel)e;

                    break;
                case "Product":
                    ProductModel UpdateDeleteProduct = (ProductModel)e;

                    break;
                case "Store":
                    StoreModel UpdateDeleteStore = (StoreModel)e;

                    break;
                case "Unit":
                    UnitModel UpdateDeleteUnit = (UnitModel)e;

                    break;
            }
        }

        public override void BtnExit_Click(object sender, EventArgs e)
        {
            FUpdateDelete.ActiveForm.Close();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
