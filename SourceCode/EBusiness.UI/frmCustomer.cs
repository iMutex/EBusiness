using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EBusiness.BLL;

namespace EBusiness
{
    public partial class frmCustomer : EBusiness.ParentForm
    {
        Customer customer = new Customer();
        BindingSource receiptBindingSource = new BindingSource();
        BindingSource detailsBindingSource = new BindingSource();
        Item item = new Item();
        private Int16 flag;
        private Int16 Status_Customer;
        #region Constructor
        public frmCustomer()
        {
            InitializeComponent();
            flag = 0;
            txtSearch.Visible = false;
            cbSearchByCode.Visible = true;
            Status_Customer = 0;
            Common.BindCustomerComboOnlyActive(ref cbSearchByCode, false);  //bind the Search By Code ComboBox
            if (!Common.CURRENT_USER.AllowCustomerPayment)
                tcMain.TabPages.Remove(tpPayment);
        }
        #endregion


        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Customer == 0)
                {
                    SaveNewUpdate(flag);
                }
                else if (Status_Customer != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbAllNewUpdateCustomers, Modules.Customer);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, "SaveNewUpdate", ex, "Customer Exception");
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
                ExceptionLog.LogException(Modules.Customer, "PopulateDetail", ex, "Customer Exception");
            }
        }
        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtCustomerCode.Enabled = !rbUpdate.Checked;
                if (rbUpdate.Checked)
                {
                    flag = 1;
                    lblSelectCompany.Visible = true;
                    cbAllNewUpdateCustomers.Visible = true;
                    txtInitialBalance.Enabled = false;
                    //PopulateCustomerCombo(ref cbAllNewUpdateCustomers, false);
                    Common.BindCustomerCombo(ref cbAllNewUpdateCustomers, false);
                }
                else
                {
                    flag = 0;
                    lblSelectCompany.Visible = false;
                    cbAllNewUpdateCustomers.Visible = false;
                    txtInitialBalance.Enabled = true;
                    ResetNewUpdate(flag);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, "PopulateCustomerCombo", ex, "Customer Exception");
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Customer == 0)
                {
                    Search();
                }
                else if (Status_Customer != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbSearchByCode, Modules.Customer);
                }

            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, " Search", ex, "Customer Exception");
            }

        }
        private void tpPayment_Enter(object sender, EventArgs e)
        {
            try
            {
                Common.BindCustomerComboOnlyActive(ref cbCustomers, false);
                DataTable dt = (DataTable)cbCustomers.DataSource;
                if (dt != null && dt.Rows.Count > 0)
                {
                    //  dt.Rows[0][1] = "--CASH--";
                }
                lblTransactionNo.Text = Common.GetNextId(Modules.Payment).ToString();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, "BindCustomerCombo", ex, "Customer Exception");
            }
        }
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Customer == 0)
                {
                    MakePayment();
                }
                else if (Status_Customer != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbCustomers, Modules.Customer);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, "MakePayment", ex, "Customer Exception");
            }

        }
        private void tpTransactions_Enter(object sender, EventArgs e)
        {
            try
            {
                PopulateCustomerCombo(ref cbCustomersTransaction, true);
                dtpFrom.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, "PopulateCustomerCombo", ex, "Customer Exception");
            }

        }
        private void btnTransactionFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Customer == 0)
                {
                    Find();
                }
                else if (Status_Customer != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbCustomersTransaction, Modules.Customer);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, "Find", ex, "Customer Exception");
            }

        }
        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = !rbAll.Checked;
            txtSearch.Visible = !rbAll.Checked;
            btnFind.Visible = !rbAll.Checked;
            chkOnlyActive.Visible = rbAll.Checked;
            btnCustomerListPrint.Visible = rbAll.Checked;
            try
            {
                if (rbAll.Checked)
                {
                    Search();
                }
                else
                {
                    dgvData.DataSource = null;
                    txtSearch.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, "Search", ex, "Customer Exception");
            }
        }
        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbCustomers.Text))
                {
                    //DataTable dt = customer.SelectCustomerByCode(cbCustomers.Text);
                    string customerId = string.IsNullOrEmpty(cbCustomers.ValueMember) ? string.Empty : cbCustomers.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomers.SelectedItem)).Row[cbSearchByCode.ValueMember]);
                    DataTable dt = customer.SelectCustomerById(customerId);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        lblCustomerName.Text = Convert.ToString(dt.Rows[0]["CustomerName"]);
                        lblPaymentAddress.Text = Convert.ToString(dt.Rows[0]["Address"]);
                        decimal balance = 0;
                        decimal.TryParse(Convert.ToString(dt.Rows[0]["CustomerBalance"]), out balance);

                        if (balance >= 0)
                        {
                            lblCustomerBalance.ForeColor = Color.Black;
                            lblCustomerBalance.Text = balance.ToString("0.00");
                        }
                        else
                        {
                            lblCustomerBalance.ForeColor = Color.Red;
                            lblCustomerBalance.Text = balance.ToString("0.00");
                        }
                    }
                    else
                    {
                        lblCustomerName.Text = customerId;
                        lblCustomerBalance.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ExceptionLog.LogException(Modules.Customer, "SelectCustomerByCode", ex, "Customer Exception");
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
                ExceptionLog.LogException(Modules.Customer, "btnCancelPayment", ex, "Customer Exception");
            }

        }
        private void tpReceipts_Enter(object sender, EventArgs e)
        {
            try
            {
                PopulateCustomerCombo(ref cbSearchReceiptCustomer, false);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, "PopulateCustomerCombo", ex, "Customer Exception");
            }

        }
        private void btnFindReceipts_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Customer == 0)
                {
                    GetReceiptsData();
                }
                else if (Status_Customer != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbSearchReceiptCustomer, Modules.Customer);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Customer, "GetReceiptsData", ex, "Customer Exception");
            }

        }
        private void rbReceiptSearchOption_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReceiptById.Checked)
            {
                txtReceiptId.Visible = true;
                lblReceiptCustomer.Visible = true;
                lblReceiptCustomer.Text = "Receipt No";
                cbSearchReceiptCustomer.Visible = false;
                lblTo.Visible = false;
                lblFrom.Visible = false;
                dtpSearchReceiptEndDate.Visible = false;
                dtpSearchReceiptStartDate.Visible = false;
            }
            else if (rbReceiptAll.Checked)
            {
                txtReceiptId.Visible = false;
                lblReceiptCustomer.Visible = false;
                cbSearchReceiptCustomer.Visible = false;
                lblTo.Visible = false;
                lblFrom.Visible = false;
                dtpSearchReceiptEndDate.Visible = false;
                dtpSearchReceiptStartDate.Visible = false;
                GetReceiptsData();
            }
            else if (rbReceiptCustomerAllReceipt.Checked)
            {
                txtReceiptId.Visible = false;
                lblReceiptCustomer.Visible = true;
                cbSearchReceiptCustomer.Visible = true;
                lblReceiptCustomer.Text = "Customer";
                lblTo.Visible = false;
                lblFrom.Visible = false;
                dtpSearchReceiptEndDate.Visible = false;
                dtpSearchReceiptStartDate.Visible = false;
            }
            else if (rbReceiptCustomerDateWise.Checked)
            {
                txtReceiptId.Visible = false;
                lblReceiptCustomer.Visible = true;
                cbSearchReceiptCustomer.Visible = true;
                lblReceiptCustomer.Text = "Customer";
                lblTo.Visible = true;
                lblFrom.Visible = true;
                dtpSearchReceiptEndDate.Visible = true;
                dtpSearchReceiptStartDate.Visible = true;
            }
            else if (rbReceiptDateWise.Checked)
            {
                txtReceiptId.Visible = false;
                lblReceiptCustomer.Visible = false;
                cbSearchReceiptCustomer.Visible = false;
                lblReceiptCustomer.Text = "Customer";
                lblTo.Visible = true;
                lblFrom.Visible = true;
                dtpSearchReceiptEndDate.Visible = true;
                dtpSearchReceiptStartDate.Visible = true;
            }
        }
        #endregion


        #region Methods
        void SaveNewUpdate(Int16 flag)
        {



            if (!string.IsNullOrEmpty(txtCustomerCode.Text))
            {
                if (!string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    if (Common.IsCodeExists(txtCustomerCode.Text, Modules.Customer) && rbNew.Checked)
                    {
                        MessageBox.Show("A Customer already exists with code [" + txtCustomerCode.Text + "]." + Environment.NewLine + "Please try some other code.", "Error.Customer [" + txtCustomerCode.Text + "]+ Already exits",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        txtCustomerCode.Focus();
                        return;
                    }


                    if (Common.IsMatch(txtInitialBalance.Text))
                    {
                        decimal amount = 0;
                        if (decimal.TryParse(txtInitialBalance.Text, out amount))
                        {
                            if (customer.InsertUpdateCustomer(lblId.Text, txtCustomerCode.Text, txtCustomerName.Text, txtContactNumber.Text, txtAddress.Text,
                                txtInitialBalance.Text, chkIsActive.Checked ? "1" : "0"
                                , txtRemarks.Text, txtCity.Text, txtContactPerson.Text, txtPhone.Text, txtFax.Text, txtWeb.Text, txtEmail.Text))
                            {
                                ResetNewUpdate(flag);
                                if (flag == 1)
                                {
                                    MessageBox.Show("Customer Record Updated sucessfully.", "Successfully Update Customer Record",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                {
                                    MessageBox.Show("Customer Record saved sucessfully.", "Successfully Saved Customer Record",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Operation could not be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Initial Balance.Please specify a valid amount", "Invalid Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtInitialBalance.Text = "0.00";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Correct formate for balance" + Environment.NewLine +
                        "It only allow maxmuim two digit decimal like 99.99", "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Customer Name is Required", "Customer Name is Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Customer Code is Required.", "Customer Code is Required.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void Search()
        {

            DataTable dt = null;
            if (rbAll.Checked)
            {
                if (chkOnlyActive.Checked)
                {
                    dt = customer.SelectAllActiveCustomer();
                }
                else
                {
                    dt = customer.SelectAllCustomer();
                }

            }
            else if (rbSearchByCode.Checked)
            {
                if (!string.IsNullOrEmpty(cbSearchByCode.Text))
                {
                    string customerId = string.IsNullOrEmpty(cbSearchByCode.ValueMember) ? string.Empty : cbSearchByCode.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSearchByCode.SelectedItem)).Row[cbSearchByCode.ValueMember]);
                    dt = customer.SelectCustomerById(customerId);
                }
                else
                    MessageBox.Show("Please enter Customer code to Search", "Enter customer Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (rbSearchByName.Checked)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    dt = customer.SelectCustomerByName(txtSearch.Text);
                }
                else
                {
                    MessageBox.Show("Please enter Customer name to Search", "Enter customer Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            dgvData.Columns.Clear();

            dgvData.DataSource = dt;

            if (dt != null)
            {
                Common.ShowHideColumns(dgvData, "Web,Fax,Email,AllBalance,CustomerId,ContactPerson,ContactNumber");
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("CustomerCode", "Code");
                dict.Add("CustomerName", "Customer");
                dict.Add("CustomerBalance", "Balance");
                dict.Add("IsActive", "Active");
                Common.RenameColumns(dgvData, dict);
                Common.FormatCurrencyColumn(dgvData, "CustomerBalance");

                decimal balance = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    balance += Convert.ToDecimal(dr["CustomerBalance"]);
                }
                txtBalance.Text = balance.ToString("0.00");
            }

        }
        void PopulateDetail()
        {
            if (rbUpdate.Checked)
            {
                int index = cbAllNewUpdateCustomers.SelectedIndex;
                if (index > -1)
                {
                    string Id = string.IsNullOrEmpty(cbAllNewUpdateCustomers.ValueMember) ? string.Empty : cbAllNewUpdateCustomers.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbAllNewUpdateCustomers.SelectedItem)).Row[cbAllNewUpdateCustomers.ValueMember]);
                    DataTable dt = customer.SelectCustomerById(Id); ;
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        lblId.Text = Convert.ToString(row["CustomerId"]);
                        txtCustomerCode.Text = Convert.ToString(row["CustomerCode"]);
                        txtCustomerName.Text = Convert.ToString(row["CustomerName"]);
                        if (row["CustomerBalance"] != DBNull.Value)
                        {
                            txtInitialBalance.Text = string.Format("{0:0.00}", Convert.ToDecimal(row["CustomerBalance"]));
                        }
                        else
                        {
                            txtInitialBalance.Text = "0.00";
                        }
                        txtContactNumber.Text = Convert.ToString(row["ContactNumber"]);
                        txtAddress.Text = Convert.ToString(row["Address"]);
                        txtCity.Text = Convert.ToString(row["City"]);
                        txtContactPerson.Text = Convert.ToString(row["ContactPerson"]);
                        txtPhone.Text = Convert.ToString(row["Phone"]);
                        txtFax.Text = Convert.ToString(row["Fax"]);
                        txtWeb.Text = Convert.ToString(row["Web"]);
                        txtEmail.Text = Convert.ToString(row["Email"]);
                        txtRemarks.Text = Convert.ToString(row["Remarks"]);
                        chkIsActive.Checked = Convert.ToBoolean(row["IsActive"]);

                        chkIsActive.Enabled = false;
                        if (string.IsNullOrEmpty(txtInitialBalance.Text) || txtInitialBalance.Text == "0" || txtInitialBalance.Text == "0.00")
                            chkIsActive.Enabled = true;
                    }
                }
            }
            else
            {
                txtCustomerCode.Text = string.Empty;
                txtCustomerName.Text = string.Empty;
                txtInitialBalance.Text = "0.00";
                txtContactNumber.Text = string.Empty;
                txtAddress.Text = string.Empty;//.ToString(row["Address"]);
                txtCity.Text = string.Empty;//.ToString(row["City"]);
                txtContactPerson.Text = string.Empty;//.ToString(row["ContactPerson"]);
                txtPhone.Text = string.Empty;//.ToString(row["Phone"]);
                txtFax.Text = string.Empty;//.ToString(row["Fax"]);
                txtWeb.Text = string.Empty;//.ToString(row["Web"]);
                txtEmail.Text = string.Empty;//.ToString(row["Email"]);
                txtRemarks.Text = string.Empty;//.ToString(row["Remarks"]);

                lblId.Text = "0";
            }
        }
        void PopulateCustomerCombo(ref ComboBox cbo, bool AllasTopItem)
        {
            Common.BindCustomerComboOnlyActive(ref cbo, AllasTopItem);

        }
        void ResetNewUpdate(int flag)
        {
            if (flag == 1)
            { }
            else
            {
                cbAllNewUpdateCustomers.DataSource = null;
                //PopulateCustomerCombo(ref cbAllNewUpdateCustomers, false);
                Common.BindCustomerCombo(ref cbAllNewUpdateCustomers, false);
                txtCustomerCode.Text = string.Empty;
                txtCustomerName.Text = string.Empty;
                txtContactNumber.Text = string.Empty;
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
            //rbNew.Checked = true;
        }
        void MakePayment()
        {
            decimal amount = 0;
            string companyId = string.IsNullOrEmpty(cbCustomers.ValueMember) ? string.Empty : cbCustomers.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomers.SelectedItem)).Row[cbCustomers.ValueMember]);//cbCustomers.SelectedValue.ToString();
            string customerName = string.IsNullOrEmpty(cbCustomers.ValueMember) ? string.Empty : cbCustomers.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomers.SelectedItem)).Row[cbCustomers.DisplayMember]);//cbCustomers.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(companyId) && companyId != "0")
            {
                if (decimal.TryParse(txtAmount.Text, out amount) & amount != 0)
                {

                    if (Common.IsMatch(txtAmount.Text))
                    {
                        if (!string.IsNullOrEmpty(txtComments.Text))
                        {
                            string strAmount = txtAmount.Text;
                            if (rbDebit.Checked)
                                strAmount = "-" + strAmount;

                            long TransactioId = customer.MakePayment(companyId, Common.FormateDateForDB(dtpDate.Value),
                            strAmount, txtComments.Text);
                            if (TransactioId > 0)
                            {
                                UserLog.Log(Common.CURRENT_USER.Id, rbCredit.Checked ? UserActions.Made_Credit_Payment_To_Customer : UserActions.Made_Debit_Payment_To_Customer, string.Format("Customer : {0} , Amount : {1}, TransactionId : {2}", customerName, strAmount, TransactioId));
                                ResetPayment();
                                lblTransactionNo.Text = Common.GetNextId(Modules.Payment).ToString();
                                string msg = "Payment made successfully." + Environment.NewLine +
                                    "Do you want to print?";
                                if (MessageBox.Show(msg, "Payment Successfully Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                    == System.Windows.Forms.DialogResult.Yes)
                                {
                                    ReportInfo info = new ReportInfo() { Id = TransactioId, Report = Report.Payment, Options = "1" };
                                    ReceiptViewer print = new ReceiptViewer(info);
                                    print.ShowDialog();
                                }
                            }
                            else
                            {
                                //MessageBox.Show("Operation could not be completed.");
                                MessageBox.Show("Operation could not be completed", "Operation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Comments are Mendatory", "Comments ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtComments.Focus();

                        }
                    }
                    else
                    {
                        //MessageBox.Show("Comments are Mendatory.");
                        MessageBox.Show("Please Enter the Correct formate for balance" + Environment.NewLine +
                     "It only allow maxmuim two digit decimal like 99.99", "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    //MessageBox.Show("InValid Amount.Please specify a valid amount.");
                    MessageBox.Show("InValid Amount.Please specify a valid amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Text = "0.00";
                    txtAmount.Focus();
                }
            }
            else
            {
                //MessageBox.Show("Please select a customer to make a payment.");
                MessageBox.Show("Please select a customer to make a payment.", "Select Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        void Find()
        {
            string fromDate = Common.FormateDateForDB(dtpFrom.Value);
            string toDate = Common.FormateDateForDB(dtpTo.Value);
            if (chkAllTransactions.Checked)
            {
                fromDate = null;
                toDate = null;
            }
            string companyId = string.IsNullOrEmpty(cbCustomersTransaction.ValueMember) ? string.Empty : cbCustomersTransaction.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomersTransaction.SelectedItem)).Row[cbCustomersTransaction.ValueMember]);//cbCustomersTransaction.SelectedValue.ToString();
            DataTable dt = customer.SelectCustomerTransactions(fromDate, toDate, companyId);
            dgvTransactions.DataSource = dt;

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

                decimal finalBalance = 0;
                if (debit < 0)
                    debit = -1 * debit;
                finalBalance = credit - debit;
                lblCredit.Text = credit.ToString("0.00");
                lblDebit.Text = debit.ToString("0.00");
                lblDebit.ForeColor = Color.Red;
                lblFinalBalance.Text = finalBalance.ToString("0.00");
                lblFinalBalance.ForeColor = Color.Black;
                if (finalBalance < 0)
                    lblFinalBalance.ForeColor = Color.Red;
                //dgvTransactions.Columns["TransactionId"].Visible = false;
                dgvTransactions.FirstDisplayedScrollingRowIndex = dgvTransactions.Rows.Count - 1;
            }


        }
        void ResetPayment()
        {
            cbCustomers.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            txtAmount.Text = "0.00";
            txtComments.Text = "";
        }
        #endregion Methods



        #region Search View Receipts and ReceiptDetails
        void GetReceiptsData()
        {
            dgvReceipts.DataSource = receiptBindingSource;
            dgvReceiptDetails.DataSource = detailsBindingSource;
            string ReceiptId = null;
            string CustomerId = null;
            DateTime StartDate = DateTime.MinValue;
            DateTime EndDate = DateTime.MaxValue;
            bool All = false;
            if (rbReceiptById.Checked)
            {
                if (!string.IsNullOrEmpty(txtReceiptId.Text))
                {
                    int rNo = 0;
                    int.TryParse(txtReceiptId.Text, out rNo);
                    if (rNo > 0)
                    {
                        ReceiptId = txtReceiptId.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a Valid Receipt No.", "Enter Valid Receipt No.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Receipt No.", "Receipt No.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbReceiptAll.Checked)
            {
                All = true;
            }
            else if (rbReceiptCustomerAllReceipt.Checked)
            {
                CustomerId = string.IsNullOrEmpty(cbSearchReceiptCustomer.ValueMember) ? string.Empty : cbSearchReceiptCustomer.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSearchReceiptCustomer.SelectedItem)).Row[cbSearchReceiptCustomer.ValueMember]);//cbSearchReceiptCustomer.SelectedValue.ToString();
            }
            else if (rbReceiptCustomerDateWise.Checked)
            {
                CustomerId = cbSearchReceiptCustomer.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSearchReceiptCustomer.SelectedItem)).Row[cbSearchReceiptCustomer.ValueMember]);//cbSearchReceiptCustomer.SelectedValue.ToString();
                StartDate = dtpSearchReceiptStartDate.Value;
                EndDate = dtpSearchReceiptEndDate.Value;

            }
            else if (rbReceiptDateWise.Checked)
            {
                StartDate = dtpSearchReceiptStartDate.Value;
                EndDate = dtpSearchReceiptEndDate.Value;
            }
            DataSet ds = item.SelectReceiptandReceiptDetails(ReceiptId, CustomerId, StartDate, EndDate, All);
            if (ds != null && ds.Tables.Count == 2)
            {
                receiptBindingSource.DataSource = ds;
                receiptBindingSource.DataMember = "Receipt";
                detailsBindingSource.DataSource = receiptBindingSource;
                detailsBindingSource.DataMember = "Receipt_ReceiptDetail";

            }
            Common.FormatCurrencyColumn(dgvReceipts, "GrandTotal,Discount,NetTotal,Payment,Arearrs");
            Common.FormatCurrencyColumn(dgvReceiptDetails, "Total,Disc,NetTotal,SalePrice");
            dgvReceiptDetails.Columns["ReceiptId"].Visible = false;
            foreach (DataGridViewColumn col in dgvReceiptDetails.Columns)
            {
                col.DisplayIndex = col.Index;
            }
            if (dgvReceipts.Rows.Count > 0)
            {
                dgvReceipts.FirstDisplayedScrollingRowIndex = dgvReceipts.Rows.Count - 1;
                dgvReceipts.Rows[dgvReceipts.Rows.Count - 1].Selected = true;
            }
        }
        #endregion




        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Status_Customer == 0 && dgvTransactions.Rows.Count > 0)
            {
                try
                {

                    long id;
                    string selectedValue = string.IsNullOrEmpty(cbCustomersTransaction.ValueMember) ? string.Empty : cbCustomersTransaction.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomersTransaction.SelectedItem)).Row[cbCustomersTransaction.ValueMember]);//Convert.ToString(cbCustomersTransaction.SelectedValue);
                    long.TryParse(selectedValue, out id);
                    ReportInfo reportInfo = new ReportInfo();
                    reportInfo.Report = Report.CustomerTransactionsReport;
                    if (chkAllTransactions.Checked)
                    {
                        reportInfo.EndDate = null;
                        reportInfo.StartDate = null;
                    }
                    else
                    {
                        reportInfo.EndDate = dtpTo.Value.Date;
                        reportInfo.StartDate = dtpFrom.Value.Date;
                    }
                    reportInfo.Id = id;
                    EBusiness.Reports.Report_Viewer print = new Reports.Report_Viewer(reportInfo);
                    print.ShowDialog();

                }
                catch (Exception exe)
                {

                    ExceptionLog.LogException(Modules.TransactionReportControl, "Print Customer Report", exe, "Customer Transaction Report Error");
                }
            }
            else
            {
                if (dgvTransactions.Rows.Count == 0)
                {
                    MessageBox.Show("Error ! No Record Found" + Environment.NewLine + "Please made a Valid Transaction for Print", "Customer Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Status_Customer != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbCustomersTransaction, Modules.Customer);
                }
            }
        }

        private void chkOnlyActive_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnCustomerListPrint_Click(object sender, EventArgs e)
        {
            if (Status_Customer == 0 && dgvData.Rows.Count > 0)
            {
                string options = "0,0";
                if (chkOnlyActive.Checked)
                    options = "1,0";
                ReportInfo info = new ReportInfo() { Options = options, Report = Report.CompanyCustomerList };
                ReceiptViewer print = new ReceiptViewer(info);
                print.ShowDialog();
            }
            else
            {
                if (Status_Customer != 0)
                {
                    Common.ShowInvlaidCodeMessage(cbSearchByCode, Modules.Customer);
                }
                else if (dgvData.Rows.Count == 0)
                {
                    MessageBox.Show("Error ! No Record Found" + Environment.NewLine + "Sorry No Customer Record Found for Print", "Customer Code", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void rbSearchByCode_CheckedChanged(object sender, EventArgs e)
        {
            cbSearchByCode.Visible = rbSearchByCode.Checked;
            txtSearch.Visible = !rbSearchByCode.Checked;
            if (rbSearchByCode.Checked)
            {
                Common.BindCustomerComboOnlyActive(ref cbSearchByCode, false);
                //  Search();
            }
            else
            {
                dgvData.DataSource = null;
                txtSearch.Text = string.Empty;
            }
        }

        private void cbSearchByCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbSearchByCode.Checked)
                Search();
        }

        private void cbAllNewUpdateCustomers_Leave(object sender, EventArgs e)
        {
            if (rbUpdate.Checked && !string.IsNullOrEmpty(cbAllNewUpdateCustomers.Text) && !Common.IsCodeExists(cbAllNewUpdateCustomers.Text, Modules.Customer, false))
            {
                Status_Customer = 1;
                Common.ShowInvlaidCodeMessage(cbAllNewUpdateCustomers, Modules.Customer);
            }
            else if (rbUpdate.Checked && string.IsNullOrEmpty(cbAllNewUpdateCustomers.Text))
            {
                if (cbAllNewUpdateCustomers.Items.Count > 0)
                    cbAllNewUpdateCustomers.SelectedIndex = 0;
            }
            else
            {
                Status_Customer = 0;
            }
        }

        private void cbSearchByCode_Leave(object sender, EventArgs e)
        {

            if (tcMain.SelectedTab.Name == "tpView" && !string.IsNullOrEmpty(cbSearchByCode.Text) && !Common.IsCodeExists(cbSearchByCode.Text, Modules.Customer))
            {
                Status_Customer = 1;
                Common.ShowInvlaidCodeMessage(cbSearchByCode, Modules.Customer);
            }
            else if (tcMain.SelectedTab.Name == "tpView" && string.IsNullOrEmpty(cbSearchByCode.Text))
            {
                if (cbSearchByCode.Items.Count > 0)
                    cbSearchByCode.SelectedIndex = 0;
            }
            else
            {
                Status_Customer = 0;
            }
        }

        private void cbCustomers_Leave(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab.Name == "tpPayment")
            {
                Status_Customer = Common.IsValidCode(cbCustomers, Modules.Customer);
            }
        }

        private void cbCustomersTransaction_Leave(object sender, EventArgs e)
        {
            Status_Customer = 0;
            if (tcMain.SelectedTab.Name == "tpTransactions" && cbCustomersTransaction.Text != "--ALL--")
            {
                Status_Customer = Common.IsValidCode(cbCustomersTransaction, Modules.Customer);
            }
        }

        private void cbSearchReceiptCustomer_Leave(object sender, EventArgs e)
        {
            if (!Common.IsCodeExists(cbSearchReceiptCustomer.Text, Modules.Customer))
            {
                Status_Customer = Common.IsValidCode(cbSearchReceiptCustomer, Modules.Customer);
            }
        }

        private void tpView_Enter(object sender, EventArgs e)
        {
            Common.BindCustomerComboOnlyActive(ref cbSearchByCode, false);
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab.Name == "tpView")
            {
                chkOnlyActive.Checked = true;
                Search();
            }
        }

        private void chkAllTransactions_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = !chkAllTransactions.Checked;
            label8.Visible = !chkAllTransactions.Checked;
            dtpFrom.Visible = !chkAllTransactions.Checked;
            dtpTo.Visible = !chkAllTransactions.Checked;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedRows.Count > 0)
            {
                long Id = Convert.ToInt64(dgvReceipts.SelectedRows[0].Cells["Id"].Value);
                if (Id > 0)
                {
                    ReportInfo info = new ReportInfo();
                    info.Id = Id;
                    info.Report = Report.Receipt;
                    ReceiptViewer print = new ReceiptViewer(info);
                    print.ShowDialog();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dgvReceipts.SelectedRows.Count < 1;
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count > 0)
            {
                long Id = Convert.ToInt64(dgvTransactions.SelectedRows[0].Cells["TransactionId"].Value);
                if (Id > 0)
                {

                    ReportInfo info = new ReportInfo() { Id = Id, Report = Report.Payment, Options = "1" };
                    ReceiptViewer print = new ReceiptViewer(info);
                    print.ShowDialog();

                }
            }

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dgvTransactions.SelectedRows.Count < 0;
        }





    }
}
