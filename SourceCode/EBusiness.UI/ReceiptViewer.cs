using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EBusiness.BLL;

namespace EBusiness
{
    public partial class ReceiptViewer : Form
    {
        private ReportInfo localReportInfo = null;
        public ReceiptViewer()
        {
            InitializeComponent();
        }
        public ReceiptViewer(ReportInfo info)
        {
            InitializeComponent();
            localReportInfo = info;
        }
        private void ReceiptViewer_Load(object sender, EventArgs e)
        {
            //localReportInfo = new ReportInfo() { Options="0,0", Report=Report.CompanyCustomerList};
            if (reportDataSource1 == null)
                reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            switch (localReportInfo.Report)
            {
                case Report.Receipt:
                    LoadReceipt();
                    break;
                case Report.Invoice:
                    LoadInvoiceOrder(true);
                    break;
                case Report.Order:
                    LoadInvoiceOrder(false);
                    break;
                case Report.Payment:
                    LoadPayment();
                    break;
                case Report.CompanyCustomerList:
                    LoadConpanyCustomerList();
                    break;
                case Report.ItemList:
                    LoadItemList();
                    break;
                case Report.ItemListBySupplier:
                    LoadItemListBySupplier();
                    break;
                    //ItemListBySupplier
                case Report.Stock:
                    LoadStock();
                    break;
                default:
                    break;
            }

            //LoadReceipt();
            //LoadInvoiceOrder(true);
            this.reportViewer1.RefreshReport();
        }


        void LoadReceipt()
        {
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectReceiptBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.ReceiptPrint.rdlc";
             
            this.SelectReceiptTableAdapter.ClearBeforeFill = true;
            this.SelectReceiptBindingSource.DataMember = "SelectReceipt";
            this.SelectReceiptBindingSource.DataSource = this.EBusinessDataSet;
            this.SelectReceiptTableAdapter.Fill(this.EBusinessDataSet.SelectReceipt, localReportInfo.Id, null, null, null);

        }
        void LoadInvoiceOrder(bool IsInvoice)
        {
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectInvoiceOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.ReportInvoiceOrder.rdlc";

            this.SelectInvoiceOrderTableAdapter.ClearBeforeFill = true;
            this.SelectInvoiceOrderBindingSource.DataMember = "SelectInvoiceOrder";
            this.SelectInvoiceOrderBindingSource.DataSource = this.EBusinessDataSet;
            this.SelectInvoiceOrderTableAdapter.Fill(this.EBusinessDataSet.SelectInvoiceOrder, localReportInfo.Id, null, null, null, IsInvoice);

        }
        void LoadPayment()
        {
            try
            {
                short IsCustomer = Convert.ToInt16(localReportInfo.Options);
            
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectTransaction_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.PaymentPrint.rdlc";

            this.SelectTransaction_PrintTableAdapter.ClearBeforeFill = true;
            this.SelectTransaction_PrintBindingSource.DataMember = "SelectTransaction_Print";
            this.SelectTransaction_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.SelectTransaction_PrintTableAdapter.Fill(this.EBusinessDataSet.SelectTransaction_Print, localReportInfo.Id, IsCustomer);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        void LoadConpanyCustomerList( )
        {
            try
            {
                string[] arr = localReportInfo.Options.Split(',');
                bool OnlyActive = arr[0]=="1";
                bool IsCompany = arr[1]=="1";

                reportDataSource1.Name = "DataSet1";
                reportDataSource1.Value = this.SelectCompanyCustomer_PrintBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.ReportCompanyCustomerList.rdlc";

                this.SelectCompanyCustomer_PrintTableAdapter.ClearBeforeFill = true;
                this.SelectCompanyCustomer_PrintBindingSource.DataMember = "SelectCompanyCustomer_Print";
                this.SelectCompanyCustomer_PrintBindingSource.DataSource = this.EBusinessDataSet;
                this.SelectCompanyCustomer_PrintTableAdapter.Fill(this.EBusinessDataSet.SelectCompanyCustomer_Print, null, null, null, OnlyActive, IsCompany);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        void LoadItemList()
        {
            try
            {
                string[] arr = localReportInfo.Options.Split(',');
                int OnlyActive = 0;
                int.TryParse(localReportInfo.Options, out OnlyActive);

                reportDataSource1.Name = "DataSet1";
                reportDataSource1.Value = this.SelectItem_PrintBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.PrintItemList.rdlc";

                this.SelectItem_PrintTableAdapter.ClearBeforeFill = true;
                this.SelectItem_PrintBindingSource.DataMember = "SelectItem_Print";
                this.SelectItem_PrintBindingSource.DataSource = this.EBusinessDataSet;
                this.SelectItem_PrintTableAdapter.Fill(this.EBusinessDataSet.SelectItem_Print, OnlyActive, 0);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        void LoadItemListBySupplier()
        {
            try
            {
                int CompanyId = 0;
                int.TryParse(localReportInfo.Options, out CompanyId);

                reportDataSource1.Name = "DataSet1";
                reportDataSource1.Value = this.SelectItem_PrintBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.PrintItemList.rdlc";

                this.SelectItem_PrintTableAdapter.ClearBeforeFill = true;
                this.SelectItem_PrintBindingSource.DataMember = "SelectItem_Print";
                this.SelectItem_PrintBindingSource.DataSource = this.EBusinessDataSet;
                this.SelectItem_PrintTableAdapter.Fill(this.EBusinessDataSet.SelectItem_Print, 1, CompanyId);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        void LoadStock()
        {
            try
            {
                reportDataSource1.Name = "DataSet1";
                reportDataSource1.Value = this.StockBindingSource;
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.StockReport.rdlc";

                this.StockTableAdapter.ClearBeforeFill = true;
                this.StockBindingSource.DataMember = "Stock";
                this.StockBindingSource.DataSource = this.EBusinessDataSet;
                this.StockTableAdapter.Fill(this.EBusinessDataSet.Stock, localReportInfo.Options, true );
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        
    
    }
}
