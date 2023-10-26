using Guna.UI2.WinForms;
using SalesManagementSystem.Views.Functions;
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
    public partial class FHomeInventory : FDMain
    {
        public FHomeInventory()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Guna2ImageButton button = (Guna2ImageButton)sender;
            PMenuClick.Location = new Point(1, button.Location.Y);
            AddControl(FunAddUserControls.SetControl(button.Name));

        }
        private void AddControl(UserControl U)
        {
            PnlMain.Controls.Clear();
            try
            {
                UCChild u = (UCChild)U;
                u.Dock = DockStyle.Fill;
                u.PnlMain.Enabled = false;
                PnlMain.Controls.Add(u);
            }
            catch
            {
                U.Dock = DockStyle.Fill;
                PnlMain.Controls.Add(U);

            }
        }
    }
}
