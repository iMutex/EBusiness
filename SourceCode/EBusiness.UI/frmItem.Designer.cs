namespace EBusiness
{
    partial class frmItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSelectCompany = new System.Windows.Forms.Label();
            this.cbAllNewUpdate = new System.Windows.Forms.ComboBox();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.lblId = new System.Windows.Forms.Label();
            this.tpNewItemType = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblItemTypeId = new System.Windows.Forms.Label();
            this.lblSelectItemType = new System.Windows.Forms.Label();
            this.cboAllItemTypes = new System.Windows.Forms.ComboBox();
            this.rbUpdateItemType = new System.Windows.Forms.RadioButton();
            this.rbNewItemType = new System.Windows.Forms.RadioButton();
            this.chkITemTypeIsActive = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtItemTypeName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewItemType = new System.Windows.Forms.Button();
            this.btnCancelItemType = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tpSearchItemType = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckViewAllItems = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvItemTypesData = new System.Windows.Forms.DataGridView();
            this.rbSearchByItemType = new System.Windows.Forms.RadioButton();
            this.rbSearchByCompany = new System.Windows.Forms.RadioButton();
            this.cbItemSearch = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnItemListPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtItemCode = new EBusiness.ucTextBox();
            this.txtItemName = new EBusiness.ucTextBox();
            this.txtPacking = new EBusiness.ucTextBox();
            this.txtPurchasePrice = new EBusiness.ucTextBox();
            this.txtSalePrice = new EBusiness.ucTextBox();
            this.txtDiscount = new EBusiness.ucTextBox();
            this.txtMinStock = new EBusiness.ucTextBox();
            this.txtBatchNo = new EBusiness.ucTextBox();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.dtExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.chkitemView = new System.Windows.Forms.CheckBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.cbSearchByCode = new System.Windows.Forms.ComboBox();
            this.tcMain.SuspendLayout();
            this.tpView.SuspendLayout();
            this.tpNew.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.tpNewItemType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpSearchItemType.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemTypesData)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFind.Location = new System.Drawing.Point(685, 87);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Size = new System.Drawing.Size(94, 41);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpNewItemType);
            this.tcMain.Controls.Add(this.tpSearchItemType);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Size = new System.Drawing.Size(886, 635);
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged_1);
            this.tcMain.Controls.SetChildIndex(this.tpSearchItemType, 0);
            this.tcMain.Controls.SetChildIndex(this.tpNewItemType, 0);
            this.tcMain.Controls.SetChildIndex(this.tpView, 0);
            this.tcMain.Controls.SetChildIndex(this.tpNew, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(749, 19);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(632, 19);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.TabIndex = 0;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbSearchByCode
            // 
            this.rbSearchByCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSearchByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbSearchByCode.Location = new System.Drawing.Point(146, 63);
            this.rbSearchByCode.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchByCode.Size = new System.Drawing.Size(128, 18);
            this.rbSearchByCode.TabIndex = 1;
            this.rbSearchByCode.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // rbSearchByName
            // 
            this.rbSearchByName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSearchByName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbSearchByName.Location = new System.Drawing.Point(275, 63);
            this.rbSearchByName.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchByName.Size = new System.Drawing.Size(133, 18);
            this.rbSearchByName.TabIndex = 2;
            this.rbSearchByName.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbAll.Location = new System.Drawing.Point(696, 63);
            this.rbAll.Margin = new System.Windows.Forms.Padding(4);
            this.rbAll.Size = new System.Drawing.Size(79, 18);
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // tpView
            // 
            this.tpView.Margin = new System.Windows.Forms.Padding(4);
            this.tpView.Padding = new System.Windows.Forms.Padding(4);
            this.tpView.Size = new System.Drawing.Size(878, 609);
            this.tpView.Text = "Search / View Item";
            // 
            // tpNew
            // 
            this.tpNew.Margin = new System.Windows.Forms.Padding(4);
            this.tpNew.Padding = new System.Windows.Forms.Padding(4);
            this.tpNew.Size = new System.Drawing.Size(878, 609);
            this.tpNew.Text = "New / Update Item";
            this.tpNew.Enter += new System.EventHandler(this.tpNew_Enter);
            // 
            // lblHeader
            // 
            this.lblHeader.Image = ((System.Drawing.Image)(resources.GetObject("lblHeader.Image")));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Size = new System.Drawing.Size(870, 57);
            this.lblHeader.Text = "Item Information";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblCompanyName);
            this.gbMain.Controls.Add(this.lblSupplierName);
            this.gbMain.Controls.Add(this.dtExpiryDate);
            this.gbMain.Controls.Add(this.lblExpiryDate);
            this.gbMain.Controls.Add(this.txtBatchNo);
            this.gbMain.Controls.Add(this.lblBatchNo);
            this.gbMain.Controls.Add(this.txtMinStock);
            this.gbMain.Controls.Add(this.txtDiscount);
            this.gbMain.Controls.Add(this.txtSalePrice);
            this.gbMain.Controls.Add(this.txtPurchasePrice);
            this.gbMain.Controls.Add(this.txtPacking);
            this.gbMain.Controls.Add(this.txtItemName);
            this.gbMain.Controls.Add(this.txtItemCode);
            this.gbMain.Controls.Add(this.label13);
            this.gbMain.Controls.Add(this.label12);
            this.gbMain.Controls.Add(this.label11);
            this.gbMain.Controls.Add(this.lblId);
            this.gbMain.Controls.Add(this.lblSelectCompany);
            this.gbMain.Controls.Add(this.cbAllNewUpdate);
            this.gbMain.Controls.Add(this.rbUpdate);
            this.gbMain.Controls.Add(this.rbNew);
            this.gbMain.Controls.Add(this.label9);
            this.gbMain.Controls.Add(this.cbCompany);
            this.gbMain.Controls.Add(this.label8);
            this.gbMain.Controls.Add(this.cbItemType);
            this.gbMain.Controls.Add(this.label7);
            this.gbMain.Controls.Add(this.label6);
            this.gbMain.Controls.Add(this.label5);
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.chkIsActive);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.ForeColor = System.Drawing.Color.Black;
            this.gbMain.Location = new System.Drawing.Point(4, 61);
            this.gbMain.Margin = new System.Windows.Forms.Padding(4);
            this.gbMain.Padding = new System.Windows.Forms.Padding(4);
            this.gbMain.Size = new System.Drawing.Size(870, 468);
            this.gbMain.Enter += new System.EventHandler(this.gbMain_Enter);
            // 
            // txtBalance
            // 
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(149, 100);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Size = new System.Drawing.Size(520, 22);
            this.txtSearch.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(28, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.Text = "Search Text";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbSearchByCode);
            this.gbSearch.Controls.Add(this.chkitemView);
            this.gbSearch.Controls.Add(this.panel3);
            this.gbSearch.Controls.Add(this.rbSearchByCompany);
            this.gbSearch.Controls.Add(this.rbSearchByItemType);
            this.gbSearch.Controls.Add(this.cbItemSearch);
            this.gbSearch.Location = new System.Drawing.Point(4, 4);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearch.Size = new System.Drawing.Size(870, 136);
            this.gbSearch.Controls.SetChildIndex(this.cbItemSearch, 0);
            this.gbSearch.Controls.SetChildIndex(this.rbSearchByItemType, 0);
            this.gbSearch.Controls.SetChildIndex(this.rbSearchByCompany, 0);
            this.gbSearch.Controls.SetChildIndex(this.txtSearch, 0);
            this.gbSearch.Controls.SetChildIndex(this.panel3, 0);
            this.gbSearch.Controls.SetChildIndex(this.chkitemView, 0);
            this.gbSearch.Controls.SetChildIndex(this.cbSearchByCode, 0);
            this.gbSearch.Controls.SetChildIndex(this.btnFind, 0);
            this.gbSearch.Controls.SetChildIndex(this.rbSearchByCode, 0);
            this.gbSearch.Controls.SetChildIndex(this.rbSearchByName, 0);
            this.gbSearch.Controls.SetChildIndex(this.label1, 0);
            this.gbSearch.Controls.SetChildIndex(this.rbAll, 0);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.Location = new System.Drawing.Point(593, 433);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 51;
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(520, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Active : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(155, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Item Code : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(156, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Item Type : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(117, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Purchase Price : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(159, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sale Price : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbItemType
            // 
            this.cbItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItemType.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Location = new System.Drawing.Point(278, 156);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(317, 24);
            this.cbItemType.Sorted = true;
            this.cbItemType.TabIndex = 44;
            this.cbItemType.Leave += new System.EventHandler(this.cbItemType_Leave);
            // 
            // cbCompany
            // 
            this.cbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCompany.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(278, 192);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(317, 24);
            this.cbCompany.Sorted = true;
            this.cbCompany.TabIndex = 45;
            this.cbCompany.SelectedIndexChanged += new System.EventHandler(this.cbCompany_SelectedIndexChanged);
            this.cbCompany.Leave += new System.EventHandler(this.cbCompany_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(172, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Supplier : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(148, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Item Name : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectCompany
            // 
            this.lblSelectCompany.AutoSize = true;
            this.lblSelectCompany.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectCompany.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSelectCompany.Location = new System.Drawing.Point(151, 40);
            this.lblSelectCompany.Name = "lblSelectCompany";
            this.lblSelectCompany.Size = new System.Drawing.Size(119, 18);
            this.lblSelectCompany.TabIndex = 35;
            this.lblSelectCompany.Text = "Select Item: ";
            this.lblSelectCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSelectCompany.Visible = false;
            // 
            // cbAllNewUpdate
            // 
            this.cbAllNewUpdate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAllNewUpdate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAllNewUpdate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbAllNewUpdate.FormattingEnabled = true;
            this.cbAllNewUpdate.Location = new System.Drawing.Point(278, 39);
            this.cbAllNewUpdate.Name = "cbAllNewUpdate";
            this.cbAllNewUpdate.Size = new System.Drawing.Size(317, 24);
            this.cbAllNewUpdate.Sorted = true;
            this.cbAllNewUpdate.TabIndex = 2;
            this.cbAllNewUpdate.Visible = false;
            this.cbAllNewUpdate.SelectedIndexChanged += new System.EventHandler(this.cbAllNewUpdate_SelectedIndexChanged);
            this.cbAllNewUpdate.Leave += new System.EventHandler(this.cbAllNewUpdate_Leave);
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.rbUpdate.ForeColor = System.Drawing.Color.Blue;
            this.rbUpdate.Location = new System.Drawing.Point(397, 11);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(104, 27);
            this.rbUpdate.TabIndex = 1;
            this.rbUpdate.Text = "Update";
            this.rbUpdate.UseVisualStyleBackColor = true;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Checked = true;
            this.rbNew.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.rbNew.ForeColor = System.Drawing.Color.Blue;
            this.rbNew.Location = new System.Drawing.Point(315, 11);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(76, 27);
            this.rbNew.TabIndex = 0;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.DarkGray;
            this.lblId.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblId.Location = new System.Drawing.Point(765, 400);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 43);
            this.lblId.TabIndex = 36;
            this.lblId.Text = "0";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Visible = false;
            // 
            // tpNewItemType
            // 
            this.tpNewItemType.Controls.Add(this.groupBox1);
            this.tpNewItemType.Controls.Add(this.groupBox2);
            this.tpNewItemType.Controls.Add(this.groupBox3);
            this.tpNewItemType.Location = new System.Drawing.Point(4, 22);
            this.tpNewItemType.Name = "tpNewItemType";
            this.tpNewItemType.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewItemType.Size = new System.Drawing.Size(878, 609);
            this.tpNewItemType.TabIndex = 2;
            this.tpNewItemType.Text = "New / Update Item Type";
            this.tpNewItemType.UseVisualStyleBackColor = true;
            this.tpNewItemType.Enter += new System.EventHandler(this.tpNewItemType_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblItemTypeId);
            this.groupBox1.Controls.Add(this.lblSelectItemType);
            this.groupBox1.Controls.Add(this.cboAllItemTypes);
            this.groupBox1.Controls.Add(this.rbUpdateItemType);
            this.groupBox1.Controls.Add(this.rbNewItemType);
            this.groupBox1.Controls.Add(this.chkITemTypeIsActive);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtItemTypeName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 457);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblItemTypeId
            // 
            this.lblItemTypeId.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTypeId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblItemTypeId.Location = new System.Drawing.Point(110, 244);
            this.lblItemTypeId.Name = "lblItemTypeId";
            this.lblItemTypeId.Size = new System.Drawing.Size(75, 43);
            this.lblItemTypeId.TabIndex = 38;
            this.lblItemTypeId.Text = "0";
            this.lblItemTypeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblItemTypeId.Visible = false;
            // 
            // lblSelectItemType
            // 
            this.lblSelectItemType.AutoSize = true;
            this.lblSelectItemType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectItemType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSelectItemType.Location = new System.Drawing.Point(30, 69);
            this.lblSelectItemType.Name = "lblSelectItemType";
            this.lblSelectItemType.Size = new System.Drawing.Size(173, 18);
            this.lblSelectItemType.TabIndex = 37;
            this.lblSelectItemType.Text = "Select Item Type : ";
            this.lblSelectItemType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSelectItemType.Visible = false;
            // 
            // cboAllItemTypes
            // 
            this.cboAllItemTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAllItemTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAllItemTypes.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cboAllItemTypes.FormattingEnabled = true;
            this.cboAllItemTypes.Location = new System.Drawing.Point(208, 69);
            this.cboAllItemTypes.Name = "cboAllItemTypes";
            this.cboAllItemTypes.Size = new System.Drawing.Size(338, 24);
            this.cboAllItemTypes.Sorted = true;
            this.cboAllItemTypes.TabIndex = 2;
            this.cboAllItemTypes.Visible = false;
            this.cboAllItemTypes.SelectedIndexChanged += new System.EventHandler(this.cboAllItemTypes_SelectedIndexChanged);
            this.cboAllItemTypes.Leave += new System.EventHandler(this.cboAllItemTypes_Leave);
            // 
            // rbUpdateItemType
            // 
            this.rbUpdateItemType.AutoSize = true;
            this.rbUpdateItemType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.rbUpdateItemType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbUpdateItemType.Location = new System.Drawing.Point(314, 26);
            this.rbUpdateItemType.Name = "rbUpdateItemType";
            this.rbUpdateItemType.Size = new System.Drawing.Size(90, 22);
            this.rbUpdateItemType.TabIndex = 1;
            this.rbUpdateItemType.Text = "Update";
            this.rbUpdateItemType.UseVisualStyleBackColor = true;
            this.rbUpdateItemType.CheckedChanged += new System.EventHandler(this.rbUpdateItemType_CheckedChanged);
            // 
            // rbNewItemType
            // 
            this.rbNewItemType.AutoSize = true;
            this.rbNewItemType.Checked = true;
            this.rbNewItemType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.rbNewItemType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbNewItemType.Location = new System.Drawing.Point(208, 26);
            this.rbNewItemType.Name = "rbNewItemType";
            this.rbNewItemType.Size = new System.Drawing.Size(66, 22);
            this.rbNewItemType.TabIndex = 0;
            this.rbNewItemType.TabStop = true;
            this.rbNewItemType.Text = "New";
            this.rbNewItemType.UseVisualStyleBackColor = true;
            // 
            // chkITemTypeIsActive
            // 
            this.chkITemTypeIsActive.AutoSize = true;
            this.chkITemTypeIsActive.Checked = true;
            this.chkITemTypeIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkITemTypeIsActive.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.chkITemTypeIsActive.Location = new System.Drawing.Point(208, 187);
            this.chkITemTypeIsActive.Name = "chkITemTypeIsActive";
            this.chkITemTypeIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkITemTypeIsActive.TabIndex = 4;
            this.chkITemTypeIsActive.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(104, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 18);
            this.label14.TabIndex = 32;
            this.label14.Text = "Is Active : ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemTypeName
            // 
            this.txtItemTypeName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtItemTypeName.Location = new System.Drawing.Point(208, 119);
            this.txtItemTypeName.Name = "txtItemTypeName";
            this.txtItemTypeName.Size = new System.Drawing.Size(338, 24);
            this.txtItemTypeName.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(88, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Item Type : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewItemType);
            this.groupBox2.Controls.Add(this.btnCancelItemType);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 530);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnNewItemType
            // 
            this.btnNewItemType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewItemType.BackgroundImage")));
            this.btnNewItemType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItemType.ForeColor = System.Drawing.Color.Blue;
            this.btnNewItemType.Image = ((System.Drawing.Image)(resources.GetObject("btnNewItemType.Image")));
            this.btnNewItemType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewItemType.Location = new System.Drawing.Point(614, 19);
            this.btnNewItemType.Name = "btnNewItemType";
            this.btnNewItemType.Size = new System.Drawing.Size(107, 51);
            this.btnNewItemType.TabIndex = 0;
            this.btnNewItemType.Text = "Save";
            this.btnNewItemType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewItemType.UseVisualStyleBackColor = true;
            this.btnNewItemType.Click += new System.EventHandler(this.btnNewItemType_Click);
            // 
            // btnCancelItemType
            // 
            this.btnCancelItemType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelItemType.BackgroundImage")));
            this.btnCancelItemType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelItemType.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelItemType.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelItemType.Image")));
            this.btnCancelItemType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelItemType.Location = new System.Drawing.Point(727, 19);
            this.btnCancelItemType.Name = "btnCancelItemType";
            this.btnCancelItemType.Size = new System.Drawing.Size(107, 51);
            this.btnCancelItemType.TabIndex = 1;
            this.btnCancelItemType.Text = "Cancel";
            this.btnCancelItemType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelItemType.UseVisualStyleBackColor = true;
            this.btnCancelItemType.Click += new System.EventHandler(this.btnCancelItemType_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 75);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(866, 56);
            this.label10.TabIndex = 0;
            this.label10.Text = "Item Type Information";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpSearchItemType
            // 
            this.tpSearchItemType.Controls.Add(this.groupBox4);
            this.tpSearchItemType.Location = new System.Drawing.Point(4, 22);
            this.tpSearchItemType.Name = "tpSearchItemType";
            this.tpSearchItemType.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchItemType.Size = new System.Drawing.Size(878, 609);
            this.tpSearchItemType.TabIndex = 3;
            this.tpSearchItemType.Text = "View All Item Types";
            this.tpSearchItemType.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckViewAllItems);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Controls.Add(this.dgvItemTypesData);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(872, 603);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // ckViewAllItems
            // 
            this.ckViewAllItems.AutoSize = true;
            this.ckViewAllItems.Checked = true;
            this.ckViewAllItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckViewAllItems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.ckViewAllItems.ForeColor = System.Drawing.Color.Green;
            this.ckViewAllItems.Location = new System.Drawing.Point(21, 63);
            this.ckViewAllItems.Name = "ckViewAllItems";
            this.ckViewAllItems.Size = new System.Drawing.Size(100, 17);
            this.ckViewAllItems.TabIndex = 2;
            this.ckViewAllItems.Text = "Active Only";
            this.ckViewAllItems.UseVisualStyleBackColor = true;
            this.ckViewAllItems.CheckedChanged += new System.EventHandler(this.ckViewAllItems_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::EBusiness.Properties.Resources.Heading;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(872, 57);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EBusiness.Properties.Resources.gwenview;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(278, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(318, 32);
            this.label17.TabIndex = 0;
            this.label17.Text = "View All Item Types";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvItemTypesData
            // 
            this.dgvItemTypesData.AllowUserToAddRows = false;
            this.dgvItemTypesData.AllowUserToDeleteRows = false;
            this.dgvItemTypesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemTypesData.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemTypesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItemTypesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemTypesData.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItemTypesData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItemTypesData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItemTypesData.Location = new System.Drawing.Point(3, 105);
            this.dgvItemTypesData.Name = "dgvItemTypesData";
            this.dgvItemTypesData.ReadOnly = true;
            this.dgvItemTypesData.RowTemplate.Height = 24;
            this.dgvItemTypesData.Size = new System.Drawing.Size(866, 495);
            this.dgvItemTypesData.TabIndex = 0;
            // 
            // rbSearchByItemType
            // 
            this.rbSearchByItemType.AutoSize = true;
            this.rbSearchByItemType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSearchByItemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbSearchByItemType.Location = new System.Drawing.Point(409, 63);
            this.rbSearchByItemType.Name = "rbSearchByItemType";
            this.rbSearchByItemType.Size = new System.Drawing.Size(128, 18);
            this.rbSearchByItemType.TabIndex = 3;
            this.rbSearchByItemType.TabStop = true;
            this.rbSearchByItemType.Text = "Search By Type";
            this.rbSearchByItemType.UseVisualStyleBackColor = true;
            this.rbSearchByItemType.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // rbSearchByCompany
            // 
            this.rbSearchByCompany.AutoSize = true;
            this.rbSearchByCompany.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSearchByCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbSearchByCompany.Location = new System.Drawing.Point(539, 63);
            this.rbSearchByCompany.Name = "rbSearchByCompany";
            this.rbSearchByCompany.Size = new System.Drawing.Size(151, 18);
            this.rbSearchByCompany.TabIndex = 4;
            this.rbSearchByCompany.TabStop = true;
            this.rbSearchByCompany.Text = "Search By Supplier";
            this.rbSearchByCompany.UseVisualStyleBackColor = true;
            this.rbSearchByCompany.CheckedChanged += new System.EventHandler(this.rbSearchOption_CheckedChanged);
            // 
            // cbItemSearch
            // 
            this.cbItemSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbItemSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItemSearch.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbItemSearch.FormattingEnabled = true;
            this.cbItemSearch.Location = new System.Drawing.Point(149, 100);
            this.cbItemSearch.Name = "cbItemSearch";
            this.cbItemSearch.Size = new System.Drawing.Size(520, 24);
            this.cbItemSearch.Sorted = true;
            this.cbItemSearch.TabIndex = 7;
            this.cbItemSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            this.cbItemSearch.Leave += new System.EventHandler(this.cbItemSearch_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(168, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 18);
            this.label11.TabIndex = 38;
            this.label11.Text = "Discount : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(176, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 40;
            this.label12.Text = "Packing : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(148, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stock Limit : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(601, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 26);
            this.label13.TabIndex = 41;
            this.label13.Text = "%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::EBusiness.Properties.Resources.Heading;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnItemListPrint);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(872, 57);
            this.panel3.TabIndex = 92;
            // 
            // btnItemListPrint
            // 
            this.btnItemListPrint.BackgroundImage = global::EBusiness.Properties.Resources.largeButton1;
            this.btnItemListPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnItemListPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemListPrint.Location = new System.Drawing.Point(745, 10);
            this.btnItemListPrint.Name = "btnItemListPrint";
            this.btnItemListPrint.Size = new System.Drawing.Size(118, 40);
            this.btnItemListPrint.TabIndex = 6;
            this.btnItemListPrint.Text = "&Print";
            this.btnItemListPrint.UseVisualStyleBackColor = true;
            this.btnItemListPrint.Visible = false;
            this.btnItemListPrint.Click += new System.EventHandler(this.btnItemListPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EBusiness.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(6, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(276, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(328, 32);
            this.label16.TabIndex = 0;
            this.label16.Text = "Search / View Items";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtItemCode.ForeColor = System.Drawing.Color.Black;
            this.txtItemCode.Location = new System.Drawing.Point(278, 81);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(317, 24);
            this.txtItemCode.TabIndex = 42;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtItemName.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.Location = new System.Drawing.Point(278, 119);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(317, 24);
            this.txtItemName.TabIndex = 43;
            // 
            // txtPacking
            // 
            this.txtPacking.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtPacking.ForeColor = System.Drawing.Color.Black;
            this.txtPacking.Location = new System.Drawing.Point(279, 230);
            this.txtPacking.Name = "txtPacking";
            this.txtPacking.Size = new System.Drawing.Size(317, 24);
            this.txtPacking.TabIndex = 46;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchasePrice.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtPurchasePrice.ForeColor = System.Drawing.Color.Black;
            this.txtPurchasePrice.Location = new System.Drawing.Point(280, 264);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(317, 24);
            this.txtPurchasePrice.TabIndex = 47;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtSalePrice.ForeColor = System.Drawing.Color.Black;
            this.txtSalePrice.Location = new System.Drawing.Point(280, 301);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(317, 24);
            this.txtSalePrice.TabIndex = 48;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtDiscount.Location = new System.Drawing.Point(280, 337);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(317, 24);
            this.txtDiscount.TabIndex = 49;
            this.txtDiscount.Text = "0.00";
            // 
            // txtMinStock
            // 
            this.txtMinStock.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtMinStock.ForeColor = System.Drawing.Color.Black;
            this.txtMinStock.Location = new System.Drawing.Point(280, 374);
            this.txtMinStock.Name = "txtMinStock";
            this.txtMinStock.Size = new System.Drawing.Size(317, 24);
            this.txtMinStock.TabIndex = 50;
            this.txtMinStock.Text = "0";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtBatchNo.ForeColor = System.Drawing.Color.Black;
            this.txtBatchNo.Location = new System.Drawing.Point(278, 403);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(317, 24);
            this.txtBatchNo.TabIndex = 53;
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblBatchNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBatchNo.Location = new System.Drawing.Point(166, 402);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(103, 18);
            this.lblBatchNo.TabIndex = 52;
            this.lblBatchNo.Text = "Batch No : ";
            this.lblBatchNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblExpiryDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblExpiryDate.Location = new System.Drawing.Point(145, 431);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(126, 18);
            this.lblExpiryDate.TabIndex = 54;
            this.lblExpiryDate.Text = "Expiry Date : ";
            this.lblExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtExpiryDate
            // 
            this.dtExpiryDate.CalendarFont = new System.Drawing.Font("Verdana", 8F);
            this.dtExpiryDate.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.dtExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpiryDate.Location = new System.Drawing.Point(278, 433);
            this.dtExpiryDate.Name = "dtExpiryDate";
            this.dtExpiryDate.Size = new System.Drawing.Size(108, 20);
            this.dtExpiryDate.TabIndex = 55;
            // 
            // chkitemView
            // 
            this.chkitemView.AutoSize = true;
            this.chkitemView.Checked = true;
            this.chkitemView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkitemView.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkitemView.ForeColor = System.Drawing.Color.Green;
            this.chkitemView.Location = new System.Drawing.Point(8, 63);
            this.chkitemView.Name = "chkitemView";
            this.chkitemView.Size = new System.Drawing.Size(100, 17);
            this.chkitemView.TabIndex = 0;
            this.chkitemView.Text = "Active Only";
            this.chkitemView.UseVisualStyleBackColor = true;
            this.chkitemView.CheckedChanged += new System.EventHandler(this.chkitemView_CheckedChanged);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.ForeColor = System.Drawing.Color.Green;
            this.lblSupplierName.Location = new System.Drawing.Point(616, 197);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(0, 13);
            this.lblSupplierName.TabIndex = 56;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Green;
            this.lblCompanyName.Location = new System.Drawing.Point(610, 196);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(0, 23);
            this.lblCompanyName.TabIndex = 57;
            // 
            // cbSearchByCode
            // 
            this.cbSearchByCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearchByCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchByCode.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbSearchByCode.FormattingEnabled = true;
            this.cbSearchByCode.Location = new System.Drawing.Point(149, 100);
            this.cbSearchByCode.Name = "cbSearchByCode";
            this.cbSearchByCode.Size = new System.Drawing.Size(520, 24);
            this.cbSearchByCode.TabIndex = 6;
            this.cbSearchByCode.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            this.cbSearchByCode.Leave += new System.EventHandler(this.cbSearchByCode_Leave);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 635);
            this.ControlBox = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItem";
            this.Text = "Item and Item Type Information";
            this.tcMain.ResumeLayout(false);
            this.tpView.ResumeLayout(false);
            this.tpNew.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.tpNewItemType.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tpSearchItemType.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemTypesData)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIsActive;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbItemType;
        private System.Windows.Forms.ComboBox cbCompany;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label lblSelectCompany;
        private System.Windows.Forms.ComboBox cbAllNewUpdate;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbNew;
        protected System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TabPage tpNewItemType;
        private System.Windows.Forms.TabPage tpSearchItemType;
        protected System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Button btnNewItemType;
        protected System.Windows.Forms.Button btnCancelItemType;
        private System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.DataGridView dgvItemTypesData;
        protected System.Windows.Forms.Label lblItemTypeId;
        protected System.Windows.Forms.Label lblSelectItemType;
        private System.Windows.Forms.ComboBox cboAllItemTypes;
        private System.Windows.Forms.RadioButton rbUpdateItemType;
        private System.Windows.Forms.RadioButton rbNewItemType;
        private System.Windows.Forms.CheckBox chkITemTypeIsActive;
        protected System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtItemTypeName;
        protected System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbSearchByCompany;
        private System.Windows.Forms.RadioButton rbSearchByItemType;
        private System.Windows.Forms.ComboBox cbItemSearch;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox2;
        private EBusiness.ucTextBox txtItemCode;
        private EBusiness.ucTextBox txtItemName;
        private ucTextBox txtPacking;
        private ucTextBox txtPurchasePrice;
        private ucTextBox txtSalePrice;
        private ucTextBox txtDiscount;
        private ucTextBox txtMinStock;
        protected System.Windows.Forms.Label lblExpiryDate;
        private ucTextBox txtBatchNo;
        protected System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.DateTimePicker dtExpiryDate;
        private System.Windows.Forms.CheckBox chkitemView;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.ComboBox cbSearchByCode;
        private System.Windows.Forms.CheckBox ckViewAllItems;
        protected System.Windows.Forms.Button btnItemListPrint;
    }
}