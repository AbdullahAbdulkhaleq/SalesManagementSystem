﻿using Guna.UI2.WinForms;
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
    public partial class FHomeAdmin : FDMain
    {
        public FHomeAdmin()
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
