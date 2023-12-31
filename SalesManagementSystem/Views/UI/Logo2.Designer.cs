﻿namespace SalesManagementSystem.Views.UI
{
    partial class Logo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logo2));
            this.TMain = new System.Windows.Forms.Timer(this.components);
            this.LSalesManagementSystem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBMain = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TMain
            // 
            this.TMain.Enabled = true;
            this.TMain.Interval = 250;
            this.TMain.Tick += new System.EventHandler(this.TMain_Tick);
            // 
            // LSalesManagementSystem
            // 
            this.LSalesManagementSystem.AutoSize = true;
            this.LSalesManagementSystem.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSalesManagementSystem.Location = new System.Drawing.Point(276, 491);
            this.LSalesManagementSystem.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LSalesManagementSystem.Name = "LSalesManagementSystem";
            this.LSalesManagementSystem.Size = new System.Drawing.Size(460, 44);
            this.LSalesManagementSystem.TabIndex = 6;
            this.LSalesManagementSystem.Text = "Sales Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManagementSystem.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 548);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PBMain
            // 
            this.PBMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PBMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PBMain.Location = new System.Drawing.Point(0, 563);
            this.PBMain.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(1011, 22);
            this.PBMain.TabIndex = 4;
            this.PBMain.Value = 10;
            // 
            // Logo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 585);
            this.Controls.Add(this.LSalesManagementSystem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PBMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Logo1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TMain;
        private System.Windows.Forms.Label LSalesManagementSystem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar PBMain;
    }
}