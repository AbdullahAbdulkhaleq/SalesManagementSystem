namespace SalesManagementSystem.Views.UI.Inventory
{
    partial class UCCategory
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
            this.BtnInsert = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LabName = new System.Windows.Forms.Label();
            this.TexCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRefersh
            // 
            this.BtnRefersh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnRefersh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnRefersh.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnRefersh.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnRefersh.PressedState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnRefersh.Click += new System.EventHandler(this.BtnRefersh_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPrint.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnPrint.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnPrint.PressedState.ImageSize = new System.Drawing.Size(33, 33);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnInsert);
            this.panel1.Controls.Add(this.LabName);
            this.panel1.Controls.Add(this.TexCategoryName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 690);
            this.panel1.TabIndex = 32;
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsert.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnInsert.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnInsert.Image = global::SalesManagementSystem.Properties.Resources.Add;
            this.BtnInsert.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnInsert.ImageRotate = 0F;
            this.BtnInsert.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnInsert.Location = new System.Drawing.Point(125, 417);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.BtnInsert.Size = new System.Drawing.Size(70, 70);
            this.BtnInsert.TabIndex = 42;
            this.BtnInsert.UseTransparentBackground = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LabName.Location = new System.Drawing.Point(24, 307);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(56, 21);
            this.LabName.TabIndex = 39;
            this.LabName.Text = "Name";
            // 
            // TexCategoryName
            // 
            this.TexCategoryName.BorderRadius = 10;
            this.TexCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TexCategoryName.DefaultText = "";
            this.TexCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TexCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TexCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TexCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TexCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TexCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TexCategoryName.Location = new System.Drawing.Point(17, 332);
            this.TexCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.TexCategoryName.Name = "TexCategoryName";
            this.TexCategoryName.PasswordChar = '\0';
            this.TexCategoryName.PlaceholderText = "Category Name";
            this.TexCategoryName.SelectedText = "";
            this.TexCategoryName.Size = new System.Drawing.Size(284, 50);
            this.TexCategoryName.TabIndex = 28;
            this.TexCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Manage Products";
            // 
            // UCCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "UCCategory";
            this.Controls.SetChildIndex(this.PnlMain, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TexCategoryName;
        private Guna.UI2.WinForms.Guna2ImageButton BtnInsert;
    }
}
