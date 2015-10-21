namespace EBusiness
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.chkUserManagement = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.chkShop = new System.Windows.Forms.CheckBox();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.chkInvoice = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSelectCompany = new System.Windows.Forms.Label();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.chkItem = new System.Windows.Forms.CheckBox();
            this.cbSelectUser = new System.Windows.Forms.ComboBox();
            this.chkOrder = new System.Windows.Forms.CheckBox();
            this.chkCustomerPayment = new System.Windows.Forms.CheckBox();
            this.chkCompanyPayment = new System.Windows.Forms.CheckBox();
            this.chkReturnSale = new System.Windows.Forms.CheckBox();
            this.chkReturnPurchase = new System.Windows.Forms.CheckBox();
            this.tcMain.SuspendLayout();
            this.tpView.SuspendLayout();
            this.tpNew.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(542, 24);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tcMain
            // 
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Size = new System.Drawing.Size(984, 569);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(815, 21);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.TabIndex = 103;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(701, 21);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.TabIndex = 102;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbSearchByCode
            // 
            this.rbSearchByCode.Location = new System.Drawing.Point(76, 11);
            this.rbSearchByCode.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchByCode.Size = new System.Drawing.Size(118, 17);
            this.rbSearchByCode.Text = "Search by Name";
            // 
            // rbSearchByName
            // 
            this.rbSearchByName.Location = new System.Drawing.Point(243, 11);
            this.rbSearchByName.Margin = new System.Windows.Forms.Padding(4);
            this.rbSearchByName.Size = new System.Drawing.Size(144, 17);
            this.rbSearchByName.Text = "Search by UserName";
            // 
            // rbAll
            // 
            this.rbAll.Location = new System.Drawing.Point(417, 11);
            this.rbAll.Margin = new System.Windows.Forms.Padding(4);
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // tpView
            // 
            this.tpView.Margin = new System.Windows.Forms.Padding(4);
            this.tpView.Padding = new System.Windows.Forms.Padding(4);
            this.tpView.Size = new System.Drawing.Size(976, 543);
            // 
            // tpNew
            // 
            this.tpNew.Margin = new System.Windows.Forms.Padding(4);
            this.tpNew.Padding = new System.Windows.Forms.Padding(4);
            this.tpNew.Size = new System.Drawing.Size(976, 543);
            // 
            // lblHeader
            // 
            this.lblHeader.Image = ((System.Drawing.Image)(resources.GetObject("lblHeader.Image")));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Size = new System.Drawing.Size(968, 57);
            this.lblHeader.Text = "User Management";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.chkReturnPurchase);
            this.gbMain.Controls.Add(this.chkReturnSale);
            this.gbMain.Controls.Add(this.chkCustomerPayment);
            this.gbMain.Controls.Add(this.chkCompanyPayment);
            this.gbMain.Controls.Add(this.chkOrder);
            this.gbMain.Controls.Add(this.cbSelectUser);
            this.gbMain.Controls.Add(this.chkItem);
            this.gbMain.Controls.Add(this.txtRePassword);
            this.gbMain.Controls.Add(this.label8);
            this.gbMain.Controls.Add(this.txtPassword);
            this.gbMain.Controls.Add(this.label7);
            this.gbMain.Controls.Add(this.chkUserManagement);
            this.gbMain.Controls.Add(this.chkReports);
            this.gbMain.Controls.Add(this.chkShop);
            this.gbMain.Controls.Add(this.chkCustomer);
            this.gbMain.Controls.Add(this.chkCompany);
            this.gbMain.Controls.Add(this.chkStock);
            this.gbMain.Controls.Add(this.chkInvoice);
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.txtAddress);
            this.gbMain.Controls.Add(this.label15);
            this.gbMain.Controls.Add(this.lblId);
            this.gbMain.Controls.Add(this.lblSelectCompany);
            this.gbMain.Controls.Add(this.rbUpdate);
            this.gbMain.Controls.Add(this.rbNew);
            this.gbMain.Controls.Add(this.txtUserName);
            this.gbMain.Controls.Add(this.label6);
            this.gbMain.Controls.Add(this.txtContactNumber);
            this.gbMain.Controls.Add(this.label5);
            this.gbMain.Controls.Add(this.chkIsActive);
            this.gbMain.Controls.Add(this.txtFullName);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Location = new System.Drawing.Point(4, 61);
            this.gbMain.Margin = new System.Windows.Forms.Padding(4);
            this.gbMain.Padding = new System.Windows.Forms.Padding(4);
            this.gbMain.Size = new System.Drawing.Size(968, 402);
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(397, 7);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Visible = false;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(504, 5);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(152, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Size = new System.Drawing.Size(356, 26);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(99, 22);
            // 
            // gbSearch
            // 
            this.gbSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSearch.Location = new System.Drawing.Point(4, 4);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearch.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearch.Size = new System.Drawing.Size(968, 81);
            // 
            // chkUserManagement
            // 
            this.chkUserManagement.AutoSize = true;
            this.chkUserManagement.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkUserManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkUserManagement.Location = new System.Drawing.Point(402, 372);
            this.chkUserManagement.Name = "chkUserManagement";
            this.chkUserManagement.Size = new System.Drawing.Size(143, 17);
            this.chkUserManagement.TabIndex = 100;
            this.chkUserManagement.Text = "User Management";
            this.chkUserManagement.UseVisualStyleBackColor = true;
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkReports.ForeColor = System.Drawing.Color.Olive;
            this.chkReports.Location = new System.Drawing.Point(403, 349);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(76, 17);
            this.chkReports.TabIndex = 97;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            // 
            // chkShop
            // 
            this.chkShop.AutoSize = true;
            this.chkShop.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkShop.Location = new System.Drawing.Point(483, 349);
            this.chkShop.Name = "chkShop";
            this.chkShop.Size = new System.Drawing.Size(58, 17);
            this.chkShop.TabIndex = 98;
            this.chkShop.Text = "Shop";
            this.chkShop.UseVisualStyleBackColor = true;
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkCustomer.Location = new System.Drawing.Point(551, 349);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(88, 17);
            this.chkCustomer.TabIndex = 99;
            this.chkCustomer.Text = "Customer";
            this.chkCustomer.UseVisualStyleBackColor = true;
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkCompany.Location = new System.Drawing.Point(551, 326);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(86, 17);
            this.chkCompany.TabIndex = 96;
            this.chkCompany.Text = "Company";
            this.chkCompany.UseVisualStyleBackColor = true;
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkStock.Location = new System.Drawing.Point(483, 326);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(62, 17);
            this.chkStock.TabIndex = 95;
            this.chkStock.Text = "Stock";
            this.chkStock.UseVisualStyleBackColor = true;
            // 
            // chkInvoice
            // 
            this.chkInvoice.AutoSize = true;
            this.chkInvoice.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkInvoice.ForeColor = System.Drawing.Color.Green;
            this.chkInvoice.Location = new System.Drawing.Point(402, 326);
            this.chkInvoice.Name = "chkInvoice";
            this.chkInvoice.Size = new System.Drawing.Size(75, 17);
            this.chkInvoice.TabIndex = 94;
            this.chkInvoice.Text = "Invoice";
            this.chkInvoice.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(228, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "Access Rights:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(403, 152);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAddress.Size = new System.Drawing.Size(259, 38);
            this.txtAddress.TabIndex = 89;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(228, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 18);
            this.label15.TabIndex = 71;
            this.label15.Text = "Address : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.DarkGray;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblId.Location = new System.Drawing.Point(241, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(75, 19);
            this.lblId.TabIndex = 70;
            this.lblId.Text = "0";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblId.Visible = false;
            // 
            // lblSelectCompany
            // 
            this.lblSelectCompany.AutoSize = true;
            this.lblSelectCompany.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectCompany.ForeColor = System.Drawing.Color.Navy;
            this.lblSelectCompany.Location = new System.Drawing.Point(228, 64);
            this.lblSelectCompany.Name = "lblSelectCompany";
            this.lblSelectCompany.Size = new System.Drawing.Size(123, 18);
            this.lblSelectCompany.TabIndex = 69;
            this.lblSelectCompany.Text = "Select User : ";
            this.lblSelectCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSelectCompany.Visible = false;
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.rbUpdate.ForeColor = System.Drawing.Color.Blue;
            this.rbUpdate.Location = new System.Drawing.Point(537, 33);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(104, 27);
            this.rbUpdate.TabIndex = 64;
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
            this.rbNew.Location = new System.Drawing.Point(429, 33);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(76, 27);
            this.rbNew.TabIndex = 63;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(403, 196);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(259, 23);
            this.txtUserName.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(228, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "User Name : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtContactNumber.ForeColor = System.Drawing.Color.Black;
            this.txtContactNumber.Location = new System.Drawing.Point(403, 123);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(259, 23);
            this.txtContactNumber.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(228, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Contact Number : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Location = new System.Drawing.Point(403, 94);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(259, 23);
            this.txtFullName.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(228, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Full Name : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(403, 225);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(259, 23);
            this.txtPassword.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(228, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "Password : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtRePassword.ForeColor = System.Drawing.Color.Black;
            this.txtRePassword.Location = new System.Drawing.Point(403, 254);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(259, 23);
            this.txtRePassword.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(228, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "Re-Enter Password : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.ForeColor = System.Drawing.Color.Crimson;
            this.chkIsActive.Location = new System.Drawing.Point(402, 283);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(108, 30);
            this.chkIsActive.TabIndex = 93;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // chkItem
            // 
            this.chkItem.AutoSize = true;
            this.chkItem.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkItem.ForeColor = System.Drawing.Color.Lime;
            this.chkItem.Location = new System.Drawing.Point(801, 349);
            this.chkItem.Name = "chkItem";
            this.chkItem.Size = new System.Drawing.Size(57, 17);
            this.chkItem.TabIndex = 101;
            this.chkItem.Text = "Item";
            this.chkItem.UseVisualStyleBackColor = true;
            // 
            // cbSelectUser
            // 
            this.cbSelectUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelectUser.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbSelectUser.FormattingEnabled = true;
            this.cbSelectUser.Location = new System.Drawing.Point(403, 67);
            this.cbSelectUser.Name = "cbSelectUser";
            this.cbSelectUser.Size = new System.Drawing.Size(259, 24);
            this.cbSelectUser.Sorted = true;
            this.cbSelectUser.TabIndex = 86;
            this.cbSelectUser.Visible = false;
            this.cbSelectUser.SelectedIndexChanged += new System.EventHandler(this.cbSelectUser_SelectedIndexChanged);
            // 
            // chkOrder
            // 
            this.chkOrder.AutoSize = true;
            this.chkOrder.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkOrder.ForeColor = System.Drawing.Color.Red;
            this.chkOrder.Location = new System.Drawing.Point(801, 326);
            this.chkOrder.Name = "chkOrder";
            this.chkOrder.Size = new System.Drawing.Size(63, 17);
            this.chkOrder.TabIndex = 102;
            this.chkOrder.Text = "Order";
            this.chkOrder.UseVisualStyleBackColor = true;
            // 
            // chkCustomerPayment
            // 
            this.chkCustomerPayment.AutoSize = true;
            this.chkCustomerPayment.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkCustomerPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkCustomerPayment.Location = new System.Drawing.Point(645, 349);
            this.chkCustomerPayment.Name = "chkCustomerPayment";
            this.chkCustomerPayment.Size = new System.Drawing.Size(149, 17);
            this.chkCustomerPayment.TabIndex = 104;
            this.chkCustomerPayment.Text = "Customer Payment";
            this.chkCustomerPayment.UseVisualStyleBackColor = true;
            // 
            // chkCompanyPayment
            // 
            this.chkCompanyPayment.AutoSize = true;
            this.chkCompanyPayment.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkCompanyPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkCompanyPayment.Location = new System.Drawing.Point(645, 326);
            this.chkCompanyPayment.Name = "chkCompanyPayment";
            this.chkCompanyPayment.Size = new System.Drawing.Size(147, 17);
            this.chkCompanyPayment.TabIndex = 103;
            this.chkCompanyPayment.Text = "Company Payment";
            this.chkCompanyPayment.UseVisualStyleBackColor = true;
            // 
            // chkReturnSale
            // 
            this.chkReturnSale.AutoSize = true;
            this.chkReturnSale.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkReturnSale.ForeColor = System.Drawing.Color.Purple;
            this.chkReturnSale.Location = new System.Drawing.Point(551, 372);
            this.chkReturnSale.Name = "chkReturnSale";
            this.chkReturnSale.Size = new System.Drawing.Size(101, 17);
            this.chkReturnSale.TabIndex = 105;
            this.chkReturnSale.Text = "Return Sale";
            this.chkReturnSale.UseVisualStyleBackColor = true;
            // 
            // chkReturnPurchase
            // 
            this.chkReturnPurchase.AutoSize = true;
            this.chkReturnPurchase.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.chkReturnPurchase.ForeColor = System.Drawing.Color.Red;
            this.chkReturnPurchase.Location = new System.Drawing.Point(669, 372);
            this.chkReturnPurchase.Name = "chkReturnPurchase";
            this.chkReturnPurchase.Size = new System.Drawing.Size(133, 17);
            this.chkReturnPurchase.TabIndex = 106;
            this.chkReturnPurchase.Text = "Return Purchase";
            this.chkReturnPurchase.UseVisualStyleBackColor = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.ControlBox = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUser";
            this.Text = "User Management";
            this.tcMain.ResumeLayout(false);
            this.tpView.ResumeLayout(false);
            this.tpNew.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUserManagement;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.CheckBox chkShop;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.CheckBox chkCompany;
        private System.Windows.Forms.CheckBox chkStock;
        private System.Windows.Forms.CheckBox chkInvoice;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label lblId;
        protected System.Windows.Forms.Label lblSelectCompany;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.TextBox txtUserName;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContactNumber;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRePassword;
        protected System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.CheckBox chkItem;
        private System.Windows.Forms.ComboBox cbSelectUser;
        private System.Windows.Forms.CheckBox chkOrder;
        private System.Windows.Forms.CheckBox chkCustomerPayment;
        private System.Windows.Forms.CheckBox chkCompanyPayment;
        private System.Windows.Forms.CheckBox chkReturnPurchase;
        private System.Windows.Forms.CheckBox chkReturnSale;


    }
}