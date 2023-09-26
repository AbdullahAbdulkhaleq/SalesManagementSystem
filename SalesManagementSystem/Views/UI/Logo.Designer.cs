namespace SalesManagementSystem.Views.UI
{
    partial class Logo
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
            this.components = new System.ComponentModel.Container();
            this.TLogo = new System.Windows.Forms.Timer(this.components);
            this.PBMain = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TLogo
            // 
            this.TLogo.Enabled = true;
            this.TLogo.Tick += new System.EventHandler(this.TLogo_Tick);
            // 
            // PBMain
            // 
            this.PBMain.BackColor = System.Drawing.Color.White;
            this.PBMain.Controls.Add(this.guna2PictureBox1);
            this.PBMain.Controls.Add(this.label2);
            this.PBMain.Controls.Add(this.label1);
            this.PBMain.Controls.Add(this.LTimer);
            this.PBMain.Controls.Add(this.pictureBox1);
            this.PBMain.FillColor = System.Drawing.Color.White;
            this.PBMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PBMain.ForeColor = System.Drawing.Color.White;
            this.PBMain.Location = new System.Drawing.Point(34, -356);
            this.PBMain.Minimum = 0;
            this.PBMain.Name = "PBMain";
            this.PBMain.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PBMain.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(200)))));
            this.PBMain.ProgressThickness = 500;
            this.PBMain.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PBMain.Size = new System.Drawing.Size(1200, 1200);
            this.PBMain.TabIndex = 1;
            this.PBMain.Text = "guna2CircleProgressBar1";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::SalesManagementSystem.Properties.Resources.fbc00f81999693_5d10c08723f94;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(526, 535);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(150, 127);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 751);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loding .....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sales Management System";
            // 
            // LTimer
            // 
            this.LTimer.AutoSize = true;
            this.LTimer.BackColor = System.Drawing.Color.Transparent;
            this.LTimer.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTimer.ForeColor = System.Drawing.Color.Black;
            this.LTimer.Location = new System.Drawing.Point(199, 751);
            this.LTimer.Name = "LTimer";
            this.LTimer.Size = new System.Drawing.Size(34, 40);
            this.LTimer.TabIndex = 9;
            this.LTimer.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SalesManagementSystem.Properties.Resources.Discount_cuate;
            this.pictureBox1.Location = new System.Drawing.Point(-34, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 444);
            this.Controls.Add(this.PBMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Logo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logo";
            this.PBMain.ResumeLayout(false);
            this.PBMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TLogo;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PBMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LTimer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}