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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDMain));
            this.min = new System.Windows.Forms.ToolTip(this.components);
            this.BtnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnMinimized = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PHeader = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PHeadController = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.LabWelcome = new System.Windows.Forms.Label();
            this.BtnLogOut = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PHeader.SuspendLayout();
            this.PHeadController.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.HoverState.ImageSize = new System.Drawing.Size(39, 33);
            this.BtnExit.Image = global::SalesManagementSystem.Properties.Resources.Close;
            this.BtnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnExit.ImageRotate = 0F;
            this.BtnExit.ImageSize = new System.Drawing.Size(34, 27);
            this.BtnExit.Location = new System.Drawing.Point(116, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnExit.Size = new System.Drawing.Size(32, 33);
            this.BtnExit.TabIndex = 6;
            this.min.SetToolTip(this.BtnExit, "خروج");
            this.BtnExit.UseTransparentBackground = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.BtnExit.Enter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.BtnExit.Leave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // BtnMinimized
            // 
            this.BtnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimized.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMinimized.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMinimized.HoverState.ImageSize = new System.Drawing.Size(30, 7);
            this.BtnMinimized.Image = global::SalesManagementSystem.Properties.Resources.Minimiz;
            this.BtnMinimized.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnMinimized.ImageRotate = 0F;
            this.BtnMinimized.ImageSize = new System.Drawing.Size(25, 5);
            this.BtnMinimized.Location = new System.Drawing.Point(10, 0);
            this.BtnMinimized.Name = "BtnMinimized";
            this.BtnMinimized.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnMinimized.Size = new System.Drawing.Size(27, 33);
            this.BtnMinimized.TabIndex = 8;
            this.min.SetToolTip(this.BtnMinimized, "تصغير");
            this.BtnMinimized.UseTransparentBackground = true;
            this.BtnMinimized.Click += new System.EventHandler(this.BtnMinimized_Click);
            // 
            // PHeader
            // 
            this.PHeader.BorderRadius = 1;
            this.PHeader.BorderThickness = 1;
            this.PHeader.Controls.Add(this.PHeadController);
            this.PHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PHeader.Location = new System.Drawing.Point(0, 0);
            this.PHeader.Name = "PHeader";
            this.PHeader.Size = new System.Drawing.Size(630, 33);
            this.PHeader.TabIndex = 6;
            // 
            // PHeadController
            // 
            this.PHeadController.Controls.Add(this.BtnLogOut);
            this.PHeadController.Controls.Add(this.BtnMinimized);
            this.PHeadController.Controls.Add(this.BtnExit);
            this.PHeadController.Dock = System.Windows.Forms.DockStyle.Right;
            this.PHeadController.Location = new System.Drawing.Point(472, 0);
            this.PHeadController.Name = "PHeadController";
            this.PHeadController.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.PHeadController.Size = new System.Drawing.Size(158, 33);
            this.PHeadController.TabIndex = 7;
            // 
            // LabWelcome
            // 
            this.LabWelcome.AutoSize = true;
            this.LabWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWelcome.Location = new System.Drawing.Point(98, 2);
            this.LabWelcome.Name = "LabWelcome";
            this.LabWelcome.Size = new System.Drawing.Size(207, 46);
            this.LabWelcome.TabIndex = 18;
            this.LabWelcome.Text = "Welcome ";
            this.LabWelcome.Visible = false;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogOut.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnLogOut.HoverState.ImageSize = new System.Drawing.Size(33, 30);
            this.BtnLogOut.Image = global::SalesManagementSystem.Properties.Resources.Logout;
            this.BtnLogOut.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnLogOut.ImageRotate = 0F;
            this.BtnLogOut.ImageSize = new System.Drawing.Size(30, 27);
            this.BtnLogOut.Location = new System.Drawing.Point(63, 0);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.PressedState.ImageSize = new System.Drawing.Size(33, 30);
            this.BtnLogOut.Size = new System.Drawing.Size(32, 33);
            this.BtnLogOut.TabIndex = 9;
            this.min.SetToolTip(this.BtnLogOut, "تسجيل خروج");
            this.BtnLogOut.UseTransparentBackground = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // FDMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 375);
            this.Controls.Add(this.LabWelcome);
            this.Controls.Add(this.PHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FDMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDMain";
            this.PHeader.ResumeLayout(false);
            this.PHeadController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip min;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PHeader;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PHeadController;
        private Guna.UI2.WinForms.Guna2ImageButton BtnMinimized;
        public System.Windows.Forms.Label LabWelcome;
        protected Guna.UI2.WinForms.Guna2ImageButton BtnExit;
        protected Guna.UI2.WinForms.Guna2ImageButton BtnLogOut;
    }
}