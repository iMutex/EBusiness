namespace EBusiness
{
    partial class frmInvoice
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNewInvoice = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrandTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPaidOnOrder = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblArrears = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadOrder = new System.Windows.Forms.Button();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.chkLoadOrder = new System.Windows.Forms.CheckBox();
            this.chkIsReturn = new System.Windows.Forms.CheckBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.txtCompanyBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCompanies = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblNextInvoiceNo = new System.Windows.Forms.Label();
            this.lblShopName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.rbCompanyDatewise = new System.Windows.Forms.RadioButton();
            this.rbById = new System.Windows.Forms.RadioButton();
            this.rbDateWise = new System.Windows.Forms.RadioButton();
            this.rbCompanyAll = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.cboSearchCompanies = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnFindInvoices = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpNewInvoice.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNewInvoice);
            this.tabControl1.Controls.Add(this.tpSearch);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tpNewInvoice
            // 
            this.tpNewInvoice.Controls.Add(this.panel4);
            this.tpNewInvoice.Controls.Add(this.panel3);
            this.tpNewInvoice.Controls.Add(this.panel1);
            this.tpNewInvoice.Controls.Add(this.panel2);
            this.tpNewInvoice.Location = new System.Drawing.Point(4, 22);
            this.tpNewInvoice.Name = "tpNewInvoice";
            this.tpNewInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewInvoice.Size = new System.Drawing.Size(893, 618);
            this.tpNewInvoice.TabIndex = 0;
            this.tpNewInvoice.Text = "New";
            this.tpNewInvoice.UseVisualStyleBackColor = true;
            this.tpNewInvoice.Enter += new System.EventHandler(this.tpNewInvoice_Enter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvItems);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(887, 372);
            this.panel4.TabIndex = 1;
            this.panel4.TabStop = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerial,
            this.colItemId,
            this.colItemCode,
            this.colItemName,
            this.colQuantity,
            this.colPrice,
            this.colGrandTotal,
            this.colDiscount,
            this.colTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 20;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(887, 372);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellEndEdit);
            this.dgvItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvItems_RowsAdded);
            this.dgvItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvItems_RowsRemoved);
            // 
            // colSerial
            // 
            this.colSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSerial.HeaderText = "S. No";
            this.colSerial.Name = "colSerial";
            this.colSerial.ReadOnly = true;
            this.colSerial.Width = 70;
            // 
            // colItemId
            // 
            this.colItemId.HeaderText = "ItemId";
            this.colItemId.Name = "colItemId";
            this.colItemId.ReadOnly = true;
            this.colItemId.Visible = false;
            // 
            // colItemCode
            // 
            this.colItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colItemCode.FillWeight = 150F;
            this.colItemCode.HeaderText = "Item Code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.ReadOnly = true;
            this.colItemCode.Width = 150;
            // 
            // colItemName
            // 
            this.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colItemName.FillWeight = 150F;
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Width = 170;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 120;
            // 
            // colGrandTotal
            // 
            this.colGrandTotal.HeaderText = "G.Total";
            this.colGrandTotal.Name = "colGrandTotal";
            this.colGrandTotal.ReadOnly = true;
            this.colGrandTotal.Width = 77;
            // 
            // colDiscount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDiscount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDiscount.HeaderText = "Disc.%";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 78;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPaidOnOrder);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.dtDeliveryDate);
            this.panel3.Controls.Add(this.lblDeliveryDate);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtExpenses);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblArrears);
            this.panel3.Controls.Add(this.txtComments);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblGrandTotal);
            this.panel3.Controls.Add(this.btnDone);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtPayment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 514);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 101);
            this.panel3.TabIndex = 2;
            // 
            // lblPaidOnOrder
            // 
            this.lblPaidOnOrder.AutoSize = true;
            this.lblPaidOnOrder.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.lblPaidOnOrder.ForeColor = System.Drawing.Color.Green;
            this.lblPaidOnOrder.Location = new System.Drawing.Point(402, 26);
            this.lblPaidOnOrder.Name = "lblPaidOnOrder";
            this.lblPaidOnOrder.Size = new System.Drawing.Size(15, 13);
            this.lblPaidOnOrder.TabIndex = 105;
            this.lblPaidOnOrder.Text = "0";
            this.lblPaidOnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPaidOnOrder.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(402, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 104;
            this.label14.Text = "Paid on Order:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(812, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 103;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.CalendarFont = new System.Drawing.Font("Verdana", 8F);
            this.dtDeliveryDate.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.dtDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeliveryDate.Location = new System.Drawing.Point(271, 28);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(112, 20);
            this.dtDeliveryDate.TabIndex = 102;
            this.dtDeliveryDate.Visible = false;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryDate.ForeColor = System.Drawing.Color.Navy;
            this.lblDeliveryDate.Location = new System.Drawing.Point(269, 3);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(114, 22);
            this.lblDeliveryDate.TabIndex = 101;
            this.lblDeliveryDate.Text = "Date:";
            this.lblDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeliveryDate.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(297, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 100;
            this.label12.Text = "Discount :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Visible = false;
            // 
            // txtExpenses
            // 
            this.txtExpenses.AcceptsReturn = true;
            this.txtExpenses.Enabled = false;
            this.txtExpenses.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtExpenses.ForeColor = System.Drawing.Color.Black;
            this.txtExpenses.Location = new System.Drawing.Point(400, 69);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.Size = new System.Drawing.Size(109, 24);
            this.txtExpenses.TabIndex = 2;
            this.txtExpenses.Text = "0.00";
            this.txtExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExpenses.Visible = false;
            this.txtExpenses.Leave += new System.EventHandler(this.txtExpenses_Leave);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(15, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 96;
            this.label9.Text = "Comments:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArrears
            // 
            this.lblArrears.AcceptsReturn = true;
            this.lblArrears.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblArrears.ForeColor = System.Drawing.Color.Black;
            this.lblArrears.Location = new System.Drawing.Point(634, 53);
            this.lblArrears.Name = "lblArrears";
            this.lblArrears.ReadOnly = true;
            this.lblArrears.Size = new System.Drawing.Size(109, 24);
            this.lblArrears.TabIndex = 4;
            this.lblArrears.Text = "0.00";
            this.lblArrears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtComments
            // 
            this.txtComments.AcceptsReturn = true;
            this.txtComments.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtComments.ForeColor = System.Drawing.Color.Black;
            this.txtComments.Location = new System.Drawing.Point(18, 26);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(225, 63);
            this.txtComments.TabIndex = 0;
            this.txtComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddToGridEvent);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(541, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 97;
            this.label7.Text = "Arrears :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AcceptsReturn = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.lblGrandTotal.Location = new System.Drawing.Point(634, 3);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.ReadOnly = true;
            this.lblGrandTotal.Size = new System.Drawing.Size(109, 24);
            this.lblGrandTotal.TabIndex = 1;
            this.lblGrandTotal.Text = "0.00";
            this.lblGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Green;
            this.btnDone.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.Image")));
            this.btnDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDone.Location = new System.Drawing.Point(780, 50);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(104, 51);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "&Done";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(532, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Payment :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(508, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "Grand Total :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPayment
            // 
            this.txtPayment.AcceptsReturn = true;
            this.txtPayment.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtPayment.ForeColor = System.Drawing.Color.Black;
            this.txtPayment.Location = new System.Drawing.Point(634, 29);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(109, 24);
            this.txtPayment.TabIndex = 3;
            this.txtPayment.Text = "0.00";
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayment.Leave += new System.EventHandler(this.txtPayment_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadOrder);
            this.panel1.Controls.Add(this.txtOrderNo);
            this.panel1.Controls.Add(this.chkLoadOrder);
            this.panel1.Controls.Add(this.chkIsReturn);
            this.panel1.Controls.Add(this.lblItemId);
            this.panel1.Controls.Add(this.txtCompanyBalance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbCompanies);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboItems);
            this.panel1.Controls.Add(this.lblCompany);
            this.panel1.Controls.Add(this.lblItemName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 97);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // btnLoadOrder
            // 
            this.btnLoadOrder.Location = new System.Drawing.Point(816, 66);
            this.btnLoadOrder.Name = "btnLoadOrder";
            this.btnLoadOrder.Size = new System.Drawing.Size(59, 23);
            this.btnLoadOrder.TabIndex = 97;
            this.btnLoadOrder.Text = "Load";
            this.btnLoadOrder.UseVisualStyleBackColor = true;
            this.btnLoadOrder.Visible = false;
            this.btnLoadOrder.Click += new System.EventHandler(this.btnLoadOrder_Click);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.AcceptsReturn = true;
            this.txtOrderNo.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.txtOrderNo.ForeColor = System.Drawing.Color.Black;
            this.txtOrderNo.Location = new System.Drawing.Point(712, 68);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(91, 20);
            this.txtOrderNo.TabIndex = 96;
            this.txtOrderNo.Visible = false;
            // 
            // chkLoadOrder
            // 
            this.chkLoadOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLoadOrder.AutoSize = true;
            this.chkLoadOrder.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.chkLoadOrder.ForeColor = System.Drawing.Color.Navy;
            this.chkLoadOrder.Location = new System.Drawing.Point(712, 38);
            this.chkLoadOrder.Name = "chkLoadOrder";
            this.chkLoadOrder.Size = new System.Drawing.Size(115, 21);
            this.chkLoadOrder.TabIndex = 95;
            this.chkLoadOrder.TabStop = false;
            this.chkLoadOrder.Text = "Load Order";
            this.chkLoadOrder.UseVisualStyleBackColor = true;
            this.chkLoadOrder.CheckedChanged += new System.EventHandler(this.chkLoadOrder_CheckedChanged);
            // 
            // chkIsReturn
            // 
            this.chkIsReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsReturn.AutoSize = true;
            this.chkIsReturn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.chkIsReturn.ForeColor = System.Drawing.Color.Navy;
            this.chkIsReturn.Location = new System.Drawing.Point(712, 9);
            this.chkIsReturn.Name = "chkIsReturn";
            this.chkIsReturn.Size = new System.Drawing.Size(143, 21);
            this.chkIsReturn.TabIndex = 0;
            this.chkIsReturn.TabStop = false;
            this.chkIsReturn.Text = "Return Invoice";
            this.chkIsReturn.UseVisualStyleBackColor = true;
            this.chkIsReturn.CheckedChanged += new System.EventHandler(this.chkIsReturn_CheckedChanged);
            // 
            // lblItemId
            // 
            this.lblItemId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblItemId.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblItemId.Location = new System.Drawing.Point(855, 14);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(19, 26);
            this.lblItemId.TabIndex = 94;
            this.lblItemId.Text = "0";
            this.lblItemId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItemId.Visible = false;
            // 
            // txtCompanyBalance
            // 
            this.txtCompanyBalance.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtCompanyBalance.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyBalance.Location = new System.Drawing.Point(558, 8);
            this.txtCompanyBalance.Name = "txtCompanyBalance";
            this.txtCompanyBalance.Size = new System.Drawing.Size(118, 21);
            this.txtCompanyBalance.TabIndex = 93;
            this.txtCompanyBalance.Text = "Balance";
            this.txtCompanyBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(495, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 92;
            this.label8.Text = "Price :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.AcceptsReturn = true;
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(561, 38);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(107, 24);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddToGridEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(478, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 91;
            this.label4.Text = "Balance:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCompanies
            // 
            this.cbCompanies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCompanies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCompanies.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbCompanies.ForeColor = System.Drawing.Color.Black;
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.Location = new System.Drawing.Point(113, 4);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(173, 24);
            this.cbCompanies.Sorted = true;
            this.cbCompanies.TabIndex = 0;
            this.cbCompanies.SelectedIndexChanged += new System.EventHandler(this.cbCompanies_SelectedIndexChanged);
            this.cbCompanies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboItems_KeyDown);
            this.cbCompanies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCompanies_KeyPress);
            this.cbCompanies.Leave += new System.EventHandler(this.cbCompanies_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(24, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Supplier :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(386, 66);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(99, 23);
            this.lblStock.TabIndex = 89;
            this.lblStock.Text = "0.00";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(323, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Stock:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboItems
            // 
            this.cboItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItems.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cboItems.ForeColor = System.Drawing.Color.Black;
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Location = new System.Drawing.Point(113, 39);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(175, 24);
            this.cboItems.Sorted = true;
            this.cboItems.TabIndex = 1;
            this.cboItems.SelectedIndexChanged += new System.EventHandler(this.cboItems_SelectedIndexChanged);
            this.cboItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboItems_KeyDown);
            this.cboItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboItems_KeyPress);
            this.cboItems.Leave += new System.EventHandler(this.cboItems_Leave);
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblCompany.ForeColor = System.Drawing.Color.Navy;
            this.lblCompany.Location = new System.Drawing.Point(297, 4);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(160, 24);
            this.lblCompany.TabIndex = 87;
            this.lblCompany.Text = "Supplier";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(110, 66);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(166, 23);
            this.lblItemName.TabIndex = 86;
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(295, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "Quantity :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(4, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "Item Name :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AcceptsReturn = true;
            this.txtQuantity.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(392, 39);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(97, 24);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddToGridEvent);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(51, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "Item :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtInvoiceNo);
            this.panel2.Controls.Add(this.lblNextInvoiceNo);
            this.panel2.Controls.Add(this.lblShopName);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 42);
            this.panel2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(112, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 101;
            this.label13.Text = "No :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.AcceptsReturn = true;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.Black;
            this.txtInvoiceNo.Location = new System.Drawing.Point(158, 11);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(130, 24);
            this.txtInvoiceNo.TabIndex = 0;
            // 
            // lblNextInvoiceNo
            // 
            this.lblNextInvoiceNo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextInvoiceNo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNextInvoiceNo.Location = new System.Drawing.Point(684, 5);
            this.lblNextInvoiceNo.Name = "lblNextInvoiceNo";
            this.lblNextInvoiceNo.Size = new System.Drawing.Size(198, 33);
            this.lblNextInvoiceNo.TabIndex = 91;
            this.lblNextInvoiceNo.Text = "0";
            this.lblNextInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShopName
            // 
            this.lblShopName.BackColor = System.Drawing.Color.Transparent;
            this.lblShopName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblShopName.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.lblShopName.ForeColor = System.Drawing.Color.Purple;
            this.lblShopName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShopName.Location = new System.Drawing.Point(102, 0);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(785, 37);
            this.lblShopName.TabIndex = 86;
            this.lblShopName.Text = "Invoice";
            this.lblShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(102, 42);
            this.panel5.TabIndex = 0;
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.groupBox6);
            this.tpSearch.Controls.Add(this.groupBox3);
            this.tpSearch.Controls.Add(this.panel6);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(893, 618);
            this.tpSearch.TabIndex = 1;
            this.tpSearch.Text = "Search / View";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvInvoiceDetails);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 391);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(887, 224);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Invoice Details";
            // 
            // dgvInvoiceDetails
            // 
            this.dgvInvoiceDetails.AllowUserToAddRows = false;
            this.dgvInvoiceDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvInvoiceDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInvoiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInvoiceDetails.Location = new System.Drawing.Point(3, 16);
            this.dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            this.dgvInvoiceDetails.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInvoiceDetails.RowHeadersWidth = 10;
            this.dgvInvoiceDetails.RowTemplate.Height = 24;
            this.dgvInvoiceDetails.Size = new System.Drawing.Size(881, 205);
            this.dgvInvoiceDetails.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvInvoices);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(887, 331);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Invoice";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInvoices.Location = new System.Drawing.Point(3, 16);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersWidth = 25;
            this.dgvInvoices.RowTemplate.Height = 24;
            this.dgvInvoices.Size = new System.Drawing.Size(881, 312);
            this.dgvInvoices.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSearchText);
            this.panel6.Controls.Add(this.rbCompanyDatewise);
            this.panel6.Controls.Add(this.rbById);
            this.panel6.Controls.Add(this.rbDateWise);
            this.panel6.Controls.Add(this.rbCompanyAll);
            this.panel6.Controls.Add(this.rbAll);
            this.panel6.Controls.Add(this.lblSearchFor);
            this.panel6.Controls.Add(this.cboSearchCompanies);
            this.panel6.Controls.Add(this.dtpEndDate);
            this.panel6.Controls.Add(this.lblTo);
            this.panel6.Controls.Add(this.dtpStartDate);
            this.panel6.Controls.Add(this.lblFrom);
            this.panel6.Controls.Add(this.btnFindInvoices);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(887, 57);
            this.panel6.TabIndex = 3;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(477, 30);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(152, 20);
            this.txtSearchText.TabIndex = 7;
            this.txtSearchText.Visible = false;
            // 
            // rbCompanyDatewise
            // 
            this.rbCompanyDatewise.AutoSize = true;
            this.rbCompanyDatewise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompanyDatewise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbCompanyDatewise.Location = new System.Drawing.Point(90, 3);
            this.rbCompanyDatewise.Name = "rbCompanyDatewise";
            this.rbCompanyDatewise.Size = new System.Drawing.Size(203, 19);
            this.rbCompanyDatewise.TabIndex = 1;
            this.rbCompanyDatewise.Text = "Company Invoices Datewise";
            this.rbCompanyDatewise.UseVisualStyleBackColor = true;
            this.rbCompanyDatewise.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // rbById
            // 
            this.rbById.AutoSize = true;
            this.rbById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbById.ForeColor = System.Drawing.Color.Purple;
            this.rbById.Location = new System.Drawing.Point(555, 3);
            this.rbById.Name = "rbById";
            this.rbById.Size = new System.Drawing.Size(115, 19);
            this.rbById.TabIndex = 4;
            this.rbById.Text = "By Invoice No.";
            this.rbById.UseVisualStyleBackColor = true;
            this.rbById.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // rbDateWise
            // 
            this.rbDateWise.AutoSize = true;
            this.rbDateWise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDateWise.ForeColor = System.Drawing.Color.Olive;
            this.rbDateWise.Location = new System.Drawing.Point(463, 3);
            this.rbDateWise.Name = "rbDateWise";
            this.rbDateWise.Size = new System.Drawing.Size(90, 19);
            this.rbDateWise.TabIndex = 3;
            this.rbDateWise.Text = "Date Wise";
            this.rbDateWise.UseVisualStyleBackColor = true;
            this.rbDateWise.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // rbCompanyAll
            // 
            this.rbCompanyAll.AutoSize = true;
            this.rbCompanyAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCompanyAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbCompanyAll.Location = new System.Drawing.Point(297, 3);
            this.rbCompanyAll.Name = "rbCompanyAll";
            this.rbCompanyAll.Size = new System.Drawing.Size(160, 19);
            this.rbCompanyAll.TabIndex = 2;
            this.rbCompanyAll.Text = "Company All Invoices";
            this.rbCompanyAll.UseVisualStyleBackColor = true;
            this.rbCompanyAll.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbAll.Location = new System.Drawing.Point(11, 3);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(75, 19);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "View All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearchFor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSearchFor.Location = new System.Drawing.Point(369, 30);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(92, 17);
            this.lblSearchFor.TabIndex = 23;
            this.lblSearchFor.Text = "Search For";
            // 
            // cboSearchCompanies
            // 
            this.cboSearchCompanies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSearchCompanies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSearchCompanies.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.cboSearchCompanies.FormattingEnabled = true;
            this.cboSearchCompanies.Location = new System.Drawing.Point(476, 30);
            this.cboSearchCompanies.Name = "cboSearchCompanies";
            this.cboSearchCompanies.Size = new System.Drawing.Size(163, 21);
            this.cboSearchCompanies.TabIndex = 19;
            this.cboSearchCompanies.Leave += new System.EventHandler(this.cboSearchCompanies_Leave);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Verdana", 8F);
            this.dtpEndDate.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(246, 30);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(103, 20);
            this.dtpEndDate.TabIndex = 6;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTo.Location = new System.Drawing.Point(212, 30);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 17);
            this.lblTo.TabIndex = 22;
            this.lblTo.Text = "To";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Verdana", 8F);
            this.dtpStartDate.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(104, 30);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(102, 20);
            this.dtpStartDate.TabIndex = 5;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFrom.Location = new System.Drawing.Point(53, 30);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(48, 17);
            this.lblFrom.TabIndex = 21;
            this.lblFrom.Text = "From";
            // 
            // btnFindInvoices
            // 
            this.btnFindInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFindInvoices.Image = ((System.Drawing.Image)(resources.GetObject("btnFindInvoices.Image")));
            this.btnFindInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindInvoices.Location = new System.Drawing.Point(671, 14);
            this.btnFindInvoices.Name = "btnFindInvoices";
            this.btnFindInvoices.Size = new System.Drawing.Size(118, 40);
            this.btnFindInvoices.TabIndex = 8;
            this.btnFindInvoices.Text = "Find";
            this.btnFindInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindInvoices.UseVisualStyleBackColor = true;
            this.btnFindInvoices.Click += new System.EventHandler(this.btnFindInvoices_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 644);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Management";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpNewInvoice.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpSearch.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetails)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNewInvoice;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayment;
        protected System.Windows.Forms.Label lblItemId;
        protected System.Windows.Forms.Label txtCompanyBalance;
        protected System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCompanies;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label lblStock;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboItems;
        protected System.Windows.Forms.Label lblCompany;
        protected System.Windows.Forms.Label lblItemName;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        protected System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnDone;
        protected System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chkIsReturn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvInvoiceDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSearchText;
        protected System.Windows.Forms.RadioButton rbById;
        protected System.Windows.Forms.RadioButton rbDateWise;
        protected System.Windows.Forms.RadioButton rbCompanyDatewise;
        protected System.Windows.Forms.RadioButton rbCompanyAll;
        protected System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.ComboBox cboSearchCompanies;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblFrom;
        protected System.Windows.Forms.Button btnFindInvoices;
        protected System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox lblGrandTotal;
        private System.Windows.Forms.TextBox lblArrears;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComments;
        protected System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.CheckBox chkLoadOrder;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Button btnLoadOrder;
        protected System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrandTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        protected System.Windows.Forms.Label lblNextInvoiceNo;
        private System.Windows.Forms.Button btnClear;
        protected System.Windows.Forms.Label label14;
        protected System.Windows.Forms.Label lblPaidOnOrder;
        protected System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInvoiceNo;


    }
}