namespace SalesManagementSystem.Views.UI.Human
{
    partial class UCCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.TCustomerType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TCustomerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.TCustomerEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TCustomerPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtbMenuProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtbMenuProduct);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TCustomerType);
            this.panel1.Controls.Add(this.TCustomerName);
            this.panel1.Controls.Add(this.TCustomerId);
            this.panel1.Controls.Add(this.TCustomerEmail);
            this.panel1.Controls.Add(this.TCustomerPhone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 702);
            this.panel1.TabIndex = 3;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Products";
            // 
            // TCustomerType
            // 
            this.TCustomerType.BackColor = System.Drawing.Color.Transparent;
            this.TCustomerType.BorderRadius = 10;
            this.TCustomerType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TCustomerType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TCustomerType.ItemHeight = 30;
            this.TCustomerType.Location = new System.Drawing.Point(22, 386);
            this.TCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.TCustomerType.Name = "TCustomerType";
            this.TCustomerType.Size = new System.Drawing.Size(282, 36);
            this.TCustomerType.TabIndex = 22;
            this.TCustomerType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TCustomerName
            // 
            this.TCustomerName.BorderRadius = 10;
            this.TCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCustomerName.DefaultText = "";
            this.TCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerName.Location = new System.Drawing.Point(22, 213);
            this.TCustomerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TCustomerName.Name = "TCustomerName";
            this.TCustomerName.PasswordChar = '\0';
            this.TCustomerName.PlaceholderText = "Customer Name";
            this.TCustomerName.SelectedText = "";
            this.TCustomerName.Size = new System.Drawing.Size(284, 50);
            this.TCustomerName.TabIndex = 21;
            this.TCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TCustomerId
            // 
            this.TCustomerId.BorderRadius = 10;
            this.TCustomerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCustomerId.DefaultText = "";
            this.TCustomerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TCustomerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TCustomerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCustomerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCustomerId.Enabled = false;
            this.TCustomerId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TCustomerId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerId.Location = new System.Drawing.Point(22, 154);
            this.TCustomerId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TCustomerId.Name = "TCustomerId";
            this.TCustomerId.PasswordChar = '\0';
            this.TCustomerId.PlaceholderText = "Customer Id";
            this.TCustomerId.SelectedText = "";
            this.TCustomerId.Size = new System.Drawing.Size(284, 50);
            this.TCustomerId.TabIndex = 19;
            this.TCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TCustomerEmail
            // 
            this.TCustomerEmail.BorderRadius = 10;
            this.TCustomerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCustomerEmail.DefaultText = "";
            this.TCustomerEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TCustomerEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TCustomerEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCustomerEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCustomerEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TCustomerEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerEmail.Location = new System.Drawing.Point(22, 329);
            this.TCustomerEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TCustomerEmail.Name = "TCustomerEmail";
            this.TCustomerEmail.PasswordChar = '\0';
            this.TCustomerEmail.PlaceholderText = "Customer Email";
            this.TCustomerEmail.SelectedText = "";
            this.TCustomerEmail.Size = new System.Drawing.Size(284, 50);
            this.TCustomerEmail.TabIndex = 17;
            this.TCustomerEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TCustomerPhone
            // 
            this.TCustomerPhone.BorderRadius = 10;
            this.TCustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TCustomerPhone.DefaultText = "";
            this.TCustomerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TCustomerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TCustomerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCustomerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TCustomerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TCustomerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TCustomerPhone.Location = new System.Drawing.Point(22, 271);
            this.TCustomerPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TCustomerPhone.Name = "TCustomerPhone";
            this.TCustomerPhone.PasswordChar = '\0';
            this.TCustomerPhone.PlaceholderText = "Customer Phone";
            this.TCustomerPhone.SelectedText = "";
            this.TCustomerPhone.Size = new System.Drawing.Size(284, 50);
            this.TCustomerPhone.TabIndex = 18;
            this.TCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtbMenuProduct
            // 
            this.BtbMenuProduct.BackColor = System.Drawing.Color.Transparent;
            this.BtbMenuProduct.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtbMenuProduct.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.BtbMenuProduct.Image = global::SalesManagementSystem.Properties.Resources.products_icon;
            this.BtbMenuProduct.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtbMenuProduct.ImageRotate = 0F;
            this.BtbMenuProduct.ImageSize = new System.Drawing.Size(50, 50);
            this.BtbMenuProduct.Location = new System.Drawing.Point(117, 429);
            this.BtbMenuProduct.Name = "BtbMenuProduct";
            this.BtbMenuProduct.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.BtbMenuProduct.Size = new System.Drawing.Size(75, 75);
            this.BtbMenuProduct.TabIndex = 23;
            this.BtbMenuProduct.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(117, 50);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(82, 76);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(331, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 702);
            this.panel2.TabIndex = 13;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::SalesManagementSystem.Properties.Resources.update;
            this.guna2Button1.Location = new System.Drawing.Point(814, 12);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(140, 33);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Research";
            // 
            // UCCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UCCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TCustomerEmail;
        private Guna.UI2.WinForms.Guna2TextBox TCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox TCustomerId;
        private Guna.UI2.WinForms.Guna2TextBox TCustomerPhone;
        private Guna.UI2.WinForms.Guna2ComboBox TCustomerType;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton BtbMenuProduct;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
