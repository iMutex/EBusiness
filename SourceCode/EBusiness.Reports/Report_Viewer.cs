using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EBusiness.BLL;

namespace EBusiness.Reports
{
    public partial class Report_Viewer : Form
    {
        int ReportId = 0;
        private ReportInfo localReportInfo = null;
        public Report_Viewer()
        {
            InitializeComponent();
        }
        public Report_Viewer(ReportInfo reportInfo)
        {
            InitializeComponent();
            localReportInfo = reportInfo;
        }

        private void Report_Viewer_Load(object sender, EventArgs e)
        {
            if (localReportInfo == null)
            {
                localReportInfo = new ReportInfo();
                localReportInfo.Report = Report.ProductDailySalePurchaseSummaryReport;
                localReportInfo.StartDate = DateTime.Now.AddMonths(-1);
                localReportInfo.EndDate = DateTime.Now;
                localReportInfo.Id = 5;
                localReportInfo.Options = "1";
            }

            LoadReport();

            this.reportViewer1.RefreshReport();
        }
        void LoadReport()
        {
            if (reportDataSource1 == null)
                reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            if (localReportInfo.StartDate != null)
                localReportInfo.StartDate = localReportInfo.StartDate.Value.Date;
            if (localReportInfo.EndDate!= null)
                localReportInfo.EndDate = localReportInfo.EndDate.Value.Date;

            switch (localReportInfo.Report)
            {
                case Report.CustomerSalesReport:
                    LoadCustomerSalesReport();
                    break;
                case Report.CustomerSalesReportDetailed:
                    LoadCustomerSalesReportDetailed();
                    break;
                case Report.ProductSaleReport:
                    LoadProductSaleReport();
                    break;
                case Report.ProductPurchaseReport:
                    LoadProductPurchaseReport(true);
                    break;
                case Report.CompanyPurchaseReportDetailed:
                    LoadProductPurchaseReport(false);
                    break;
                case Report.BuyerLedger:
                    LoadBuyerLedger();
                    break;
                case Report.BuyerLedgerProductWise:
                    LoadBuyerLedgerProductWise();
                    break;
                case Report.CompanyPurchaseReport:
                    LoadCompanyPurchaseReport();
                    break;
                case Report.CustomerTransactionsReport:
                    LoadCustomerTransactionsReport();
                    break;
                case Report.CompanyTransactionsReport:
                    LoadCompanyTransactionsReport();
                    break;

                case Report.ProductDailySalePurchaseSummaryReport:
                    LoadDailyProductSalePurchaseSummaryReport();
                    break;
                case Report.ProductInOutDetailReport:
                    LoadProductInOutDetailedReport();
                    break;
                case Report.ProductInOutSummaryReport:
                    LoadProductInOutSummaryReport();
                    break;


                case Report.DailySalesPurchase:
                    break;
                case Report.CurrentCashReport:
                    break;
                case Report.ProfitLoss:
                    break;
                default:
                    break;
            }
        }

        

