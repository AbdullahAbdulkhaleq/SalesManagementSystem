namespace SalesManagementSystem.Views.UI.Inventory
{
    partial class UCProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ComBUnitId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComBStoreId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComBProductCategoryId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnInsert = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LabPhone = new System.Windows.Forms.Label();
            this.LabManage = new System.Windows.Forms.Label();
            this.LabAddress = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.TxtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtLastPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRefersh
            // 
            this.BtnRefersh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnRefersh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnRefersh.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnRefersh.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnRefersh.PressedState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnRefersh.Click += new System.EventHandler(this.BtnRefersh_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPrint.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnPrint.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnPrint.PressedState.ImageSize = new System.Drawing.Size(33, 33);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ComBUnitId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ComBStoreId);
            this.panel1.Controls.Add(this.ComBProductCategoryId);
            this.panel1.Controls.Add(this.BtnInsert);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.LabPhone);
            this.panel1.Controls.Add(this.LabManage);
            this.panel1.Controls.Add(this.LabAddress);
            this.panel1.Controls.Add(this.LabName);
            this.panel1.Controls.Add(this.TxtProductName);
            this.panel1.Controls.Add(this.TxtLastPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 690);
            this.panel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(14, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Address";
            // 
            // ComBUnitId
            // 
            this.ComBUnitId.BackColor = System.Drawing.Color.Transparent;
            this.ComBUnitId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComBUnitId.BorderRadius = 10;
            this.ComBUnitId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBUnitId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBUnitId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBUnitId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBUnitId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBUnitId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ComBUnitId.ItemHeight = 30;
            this.ComBUnitId.Items.AddRange(new object[] {
            "خامل ",
            "نشط"});
            this.ComBUnitId.Location = new System.Drawing.Point(11, 468);
            this.ComBUnitId.Name = "ComBUnitId";
            this.ComBUnitId.Size = new System.Drawing.Size(284, 36);
            this.ComBUnitId.TabIndex = 46;
            this.ComBUnitId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(14, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Address";
            // 
            // ComBStoreId
            // 
            this.ComBStoreId.BackColor = System.Drawing.Color.Transparent;
            this.ComBStoreId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComBStoreId.BorderRadius = 10;
            this.ComBStoreId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBStoreId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBStoreId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBStoreId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBStoreId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ComBStoreId.ItemHeight = 30;
            this.ComBStoreId.Items.AddRange(new object[] {
            "خامل ",
            "نشط"});
            this.ComBStoreId.Location = new System.Drawing.Point(11, 397);
            this.ComBStoreId.Name = "ComBStoreId";
            this.ComBStoreId.Size = new System.Drawing.Size(284, 36);
            this.ComBStoreId.TabIndex = 44;
            this.ComBStoreId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComBProductCategoryId
            // 
            this.ComBProductCategoryId.BackColor = System.Drawing.Color.Transparent;
            this.ComBProductCategoryId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComBProductCategoryId.BorderRadius = 10;
            this.ComBProductCategoryId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBProductCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBProductCategoryId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBProductCategoryId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBProductCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBProductCategoryId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ComBProductCategoryId.ItemHeight = 30;
            this.ComBProductCategoryId.Items.AddRange(new object[] {
            "خامل ",
            "نشط"});
            this.ComBProductCategoryId.Location = new System.Drawing.Point(11, 324);
            this.ComBProductCategoryId.Name = "ComBProductCategoryId";
            this.ComBProductCategoryId.Size = new System.Drawing.Size(284, 36);
            this.ComBProductCategoryId.TabIndex = 43;
            this.ComBProductCategoryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsert.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnInsert.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnInsert.Image = global::SalesManagementSystem.Properties.Resources.Add;
            this.BtnInsert.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnInsert.ImageRotate = 0F;
            this.BtnInsert.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnInsert.Location = new System.Drawing.Point(117, 542);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnInsert.Size = new System.Drawing.Size(70, 70);
            this.BtnInsert.TabIndex = 42;
            this.BtnInsert.UseTransparentBackground = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::SalesManagementSystem.Properties.Resources.Info;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(117, 50);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(82, 76);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            // 
            // LabPhone
            // 
            this.LabPhone.AutoSize = true;
            this.LabPhone.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPhone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabPhone.Location = new System.Drawing.Point(14, 211);
            this.LabPhone.Name = "LabPhone";
            this.LabPhone.Size = new System.Drawing.Size(59, 21);
            this.LabPhone.TabIndex = 31;
            this.LabPhone.Text = "Phone";
            // 
            // LabManage
            // 
            this.LabManage.AutoSize = true;
            this.LabManage.Location = new System.Drawing.Point(34, 12);
            this.LabManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabManage.Name = "LabManage";
            this.LabManage.Size = new System.Drawing.Size(257, 33);
            this.LabManage.TabIndex = 3;
            this.LabManage.Text = "Manage Products";
            // 
            // LabAddress
            // 
            this.LabAddress.AutoSize = true;
            this.LabAddress.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabAddress.Location = new System.Drawing.Point(14, 300);
            this.LabAddress.Name = "LabAddress";
            this.LabAddress.Size = new System.Drawing.Size(70, 21);
            this.LabAddress.TabIndex = 30;
            this.LabAddress.Text = "Address";
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabName.Location = new System.Drawing.Point(20, 134);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(56, 21);
            this.LabName.TabIndex = 29;
            this.LabName.Text = "Name";
            // 
            // TxtProductName
            // 
            this.TxtProductName.BorderRadius = 10;
            this.TxtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtProductName.DefaultText = "";
            this.TxtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtProductName.Location = new System.Drawing.Point(11, 161);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.PasswordChar = '\0';
            this.TxtProductName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TxtProductName.PlaceholderText = "Product Name";
            this.TxtProductName.SelectedText = "";
            this.TxtProductName.Size = new System.Drawing.Size(284, 50);
            this.TxtProductName.TabIndex = 21;
            this.TxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtLastPrice
            // 
            this.TxtLastPrice.BorderRadius = 10;
            this.TxtLastPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLastPrice.DefaultText = "";
            this.TxtLastPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtLastPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtLastPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLastPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtLastPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLastPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtLastPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtLastPrice.Location = new System.Drawing.Point(11, 238);
            this.TxtLastPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtLastPrice.Name = "TxtLastPrice";
            this.TxtLastPrice.PasswordChar = '\0';
            this.TxtLastPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TxtLastPrice.PlaceholderText = "Store Phone";
            this.TxtLastPrice.SelectedText = "";
            this.TxtLastPrice.Size = new System.Drawing.Size(284, 50);
            this.TxtLastPrice.TabIndex = 17;
            this.TxtLastPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "UCProduct";
            this.Controls.SetChildIndex(this.PnlMain, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton BtnInsert;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label LabPhone;
        private System.Windows.Forms.Label LabManage;
        private System.Windows.Forms.Label LabAddress;
        private System.Windows.Forms.Label LabName;
        private Guna.UI2.WinForms.Guna2TextBox TxtProductName;
        private Guna.UI2.WinForms.Guna2TextBox TxtLastPrice;
        private Guna.UI2.WinForms.Guna2ComboBox ComBStoreId;
        private Guna.UI2.WinForms.Guna2ComboBox ComBProductCategoryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox ComBUnitId;
    }
}
