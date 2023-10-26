using SalesManagementSystem.Presenters.Presenters;
using SalesManagementSystem.Views.Functions;
using SalesManagementSystem.Views.Interface;
using SalesManagementSystem.Views.UI.Designer;
using System;

namespace SalesManagementSystem.Views.UI.Inventory_FUnit_FStore_FProduct
{
    public partial class UCUnit : UCChild, IUnit
    {
        private UnitPresenter presenter = null;
        public UCUnit()
        {
            InitializeComponent();
            presenter = new UnitPresenter(this);
        }

        public int UnitId { get => 0; set => throw new NotImplementedException(); }
        public string UnitCode { get => TxtUnitName.Text; set => TxtUnitName.Text = value; }
        public string UnitDesc { get => TxtUnitDescription.Text; set => TxtUnitDescription.Text = value; }

        private void UCUnit_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUnitName.Text != string.Empty && TxtUnitDescription.Text != string.Empty)
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
            TxtUnitName.Text = string.Empty;
            TxtUnitDescription.Text = string.Empty;
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

    }
}
