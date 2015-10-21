namespace EBusiness.Reports
{
    partial class DailySalesPurchaseReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySalesPurchaseReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalPurchase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalSale = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panelCriteria.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.Location = new System.Drawing.Point(7, 7);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Size = new System.Drawing.Size(54, 13);
            this.lblSelect.Text = "Report:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(777, 6);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(899, 424);
            this.panel3.Controls.SetChildIndex(this.panel1, 0);
            this.panel3.Controls.SetChildIndex(this.panelBottom, 0);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 422);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Size = new System.Drawing.Size(899, 2);
            this.panelBottom.Visible = false;
            // 
            // cbSelect
            // 
            this.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelect.Items.AddRange(new object[] {
            "Daily Sale Purchase",
            "Daily Sale Purchase Detailed",
            "Daily Sale Purchase Summary",
            "Daily Sale Purchase Product Summary"});
            this.cbSelect.Location = new System.Drawing.Point(10, 24);
            this.cbSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cbSelect.Size = new System.Drawing.Size(298, 21);
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // panelCriteria
            // 
            this.panelCriteria.BackColor = System.Drawing.SystemColors.Control;
            this.panelCriteria.Controls.Add(this.label6);
            this.panelCriteria.Controls.Add(this.cboProduct);
            this.panelCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.panelCriteria.Size = new System.Drawing.Size(899, 59);
            this.panelCriteria.Controls.SetChildIndex(this.label1, 0);
            this.panelCriteria.Controls.SetChildIndex(this.dtpEndDate, 0);
            this.panelCriteria.Controls.SetChildIndex(this.label7, 0);
            this.panelCriteria.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.panelCriteria.Controls.SetChildIndex(this.cbSelect, 0);
            this.panelCriteria.Controls.SetChildIndex(this.lblSelect, 0);
            this.panelCriteria.Controls.SetChildIndex(this.btnFind, 0);
            this.panelCriteria.Controls.SetChildIndex(this.cboProduct, 0);
            this.panelCriteria.Controls.SetChildIndex(this.label6, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(451, 24);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.Size = new System.Drawing.Size(110, 20);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(448, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.Text = "To:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(334, 24);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Size = new System.Drawing.Size(103, 20);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(331, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.Text = "From:";
            // 
            // lblReportHeader
            // 
            this.lblReportHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportHeader.Size = new System.Drawing.Size(899, 52);
            this.lblReportHeader.Text = "Daily Sales && Purchase Report";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(770, 2);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 424);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer.Panel1.Controls.Add(this.dgvPurchase);
            this.splitContainer.Panel1.Controls.Add(this.panel6);
            this.splitContainer.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer.Panel2.Controls.Add(this.dgvSales);
            this.splitContainer.Panel2.Controls.Add(this.panel7);
            this.splitContainer.Panel2.Controls.Add(this.panel5);
            this.splitContainer.Size = new System.Drawing.Size(899, 424);
            this.splitContainer.SplitterDistance = 443;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AllowUserToAddRows = false;
            this.dgvPurchase.AllowUserToDeleteRows = false;
            this.dgvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPurchase.Location = new System.Drawing.Point(0, 38);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.ReadOnly = true;
            this.dgvPurchase.RowHeadersWidth = 5;
            this.dgvPurchase.RowTemplate.Height = 24;
            this.dgvPurchase.Size = new System.Drawing.Size(443, 355);
            this.dgvPurchase.TabIndex = 88;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(443, 38);
            this.panel6.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Vani", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 38);
            this.label2.TabIndex = 81;
            this.label2.Text = "Purchase";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.lblTotalPurchase);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 393);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 31);
            this.panel4.TabIndex = 0;
            // 
            // lblTotalPurchase
            // 
            this.lblTotalPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPurchase.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalPurchase.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalPurchase.Location = new System.Drawing.Point(257, 9);
            this.lblTotalPurchase.Name = "lblTotalPurchase";
            this.lblTotalPurchase.Size = new System.Drawing.Size(108, 13);
            this.lblTotalPurchase.TabIndex = 20;
            this.lblTotalPurchase.Text = "0.00";
            this.lblTotalPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(148, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total Purchase:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSales.Location = new System.Drawing.Point(0, 38);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 5;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(452, 355);
            this.dgvSales.TabIndex = 89;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(452, 38);
            this.panel7.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Vani", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 38);
            this.label3.TabIndex = 81;
            this.label3.Text = "Sales ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.lblTotalSale);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 393);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(452, 31);
            this.panel5.TabIndex = 1;
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSale.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalSale.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalSale.Location = new System.Drawing.Point(263, 9);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(108, 13);
            this.lblTotalSale.TabIndex = 21;
            this.lblTotalSale.Text = "0.00";
            this.lblTotalSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(181, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Sale:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(582, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Select Product:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProduct
            // 
            this.cboProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProduct.Font = new System.Drawing.Font("Verdana", 8F);
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(585, 23);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(160, 21);
            this.cboProduct.TabIndex = 19;
            this.cboProduct.Visible = false;
            // 
            // DailySalesPurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(706, 535);
            this.Name = "DailySalesPurchaseReport";
            this.Size = new System.Drawing.Size(899, 535);
            this.Load += new System.EventHandler(this.DailySalesPurchaseReport_Load);
            this.panel3.ResumeLayout(false);
            this.panelCriteria.ResumeLayout(false);
            this.panelCriteria.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.DataGridView dgvSales;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblTotalPurchase;
        public System.Windows.Forms.Label lblTotalSale;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cboProduct;

    }
}
