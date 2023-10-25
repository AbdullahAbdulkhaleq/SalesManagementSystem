namespace SalesManagementSystem.Views.UI.Designer
{
    partial class UCChild
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.DGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PnaleMainHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnRefersh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnPrint = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LabSortBy = new System.Windows.Forms.Label();
            this.LabCountRow = new System.Windows.Forms.Label();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.PnaleMainHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.PnlMain.BackColor = System.Drawing.Color.White;
            this.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMain.Controls.Add(this.DGV);
            this.PnlMain.Controls.Add(this.PnaleMainHeader);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlMain.Location = new System.Drawing.Point(325, 5);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(960, 690);
            this.PnlMain.TabIndex = 21;
            // 
            // DGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.ColumnHeadersHeight = 35;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DGV.Location = new System.Drawing.Point(0, 58);
            this.DGV.Name = "DGV";
            this.DGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(958, 630);
            this.DGV.TabIndex = 13;
            this.DGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV.ThemeStyle.HeaderStyle.Height = 35;
            this.DGV.ThemeStyle.ReadOnly = false;
            this.DGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV.ThemeStyle.RowsStyle.Height = 28;
            this.DGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            // 
            // PnaleMainHeader
            // 
            this.PnaleMainHeader.Controls.Add(this.BtnRefersh);
            this.PnaleMainHeader.Controls.Add(this.BtnPrint);
            this.PnaleMainHeader.Controls.Add(this.guna2ComboBox1);
            this.PnaleMainHeader.Controls.Add(this.LabSortBy);
            this.PnaleMainHeader.Controls.Add(this.LabCountRow);
            this.PnaleMainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnaleMainHeader.Location = new System.Drawing.Point(0, 0);
            this.PnaleMainHeader.Name = "PnaleMainHeader";
            this.PnaleMainHeader.Size = new System.Drawing.Size(958, 58);
            this.PnaleMainHeader.TabIndex = 0;
            // 
            // BtnRefersh
            // 
            this.BtnRefersh.BackColor = System.Drawing.Color.Transparent;
            this.BtnRefersh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnRefersh.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnRefersh.Image = global::SalesManagementSystem.Properties.Resources.update;
            this.BtnRefersh.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnRefersh.ImageRotate = 0F;
            this.BtnRefersh.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnRefersh.Location = new System.Drawing.Point(557, -1);
            this.BtnRefersh.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRefersh.Name = "BtnRefersh";
            this.BtnRefersh.PressedState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnRefersh.Size = new System.Drawing.Size(62, 59);
            this.BtnRefersh.TabIndex = 45;
            this.BtnRefersh.UseTransparentBackground = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrint.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnPrint.HoverState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnPrint.Image = global::SalesManagementSystem.Properties.Resources.print;
            this.BtnPrint.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnPrint.ImageRotate = 0F;
            this.BtnPrint.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnPrint.Location = new System.Drawing.Point(871, -6);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.PressedState.ImageSize = new System.Drawing.Size(33, 33);
            this.BtnPrint.Size = new System.Drawing.Size(70, 70);
            this.BtnPrint.TabIndex = 43;
            this.BtnPrint.UseTransparentBackground = true;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(315, 7);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(201, 36);
            this.guna2ComboBox1.TabIndex = 2;
            // 
            // LabSortBy
            // 
            this.LabSortBy.AutoSize = true;
            this.LabSortBy.Location = new System.Drawing.Point(186, 13);
            this.LabSortBy.Name = "LabSortBy";
            this.LabSortBy.Size = new System.Drawing.Size(123, 33);
            this.LabSortBy.TabIndex = 1;
            this.LabSortBy.Text = "Sort by:";
            // 
            // LabCountRow
            // 
            this.LabCountRow.AutoSize = true;
            this.LabCountRow.Location = new System.Drawing.Point(30, 10);
            this.LabCountRow.Name = "LabCountRow";
            this.LabCountRow.Size = new System.Drawing.Size(32, 33);
            this.LabCountRow.TabIndex = 0;
            this.LabCountRow.Text = "1";
            // 
            // UCChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlMain);
            this.Name = "UCChild";
            this.PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.PnaleMainHeader.ResumeLayout(false);
            this.PnaleMainHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PnlMain;
        public Guna.UI2.WinForms.Guna2DataGridView DGV;
        public System.Windows.Forms.DataGridViewButtonColumn Delete;
        public Guna.UI2.WinForms.Guna2Panel PnaleMainHeader;
        public Guna.UI2.WinForms.Guna2ImageButton BtnRefersh;
        public Guna.UI2.WinForms.Guna2ImageButton BtnPrint;
        public Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        public System.Windows.Forms.Label LabSortBy;
        public System.Windows.Forms.Label LabCountRow;
    }
}
