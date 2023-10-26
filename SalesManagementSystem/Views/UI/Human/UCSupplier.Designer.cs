namespace SalesManagementSystem.Views.UI.Human
{
    partial class UCSupplier
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
            this.PanInsert = new System.Windows.Forms.Panel();
            this.LabCategory = new System.Windows.Forms.Label();
            this.LabEmail = new System.Windows.Forms.Label();
            this.LabPhone = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.BtnInsert = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LabBrand = new System.Windows.Forms.Label();
            this.ComBSupplierType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtSupplierBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabManage = new System.Windows.Forms.Label();
            this.TxtSupplierEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtSupplierName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtSupplierPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanInsert.SuspendLayout();
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
            // PanInsert
            // 
            this.PanInsert.BackColor = System.Drawing.Color.White;
            this.PanInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanInsert.Controls.Add(this.LabCategory);
            this.PanInsert.Controls.Add(this.LabEmail);
            this.PanInsert.Controls.Add(this.LabPhone);
            this.PanInsert.Controls.Add(this.LabName);
            this.PanInsert.Controls.Add(this.BtnInsert);
            this.PanInsert.Controls.Add(this.LabBrand);
            this.PanInsert.Controls.Add(this.ComBSupplierType);
            this.PanInsert.Controls.Add(this.TxtSupplierBrand);
            this.PanInsert.Controls.Add(this.LabManage);
            this.PanInsert.Controls.Add(this.TxtSupplierEmail);
            this.PanInsert.Controls.Add(this.TxtSupplierName);
            this.PanInsert.Controls.Add(this.TxtSupplierPhone);
            this.PanInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanInsert.Location = new System.Drawing.Point(5, 5);
            this.PanInsert.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PanInsert.Name = "PanInsert";
            this.PanInsert.Size = new System.Drawing.Size(320, 690);
            this.PanInsert.TabIndex = 22;
            // 
            // LabCategory
            // 
            this.LabCategory.AutoSize = true;
            this.LabCategory.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCategory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabCategory.Location = new System.Drawing.Point(33, 361);
            this.LabCategory.Name = "LabCategory";
            this.LabCategory.Size = new System.Drawing.Size(46, 21);
            this.LabCategory.TabIndex = 45;
            this.LabCategory.Text = "Type";
            // 
            // LabEmail
            // 
            this.LabEmail.AutoSize = true;
            this.LabEmail.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabEmail.Location = new System.Drawing.Point(36, 277);
            this.LabEmail.Name = "LabEmail";
            this.LabEmail.Size = new System.Drawing.Size(51, 21);
            this.LabEmail.TabIndex = 44;
            this.LabEmail.Text = "Email";
            // 
            // LabPhone
            // 
            this.LabPhone.AutoSize = true;
            this.LabPhone.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPhone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabPhone.Location = new System.Drawing.Point(36, 200);
            this.LabPhone.Name = "LabPhone";
            this.LabPhone.Size = new System.Drawing.Size(59, 21);
            this.LabPhone.TabIndex = 43;
            this.LabPhone.Text = "Phone";
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabName.Location = new System.Drawing.Point(36, 104);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(56, 21);
            this.LabName.TabIndex = 42;
            this.LabName.Text = "Name";
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
            this.BtnInsert.Location = new System.Drawing.Point(124, 550);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnInsert.Size = new System.Drawing.Size(70, 70);
            this.BtnInsert.TabIndex = 41;
            this.BtnInsert.UseTransparentBackground = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LabBrand
            // 
            this.LabBrand.AutoSize = true;
            this.LabBrand.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBrand.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabBrand.Location = new System.Drawing.Point(33, 436);
            this.LabBrand.Name = "LabBrand";
            this.LabBrand.Size = new System.Drawing.Size(55, 21);
            this.LabBrand.TabIndex = 39;
            this.LabBrand.Text = "Brand";
            // 
            // ComBSupplierType
            // 
            this.ComBSupplierType.BackColor = System.Drawing.Color.Transparent;
            this.ComBSupplierType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComBSupplierType.BorderRadius = 10;
            this.ComBSupplierType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBSupplierType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBSupplierType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBSupplierType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBSupplierType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBSupplierType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ComBSupplierType.ItemHeight = 30;
            this.ComBSupplierType.Location = new System.Drawing.Point(18, 391);
            this.ComBSupplierType.Margin = new System.Windows.Forms.Padding(4);
            this.ComBSupplierType.Name = "ComBSupplierType";
            this.ComBSupplierType.Size = new System.Drawing.Size(282, 36);
            this.ComBSupplierType.TabIndex = 32;
            this.ComBSupplierType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSupplierBrand
            // 
            this.TxtSupplierBrand.BorderRadius = 10;
            this.TxtSupplierBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSupplierBrand.DefaultText = "";
            this.TxtSupplierBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSupplierBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSupplierBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSupplierBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSupplierBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSupplierBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSupplierBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSupplierBrand.Location = new System.Drawing.Point(16, 463);
            this.TxtSupplierBrand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtSupplierBrand.Name = "TxtSupplierBrand";
            this.TxtSupplierBrand.PasswordChar = '\0';
            this.TxtSupplierBrand.PlaceholderText = "Supplier Brand";
            this.TxtSupplierBrand.SelectedText = "";
            this.TxtSupplierBrand.Size = new System.Drawing.Size(284, 50);
            this.TxtSupplierBrand.TabIndex = 29;
            this.TxtSupplierBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabManage
            // 
            this.LabManage.AutoSize = true;
            this.LabManage.Location = new System.Drawing.Point(34, 12);
            this.LabManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabManage.Name = "LabManage";
            this.LabManage.Size = new System.Drawing.Size(249, 33);
            this.LabManage.TabIndex = 3;
            this.LabManage.Text = "Manage Supplier";
            // 
            // TxtSupplierEmail
            // 
            this.TxtSupplierEmail.BorderRadius = 10;
            this.TxtSupplierEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSupplierEmail.DefaultText = "";
            this.TxtSupplierEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSupplierEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSupplierEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSupplierEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSupplierEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSupplierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSupplierEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSupplierEmail.Location = new System.Drawing.Point(16, 304);
            this.TxtSupplierEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtSupplierEmail.Name = "TxtSupplierEmail";
            this.TxtSupplierEmail.PasswordChar = '\0';
            this.TxtSupplierEmail.PlaceholderText = "Supplier Email";
            this.TxtSupplierEmail.SelectedText = "";
            this.TxtSupplierEmail.Size = new System.Drawing.Size(284, 50);
            this.TxtSupplierEmail.TabIndex = 17;
            this.TxtSupplierEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSupplierName
            // 
            this.TxtSupplierName.BorderRadius = 10;
            this.TxtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSupplierName.DefaultText = "";
            this.TxtSupplierName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSupplierName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSupplierName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSupplierName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSupplierName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSupplierName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSupplierName.Location = new System.Drawing.Point(19, 131);
            this.TxtSupplierName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtSupplierName.Name = "TxtSupplierName";
            this.TxtSupplierName.PasswordChar = '\0';
            this.TxtSupplierName.PlaceholderText = "Supplier Name";
            this.TxtSupplierName.SelectedText = "";
            this.TxtSupplierName.Size = new System.Drawing.Size(284, 50);
            this.TxtSupplierName.TabIndex = 21;
            this.TxtSupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSupplierPhone
            // 
            this.TxtSupplierPhone.BorderRadius = 10;
            this.TxtSupplierPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSupplierPhone.DefaultText = "";
            this.TxtSupplierPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSupplierPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSupplierPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSupplierPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSupplierPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSupplierPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSupplierPhone.Location = new System.Drawing.Point(16, 221);
            this.TxtSupplierPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtSupplierPhone.Name = "TxtSupplierPhone";
            this.TxtSupplierPhone.PasswordChar = '\0';
            this.TxtSupplierPhone.PlaceholderText = "Supplier Phone";
            this.TxtSupplierPhone.SelectedText = "";
            this.TxtSupplierPhone.Size = new System.Drawing.Size(284, 50);
            this.TxtSupplierPhone.TabIndex = 18;
            this.TxtSupplierPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UCSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanInsert);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "UCSupplier";
            this.Controls.SetChildIndex(this.PnlMain, 0);
            this.Controls.SetChildIndex(this.PanInsert, 0);
            this.PanInsert.ResumeLayout(false);
            this.PanInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanInsert;
        private System.Windows.Forms.Label LabCategory;
        private System.Windows.Forms.Label LabEmail;
        private System.Windows.Forms.Label LabPhone;
        private System.Windows.Forms.Label LabName;
        public Guna.UI2.WinForms.Guna2ImageButton BtnInsert;
        private System.Windows.Forms.Label LabBrand;
        private Guna.UI2.WinForms.Guna2ComboBox ComBSupplierType;
        private Guna.UI2.WinForms.Guna2TextBox TxtSupplierBrand;
        private System.Windows.Forms.Label LabManage;
        private Guna.UI2.WinForms.Guna2TextBox TxtSupplierEmail;
        private Guna.UI2.WinForms.Guna2TextBox TxtSupplierName;
        private Guna.UI2.WinForms.Guna2TextBox TxtSupplierPhone;
    }
}
