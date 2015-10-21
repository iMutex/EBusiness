using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EBusiness.BLL;

namespace EBusiness.Reports
{
    public partial class SalesPurchaseReportControl : ReportControl
    {
        private static int flag = 0;
        Report selectedReport;
        Item item = null;
        Company company = null;
        Customer customer = null;
        Report report = Report.CompanyPurchaseReport;
        AnalysisReports reportEngine = null;
        bool IsPurchase = false;
        public SalesPurchaseReportControl()
        {
            Initialize(false);
        }
        public SalesPurchaseReportControl(bool isPurchase, Report report)
        {
            selectedReport = report;
            Initialize(isPurchase);
        }
        private void Initialize(bool isPurchase)
        {
            InitializeComponent();
            IsPurchase = isPurchase;
            item = new Item();
            company = new Company();
            customer = new Customer();
            if (flag == 3)
            {
                report = Report.BuyerLedger;
                SetReports();
                cbReport.SelectedIndex = 3;
            }
            else if (flag == 2)
            {
                report = Report.ProductSaleReport;
                SetReports();
                cbReport.SelectedIndex = 2;

            }
            else if (flag == 1)
            {
                report = Report.ProductPurchaseReport;
                SetReports();
                cbReport.SelectedIndex = 1;
            }
            else if (flag == 0)
            {
                report = Report.CustomerSalesReport;
                SetReports();
                cbReport.SelectedIndex = 0;
            }

        }

        void SetReports()
        {
            reportEngine = new AnalysisReports();
            LoadReportsCombo();

        }

        public static void SetFlag(int value)
        {
            flag = value;
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            lblTotal.Visible = false;
            lblTotalValue.Visible = false;
            lblTotalValue.Text = string.Empty;
            switch (cbReport.SelectedIndex)
            {
                case 0:
                    report = IsPurchase ? Report.CompanyPurchaseReport : Report.CustomerSalesReport;
                    break;
                case 1:
                    report = IsPurchase ? Report.CompanyPurchaseReportDetailed : Report.CustomerSalesReportDetailed;
                    break;
                case 2:
                    report = IsPurchase ? Report.ProductPurchaseReport : Report.ProductSaleReport;
                    break;
                case 3:
                    report = Report.BuyerLedger;
                    break;
                case 4:
                    report = Report.BuyerLedgerProductWise;
                    lblTotal.Visible = true;
                    lblTotalValue.Visible = true;
                    break;
                default:
                    break;
            }
            SetReport();


        }



        #region Methods

        void LoadReportsCombo()
        {
            cbReport.Items.Clear();
            if (!IsPurchase)
            {
                cbReport.Items.Add("Customer Sales Report");
                cbReport.Items.Add("Customer Sales Report Detailed");
                cbReport.Items.Add("Product Sales Report");
                cbReport.Items.Add("Buyer Ledger");
                cbReport.Items.Add("Buyer Ledger Product Wise");
            }
            else
            {
                cbReport.Items.Add("Supplier Purchase Report");
                cbReport.Items.Add("Supplier Purchase Report Detailed");
                cbReport.Items.Add("Product Purchase Report");

            }
            cbReport.SelectedIndex = 0;
        }
        void SetReport()
        {
            DataTable dt = null;
            dgvData.DataSource = null;
            string displayMember = string.Empty;
            string valueMember = string.Empty;
            cbSelect.DataSource = null;
            switch (report)
            {
                case Report.ProductSaleReport:
                    Common.BindItemCombo(ref cbSelect, true);
                    lblSelect.Text = "Item:";
                    lblReportHeader.Text = "Item Sales Report";
                    break;
                case Report.CustomerSalesReport:
                    Common.BindCustomerComboOnlyActive(ref cbSelect, true);
                    lblSelect.Text = "Customer:";
                    lblReportHeader.Text = "Customer Sales Report";
                    break;
                case Report.CustomerSalesReportDetailed:
                    Common.BindCustomerComboOnlyActive(ref cbSelect, true);
                    lblSelect.Text = "Customer:";
                    lblReportHeader.Text = "Customer Sales Report Detailed";
                    break;
                case Report.BuyerLedger:
                    Common.BindCustomerComboOnlyActive(ref cbSelect, true);
                    lblSelect.Text = "Customer:";
                    lblReportHeader.Text = "Buyer Ledger";
                    break;
                case Report.BuyerLedgerProductWise:
                    Common.BindItemCombo(ref cbSelect, false);
                    lblSelect.Text = "Item:";
                    lblReportHeader.Text = "Buyer Ledger Item Wise";
                    break;

                case Report.ProductPurchaseReport:
                    Common.BindItemCombo(ref cbSelect, true);
                    lblSelect.Text = "Item:";
                    lblReportHeader.Text = "Item Purchase Report";
                    break;
                case Report.CompanyPurchaseReport:
                    Common.BindCompanyComboOnlyActive(ref cbSelect, true);
                    lblSelect.Text = "Supplier:";
                    lblReportHeader.Text = "Supplier Purchase Report";
                    break;
                case Report.CompanyPurchaseReportDetailed:
                    Common.BindCompanyComboOnlyActive(ref cbSelect, true);
                    lblSelect.Text = "Supplier:";
                    lblReportHeader.Text = "Supplier Purchase Report Detailed";
                    break;


                default:
                    dt = null;
                    displayMember = string.Empty;
                    valueMember = string.Empty;
                    cbSelect.DataSource = null;
                    dgvData.DataSource = null;
                    break;
            }
        }

