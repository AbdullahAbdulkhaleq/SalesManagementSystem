namespace SalesManagementSystem.Views.UI.Designer
{
    partial class UCInvoice
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
            this.PanHeaderInvoice = new Guna.UI2.WinForms.Guna2Panel();
            this.LabTranType = new System.Windows.Forms.Label();
            this.LabUserName = new System.Windows.Forms.Label();
            this.CMBStore = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.InvoiceDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LavoiceNumber = new System.Windows.Forms.Label();
            this.PanMainInvoice = new Guna.UI2.WinForms.Guna2Panel();
            this.PanFooterInvoice = new Guna.UI2.WinForms.Guna2Panel();
            this.PanFooterInvoiceFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnInsert = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnPrint = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PanHeaderInvoice.SuspendLayout();
            this.PanMainInvoice.SuspendLayout();
            this.PanFooterInvoice.SuspendLayout();
            this.PanFooterInvoiceFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanHeaderInvoice
            // 
            this.PanHeaderInvoice.BorderColor = System.Drawing.Color.Black;
            this.PanHeaderInvoice.BorderThickness = 1;
            this.PanHeaderInvoice.Controls.Add(this.LabTranType);
            this.PanHeaderInvoice.Controls.Add(this.LabUserName);
            this.PanHeaderInvoice.Controls.Add(this.CMBStore);
            this.PanHeaderInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanHeaderInvoice.Location = new System.Drawing.Point(5, 5);
            this.PanHeaderInvoice.Name = "PanHeaderInvoice";
            this.PanHeaderInvoice.Size = new System.Drawing.Size(1280, 88);
            this.PanHeaderInvoice.TabIndex = 1;
            // 
            // LabTranType
            // 
            this.LabTranType.AutoSize = true;
            this.LabTranType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTranType.Location = new System.Drawing.Point(591, 28);
            this.LabTranType.Name = "LabTranType";
            this.LabTranType.Size = new System.Drawing.Size(98, 32);
            this.LabTranType.TabIndex = 4;
            this.LabTranType.Text = "label1";
            // 
            // LabUserName
            // 
            this.LabUserName.AutoSize = true;
            this.LabUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUserName.Location = new System.Drawing.Point(41, 21);
            this.LabUserName.Name = "LabUserName";
            this.LabUserName.Size = new System.Drawing.Size(98, 32);
            this.LabUserName.TabIndex = 3;
            this.LabUserName.Text = "label1";
            // 
            // CMBStore
            // 
            this.CMBStore.BackColor = System.Drawing.Color.Transparent;
            this.CMBStore.BorderRadius = 20;
            this.CMBStore.BorderThickness = 0;
            this.CMBStore.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CMBStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBStore.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CMBStore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CMBStore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CMBStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CMBStore.ItemHeight = 30;
            this.CMBStore.Location = new System.Drawing.Point(913, 28);
            this.CMBStore.Name = "CMBStore";
            this.CMBStore.Size = new System.Drawing.Size(232, 36);
            this.CMBStore.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(5, 192);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1280, 503);
            this.guna2Panel1.TabIndex = 4;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.AutoRoundedCorners = true;
            this.InvoiceDate.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceDate.BorderRadius = 17;
            this.InvoiceDate.Checked = true;
            this.InvoiceDate.FillColor = System.Drawing.Color.White;
            this.InvoiceDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.InvoiceDate.IndicateFocus = true;
            this.InvoiceDate.Location = new System.Drawing.Point(503, 34);
            this.InvoiceDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.InvoiceDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(266, 36);
            this.InvoiceDate.TabIndex = 0;
            this.InvoiceDate.UseTransparentBackground = true;
            this.InvoiceDate.Value = new System.DateTime(2023, 10, 16, 15, 35, 18, 742);
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 20;
            this.guna2ComboBox2.BorderThickness = 0;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Location = new System.Drawing.Point(13, 34);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(254, 36);
            this.guna2ComboBox2.TabIndex = 3;
            // 
            // LavoiceNumber
            // 
            this.LavoiceNumber.AutoSize = true;
            this.LavoiceNumber.Location = new System.Drawing.Point(1065, 37);
            this.LavoiceNumber.Name = "LavoiceNumber";
            this.LavoiceNumber.Size = new System.Drawing.Size(99, 33);
            this.LavoiceNumber.TabIndex = 4;
            this.LavoiceNumber.Text = "label1";
            // 
            // PanMainInvoice
            // 
            this.PanMainInvoice.BackColor = System.Drawing.Color.White;
            this.PanMainInvoice.BorderColor = System.Drawing.Color.Black;
            this.PanMainInvoice.BorderThickness = 1;
            this.PanMainInvoice.Controls.Add(this.LavoiceNumber);
            this.PanMainInvoice.Controls.Add(this.guna2ComboBox2);
            this.PanMainInvoice.Controls.Add(this.InvoiceDate);
            this.PanMainInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanMainInvoice.Location = new System.Drawing.Point(5, 93);
            this.PanMainInvoice.Name = "PanMainInvoice";
            this.PanMainInvoice.Size = new System.Drawing.Size(1280, 99);
            this.PanMainInvoice.TabIndex = 2;
            // 
            // PanFooterInvoice
            // 
            this.PanFooterInvoice.BackColor = System.Drawing.Color.White;
            this.PanFooterInvoice.BorderColor = System.Drawing.Color.Black;
            this.PanFooterInvoice.BorderThickness = 1;
            this.PanFooterInvoice.Controls.Add(this.PanFooterInvoiceFooter);
            this.PanFooterInvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanFooterInvoice.Location = new System.Drawing.Point(5, 188);
            this.PanFooterInvoice.Name = "PanFooterInvoice";
            this.PanFooterInvoice.Size = new System.Drawing.Size(1280, 507);
            this.PanFooterInvoice.TabIndex = 6;
            // 
            // PanFooterInvoiceFooter
            // 
            this.PanFooterInvoiceFooter.BackColor = System.Drawing.Color.White;
            this.PanFooterInvoiceFooter.BorderColor = System.Drawing.Color.Black;
            this.PanFooterInvoiceFooter.BorderThickness = 1;
            this.PanFooterInvoiceFooter.Controls.Add(this.BtnInsert);
            this.PanFooterInvoiceFooter.Controls.Add(this.BtnPrint);
            this.PanFooterInvoiceFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanFooterInvoiceFooter.Location = new System.Drawing.Point(0, 449);
            this.PanFooterInvoiceFooter.Name = "PanFooterInvoiceFooter";
            this.PanFooterInvoiceFooter.Size = new System.Drawing.Size(1280, 58);
            this.PanFooterInvoiceFooter.TabIndex = 3;
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.Color.Transparent;
            this.BtnInsert.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnInsert.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnInsert.Image = global::SalesManagementSystem.Properties.Resources.Add;
            this.BtnInsert.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnInsert.ImageRotate = 0F;
            this.BtnInsert.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnInsert.Location = new System.Drawing.Point(25, -6);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnInsert.Size = new System.Drawing.Size(70, 70);
            this.BtnInsert.TabIndex = 43;
            this.BtnInsert.UseTransparentBackground = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrint.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnPrint.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnPrint.Image = global::SalesManagementSystem.Properties.Resources.print;
            this.BtnPrint.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnPrint.ImageRotate = 0F;
            this.BtnPrint.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnPrint.Location = new System.Drawing.Point(605, -6);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.BtnPrint.Size = new System.Drawing.Size(70, 70);
            this.BtnPrint.TabIndex = 42;
            this.BtnPrint.UseTransparentBackground = true;
            // 
            // UCInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanFooterInvoice);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.PanMainInvoice);
            this.Controls.Add(this.PanHeaderInvoice);
            this.Name = "UCInvoice";
            this.PanHeaderInvoice.ResumeLayout(false);
            this.PanHeaderInvoice.PerformLayout();
            this.PanMainInvoice.ResumeLayout(false);
            this.PanMainInvoice.PerformLayout();
            this.PanFooterInvoice.ResumeLayout(false);
            this.PanFooterInvoiceFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Panel PanHeaderInvoice;
        public Guna.UI2.WinForms.Guna2ComboBox CMBStore;
        public System.Windows.Forms.Label LabTranType;
        public System.Windows.Forms.Label LabUserName;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2DateTimePicker InvoiceDate;
        public Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        public System.Windows.Forms.Label LavoiceNumber;
        public Guna.UI2.WinForms.Guna2Panel PanMainInvoice;
        public Guna.UI2.WinForms.Guna2Panel PanFooterInvoice;
        public Guna.UI2.WinForms.Guna2Panel PanFooterInvoiceFooter;
        public Guna.UI2.WinForms.Guna2ImageButton BtnInsert;
        public Guna.UI2.WinForms.Guna2ImageButton BtnPrint;
    }
}
