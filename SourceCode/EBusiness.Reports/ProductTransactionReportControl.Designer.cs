namespace EBusiness.Reports
{
    partial class ProductTransactionReportControl
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panelCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.Location = new System.Drawing.Point(577, 11);
            // 
            // btnFind
            // 
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvData);
            this.panel3.Controls.SetChildIndex(this.panelBottom, 0);
            this.panel3.Controls.SetChildIndex(this.dgvData, 0);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 453);
            this.panelBottom.Size = new System.Drawing.Size(900, 10);
            // 
            // cbSelect
            // 
            this.cbSelect.Location = new System.Drawing.Point(580, 27);
            this.cbSelect.Size = new System.Drawing.Size(191, 21);
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // panelCriteria
            // 
            this.panelCriteria.Controls.Add(this.label2);
            this.panelCriteria.Controls.Add(this.cbReport);
            this.panelCriteria.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.panelCriteria.Controls.SetChildIndex(this.label7, 0);
            this.panelCriteria.Controls.SetChildIndex(this.label1, 0);
            this.panelCriteria.Controls.SetChildIndex(this.lblSelect, 0);
            this.panelCriteria.Controls.SetChildIndex(this.dtpEndDate, 0);
            this.panelCriteria.Controls.SetChildIndex(this.cbSelect, 0);
            this.panelCriteria.Controls.SetChildIndex(this.btnFind, 0);
            this.panelCriteria.Controls.SetChildIndex(this.cbReport, 0);
            this.panelCriteria.Controls.SetChildIndex(this.label2, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(429, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(426, 10);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(298, 27);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(295, 11);
            // 
            // lblReportHeader
            // 
            this.lblReportHeader.Text = "Product Transaction Report";
            // 
            // btnPrint
            // 
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(900, 453);
            this.dgvData.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Report:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbReport
            // 
            this.cbReport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbReport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReport.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Items.AddRange(new object[] {
            "Product Transaction Detailed",
            "Product Transaction Summary"});
            this.cbReport.Location = new System.Drawing.Point(10, 26);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(250, 21);
            this.cbReport.TabIndex = 21;
            this.cbReport.SelectedIndexChanged += new System.EventHandler(this.cbReport_SelectedIndexChanged);
            // 
            // ProductTransactionReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProductTransactionReportControl";
            this.Load += new System.EventHandler(this.ProductTransactionReportControl_Load);
            this.panel3.ResumeLayout(false);
            this.panelCriteria.ResumeLayout(false);
            this.panelCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvData;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbReport;
    }
}
