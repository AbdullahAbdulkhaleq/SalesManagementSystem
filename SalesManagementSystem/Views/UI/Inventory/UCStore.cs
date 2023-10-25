using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Views.Functions;
using SalesManagementSystem.Views.Interface;
using SalesManagementSystem.Views.UI.Designer;

namespace SalesManagementSystem.Views.UI.Inventory_FUnit_FStore_FProduct
{
    public partial class UCStore : UCChild, IStore
    {
        private StorePresenter presenter = null;
        public UCStore()
        {
            InitializeComponent();
            presenter = new StorePresenter(this);
        }

        public int StoreId { get => 0; set => throw new System.NotImplementedException(); }
        public string StoreName { get => TxtStoreName.Text; set => TxtStoreName.Text = value; }
        public string StoreAddress { get => TxtStoreAddress.Text; set => TxtStoreAddress.Text = value; }
        public string StorePhone { get => TxtStorePhone.Text; set => TxtStorePhone.Text = value; }

        private void BtnInsert_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (TxtStoreName.Text != string.Empty && TxtStoreAddress.Text != string.Empty && TxtStorePhone.Text != string.Empty)
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
            TxtStoreName.Text = string.Empty;
            TxtStoreAddress.Text = string.Empty;
            TxtStorePhone.Text = string.Empty;
        }

        private void BtnRefersh_Click(object sender, System.EventArgs e)
        {

            DGV.DataSource = presenter.Select();
        }

    }
}
