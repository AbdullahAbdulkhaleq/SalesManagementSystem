namespace SalesManagementSystem.Views.UI.Designer
{
    partial class FDMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.min = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 27);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2ImageButton1);
            this.panel2.Controls.Add(this.BExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(517, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 27);
            this.panel2.TabIndex = 3;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 7);
            this.guna2ImageButton1.Image = global::SalesManagementSystem.Properties.Resources.minimiz;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(25, 5);
            this.guna2ImageButton1.Location = new System.Drawing.Point(13, 1);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(27, 23);
            this.guna2ImageButton1.TabIndex = 5;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // BExit
            // 
            this.BExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BExit.HoverState.ImageSize = new System.Drawing.Size(39, 33);
            this.BExit.Image = global::SalesManagementSystem.Properties.Resources.Close;
            this.BExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.BExit.ImageRotate = 0F;
            this.BExit.ImageSize = new System.Drawing.Size(34, 27);
            this.BExit.Location = new System.Drawing.Point(78, 0);
            this.BExit.Name = "BExit";
            this.BExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BExit.Size = new System.Drawing.Size(32, 25);
            this.BExit.TabIndex = 3;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            this.BExit.MouseEnter += new System.EventHandler(this.BExit_MouseEnter);
            this.BExit.MouseLeave += new System.EventHandler(this.BExit_MouseLeave);
            // 
            // FDMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 375);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::SalesManagementSystem.Properties.Resources.Logo;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FDMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip min;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton BExit;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}