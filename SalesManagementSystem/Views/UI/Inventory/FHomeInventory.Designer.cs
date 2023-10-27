namespace SalesManagementSystem.Views.UI
{
    partial class FHomeInventory
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
            this.TTPMain = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.BtnMenuUnit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuGategory = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuStore = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMenuInfo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.ucParent1 = new SalesManagementSystem.Views.UI.Designer.UCParent();
            this.PMenu = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PMenuClick = new Guna.UI2.WinForms.Guna2Panel();
            this.PnlMain.SuspendLayout();
            this.PMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabWelcome
            // 
            this.LabWelcome.Location = new System.Drawing.Point(95, 0);
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
            // TTPMain
            // 
            this.TTPMain.AllowLinksHandling = true;
            this.TTPMain.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // BtnMenuUnit
            // 
            this.BtnMenuUnit.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuUnit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuUnit.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuUnit.Image = global::SalesManagementSystem.Properties.Resources.inventor;
            this.BtnMenuUnit.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuUnit.ImageRotate = 0F;
            this.BtnMenuUnit.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuUnit.Location = new System.Drawing.Point(9, 549);
            this.BtnMenuUnit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuUnit.Name = "BtnMenuUnit";
            this.BtnMenuUnit.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuUnit.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuUnit.TabIndex = 10;
            this.TTPMain.SetToolTip(this.BtnMenuUnit, " وحدة أضافة");
            this.BtnMenuUnit.UseTransparentBackground = true;
            this.BtnMenuUnit.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMenuGategory
            // 
            this.BtnMenuGategory.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuGategory.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuGategory.HoverState.ImageSize = new System.Drawing.Size(42, 27);
            this.BtnMenuGategory.Image = global::SalesManagementSystem.Properties.Resources.ProductCategory;
            this.BtnMenuGategory.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuGategory.ImageRotate = 0F;
            this.BtnMenuGategory.ImageSize = new System.Drawing.Size(40, 25);
            this.BtnMenuGategory.Location = new System.Drawing.Point(9, 417);
            this.BtnMenuGategory.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuGategory.Name = "BtnMenuGategory";
            this.BtnMenuGategory.PressedState.ImageSize = new System.Drawing.Size(42, 27);
            this.BtnMenuGategory.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuGategory.TabIndex = 9;
            this.TTPMain.SetToolTip(this.BtnMenuGategory, " فئة أضافة  ");
            this.BtnMenuGategory.UseTransparentBackground = true;
            this.BtnMenuGategory.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMenuProduct
            // 
            this.BtnMenuProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuProduct.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuProduct.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.BtnMenuProduct.Image = global::SalesManagementSystem.Properties.Resources.products_icon;
            this.BtnMenuProduct.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuProduct.ImageRotate = 0F;
            this.BtnMenuProduct.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuProduct.Location = new System.Drawing.Point(9, 255);
            this.BtnMenuProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuProduct.Name = "BtnMenuProduct";
            this.BtnMenuProduct.PressedState.ImageSize = new System.Drawing.Size(44, 44);
            this.BtnMenuProduct.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuProduct.TabIndex = 7;
            this.TTPMain.SetToolTip(this.BtnMenuProduct, " منتج أضافة  ");
            this.BtnMenuProduct.UseTransparentBackground = true;
            this.BtnMenuProduct.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnMenuStore
            // 
            this.BtnMenuStore.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuStore.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuStore.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuStore.Image = global::SalesManagementSystem.Properties.Resources.Add_inventor;
            this.BtnMenuStore.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuStore.ImageRotate = 0F;
            this.BtnMenuStore.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuStore.Location = new System.Drawing.Point(9, 98);
            this.BtnMenuStore.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuStore.Name = "BtnMenuStore";
            this.BtnMenuStore.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuStore.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuStore.TabIndex = 5;
            this.TTPMain.SetToolTip(this.BtnMenuStore, " مخزن أضافة  ");
            this.BtnMenuStore.UseTransparentBackground = true;
            this.BtnMenuStore.Click += new System.EventHandler(this.BtnMenu_Click);
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
            this.BtnMenuSettings.Location = new System.Drawing.Point(12, 13);
            this.BtnMenuSettings.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuSettings.Name = "BtnMenuSettings";
            this.BtnMenuSettings.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuSettings.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuSettings.TabIndex = 3;
            this.TTPMain.SetToolTip(this.BtnMenuSettings, "ألاعدادات");
            this.BtnMenuSettings.UseTransparentBackground = true;
            this.BtnMenuSettings.Click += new System.EventHandler(this.BtnMenu_Click);
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
            this.BtnMenuInfo.Location = new System.Drawing.Point(10, 644);
            this.BtnMenuInfo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuInfo.Name = "BtnMenuInfo";
            this.BtnMenuInfo.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.BtnMenuInfo.Size = new System.Drawing.Size(60, 60);
            this.BtnMenuInfo.TabIndex = 11;
            this.TTPMain.SetToolTip(this.BtnMenuInfo, "المساعدة [CTRL + F1]");
            this.BtnMenuInfo.UseTransparentBackground = true;
            this.BtnMenuInfo.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.AutoSize = true;
            this.PnlMain.Controls.Add(this.ucParent1);
            this.PnlMain.Location = new System.Drawing.Point(86, 47);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1290, 700);
            this.PnlMain.TabIndex = 13;
            // 
            // ucParent1
            // 
            this.ucParent1.AutoSize = true;
            this.ucParent1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ucParent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucParent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucParent1.Location = new System.Drawing.Point(0, 0);
            this.ucParent1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucParent1.Name = "ucParent1";
            this.ucParent1.Padding = new System.Windows.Forms.Padding(5);
            this.ucParent1.Size = new System.Drawing.Size(1290, 700);
            this.ucParent1.TabIndex = 14;
            // 
            // PMenu
            // 
            this.PMenu.BackColor = System.Drawing.Color.White;
            this.PMenu.BorderRadius = 1;
            this.PMenu.Controls.Add(this.BtnMenuInfo);
            this.PMenu.Controls.Add(this.PMenuClick);
            this.PMenu.Controls.Add(this.BtnMenuUnit);
            this.PMenu.Controls.Add(this.BtnMenuGategory);
            this.PMenu.Controls.Add(this.BtnMenuProduct);
            this.PMenu.Controls.Add(this.BtnMenuStore);
            this.PMenu.Controls.Add(this.BtnMenuSettings);
            this.PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMenu.Location = new System.Drawing.Point(0, 0);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(83, 750);
            this.PMenu.TabIndex = 3;
            // 
            // PMenuClick
            // 
            this.PMenuClick.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PMenuClick.Location = new System.Drawing.Point(1, 98);
            this.PMenuClick.Name = "PMenuClick";
            this.PMenuClick.Size = new System.Drawing.Size(7, 70);
            this.PMenuClick.TabIndex = 0;
            // 
            // FHomeInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1390, 750);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PMenu);
            this.Name = "FHomeInventory";
            this.Text = "FHomeAdmin";
            this.Controls.SetChildIndex(this.PMenu, 0);
            this.Controls.SetChildIndex(this.PnlMain, 0);
            this.Controls.SetChildIndex(this.LabWelcome, 0);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.PMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel PMenu;
        private Guna.UI2.WinForms.Guna2HtmlToolTip TTPMain;
        private Guna.UI2.WinForms.Guna2Panel PMenuClick;
        private Guna.UI2.WinForms.Guna2Panel PnlMain;
        public Guna.UI2.WinForms.Guna2ImageButton BtnMenuSettings;
        public Guna.UI2.WinForms.Guna2ImageButton BtnMenuStore;
        public Guna.UI2.WinForms.Guna2ImageButton BtnMenuUnit;
        public Guna.UI2.WinForms.Guna2ImageButton BtnMenuGategory;
        public Guna.UI2.WinForms.Guna2ImageButton BtnMenuProduct;
        public Guna.UI2.WinForms.Guna2ImageButton BtnMenuInfo;
        private Designer.UCParent ucParent1;
    }
}