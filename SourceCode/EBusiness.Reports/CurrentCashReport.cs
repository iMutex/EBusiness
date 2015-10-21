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
    public partial class CurrentCashReport : Form
    {
        AnalysisReports reportEngine = null;
        #region Constructor
        public CurrentCashReport()
        {
            InitializeComponent();
        }
        #endregion Constructor

        private void CurrentCashReport_Load(object sender, EventArgs e)
        {
            //CompaniesBalance,CustomerBalance , TotalPurchase , TotalSale
            DataTable dt = null;
            reportEngine = new AnalysisReports();
            dt = reportEngine.CurrentCashReport();
            if (dt != null)
            {
                txtCompaniesBalance.Text = Convert.ToDecimal(dt.Rows[0]["CompaniesBalance"]).ToString("#0.00");
                txtCustomersBalance.Text = Convert.ToDecimal(dt.Rows[0]["CustomerBalance"]).ToString("#0.00");
                txtTotalPurchase.Text = Convert.ToDecimal(dt.Rows[0]["TotalPurchase"]).ToString("#0.00");
                txtTotalSale.Text = Convert.ToDecimal(dt.Rows[0]["TotalSale"]).ToString("#0.00");
                txtCashInHand.Text = Convert.ToDecimal(dt.Rows[0]["CashInHand"]).ToString("#0.00"); 
            }
        }
        private void btnShop_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.CurrentCashReport, "btnShop", ex, "CurrentCashReport Exception");
            }
        }
    }
}
