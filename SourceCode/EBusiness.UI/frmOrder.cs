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
    public partial class frmOrder : Form
    {
        BindingSource InvoiceBindingSource = new BindingSource();
        BindingSource detailsBindingSource = new BindingSource();
        Common common = new Common();
        Item item = new Item();
        Order order = new Order();
        Company comp = new Company();
        Shop shop = new Shop();
        private Int16 Status_Item;
        private Int16 Status_Supplier;
        #region Constructor
        public frmOrder()
        {
            Initialize();
            Status_Item = 0;
            Status_Supplier = 0;
            MakeOrderInvoiceScreen();
        }
        #endregion Constructor
        #region Event
        private void txtExpenses_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal discount = 0;
                if (!decimal.TryParse(txtExpenses.Text, out discount))
                {
                    MessageBox.Show("Invalid discount amount."+Environment.NewLine+" Please try a valid amount"
                                    ,"Invalid Discount Amount",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                decimal total = 0;
                decimal.TryParse(lblGrandTotal.Text, out total);

                SetArrears();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Order, "frmOrder", ex,"Order Exception");
            }
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
                ExceptionLog.LogException(Modules.Order, "btnAdminPanel", ex,"Order Exception");
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
                ExceptionLog.LogException(Modules.Order, "SelectItem", ex, "Order Exception");
            }

        }
        private void cboItems_Leave(object sender, EventArgs e)
        {
            Status_Item = 0;
            if (tcOrderMain.SelectedTab.Name == "tpNewInvoice")
            {
                Status_Item = Common.IsValidCode(cboItems, Modules.Item);
            }
            try
            {
                SelectItem();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Order, "SelectItem", ex, "Order Exception");
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status_Item == 0 && Status_Supplier == 0)
                {
                    Save();
                }
                else 
                {
                    if (Status_Item != 0)
                    {
                        MessageBox.Show("Error! Invalid Selected Item." + Environment.NewLine + "Please Select a Valid Item ", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboItems.Focus();
                    }
                    else if(Status_Supplier!=0)
                    {
                        MessageBox.Show("Error! Invalid Selected Supplier." + Environment.NewLine + "Please Select a Valid Supplier ", "Supplier Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbCompanies.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Order, "Save", ex, "Order Exception");
            }
        }
        private void AddToGridEvent(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    AddToGrid();
                    cboItems.Focus();
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Order, "AddtoGrid", ex, "Order Exception");
            }
        }
        private void cbCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status_Supplier = 0;
            if (tcOrderMain.SelectedTab.Name == "tpNewInvoice")
            {
                Status_Supplier = Common.IsValidCode(cbCompanies, Modules.Supplier);
            }


            //if (!string.IsNullOrEmpty(cbCompanies.Text) && !Common.IsCodeExists(cbCompanies.Text, Modules.Supplier))
            //{
            //    Status_Supplier = 1;
            //    Common.ShowInvlaidCodeMessage(cbCompanies, Modules.Supplier);
            //}
            //else
            //{
            //    Status_Supplier = 0;
            //}

            try
            {
                if (!string.IsNullOrEmpty(cbCompanies.SelectedItem.ToString()) && cbCompanies.Text.ToLower() != "all" && cbCompanies.SelectedIndex > -1)
                {
                    DataTable dt = null;
                    string Id = Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]);
                    if (!string.IsNullOrEmpty(Id))
                    {
                        dt = comp.SelectCompanyById(Id);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            decimal Balance = Convert.ToDecimal(dt.Rows[0]["CompanyBalance"]);
                            lblCompany.Text = Convert.ToString(dt.Rows[0]["CompanyName"]);
                            txtCompanyBalance.Text = Balance.ToString("#0.00");
                            PopulateItems(Id);
                        }
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
                ExceptionLog.LogException(Modules.Order, "cbCompanies", ex, "Order Exception");
            }
        }
        private void cbCompanies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cboItems.Focus();
            }
        }
        private void cboItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboItems.Text.Trim() == "" && e.KeyChar == ' ')
            {
                long ItemId = 0;
                ItemsList items = null;
                if (cbCompanies.SelectedIndex > 0)
                {
                    int compId = Convert.ToInt32(cbCompanies.SelectedItem == null ? "0" : Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]));
                    items = new ItemsList(compId);
                }
                else
                {
                    items = new ItemsList();
                }
                items.ShowDialog();
                ItemId = items.ItemId;
                cboItems.Text = string.Empty;
                if (ItemId > 0)
                {
                    if(Common.UseItemNames)
                    cboItems.SelectedValue = cboItems.FindString(items.ItemName) ;
                    else
                        cboItems.SelectedValue = cboItems.FindString(items.ItemCode);
                }
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
                ExceptionLog.LogException(Modules.Order, "ReadKeyBoolean", ex, "Order Exception");
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
                    MessageBox.Show("Invalid Quantity"+Environment.NewLine+"Try Again!","Invalid Quantity"
                                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                decimal Price = 0;
                if (!decimal.TryParse(Convert.ToString(dgvItems.Rows[e.RowIndex].Cells[5].Value), out Price)
                || Price <= 0)
                {
                    MessageBox.Show("Invalid Price" + Environment.NewLine + "Try Again!", "Invalid Price"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal discount = 0;
                if (!decimal.TryParse(Convert.ToString(dgvItems.Rows[e.RowIndex].Cells[7].Value).Replace("%", ""), out discount)
                || discount < 0 || discount >= 100)
                {
                    MessageBox.Show("Invalid Discount" + Environment.NewLine + "Try Again!", "Invalid Discount"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                }
                dgvItems.Rows[e.RowIndex].Cells[5].Value = Price.ToString("#0.00");
                dgvItems.Rows[e.RowIndex].Cells[6].Value = (Qty * Price).ToString("#0.00");
                dgvItems.Rows[e.RowIndex].Cells[8].Value = ((Qty * Price) - (Qty * Price * discount / 100)).ToString("#0.00");
                lblGrandTotal.Text = GetGrandTotal().ToString("#0.00");

                SetArrears();
                
            }
        }
 
        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DialogResult dr = new DialogResult();
            //    dr = MessageBox.Show("Are you confirm to delete it", "Confirm", MessageBoxButtons.YesNo);

            //    if (dr == DialogResult.Yes)
            //    {
            //        int i;
            //        i = dgvInvoices.SelectedCells[0].RowIndex;
            //        int orderId = int.Parse(dgvInvoices.Rows[i].Cells["No"].Value.ToString());


            //        int a = order.DeleteOrder(orderId, 2);
            //        MessageBox.Show("The Order number" + orderId.ToString() + "Deleted","Order Number Deleted"
            //                        ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("No Order is Delete","Error Order Deleted",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    }
            //}

            //catch (Exception exe)
            //{

            //    ExceptionLog.LogException(Modules.Order, "DeleteOrder", exe, "Order Exception");
            //}
        }
        private void dgvItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvItems.Rows.Count == 0)
                cbCompanies.Enabled = true;
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
                ExceptionLog.LogException(Modules.POS, "SetTotals", ex, "Order Exception");
            }
        }
        #endregion Event
        #region Method
        void Initialize()
        {
            InitializeComponent();
            DataTable dtShop = shop.SelectAllShop();
            lblShopName.Text = Convert.ToString(dtShop.Rows[0][0]);
            //PopulateItems(string.Empty);
            Common.BindCompanyComboOnlyActive(ref cbCompanies, false);
            Common.BindCompanyComboOnlyActive(ref cboSearchCompanies, true);
            rbCompanyDatewise.Checked = true;
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
                cboItems.DisplayMember = "ItemCode";
                cboItems.ValueMember = "ItemId";
                cboItems.DataSource = dtItems;
                cboItems.DisplayMember = "ItemCode";
                cboItems.ValueMember = "ItemId";
            }
            
        }
        void PopulateCompanies()
        {
            DataTable dt = comp.SelectAllActiveCompanies(); ;
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["CompanyId"] = 0;
                dr["CompanyCode"] = "ALL";
                dt.Rows.InsertAt(dr, 0);
                cbCompanies.DataSource = dt;
                cbCompanies.DisplayMember = "CompanyCode";
                cbCompanies.ValueMember = "CompanyId";
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
            if (!string.IsNullOrEmpty(cboItems.Text))
            {
                DataTable dt = item.SelectItemById(Convert.ToString(((DataRowView)(cboItems.SelectedItem)).Row[cboItems.ValueMember]));
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
            this.Text = "Order Management";
            lblShopName.Text = "Order";
            rbCompanyDatewise.Text = "Supplier Order Datewise";
            rbCompanyAll.Text = "Supplier All Order";
            //chkIsReturn.Visible = false;
            lblDeliveryDate.Visible = false;
            dtDeliveryDate.Visible = false;
            //chkLoadOrder.Visible = false;
            //txtOrderNo.Visible = false;
        }
        void Save()
        {
            if (dgvItems.Rows.Count > 0)
            {
                string CompanyId = string.IsNullOrEmpty(cbCompanies.ValueMember) ? string.Empty : cbCompanies.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompanies.SelectedItem)).Row[cbCompanies.ValueMember]);//Convert.ToString(cbCompanies.SelectedValue);
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
                long Id = order.SaveOrder(CompanyId, GrandTotal, Discount, Payment, Arrears, txtComments.Text, dtDeliveryDate.Value, dt, false);
                MessageBox.Show("Order Saved Sucessfully.....","Save Successfully"
                                ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                reportInfo.Id = Id;
                reportInfo.Report = Report.Order;
                ReceiptViewer receipt = new ReceiptViewer(reportInfo);
                receipt.ShowDialog();
                ResetInvoice();
            }
            else
            {
                MessageBox.Show("Error !No Item for Invoice...","Error"
                                ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void ResetInvoice()
        {
            dgvItems.Rows.Clear();
            txtExpenses.Text = "0.00";
            txtPayment.Text = "0.00";
            lblArrears.Text = "0.00";
            lblGrandTotal.Text = "0.00";
            lblNextOrderNo.Text = Common.GetNextId(Modules.Order).ToString();
        }
        #endregion Method
        #region Search View Invoices and InvoiceDetails
        private void rbSearchOption_CheckedChanged(object sender, EventArgs e)
        {
            dgvInvoices.DataSource = null;
            dgvInvoiceDetails.DataSource = null;
            if (rbAll.Checked)
            {
                btnFindInvoices.Visible = false;
                lblFrom.Visible = false;
                dtpStartDate.Visible = false;
                lblTo.Visible = false;
                dtpEndDate.Visible = false;
                lblSearchFor.Visible = false;
                txtSearchText.Visible = false;
                cboSearchCompanies.Visible = false;
                BindGrid();

                //Load All INvoices

            }
            else if (rbCompanyDatewise.Checked)
            {
                btnFindInvoices.Visible = true;
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
                btnFindInvoices.Visible = true;
                lblFrom.Visible = false;
                dtpStartDate.Visible = false;
                lblTo.Visible = false;
                dtpEndDate.Visible = false;
                lblSearchFor.Visible = true;
                txtSearchText.Visible = false;
                cboSearchCompanies.Visible = true;
                BindGrid();
            }
            else if (rbDateWise.Checked)
            {
                btnFindInvoices.Visible = true;
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
                btnFindInvoices.Visible = true;
                lblFrom.Visible = false;
                dtpStartDate.Visible = false;
                lblTo.Visible = false;
                dtpEndDate.Visible = false;
                lblSearchFor.Visible = true;
                txtSearchText.Visible = true;
                cboSearchCompanies.Visible = false;
            }
        }
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
                    int id = 0;
                    int.TryParse(txtSearchText.Text, out id);
                    if (id > 0)
                    {
                        InvoiceId = id.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a valid Invoice No.","Valid Invoice Number"
                                        ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a valid Invoice No.", "Valid Invoice Number"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            BindGridToData(InvoiceId, CompanyId, StartDate, EndDate, All);
        }
        void BindGridToData(string InvoiceId, string CompanyId, DateTime StartDate, DateTime EndDate, bool All)
        {
            dgvInvoices.DataSource = null;
            dgvInvoiceDetails.DataSource = null;
            dgvInvoices.DataSource = InvoiceBindingSource;

            dgvInvoiceDetails.DataSource = detailsBindingSource;
            DataSet ds = order.SelectOrderandOrderDetails(InvoiceId, CompanyId, StartDate, EndDate, All);
            if (ds != null && ds.Tables.Count == 2)
            {
                InvoiceBindingSource.DataSource = ds;
                InvoiceBindingSource.DataMember = "Order";
                detailsBindingSource.DataSource = InvoiceBindingSource;
                detailsBindingSource.DataMember = "Order_OrderDetail";
                dgvInvoiceDetails.Columns["OrderId"].Visible = false;
                dgvInvoiceDetails.Columns["ItemId"].Visible = false;
                dgvInvoices.Columns["CompanyId"].Visible = false;
                dgvInvoices.Columns["Id"].HeaderText = "No.";
                dgvInvoices.Columns["CompanyCode"].HeaderText = "Code";
                dgvInvoices.Columns["CompanyName"].HeaderText = "Supplier";
                dgvInvoices.Columns["CompanyBalance"].HeaderText = "Balance";

                dgvInvoices.Refresh();
                dgvInvoiceDetails.Refresh();
            }

            Common.FormatCurrencyColumn(dgvInvoices, "CompanyBalance,GrandTotal,Discount,Payment,Arrears");
            Common.FormatCurrencyColumn(dgvInvoiceDetails, "PurchasePrice,GrandTotal,Discount,Total");
        }
        private void btnFindInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                BindGrid();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Order, "BindGrid", ex, "Order Exception");
            }
        }
        #endregion Search View Invoices and InvoiceDetails

        private void tpNewInvoice_Enter(object sender, EventArgs e)
        {
            lblNextOrderNo.Text = Common.GetNextId(Modules.Order).ToString();
        }

        private void btnLoadOrder_Click(object sender, EventArgs e)
        {

        }

        private void chkLoadOrder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
                cbCompanies.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();
            cbCompanies.Enabled = true;
        }

        private void cboSearchCompanies_Leave(object sender, EventArgs e)
        {
            //Status_Item = 0;
            //if (tcOrderMain.SelectedTab.Name == "tpSearch")
            //{
            //    Status_Item = Common.IsValidCode(cboSearchCompanies, Modules);
            //}

            Status_Supplier = 0;
            if (tcOrderMain.SelectedTab.Name == "tpSearch" && cboSearchCompanies.Text != "--ALL--")
            {
                Status_Supplier = Common.IsValidCode(cboSearchCompanies, Modules.Supplier);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                long Id = Convert.ToInt64(dgvInvoices.SelectedRows[0].Cells["Id"].Value);
                if (Id > 0)
                {
                    ReportInfo info = new ReportInfo();
                    info.Id = Id;
                    info.Report = Report.Order;
                    ReceiptViewer print = new ReceiptViewer(info);
                    print.ShowDialog();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = dgvInvoices.SelectedRows.Count < 1;
        }


        void SetArrears()
        {
            decimal discount = 0;
            decimal.TryParse(txtExpenses.Text, out discount);
            decimal total = 0;
            decimal.TryParse(lblGrandTotal.Text, out total);
            decimal payment = 0;
            decimal.TryParse(txtPayment.Text, out payment);
            lblArrears.Text = (total - discount - payment).ToString("0.00");

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            
        }
    }
}