namespace SalesManagementSystem.Views.UI.Access
{
    partial class FError
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
            this.LabMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabWelcome
            // 
            this.LabWelcome.AutoEllipsis = true;
            this.LabWelcome.AutoSize = false;
            this.LabWelcome.Location = new System.Drawing.Point(12, 146);
            this.LabWelcome.Size = new System.Drawing.Size(874, 46);
            this.LabWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnExit
            // 
            this.BtnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnExit.HoverState.ImageSize = new System.Drawing.Size(39, 33);
            this.BtnExit.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnLogOut.HoverState.ImageSize = new System.Drawing.Size(33, 30);
            this.BtnLogOut.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnLogOut.PressedState.ImageSize = new System.Drawing.Size(33, 30);
            // 
            // LabMessage
            // 
            this.LabMessage.AutoEllipsis = true;
            this.LabMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMessage.ForeColor = System.Drawing.Color.Red;
            this.LabMessage.Location = new System.Drawing.Point(12, 273);
            this.LabMessage.Name = "LabMessage";
            this.LabMessage.Size = new System.Drawing.Size(874, 37);
            this.LabMessage.TabIndex = 19;
            this.LabMessage.Text = "عذرا هذه المستخدم محظور يرجا مراجعة الادمن";
            this.LabMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 523);
            this.Controls.Add(this.LabMessage);
            this.Name = "FError";
            this.Text = "FLoginBlock";
            this.Controls.SetChildIndex(this.LabWelcome, 0);
            this.Controls.SetChildIndex(this.LabMessage, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabMessage;
    }
}