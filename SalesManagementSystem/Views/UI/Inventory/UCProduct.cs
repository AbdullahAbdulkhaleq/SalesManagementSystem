using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Views.Functions;
using SalesManagementSystem.Views.Interface;
using SalesManagementSystem.Views.UI.Designer;
using System;

namespace SalesManagementSystem.Views.UI.Inventory
{
    public partial class UCProduct : UCChild,IProduct
    {
        public UCProduct()
        {
            InitializeComponent();
        }

        private ProductPresenter presenter = null;
        public int ProductId { get => 0; set => throw new NotImplementedException(); }
        public string ProductName { get => TxtProductName.Text; set => TxtProductName.Text = value; }
        public decimal ProductPrice { get => decimal.Parse(TxtLastPrice.Text); set => TxtLastPrice.Text = value.ToString(); }
        public int ProductCategoryId { get => int.Parse(ComBProductCategoryId.Text); set => ComBProductCategoryId.Text = value.ToString(); }
        public int StoreId { get => int.Parse(ComBStoreId.Text); set => ComBStoreId.Text = value.ToString(); }
        public int UnitId { get => int.Parse(ComBUnitId.Text); set => ComBUnitId.Text = value.ToString(); }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            TxtProductName.Text = string.Empty;
            TxtLastPrice.Text = string.Empty;
        }

        private void BtnRefersh_Click(object sender, EventArgs e)
        {
            DGV.DataSource = presenter.Select();
        }

    }
}
