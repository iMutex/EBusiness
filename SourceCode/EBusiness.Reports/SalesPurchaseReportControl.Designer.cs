namespace EBusiness.Reports
{
    partial class SalesPurchaseReportControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.Location = new System.Drawing.Point(607, 12);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Size = new System.Drawing.Size(73, 13);
            this.lblSelect.Text = "Customer:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(786, 5);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvData);
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(897, 463);
            this.panel3.Controls.SetChildIndex(this.panelBottom, 0);
            this.panel3.Controls.SetChildIndex(this.dgvData, 0);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblTotalValue);
            this.panelBottom.Controls.Add(this.lblTotal);
            this.panelBottom.Location = new System.Drawing.Point(0, 424);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Size = new System.Drawing.Size(897, 39);
            // 
            // cbSelect
            // 
            this.cbSelect.Location = new System.Drawing.Point(610, 29);
            this.cbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cbSelect.Size = new System.Drawing.Size(157, 21);
            this.cbSelect.Sorted = true;
            this.cbSelect.Leave += new System.EventHandler(this.cbSelect_Leave);
            // 
            // panelCriteria
            // 
            this.panelCriteria.BackColor = System.Drawing.SystemColors.Control;
            this.panelCriteria.Controls.Add(this.label2);
            this.panelCriteria.Controls.Add(this.cbReport);
            this.panelCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.panelCriteria.Size = new System.Drawing.Size(897, 60);
            this.panelCriteria.Controls.SetChildIndex(this.label7, 0);
            this.panelCriteria.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.panelCriteria.Controls.SetChildIndex(this.label1, 0);
            this.panelCriteria.Controls.SetChildIndex(this.dtpEndDate, 0);
            this.panelCriteria.Controls.SetChildIndex(this.cbSelect, 0);
            this.panelCriteria.Controls.SetChildIndex(this.btnFind, 0);
            this.panelCriteria.Controls.SetChildIndex(this.lblSelect, 0);
            this.panelCriteria.Controls.SetChildIndex(this.cbReport, 0);
            this.panelCriteria.Controls.SetChildIndex(this.label2, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(451, 27);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(449, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.Text = "To:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(315, 27);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(312, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.Text = "From:";
            // 
            // lblReportHeader
            // 
            this.lblReportHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportHeader.Size = new System.Drawing.Size(897, 52);
            this.lblReportHeader.Text = "Customer Sales Report";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Location = new System.Drawing.Point(789, 0);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Size = new System.Drawing.Size(108, 52);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 20;
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
            this.cbReport.Location = new System.Drawing.Point(10, 29);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(279, 21);
            this.cbReport.TabIndex = 19;
            this.cbReport.SelectedIndexChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(897, 424);
            this.dgvData.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(691, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 17);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalValue.Location = new System.Drawing.Point(764, 14);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(130, 13);
            this.lblTotalValue.TabIndex = 22;
            this.lblTotalValue.Text = "0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalValue.Visible = false;
            // 
            // SalesPurchaseReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(675, 471);
            this.Name = "SalesPurchaseReportControl";
            this.Size = new System.Drawing.Size(897, 575);
            this.Load += new System.EventHandler(this.SalesPurchaseReportControl_Load);
            this.panel3.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelCriteria.ResumeLayout(false);
            this.panelCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbReport;
        public System.Windows.Forms.DataGridView dgvData;
        public System.Windows.Forms.Label lblTotal;
        protected System.Windows.Forms.Label lblTotalValue;
        

    }
}