        void LoadCustomerSalesReport()
        {
            reportDataSource1.Name = "CustomerSaleReportDataSet";
            reportDataSource1.Value = this.Report_CustomerSalesReport_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_CustomerSale.rdlc";

            this.Report_CustomerSalesReport_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_CustomerSalesReport_PrintBindingSource.DataMember = "Report_CustomerSalesReport_Print";
            this.Report_CustomerSalesReport_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_CustomerSalesReport_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_CustomerSalesReport_Print,localReportInfo.StartDate, localReportInfo.EndDate, localReportInfo.Id);

        }
        void LoadCustomerSalesReportDetailed()
        {
            reportDataSource1.Name = "DetailedCustomerSalesreportDataSet";
            reportDataSource1.Value = this.Report_CustomerSalesReportDetailed_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_CustomerSaleDetailed.rdlc";

            this.Report_CustomerSalesReportDetailed_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_CustomerSalesReportDetailed_PrintBindingSource.DataMember = "Report_CustomerSalesReportDetailed_Print";
            this.Report_CustomerSalesReportDetailed_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_CustomerSalesReportDetailed_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_CustomerSalesReportDetailed_Print, localReportInfo.StartDate, localReportInfo.EndDate, localReportInfo.Id);
        }
        void LoadProductSaleReport()
        {
            reportDataSource1.Name = "ProductSaleDataSet";
            reportDataSource1.Value = this.Report_ProductSalesReport_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_ProductSale.rdlc";

            this.Report_ProductSalesReport_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_ProductSalesReport_PrintBindingSource.DataMember = "Report_ProductSalesReport_Print";
            this.Report_ProductSalesReport_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_ProductSalesReport_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_ProductSalesReport_Print, localReportInfo.StartDate, localReportInfo.EndDate, localReportInfo.Id);
        }
        void LoadProductPurchaseReport( bool IsProductReport)
        {
            reportDataSource1.Name = "ProductPurchaseDataSet";
            reportDataSource1.Value = this.Report_ProductPurchaseReport_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_ProductPurchase.rdlc";

            this.Report_ProductPurchaseReport_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_ProductPurchaseReport_PrintBindingSource.DataMember = "Report_ProductPurchaseReport_Print";
            this.Report_ProductPurchaseReport_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_ProductPurchaseReport_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_ProductPurchaseReport_Print, localReportInfo.StartDate, localReportInfo.EndDate, localReportInfo.Id, IsProductReport);

        }
        void LoadBuyerLedger()
        {
            reportDataSource1.Name = "BuyerLedgerDataSet";
            reportDataSource1.Value = this.Report_BuyerLedger_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_BuyerLedger.rdlc";

            this.Report_BuyerLedger_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_BuyerLedger_PrintBindingSource.DataMember = "Report_BuyerLedger_Print";
            this.Report_BuyerLedger_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_BuyerLedger_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_BuyerLedger_Print, localReportInfo.StartDate, localReportInfo.EndDate, localReportInfo.Id);

        }

        void LoadBuyerLedgerProductWise()
        {
            reportDataSource1.Name = "BuyerLedgerDataSet";
            reportDataSource1.Value = this.Report_BuyerLedgerProductWise_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_BuyerLedger.rdlc";

            this.Report_BuyerLedgerProductWise_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_BuyerLedgerProductWise_PrintBindingSource.DataMember = "Report_BuyerLedgerProductWise_Print";
            this.Report_BuyerLedgerProductWise_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_BuyerLedgerProductWise_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_BuyerLedgerProductWise_Print, localReportInfo.StartDate, localReportInfo.EndDate, localReportInfo.Id);

        }

        void LoadCompanyPurchaseReport()
        {
            reportDataSource1.Name = "CompanyPurchaseReportDataSet";
            reportDataSource1.Value = this.Report_CompanyPurchaseReport_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_CompanyPurchase.rdlc";

            this.Report_CompanyPurchaseReport_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_CompanyPurchaseReport_PrintBindingSource.DataMember = "Report_CompanyPurchaseReport_Print";
            this.Report_CompanyPurchaseReport_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_CompanyPurchaseReport_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_CompanyPurchaseReport_Print, localReportInfo.StartDate, localReportInfo.EndDate, localReportInfo.Id);

        }
        void LoadCustomerTransactionsReport()
        {
            reportDataSource1.Name = "CustomerTransactionDataSet";
            reportDataSource1.Value = this.Report_CustomerTransactions_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_CustomerTransaction.rdlc";

            this.Report_CustomerTransactions_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_CustomerTransactions_PrintBindingSource.DataMember = "Report_CustomerTransactions_Print";
            this.Report_CustomerTransactions_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_CustomerTransactions_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_CustomerTransactions_Print, localReportInfo.Id, localReportInfo.StartDate, localReportInfo.EndDate);

        }
        void LoadCompanyTransactionsReport()
        {
            reportDataSource1.Name = "CompanyTransactionDataSet";
            reportDataSource1.Value = this.Report_CompanyTransactions_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_CompanyTransaction.rdlc";

            this.Report_CompanyTransactions_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_CompanyTransactions_PrintBindingSource.DataMember = "Report_CompanyTransactions_Print";
            this.Report_CompanyTransactions_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_CompanyTransactions_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_CompanyTransactions_Print, localReportInfo.Id, localReportInfo.StartDate, localReportInfo.EndDate);
        }


        void LoadDailyProductSalePurchaseSummaryReport()
        {
            try
            {

            
            reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Report_ProductDailyPurchaseReport_PrintBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Report_ProductDailySaleReport_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_DailyProductSalePurchaseSummary.rdlc";

            this.Report_ProductDailyPurchaseReport_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_ProductDailyPurchaseReport_PrintBindingSource.DataMember = "Report_ProductDailyPurchaseReport_Print";
            this.Report_ProductDailyPurchaseReport_PrintBindingSource.DataSource = this.EBusinessDataSet;
            try
            {
                this.Report_ProductDailyPurchaseReport_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_ProductDailyPurchaseReport_Print, localReportInfo.StartDate, localReportInfo.EndDate, Convert.ToInt32(localReportInfo.Options));
            }
            catch (Exception)
            {
                
            }
                

            this.Report_ProductDailySaleReport_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_ProductDailySaleReport_PrintBindingSource.DataMember = "Report_ProductDailySaleReport_Print";
            this.Report_ProductDailySaleReport_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_ProductDailySaleReport_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_ProductDailySaleReport_Print, localReportInfo.StartDate, localReportInfo.EndDate, Convert.ToInt32(localReportInfo.Options));

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        void LoadProductInOutDetailedReport()
        {
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Report_ProductInOutDetailedReport_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_ProductInOutDetail.rdlc";

            this.Report_ProductInOutDetailedReport_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_ProductInOutDetailedReport_PrintBindingSource.DataMember = "Report_ProductInOutDetailedReport_Print";
            this.Report_ProductInOutDetailedReport_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_ProductInOutDetailedReport_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_ProductInOutDetailedReport_Print, localReportInfo.StartDate, localReportInfo.EndDate, localReportInfo.Id);
        }
        private void LoadProductInOutSummaryReport()
        {
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Report_ProductInOutSummaryReport_PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EBusiness.Reports.Report_ProductInOutSummary.rdlc";

            this.Report_ProductInOutSummaryReport_PrintTableAdapter.ClearBeforeFill = true;
            this.Report_ProductInOutSummaryReport_PrintBindingSource.DataMember = "Report_ProductInOutSummaryReport_Print";
            this.Report_ProductInOutSummaryReport_PrintBindingSource.DataSource = this.EBusinessDataSet;
            this.Report_ProductInOutSummaryReport_PrintTableAdapter.Fill(this.EBusinessDataSet.Report_ProductInOutSummaryReport_Print, localReportInfo.StartDate, localReportInfo.EndDate, localReportInfo.Id);
        }
        void LoadCurrentCashReport()
        { }
        void LoadProfitLoss()
        { }
        void LoadDailySalesPurchase()
        { }


    }
}