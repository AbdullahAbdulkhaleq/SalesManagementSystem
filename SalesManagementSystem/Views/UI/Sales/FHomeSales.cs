using Guna.UI2.WinForms;
using SalesManagementSystem.Views.Functions;
using SalesManagementSystem.Views.UI.Designer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalesManagementSystem.Views.UI.Sales
{
    public partial class FHomeSales : FDMain
    {
        public FHomeSales()
        {
            InitializeComponent();
        }

        private void BtnMenuPur_Click(object sender, EventArgs e)
        {
            Guna2ImageButton button = (Guna2ImageButton)sender;
            PMenuClick.Location = new Point(1, button.Location.Y);
            AddControl(FunAddUserControls.SetControl(button.Name));
        }
        private void AddControl(UserControl U)
        {
            PnlMain.Controls.Clear();
            U.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(U);

        }
    }
}
