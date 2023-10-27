namespace SalesManagementSystem.Views.UI.Human
{
    partial class UCUser
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
            this.LabManage = new System.Windows.Forms.Label();
            this.ComBUserStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnInsert = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LabDepartment = new System.Windows.Forms.Label();
            this.LabUserStataus = new System.Windows.Forms.Label();
            this.LabUserPassword = new System.Windows.Forms.Label();
            this.LabUserName = new System.Windows.Forms.Label();
            this.ComBDepartmentId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.LabManage);
            this.panel1.Controls.Add(this.ComBUserStatus);
            this.panel1.Controls.Add(this.BtnInsert);
            this.panel1.Controls.Add(this.LabDepartment);
            this.panel1.Controls.Add(this.LabUserStataus);
            this.panel1.Controls.Add(this.LabUserPassword);
            this.panel1.Controls.Add(this.LabUserName);
            this.panel1.Controls.Add(this.ComBDepartmentId);
            this.panel1.Controls.Add(this.TxtUserName);
            this.panel1.Controls.Add(this.TxtUserPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 690);
            this.panel1.TabIndex = 20;
            // 
            // LabManage
            // 
            this.LabManage.AutoSize = true;
            this.LabManage.Location = new System.Drawing.Point(34, 13);
            this.LabManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabManage.Name = "LabManage";
            this.LabManage.Size = new System.Drawing.Size(216, 33);
            this.LabManage.TabIndex = 37;
            this.LabManage.Text = "Manage Users";
            // 
            // ComBUserStatus
            // 
            this.ComBUserStatus.BackColor = System.Drawing.Color.Transparent;
            this.ComBUserStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComBUserStatus.BorderRadius = 10;
            this.ComBUserStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBUserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBUserStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBUserStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBUserStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ComBUserStatus.ItemHeight = 30;
            this.ComBUserStatus.Items.AddRange(new object[] {
            "خامل ",
            "نشط"});
            this.ComBUserStatus.Location = new System.Drawing.Point(17, 339);
            this.ComBUserStatus.Name = "ComBUserStatus";
            this.ComBUserStatus.Size = new System.Drawing.Size(284, 36);
            this.ComBUserStatus.TabIndex = 2;
            this.ComBUserStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnInsert.Location = new System.Drawing.Point(124, 486);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnInsert.Size = new System.Drawing.Size(70, 70);
            this.BtnInsert.TabIndex = 4;
            this.BtnInsert.UseTransparentBackground = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LabDepartment
            // 
            this.LabDepartment.AutoSize = true;
            this.LabDepartment.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDepartment.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabDepartment.Location = new System.Drawing.Point(20, 397);
            this.LabDepartment.Name = "LabDepartment";
            this.LabDepartment.Size = new System.Drawing.Size(102, 21);
            this.LabDepartment.TabIndex = 36;
            this.LabDepartment.Text = "Department";
            // 
            // LabUserStataus
            // 
            this.LabUserStataus.AutoSize = true;
            this.LabUserStataus.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUserStataus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabUserStataus.Location = new System.Drawing.Point(21, 308);
            this.LabUserStataus.Name = "LabUserStataus";
            this.LabUserStataus.Size = new System.Drawing.Size(66, 21);
            this.LabUserStataus.TabIndex = 35;
            this.LabUserStataus.Text = "Stataus";
            // 
            // LabUserPassword
            // 
            this.LabUserPassword.AutoSize = true;
            this.LabUserPassword.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUserPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabUserPassword.Location = new System.Drawing.Point(21, 219);
            this.LabUserPassword.Name = "LabUserPassword";
            this.LabUserPassword.Size = new System.Drawing.Size(82, 21);
            this.LabUserPassword.TabIndex = 34;
            this.LabUserPassword.Text = "Password";
            // 
            // LabUserName
            // 
            this.LabUserName.AutoSize = true;
            this.LabUserName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUserName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabUserName.Location = new System.Drawing.Point(22, 132);
            this.LabUserName.Name = "LabUserName";
            this.LabUserName.Size = new System.Drawing.Size(56, 21);
            this.LabUserName.TabIndex = 33;
            this.LabUserName.Text = "Name";
            // 
            // ComBDepartmentId
            // 
            this.ComBDepartmentId.BackColor = System.Drawing.Color.Transparent;
            this.ComBDepartmentId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ComBDepartmentId.BorderRadius = 10;
            this.ComBDepartmentId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComBDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBDepartmentId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBDepartmentId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComBDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBDepartmentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ComBDepartmentId.ItemHeight = 30;
            this.ComBDepartmentId.Items.AddRange(new object[] {
            "مدراء",
            "مبيعات",
            "مشتريات",
            "مخازن"});
            this.ComBDepartmentId.Location = new System.Drawing.Point(17, 422);
            this.ComBDepartmentId.Name = "ComBDepartmentId";
            this.ComBDepartmentId.Size = new System.Drawing.Size(284, 36);
            this.ComBDepartmentId.TabIndex = 3;
            this.ComBDepartmentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.Transparent;
            this.TxtUserName.BorderRadius = 10;
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.DefaultText = "";
            this.TxtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserName.Location = new System.Drawing.Point(17, 155);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TxtUserName.PlaceholderText = "User Name";
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.Size = new System.Drawing.Size(284, 50);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtUserPassword
            // 
            this.TxtUserPassword.BorderRadius = 10;
            this.TxtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserPassword.DefaultText = "";
            this.TxtUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserPassword.Location = new System.Drawing.Point(17, 243);
            this.TxtUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserPassword.Name = "TxtUserPassword";
            this.TxtUserPassword.PasswordChar = '●';
            this.TxtUserPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TxtUserPassword.PlaceholderText = "User Password";
            this.TxtUserPassword.SelectedText = "";
            this.TxtUserPassword.Size = new System.Drawing.Size(284, 50);
            this.TxtUserPassword.TabIndex = 1;
            this.TxtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUserPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Products";
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "UCUser";
            this.Load += new System.EventHandler(this.UCUser_Load);
            this.Controls.SetChildIndex(this.PnlMain, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton BtnInsert;
        private System.Windows.Forms.Label LabDepartment;
        private System.Windows.Forms.Label LabUserStataus;
        private System.Windows.Forms.Label LabUserPassword;
        private System.Windows.Forms.Label LabUserName;
        private Guna.UI2.WinForms.Guna2ComboBox ComBDepartmentId;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserName;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox ComBUserStatus;
        private System.Windows.Forms.Label LabManage;
    }
}
