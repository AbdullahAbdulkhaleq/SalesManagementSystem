namespace SalesManagementSystem.Views.UI.Human
{
    partial class UCCustomer
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
            this.BtnInsert = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LabType = new System.Windows.Forms.Label();
            this.LabEmail = new System.Windows.Forms.Label();
            this.LabPhone = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.LabManage = new System.Windows.Forms.Label();
            this.ComBCustomerType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCustomerEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCustomerPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.BtnInsert);
            this.panel1.Controls.Add(this.LabType);
            this.panel1.Controls.Add(this.LabEmail);
            this.panel1.Controls.Add(this.LabPhone);
            this.panel1.Controls.Add(this.LabName);
            this.panel1.Controls.Add(this.LabManage);
            this.panel1.Controls.Add(this.ComBCustomerType);
            this.panel1.Controls.Add(this.TxtCustomerName);
            this.panel1.Controls.Add(this.TxtCustomerEmail);
            this.panel1.Controls.Add(this.TxtCustomerPhone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 690);
            this.panel1.TabIndex = 20;
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
            this.BtnInsert.Location = new System.Drawing.Point(124, 462);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnInsert.Size = new System.Drawing.Size(70, 70);
            this.BtnInsert.TabIndex = 41;
            this.BtnInsert.UseTransparentBackground = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LabType
            // 
            this.LabType.AutoSize = true;
            this.LabType.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabType.Location = new System.Drawing.Point(15, 376);
            this.LabType.Name = "LabType";
            this.LabType.Size = new System.Drawing.Size(46, 21);
            this.LabType.TabIndex = 34;
            this.LabType.Text = "Type";
            // 
            // LabEmail
            // 
            this.LabEmail.AutoSize = true;
            this.LabEmail.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabEmail.Location = new System.Drawing.Point(15, 285);
            this.LabEmail.Name = "LabEmail";
            this.LabEmail.Size = new System.Drawing.Size(51, 21);
            this.LabEmail.TabIndex = 33;
            this.LabEmail.Text = "Email";
            // 
            // LabPhone
            // 
            this.LabPhone.AutoSize = true;
            this.LabPhone.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPhone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabPhone.Location = new System.Drawing.Point(11, 183);
            this.LabPhone.Name = "LabPhone";
            this.LabPhone.Size = new System.Drawing.Size(59, 21);
            this.LabPhone.TabIndex = 32;
            this.LabPhone.Text = "Phone";
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabName.Location = new System.Drawing.Point(16, 90);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(56, 21);
            this.LabName.TabIndex = 31;
            this.LabName.Text = "Name";
            // 
            // LabManage
            // 
            this.LabManage.AutoSize = true;
            this.LabManage.Location = new System.Drawing.Point(31, 12);
            this.LabManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabManage.Name = "LabManage";
            this.LabManage.Size = new System.Drawing.Size(269, 33);
            this.LabManage.TabIndex = 3;
            this.LabManage.Text = "Manage Customer";
            // 
            // ComBCustomerType
            // 
            this.ComBCustomerType.BackColor = System.Drawing.Color.Transparent;
            this.ComBCustomerType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComBCustomerType.BorderRadius = 10;
            this.ComBCustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBCustomerType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBCustomerType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ComBCustomerType.ItemHeight = 30;
            this.ComBCustomerType.Items.AddRange(new object[] {
            "محلي",
            "خارجي"});
            this.ComBCustomerType.Location = new System.Drawing.Point(8, 401);
            this.ComBCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.ComBCustomerType.Name = "ComBCustomerType";
            this.ComBCustomerType.Size = new System.Drawing.Size(303, 36);
            this.ComBCustomerType.TabIndex = 22;
            this.ComBCustomerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.BorderRadius = 10;
            this.TxtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCustomerName.DefaultText = "";
            this.TxtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCustomerName.Location = new System.Drawing.Point(8, 115);
            this.TxtCustomerName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.PasswordChar = '\0';
            this.TxtCustomerName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TxtCustomerName.PlaceholderText = "Customer Name";
            this.TxtCustomerName.SelectedText = "";
            this.TxtCustomerName.Size = new System.Drawing.Size(303, 55);
            this.TxtCustomerName.TabIndex = 21;
            this.TxtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.BorderRadius = 10;
            this.TxtCustomerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCustomerEmail.DefaultText = "";
            this.TxtCustomerEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCustomerEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCustomerEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCustomerEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCustomerEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCustomerEmail.Location = new System.Drawing.Point(8, 310);
            this.TxtCustomerEmail.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.PasswordChar = '\0';
            this.TxtCustomerEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TxtCustomerEmail.PlaceholderText = "Customer Email";
            this.TxtCustomerEmail.SelectedText = "";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(303, 55);
            this.TxtCustomerEmail.TabIndex = 17;
            this.TxtCustomerEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCustomerPhone
            // 
            this.TxtCustomerPhone.BorderRadius = 10;
            this.TxtCustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCustomerPhone.DefaultText = "";
            this.TxtCustomerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCustomerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCustomerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCustomerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCustomerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCustomerPhone.Location = new System.Drawing.Point(7, 211);
            this.TxtCustomerPhone.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtCustomerPhone.Name = "TxtCustomerPhone";
            this.TxtCustomerPhone.PasswordChar = '\0';
            this.TxtCustomerPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TxtCustomerPhone.PlaceholderText = "Customer Phone";
            this.TxtCustomerPhone.SelectedText = "";
            this.TxtCustomerPhone.Size = new System.Drawing.Size(303, 55);
            this.TxtCustomerPhone.TabIndex = 18;
            this.TxtCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UCCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UCCustomer";
            this.Controls.SetChildIndex(this.PnlMain, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton BtnInsert;
        private System.Windows.Forms.Label LabType;
        private System.Windows.Forms.Label LabEmail;
        private System.Windows.Forms.Label LabPhone;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Label LabManage;
        private Guna.UI2.WinForms.Guna2ComboBox ComBCustomerType;
        private Guna.UI2.WinForms.Guna2TextBox TxtCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox TxtCustomerEmail;
        private Guna.UI2.WinForms.Guna2TextBox TxtCustomerPhone;
    }
}
