using Guna.UI2.WinForms;
using SalesManagementSystem.Views.UI.Designer;
using System;
using System.Drawing;

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
        }
    }
}
