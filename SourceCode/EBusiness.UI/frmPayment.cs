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
    public partial class frmPayment : Form
    {
        Customer customer = null;
        Company company = null;
        bool IsCustomer = true;
        public frmPayment()
        {
            InitializeComponent();
            Initialize(true);
        }
        public frmPayment(bool isCustomer)
        {
            InitializeComponent();
            Initialize(isCustomer);
        }

        void Initialize(bool isCustomer)
        {

            IsCustomer = isCustomer;
            customer = new Customer();
            company = new Company();
            //cbCustomersSuppliers.Items.Clear();
            cbCustomersSuppliers.DataSource = null;
            if (IsCustomer)
            {
                Common.BindCustomerComboOnlyActive(ref cbCustomersSuppliers, false);
            }
            else
            {
                Common.BindCompanyComboOnlyActive(ref cbCustomersSuppliers, false);
            }
        }

        private void cbCustomersSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbCustomersSuppliers.Text))
                {
                    string Id = string.IsNullOrEmpty(cbCustomersSuppliers.ValueMember) ? string.Empty : cbCustomersSuppliers.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomersSuppliers.SelectedItem)).Row[cbCustomersSuppliers.ValueMember]);
                    DataTable dt = null;
                    decimal balance = 0;
                    string name = string.Empty;
                    if (IsCustomer)
                    {
                        dt = customer.SelectCustomerById(Id);
                    }
                    else
                    {
                        dt = company.SelectCompanyById(Id);
                    }
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        if (IsCustomer)
                        {
                            name = Convert.ToString(dt.Rows[0]["CustomerName"]);
                            decimal.TryParse(Convert.ToString(dt.Rows[0]["CustomerBalance"]), out balance);
                        }
                        else
                        {
                            name = Convert.ToString(dt.Rows[0]["CompanyName"]);
                            decimal.TryParse(Convert.ToString(dt.Rows[0]["CompanyBalance"]), out balance);
                        }

                    }
                    lblName.Text = name;
                    if (balance >= 0)
                    {
                        lblBalance.ForeColor = Color.Black;
                        lblBalance.Text = balance.ToString("0.00");
                    }
                    else
                    {
                        lblBalance.ForeColor = Color.Red;
                        lblBalance.Text = balance.ToString("0.00");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ExceptionLog.LogException(Modules.Payment, "cbCustomersSuppliers_SelectedIndexChanged", ex, "Customer Exception");
            }
        }

        private void rbCustomerPayment_CheckedChanged(object sender, EventArgs e)
        {
            Initialize(rbCustomerPayment.Checked);
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {

        }

        void MakePayment()
        {
            decimal amount = 0;
            string companyId = string.IsNullOrEmpty(cbCustomersSuppliers.ValueMember) ? string.Empty : cbCustomersSuppliers.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomersSuppliers.SelectedItem)).Row[cbCustomersSuppliers.ValueMember]);//cbCustomers.SelectedValue.ToString();
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
                            long TransactioId = 0;
                            if (IsCustomer)
                                TransactioId = customer.MakePayment(companyId, Common.FormateDateForDB(dtpDate.Value),strAmount, txtComments.Text);
                            else
                                TransactioId = company.MakePayment(companyId, Common.FormateDateForDB(dtpDate.Value), strAmount, txtComments.Text);
                            if (TransactioId > 0)
                            {
                                //ResetPayment();
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
                if (IsCustomer)
                    MessageBox.Show("Please select a Customer to make a payment.", "Select Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Please select a Supplier to make a payment.", "Select Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbCustomersSuppliers.Focus();
            }
        }
    }
}
