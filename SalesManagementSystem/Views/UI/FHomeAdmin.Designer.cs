namespace SalesManagementSystem.Views.UI
{
    partial class FHomeAdmin
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
            this.BtnMenuUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuStore = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuSupplier = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuSales = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuCustomer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuPurchasing = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuInfo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TTPMain = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.ucParent1 = new SalesManagementSystem.Views.UI.Designer.UCParent();
            this.PnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PMenu.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnExit.HoverState.ImageSize = new System.Drawing.Size(39, 33);
            this.BtnExit.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnLogOut.HoverState.ImageSize = new System.Drawing.Size(33, 30);
            this.BtnLogOut.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnLogOut.PressedState.ImageSize = new System.Drawing.Size(33, 30);
            // 
            // PMenu
            // 
            this.PMenu.BackColor = System.Drawing.Color.White;
            this.PMenu.BorderRadius = 1;
            this.PMenu.Controls.Add(this.PMenuClick);
            this.PMenu.Controls.Add(this.BtnMenuUser);
            this.PMenu.Controls.Add(this.BtnMenuStore);
            this.PMenu.Controls.Add(this.BtnMenuProduct);
            this.PMenu.Controls.Add(this.BtnMenuSupplier);
            this.PMenu.Controls.Add(this.BtnMenuSales);
            this.PMenu.Controls.Add(this.BtnMenuCustomer);
            this.PMenu.Controls.Add(this.BtnMenuPurchasing);
            this.PMenu.Controls.Add(this.BtnMenuInfo);
            this.PMenu.Controls.Add(this.BtnMenuSettings);
            this.PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMenu.Location = new System.Drawing.Point(0, 33);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(83, 717);
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
            // BtnMenuUser
            // 
            this.BtnMenuUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuUser.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuUser.Image = global::SalesManagementSystem.Properties.Resources.User_Icon;
            this.BtnMenuUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuUser.ImageRotate = 0F;
            this.BtnMenuUser.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuUser.Location = new System.Drawing.Point(9, 552);
            this.BtnMenuUser.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuUser.Name = "BtnMenuUser";
            this.BtnMenuUser.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuUser.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuUser.TabIndex = 11;
            this.TTPMain.SetToolTip(this.BtnMenuUser, "الموظفين أدارة ");
            this.BtnMenuUser.UseTransparentBackground = true;
            this.BtnMenuUser.Click += new System.EventHandler(this.BtnMenu_Click);
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
            this.BtnMenuStore.Location = new System.Drawing.Point(8, 468);
            this.BtnMenuStore.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuStore.Name = "BtnMenuStore";
            this.BtnMenuStore.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuStore.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuStore.TabIndex = 10;
            this.TTPMain.SetToolTip(this.BtnMenuStore, " المخازن أدارة");
            this.BtnMenuStore.UseTransparentBackground = true;
            this.BtnMenuStore.Click += new System.EventHandler(this.BtnMenu_Click);
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
            this.BtnMenuProduct.Location = new System.Drawing.Point(9, 388);
            this.BtnMenuProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuProduct.Name = "BtnMenuProduct";
            this.BtnMenuProduct.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuProduct.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuProduct.TabIndex = 9;
            this.TTPMain.SetToolTip(this.BtnMenuProduct, "المنتجات أدارة ");
            this.BtnMenuProduct.UseTransparentBackground = true;
            this.BtnMenuProduct.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMenuSupplier
            // 
            this.BtnMenuSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuSupplier.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuSupplier.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuSupplier.Image = global::SalesManagementSystem.Properties.Resources.Supplier;
            this.BtnMenuSupplier.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuSupplier.ImageRotate = 0F;
            this.BtnMenuSupplier.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuSupplier.Location = new System.Drawing.Point(9, 308);
            this.BtnMenuSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuSupplier.Name = "BtnMenuSupplier";
            this.BtnMenuSupplier.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuSupplier.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuSupplier.TabIndex = 8;
            this.TTPMain.SetToolTip(this.BtnMenuSupplier, "الموردين أدارة ");
            this.BtnMenuSupplier.UseTransparentBackground = true;
            this.BtnMenuSupplier.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMenuSales
            // 
            this.BtnMenuSales.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuSales.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuSales.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuSales.Image = global::SalesManagementSystem.Properties.Resources.Sale;
            this.BtnMenuSales.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuSales.ImageRotate = 0F;
            this.BtnMenuSales.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuSales.Location = new System.Drawing.Point(9, 151);
            this.BtnMenuSales.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuSales.Name = "BtnMenuSales";
            this.BtnMenuSales.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuSales.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuSales.TabIndex = 7;
            this.TTPMain.SetToolTip(this.BtnMenuSales, " المبيعات أدارة ");
            this.BtnMenuSales.UseTransparentBackground = true;
            this.BtnMenuSales.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMenuCustomer
            // 
            this.BtnMenuCustomer.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuCustomer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuCustomer.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuCustomer.Image = global::SalesManagementSystem.Properties.Resources.Customers;
            this.BtnMenuCustomer.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuCustomer.ImageRotate = 0F;
            this.BtnMenuCustomer.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuCustomer.Location = new System.Drawing.Point(9, 229);
            this.BtnMenuCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuCustomer.Name = "BtnMenuCustomer";
            this.BtnMenuCustomer.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuCustomer.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuCustomer.TabIndex = 6;
            this.TTPMain.SetToolTip(this.BtnMenuCustomer, " العملاء أدارة ");
            this.BtnMenuCustomer.UseTransparentBackground = true;
            this.BtnMenuCustomer.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMenuPurchasing
            // 
            this.BtnMenuPurchasing.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuPurchasing.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuPurchasing.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuPurchasing.Image = global::SalesManagementSystem.Properties.Resources.MenuTrans;
            this.BtnMenuPurchasing.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuPurchasing.ImageRotate = 0F;
            this.BtnMenuPurchasing.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuPurchasing.Location = new System.Drawing.Point(9, 73);
            this.BtnMenuPurchasing.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuPurchasing.Name = "BtnMenuPurchasing";
            this.BtnMenuPurchasing.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuPurchasing.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuPurchasing.TabIndex = 5;
            this.TTPMain.SetToolTip(this.BtnMenuPurchasing, "المشتريات أدارة ");
            this.BtnMenuPurchasing.UseTransparentBackground = true;
            this.BtnMenuPurchasing.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMenuInfo
            // 
            this.BtnMenuInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuInfo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuInfo.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuInfo.Image = global::SalesManagementSystem.Properties.Resources.Info;
            this.BtnMenuInfo.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuInfo.ImageRotate = 0F;
            this.BtnMenuInfo.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnMenuInfo.Location = new System.Drawing.Point(11, 649);
            this.BtnMenuInfo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuInfo.Name = "BtnMenuInfo";
            this.BtnMenuInfo.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuInfo.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuInfo.TabIndex = 4;
            this.TTPMain.SetToolTip(this.BtnMenuInfo, "المساعدة [CTRL + F1]");
            this.BtnMenuInfo.UseTransparentBackground = true;
            this.BtnMenuInfo.Click += new System.EventHandler(this.BtnMenu_Click);
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
            this.BtnMenuSettings.Location = new System.Drawing.Point(11, 2);
            this.BtnMenuSettings.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuSettings.Name = "BtnMenuSettings";
            this.BtnMenuSettings.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuSettings.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuSettings.TabIndex = 3;
            this.TTPMain.SetToolTip(this.BtnMenuSettings, "ألاعدادات");
            this.BtnMenuSettings.UseTransparentBackground = true;
            this.BtnMenuSettings.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // TTPMain
            // 
            this.TTPMain.AllowLinksHandling = true;
            this.TTPMain.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // ucParent1
            // 
            this.ucParent1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ucParent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucParent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucParent1.Location = new System.Drawing.Point(0, 0);
            this.ucParent1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucParent1.Name = "ucParent1";
            this.ucParent1.Padding = new System.Windows.Forms.Padding(5);
            this.ucParent1.Size = new System.Drawing.Size(1294, 704);
            this.ucParent1.TabIndex = 14;
            // 
            // PnlMain
            // 
            this.PnlMain.AutoSize = true;
            this.PnlMain.Controls.Add(this.guna2ImageButton1);
            this.PnlMain.Controls.Add(this.ucParent1);
            this.PnlMain.Location = new System.Drawing.Point(92, 46);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1294, 704);
            this.PnlMain.TabIndex = 13;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.guna2ImageButton1.Image = global::SalesManagementSystem.Properties.Resources.Logout;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1220, 650);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(44, 44);
            this.guna2ImageButton1.Size = new System.Drawing.Size(70, 50);
            this.guna2ImageButton1.TabIndex = 45;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Visible = false;
            // 
            // FHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1390, 750);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PMenu);
            this.MaximumSize = new System.Drawing.Size(1390, 750);
            this.MinimumSize = new System.Drawing.Size(1390, 750);
            this.Name = "FHomeAdmin";
            this.Text = "FHomeAdmin";
            this.Controls.SetChildIndex(this.PMenu, 0);
            this.Controls.SetChildIndex(this.PnlMain, 0);
            this.Controls.SetChildIndex(this.LabWelcome, 0);
            this.PMenu.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel PMenu;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuSettings;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuInfo;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuPurchasing;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuUser;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuStore;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuProduct;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuSupplier;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuSales;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuCustomer;
        private Guna.UI2.WinForms.Guna2Panel PMenuClick;
        private Guna.UI2.WinForms.Guna2HtmlToolTip TTPMain;
        private Designer.UCParent ucParent1;
        private Guna.UI2.WinForms.Guna2Panel PnlMain;
        public Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}