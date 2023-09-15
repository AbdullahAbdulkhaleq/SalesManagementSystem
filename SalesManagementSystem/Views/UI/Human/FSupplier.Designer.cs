namespace SalesManagementSystem.Views.UI.Human
{
    partial class FSupplier
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
            this.TSupplierId = new System.Windows.Forms.TextBox();
            this.TSupplierName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TSupplierId
            // 
            this.TSupplierId.Location = new System.Drawing.Point(256, 97);
            this.TSupplierId.Name = "TSupplierId";
            this.TSupplierId.Size = new System.Drawing.Size(166, 29);
            this.TSupplierId.TabIndex = 3;
            // 
            // TSupplierName
            // 
            this.TSupplierName.Location = new System.Drawing.Point(256, 192);
            this.TSupplierName.Name = "TSupplierName";
            this.TSupplierName.Size = new System.Drawing.Size(166, 29);
            this.TSupplierName.TabIndex = 4;
            // 
            // FSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TSupplierName);
            this.Controls.Add(this.TSupplierId);
            this.Name = "FSupplier";
            this.Text = "FSupplier";
            this.Controls.SetChildIndex(this.TSupplierId, 0);
            this.Controls.SetChildIndex(this.TSupplierName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TSupplierId;
        private System.Windows.Forms.TextBox TSupplierName;
    }
}