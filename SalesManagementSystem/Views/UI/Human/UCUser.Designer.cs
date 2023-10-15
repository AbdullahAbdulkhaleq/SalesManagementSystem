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
            this.BtnMenuUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LabDepartment = new System.Windows.Forms.Label();
            this.LabUserStataus = new System.Windows.Forms.Label();
            this.LabUserPassword = new System.Windows.Forms.Label();
            this.LabUserName = new System.Windows.Forms.Label();
            this.CmpDepartmentId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtUserStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnMenuUser);
            this.panel1.Controls.Add(this.LabDepartment);
            this.panel1.Controls.Add(this.LabUserStataus);
            this.panel1.Controls.Add(this.LabUserPassword);
            this.panel1.Controls.Add(this.LabUserName);
            this.panel1.Controls.Add(this.CmpDepartmentId);
            this.panel1.Controls.Add(this.TxtUserName);
            this.panel1.Controls.Add(this.TxtUserStatus);
            this.panel1.Controls.Add(this.TxtUserPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 690);
            this.panel1.TabIndex = 3;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseEnter);
            // 
            // BtnMenuUser
            // 
            this.BtnMenuUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenuUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMenuUser.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuUser.Image = global::SalesManagementSystem.Properties.Resources.Add;
            this.BtnMenuUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMenuUser.ImageRotate = 0F;
            this.BtnMenuUser.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnMenuUser.Location = new System.Drawing.Point(124, 486);
            this.BtnMenuUser.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenuUser.Name = "BtnMenuUser";
            this.BtnMenuUser.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnMenuUser.Size = new System.Drawing.Size(70, 70);
            this.BtnMenuUser.TabIndex = 41;
            this.BtnMenuUser.UseTransparentBackground = true;
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
            // CmpDepartmentId
            // 
            this.CmpDepartmentId.BackColor = System.Drawing.Color.Transparent;
            this.CmpDepartmentId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.CmpDepartmentId.BorderRadius = 10;
            this.CmpDepartmentId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmpDepartmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmpDepartmentId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmpDepartmentId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmpDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmpDepartmentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CmpDepartmentId.ItemHeight = 30;
            this.CmpDepartmentId.Location = new System.Drawing.Point(17, 422);
            this.CmpDepartmentId.Name = "CmpDepartmentId";
            this.CmpDepartmentId.Size = new System.Drawing.Size(284, 36);
            this.CmpDepartmentId.TabIndex = 32;
            this.CmpDepartmentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserName.Location = new System.Drawing.Point(17, 155);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TxtUserName.PlaceholderText = "User Name";
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.Size = new System.Drawing.Size(284, 50);
            this.TxtUserName.TabIndex = 31;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtUserStatus
            // 
            this.TxtUserStatus.BorderRadius = 10;
            this.TxtUserStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserStatus.DefaultText = "";
            this.TxtUserStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUserStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUserStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserStatus.Location = new System.Drawing.Point(17, 332);
            this.TxtUserStatus.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserStatus.Name = "TxtUserStatus";
            this.TxtUserStatus.PasswordChar = '\0';
            this.TxtUserStatus.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TxtUserStatus.PlaceholderText = "User Status";
            this.TxtUserStatus.SelectedText = "";
            this.TxtUserStatus.Size = new System.Drawing.Size(284, 50);
            this.TxtUserStatus.TabIndex = 29;
            this.TxtUserStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.TxtUserPassword.TabIndex = 30;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(325, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 690);
            this.panel2.TabIndex = 17;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Button1.Image = global::SalesManagementSystem.Properties.Resources.update;
            this.guna2Button1.Location = new System.Drawing.Point(810, 10);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(140, 33);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Research";
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "UCUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label LabDepartment;
        private System.Windows.Forms.Label LabUserStataus;
        private System.Windows.Forms.Label LabUserPassword;
        private System.Windows.Forms.Label LabUserName;
        private Guna.UI2.WinForms.Guna2ComboBox CmpDepartmentId;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserName;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserStatus;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserPassword;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMenuUser;
    }
}
