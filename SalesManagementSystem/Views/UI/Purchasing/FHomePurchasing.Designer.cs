namespace SalesManagementSystem.Views.UI.Purchasing
{
    partial class FHomePurchasing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PMenu = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PMenuClick = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnMenuStore = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuSales = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuPur = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TTPMain = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.PanlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.PMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenu
            // 
            this.PMenu.BackColor = System.Drawing.Color.White;
            this.PMenu.BorderRadius = 1;
            this.PMenu.Controls.Add(this.PMenuClick);
            this.PMenu.Controls.Add(this.BtnMenuStore);
            this.PMenu.Controls.Add(this.BtnMenuProduct);
            this.PMenu.Controls.Add(this.BtnMenuSales);
            this.PMenu.Controls.Add(this.BtnMenuPur);
            this.PMenu.Controls.Add(this.guna2ImageButton2);
            this.PMenu.Controls.Add(this.BtnMenuSettings);
            this.PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMenu.Location = new System.Drawing.Point(0, 0);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(83, 735);
            this.PMenu.TabIndex = 3;
            // 
            // PMenuClick
            // 
            this.PMenuClick.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PMenuClick.Location = new System.Drawing.Point(1, 73);
            this.PMenuClick.Name = "PMenuClick";
            this.PMenuClick.Size = new System.Drawing.Size(7, 70);
            this.PMenuClick.TabIndex = 0;
            // 
            // BtnMenuStore
            // 
            this.BtnMenuStore.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuStore.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuStore.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuStore.Image = global::SalesManagementSystem.Properties.Resources.inventor;
            this.BtnMenuStore.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuStore.ImageRotate = 0F;
            this.BtnMenuStore.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuStore.Location = new System.Drawing.Point(9, 448);
            this.BtnMenuStore.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuStore.Name = "BtnMenuStore";
            this.BtnMenuStore.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuStore.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuStore.TabIndex = 10;
            this.TTPMain.SetToolTip(this.BtnMenuStore, " المخازن أدارة");
            this.BtnMenuStore.UseTransparentBackground = true;
            this.BtnMenuStore.Click += new System.EventHandler(this.BtnMenuPur_Click);
            // 
            // BtnMenuProduct
            // 
            this.BtnMenuProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuProduct.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuProduct.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuProduct.Image = global::SalesManagementSystem.Properties.Resources.products_icon;
            this.BtnMenuProduct.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuProduct.ImageRotate = 0F;
            this.BtnMenuProduct.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuProduct.Location = new System.Drawing.Point(9, 328);
            this.BtnMenuProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuProduct.Name = "BtnMenuProduct";
            this.BtnMenuProduct.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuProduct.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuProduct.TabIndex = 9;
            this.TTPMain.SetToolTip(this.BtnMenuProduct, "المنتجات أدارة ");
            this.BtnMenuProduct.UseTransparentBackground = true;
            this.BtnMenuProduct.Click += new System.EventHandler(this.BtnMenuPur_Click);
            // 
            // BtnMenuSales
            // 
            this.BtnMenuSales.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuSales.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuSales.HoverState.ImageSize = new System.Drawing.Size(45, 30);
            this.BtnMenuSales.Image = global::SalesManagementSystem.Properties.Resources.ProductCategory;
            this.BtnMenuSales.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuSales.ImageRotate = 0F;
            this.BtnMenuSales.ImageSize = new System.Drawing.Size(40, 25);
            this.BtnMenuSales.Location = new System.Drawing.Point(9, 220);
            this.BtnMenuSales.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuSales.Name = "BtnMenuSales";
            this.BtnMenuSales.PressedState.ImageSize = new System.Drawing.Size(45, 30);
            this.BtnMenuSales.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuSales.TabIndex = 7;
            this.TTPMain.SetToolTip(this.BtnMenuSales, " المبيعات أدارة ");
            this.BtnMenuSales.UseTransparentBackground = true;
            this.BtnMenuSales.Click += new System.EventHandler(this.BtnMenuPur_Click);
            // 
            // BtnMenuPur
            // 
            this.BtnMenuPur.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuPur.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuPur.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuPur.Image = global::SalesManagementSystem.Properties.Resources.Add_inventor;
            this.BtnMenuPur.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuPur.ImageRotate = 0F;
            this.BtnMenuPur.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuPur.Location = new System.Drawing.Point(9, 73);
            this.BtnMenuPur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuPur.Name = "BtnMenuPur";
            this.BtnMenuPur.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuPur.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuPur.TabIndex = 5;
            this.TTPMain.SetToolTip(this.BtnMenuPur, "المشتريات أدارة ");
            this.BtnMenuPur.UseTransparentBackground = true;
            this.BtnMenuPur.Click += new System.EventHandler(this.BtnMenuPur_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton2.Image = global::SalesManagementSystem.Properties.Resources.Info;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(11, 540);
            this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton2.Size = new System.Drawing.Size(60, 60);
            this.guna2ImageButton2.TabIndex = 4;
            this.TTPMain.SetToolTip(this.guna2ImageButton2, "المساعدة [CTRL + F1]");
            this.guna2ImageButton2.UseTransparentBackground = true;
            // 
            // BtnMenuSettings
            // 
            this.BtnMenuSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuSettings.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuSettings.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuSettings.Image = global::SalesManagementSystem.Properties.Resources.Settings;
            this.BtnMenuSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuSettings.ImageRotate = 0F;
            this.BtnMenuSettings.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnMenuSettings.Location = new System.Drawing.Point(11, -8);
            this.BtnMenuSettings.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuSettings.Name = "BtnMenuSettings";
            this.BtnMenuSettings.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuSettings.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuSettings.TabIndex = 3;
            this.TTPMain.SetToolTip(this.BtnMenuSettings, "ألاعدادات");
            this.BtnMenuSettings.UseTransparentBackground = true;
            // 
            // TTPMain
            // 
            this.TTPMain.AllowLinksHandling = true;
            this.TTPMain.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // PanlMain
            // 
            this.PanlMain.Location = new System.Drawing.Point(83, 33);
            this.PanlMain.Name = "PanlMain";
            this.PanlMain.Size = new System.Drawing.Size(1299, 702);
            this.PanlMain.TabIndex = 11;
            // 
            // FHomePurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 735);
            this.Controls.Add(this.PanlMain);
            this.Controls.Add(this.PMenu);
            this.Name = "FHomePurchasing";
            this.Text = "FHomeAdmin";
            this.PMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel PMenu;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuSettings;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuPur;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuStore;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuProduct;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuSales;
        private Guna.UI2.WinForms.Guna2Panel PMenuClick;
        private Guna.UI2.WinForms.Guna2HtmlToolTip TTPMain;
        private Guna.UI2.WinForms.Guna2Panel PanlMain;
    }
}