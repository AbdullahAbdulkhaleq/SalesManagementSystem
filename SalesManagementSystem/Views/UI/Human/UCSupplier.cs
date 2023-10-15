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
    public partial class UCSupplier : UCParent , ISupplier
    {
        private SupplierPresenter presenter;

        public UCSupplier()
        {
            InitializeComponent();
            presenter = new SupplierPresenter(this);
        }

        public int SupplierId { get; set; }
        public string SupplierName { get => TSupplierName.Text; set => TSupplierName.Text = value; }
        public string SupplierEmail { get => TSupplierEmail.Text; set => TSupplierEmail.Text = value; }
        public string SupplierPhone { get => TSupplierPhone.Text; set => TSupplierPhone.Text = value; }
        public string SupplierBrand { get => TSupplierBrand.Text; set => TSupplierBrand.Text = value; }
        public string SupplierType { get => TSupplierType.Text; set => TSupplierType.Text = value; }

        private void BInsert_Click(object sender, EventArgs e)
        {
        }

        private void UCSupplier_Load(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TCustomerPhone_TextChanged(object sender, EventArgs e)
        {

        }


        private void BInsert_Click_1(object sender, EventArgs e)
        {

        }

        private void TCustomerEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbManageProducts_Click(object sender, EventArgs e)
        {

        }



        private void panel1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void TSupplierId_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panel1_MouseEnter_1(object sender, EventArgs e)
        {

        /*    if (TSupplierId.Text == "")
                TSupplierId.Text = presenter.GetSupplierId().ToString();*/
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
