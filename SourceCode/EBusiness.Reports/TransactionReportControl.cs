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
    public partial class TransactionReportControl : ReportControl
    {
        bool IsCutomerReport = false;
        public TransactionReportControl()
        {
            Initialize(true);
        }
        public TransactionReportControl(bool isCutomerReport)
        {
            Initialize(isCutomerReport);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.TransactionReportControl, "GetData", ex, "TransactionReportControl Exception");
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
            long Id = 0;
            if (long.TryParse(strId, out Id) && Id >= 0)
            {
                if (IsCutomerReport)
                {

                    FetchCustomerTransaction(dt, startDate, endDate, strId);
                }
                else
                {
                    Company comp = new Company();
                    dt = comp.SelectCompanyTransactions(Common.FormateDateForDB(startDate), Common.FormateDateForDB(endDate), strId);
                    dgvData.DataSource = dt;

                    dgvData.Columns["TransactionId"].Visible = false;
                    dgvData.Columns["TransactionDate"].HeaderText = "Date";
                    dgvData.Columns["TransactionDate"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
                    dgvData.Columns["Name"].HeaderText = "Supplier";

                    Common.FormatCurrencyColumn(dgvData, "Debit,Credit,Amount,Balance");
                }

                FormatGrid();
            }
            if (dt != null)
            {
                dgvData.DataSource = dt;
            }
        }

        private void FetchCustomerTransaction(DataTable dt, DateTime? startDate, DateTime? endDate, string strId)
        {
            Customer customer = new Customer();
            dt = customer.SelectCustomerTransactions(Common.FormateDateForDB(startDate), Common.FormateDateForDB(endDate), strId);
            dgvData.DataSource = dt;
            Common.FormatCurrencyColumn(dgvData, "Debit,Credit,Balance");
            //return dt;
        }


        private void Initialize(bool isCutomerReport)
        {
            InitializeComponent();
            IsCutomerReport = isCutomerReport;
            if (IsCutomerReport)
            {
                Common.BindCustomerComboOnlyActive(ref cbSelect, true);
                lblSelect.Text = "Customer:";
                lblReportHeader.Text = "Customer Transaction Report";
            }
            else
            {
                Common.BindCompanyComboOnlyActive(ref cbSelect, true);
                lblSelect.Text = "Supplier:";
                lblReportHeader.Text = "Supplier Transaction Report";
            }
        }

        void FormatGrid()
        {
            if (dgvData.Rows.Count > 0)
            {
                decimal debit = 0;
                decimal credit = 0;
                decimal creditamount = 0;
                decimal debitamount = 0;
                foreach (DataGridViewRow dr in dgvData.Rows)
                {
                    decimal.TryParse(Convert.ToString(dr.Cells["Credit"].Value), out creditamount);
                    decimal.TryParse(Convert.ToString(dr.Cells["Debit"].Value), out debitamount);
                    if (debitamount < 0)
                    {
                        dr.Cells["Debit"].Style.ForeColor = Color.Red;
                    }
                    debit -= debitamount;
                    credit += creditamount;
                }

                decimal finalBalance = credit - debit;
                lblCredit.Text = credit.ToString("0.00");
                lblDebit.Text = debit.ToString("0.00");
                lblDebit.ForeColor = Color.Red;
                lblFinalBalance.Text = finalBalance.ToString("0.00");
                lblFinalBalance.ForeColor = Color.Black;
                if (finalBalance < 0)
                    lblFinalBalance.ForeColor = Color.Red;


            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                try
                {
                    long id = 0;
                    string selectedValue = string.IsNullOrEmpty(cbSelect.ValueMember) ? string.Empty : Convert.ToString(((DataRowView)(cbSelect.SelectedItem)).Row[cbSelect.ValueMember]);//Convert.ToString(cbSelect.SelectedValue);
                    long.TryParse(selectedValue, out id);
                    ReportInfo info = new ReportInfo();
                    if (IsCutomerReport)
                        info.Report = Report.CustomerTransactionsReport;
                    else
                        info.Report = Report.CompanyTransactionsReport;
                    info.StartDate = dtpStartDate.Value;
                    info.EndDate = dtpEndDate.Value;
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
                    ExceptionLog.LogException(Modules.TransactionReportControl, "btnPrint", ex, "TransactionReportControl Exception");
                }
            }
            else
            {
                MessageBox.Show("Error ! No Record Found" + Environment.NewLine + "Please Made a valid transactions for print", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSelect_Leave(object sender, EventArgs e)
        {
            Modules module = Modules.Customer;
            if(!IsCutomerReport)
                module = Modules.Supplier;
            if (Common.IsValidCode(cbSelect, module, true) > 0)
            {
                dgvData.DataSource = null;
            }
        }
    }
}
