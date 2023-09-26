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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinFrgotPassword
            // 
            this.LinFrgotPassword.AutoSize = true;
            this.LinFrgotPassword.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinFrgotPassword.LinkColor = System.Drawing.Color.Red;
            this.LinFrgotPassword.Location = new System.Drawing.Point(300, 285);
            this.LinFrgotPassword.Name = "LinFrgotPassword";
            this.LinFrgotPassword.Size = new System.Drawing.Size(139, 31);
            this.LinFrgotPassword.TabIndex = 10;
            this.LinFrgotPassword.TabStop = true;
            this.LinFrgotPassword.Text = "Frgot Password";
            this.LinFrgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinFrgotPassword_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManagementSystem.Properties.Resources.Shopping_bag_bro;
            this.pictureBox1.Location = new System.Drawing.Point(3, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
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
            this.TUserName.IconLeft = global::SalesManagementSystem.Properties.Resources.user_512px;
            this.TUserName.Location = new System.Drawing.Point(273, 82);
            this.TUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TUserName.Name = "TUserName";
            this.TUserName.PasswordChar = '\0';
            this.TUserName.PlaceholderText = "User Name";
            this.TUserName.SelectedText = "";
            this.TUserName.Size = new System.Drawing.Size(216, 36);
            this.TUserName.TabIndex = 21;
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
            this.TUserPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TUserPassword.IconLeft = global::SalesManagementSystem.Properties.Resources.password_144px;
            this.TUserPassword.Location = new System.Drawing.Point(273, 154);
            this.TUserPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TUserPassword.Name = "TUserPassword";
            this.TUserPassword.PasswordChar = '●';
            this.TUserPassword.PlaceholderText = "Password";
            this.TUserPassword.SelectedText = "";
            this.TUserPassword.Size = new System.Drawing.Size(216, 36);
            this.TUserPassword.TabIndex = 22;
            this.TUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TUserPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(273, 225);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 36);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 340);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.TUserPassword);
            this.Controls.Add(this.TUserName);
            this.Controls.Add(this.LinFrgotPassword);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FLogin";
            this.Text = "FLogin";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.LinFrgotPassword, 0);
            this.Controls.SetChildIndex(this.TUserName, 0);
            this.Controls.SetChildIndex(this.TUserPassword, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinFrgotPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox TUserName;
        private Guna.UI2.WinForms.Guna2TextBox TUserPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}