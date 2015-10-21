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
    public partial class ReportsApp : Form
    {

        AnalysisReports analysisReports = new AnalysisReports();
        Report report;
        public ReportsApp()
        {
            InitializeComponent();
            //report = Report.SalesReport;
            // SetHeaderandCombo("SalesReport");
        }

        #region Events
        //One event for all report buttons
        private void Report_Click(object sender, EventArgs e)
        {
            string button = ((Button)(sender)).Text;
            switch (button)
            {
                //case "Sales Report":
                //    report = Report.SalesReport;
                //    break;
                //case "Purchase Report":
                //    report = Report.PurchaseReport;
                //    break;
                case "Daily Sale Purchase":
                    report = Report.DailySalesPurchase;
                    break;
                case @"Profit / Loss":
                    report = Report.ProfitLoss;

                    break;
                //case "Product Report":
                //    report = Report.ProductReport;

                    break;
                case "Buyer Ledger":
                    report = Report.BuyerLedger;

                    break;
                case "Current Cash":
                    report = Report.CurrentCashReport;

                    break;
                default:
                    break;
            }
            LoadReportControl(report);

        }

        #endregion

        private void LoadReportControl(Report reportControl)
        {
            panelReportControl.Controls.Clear();
            Control ctrl = null;


            switch (reportControl)
            {
                //case Report.SalesReport:
                //    ctrl = new SalesPurchaseReportControl(false);
                //    break;
                //case Report.PurchaseReport:
                //    ctrl = new SalesPurchaseReportControl(true);
                //    break;
                case Report.DailySalesPurchase:
                    ctrl = new DailySalesPurchaseReport();
                    break;
                case Report.ProfitLoss:
                    ctrl = new ProfitLossReportControl();
                    break;
                case Report.CustomerTransactionsReport:
                    break;
                case Report.CompanyTransactionsReport:
                    break;
                //case Report.ProductReport:
                //    break;
                case Report.BuyerLedger:
                    break;
                case Report.CurrentCashReport:
                    CurrentCashReport ccr = new CurrentCashReport();
                    ccr.ShowDialog();
                    break;
                default:
                    break;
            }

            if (ctrl != null)
            {
                ctrl.Dock = DockStyle.Fill;
                panelReportControl.Controls.Add(ctrl);
            }

        }

        private void btnCustomerTransaction_Click(object sender, EventArgs e)
        {
            panelReportControl.Controls.Clear();
            TransactionReportControl ctrl = new TransactionReportControl(true);
            ctrl.Dock = DockStyle.Fill;
            panelReportControl.Controls.Add(ctrl);
        }

        private void btnCompanyTransaction_Click(object sender, EventArgs e)
        {
            panelReportControl.Controls.Clear();
            TransactionReportControl ctrl = new TransactionReportControl(false);
            ctrl.Dock = DockStyle.Fill;
            panelReportControl.Controls.Add(ctrl);
        }

    }
}
