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
    public partial class ProfitLossReportControl : ReportControl
    {
        AnalysisReports reportEngine = null;
        public ProfitLossReportControl()
        {
            InitializeComponent();
        }

        private void BusinessProdfitLossReportControl_Load(object sender, EventArgs e)
        {
            reportEngine = new AnalysisReports();
            string[] levels = Enum.GetNames(typeof(ReportLevel));
            foreach (string level in levels)
            {
                cbSelect.Items.Add(level);
            }
            if (cbSelect.Items != null && cbSelect.Items.Count > 0)
                cbSelect.SelectedIndex = 0;
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.ProfitLossReportControl, "GetData", ex, "ProfitLossReportControl Exception");
            }
        }

        private void GetData()
        {
            DataTable dt = null;
            double profitLoss = 0.0;
            dgvData.DataSource = dt;
            DateTime? startDate = dtpStartDate.Value;
            DateTime? endDate = dtpEndDate.Value;
            if (chkAllDates.Checked)
            {
                startDate = null;
                endDate = null;
            }
            string strlevel = Convert.ToString(cbSelect.SelectedIndex);
            dt = reportEngine.ProfitLoassReport(startDate, endDate, strlevel);
            if (dt != null )
            {
                dgvData.DataSource = dt;
                string cols = "TotalProfitLoss";
                switch (cbSelect.SelectedIndex)
                {
                    case 5:
                        cols = "ProfitLoss,Quantity";
                        break;
                    case 6:
                        cols = "PurchasePrice,SalePrice,ProfitLoss,Quantity";
                        break;
                    default:
                        break;
                }
                Common.FormatCurrencyColumn(dgvData, cols);
                int index = dt.Columns.Count - 1;
                foreach (DataRow dr in dt.Rows)
                {
                    if (profitLoss != 0.0)
                    {
                        profitLoss += Convert.ToDouble(dr[index]);
                    }
                }
                if (profitLoss < 0)
                    lblProfitLoss.Text = "Total Loss";
                lblProfitLossAmount.Text = profitLoss.ToString(@"#0.00");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    PrintReports printreports = new PrintReports();
            //    printreports.PrintReport(dgvData);
            //}
            //catch (Exception ex)
            //{
            //    ExceptionLog.LogException(Modules.ProfitLossReportControl, "btnPrint", ex, "ProfitLossReportControl Exception");
            //}
            PrintDGV.Print_DataGridView(dgvData, "Profit Loss Report");
        }

        private void cbSelect_Leave(object sender, EventArgs e)
        {

        }

        private void cbSelect_Leave_1(object sender, EventArgs e)
        {

        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chkAllDates.Checked)
            {
                label1.Visible = cbSelect.SelectedIndex < 7;
                label7.Visible = cbSelect.SelectedIndex < 7;
                dtpStartDate.Visible = cbSelect.SelectedIndex < 7;
                dtpEndDate.Visible = cbSelect.SelectedIndex < 7;
            }
        }

       

       

       
    }
}
