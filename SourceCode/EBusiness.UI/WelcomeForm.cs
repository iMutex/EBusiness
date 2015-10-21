using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EBusiness.BLL;
using EBusiness.Reports;
using System.IO;

namespace EBusiness
{
    public partial class WelcomeForm : Form
    {

        Shop shop = new Shop();
        int seconds = 0;
        //Login login = null;
        public WelcomeForm()
        {
            //login = new Login();
            //login.ShowDialog();

            InitializeComponent();
            lblWatch.Text = DateTime.Now.ToString("hh:mm:ss");
            SetRights();
        }


        public WelcomeForm(bool result)
        {

            if (result)
            {
                InitializeComponent();
                lblWatch.Text = DateTime.Now.ToString("hh:mm:ss");
                Common.ShowModelDialogs = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.ShowDashBoard);
                SetRights();
            }

        }

        private void SetRights()
        {

            initializeDatabaseToolStripMenuItem.Visible = Common.CURRENT_USER.IsSuperAdmin;
            createDatabaseToolStripMenuItem.Visible = Common.CURRENT_USER.IsSuperAdmin;
            registerTrialToolStripMenuItem.Visible = Common.CURRENT_USER.IsSuperAdmin;
            registerToolStripMenuItem.Visible = Common.CURRENT_USER.IsSuperAdmin;
            unRegisterToolStripMenuItem.Visible = Common.CURRENT_USER.IsSuperAdmin;

            toolStrip_Reports.Visible = Common.CURRENT_USER.AllowReports;

            btnCompany.Visible = Common.CURRENT_USER.AllowCompany;
            toolStripSeparator4.Visible = Common.CURRENT_USER.AllowCompany;

            btnCustomer.Visible = Common.CURRENT_USER.AllowCustomer;
            toolStripSeparator3.Visible = Common.CURRENT_USER.AllowCustomer;

            btnInvoice.Visible = Common.CURRENT_USER.AllowInvoice;
            toolStripSeparator14.Visible = Common.CURRENT_USER.AllowInvoice;

            btnItem.Visible = Common.CURRENT_USER.AllowItem;
            toolStripSeparator2.Visible = Common.CURRENT_USER.AllowItem;

            btnShop.Visible = Common.CURRENT_USER.AllowShop;
            toolStripSeparator6.Visible = Common.CURRENT_USER.AllowShop;

            btnStock.Visible = Common.CURRENT_USER.AllowStock;
            toolStripSeparator1.Visible = Common.CURRENT_USER.AllowStock;

            btnOrder.Visible = Common.CURRENT_USER.AllowOrder;
            toolStripSeparator5.Visible = Common.CURRENT_USER.AllowOrder;

            manageUserToolStripMenuItem.Visible = Common.CURRENT_USER.AllowUserManagement;

            /*
            if (!Common.CURRENT_USER.AllowReports)
            {
                btnSalesReport.Visible = false;
                btnPurchaseReport.Visible = false;
                btnDailySalesReport.Visible = false;
                btnBuyerLedgerReport.Visible = false;
                btnCustomerTransaction.Visible = false;
                btnCompanyTransaction.Visible = false;
                btnProfitReport.Visible = false;
                btnCurrentCashReport.Visible = false;

               toolStrip_Reports.Visible = false;
            }
            if (!Common.CURRENT_USER.AllowCompany)
            {
                btnCompany.Visible = false;
                toolStripSeparator4.Visible = false;
            }
            if (!Common.CURRENT_USER.AllowCustomer)
            {
                btnCustomer.Visible = false;
                toolStripSeparator3.Visible = false;
            }
            if (!Common.CURRENT_USER.AllowInvoice)
            {
                btnInvoice.Visible = false;
                toolStripSeparator14.Visible = false;
            }
            if (!Common.CURRENT_USER.AllowItem)
            {
                btnItem.Visible = false;
                toolStripSeparator2.Visible = false;
            }
            if (!Common.CURRENT_USER.AllowShop)
            {
                btnShop.Visible = false;
                toolStripSeparator6.Visible = false;
            }
            if (!Common.CURRENT_USER.AllowStock)
            {
                btnStock.Visible = false;
                toolStripSeparator1.Visible = false;
            }
            if (!Common.CURRENT_USER.AllowUserManagement)
            {
                manageUserToolStripMenuItem.Visible = false;
            }
            */
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            string button = ((ToolStripButton)sender).Name;
            ShowDialog(button);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtShop = shop.SelectAllShop();
                if (dtShop.Rows.Count != 1)
                {
                    MessageBox.Show("Error ! Please provide the shop information to continue", "Shop Information Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmShop frm = new frmShop();
                    frm.ShowDialog();
                }
                else
                {

                    ReportsForm rptForm = new ReportsForm();
                    ReportControl frm = null;
                    Form ccr = null;
                    string button = ((ToolStripButton)sender).Name;
                    switch (button)
                    {
                        //REPORTS SECTION
                        case "btnCurrentCashReport":
                            ccr = new CurrentCashReport();
                            break;
                        case "btnBuyerLedger":
                            frm = new SalesPurchaseReportControl(false, Report.Invoice);
                            break;
                        case "btnProductWiseReport":
                            frm = new SalesPurchaseReportControl(false, Report.Invoice);
                            break;
                        case "btnPurchaseReport":
                            frm = new SalesPurchaseReportControl(true, Report.Invoice);
                            break;
                        case "btnSalesReport":
                            frm = new SalesPurchaseReportControl(false, Report.Invoice);
                            break;
                        case "btnCustomerTransaction":
                            frm = new TransactionReportControl(true);
                            break;
                        case "btnCompanyTransaction":
                            frm = new TransactionReportControl(false);
                            break;
                        case "btnProfitReport":
                            frm = new ProfitLossReportControl();
                            break;
                        case "btnDailySalesReport":
                            frm = new DailySalesPurchaseReport();
                            break;
                        case "btnBuyerLedgerReport":
                            frm = new SalesPurchaseReportControl(false, Report.Invoice);
                            break;
                        case "btnItemTransaction":
                            frm = new ProductTransactionReportControl();
                            break;

                        default:
                            break;
                    }
                    if (ccr != null)
                    {
                        ccr.ShowDialog();
                    }
                    else if (frm != null)
                    {
                        frm.Dock = DockStyle.Fill;
                        rptForm.panelReportControl.Controls.Add(frm);
                        this.Visible = false;
                        rptForm.ShowDialog();
                        if (!this.IsDisposed)
                            this.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.WelcomeForm, "btnReport", ex, "Welcome Form Exception");

            }
        }
        void ShowDialog(string button)
        {
            Form frm = null;
            bool ShopInfoRequired = false;
            if (button != "btnShop")
            {
                DataTable dtShop = shop.SelectAllShop();
                if (dtShop.Rows.Count != 1)
                {
                    MessageBox.Show("Error ! Please provide the shop information to continue", "Shop Information Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShopInfoRequired = true;
                    frm = new frmShop();
                }
            }
            if (!ShopInfoRequired)
            {
                switch (button)
                {
                    case "btnPOS":
                        frm = new frmPOS();
                        break;
                    case "btnSystemLog":
                        frm = new frmSystemLog();
                        break;
                    case "btnShop":
                        frm = new frmShop();
                        break;
                    case "btnUser":
                        frm = new frmUser();
                        break;
                    case "btnCompany":
                        frm = new frmCompany();
                        break;
                    case "btnCustomer":
                        frm = new frmCustomer();
                        break;
                    case "btnItem":
                        frm = new frmItem();
                        break;
                    case "btnInvoice":

                        frm = new frmInvoice();
                        break;
                    case "btnOrder":
                        frm = new frmOrder();
                        break;
                    case "btnStock":
                        frm = new frmStock();
                        break;
                    default:
                        break;
                }
            }
            if (frm != null)
            {
                //this.Visible = false;

                if (Common.ShowModelDialogs)
                {
                    frm.ShowDialog();
                    if (!this.IsDisposed)
                        this.Visible = true;
                }
                else
                {
                    frm.Show();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWatch.Text = DateTime.Now.ToString("hh:mm:ss");
            seconds++;
            if (seconds >= 60)
            {
                //if (Common.ShowDashBoard)
                //{

                //    lvSale.Items.Clear();
                //    lvPurchase.Items.Clear();

                //    PopulateDailyPurchase();
                //    PopulateDailySale();
                //    SumTotalPurchase();
                //    SumTotalSale();
                //}
                //lvStockSummary.Items.Clear();
                //PopulateStockSummary();


                SetDashBoard();
                seconds = 0;
            }
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateShopDetails();
                SetDashBoard();


            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.WelcomeForm, "WelcomeFormLoad", ex, "Welcome Form Exception");
            }
        }
        private void PopulateShopDetails()
        {
            DataTable dt = shop.SelectAllShop();
            if (dt != null && dt.Rows.Count > 0)
            {

                //lblShopName.Text = Convert.ToString(dt.Rows[0]["ShopName"]);
                //lblSologon.Text = Convert.ToString(dt.Rows[0]["ShopSlogon"]);
                ////txtShopResgistration.Text = Convert.ToString(dt.Rows[0]["RegistrationNumber"]);
                //lblAddress.Text = Convert.ToString(dt.Rows[0]["ShopAddress"]);
                //lblPhoneData.Text = Convert.ToString(dt.Rows[0]["ShopNumber"]);
                ////lblProperiterData.Text = Convert.ToString(dt.Rows[0]["Properiter"]);


                lblShopName.Text = Convert.ToString(dt.Rows[0]["ShopName"]);
                lblAdress.Text = Convert.ToString(dt.Rows[0]["ShopAddress"]);
                //txtShopResgistration.Text = Convert.ToString(dt.Rows[0]["RegistrationNumber"]);
                lblPhoneNumber.Text = Convert.ToString(dt.Rows[0]["ShopNumber"]);
                lbRegistrationNo.Text = Convert.ToString(dt.Rows[0]["RegistrationNumber"]);
                lblSologon.Text = Convert.ToString(dt.Rows[0]["ShopSlogon"]);
                //lblProperiterData.Text = Convert.ToString(dt.Rows[0]["Properiter"]);



                //for Writing copyright Symbol
                string copyright = "iMutex" + "\u00a9 2011";
                toolStripStatusLabel4.Text = copyright;

            }
        }
        private void PopulateStockSummary()
        {
            Item item = new Item();
            DataTable dt = item.SelectItemShortInStock();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listItem = new ListViewItem(dr["ItemCode"].ToString());
                    listItem.SubItems.Add(dr["ItemInStock"].ToString());
                    listItem.SubItems.Add(dr["ItemOnOrder"].ToString());
                    listItem.SubItems.Add(dr["StockLimit"].ToString());
                    lvStockSummary.Items.Add(listItem);
                }
            }
        }

