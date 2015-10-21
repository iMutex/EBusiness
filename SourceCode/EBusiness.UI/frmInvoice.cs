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
    public partial class frmInvoice : Form
    {


        BindingSource InvoiceBindingSource = new BindingSource();
        BindingSource detailsBindingSource = new BindingSource();

        Common common = new Common();
        Item item = new Item();
        Order order = new Order();
        Company comp = new Company();
        Shop shop = new Shop();
        private Int16 Status_Supplier;
        private Int16 Status_Item;
        //bool IsOrder = false;



        #region Constructors
        public frmInvoice()
        {

            Initialize();
            cbCompanies.Focus();
            MakeOrderInvoiceScreen();
            Status_Supplier = 0;
            Status_Item = 0;

        }
        public frmInvoice(bool isOrder)
        {

            Initialize();
            cbCompanies.Focus();
            MakeOrderInvoiceScreen();
        }
        #endregion Constructors




        #region Event
        private void txtExpenses_Leave(object sender, EventArgs e)
        {
            decimal discount = 0;
            if (!decimal.TryParse(txtExpenses.Text, out discount))
            {
                MessageBox.Show("Error! Invalid discount amount." + Environment.NewLine + " Please try a valid amount", "Invalid Discount Amount"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal total = 0;
            decimal.TryParse(lblGrandTotal.Text, out total);
            SetArrears();
            //txtPayment.Text = (total - discount).ToString("0.00");
        }
        private void txtPayment_Leave(object sender, EventArgs e)
        {
            SetArrears();
        }
        private void btnAdminPanelt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Invoice, "btnAdminPanel", ex, "Invoice Exception");
            }
        }
        private void cboItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectItem();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Invoice, "SelectItem", ex, "Invoice Exception");
            }

        }
        private void cboItems_Leave(object sender, EventArgs e)
        {
            try
            {
                Status_Supplier = 0;
                if (tabControl1.SelectedTab.Name == "tpNewInvoice")
                {
                    Status_Supplier = Common.IsValidCode(cboItems, Modules.Item);
                }
                
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Invoice, "SelectItem", ex, "Invoice Exception");
            }

        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Supplier == 0 && Status_Item == 0)
                {
                    Save();
                }
                else
                {
                    if (Status_Supplier != 0)
                    {
                        Common.ShowInvlaidCodeMessage(cbCompanies, Modules.Supplier);
                    }
                    else if (Status_Item != 0)
                    {
                        Common.ShowInvlaidCodeMessage(cboItems, Modules.Item);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Invoice, "Save", ex, "Invoice Exception");
            }
        }
        private void AddToGridEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    AddToGrid();
                    cboItems.Focus();
                }
                catch (Exception ex)
                {
                    ExceptionLog.LogException(Modules.Invoice, "AddToGrid", ex, "Invoice Exception");
                }
            }
        }
        private void cbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cbCompanies.SelectedIndex == 0)
                //{
                //    PopulateItems(string.Empty);
                //}
                if (!string.IsNullOrEmpty(cbCompanies.SelectedItem.ToString()) && cbCompanies.Text.ToLower() != "all")
                {
                    DataTable dt = comp.SelectCompanyById(Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]));
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        decimal Balance = Convert.ToDecimal(dt.Rows[0]["CompanyBalance"]);
                        lblCompany.Text = Convert.ToString(dt.Rows[0]["CompanyName"]);
                        txtCompanyBalance.Text = Balance.ToString("#0.00");
                        PopulateItems(Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]));
                    }
                    else
                    {

                        EmptyFields();
                    }
                }
                else
                {
                    PopulateItems(string.Empty);
                    EmptyFields();
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Invoice, "frmInvoice", ex, "Invoice Exception");
            }
        }
        private void cbCompanies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cboItems.Focus();
            }
        }
        /**/
        private void cboItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboItems.Text.Trim() == "" && e.KeyChar == ' ')
            {
                long ItemId = 0;
                ItemsList items = null;
                //if (cbCompanies.SelectedIndex > 0)
                //{
                int compId = Convert.ToInt32(string.IsNullOrEmpty(cbCompanies.ValueMember) ? string.Empty : cbCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]));
                items = new ItemsList(compId);
                //}
                //else
                //{
                //    items = new ItemsList();
                //}
                items.ShowDialog();
                ItemId = items.ItemId;
                cboItems.Text = string.Empty;
                if (Common.UseItemNames)
                    cboItems.SelectedValue = cboItems.FindString(items.ItemName);
                else
                    cboItems.SelectedValue = cboItems.FindString(items.ItemCode);

            }
        }
        private void cboItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.AcceptReturnInItemCombo))
                {
                    if (e.KeyCode == Keys.Return)
                    {
                        AddToGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Invoice, "ReadKeyBoolean", ex, "Invoice Exception");
            }

        }
        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 7)
            {
                decimal Qty = 0;
                if (!decimal.TryParse(Convert.ToString(dgvItems.Rows[e.RowIndex].Cells[4].Value), out Qty)
                || Qty <= 0)
                {
                    MessageBox.Show("Error! Invalid Quantity", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal Price = 0;
                if (!decimal.TryParse(Convert.ToString(dgvItems.Rows[e.RowIndex].Cells[5].Value), out Price)
                || Price <= 0)
                {
                    MessageBox.Show("Error! Invalid Price", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal discount = 0;
                if (!decimal.TryParse(Convert.ToString(dgvItems.Rows[e.RowIndex].Cells[7].Value).Replace("%", ""), out discount)
                || discount < 0 || discount >= 100)
                {
                    MessageBox.Show("Error! Invalid Discount", "Invalid Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                }
                dgvItems.Rows[e.RowIndex].Cells[5].Value = Price.ToString("#0.00");
                dgvItems.Rows[e.RowIndex].Cells[6].Value = (Qty * Price).ToString("#0.00");
                dgvItems.Rows[e.RowIndex].Cells[8].Value = ((Qty * Price) - (Qty * Price * discount / 100)).ToString("#0.00");
                try
                {
                    lblGrandTotal.Text = GetGrandTotal().ToString("#0.00");
                    SetArrears();
                }
                catch (Exception ex)
                {
                    ExceptionLog.LogException(Modules.Invoice, "GetGrandTotal", ex, "Invoice Exception");
                }

            }
        }
        private void rbSearchOption_CheckedChanged(object sender, EventArgs e)
        {
            dgvInvoices.DataSource = null;
            dgvInvoiceDetails.DataSource = null;
            if (rbAll.Checked)
            {
                lblFrom.Visible = false;
                dtpStartDate.Visible = false;
                lblTo.Visible = false;
                dtpEndDate.Visible = false;
                lblSearchFor.Visible = false;
                txtSearchText.Visible = false;
                cboSearchCompanies.Visible = false;
                BindGrid();
            }
            else if (rbCompanyDatewise.Checked)
            {
                lblFrom.Visible = true;
                dtpStartDate.Visible = true;
                lblTo.Visible = true;
                dtpEndDate.Visible = true;
                lblSearchFor.Visible = true;
                txtSearchText.Visible = false;
                cboSearchCompanies.Visible = true;
            }
            else if (rbCompanyAll.Checked)
            {
                lblFrom.Visible = false;
                dtpStartDate.Visible = false;
                lblTo.Visible = false;
                dtpEndDate.Visible = false;
                lblSearchFor.Visible = true;
                txtSearchText.Visible = false;
                cboSearchCompanies.Visible = true;
            }
            else if (rbDateWise.Checked)
            {
                lblFrom.Visible = true;
                dtpStartDate.Visible = true;
                lblTo.Visible = true;
                dtpEndDate.Visible = true;
                lblSearchFor.Visible = false;
                txtSearchText.Visible = false;
                cboSearchCompanies.Visible = false;
            }
            else if (rbById.Checked)
            {
                lblFrom.Visible = false;
                dtpStartDate.Visible = false;
                lblTo.Visible = false;
                dtpEndDate.Visible = false;
                lblSearchFor.Visible = true;
                txtSearchText.Visible = true;
                cboSearchCompanies.Visible = false;
            }
        }
        private void btnFindInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Supplier == 0)
                {
                    BindGrid();
                }
                else if (Status_Supplier != 0)
                {
                    Common.ShowInvlaidCodeMessage(cboSearchCompanies, Modules.Supplier);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Invoice, "BindGrid", ex, "Invoice Exception");
            }

        }
        private void chkLoadOrder_CheckedChanged(object sender, EventArgs e)
        {
            label14.Visible = chkLoadOrder.Checked;
            lblPaidOnOrder.Visible = chkLoadOrder.Checked;

            if (chkLoadOrder.Checked)
            {
                chkIsReturn.Checked = false;
                txtOrderNo.Visible = chkLoadOrder.Checked;
                btnLoadOrder.Visible = chkLoadOrder.Checked;
            }
            else
            {
                txtOrderNo.Visible = chkLoadOrder.Checked;
                btnLoadOrder.Visible = chkLoadOrder.Checked;
                //txtOrderNo.Text = string.Empty;
                //lblPaidOnOrder.Text = string.Empty;
                //txtExpenses.Text = string.Empty;
                //lblArrears.Text = string.Empty;
                //dgvItems.Rows.Clear();
                //txtComments.Text = string.Empty;
                ResetInvoice();
            }
        }
        private void btnLoadOrder_Click(object sender, EventArgs e)
        {
            bool IsOrder = chkLoadOrder.Checked;
            long orderId = 0;
            try
            {
                if (!IsOrder || long.TryParse(txtOrderNo.Text, out orderId) && orderId > 0)
                {
                    
                    DataSet ds = null;
                    if (IsOrder)
                        ds = order.SelectOrderandOrderDetails(txtOrderNo.Text, null, DateTime.MinValue, DateTime.MinValue, false);
                    else
                        ds = item.SelectInvoiceandInvoiceDetails(txtOrderNo.Text);
                    if (ds != null && ds.Tables.Count == 2)
                    {
                        DataTable dt1 = ds.Tables[0];
                        if (dt1.Rows.Count > 0)
                        {
                            if (IsOrder)
                            {
                                //cbCompanies.SelectedValue = dt1.Rows[0]["CompanyId"];
                                cbCompanies.SelectedIndex = cbCompanies.FindString(Convert.ToString(dt1.Rows[0][cbCompanies.DisplayMember]));
                                lblCompany.Text = Convert.ToString(dt1.Rows[0]["CompanyName"]);
                                txtCompanyBalance.Text = Convert.ToString(dt1.Rows[0]["CompanyBalance"]);
                            }
                            else
                            {
                                if (cbCompanies.DisplayMember == "CompanyCode")
                                    cbCompanies.SelectedIndex = cbCompanies.FindString(Convert.ToString(dt1.Rows[0]["Code"]));
                                else
                                    cbCompanies.SelectedIndex = cbCompanies.FindString(Convert.ToString(dt1.Rows[0]["Name"]));
                                //lblCompany.Text = Convert.ToString(dt1.Rows[0]["Name"]);
                            }

                            decimal grandTotal = Convert.ToDecimal(dt1.Rows[0]["GrandTotal"]);
                            decimal Discount = Convert.ToDecimal(dt1.Rows[0]["Discount"]);
                            decimal netTotal = grandTotal - Discount;
                            decimal Payment = Convert.ToDecimal(dt1.Rows[0]["Payment"]);
                            decimal Arrears = Convert.ToDecimal(dt1.Rows[0]["Arrears"]);



                            DataTable dtItems = ds.Tables[1];
                            if (dtItems.Rows.Count > 0)
                            {
                                if (dtItems != null && dtItems.Rows.Count > 0)
                                {
                                    dgvItems.Rows.Clear();
                                    foreach (DataRow dr in dtItems.Rows)
                                    {
                                        int SerialNo = dgvItems.Rows.Count + 1;
                                        string code = Convert.ToString(dr["Itemcode"]);
                                        string name = Convert.ToString(dr["ItemName"]);
                                        decimal price = Convert.ToDecimal(dr["PurchasePrice"]);
                                        int Quantity = Convert.ToInt32(dr["Quantity"]);
                                        decimal total = Convert.ToDecimal(dr["Total"]);
                                        decimal Gtotal = Convert.ToDecimal(dr["GrandTotal"]);
                                        decimal Disc = Convert.ToDecimal(dr["Discount"]);
                                        int ItemId = Convert.ToInt32(dr["ItemId"]);
                                        RemoveExistingRow(ItemId, code);
                                        dgvItems.Rows.Add(
                                            SerialNo.ToString()
                                            , ItemId.ToString()
                                            , code
                                            , name
                                            , Quantity.ToString()
                                            , price.ToString("#0.00")
                                            , Gtotal.ToString("#0.00")
                                            , Disc.ToString("#0.00")
                                            , total.ToString("#0.00"));


                                    }
                                }
                                lblGrandTotal.Text = grandTotal.ToString("#0.00");
                                
                                txtExpenses.Text = Discount.ToString("#0.00");
                                if(IsOrder)
                                lblPaidOnOrder.Text = Payment.ToString("#0.00");
                                else
                                    txtPayment.Text = Payment.ToString("#0.00");
                                SetArrears();
                            }
                            else
                            {
                                dgvItems.Rows.Clear();

                            }
                            if (IsOrder)
                                txtComments.Text = "Loaded from Order No. " + txtOrderNo.Text;
                            else
                                txtComments.Text = "Return for Invoice No. " + txtOrderNo.Text;
                        }
                        else
                        {
                            if (IsOrder)
                                MessageBox.Show("Error! No order found." + Environment.NewLine + "Please Type a Valid Order No.", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show("Error! No Invoice found." + Environment.NewLine + "Please Type a Valid Invoice No.", "No Invoice Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! No Order Found", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error! Please provide a valid order number", "Valid Order Number"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Invoice, "btnLoadOrder", ex, "Invoice Exception");
            }
        }

        private void dgvItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            cbCompanies.Enabled = dgvItems.Rows.Count == 0;
            for (int i = e.RowIndex; i < dgvItems.Rows.Count; i++)
            {
                int sno = Convert.ToInt32(dgvItems.Rows[i].Cells["colSerial"].Value);
                if (sno > 1)
                {
                    dgvItems.Rows[i].Cells["colSerial"].Value = sno - 1;
                }
            }
            try
            {
                SetTotals();
                lblGrandTotal.Text = GetGrandTotal().ToString();
                SetArrears();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "SetTotals", ex, "Invoice Exception");
            }
        }
        #endregion Event




        #region Method
        void Initialize()
        {
            try
            {

                DataTable dtShop = shop.SelectAllShop();
                InitializeComponent();
                lblShopName.Text = Convert.ToString(dtShop.Rows[0][0]);
                Common.BindCompanyComboOnlyActive(ref cbCompanies, false);
                Common.BindCompanyComboOnlyActive(ref cboSearchCompanies, true);
                PopulateItems(string.IsNullOrEmpty(cbCompanies.ValueMember) ? string.Empty : cbCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]));
                SelectItem();
                rbCompanyDatewise.Checked = true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        void PopulateItems(string CompanyId)
        {
            DataTable dtItems = null;
            if (!string.IsNullOrEmpty(CompanyId))
            {
                dtItems = item.SelectItemByCompany(CompanyId);
            }
            else
            {
                dtItems = item.SelectAllActiveItem();
            }
            if (dtItems != null)
            {
                cboItems.DataSource = dtItems;
                cboItems.DisplayMember = "ItemCode";
                cboItems.ValueMember = "ItemId";
            }
        }

        private void AddToGrid()
        {
            int ItemId = 0;
            int.TryParse(lblItemId.Text, out ItemId);
            if (ItemId > 0)
            {
                int SerialNo = dgvItems.Rows.Count + 1;
                string code = cboItems.Text;
                string name = lblItemName.Text;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                int Quantity = Convert.ToInt32(txtQuantity.Text);
                decimal total = price * Quantity;
                RemoveExistingRow(ItemId, code);

                dgvItems.Rows.Add(
                    SerialNo.ToString()
                    , ItemId.ToString()
                    , code
                    , name
                    , Quantity.ToString()
                    , price.ToString("#0.00")
                    , total.ToString("#0.00")
                    , "0.00"
                    , total.ToString("#0.00"));
                lblGrandTotal.Text = GetGrandTotal().ToString("#0.00");
                SetArrears();
            }
        }
        void SelectItem()
        {
            //string text = cboItems.SelectedText.ToString();
            string text = string.IsNullOrEmpty(cboItems.ValueMember) ? string.Empty : cboItems.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cboItems.SelectedItem)).Row[cboItems.ValueMember]);//Convert.ToString(cbCompanies.SelectedValue);

            if (!string.IsNullOrEmpty(text))
            {
                DataTable dt = item.SelectItemById(text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    string price = Convert.ToDecimal(dr["PurchasePrice"]).ToString("#0.00");
                    if (!string.IsNullOrEmpty(price))
                    {
                        txtPrice.Text = price;
                    }
                    lblItemId.Text = Convert.ToString(dr["ItemId"]);
                    txtQuantity.Text = "1";
                    lblItemName.Text = Convert.ToString(dr["ItemName"]);
                    lblStock.Text = Convert.ToString(dr["ItemInStock"]);
                }
                else
                {
                    EmptyFields();
                }
            }
            else
            {
                EmptyFields();
            }
        }
        void EmptyFields()
        {
            txtPrice.Text = string.Empty;
            lblItemId.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            lblItemName.Text = string.Empty;
            lblStock.Text = string.Empty;
        }
        void RemoveExistingRow(int ItemId, string code)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (
                    Convert.ToInt32(row.Cells["colItemId"].Value) == ItemId
                    && Convert.ToString(row.Cells["colItemCode"].Value) == code
                    )
                {
                    dgvItems.Rows.Remove(row);
                    break;
                }
            }
        }
        decimal GetGrandTotal()
        {
            decimal grandTotal = 0;
            int index = 1;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.Cells["colSerial"].Value = index++;
                grandTotal += Convert.ToDecimal(row.Cells["colTotal"].Value);
            }
            return grandTotal;
        }
        void SetTotals()
        {
            decimal grandTotal = 0;
            int index = 1;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.Cells["colSerial"].Value = index++;
                grandTotal += Convert.ToDecimal(row.Cells["colTotal"].Value);
            }

        }
        void MakeOrderInvoiceScreen()
        {
            rbCompanyDatewise.Text = "Company Invoices Datewise";
            rbCompanyAll.Text = "Company All Invoices";
            chkIsReturn.Visible = true;
            lblDeliveryDate.Visible = true;
            dtDeliveryDate.Visible = true;
            chkLoadOrder.Visible = true;
        }
        void Save()
        {
            if (dgvItems.Rows.Count > 0)
            {
                string CompanyId = string.IsNullOrEmpty(cbCompanies.ValueMember) ? string.Empty : cbCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]);//Convert.ToString(cbCompanies.SelectedValue);
                string CompanyName = string.IsNullOrEmpty(cbCompanies.ValueMember) ? string.Empty : cbCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.DisplayMember]);//Convert.ToString(cbCompanies.SelectedValue);
                string InvoiceNo = txtInvoiceNo.Text;
                if (string.IsNullOrEmpty(InvoiceNo))
                {
                    MessageBox.Show("Error! Invoice No. is Empty." + Environment.NewLine + "Please Enter a Invoice Number", "Invoice Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (item.IsDuplictaeInvoiceNo(InvoiceNo, CompanyId))
                {
                    MessageBox.Show(string.Format("Error! Invoice No [{0}] already exists for Supplier [{1}]." + Environment.NewLine + "Please Enter a valid Invoice Number", InvoiceNo, cbCompanies.Text), "Invoice Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string GrandTotal = lblGrandTotal.Text;
                string Discount = txtExpenses.Text;
                string Payment = txtPayment.Text;
                string Arrears = lblArrears.Text;
                DataTable dt = item.SelectEmptyInvoiceDetailTable();
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["Id"] = row.Cells["colSerial"].Value;
                    dr["ItemId"] = row.Cells["colItemId"].Value;
                    dr["PurchasePrice"] = row.Cells["colPrice"].Value;
                    dr["Quantity"] = row.Cells["colQuantity"].Value;
                    dr["Total"] = row.Cells["colTotal"].Value;
                    dr["Discount"] = row.Cells["colDiscount"].Value;
                    dr["GrandTotal"] = row.Cells["colGrandTotal"].Value;
                    dt.Rows.Add(dr);
                }
                ReportInfo reportInfo = new ReportInfo();
                long OrderNo = 0;
                long.TryParse(txtOrderNo.Text, out OrderNo);
                long Id = item.SaveInvoice(CompanyId, InvoiceNo, GrandTotal, Discount, Payment, Arrears, txtComments.Text, OrderNo.ToString(), dt, chkIsReturn.Checked);
                if (Id > 0)
                {
                    UserLog.Log(Common.CURRENT_USER.Id, chkIsReturn.Checked ? UserActions.Made_A_Return_Invoice : UserActions.Made_A_Purchase_Invoice,
                        string.Format("Supplier : {0} ,  Invoice No : {1}", CompanyName, InvoiceNo));
                    MessageBox.Show("Invoice Saved Sucessfully.....", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reportInfo.Id = Id;
                    reportInfo.Report = Report.Invoice;
                    ReceiptViewer receipt = new ReceiptViewer(reportInfo);
                    receipt.ShowDialog();
                    ResetInvoice();
                }
            }
            else
            {
                MessageBox.Show("Error! No Item for Invoice...", "No Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ResetInvoice()
        {
           // chkIsReturn.Checked = false;
            dgvItems.Rows.Clear();
            lblNextInvoiceNo.Text = Common.GetNextId(Modules.Invoice).ToString();
            txtInvoiceNo.Text = string.Empty;

            lblGrandTotal.Text = "0.00";
            txtExpenses.Text = "0.00";
            txtPayment.Text = "0.00";
            lblArrears.Text = "0.00";

            txtComments.Text = string.Empty;
            lblPaidOnOrder.Text = string.Empty;

            //dgvItems.Rows.Clear();
            cbCompanies.Enabled = true;
            cboItems.SelectedIndex = 0;
            //txtInvoiceNo.Text = string.Empty;
            //txtComments.Text = string.Empty;
            //lblPaidOnOrder.Text = string.Empty;
            txtOrderNo.Text = string.Empty;
            //txtComments.Text = string.Empty;
            //txtExpenses.Text = string.Empty;
            //lblArrears.Text = string.Empty;
        }
        #endregion Method





        #region Search View Invoices and InvoiceDetails
        void BindGrid()
        {

            string InvoiceId = string.Empty;
            string CompanyId = string.Empty;
            DateTime StartDate = DateTime.MinValue;
            DateTime EndDate = DateTime.MaxValue;
            bool All = false;
            if (rbAll.Checked)
            {
                All = true;
            }
            else if (rbCompanyDatewise.Checked)
            {
                if (cboSearchCompanies.SelectedIndex > 0)
                    CompanyId = string.IsNullOrEmpty(cboSearchCompanies.ValueMember) ? string.Empty : cboSearchCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cboSearchCompanies.SelectedItem)).Row[cboSearchCompanies.ValueMember]);//Convert.ToString(cboSearchCompanies.SelectedValue);
                StartDate = dtpStartDate.Value;
                EndDate = dtpEndDate.Value;

            }
            else if (rbCompanyAll.Checked)
            {
                if (cboSearchCompanies.SelectedIndex > 0)
                    CompanyId = cboSearchCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cboSearchCompanies.SelectedItem)).Row[cboSearchCompanies.ValueMember]);//Convert.ToString(cboSearchCompanies.SelectedValue);

            }
            else if (rbDateWise.Checked)
            {
                StartDate = dtpStartDate.Value;
                EndDate = dtpEndDate.Value;
            }
            else if (rbById.Checked)
            {
                if (!string.IsNullOrEmpty(txtSearchText.Text))
                {
                    InvoiceId = txtSearchText.Text;
                }
                else
                {
                    MessageBox.Show("Error! Please Enter an Invoice No.", "Invoice Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            BindGridToData(InvoiceId, CompanyId, StartDate, EndDate, All);
        }
        void BindGridToData(string InvoiceId, string CompanyId, DateTime StartDate, DateTime EndDate, bool All)
        {
            dgvInvoices.Columns.Clear();
            dgvInvoices.DataSource = null;
            dgvInvoiceDetails.DataSource = null;
            dgvInvoices.DataSource = InvoiceBindingSource;
            dgvInvoiceDetails.DataSource = detailsBindingSource;
            DataSet ds = item.SelectInvoiceandInvoiceDetails(InvoiceId, CompanyId, Common.FormateDateForDB(StartDate), Common.FormateDateForDB(EndDate), All);
            if (ds != null && ds.Tables.Count == 2)
            {
                InvoiceBindingSource.DataSource = ds;
                InvoiceBindingSource.DataMember = "Invoice";
                detailsBindingSource.DataSource = InvoiceBindingSource;
                detailsBindingSource.DataMember = "Invoice_InvoiceDetail";
                dgvInvoices.Refresh();
                dgvInvoiceDetails.Refresh();
            }
            dgvInvoices.Columns["Id"].Visible = false;
            dgvInvoiceDetails.Columns["InvoiceId"].Visible = false;
            dgvInvoices.Columns["CompanyId"].Visible = false;
            dgvInvoiceDetails.Columns["ItemId"].Visible = false;
            Common.FormatCurrencyColumn(dgvInvoices, "GrandTotal,Discount,Payment,Arrears");
            Common.FormatCurrencyColumn(dgvInvoiceDetails, "PurchasePrice,GrandTotal,Discount,Total");
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

        private void cbCompanies_Leave(object sender, EventArgs e)
        {

            Status_Supplier = 0;
            if (tabControl1.SelectedTab.Name == "tpNewInvoice")
            {
                Status_Supplier = Common.IsValidCode(cbCompanies, Modules.Supplier);
            }
        }

        private void cboSearchCompanies_Leave(object sender, EventArgs e)
        {
            Status_Supplier = 0;
            if (tabControl1.SelectedTab.Name == "tpSearch" && cboSearchCompanies.Text != "--ALL--")
            {
                Status_Supplier = Common.IsValidCode(cboSearchCompanies, Modules.Supplier);
            }
            //if (!Common.IsCodeExists(cboSearchCompanies.Text, Modules.Supplier))
            //{
            //    Status_Supplier = 1;
            //    Common.ShowInvlaidCodeMessage(cboSearchCompanies, Modules.Supplier);
            //}
            //else
            //{
            //    Status_Supplier = 0;
            //}
        }

        private void tpNewInvoice_Enter(object sender, EventArgs e)
        {
            lblNextInvoiceNo.Text = Common.GetNextId(Modules.Invoice).ToString();
            txtInvoiceNo.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            ResetInvoice();
        }

        private void dgvItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cbCompanies.Enabled = dgvItems.Rows.Count == 0;

        }


        void SetArrears()
        {
            decimal discount = 0;
            decimal.TryParse(txtExpenses.Text, out discount);
            decimal total = 0;
            decimal.TryParse(lblGrandTotal.Text, out total);
            decimal payment = 0;
            decimal.TryParse(txtPayment.Text, out payment);
            decimal paidOrder = 0;
            decimal.TryParse(lblPaidOnOrder.Text, out paidOrder);
            //if(!chkIsReturn.Checked)
            lblArrears.Text = (total - discount - payment - paidOrder).ToString("0.00");

        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            txtInvoiceNo.Focus();
            chkIsReturn.Visible = Common.CURRENT_USER.AllowReturnPurchase;
        }

        private void chkIsReturn_CheckedChanged(object sender, EventArgs e)
        {
            ResetInvoice();
            if (chkLoadOrder.Checked)
                chkLoadOrder.Checked = false;
            txtOrderNo.Visible = chkIsReturn.Checked;
            btnLoadOrder.Visible = chkIsReturn.Checked;
            //txtExpenses.Visible = chkIsReturn.Checked;

            //label3.Visible = !chkIsReturn.Checked;
            //txtPayment.Visible = !chkIsReturn.Checked;
            //label7.Visible = !chkIsReturn.Checked;
            //lblArrears.Visible = !chkIsReturn.Checked;
            if (chkIsReturn.Checked)
            {
                lblArrears.Text = "0.00";
                txtPayment.Text = "0.00";
            }
            SetArrears();
            
        }




    }
}
