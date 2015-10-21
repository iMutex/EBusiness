namespace EBusiness.Reports
{
    partial class ReportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportControl));
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.panelCriteria = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkAllDates = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblReportHeader = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panelCriteria.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.lblSelect.ForeColor = System.Drawing.Color.Blue;
            this.lblSelect.Location = new System.Drawing.Point(565, 27);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(51, 13);
            this.lblSelect.TabIndex = 18;
            this.lblSelect.Text = "Select:";
            this.lblSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(789, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(108, 49);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "Go";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panelBottom);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 463);
            this.panel3.TabIndex = 88;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 418);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(900, 45);
            this.panelBottom.TabIndex = 0;
            // 
            // cbSelect
            // 
            this.cbSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelect.Font = new System.Drawing.Font("Verdana", 8F);
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(622, 24);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(160, 21);
            this.cbSelect.TabIndex = 16;
            // 
            // panelCriteria
            // 
            this.panelCriteria.BackColor = System.Drawing.Color.White;
            this.panelCriteria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCriteria.Controls.Add(this.lblSelect);
            this.panelCriteria.Controls.Add(this.btnFind);
            this.panelCriteria.Controls.Add(this.cbSelect);
            this.panelCriteria.Controls.Add(this.dtpEndDate);
            this.panelCriteria.Controls.Add(this.label1);
            this.panelCriteria.Controls.Add(this.dtpStartDate);
            this.panelCriteria.Controls.Add(this.label7);
            this.panelCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCriteria.Location = new System.Drawing.Point(0, 52);
            this.panelCriteria.Name = "panelCriteria";
            this.panelCriteria.Size = new System.Drawing.Size(900, 65);
            this.panelCriteria.TabIndex = 87;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Verdana", 8F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(430, 24);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(106, 20);
            this.dtpEndDate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(355, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "End Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Verdana", 8F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(206, 27);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(105, 20);
            this.dtpStartDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(123, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Start Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.chkAllDates);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.lblReportHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 52);
            this.panel2.TabIndex = 86;
            // 
            // chkAllDates
            // 
            this.chkAllDates.AutoSize = true;
            this.chkAllDates.BackColor = System.Drawing.Color.Transparent;
            this.chkAllDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllDates.Location = new System.Drawing.Point(58, 16);
            this.chkAllDates.Name = "chkAllDates";
            this.chkAllDates.Size = new System.Drawing.Size(101, 24);
            this.chkAllDates.TabIndex = 83;
            this.chkAllDates.Text = "All Dates";
            this.chkAllDates.UseVisualStyleBackColor = false;
            this.chkAllDates.CheckedChanged += new System.EventHandler(this.chkAllDates_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(789, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 49);
            this.btnPrint.TabIndex = 82;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblReportHeader
            // 
            this.lblReportHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblReportHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportHeader.Font = new System.Drawing.Font("Vani", 24F, System.Drawing.FontStyle.Bold);
            this.lblReportHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReportHeader.Image = ((System.Drawing.Image)(resources.GetObject("lblReportHeader.Image")));
            this.lblReportHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReportHeader.Location = new System.Drawing.Point(0, 0);
            this.lblReportHeader.Name = "lblReportHeader";
            this.lblReportHeader.Size = new System.Drawing.Size(900, 52);
            this.lblReportHeader.TabIndex = 81;
            this.lblReportHeader.Text = "Sales Report";
            this.lblReportHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelCriteria);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(900, 580);
            this.panel3.ResumeLayout(false);
            this.panelCriteria.ResumeLayout(false);
            this.panelCriteria.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblSelect;
        public System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panelBottom;
        public System.Windows.Forms.ComboBox cbSelect;
        public System.Windows.Forms.Panel panelCriteria;
        public System.Windows.Forms.DateTimePicker dtpEndDate;
        protected System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpStartDate;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblReportHeader;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.CheckBox chkAllDates;
    }
}
