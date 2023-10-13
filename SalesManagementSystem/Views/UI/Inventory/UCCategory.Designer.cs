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
            this.TexCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabmanageCategory = new System.Windows.Forms.Label();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
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
            this.TexCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TexCategoryName.Location = new System.Drawing.Point(22, 130);
            this.TexCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.TexCategoryName.Name = "TexCategoryName";
            this.TexCategoryName.PasswordChar = '\0';
            this.TexCategoryName.PlaceholderText = "Category Name";
            this.TexCategoryName.SelectedText = "";
            this.TexCategoryName.Size = new System.Drawing.Size(284, 50);
            this.TexCategoryName.TabIndex = 28;
            this.TexCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabmanageCategory
            // 
            this.LabmanageCategory.AutoSize = true;
            this.LabmanageCategory.Location = new System.Drawing.Point(503, 18);
            this.LabmanageCategory.Name = "LabmanageCategory";
            this.LabmanageCategory.Size = new System.Drawing.Size(260, 33);
            this.LabmanageCategory.TabIndex = 27;
            this.LabmanageCategory.Text = "Manage Category";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = global::SalesManagementSystem.Properties.Resources.Add_Customer;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(124, 239);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(65, 66);
            this.guna2ImageButton2.TabIndex = 29;
            this.guna2ImageButton2.UseTransparentBackground = true;
            // 
            // UCCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.TexCategoryName);
            this.Controls.Add(this.LabmanageCategory);
            this.Name = "UCCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2TextBox TexCategoryName;
        private System.Windows.Forms.Label LabmanageCategory;
    }
}
