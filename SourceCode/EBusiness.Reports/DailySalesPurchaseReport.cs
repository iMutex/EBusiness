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
    public partial class DailySalesPurchaseReport : ReportControl
    {
        AnalysisReports reportEngine = null;
        public DailySalesPurchaseReport()
        {
            InitializeComponent();
        }

        private void DailySalesPurchaseReport_Load(object sender, EventArgs e)
        {
            reportEngine = new AnalysisReports();
            splitContainer.SplitterDistance = panel3.Width / 2;
            cbSelect.SelectedIndex = 0;
            Common.BindItemCombo(ref cboProduct, true);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.DailySalesPurchaseReport, "GetData", ex, "DailySalesPurchaseReport Exception");
            }
        }

        private void GetData()
        {
            DataSet ds = null;
            dgvPurchase.DataSource = null;
            dgvSales.DataSource = null;
            DateTime? startDate = dtpStartDate.Value.Date;
            DateTime? endDate = dtpEndDate.Value.Date;
            if (chkAllDates.Checked)
            {
                startDate = null;
                endDate = null;

            }
            Int32 indexValue = cbSelect.SelectedIndex;
            if (indexValue < 3)
            {
                ds = reportEngine.DailySalePurchaseReport(startDate, endDate, indexValue);
            }
            else
            {
                string Id = string.IsNullOrEmpty(cboProduct.ValueMember) ? string.Empty : cboProduct.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cboProduct.SelectedItem)).Row[cboProduct.ValueMember]);
                ds = reportEngine.DailySalePurchaseProductSummaryReport(startDate, endDate, Id);
            }
            if (ds != null)
            {
                DataTable dtPurchase = ds.Tables[0];
                DataTable dtSales = ds.Tables[1];
                if (dtPurchase != null)
                {
                    dgvPurchase.DataSource = dtPurchase;
                    Common.FormatCurrencyColumn(dgvPurchase, "Total");
                }
                if (dtSales != null)
                {
                    dgvSales.DataSource = dtSales;
                    Common.FormatCurrencyColumn(dgvSales, "Total");
                }

                if (dgvPurchase.Rows.Count > 0)
                {
                    int index = dgvPurchase.ColumnCount - 1;
                    double totalPurchase = 0.0;
                    foreach (DataGridViewRow dr in dgvPurchase.Rows)
                    {
                        totalPurchase += Convert.ToDouble(dr.Cells[index].Value);
                    }
                    lblTotalPurchase.Text = totalPurchase.ToString("#0.00");
                }
                if (dgvSales.Rows.Count > 0)
                {
                    int index = dgvSales.ColumnCount - 1;
                    double totalSale = 0.0;
                    foreach (DataGridViewRow dr in dgvSales.Rows)
                    {
                        totalSale += Convert.ToDouble(dr.Cells[index].Value);
                    }
                    lblTotalSale.Text = totalSale.ToString("#0.00");
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvPurchase.Rows.Count > 0 || dgvSales.Rows.Count > 0)
            {
                try
                {
                    long id = 0;
                    string selectedValue = string.IsNullOrEmpty(cboProduct.ValueMember) ? string.Empty : Convert.ToString(((DataRowView)(cboProduct.SelectedItem)).Row[cboProduct.ValueMember]);//Convert.ToString( cbSelect.SelectedValue);
                    long.TryParse(selectedValue, out id);
                    ReportInfo info = new ReportInfo();
                    info.Report = Report.ProductDailySalePurchaseSummaryReport ;
                    info.StartDate = dtpStartDate.Value.Date;
                    info.EndDate = dtpEndDate.Value.Date;
                    if (chkAllDates.Checked)
                    {
                        info.StartDate = null;
                        info.EndDate = null;
                    }
                    info.Options = selectedValue;

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

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Visible = cbSelect.SelectedIndex == 3;
            cboProduct.Visible = cbSelect.SelectedIndex == 3;
            btnPrint.Visible = cbSelect.SelectedIndex == 3;
        }


    }
}
