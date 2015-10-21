namespace EBusiness
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblShopName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chkHideZero = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboItemTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCompanies = new System.Windows.Forms.ComboBox();
            this.lblReceiptCustomer = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalSale = new System.Windows.Forms.Label();
            this.Lable6 = new System.Windows.Forms.Label();
            this.lblTotalPurchase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPacking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchasedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblShopName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 40);
            this.panel2.TabIndex = 82;
            // 
            // lblShopName
            // 
            this.lblShopName.BackColor = System.Drawing.Color.Transparent;
            this.lblShopName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShopName.Font = new System.Drawing.Font("Vani", 20F, System.Drawing.FontStyle.Bold);
            this.lblShopName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblShopName.Image = ((System.Drawing.Image)(resources.GetObject("lblShopName.Image")));
            this.lblShopName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShopName.Location = new System.Drawing.Point(0, 0);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(1008, 40);
            this.lblShopName.TabIndex = 81;
            this.lblShopName.Text = "Stock";
            this.lblShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.chkHideZero);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cboItemTypes);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbCompanies);
            this.panel4.Controls.Add(this.lblReceiptCustomer);
            this.panel4.Controls.Add(this.cbItems);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 42);
            this.panel4.TabIndex = 83;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(921, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // chkHideZero
            // 
            this.chkHideZero.AutoSize = true;
            this.chkHideZero.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHideZero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkHideZero.Location = new System.Drawing.Point(12, 13);
            this.chkHideZero.Name = "chkHideZero";
            this.chkHideZero.Size = new System.Drawing.Size(129, 17);
            this.chkHideZero.TabIndex = 28;
            this.chkHideZero.Text = "Hide Zero Stock";
            this.chkHideZero.UseVisualStyleBackColor = true;
            this.chkHideZero.CheckedChanged += new System.EventHandler(this.chkHideZero_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(440, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Item Type :";
            // 
            // cboItemTypes
            // 
            this.cboItemTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboItemTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItemTypes.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.cboItemTypes.FormattingEnabled = true;
            this.cboItemTypes.Location = new System.Drawing.Point(553, 11);
            this.cboItemTypes.Name = "cboItemTypes";
            this.cboItemTypes.Size = new System.Drawing.Size(130, 21);
            this.cboItemTypes.Sorted = true;
            this.cboItemTypes.TabIndex = 26;
            this.cboItemTypes.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(165, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Supplier : ";
            // 
            // cbCompanies
            // 
            this.cbCompanies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCompanies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCompanies.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.Location = new System.Drawing.Point(268, 11);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(163, 21);
            this.cbCompanies.Sorted = true;
            this.cbCompanies.TabIndex = 24;
            this.cbCompanies.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // lblReceiptCustomer
            // 
            this.lblReceiptCustomer.AutoSize = true;
            this.lblReceiptCustomer.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblReceiptCustomer.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblReceiptCustomer.Location = new System.Drawing.Point(690, 12);
            this.lblReceiptCustomer.Name = "lblReceiptCustomer";
            this.lblReceiptCustomer.Size = new System.Drawing.Size(56, 17);
            this.lblReceiptCustomer.TabIndex = 23;
            this.lblReceiptCustomer.Text = "Item :";
            // 
            // cbItems
            // 
            this.cbItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItems.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(750, 11);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(130, 21);
            this.cbItems.Sorted = true;
            this.cbItems.TabIndex = 19;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalSale);
            this.panel1.Controls.Add(this.Lable6);
            this.panel1.Controls.Add(this.lblTotalPurchase);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblStockValue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 39);
            this.panel1.TabIndex = 84;
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.AutoSize = true;
            this.lblTotalSale.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalSale.Location = new System.Drawing.Point(777, 13);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(43, 17);
            this.lblTotalSale.TabIndex = 31;
            this.lblTotalSale.Text = "0.00";
            this.lblTotalSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lable6
            // 
            this.Lable6.AutoSize = true;
            this.Lable6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Lable6.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lable6.Location = new System.Drawing.Point(671, 13);
            this.Lable6.Name = "Lable6";
            this.Lable6.Size = new System.Drawing.Size(100, 17);
            this.Lable6.TabIndex = 30;
            this.Lable6.Text = "Total Sale : ";
            // 
            // lblTotalPurchase
            // 
            this.lblTotalPurchase.AutoSize = true;
            this.lblTotalPurchase.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPurchase.Location = new System.Drawing.Point(525, 13);
            this.lblTotalPurchase.Name = "lblTotalPurchase";
            this.lblTotalPurchase.Size = new System.Drawing.Size(43, 17);
            this.lblTotalPurchase.TabIndex = 29;
            this.lblTotalPurchase.Text = "0.00";
            this.lblTotalPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(380, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Total Purchase : ";
            // 
            // lblStockValue
            // 
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStockValue.Location = new System.Drawing.Point(229, 13);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(43, 17);
            this.lblStockValue.TabIndex = 27;
            this.lblStockValue.Text = "0.00";
            this.lblStockValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(108, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Stock Value : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvStock);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 541);
            this.panel3.TabIndex = 85;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colName,
            this.colPacking,
            this.colCompany,
            this.colType,
            this.colPurchasePrice,
            this.colSalePrice,
            this.colTotalPurchase,
            this.colTotalSale,
            this.colStock,
            this.colStockValue,
            this.colPurchasedValue,
            this.colSoldValue,
            this.colOnOrder});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(1008, 541);
            this.dgvStock.TabIndex = 1;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPacking
            // 
            this.colPacking.HeaderText = "Packing";
            this.colPacking.Name = "colPacking";
            this.colPacking.ReadOnly = true;
            // 
            // colCompany
            // 
            this.colCompany.HeaderText = "Supplier";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colPurchasePrice
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPurchasePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPurchasePrice.HeaderText = "PurchasePrice";
            this.colPurchasePrice.Name = "colPurchasePrice";
            this.colPurchasePrice.ReadOnly = true;
            this.colPurchasePrice.Visible = false;
            // 
            // colSalePrice
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSalePrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSalePrice.HeaderText = "SalePrice";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.ReadOnly = true;
            this.colSalePrice.Visible = false;
            // 
            // colTotalPurchase
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotalPurchase.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTotalPurchase.HeaderText = "Purchase";
            this.colTotalPurchase.Name = "colTotalPurchase";
            this.colTotalPurchase.ReadOnly = true;
            // 
            // colTotalSale
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotalSale.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTotalSale.HeaderText = "Sale";
            this.colTotalSale.Name = "colTotalSale";
            this.colTotalSale.ReadOnly = true;
            // 
            // colStock
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colStockValue
            // 
            this.colStockValue.HeaderText = "StockValue";
            this.colStockValue.Name = "colStockValue";
            this.colStockValue.ReadOnly = true;
            // 
            // colPurchasedValue
            // 
            this.colPurchasedValue.HeaderText = "P.Return";
            this.colPurchasedValue.Name = "colPurchasedValue";
            this.colPurchasedValue.ReadOnly = true;
            // 
            // colSoldValue
            // 
            this.colSoldValue.HeaderText = "S.Return";
            this.colSoldValue.Name = "colSoldValue";
            this.colSoldValue.ReadOnly = true;
            // 
            // colOnOrder
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colOnOrder.DefaultCellStyle = dataGridViewCellStyle7;
            this.colOnOrder.HeaderText = "OnOrder";
            this.colOnOrder.Name = "colOnOrder";
            this.colOnOrder.ReadOnly = true;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblReceiptCustomer;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboItemTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCompanies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkHideZero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label lblTotalSale;
        private System.Windows.Forms.Label Lable6;
        private System.Windows.Forms.Label lblTotalPurchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPacking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchasedValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoldValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOnOrder;
    }
}