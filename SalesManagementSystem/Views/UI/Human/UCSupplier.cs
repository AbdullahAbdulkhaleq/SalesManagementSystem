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

namespace SalesManagementSystem.Views.UI.Human
{
    public partial class UCSupplier : UCMain , ISupplier
    {
        private SupplierPresenter presenter;

        public UCSupplier()
        {
            InitializeComponent();
            presenter = new SupplierPresenter(this);
        }

        public int SupplierId { get => int.Parse(TSupplierId.Text); set => TSupplierId.Text = value.ToString(); }
        public string SupplierName { get => TSupplierName.Text; set => TSupplierName.Text = value; }
        public string SupplierEmail { get => TSupplierEmail.Text; set => TSupplierEmail.Text = value; }
        public string SupplierType { get => TSupplierType.Text; set => TSupplierType.Text = value; }
        public string SupplierPhone { get => TSupplierPhone.Text; set => TSupplierPhone.Text = value; }
        public string SupplierBrand { get => TSupplierBrand.Text; set => TSupplierBrand.Text = value; }

        private void BInsert_Click(object sender, EventArgs e)
        {
        }

        private void UCSupplier_Load(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TCustomerPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TSupplierType_TextChanged(object sender, EventArgs e)
        {

        }


        private void BInsert_Click_1(object sender, EventArgs e)
        {

        }

        private void BSelect_Click_1(object sender, EventArgs e)
        {

        }

        private void BDeltete_Click_1(object sender, EventArgs e)
        {

        }

        private void BDeleteAll_Click_1(object sender, EventArgs e)
        {

        }

        private void BUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void TCustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbManageProducts_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TCustomerType_TextChanged(object sender, EventArgs e)
        {

        }

        private void TSupplierName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TSupplierId_Click(object sender, EventArgs e)
        {

        }
    }
}