        #endregion

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.SalesPurchaseReportControl, "GetData", ex, "SalePurchaseReportControl Exception");
            }
        }

        private void GetData()
        {
            DataTable dt = null;
            dgvData.DataSource = dt;
            DateTime? startDate = dtpStartDate.Value;
            DateTime? endDate = dtpEndDate.Value;
            if (chkAllDates.Checked)
            {
                startDate = null;
                endDate = null;
            }
            string strId = string.IsNullOrEmpty(cbSelect.ValueMember) ? string.Empty : Convert.ToString(((DataRowView)(cbSelect.SelectedItem)).Row[cbSelect.ValueMember]);//Convert.ToString(cbSelect.SelectedValue);
            string currencyColumns = string.Empty;

            switch (report)
            {
                case Report.ProductSaleReport:
                    dt = reportEngine.ProductSalesPurchaseReport(startDate, endDate, strId, false);
                    currencyColumns = "SalePrice,Total,Quantity";
                    break;
                case Report.CustomerSalesReport:
                    dt = reportEngine.CustomerSalesReport(startDate, endDate, strId, false);
                    currencyColumns = "GrandTotal,Payment";
                    break;
                case Report.CustomerSalesReportDetailed:
                    dt = reportEngine.CustomerSalesReport(startDate, endDate, strId, true);
                    currencyColumns = "SalePrice,Total,Quantity";
                    break;
                case Report.BuyerLedger:
                    dt = reportEngine.BuyerLedger(startDate, endDate, strId);
                    currencyColumns = "Quantity";
                    break;
                case Report.BuyerLedgerProductWise:
                    dt = reportEngine.BuyerLedgerProductWise(startDate, endDate, strId);
                    currencyColumns = "Quantity";
                    break;
                case Report.CompanyPurchaseReport:
                    dt = reportEngine.CompanyPurchaseReport(startDate, endDate, strId, false);
                    currencyColumns = "Total,Payment";
                    break;
                case Report.ProductPurchaseReport:
                    dt = reportEngine.ProductSalesPurchaseReport(startDate, endDate, strId, true);
                    currencyColumns = "PurchasePrice,Total,Quantity";
                    break;
                case Report.CompanyPurchaseReportDetailed:
                    dt = reportEngine.CompanyPurchaseReport(startDate, endDate, strId, true);
                    currencyColumns = "PurchasePrice,Total,Quantity";
                    break;

                default:
                    break;
            }


            if (dt != null)
            {
                dgvData.DataSource = dt;
                Common.FormatCurrencyColumn(dgvData, currencyColumns);
                if (report == Report.BuyerLedgerProductWise)
                {
                    if (dt.Rows.Count > 0)
                    {
                        long total = 0;
                        foreach (DataGridViewRow row in dgvData.Rows)
                        {
                            total += Convert.ToInt32(row.Cells["Quantity"].Value);
                        }
                        lblTotalValue.Text = total.ToString("#0.00");
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                try
                {
                    long id = 0;
                    string selectedValue = string.IsNullOrEmpty(cbSelect.ValueMember) ? string.Empty : Convert.ToString(((DataRowView)(cbSelect.SelectedItem)).Row[cbSelect.ValueMember]);//Convert.ToString( cbSelect.SelectedValue);
                    long.TryParse(selectedValue, out id);
                    ReportInfo info = new ReportInfo();
                    info.Report = report;
                    info.StartDate = dtpStartDate.Value.Date;
                    info.EndDate = dtpEndDate.Value.Date;
                    if (chkAllDates.Checked)
                    {
                        info.StartDate = null;
                        info.EndDate = null;

                    }
                    info.Id = id;

                    Report_Viewer viewer = new Report_Viewer(info);
                    viewer.ShowDialog();
                }
                catch (Exception ex)
                {
                    ExceptionLog.LogException(Modules.SalesPurchaseReportControl, "btnPrint", ex, "SalePurchaseReportControl Exception");
                }
            }

            else
            {
                MessageBox.Show("Error ! No Record Found" + Environment.NewLine + "Please Made a valid transactions for print", "Supplier Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SalesPurchaseReportControl_Load(object sender, EventArgs e)
        {

        }

        private void cbSelect_Leave(object sender, EventArgs e)
        {
            Modules module = Modules.Customer;
            switch (report)
            {
                case Report.BuyerLedgerProductWise:
                    module = Modules.Item;
                    break;
                case Report.ProductSaleReport:
                    module = Modules.Item;
                    break;
                case Report.ProductPurchaseReport:
                    module = Modules.Item;
                    break;
                case Report.CompanyPurchaseReport:
                    module = Modules.Supplier;
                    break;
                case Report.CompanyPurchaseReportDetailed:
                    module = Modules.Supplier;
                    break;
                default:
                    break;
            }

            if (Common.IsValidCode(cbSelect, module, true) > 0)
            {
                dgvData.DataSource = null;
            }

        }



    }
}
