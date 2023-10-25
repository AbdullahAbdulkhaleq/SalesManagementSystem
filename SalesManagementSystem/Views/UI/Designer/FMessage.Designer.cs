namespace SalesManagementSystem.Views.UI.Designer
{
    partial class FMessage
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
            this.PnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.Captions = new System.Windows.Forms.Label();
            this.Icon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PnlMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Message = new System.Windows.Forms.Label();
            this.BtnOk = new Guna.UI2.WinForms.Guna2Button();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.PnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.Controls.Add(this.Captions);
            this.PnlHeader.Controls.Add(this.Icon);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.PnlHeader.Size = new System.Drawing.Size(295, 42);
            this.PnlHeader.TabIndex = 1;
            // 
            // Captions
            // 
            this.Captions.AutoEllipsis = true;
            this.Captions.Location = new System.Drawing.Point(58, 5);
            this.Captions.Name = "Captions";
            this.Captions.Size = new System.Drawing.Size(225, 33);
            this.Captions.TabIndex = 6;
            this.Captions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Icon
            // 
            this.Icon.Image = global::SalesManagementSystem.Properties.Resources.Info;
            this.Icon.ImageRotate = 0F;
            this.Icon.Location = new System.Drawing.Point(12, 2);
            this.Icon.Name = "Icon";
            this.Icon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Icon.Size = new System.Drawing.Size(40, 40);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon.TabIndex = 3;
            this.Icon.TabStop = false;
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.Message);
            this.PnlMain.Controls.Add(this.BtnOk);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 42);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(295, 132);
            this.PnlMain.TabIndex = 2;
            // 
            // Message
            // 
            this.Message.AutoEllipsis = true;
            this.Message.Location = new System.Drawing.Point(12, 37);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(271, 33);
            this.Message.TabIndex = 5;
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOk
            // 
            this.BtnOk.BorderRadius = 10;
            this.BtnOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOk.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(111, 93);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(73, 32);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "OK";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 174);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMessage";
            this.PnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.PnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlHeader;
        private Guna.UI2.WinForms.Guna2GradientPanel PnlMain;
        private Guna.UI2.WinForms.Guna2Button BtnOk;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Icon;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label Captions;
    }
}