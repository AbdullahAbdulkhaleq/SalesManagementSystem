using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Views.Functions;
using SalesManagementSystem.Views.Interface;
using SalesManagementSystem.Views.UI.Designer;
using System;

namespace SalesManagementSystem.Views.UI.Inventory
{
    public partial class UCCategory : UCChild, ICategory
    {
        private CategoryPresenter presenter = null;
        public UCCategory()
        {
            InitializeComponent();
            presenter = new CategoryPresenter(this);
        }
        public int ProductCategoryId { get => 0; set => TexCategoryName.Text =value.ToString(); }
        public string ProductCategoryName { get => TexCategoryName.Text; set =>TexCategoryName.Text =value.ToString(); }
        public DateTime ModifiedDate { get => DateTime.Now; set => throw new NotImplementedException(); }


        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TexCategoryName.Text != string.Empty )
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
        private void BtnRefersh_Click(object sender, EventArgs e)
        {
            try
            {
                DGV.DataSource = presenter.Select();
                LabCountRow.Text = (DGV.RowCount - 1).ToString();

            }
            catch
            {
                FunMessage.Print();
            }
        }

        void Clear()
        {
            TexCategoryName.Text = string.Empty;
        }

    }
}
