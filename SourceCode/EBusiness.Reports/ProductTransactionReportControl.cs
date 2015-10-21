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
    public partial class ProductTransactionReportControl : ReportControl
    {

        AnalysisReports reportEngine = null;
        public ProductTransactionReportControl()
        {
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
            Common.BindItemCombo(ref cbSelect, false);
            lblSelect.Text = "Select Item:";
            lblReportHeader.Text = "Product Transaction Report";
            reportEngine = new AnalysisReports();
            cbReport.SelectedIndex = 0;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.TransactionReportControl, "GetData", ex, "ProductTransactionReportControl Exception");
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
            string strId = string.IsNullOrEmpty(cbSelect.ValueMember) ? string.Empty : Convert.ToString(((DataRowView)(cbSelect.SelectedItem)).Row[cbSelect.ValueMember]);
            long Id = 0;
            if (long.TryParse(strId, out Id) && Id >= 0)
            {
                if (reportEngine == null)
                    reportEngine = new AnalysisReports();
                if (cbReport.SelectedIndex == 0)
                {
                    dt = reportEngine.ProductTransactionDetailedReprot(Common.FormateDateForDB(startDate), Common.FormateDateForDB(endDate), strId);
                }
                else
                {
                    dt = reportEngine.ProductTransactionSummaryReprot(Common.FormateDateForDB(startDate), Common.FormateDateForDB(endDate), strId);
                }
            }
            if (dt != null)
            {
                dgvData.DataSource = dt;
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
                    if (cbReport.SelectedIndex == 1)
                        info.Report = Report.ProductInOutSummaryReport;
                    else
                        info.Report = Report.ProductInOutDetailReport;
                    info.StartDate = dtpStartDate.Value.Date;
                    info.EndDate = dtpEndDate.Value.Date;
                    if (chkAllDates.Checked)
                    {
                        info.StartDate = null;
                        info.EndDate = null;
                    }
                    info.Options = selectedValue;
                    info.Id = Convert.ToInt64(selectedValue);
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

        private void ProductTransactionReportControl_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
