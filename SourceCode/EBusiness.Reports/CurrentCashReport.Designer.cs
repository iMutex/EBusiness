namespace EBusiness.Reports
{
    partial class CurrentCashReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentCashReport));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShop = new System.Windows.Forms.Button();
            this.txtCashInHand = new System.Windows.Forms.TextBox();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPurchase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomersBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompaniesBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 57);
            this.panel2.TabIndex = 50;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Crimson;
            this.lblHeader.Image = ((System.Drawing.Image)(resources.GetObject("lblHeader.Image")));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(454, 57);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Current Cash Report";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 68);
            this.panel1.TabIndex = 49;
            // 
            // btnShop
            // 
            this.btnShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShop.BackgroundImage")));
            this.btnShop.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnShop.Image = ((System.Drawing.Image)(resources.GetObject("btnShop.Image")));
            this.btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.Location = new System.Drawing.Point(270, 0);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(184, 68);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "OK";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // txtCashInHand
            // 
            this.txtCashInHand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCashInHand.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtCashInHand.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCashInHand.Location = new System.Drawing.Point(194, 259);
            this.txtCashInHand.Name = "txtCashInHand";
            this.txtCashInHand.ReadOnly = true;
            this.txtCashInHand.Size = new System.Drawing.Size(248, 24);
            this.txtCashInHand.TabIndex = 48;
            this.txtCashInHand.TabStop = false;
            this.txtCashInHand.Text = "0.00";
            this.txtCashInHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTotalSale.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalSale.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTotalSale.Location = new System.Drawing.Point(194, 211);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(248, 24);
            this.txtTotalSale.TabIndex = 46;
            this.txtTotalSale.TabStop = false;
            this.txtTotalSale.Text = "0.00";
            this.txtTotalSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(1, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cash In Hand : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(1, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Total  Sale : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalPurchase
            // 
            this.txtTotalPurchase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTotalPurchase.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalPurchase.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPurchase.Location = new System.Drawing.Point(194, 164);
            this.txtTotalPurchase.Name = "txtTotalPurchase";
            this.txtTotalPurchase.ReadOnly = true;
            this.txtTotalPurchase.Size = new System.Drawing.Size(248, 24);
            this.txtTotalPurchase.TabIndex = 44;
            this.txtTotalPurchase.TabStop = false;
            this.txtTotalPurchase.Text = "0.00";
            this.txtTotalPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Total Purchase : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomersBalance
            // 
            this.txtCustomersBalance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCustomersBalance.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtCustomersBalance.Location = new System.Drawing.Point(192, 122);
            this.txtCustomersBalance.Name = "txtCustomersBalance";
            this.txtCustomersBalance.ReadOnly = true;
            this.txtCustomersBalance.Size = new System.Drawing.Size(248, 24);
            this.txtCustomersBalance.TabIndex = 42;
            this.txtCustomersBalance.TabStop = false;
            this.txtCustomersBalance.Text = "0.00";
            this.txtCustomersBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(-1, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Customer Balance : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCompaniesBalance
            // 
            this.txtCompaniesBalance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCompaniesBalance.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.txtCompaniesBalance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtCompaniesBalance.Location = new System.Drawing.Point(192, 76);
            this.txtCompaniesBalance.Name = "txtCompaniesBalance";
            this.txtCompaniesBalance.ReadOnly = true;
            this.txtCompaniesBalance.Size = new System.Drawing.Size(248, 24);
            this.txtCompaniesBalance.TabIndex = 40;
            this.txtCompaniesBalance.TabStop = false;
            this.txtCompaniesBalance.Text = "0.00";
            this.txtCompaniesBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(-1, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Companies Balance : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentCashReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 373);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCashInHand);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalPurchase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomersBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCompaniesBalance);
            this.Controls.Add(this.label6);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 411);
            this.MinimizeBox = false;
            this.Name = "CurrentCashReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Current Cash Report";
            this.Load += new System.EventHandler(this.CurrentCashReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.TextBox txtCashInHand;
        private System.Windows.Forms.TextBox txtTotalSale;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPurchase;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomersBalance;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCompaniesBalance;
        protected System.Windows.Forms.Label label6;
    }
}