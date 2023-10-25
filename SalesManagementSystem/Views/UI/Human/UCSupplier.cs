using SalesManagementSystem.Presenters.Presenters;
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
    public partial class UCSupplier : UCChild , ISupplier
    {
        private SupplierPresenter presenter = null;

        public int SupplierId { get; set; }
        public string SupplierName { get => TxtSupplierName.Text; set => TxtSupplierName.Text = value; }
        public string SupplierEmail { get => TxtSupplierEmail.Text; set => TxtSupplierEmail.Text = value; }
        public string SupplierPhone { get => TxtSupplierPhone.Text; set => TxtSupplierPhone.Text = value; }
        public string SupplierBrand { get => TxtSupplierBrand.Text; set => TxtSupplierBrand.Text = value; }
        public string SupplierType { get => ComBSupplierType.Text; set => ComBSupplierType.Text = value; }

        public UCSupplier()
        {
            InitializeComponent();
            presenter = new SupplierPresenter(this);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtSupplierName.Text != string.Empty && TxtSupplierEmail.Text != string.Empty && TxtSupplierPhone.Text != string.Empty && TxtSupplierBrand.Text != string.Empty)
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
            TxtSupplierName.Text = string.Empty;
            TxtSupplierPhone.Text = string.Empty;
            TxtSupplierName.Text = string.Empty;
            TxtSupplierBrand.Text = string.Empty;
        }

        private void BtnRefersh_Click(object sender, EventArgs e)
        {

            DGV.DataSource = presenter.s();
        }
    }
}
