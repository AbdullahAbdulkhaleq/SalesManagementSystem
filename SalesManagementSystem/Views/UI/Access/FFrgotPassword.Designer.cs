namespace SalesManagementSystem.Views.UI.Access
{
    partial class FFrgotPassword
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
            this.TUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRecovery = new Guna.UI2.WinForms.Guna2Button();
            this.TTesting = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // TUserName
            // 
            this.TUserName.BorderRadius = 10;
            this.TUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TUserName.DefaultText = "";
            this.TUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TUserName.Location = new System.Drawing.Point(51, 68);
            this.TUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TUserName.Name = "TUserName";
            this.TUserName.PasswordChar = '\0';
            this.TUserName.PlaceholderText = "User Name";
            this.TUserName.SelectedText = "";
            this.TUserName.Size = new System.Drawing.Size(212, 36);
            this.TUserName.TabIndex = 3;
            this.TUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRecovery
            // 
            this.btnRecovery.BorderRadius = 10;
            this.btnRecovery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecovery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecovery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecovery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecovery.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecovery.ForeColor = System.Drawing.Color.White;
            this.btnRecovery.Location = new System.Drawing.Point(51, 270);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(212, 36);
            this.btnRecovery.TabIndex = 4;
            this.btnRecovery.Text = "Recovery";
            // 
            // TTesting
            // 
            this.TTesting.BorderRadius = 10;
            this.TTesting.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TTesting.DefaultText = "";
            this.TTesting.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TTesting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TTesting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TTesting.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TTesting.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TTesting.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTesting.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TTesting.Location = new System.Drawing.Point(51, 184);
            this.TTesting.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TTesting.Name = "TTesting";
            this.TTesting.PasswordChar = '\0';
            this.TTesting.PlaceholderText = "";
            this.TTesting.SelectedText = "";
            this.TTesting.Size = new System.Drawing.Size(212, 36);
            this.TTesting.TabIndex = 5;
            this.TTesting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FFrgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 375);
            this.Controls.Add(this.TTesting);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.TUserName);
            this.Name = "FFrgotPassword";
            this.Text = "FFrgotPassword";
            this.Controls.SetChildIndex(this.TUserName, 0);
            this.Controls.SetChildIndex(this.btnRecovery, 0);
            this.Controls.SetChildIndex(this.TTesting, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TUserName;
        private Guna.UI2.WinForms.Guna2Button btnRecovery;
        private Guna.UI2.WinForms.Guna2TextBox TTesting;
    }
}