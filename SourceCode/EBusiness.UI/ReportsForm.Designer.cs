namespace EBusiness
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.panelReportControl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelReportControl
            // 
            this.panelReportControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelReportControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportControl.Location = new System.Drawing.Point(0, 0);
            this.panelReportControl.Name = "panelReportControl";
            this.panelReportControl.Size = new System.Drawing.Size(984, 662);
            this.panelReportControl.TabIndex = 0;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.panelReportControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Form";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelReportControl;



    }
}