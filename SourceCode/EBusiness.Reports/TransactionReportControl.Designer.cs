namespace EBusiness.Reports
{
    partial class TransactionReportControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblDebit = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.Location = new System.Drawing.Point(451, 24);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(787, 4);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvData);
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(897, 464);
            this.panel3.Controls.SetChildIndex(this.panelBottom, 0);
            this.panel3.Controls.SetChildIndex(this.dgvData, 0);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblDebit);
            this.panelBottom.Controls.Add(this.lblCredit);
            this.panelBottom.Controls.Add(this.lblFinalBalance);
            this.panelBottom.Controls.Add(this.label27);
            this.panelBottom.Controls.Add(this.label24);
            this.panelBottom.Controls.Add(this.label18);
            this.panelBottom.Location = new System.Drawing.Point(0, 421);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Size = new System.Drawing.Size(897, 43);
            // 
            // cbSelect
            // 
            this.cbSelect.Location = new System.Drawing.Point(569, 18);
            this.cbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cbSelect.Sorted = true;
            this.cbSelect.Leave += new System.EventHandler(this.cbSelect_Leave);
            // 
            // panelCriteria
            // 
            this.panelCriteria.BackColor = System.Drawing.SystemColors.Control;
            this.panelCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.panelCriteria.Size = new System.Drawing.Size(897, 59);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(266, 18);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(195, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(83, 18);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // lblReportHeader
            // 
            this.lblReportHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportHeader.Size = new System.Drawing.Size(897, 52);
            this.lblReportHeader.Text = "Transaction Report";
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
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(897, 421);
            this.dgvData.TabIndex = 4;
            // 
            // lblDebit
            // 
            this.lblDebit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblDebit.ForeColor = System.Drawing.Color.Black;
            this.lblDebit.Location = new System.Drawing.Point(197, 15);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(131, 17);
            this.lblDebit.TabIndex = 16;
            this.lblDebit.Text = "0.00";
            this.lblDebit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCredit
            // 
            this.lblCredit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblCredit.ForeColor = System.Drawing.Color.Black;
            this.lblCredit.Location = new System.Drawing.Point(398, 15);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(131, 17);
            this.lblCredit.TabIndex = 15;
            this.lblCredit.Text = "0.00";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblFinalBalance.ForeColor = System.Drawing.Color.Black;
            this.lblFinalBalance.Location = new System.Drawing.Point(616, 14);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(131, 17);
            this.lblFinalBalance.TabIndex = 14;
            this.lblFinalBalance.Text = "0.00";
            this.lblFinalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.MediumBlue;
            this.label27.Location = new System.Drawing.Point(536, 14);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 17);
            this.label27.TabIndex = 13;
            this.label27.Text = "Balance:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.DarkGreen;
            this.label24.Location = new System.Drawing.Point(334, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 17);
            this.label24.TabIndex = 12;
            this.label24.Text = "Credit:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Crimson;
            this.label18.Location = new System.Drawing.Point(137, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 17);
            this.label18.TabIndex = 11;
            this.label18.Text = "Debit:";
            // 
            // TransactionReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(675, 471);
            this.Name = "TransactionReportControl";
            this.Size = new System.Drawing.Size(897, 575);
            this.panel3.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelCriteria.ResumeLayout(false);
            this.panelCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblFinalBalance;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
    }
}
