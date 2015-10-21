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
    public partial class frmCompany : EBusiness.ParentForm
    {
        Company comp = new Company();
        BindingSource InvoiceBindingSource = new BindingSource();
        BindingSource detailsBindingSource = new BindingSource();
        private Int16 Status_Supplier;
        //DataTable companiesTable = null;

        Item item = new Item();
        public frmCompany()
        {
            InitializeComponent();
            Status_Supplier = 0;

            //BindCompanies();
            Common.BindCompanyCombo(ref cbAllNewUpdate, false);
            txtCompanyName.Focus();
            if (!Common.CURRENT_USER.AllowCompanyPayment)
                tcMain.TabPages.Remove(tpPayment);
        }

        #region Events
        private void tpPayment_Enter(object sender, EventArgs e)
        {
            try
            {
                Common.BindCompanyComboOnlyActive(ref cbCompanies, false);
                lblTransactionNo.Text = Common.GetNextId(Modules.Payment).ToString();
                //DataTable dt = (DataTable)cbCompanies.DataSource;
                //if (dt != null && dt.Rows.Count > 0)
                //{
                //    dt.Rows[0][1] = "---CASH---";
                //}
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "BindCompanyCombo", ex, "Supplier Exception");
            }
        }
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Supplier == 0)
                {
                    MakePayment();
                }
                else if (Status_Supplier != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbCompanies, Modules.Supplier);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "MakePayment", ex, "Supplier Exception");
            }
        }
        private void tpTransactions_Enter(object sender, EventArgs e)
        {
            try
            {
                Common.BindCompanyComboOnlyActive(ref cbCompaniesTransaction, true);
                dtpFrom.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "BindCompanyCombo", ex, "Supplier Exception");
            }
        }
        private void btnTransactionFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Supplier == 0)
                {
                    Search();
                }
                else if (Status_Supplier != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbCompaniesTransaction, Modules.Supplier);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "Search", ex, "Supplier Exception");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Supplier == 0)
                {
                    SaveNewUpdate();
                }
                else if (Status_Supplier != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbAllNewUpdate, Modules.Supplier);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "SaveNewUpdate", ex, "Supplier Exception");
            }

        }
        private void cbAllNewUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PopulateDetail();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "PopulateDetail", ex, "Supplier Exception");
            }
        }
        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PopulateDetail();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "PopulateDetail", ex, "Supplier Exception");
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Supplier == 0)
                {
                    Find();
                }
                else if (Status_Supplier != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbSearchByCode, Modules.Supplier);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "Find", ex, "Supplier Exception");
            }
        }
        private void btnFindInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Supplier == 0)
                {
                    GetInvoicesData();
                }
                else if (Status_Supplier != 0)
                {
                    Common.ShowInvlaidCodeMessage(cboCompaniesInvoiceSearch, Modules.Supplier);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "GetInvoicesData", ex, "Supplier Exception");
            }
        }
        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtInitialBalance.Enabled = rbNew.Checked;
                txtCode.Enabled = rbNew.Checked;
                ResetNewUpdate();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "ResetNewUpdate", ex, "Supplier Exception");
            }
        }
        private void tpSearchViewInvoices_Enter(object sender, EventArgs e)
        {
            try
            {
                Common.BindCompanyComboOnlyActive(ref cboCompaniesInvoiceSearch, true);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "BindCompanyCombo", ex, "Supplier Exception");
            }
        }
        private void cbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbCompanies.Text))
                {
                    string companyId = string.IsNullOrEmpty(cbCompanies.ValueMember) ? string.Empty : cbCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]);
                    DataTable dt = comp.SelectCompanyById(companyId);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        lblCompanyName.Text = Convert.ToString(dt.Rows[0]["CompanyName"]);
                        lblPaymentAddress.Text = Convert.ToString(dt.Rows[0]["Address"]);
                        decimal balance = 0;
                        decimal.TryParse(Convert.ToString(dt.Rows[0]["CompanyBalance"]), out balance);

                        if (balance >= 0)
                        {
                            lblCompanyBalance.ForeColor = Color.Black;
                            lblCompanyBalance.Text = balance.ToString("0.00");
                        }
                        else
                        {
                            lblCompanyBalance.ForeColor = Color.Red;
                            lblCompanyBalance.Text = balance.ToString("0.00");
                        }
                    }
                    else
                    {
                        lblCompanyName.Text = companyId;
                        lblCompanyBalance.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "SelectCompanyByCode", ex, "Supplier Exception");
            }
        }
        private void rbDebit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebit.Checked)
                txtAmount.ForeColor = Color.Red;
            else
                txtAmount.ForeColor = Color.Black;
        }
        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "btnClose", ex, "Supplier Exception");
            }

        }
        private void tpAllCompanyProducts_Enter(object sender, EventArgs e)
        {
            BindingSource CompanyBindingSource = new BindingSource();
            BindingSource productsBindingSource = new BindingSource();
            try
            {
                dgvCompanies.DataSource = CompanyBindingSource;
                dgvItems.DataSource = productsBindingSource;
                DataSet ds = comp.SelectAllCompaniesWithItems();
                if (ds != null && ds.Tables.Count == 2)
                {
                    CompanyBindingSource.DataSource = ds;
                    CompanyBindingSource.DataMember = "Company";
                    productsBindingSource.DataSource = CompanyBindingSource;
                    productsBindingSource.DataMember = "Company_Item";
                    dgvCompanies.Refresh();
                    dgvItems.Refresh();

                    dgvCompanies.Columns["CompanyId"].Visible = false;
                    dgvItems.Columns["CompanyId"].Visible = false;

                    Common.FormatCurrencyColumn(dgvCompanies, "SupplierBalance");
                    Common.FormatCurrencyColumn(dgvItems, "PurchasePrice,SalePrice");
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "SelectAllCompaniesWithItems", ex, "Supplier Exception");
            }

        }
        #endregion Events


        #region Methods
        void SaveNewUpdate()
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                if (Common.IsCodeExists(txtCode.Text, Modules.Supplier) && rbNew.Checked)
                {
                    MessageBox.Show("A Supplier already exists with code [" + txtCode.Text + "]" + Environment.NewLine + "Please try some other code.", "Supplier Already Exits", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCode.Focus();
                    return;
                }
                if (!string.IsNullOrEmpty(txtCompanyName.Text))
                {
                    decimal amount = 0;
                    if (decimal.TryParse(txtInitialBalance.Text, out amount))
                    {
                        if (comp.InsertUpdateCompany(lblCompanyId.Text, txtCode.Text, txtCompanyName.Text, txtInitialBalance.Text, chkIsActive.Checked ? "1" : "0",
                            txtContactPerson.Text, txtRemarks.Text, txtAddress.Text, txtCity.Text, txtPhone.Text, txtFax.Text, txtWeb.Text, txtEmail.Text))
                        {
                            int id = 0;
                            int.TryParse(lblCompanyId.Text, out id);
                            if (id < 1)
                            {
                                ResetNewUpdate();
                                Common.BindCompanyCombo(ref cbAllNewUpdate, false);
                            }
                            MessageBox.Show("Supplier Record saved sucessfully.", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Operation could not be completed.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Initial Balance.Please specify a valid amount.", "Invalid Balance", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        //txtInitialBalance.Text = "0.00";
                    }
                }
                else
                {
                    MessageBox.Show("Supplier Name is Required.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Supplier Code is Required.", "Code Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void Search()
        {
            string fromDate = Common.FormateDateForDB(dtpFrom.Value);
            string toDate = Common.FormateDateForDB(dtpTo.Value);
            if (chkAllTransactions.Checked)
            {
                fromDate = null;
                toDate = null;
            }
            string companyId = string.IsNullOrEmpty(cbCompaniesTransaction.ValueMember) ? string.Empty : cbCompaniesTransaction.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompaniesTransaction.SelectedItem)).Row[cbCompaniesTransaction.ValueMember]);//= cbCompaniesTransaction.SelectedValue.ToString();
            DataTable dt = comp.SelectCompanyTransactions(fromDate, toDate, companyId);
            dgvTransactions.DataSource = dt;

            //dgvTransactions.Columns["TransactionId"].Visible = false;
            dgvTransactions.Columns["TransactionId"].HeaderText = "Id";
            dgvTransactions.Columns["TransactionDate"].HeaderText = "Date";
            dgvTransactions.Columns["TransactionDate"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            dgvTransactions.Columns["Name"].HeaderText = "Supplier";

            Common.FormatCurrencyColumn(dgvTransactions, "Credit,Debit,Balance");

            if (dgvTransactions.Rows.Count > 0)
            {
                decimal debit = 0;
                decimal credit = 0;
                decimal creditamount = 0;
                decimal debitamount = 0;
                foreach (DataGridViewRow dr in dgvTransactions.Rows)
                {
                    decimal.TryParse(Convert.ToString(dr.Cells["Credit"].Value), out creditamount);
                    decimal.TryParse(Convert.ToString(dr.Cells["Debit"].Value), out debitamount);
                    if (debitamount < 0)
                    {
                        dr.Cells["Debit"].Style.ForeColor = Color.Red;
                    }
                    debit += debitamount;
                    credit += creditamount;
                }


                if (debit < 0)
                    debit = -1 * debit;
                decimal finalBalance = credit - debit;
                lblCredit.Text = credit.ToString("0.00");
                lblDebit.Text = debit.ToString("0.00");
                lblDebit.ForeColor = Color.Red;
                lblFinalBalance.Text = finalBalance.ToString("0.00");
                lblFinalBalance.ForeColor = Color.Black;
                if (finalBalance < 0)
                    lblFinalBalance.ForeColor = Color.Red;

                dgvTransactions.FirstDisplayedScrollingRowIndex = dgvTransactions.Rows.Count - 1;
            }



        }
        void PopulateDetail()
        {
            if (rbUpdate.Checked)
            {
                lblSelectCompany.Visible = true;
                cbAllNewUpdate.Visible = true;
                string Id = string.IsNullOrEmpty(cbAllNewUpdate.ValueMember) ? string.Empty : (cbAllNewUpdate.SelectedItem != null ? Convert.ToString(((DataRowView)(cbAllNewUpdate.SelectedItem)).Row[cbAllNewUpdate.ValueMember]) : string.Empty);// = Convert.ToString(cbAllNewUpdate.SelectedValue);
                lblCompanyId.Text = Id;
                if (!string.IsNullOrEmpty(Id))
                {
                    DataTable dt = comp.SelectCompanyById(Id);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        txtCode.Text = Convert.ToString(row["CompanyCode"]);
                        txtCompanyName.Text = Convert.ToString(row["CompanyName"]);
                        if (row["CompanyBalance"] != DBNull.Value)
                        {
                            txtInitialBalance.Text = string.Format("{0:0.00}", Convert.ToDecimal(row["CompanyBalance"]));
                        }
                        else
                        {
                            txtInitialBalance.Text = "0.00";
                        }

                        chkIsActive.Checked = Convert.ToBoolean(row["IsActive"]);
                        txtRemarks.Text = Convert.ToString(row["Remarks"]);
                        txtAddress.Text = Convert.ToString(row["Address"]);
                        txtContactPerson.Text = Convert.ToString(row["ContactPerson"]);
                        txtCity.Text = Convert.ToString(row["City"]);
                        txtPhone.Text = Convert.ToString(row["Phone"]);
                        txtFax.Text = Convert.ToString(row["Fax"]);
                        txtEmail.Text = Convert.ToString(row["Email"]);
                        txtWeb.Text = Convert.ToString(row["Web"]);

                        chkIsActive.Enabled = false;
                        decimal balance = 0;
                        decimal.TryParse(Convert.ToString(row["CompanyBalance"]), out balance);

                        if (balance == 0)
                        {
                            int stock = 0;
                            DataTable items = item.SelectItemByCompany(Id);
                            if (items != null && items.Rows.Count > 0)
                            {

                                foreach (DataRow dr in items.Rows)
                                {
                                    stock += Convert.ToInt32(dr["ItemInStock"]);
                                    if (stock > 0)
                                    {
                                        break;
                                    }
                                }

                            }
                            chkIsActive.Enabled = stock == 0;
                        }
                    }
                }
            }
            else
            {
                txtCode.Text = string.Empty;
                txtCompanyName.Text = string.Empty;
                txtInitialBalance.Text = "0.00";
                chkIsActive.Checked = true;
                lblSelectCompany.Visible = false;
                cbAllNewUpdate.Visible = false;
                lblCompanyId.Text = string.Empty;
            }
        }
        void ResetNewUpdate()
        {
            txtCode.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtInitialBalance.Text = "0.00";
            txtCity.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtWeb.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }
        void ResetPayment()
        {
            cbCompanies.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            txtAmount.Text = "0.00";
            txtComments.Text = string.Empty;
        }
        void Find()
        {
            DataTable dt = null;
            dgvData.DataSource = null;
            txtBalance.Text = "0.00";
            if (rbAll.Checked)
            {
                if (chkOnlyActive.Checked)
                {
                    dt = comp.SelectAllActiveCompanies();
                }
                else
                {
                    dt = comp.SelectAllCompanies();
                }
            }
            else if (rbSearchByCode.Checked)
            {
                string companyId = string.IsNullOrEmpty(cbSearchByCode.ValueMember) ? string.Empty : cbSearchByCode.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSearchByCode.SelectedItem)).Row[cbSearchByCode.ValueMember]);
                if (!string.IsNullOrEmpty(companyId))
                    dt = comp.SelectCompanyById(companyId);
                else
                    MessageBox.Show("Please enter Supplier code to search.", "Supplier Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (rbSearchByName.Checked)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                    dt = comp.SelectCompanyByName(txtSearch.Text);
                else
                    MessageBox.Show("Please enter Supplier name to search.", "Supplier Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            BindSearchGrid(dt);
        }
        void MakePayment()
        {
            try
            {


                decimal amount = 0;
                string companyId = string.IsNullOrEmpty(cbCompanies.ValueMember) ? string.Empty : cbCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]);//= cbCompanies.SelectedValue.ToString();
                string companyName = string.IsNullOrEmpty(cbCompanies.ValueMember) ? string.Empty : cbCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.DisplayMember]);//= cbCompanies.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(companyId))
                {
                    if (decimal.TryParse(txtAmount.Text, out amount) & amount != 0)
                    {
                        if (!string.IsNullOrEmpty(txtComments.Text))
                        {
                            string strAmount = txtAmount.Text;
                            if (rbDebit.Checked)
                                strAmount = "-" + strAmount;
                            long TransactioId = comp.MakePayment(companyId, Common.FormateDateForDB(dtpDate.Value), strAmount, txtComments.Text);
                            if (TransactioId > 0)
                            {
                                UserLog.Log(Common.CURRENT_USER.Id, rbCredit.Checked ? UserActions.Made_Credit_Payment_To_Supplier : UserActions.Made_Debit_Payment_To_Supplier, string.Format("Supplier : {0} , Amount : {1}, TransactionId : {2}", companyName, strAmount, TransactioId));
                                ResetPayment();
                                lblTransactionNo.Text = Common.GetNextId(Modules.Payment).ToString();
                                string msg = "Payment made successfully." + Environment.NewLine +
                                    "Do you want to print?";
                                if (MessageBox.Show(msg, "Payment Successfully Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                    == System.Windows.Forms.DialogResult.Yes)
                                {

                                    ReportInfo info = new ReportInfo() { Id = TransactioId, Report = Report.Payment, Options = "0" };
                                    ReceiptViewer print = new ReceiptViewer(info);
                                    print.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Operation could not be completed.", "Could not compete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Comments are Mendatory.", "Comments are Mendatory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtComments.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("InValid Amount.Please specify a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAmount.Text = "0.00";
                        txtAmount.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Supplier to make a payment.", "Select Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion Methods


        #region Search View Invoices and InvoiceDetails
        void GetInvoicesData()
        {
            dgvInvoices.DataSource = InvoiceBindingSource;
            dgvInvoiceDetails.DataSource = detailsBindingSource;
            string sFromDate = Common.FormateDateForDB(dtFromInvoiceSearch.Value);
            string sEndDate = Common.FormateDateForDB(dtToInvoiceSearch.Value);
            if (chkViewAllInvoices.Checked)
            {
                sFromDate = null;
                sEndDate = null;
            }
            DataSet ds = null;
            //= Convert.ToString(((DataRowView)(cbItemSearch.SelectedItem)).Row[cbItemSearch.ValueMember]);//
            if (cboCompaniesInvoiceSearch.SelectedItem != null && Convert.ToString(((DataRowView)(cboCompaniesInvoiceSearch.SelectedItem)).Row[cboCompaniesInvoiceSearch.ValueMember]) == "0")
            {
                ds = item.SelectInvoiceandInvoiceDetails(string.Empty, string.Empty, sFromDate, sEndDate, true);
            }
            else
            {
                string companyId = string.IsNullOrEmpty(cboCompaniesInvoiceSearch.ValueMember) ? string.Empty : cboCompaniesInvoiceSearch.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cboCompaniesInvoiceSearch.SelectedItem)).Row[cboCompaniesInvoiceSearch.ValueMember]);
                ds = item.SelectInvoiceandInvoiceDetails(string.Empty, companyId, sFromDate, sEndDate, false);
            }

            if (ds != null && ds.Tables.Count == 2)
            {
                InvoiceBindingSource.DataSource = ds;
                InvoiceBindingSource.DataMember = "Invoice";
                detailsBindingSource.DataSource = InvoiceBindingSource;
                detailsBindingSource.DataMember = "Invoice_InvoiceDetail";
                dgvInvoiceDetails.Columns["InvoiceId"].Visible = false;
                dgvInvoices.Refresh();
                dgvInvoiceDetails.Refresh();

                dgvInvoices.Columns["Id"].Visible = false;
                dgvInvoices.Columns["CompanyId"].Visible = false;
                dgvInvoiceDetails.Columns["ItemId"].Visible = false;
                Common.FormatCurrencyColumn(dgvInvoices, "GrandTotal,Payment,Arrears,Discount");
                Common.FormatCurrencyColumn(dgvInvoiceDetails, "PurchasePrice,Total,GrandTotal");

                if (dgvInvoices.Rows.Count > 0)
                {
                    dgvInvoices.FirstDisplayedScrollingRowIndex = dgvInvoices.Rows.Count - 1;
                    dgvInvoices.Rows[dgvInvoices.Rows.Count - 1].Selected = true;
                }
            }
        }
        #endregion Search View Invoices and InvoiceDetails

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                long Id = Convert.ToInt64(dgvInvoices.SelectedRows[0].Cells["Id"].Value);
                if (Id > 0)
                {
                    ReportInfo info = new ReportInfo();
                    info.Id = Id;
                    info.Report = Report.Invoice;
                    ReceiptViewer print = new ReceiptViewer(info);
                    print.ShowDialog();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dgvInvoices.SelectedRows.Count < 1;
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count > 0)
            {
                long Id = Convert.ToInt64(dgvTransactions.SelectedRows[0].Cells["TransactionId"].Value);
                if (Id > 0)
                {

                    ReportInfo info = new ReportInfo() { Id = Id, Report = Report.Payment, Options = "0" };
                    ReceiptViewer print = new ReceiptViewer(info);
                    print.ShowDialog();

                }
            }

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dgvTransactions.SelectedRows.Count < 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (Status_Supplier == 0 && dgvTransactions.Rows.Count > 0)
            {
                try
                {
                    long id = 0;
                    string selectedValue = string.IsNullOrEmpty(cbCompaniesTransaction.ValueMember) ? string.Empty : cbCompaniesTransaction.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompaniesTransaction.SelectedItem)).Row[cbCompaniesTransaction.ValueMember]);//Convert.ToString(cbCompaniesTransaction.SelectedValue.ToString());

                    long.TryParse(selectedValue, out id);
                    ReportInfo reportInfo = new ReportInfo();
                    reportInfo.EndDate = null;
                    reportInfo.StartDate = null;
                    if (!chkAllTransactions.Checked)
                    {
                        reportInfo.EndDate = dtpTo.Value.Date;
                        reportInfo.StartDate = dtpFrom.Value.Date;
                    }
                    reportInfo.Id = id;
                    reportInfo.Report = Report.CompanyTransactionsReport;
                    EBusiness.Reports.Report_Viewer print = new Reports.Report_Viewer(reportInfo);
                    print.ShowDialog();
                }
                catch (Exception exe)
                {

                    ExceptionLog.LogException(Modules.TransactionReportControl, "Supplier Transaction Report", exe, "Supplier Transaction Report Error");
                }
            }
            else if (dgvTransactions.Rows.Count == 0)
            {
                MessageBox.Show("No Record Found" + Environment.NewLine + "Please Made a valid transactions for print", "Supplier Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Status_Supplier != 0)
            {
                Common.ShowInvlaidCodeMessage(cbCompaniesTransaction, Modules.Supplier);
            }


        }



        private void tpView_Enter(object sender, EventArgs e)
        {
            //companiesTable = comp.SelectAllCompanies();
            //BindSearchGrid();

            Common.BindCompanyComboOnlyActive(ref cbSearchByCode, false);
        }



        void BindSearchGrid(DataTable companiesTable)
        {
            if (companiesTable != null && companiesTable.Rows.Count > 0)
            {
                dgvData.DataSource = companiesTable;
                dgvData.Columns["AllBalance"].Visible = false;
                dgvData.Columns["CompanyId"].Visible = false;
                dgvData.Columns["Email"].Visible = false;
                dgvData.Columns["Web"].Visible = false;
                dgvData.Columns["Fax"].Visible = false;
                dgvData.Columns["City"].Visible = false;

                dgvData.Columns["CompanyCode"].HeaderText = "Code";
                dgvData.Columns["CompanyName"].HeaderText = "Name";
                dgvData.Columns["CompanyBalance"].HeaderText = "Balance";

                Common.FormatCurrencyColumn(dgvData, "CompanyBalance");

                dgvData.Columns["IsActive"].HeaderText = "Active";


                txtBalance.Text = Convert.ToDecimal(companiesTable.Rows[0]["AllBalance"]).ToString("#0.00");
            }
        }

        private void cbSearchByCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbSearchByCode.Checked)
            {

                DataTable dt = null;
                string companyId = string.IsNullOrEmpty(cbSearchByCode.ValueMember) ? string.Empty : cbSearchByCode.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSearchByCode.SelectedItem)).Row[cbSearchByCode.ValueMember]);
                if (!string.IsNullOrEmpty(companyId))
                    dt = comp.SelectCompanyById(companyId);
                dgvData.DataSource = null;
                txtBalance.Text = "0.00";

                BindSearchGrid(dt);
            }
        }

        private void rbSearchByCode_CheckedChanged(object sender, EventArgs e)
        {

            cbSearchByCode.Visible = rbSearchByCode.Checked;
            txtSearch.Visible = !rbSearchByCode.Checked;
            if (rbSearchByCode.Checked)
            {
                DataTable dt = null;
                string companyId = string.IsNullOrEmpty(cbSearchByCode.ValueMember) ? string.Empty : cbSearchByCode.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSearchByCode.SelectedItem)).Row[cbSearchByCode.ValueMember]);
                if (!string.IsNullOrEmpty(companyId))
                    dt = comp.SelectCompanyById(companyId);
                dgvData.DataSource = null;
                txtBalance.Text = "0.00";

                BindSearchGrid(dt);
            }
            else
            {
                dgvData.DataSource = null;
                txtSearch.Text = string.Empty;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = !rbAll.Checked;
            txtSearch.Visible = !rbAll.Checked;
            btnFind.Visible = !rbAll.Checked;
            chkOnlyActive.Visible = rbAll.Checked;
            btnCompanyListPrint.Visible = rbAll.Checked;
            try
            {
                if (rbAll.Checked)
                {
                    Find();
                }
                else
                {
                    dgvData.DataSource = null;
                    txtSearch.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Supplier, "Find", ex, "Supplier Exception");
            }
        }



        private void chkViewAllInvoices_CheckedChanged(object sender, EventArgs e)
        {
            label17.Visible = !chkViewAllInvoices.Checked;
            dtFromInvoiceSearch.Visible = !chkViewAllInvoices.Checked;
            dtToInvoiceSearch.Visible = !chkViewAllInvoices.Checked;
            label18.Visible = !chkViewAllInvoices.Checked;
        }

        private void chkOnlyActive_CheckedChanged(object sender, EventArgs e)
        {
            Find();
        }

        private void btnCompanyListPrint_Click(object sender, EventArgs e)
        {
            if (Status_Supplier == 0)
            {
                if (dgvData.Rows.Count > 0)
                {
                    string options = "0,1";
                    if (chkOnlyActive.Checked)
                        options = "1,1";
                    ReportInfo info = new ReportInfo() { Options = options, Report = Report.CompanyCustomerList };
                    ReceiptViewer print = new ReceiptViewer(info);
                    print.ShowDialog();
                }
                else if (dgvData.Rows.Count == 0)
                {
                    MessageBox.Show("Error! No Record Found." + Environment.NewLine + "Please Made a valid transactions for print", "Supplier Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Status_Supplier != 0)
            {
                Common.ShowInvlaidCodeMessage(cbSearchByCode, Modules.Supplier);
            }
        }

        private void cbAllNewUpdate_Leave(object sender, EventArgs e)
        {
            if (rbUpdate.Checked && !string.IsNullOrEmpty(cbAllNewUpdate.Text) && !Common.IsCodeExists(cbAllNewUpdate.Text, Modules.Supplier, false))
            {
                Status_Supplier = 1;
                dgvData.DataSource = null;
                Common.ShowInvlaidCodeMessage(cbAllNewUpdate, Modules.Supplier);
            }
            else if (rbUpdate.Checked && string.IsNullOrEmpty(cbAllNewUpdate.Text))
            {
                if (cbAllNewUpdate.Items.Count > 0)
                    cbAllNewUpdate.SelectedIndex = 0;
            }
            else
            {
                Status_Supplier = 0;
            }
        }

        private void cbSearchByCode_Leave(object sender, EventArgs e)
        {
            if (rbSearchByCode.Checked && !string.IsNullOrEmpty(cbSearchByCode.Text) && !Common.IsCodeExists(cbSearchByCode.Text, Modules.Supplier))
            {
                Status_Supplier = 1;
                dgvData.DataSource = null;
                Common.ShowInvlaidCodeMessage(cbSearchByCode, Modules.Supplier);
            }
            else if (rbSearchByCode.Checked && string.IsNullOrEmpty(cbSearchByCode.Text))
            {
                if (cbSearchByCode.Items.Count > 0)
                    cbSearchByCode.SelectedIndex = 0;
            }
            else
            {
                Status_Supplier = 0;
            }

        }

        private void cbCompaniesTransaction_Leave(object sender, EventArgs e)
        {
            Status_Supplier = 0;
            if (tcMain.SelectedTab.Name == "tpTransactions" && cbCompaniesTransaction.Text != "--ALL--")
            {
                Status_Supplier = Common.IsValidCode(cbCompaniesTransaction, Modules.Supplier);
            }
        }

        private void cbCompanies_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbCompanies.Text) && !Common.IsCodeExists(cbCompanies.Text, Modules.Supplier))
            {
                Status_Supplier = 1;
                Common.ShowInvlaidCodeMessage(cbCompanies, Modules.Supplier);
            }
            else
            {
                Status_Supplier = 0;

            }
        }

        private void cboCompaniesInvoiceSearch_Leave(object sender, EventArgs e)
        {
            Status_Supplier = 0;
            if (tcMain.SelectedTab.Name == "tpSearchViewInvoices" && cboCompaniesInvoiceSearch.Text != "--ALL--")
            {
                Status_Supplier = Common.IsValidCode(cboCompaniesInvoiceSearch, Modules.Supplier);
            }
        }
        private void SearchByCode()
        {
            if (rbSearchByCode.Checked)
            {
                DataTable dt = null;
                string companyId = string.IsNullOrEmpty(cbSearchByCode.ValueMember) ? string.Empty : cbSearchByCode.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSearchByCode.SelectedItem)).Row[cbSearchByCode.ValueMember]);
                if (!string.IsNullOrEmpty(companyId))
                    dt = comp.SelectCompanyById(companyId);
                dgvData.DataSource = null;
                txtBalance.Text = "0.00";

                BindSearchGrid(dt);
            }
            else
            {
                dgvData.DataSource = null;
                txtSearch.Text = string.Empty;
            }
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab.Name == "tpView")
            {
                chkOnlyActive.Checked = true;
                Find();
            }
        }

        private void chkAllTransactions_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = !chkAllTransactions.Checked;
            label5.Visible = !chkAllTransactions.Checked;
            dtpFrom.Visible = !chkAllTransactions.Checked;
            dtpTo.Visible = !chkAllTransactions.Checked;
        }

    }
}
