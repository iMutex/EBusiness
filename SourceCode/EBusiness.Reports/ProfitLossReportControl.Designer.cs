namespace EBusiness.Reports
{
    partial class ProfitLossReportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitLossReportControl));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblProfitLoss = new System.Windows.Forms.Label();
            this.lblProfitLossAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.Location = new System.Drawing.Point(387, 21);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Size = new System.Drawing.Size(93, 13);
            this.lblSelect.Text = "Report Level:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(785, 6);
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
            this.panelBottom.Controls.Add(this.lblProfitLossAmount);
            this.panelBottom.Controls.Add(this.lblProfitLoss);
            this.panelBottom.Location = new System.Drawing.Point(0, 431);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Size = new System.Drawing.Size(897, 33);
            // 
            // cbSelect
            // 
            this.cbSelect.Location = new System.Drawing.Point(486, 18);
            this.cbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cbSelect.Size = new System.Drawing.Size(148, 21);
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            this.cbSelect.Leave += new System.EventHandler(this.cbSelect_Leave_1);
            // 
            // panelCriteria
            // 
            this.panelCriteria.BackColor = System.Drawing.SystemColors.Control;
            this.panelCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.panelCriteria.Size = new System.Drawing.Size(897, 59);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(271, 18);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(196, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(85, 18);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(2, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // lblReportHeader
            // 
            this.lblReportHeader.Dock = System.Windows.Forms.DockStyle.None;
            this.lblReportHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportHeader.Text = "Business Profit Loss Report";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(-1068, 1);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Size = new System.Drawing.Size(108, 48);
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
            this.dgvData.Size = new System.Drawing.Size(897, 431);
            this.dgvData.TabIndex = 4;
            // 
            // lblProfitLoss
            // 
            this.lblProfitLoss.AutoSize = true;
            this.lblProfitLoss.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.lblProfitLoss.ForeColor = System.Drawing.Color.Blue;
            this.lblProfitLoss.Location = new System.Drawing.Point(566, 11);
            this.lblProfitLoss.Name = "lblProfitLoss";
            this.lblProfitLoss.Size = new System.Drawing.Size(88, 13);
            this.lblProfitLoss.TabIndex = 16;
            this.lblProfitLoss.Text = "Total Profit :";
            this.lblProfitLoss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProfitLoss.Visible = false;
            // 
            // lblProfitLossAmount
            // 
            this.lblProfitLossAmount.AutoSize = true;
            this.lblProfitLossAmount.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.lblProfitLossAmount.ForeColor = System.Drawing.Color.Blue;
            this.lblProfitLossAmount.Location = new System.Drawing.Point(651, 11);
            this.lblProfitLossAmount.Name = "lblProfitLossAmount";
            this.lblProfitLossAmount.Size = new System.Drawing.Size(35, 13);
            this.lblProfitLossAmount.TabIndex = 17;
            this.lblProfitLossAmount.Text = "0.00";
            this.lblProfitLossAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProfitLossAmount.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1452, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 60);
            this.button1.TabIndex = 83;
            this.button1.Text = "Print";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProfitLossReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(675, 471);
            this.Name = "ProfitLossReportControl";
            this.Size = new System.Drawing.Size(897, 575);
            this.Load += new System.EventHandler(this.BusinessProdfitLossReportControl_Load);
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
        protected System.Windows.Forms.Label lblProfitLoss;
        protected System.Windows.Forms.Label lblProfitLossAmount;
        public System.Windows.Forms.Button button1;
    }
}