        private void PopulateDailyPurchase()
        {


            Item item = new Item();
            DataTable dt = item.SelectInvoicesDateWise(null, DateTime.Now, DateTime.Now, false);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    ListViewItem listItem = new ListViewItem(dr["RowNo"].ToString());
                    listItem.SubItems.Add(dr["InvoiceNo"].ToString());
                    listItem.SubItems.Add(dr["CompanyName"].ToString());
                    listItem.SubItems.Add(Convert.ToDecimal(dr["InvoiceTotal"]).ToString("0.00"));
                    listItem.SubItems.Add(Convert.ToDecimal(dr["Payment"]).ToString("0.00"));
                    lvPurchase.Items.Add(listItem);
                }
                label4.Text = "Total Purchase     " + SumTotalPurchase().ToString("#0.00");
            }
        }


        private void PopulateDailySale()
        {
            Item item = new Item();
            DataTable dt = item.SelectReceiptsDateWise(null, DateTime.Now, DateTime.Now, false);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listItem = new ListViewItem(dr["RowNo"].ToString());
                    listItem.SubItems.Add(dr["ReceiptNo"].ToString());
                    listItem.SubItems.Add(dr["CustomerName"].ToString());
                    listItem.SubItems.Add(Convert.ToDecimal(dr["ReceiptTotal"]).ToString("0.00"));
                    listItem.SubItems.Add(Convert.ToDecimal(dr["Payment"]).ToString("0.00"));
                    lvSale.Items.Add(listItem);


                }
                label5.Text = "Total Sale      " + SumTotalSale().ToString("#0.00");
            }
        }
        private double SumTotalSale()
        {
            double sum = 0.0;

            for (int i = 0; i < lvSale.Items.Count; i++)
            {
                sum += Convert.ToDouble(lvSale.Items[i].SubItems[3].Text.ToString());
            }


            return sum;
        }
        private double SumTotalPurchase()
        {
            double sum = 0.0;

            for (int i = 0; i < lvPurchase.Items.Count; i++)
            {
                sum += Convert.ToDouble(lvPurchase.Items[i].SubItems[3].Text.ToString());
            }


            return sum;
        }

        private void SetDashBoard()
        {
            Common.ShowDashBoard = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.ShowDashBoard);

            panelToday.Visible = Common.ShowDashBoard;
            //lvStockSummary.Visible = Common.ShowDashBoard;
            //label1.Visible = Common.ShowDashBoard;
            btnRefresh.Visible = Common.ShowDashBoard;

            lvSale.Items.Clear();
            lvPurchase.Items.Clear();
            lvStockSummary.Items.Clear();
            if (Common.ShowDashBoard)
            {
                SumTotalPurchase();
                SumTotalSale();

                PopulateDailyPurchase();
                PopulateDailySale();
            }
            PopulateStockSummary();
        }

        private void WelcomeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                ReportsForm rptForm = new ReportsForm();
                ReportControl frm = null;
                Form ccr = null;

                if ((e.KeyCode ^ Keys.D0) == 0)
                {
                    frm = new SalesPurchaseReportControl(false, Report.CustomerSalesReport);
                }
                else if ((e.KeyCode ^ Keys.D1) == 0)
                {
                    frm = new SalesPurchaseReportControl(true, Report.CompanyPurchaseReport);
                }
                else if ((e.KeyCode ^ Keys.D2) == 0)
                {
                    frm = new DailySalesPurchaseReport();
                }
                else if ((e.KeyCode ^ Keys.D3) == 0)
                {
                    frm = new SalesPurchaseReportControl(false, Report.BuyerLedger);
                }
                else if ((e.KeyCode ^ Keys.D4) == 0)
                {
                    frm = new TransactionReportControl(true);
                }
                else if ((e.KeyCode ^ Keys.D5) == 0)
                {
                    frm = new TransactionReportControl(false);
                }
                else if ((e.KeyCode ^ Keys.D6) == 0)
                {
                    frm = new ProfitLossReportControl();
                }
                else if ((e.KeyCode ^ Keys.D7) == 0)
                {
                    ccr = new CurrentCashReport();
                }
                else if ((e.KeyCode ^ Keys.D8) == 0)
                {
                    frm = new ProductTransactionReportControl();
                }

                if (ccr != null)
                {
                    this.Visible = false;
                    ccr.ShowDialog();
                    if (!this.IsDisposed)
                        this.Visible = true;
                }
                else if (frm != null)
                {
                    frm.Dock = DockStyle.Fill;
                    rptForm.panelReportControl.Controls.Add(frm);
                    this.Visible = false;
                    rptForm.ShowDialog();
                    if (!this.IsDisposed)
                        this.Visible = true;


                }
            }
            else
            {
                string button = string.Empty;
                switch (e.KeyData)
                {
                    case Keys.F1:
                        button = "btnPOS";
                        break;
                    case Keys.F2:
                        button = "btnInvoice";
                        break;
                    case Keys.F3:
                        button = "btnStock";
                        break;
                    case Keys.F4:
                        button = "btnItem";
                        break;
                    case Keys.F5:
                        button = "btnCustomer";
                        break;
                    case Keys.F6:
                        button = "btnCompany";
                        break;
                    case Keys.F7:
                        button = "btnOrder";
                        break;
                    case Keys.F8:
                        button = "btnShop";//button = "btnSystemLog";
                        break;
                    default:
                        break;
                }
                if (!string.IsNullOrEmpty(button))
                    ShowDialog(button);
            }


        }

        private void systemLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemLog systemlog = new frmSystemLog();
            systemlog.ShowDialog();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();
            frmUser.ShowDialog();
        }

        private void changePsswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChange = new frmChangePassword();
            frmChange.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.WelcomeForm, "exitToolStrip", ex, "Welcome Form Exception");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvStockSummary.Items.Clear();
            lvSale.Items.Clear();
            lvPurchase.Items.Clear();
            PopulateStockSummary();
            PopulateDailyPurchase();
            PopulateDailySale();
            SumTotalPurchase();
            SumTotalSale();
        }

        #region Database Management
        private void initializeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void createBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.DatabaseBackupLocation = ConfigurationReader.ReadKey(ConfigurationKeys.DatabaseBackupLocation);
            string fileName = DateTime.Now.Date.ToString("dd-MM-yyyy") + ".bak";
            fileName = Path.Combine(Common.DatabaseBackupLocation, fileName);
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            SuperAdmin.CreateBackup(fileName);
            MessageBox.Show("Database Backup has been Created successfully.", "Database Backup Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restoreBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog dlg = new OpenFileDialog();
                dlg.CheckFileExists = true;
                dlg.DefaultExt = "bak";
                dlg.Filter = "Backup files (*.bak)|*.bak";
                dlg.InitialDirectory = Common.DatabaseBackupLocation;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = dlg.FileName;
                    if (File.Exists(fileName))
                    {
                        SuperAdmin.RestoreBackup(fileName);
                        MessageBox.Show("Database Backup has been Restored successfully.", "Database Backup Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void userHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemLog frm = new frmSystemLog(true);
            frm.Show();
        }



    }
}
