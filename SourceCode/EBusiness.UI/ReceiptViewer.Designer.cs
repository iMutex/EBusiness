namespace EBusiness
{
    partial class ReceiptViewer
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EBusinessDataSet = new EBusiness.EBusinessDataSet();
            this.SelectReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectReceiptTableAdapter = new EBusiness.EBusinessDataSetTableAdapters.SelectReceiptTableAdapter();
            this.SelectInvoiceOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectInvoiceOrderTableAdapter = new EBusiness.EBusinessDataSetTableAdapters.SelectInvoiceOrderTableAdapter();
            this.SelectTransaction_PrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectTransaction_PrintTableAdapter = new EBusiness.EBusinessDataSetTableAdapters.SelectTransaction_PrintTableAdapter();
            this.SelectCompanyCustomer_PrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectCompanyCustomer_PrintTableAdapter = new EBusiness.EBusinessDataSetTableAdapters.SelectCompanyCustomer_PrintTableAdapter();
            this.SelectItem_PrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectItem_PrintTableAdapter = new EBusiness.EBusinessDataSetTableAdapters.SelectItem_PrintTableAdapter();
            this.StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockTableAdapter = new EBusiness.EBusinessDataSetTableAdapters.StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EBusinessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectReceiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectInvoiceOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectTransaction_PrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectCompanyCustomer_PrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectItem_PrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(669, 564);
            this.reportViewer1.TabIndex = 0;
            // 
            // EBusinessDataSet
            // 
            this.EBusinessDataSet.DataSetName = "EBusinessDataSet";
            this.EBusinessDataSet.EnforceConstraints = false;
            this.EBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectReceiptTableAdapter
            // 
            this.SelectReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // SelectInvoiceOrderTableAdapter
            // 
            this.SelectInvoiceOrderTableAdapter.ClearBeforeFill = true;
            // 
            // SelectTransaction_PrintTableAdapter
            // 
            this.SelectTransaction_PrintTableAdapter.ClearBeforeFill = true;
            // 
            // SelectCompanyCustomer_PrintTableAdapter
            // 
            this.SelectCompanyCustomer_PrintTableAdapter.ClearBeforeFill = true;
            // 
            // SelectItem_PrintTableAdapter
            // 
            this.SelectItem_PrintTableAdapter.ClearBeforeFill = true;
            // 
            // StockTableAdapter
            // 
            this.StockTableAdapter.ClearBeforeFill = true;
            // 
            // ReceiptViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 564);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceiptViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiptViewer";
            this.Load += new System.EventHandler(this.ReceiptViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EBusinessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectReceiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectInvoiceOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectTransaction_PrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectCompanyCustomer_PrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectItem_PrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1;
        private EBusinessDataSet EBusinessDataSet;

        private System.Windows.Forms.BindingSource SelectReceiptBindingSource;
        private EBusinessDataSetTableAdapters.SelectReceiptTableAdapter SelectReceiptTableAdapter;

        private System.Windows.Forms.BindingSource SelectInvoiceOrderBindingSource;
        private EBusinessDataSetTableAdapters.SelectInvoiceOrderTableAdapter SelectInvoiceOrderTableAdapter;

        private System.Windows.Forms.BindingSource SelectTransaction_PrintBindingSource;
        private EBusinessDataSetTableAdapters.SelectTransaction_PrintTableAdapter SelectTransaction_PrintTableAdapter;

        private System.Windows.Forms.BindingSource SelectCompanyCustomer_PrintBindingSource;
        private EBusinessDataSetTableAdapters.SelectCompanyCustomer_PrintTableAdapter SelectCompanyCustomer_PrintTableAdapter;

        private System.Windows.Forms.BindingSource SelectItem_PrintBindingSource;
        private EBusinessDataSetTableAdapters.SelectItem_PrintTableAdapter SelectItem_PrintTableAdapter;

        private System.Windows.Forms.BindingSource StockBindingSource;
        private EBusinessDataSetTableAdapters.StockTableAdapter StockTableAdapter;


        
    }
}