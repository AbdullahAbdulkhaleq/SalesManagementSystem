namespace SalesManagementSystem.Views.UI.Purchasing
{
    partial class UCPurchasing
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
            this.LbUserName = new System.Windows.Forms.Label();
            this.BUserIcon = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUserIcon)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LbUserName);
            this.panel1.Controls.Add(this.BUserIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 65);
            this.panel1.TabIndex = 8;
            // 
            // LbUserName
            // 
            this.LbUserName.AutoSize = true;
            this.LbUserName.Location = new System.Drawing.Point(142, 22);
            this.LbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(103, 33);
            this.LbUserName.TabIndex = 12;
            this.LbUserName.Text = "Admin";
            // 
            // BUserIcon
            // 
            this.BUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.BUserIcon.Image = global::SalesManagementSystem.Properties.Resources.Info;
            this.BUserIcon.ImageActive = null;
            this.BUserIcon.Location = new System.Drawing.Point(39, 0);
            this.BUserIcon.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BUserIcon.Name = "BUserIcon";
            this.BUserIcon.Size = new System.Drawing.Size(75, 65);
            this.BUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BUserIcon.TabIndex = 11;
            this.BUserIcon.TabStop = false;
            this.BUserIcon.Zoom = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1291, 702);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(964, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 702);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 702);
            this.panel2.TabIndex = 6;
            // 
            // UCPurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "UCPurchasing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUserIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbUserName;
        private Bunifu.Framework.UI.BunifuImageButton BUserIcon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
