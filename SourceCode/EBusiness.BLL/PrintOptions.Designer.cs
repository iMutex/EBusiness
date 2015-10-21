namespace EBusiness.BLL
{
    partial class PrintOptions
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
            this.rdoAllRows = new System.Windows.Forms.RadioButton();
            this.chkFitToPageWidth = new System.Windows.Forms.CheckBox();
            this.chklst = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // rdoAllRows
            // 
            this.rdoAllRows.AutoSize = true;
            this.rdoAllRows.Location = new System.Drawing.Point(121, 45);
            this.rdoAllRows.Name = "rdoAllRows";
            this.rdoAllRows.Size = new System.Drawing.Size(85, 17);
            this.rdoAllRows.TabIndex = 0;
            this.rdoAllRows.TabStop = true;
            this.rdoAllRows.Text = "radioButton1";
            this.rdoAllRows.UseVisualStyleBackColor = true;
            // 
            // chkFitToPageWidth
            // 
            this.chkFitToPageWidth.AutoSize = true;
            this.chkFitToPageWidth.Location = new System.Drawing.Point(94, 100);
            this.chkFitToPageWidth.Name = "chkFitToPageWidth";
            this.chkFitToPageWidth.Size = new System.Drawing.Size(80, 17);
            this.chkFitToPageWidth.TabIndex = 1;
            this.chkFitToPageWidth.Text = "checkBox1";
            this.chkFitToPageWidth.UseVisualStyleBackColor = true;
            // 
            // chklst
            // 
            this.chklst.CheckOnClick = true;
            this.chklst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklst.FormattingEnabled = true;
            this.chklst.Location = new System.Drawing.Point(-5, -3);
            this.chklst.Name = "chklst";
            this.chklst.Size = new System.Drawing.Size(170, 244);
            this.chklst.TabIndex = 14;
            // 
            // PrintOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chklst);
            this.Controls.Add(this.chkFitToPageWidth);
            this.Controls.Add(this.rdoAllRows);
            this.Name = "PrintOptions";
            this.Text = "PrintOptions";
            this.Load += new System.EventHandler(this.PrintOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoAllRows;
        private System.Windows.Forms.CheckBox chkFitToPageWidth;
        internal System.Windows.Forms.CheckedListBox chklst;
    }
}