using Bunifu.Framework.UI;
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

namespace SalesManagementSystem.Views.UI
{
    public partial class FHome : FDMain
    {
        public FHome()
        {
            InitializeComponent();
        }

        private void BMenu_Click(object sender, EventArgs e)
        {
            BunifuImageButton button = (BunifuImageButton)sender;
            PMenu.Location =new Point(-4, button.Location.Y);
            ShowUserContral(button.Name);

        }
        private void ShowUserContral(string Name)
        {

            if (Name == "BMenuSupplier")
            {
                ucSupplier1.Visible = true;
                ucCustomer1.Visible = false;
                ucSupplier1.Dock = DockStyle.Fill;
            }
            if (Name == "BMenuCustomer")
            {
                ucSupplier1.Visible = false;
                ucCustomer1.Visible = true;
                ucCustomer1.Dock = DockStyle.Fill;
            }
        }
        private void ucCustomer1_Load(object sender, EventArgs e)
        {

        }
    }
}
