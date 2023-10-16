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
            this.BtnRecovery = new Guna.UI2.WinForms.Guna2Button();
            this.TAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnExit.HoverState.ImageSize = new System.Drawing.Size(39, 33);
            this.BtnExit.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.TUserName.Location = new System.Drawing.Point(77, 95);
            this.TUserName.Margin = new System.Windows.Forms.Padding(6);
            this.TUserName.Name = "TUserName";
            this.TUserName.PasswordChar = '\0';
            this.TUserName.PlaceholderText = "User Name";
            this.TUserName.SelectedText = "";
            this.TUserName.Size = new System.Drawing.Size(318, 50);
            this.TUserName.TabIndex = 0;
            this.TUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnRecovery
            // 
            this.BtnRecovery.BorderRadius = 10;
            this.BtnRecovery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRecovery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRecovery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRecovery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRecovery.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecovery.ForeColor = System.Drawing.Color.White;
            this.BtnRecovery.Location = new System.Drawing.Point(77, 372);
            this.BtnRecovery.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRecovery.Name = "BtnRecovery";
            this.BtnRecovery.Size = new System.Drawing.Size(318, 50);
            this.BtnRecovery.TabIndex = 3;
            this.BtnRecovery.Text = "Recovery";
            this.BtnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // TAnswer
            // 
            this.TAnswer.BorderRadius = 10;
            this.TAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TAnswer.DefaultText = "";
            this.TAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TAnswer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TAnswer.Location = new System.Drawing.Point(77, 254);
            this.TAnswer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TAnswer.Name = "TAnswer";
            this.TAnswer.PasswordChar = '\0';
            this.TAnswer.PlaceholderText = "Answer";
            this.TAnswer.SelectedText = "";
            this.TAnswer.Size = new System.Drawing.Size(318, 50);
            this.TAnswer.TabIndex = 2;
            this.TAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(77, 183);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(318, 36);
            this.guna2ComboBox1.TabIndex = 1;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // FFrgotPassword
            // 
            this.AcceptButton = this.BtnRecovery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 516);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.TAnswer);
            this.Controls.Add(this.BtnRecovery);
            this.Controls.Add(this.TUserName);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "FFrgotPassword";
            this.Text = "FFrgotPassword";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FFrgotPassword_Load);
            this.Controls.SetChildIndex(this.LabWelcome, 0);
            this.Controls.SetChildIndex(this.TUserName, 0);
            this.Controls.SetChildIndex(this.BtnRecovery, 0);
            this.Controls.SetChildIndex(this.TAnswer, 0);
            this.Controls.SetChildIndex(this.guna2ComboBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TUserName;
        private Guna.UI2.WinForms.Guna2Button BtnRecovery;
        private Guna.UI2.WinForms.Guna2TextBox TAnswer;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}