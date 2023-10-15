namespace SalesManagementSystem.Views.UI.Access
{
    partial class FLogin
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
            this.LinFrgotPassword = new System.Windows.Forms.LinkLabel();
            this.PicBLogin = new System.Windows.Forms.PictureBox();
            this.TUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.PBLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // LinFrgotPassword
            // 
            this.LinFrgotPassword.AutoSize = true;
            this.LinFrgotPassword.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinFrgotPassword.LinkColor = System.Drawing.Color.Red;
            this.LinFrgotPassword.Location = new System.Drawing.Point(450, 392);
            this.LinFrgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinFrgotPassword.Name = "LinFrgotPassword";
            this.LinFrgotPassword.Size = new System.Drawing.Size(212, 47);
            this.LinFrgotPassword.TabIndex = 3;
            this.LinFrgotPassword.TabStop = true;
            this.LinFrgotPassword.Text = "Frgot Password";
            this.LinFrgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinFrgotPassword_LinkClicked);
            // 
            // PicBLogin
            // 
            this.PicBLogin.Image = global::SalesManagementSystem.Properties.Resources.Logo_Logins;
            this.PicBLogin.Location = new System.Drawing.Point(4, 63);
            this.PicBLogin.Margin = new System.Windows.Forms.Padding(4);
            this.PicBLogin.Name = "PicBLogin";
            this.PicBLogin.Size = new System.Drawing.Size(399, 374);
            this.PicBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBLogin.TabIndex = 11;
            this.PicBLogin.TabStop = false;
            // 
            // TUserName
            // 
            this.TUserName.BorderRadius = 20;
            this.TUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TUserName.DefaultText = "";
            this.TUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TUserName.IconLeft = global::SalesManagementSystem.Properties.Resources.Use_Login;
            this.TUserName.Location = new System.Drawing.Point(410, 113);
            this.TUserName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TUserName.Name = "TUserName";
            this.TUserName.PasswordChar = '\0';
            this.TUserName.PlaceholderText = "User Name";
            this.TUserName.SelectedText = "";
            this.TUserName.Size = new System.Drawing.Size(324, 50);
            this.TUserName.TabIndex = 0;
            this.TUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUserPassword
            // 
            this.TUserPassword.BorderRadius = 20;
            this.TUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TUserPassword.DefaultText = "";
            this.TUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TUserPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TUserPassword.IconLeft = global::SalesManagementSystem.Properties.Resources.password_Login;
            this.TUserPassword.Location = new System.Drawing.Point(410, 212);
            this.TUserPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TUserPassword.Name = "TUserPassword";
            this.TUserPassword.PasswordChar = '●';
            this.TUserPassword.PlaceholderText = "Password";
            this.TUserPassword.SelectedText = "";
            this.TUserPassword.Size = new System.Drawing.Size(324, 50);
            this.TUserPassword.TabIndex = 1;
            this.TUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TUserPassword.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.BorderRadius = 20;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.Color.RoyalBlue;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnLogin.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnLogin.Location = new System.Drawing.Point(410, 316);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(324, 50);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Tag = "";
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PBLogin
            // 
            this.PBLogin.Image = global::SalesManagementSystem.Properties.Resources.Updategif;
            this.PBLogin.ImageRotate = 0F;
            this.PBLogin.Location = new System.Drawing.Point(375, 224);
            this.PBLogin.Name = "PBLogin";
            this.PBLogin.Size = new System.Drawing.Size(392, 221);
            this.PBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogin.TabIndex = 19;
            this.PBLogin.TabStop = false;
            this.PBLogin.Visible = false;
            // 
            // FLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 468);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TUserPassword);
            this.Controls.Add(this.TUserName);
            this.Controls.Add(this.LinFrgotPassword);
            this.Controls.Add(this.PicBLogin);
            this.Controls.Add(this.PBLogin);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "FLogin";
            this.Text = "FLogin";
            this.Load += new System.EventHandler(this.FFrgotPassword_Load);
            this.Controls.SetChildIndex(this.PBLogin, 0);
            this.Controls.SetChildIndex(this.PicBLogin, 0);
            this.Controls.SetChildIndex(this.LinFrgotPassword, 0);
            this.Controls.SetChildIndex(this.TUserName, 0);
            this.Controls.SetChildIndex(this.TUserPassword, 0);
            this.Controls.SetChildIndex(this.BtnLogin, 0);
            this.Controls.SetChildIndex(this.LabWelcome, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PicBLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinFrgotPassword;
        private System.Windows.Forms.PictureBox PicBLogin;
        private Guna.UI2.WinForms.Guna2TextBox TUserName;
        private Guna.UI2.WinForms.Guna2TextBox TUserPassword;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox PBLogin;
    }
}