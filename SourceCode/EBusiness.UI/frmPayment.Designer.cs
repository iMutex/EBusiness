namespace EBusiness
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.rbCustomerPayment = new System.Windows.Forms.RadioButton();
            this.rbCompanyPayment = new System.Windows.Forms.RadioButton();
            this.rbDebit = new System.Windows.Forms.RadioButton();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCustomersSuppliers = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnCancelPayment = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.rbCustomerPayment);
            this.panel5.Controls.Add(this.rbCompanyPayment);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(633, 57);
            this.panel5.TabIndex = 31;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Blue;
            this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(633, 57);
            this.label25.TabIndex = 3;
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbCustomerPayment
            // 
            this.rbCustomerPayment.AutoSize = true;
            this.rbCustomerPayment.BackColor = System.Drawing.Color.Transparent;
            this.rbCustomerPayment.Checked = true;
            this.rbCustomerPayment.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.rbCustomerPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbCustomerPayment.Location = new System.Drawing.Point(87, 15);
            this.rbCustomerPayment.Name = "rbCustomerPayment";
            this.rbCustomerPayment.Size = new System.Drawing.Size(233, 27);
            this.rbCustomerPayment.TabIndex = 32;
            this.rbCustomerPayment.TabStop = true;
            this.rbCustomerPayment.Text = "Customer Payment";
            this.rbCustomerPayment.UseVisualStyleBackColor = false;
            this.rbCustomerPayment.CheckedChanged += new System.EventHandler(this.rbCustomerPayment_CheckedChanged);
            // 
            // rbCompanyPayment
            // 
            this.rbCompanyPayment.AutoSize = true;
            this.rbCompanyPayment.BackColor = System.Drawing.Color.Transparent;
            this.rbCompanyPayment.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.rbCompanyPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbCompanyPayment.Location = new System.Drawing.Point(326, 15);
            this.rbCompanyPayment.Name = "rbCompanyPayment";
            this.rbCompanyPayment.Size = new System.Drawing.Size(220, 27);
            this.rbCompanyPayment.TabIndex = 31;
            this.rbCompanyPayment.Text = "Supplier Payment";
            this.rbCompanyPayment.UseVisualStyleBackColor = false;
            // 
            // rbDebit
            // 
            this.rbDebit.AutoSize = true;
            this.rbDebit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.rbDebit.ForeColor = System.Drawing.Color.Red;
            this.rbDebit.Location = new System.Drawing.Point(233, 248);
            this.rbDebit.Name = "rbDebit";
            this.rbDebit.Size = new System.Drawing.Size(86, 27);
            this.rbDebit.TabIndex = 45;
            this.rbDebit.Text = "Debit";
            this.rbDebit.UseVisualStyleBackColor = true;
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Checked = true;
            this.rbCredit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.rbCredit.ForeColor = System.Drawing.Color.Green;
            this.rbCredit.Location = new System.Drawing.Point(325, 248);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(93, 27);
            this.rbCredit.TabIndex = 44;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Credit";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.Red;
            this.lblBalance.Location = new System.Drawing.Point(241, 214);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(23, 17);
            this.lblBalance.TabIndex = 43;
            this.lblBalance.Text = "   ";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label29.Location = new System.Drawing.Point(130, 216);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(88, 18);
            this.label29.TabIndex = 42;
            this.label29.Text = "Balance: ";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(241, 179);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(23, 17);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "   ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label26.Location = new System.Drawing.Point(148, 178);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 18);
            this.label26.TabIndex = 40;
            this.label26.Text = "Name: ";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtComments.ForeColor = System.Drawing.Color.Black;
            this.txtComments.Location = new System.Drawing.Point(233, 322);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(281, 84);
            this.txtComments.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(101, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 18);
            this.label13.TabIndex = 39;
            this.label13.Text = "Comments : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(233, 89);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(281, 24);
            this.dtpDate.TabIndex = 32;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(233, 281);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(281, 24);
            this.txtAmount.TabIndex = 34;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(126, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Amount : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCustomersSuppliers
            // 
            this.cbCustomersSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomersSuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomersSuppliers.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbCustomersSuppliers.FormattingEnabled = true;
            this.cbCustomersSuppliers.Location = new System.Drawing.Point(233, 134);
            this.cbCustomersSuppliers.Name = "cbCustomersSuppliers";
            this.cbCustomersSuppliers.Size = new System.Drawing.Size(281, 24);
            this.cbCustomersSuppliers.Sorted = true;
            this.cbCustomersSuppliers.TabIndex = 33;
            this.cbCustomersSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbCustomersSuppliers_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(152, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 37;
            this.label11.Text = "Date : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(146, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 18);
            this.label12.TabIndex = 36;
            this.label12.Text = "Select: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMakePayment.BackgroundImage")));
            this.btnMakePayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePayment.ForeColor = System.Drawing.Color.Blue;
            this.btnMakePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnMakePayment.Image")));
            this.btnMakePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakePayment.Location = new System.Drawing.Point(380, 443);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(110, 51);
            this.btnMakePayment.TabIndex = 46;
            this.btnMakePayment.Text = "Save";
            this.btnMakePayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btnCancelPayment
            // 
            this.btnCancelPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelPayment.BackgroundImage")));
            this.btnCancelPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPayment.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelPayment.Image")));
            this.btnCancelPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelPayment.Location = new System.Drawing.Point(496, 443);
            this.btnCancelPayment.Name = "btnCancelPayment";
            this.btnCancelPayment.Size = new System.Drawing.Size(125, 51);
            this.btnCancelPayment.TabIndex = 47;
            this.btnCancelPayment.Text = "Cancel";
            this.btnCancelPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelPayment.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 506);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.btnCancelPayment);
            this.Controls.Add(this.rbDebit);
            this.Controls.Add(this.rbCredit);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbCustomersSuppliers);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.Text = "Make a Payment";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbCustomerPayment;
        private System.Windows.Forms.RadioButton rbCompanyPayment;
        protected System.Windows.Forms.Label label25;
        private System.Windows.Forms.RadioButton rbDebit;
        private System.Windows.Forms.RadioButton rbCredit;
        protected System.Windows.Forms.Label lblBalance;
        protected System.Windows.Forms.Label label29;
        protected System.Windows.Forms.Label lblName;
        protected System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtComments;
        protected System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAmount;
        protected System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCustomersSuppliers;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label12;
        protected System.Windows.Forms.Button btnMakePayment;
        protected System.Windows.Forms.Button btnCancelPayment;


    }
}