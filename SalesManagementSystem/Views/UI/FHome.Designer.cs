namespace SalesManagementSystem.Views.UI
{
    partial class FHome
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BMenuHelp = new Bunifu.Framework.UI.BunifuImageButton();
            this.PMenu = new System.Windows.Forms.Panel();
            this.BMenuProduct = new Bunifu.Framework.UI.BunifuImageButton();
            this.BMenuStore = new Bunifu.Framework.UI.BunifuImageButton();
            this.BMenuSupplier = new Bunifu.Framework.UI.BunifuImageButton();
            this.BMenuUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.BMenuCustomer = new Bunifu.Framework.UI.BunifuImageButton();
            this.BMenuTrans = new Bunifu.Framework.UI.BunifuImageButton();
            this.BMenuSettings = new Bunifu.Framework.UI.BunifuImageButton();
            this.tpmain = new System.Windows.Forms.ToolTip(this.components);
            this.PMAIN = new System.Windows.Forms.Panel();
            this.ucSupplier1 = new SalesManagementSystem.Views.UI.Human.UCSupplier();
            this.ucCustomer1 = new SalesManagementSystem.Views.UI.Human.UCCustomer();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuSettings)).BeginInit();
            this.PMAIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BMenuHelp);
            this.panel2.Controls.Add(this.PMenu);
            this.panel2.Controls.Add(this.BMenuProduct);
            this.panel2.Controls.Add(this.BMenuStore);
            this.panel2.Controls.Add(this.BMenuSupplier);
            this.panel2.Controls.Add(this.BMenuUser);
            this.panel2.Controls.Add(this.BMenuCustomer);
            this.panel2.Controls.Add(this.BMenuTrans);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 503);
            this.panel2.TabIndex = 3;
            // 
            // BMenuHelp
            // 
            this.BMenuHelp.BackColor = System.Drawing.Color.Transparent;
            this.BMenuHelp.Image = global::SalesManagementSystem.Properties.Resources.about2;
            this.BMenuHelp.ImageActive = null;
            this.BMenuHelp.Location = new System.Drawing.Point(11, 456);
            this.BMenuHelp.Name = "BMenuHelp";
            this.BMenuHelp.Size = new System.Drawing.Size(30, 37);
            this.BMenuHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMenuHelp.TabIndex = 17;
            this.BMenuHelp.TabStop = false;
            this.tpmain.SetToolTip(this.BMenuHelp, "ألمساعدة");
            this.BMenuHelp.Zoom = 10;
            // 
            // PMenu
            // 
            this.PMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PMenu.Location = new System.Drawing.Point(-4, 42);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(10, 45);
            this.PMenu.TabIndex = 16;
            // 
            // BMenuProduct
            // 
            this.BMenuProduct.BackColor = System.Drawing.Color.Transparent;
            this.BMenuProduct.Image = global::SalesManagementSystem.Properties.Resources.grocery_products_icon_png_3;
            this.BMenuProduct.ImageActive = null;
            this.BMenuProduct.Location = new System.Drawing.Point(7, 104);
            this.BMenuProduct.Name = "BMenuProduct";
            this.BMenuProduct.Size = new System.Drawing.Size(37, 44);
            this.BMenuProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMenuProduct.TabIndex = 13;
            this.BMenuProduct.TabStop = false;
            this.tpmain.SetToolTip(this.BMenuProduct, "ألمنتجات");
            this.BMenuProduct.Zoom = 10;
            this.BMenuProduct.Click += new System.EventHandler(this.BMenu_Click);
            // 
            // BMenuStore
            // 
            this.BMenuStore.BackColor = System.Drawing.Color.Transparent;
            this.BMenuStore.Image = global::SalesManagementSystem.Properties.Resources.box_open;
            this.BMenuStore.ImageActive = null;
            this.BMenuStore.Location = new System.Drawing.Point(8, 170);
            this.BMenuStore.Name = "BMenuStore";
            this.BMenuStore.Size = new System.Drawing.Size(37, 44);
            this.BMenuStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMenuStore.TabIndex = 12;
            this.BMenuStore.TabStop = false;
            this.tpmain.SetToolTip(this.BMenuStore, "ألمخازن");
            this.BMenuStore.Zoom = 10;
            this.BMenuStore.Click += new System.EventHandler(this.BMenu_Click);
            // 
            // BMenuSupplier
            // 
            this.BMenuSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BMenuSupplier.Image = global::SalesManagementSystem.Properties.Resources.participation_rate;
            this.BMenuSupplier.ImageActive = null;
            this.BMenuSupplier.Location = new System.Drawing.Point(8, 311);
            this.BMenuSupplier.Name = "BMenuSupplier";
            this.BMenuSupplier.Size = new System.Drawing.Size(37, 44);
            this.BMenuSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMenuSupplier.TabIndex = 11;
            this.BMenuSupplier.TabStop = false;
            this.tpmain.SetToolTip(this.BMenuSupplier, "ألموردبن");
            this.BMenuSupplier.Zoom = 10;
            this.BMenuSupplier.Click += new System.EventHandler(this.BMenu_Click);
            // 
            // BMenuUser
            // 
            this.BMenuUser.BackColor = System.Drawing.Color.Transparent;
            this.BMenuUser.Image = global::SalesManagementSystem.Properties.Resources.male_user_1080px;
            this.BMenuUser.ImageActive = null;
            this.BMenuUser.Location = new System.Drawing.Point(8, 383);
            this.BMenuUser.Name = "BMenuUser";
            this.BMenuUser.Size = new System.Drawing.Size(37, 44);
            this.BMenuUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMenuUser.TabIndex = 10;
            this.BMenuUser.TabStop = false;
            this.tpmain.SetToolTip(this.BMenuUser, "ألمستخدمين");
            this.BMenuUser.Zoom = 10;
            this.BMenuUser.Click += new System.EventHandler(this.BMenu_Click);
            // 
            // BMenuCustomer
            // 
            this.BMenuCustomer.BackColor = System.Drawing.Color.Transparent;
            this.BMenuCustomer.Image = global::SalesManagementSystem.Properties.Resources.account_balances;
            this.BMenuCustomer.ImageActive = null;
            this.BMenuCustomer.Location = new System.Drawing.Point(8, 237);
            this.BMenuCustomer.Name = "BMenuCustomer";
            this.BMenuCustomer.Size = new System.Drawing.Size(37, 44);
            this.BMenuCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMenuCustomer.TabIndex = 9;
            this.BMenuCustomer.TabStop = false;
            this.tpmain.SetToolTip(this.BMenuCustomer, "ألعملاء");
            this.BMenuCustomer.Zoom = 10;
            this.BMenuCustomer.Click += new System.EventHandler(this.BMenu_Click);
            // 
            // BMenuTrans
            // 
            this.BMenuTrans.BackColor = System.Drawing.Color.Transparent;
            this.BMenuTrans.Image = global::SalesManagementSystem.Properties.Resources.create_order_1080px;
            this.BMenuTrans.ImageActive = null;
            this.BMenuTrans.Location = new System.Drawing.Point(8, 42);
            this.BMenuTrans.Name = "BMenuTrans";
            this.BMenuTrans.Size = new System.Drawing.Size(37, 44);
            this.BMenuTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMenuTrans.TabIndex = 8;
            this.BMenuTrans.TabStop = false;
            this.tpmain.SetToolTip(this.BMenuTrans, "ألعمليات");
            this.BMenuTrans.Zoom = 10;
            this.BMenuTrans.Click += new System.EventHandler(this.BMenu_Click);
            // 
            // BMenuSettings
            // 
            this.BMenuSettings.BackColor = System.Drawing.SystemColors.Control;
            this.BMenuSettings.Image = global::SalesManagementSystem.Properties.Resources.settings1;
            this.BMenuSettings.ImageActive = null;
            this.BMenuSettings.Location = new System.Drawing.Point(9, 12);
            this.BMenuSettings.Name = "BMenuSettings";
            this.BMenuSettings.Size = new System.Drawing.Size(37, 30);
            this.BMenuSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMenuSettings.TabIndex = 14;
            this.BMenuSettings.TabStop = false;
            this.tpmain.SetToolTip(this.BMenuSettings, "الاعدادات");
            this.BMenuSettings.Zoom = 10;
            // 
            // PMAIN
            // 
            this.PMAIN.Controls.Add(this.ucSupplier1);
            this.PMAIN.Controls.Add(this.ucCustomer1);
            this.PMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMAIN.Location = new System.Drawing.Point(53, 27);
            this.PMAIN.Name = "PMAIN";
            this.PMAIN.Size = new System.Drawing.Size(861, 503);
            this.PMAIN.TabIndex = 15;
            // 
            // ucSupplier1
            // 
            this.ucSupplier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSupplier1.Location = new System.Drawing.Point(44, 90);
            this.ucSupplier1.Margin = new System.Windows.Forms.Padding(6);
            this.ucSupplier1.Name = "ucSupplier1";
            this.ucSupplier1.Size = new System.Drawing.Size(860, 500);
            this.ucSupplier1.SupplierBrand = "";
            this.ucSupplier1.SupplierEmail = "";
            this.ucSupplier1.SupplierName = "";
            this.ucSupplier1.SupplierPhone = "";
            this.ucSupplier1.SupplierType = "";
            this.ucSupplier1.TabIndex = 18;
            // 
            // ucCustomer1
            // 
            this.ucCustomer1.CustomerEmail = "";
            this.ucCustomer1.CustomerName = "";
            this.ucCustomer1.CustomerPhone = "";
            this.ucCustomer1.CustomerType = "";
            this.ucCustomer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ucCustomer1.Location = new System.Drawing.Point(214, 22);
            this.ucCustomer1.Margin = new System.Windows.Forms.Padding(6);
            this.ucCustomer1.Name = "ucCustomer1";
            this.ucCustomer1.Size = new System.Drawing.Size(860, 500);
            this.ucCustomer1.TabIndex = 17;
            this.ucCustomer1.Load += new System.EventHandler(this.ucCustomer1_Load);
            // 
            // FHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.PMAIN);
            this.Controls.Add(this.BMenuSettings);
            this.Controls.Add(this.panel2);
            this.Name = "FHome";
            this.Text = "FHome";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.BMenuSettings, 0);
            this.Controls.SetChildIndex(this.PMAIN, 0);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BMenuHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMenuSettings)).EndInit();
            this.PMAIN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton BMenuTrans;
        private Bunifu.Framework.UI.BunifuImageButton BMenuProduct;
        private Bunifu.Framework.UI.BunifuImageButton BMenuStore;
        private Bunifu.Framework.UI.BunifuImageButton BMenuSupplier;
        private Bunifu.Framework.UI.BunifuImageButton BMenuUser;
        private Bunifu.Framework.UI.BunifuImageButton BMenuCustomer;
        private Bunifu.Framework.UI.BunifuImageButton BMenuSettings;
        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.ToolTip tpmain;
        private System.Windows.Forms.Panel PMAIN;
        private Bunifu.Framework.UI.BunifuImageButton BMenuHelp;
        private Human.UCSupplier ucSupplier1;
        private Human.UCCustomer ucCustomer1;
    }
}