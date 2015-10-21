using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using EBusiness.BLL;

namespace EBusiness
{
    public partial class POS : Form
    {
        bool UseItemNames = false;
        private static int LeaveColIndex = -1;
        private static int LeaveRowIndex = -1;
        Item item = new Item();
        Login login = null;

        bool AcceptReturnInItemCombo = true;
        bool AllowShortStockSelling = true;
        DataTable AllItemsDataTable = null;
        bool PurchasePrice;

        private delegate void OverrideFocusDelegate(DataGridViewCell cell);
        #region Constructor
        public POS()
        {
            //login = new Login();
            //login.ShowDialog();
            PurchasePrice = false;
            InitializeComponent();

            AcceptReturnInItemCombo = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.AcceptReturnInItemCombo);
            AllowShortStockSelling = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.AllowShortStockSelling);
        }

        public POS(int Id)
        {
            InitializeComponent();
            LoadReceipt(Id);
            txtReturnReceiptNo.Visible = true;
            txtReturnReceiptNo.Text = Convert.ToString(Id);
            chkIsReturn.Checked = true;
            AcceptReturnInItemCombo = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.AcceptReturnInItemCombo);
            AllowShortStockSelling = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.AllowShortStockSelling);
        }
        #endregion Constructor



        private void POS_Load(object sender, EventArgs e)
        {
            Initialize();
            //btnCompany.Visible = login.AllowCompany;
            //btnCustomer.Visible = login.AllowCustomer;
            //btnItem.Visible = login.AllowItem;
            //btnStock.Visible = login.AllowStock;
            //btnReport.Visible = login.AllowReports;
            //btnInvoice.Visible = login.AllowInvoice;
            //btnCompany.Visible = login.AllowCompany;
            bool EntryTimeEditing = ConfigurationReader.ReadKeyBoolean("EnableEntryTimeEditing");
            txtQuantity.Enabled = EntryTimeEditing;
            txtPrice.Enabled = EntryTimeEditing;
            //txtDiscount.Enabled = EntryTimeEditing;
            bool ShowPurchasePrice = ConfigurationReader.ReadKeyBoolean("ShowPurchasePrice");
            //lblPurchasePrice.Visible = ShowPurchasePrice;

            chkCash.Checked = true;
            lblNextReceiptNo.Text = Common.GetNextId(Modules.Receipt).ToString();

            chkIsReturn.Visible = Common.CURRENT_USER.AllowReturnSale;

        }




        #region Event
        private void btnAdminPanelt_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "btnAdminPanel", ex, "POS Exception");
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
                ExceptionLog.LogException(Modules.POS, "SelectItem", ex, "POS Exception");
            }
        }
        private void cboItems_Leave(object sender, EventArgs e)
        {
            try
            {
                SelectItem(false);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "SelectItem", ex, "POS Exception");
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = string.Empty;
                if (chkCash.Checked)
                {
                    Customer customer = new Customer();
                    DataTable dtCustomer = customer.SelectCustomerByCode("CASH");

                    if (dtCustomer != null && dtCustomer.Rows.Count > 0)
                    {
                        Id = Convert.ToString(dtCustomer.Rows[0]["CustomerId"]);
                        string balance = Convert.ToString(dtCustomer.Rows[0]["CustomerBalance"]);
                        customer.InsertUpdateCustomer(Id, "CASH", txtCashName.Text, string.Empty, txtCashAddress.Text, balance, "1", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                    }
                    else
                    {
                        Id = "0";
                        if (customer.InsertUpdateCustomer(Id, "CASH", txtCashName.Text, string.Empty, txtCashAddress.Text, "0.00", "1", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty))
                        {
                            dtCustomer = customer.SelectCustomerByCode("CASH");
                            Id = Convert.ToString(dtCustomer.Rows[0]["CustomerId"]);
                        }
                    }
                }
                else if (cbCustomer.Text.ToLower() == "cash")
                {
                    MessageBox.Show("To make a cash sale, CASH checkbox must be checked.");
                    chkCash.Checked = true;
                    return;
                }
                Save(Id);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "Save", ex, "POS Exception");
            }
        }
        public void AddToGridEvent(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    AddToGrid();
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "AddtoGrid", ex, "POS Exception");
            }
        }
        private void cboItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (cboItems.Text.Trim() == "" && e.KeyChar == ' ')
            //{
            //    int ItemId = 0;
            //    ItemsList items = new ItemsList();
            //    items.ShowDialog();
            //    ItemId = items.ItemId;
            //    cboItems.Text = string.Empty;
            //    if (ItemId > 0)
            //        cboItems.SelectedValue = ItemId;
            //}
        }
        private void btnReport_Click(object sender, EventArgs e)
        {

            EBusiness.Reports.ReportsApp reportApp = new Reports.ReportsApp();
            reportApp.ShowDialog();

        }
        private void Realod_Click(object sender, EventArgs e)
        {
            try
            {
                Initialize();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "Initialize", ex, "POS Exception");
            }
        }
        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PopulateCustomer();
                if (cbCustomer.Text.ToLower() == "cash")
                {
                    chkCash.Checked = true;
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "PopulateCustomer", ex, "POS Exception");
            }
        }
        private void btnCurrentCash_Click(object sender, EventArgs e)
        {
            EBusiness.Reports.CurrentCashReport frm = new Reports.CurrentCashReport();
            frm.ShowDialog();
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.ShowDialog();
        }
        private void cboItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.AcceptReturnInItemCombo))
            {
                try
                {
                    if (e.KeyCode == Keys.Return)
                    {
                        AddToGrid();
                    }
                }
                catch (Exception ex)
                {
                    ExceptionLog.LogException(Modules.POS, "AddtoGrid", ex, "POS Exception");
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "btnExit", ex, "POS Exception");
            }
        }
        private void btnSystemLog_Click(object sender, EventArgs e)
        {

        }
        private void chkIsReturn_CheckedChanged(object sender, EventArgs e)
        {
            lblReturnReceiptNo.Visible = chkIsReturn.Checked;
            txtReturnReceiptNo.Visible = chkIsReturn.Checked;
            btnLoadReturnReceipt.Visible = chkIsReturn.Checked;

            ResetReceipt();
            //txtPayment.Enabled = !chkIsReturn.Checked;

        }
        private void btnLoadReturnReceipt_Click(object sender, EventArgs e)
        {
            int ReceiptId = 0;
            int.TryParse(txtReturnReceiptNo.Text, out ReceiptId);
            try
            {
                if (ReceiptId > 0)
                {
                    LoadReceipt(ReceiptId);
                }
                else
                {
                    MessageBox.Show("Invalid Receipt No.");
                    txtReturnReceiptNo.Text = string.Empty;
                    txtReturnReceiptNo.Focus();
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "LoadReceipt", ex, "POS Exception");
            }
        }
        private void OverrideFocus(DataGridViewCell cell)
        {
            dgvItems.CurrentCell = cell;
        }
        #endregion Event





        #region Method
        void Initialize()
        {
            Shop shop = new Shop();
            DataTable dtShop = shop.SelectAllShop();
            if (dtShop.Rows.Count > 0)
            {
                string shopName = Convert.ToString(dtShop.Rows[0]["ShopName"]);
                string shopReg = Convert.ToString(dtShop.Rows[0]["RegistrationNumber"]);
                string shopAddress = Convert.ToString(dtShop.Rows[0]["ShopAddress"]);
                string shopPhone = Convert.ToString(dtShop.Rows[0]["ShopNumber"]);
                string shopProperiter = Convert.ToString(dtShop.Rows[0]["Properiter"]);
                string detail = string.Empty;
                if (!string.IsNullOrEmpty(shopReg))
                    detail = shopReg + Environment.NewLine;
                if (!string.IsNullOrEmpty(shopAddress))
                {
                    if (!string.IsNullOrEmpty(detail))
                        detail += shopAddress + "     [ Phone - " + shopPhone + "]" + Environment.NewLine;
                    else
                    {
                        detail += shopAddress + Environment.NewLine;
                        detail += shopPhone + Environment.NewLine;
                    }
                }
                if (!string.IsNullOrEmpty(shopProperiter))
                    detail += "Properiter : " + shopProperiter;

                lblShopName.Text = shopName;

                lblShopDetails.Text = detail;

            }


            UseItemNames = Convert.ToBoolean(ConfigurationManager.AppSettings["UseItemNames"]);

            BindAllItemsGrid();

            //Common.BindItemCombo(ref cboItems, true);
            //DataTable dtItems = item.SelectAllItem();
            //DataRow dr = dtItems.NewRow();
            //dr["ItemId"] = 0;
            //dr["ItemCode"] = "ALL";
            //dr["ItemName"] = "ALL";
            //dtItems.Rows.InsertAt(dr, 0);
            //cboItems.DataSource = dtItems;
            //if (UseItemNames)
            //{
            //    cboItems.DisplayMember = "ItemName";
            //}
            //else
            //{
            //    cboItems.DisplayMember = "ItemCode";
            //}
            //cboItems.ValueMember = "ItemId";

            Common.BindCustomerComboOnlyActive(ref cbCustomer, false);

            //Customer cust = new Customer();

            //cbCustomer.DisplayMember = "CustomerCode";
            //cbCustomer.ValueMember = "CustomerId";
            //cbCustomer.DataSource = cust.SelectAllCustomer();
            btnDone.Enabled = dgvItems.Rows.Count > 0;

        }
        private void AddToGrid()
        {
            if (dgvAllItems.CurrentRow != null)
            {
                int ItemId = 0;
                int.TryParse(Convert.ToString(dgvAllItems.CurrentRow.Cells["colItemId_All"].Value), out ItemId);
                if (ItemId > 0)
                {

                    string code = Convert.ToString(dgvAllItems.CurrentRow.Cells["colItemCode_All"].Value);
                    DataTable dt = item.SelectItemByCode(code.Trim()); // ???????
                    if (!string.IsNullOrEmpty(code) && dt != null && dt.Rows.Count > 0)
                    {
                        string name = Convert.ToString(dgvAllItems.CurrentRow.Cells["colItemName_All"].Value);
                        string packing = Convert.ToString(dgvAllItems.CurrentRow.Cells["colPacking_All"].Value);
                        decimal price = Convert.ToDecimal(dgvAllItems.CurrentRow.Cells["colSalePrice_All"].Value);
                        string strDisocunt =  Convert.ToString(dgvAllItems.CurrentRow.Cells["colDiscount_All"].Value);
                        long stock = 0;
                        long.TryParse(Convert.ToString(dgvAllItems.CurrentRow.Cells["colStock_All"].Value), out stock);
                        decimal discount = 0;
                        if (!string.IsNullOrEmpty(strDisocunt))
                        {
                            if (strDisocunt.Contains("%"))
                            {
                                strDisocunt = strDisocunt.Replace("%", string.Empty);
                                decimal.TryParse(strDisocunt, out discount);
                                discount = price * (discount / 100);

                            }
                            else
                            {
                                discount = Convert.ToDecimal(strDisocunt);
                            }
                        }
                        int Quantity = 0;
                        string qty = Convert.ToString(dgvAllItems.CurrentRow.Cells["colQuantity_All"].Value);
                        int.TryParse(qty, out Quantity);
                        if (Quantity < 1)
                            Quantity = 1;
                        //if (!string.IsNullOrEmpty(txtQuantity.Text))
                        //    int.TryParse(txtQuantity.Text, out Quantity);
                        decimal total = price * Quantity;
                        decimal totaldiscount = (discount * Quantity);

                        AddRowToGrid(ItemId, code, name, packing, price, strDisocunt, Quantity, total, totaldiscount, stock);

                        SetTotals();
                    }
                }
                btnDone.Enabled = dgvItems.Rows.Count > 0;
            }
        }
        private void SetTotals()
        {

            decimal GrandTotal = GetGrandTotal();
            decimal TotalDiscount = GetTotalDiscount();
            decimal NetTotal = GrandTotal - TotalDiscount;
            decimal Payment = NetTotal;
            lblGrandTotal.Text = NetTotal.ToString("#0.00"); //GrandTotal.ToString("#0.00");
            //txtTotalDiscount.Text = TotalDiscount.ToString("#0.00");
            txtNetTotal.Text = NetTotal.ToString("#0.00");
            txtPayment.Text = "0.00";//Payment.ToString("#0.00");
            SetArrears();
        }
        void LoadReceipt(int ReceiptId)
        {
            DataTable dt = Item.SelectReceipt(ReceiptId.ToString());
            bool isFirstRow = true;
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvItems.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    if (isFirstRow)
                    {
                        //Populate Customer Details
                        try
                        {
                            chkCash.Checked = false;
                            txtComments.Text = "Return Receipt for Receipt No. " + ReceiptId.ToString();
                            cbCustomer.SelectedIndex = cbCustomer.FindString(Convert.ToString(row[cbCustomer.DisplayMember]));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    //Add to  Grid
                    int ItemId = Convert.ToInt32(row["ItemId"]);
                    string code = Convert.ToString(row["ItemCode"]);
                    string name = Convert.ToString(row["ItemName"]);
                    string packing = Convert.ToString(row["Packing"]);
                    decimal price = Convert.ToDecimal(row["SalePrice"]);
                    int Quantity = Convert.ToInt32(row["Quantity"]);
                    decimal grandTotal = Convert.ToDecimal(row["ReceiptDetailGrandTotal"]);
                    decimal totaldiscount = Convert.ToDecimal(row["ReceiptDetailDiscount"]);
                    string discount = Convert.ToString(row["ItemDiscount"]);
                    decimal Total = Convert.ToDecimal(row["ReceiptDetailTotal"]);
                    long stock = Quantity;


                    AddRowToGrid(ItemId, code, name, packing, price, discount, Quantity, Total, totaldiscount, Quantity);

                }

                SetTotals();
                txtTotalDiscount.Text = Convert.ToDecimal(dt.Rows[0]["ReceiptDiscount"]).ToString("0.00");
                txtPayment.Text = Convert.ToDecimal(dt.Rows[0]["Payment"]).ToString("0.00");
            }
            //
            SetArrears();
            btnDone.Enabled = dgvItems.Rows.Count > 0;
        }
        private void AddRowToGrid(int ItemId, string code, string name, string packing, decimal price, string discount, int Quantity, decimal total, decimal totaldiscount, long stock)
        {
            if (Quantity <= stock || AllowShortStockSelling)
            {
                int SerialNo = dgvItems.Rows.Count + 1;
                RemoveExistingRow(ItemId, code);

                int rowIndex = dgvItems.Rows.Add(
                     SerialNo.ToString()
                     , ItemId.ToString()
                     , code
                     , name
                     , packing
                     , price.ToString("#0.00")
                     , Quantity.ToString()
                     , total.ToString("#0.00")
                     , discount//totaldiscount.ToString("#0.00")
                     , (total - totaldiscount).ToString("#0.00")
                     , discount
                     , stock
                     );
                if (Quantity > stock)
                    dgvItems.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightPink;
            }
            else
            {
                MessageBox.Show("Short Stock Selling is not allowed.");
            }
        }
        void SelectItem()
        {
            SelectItem(true);
        }
        void SelectItem(bool focus)
        {
            //try
            //{
            //    if (!string.IsNullOrEmpty(cboItems.Text))
            //    {
            //        DataTable dt = item.SelectItemByCode(cboItems.Text.Trim());
            //        if (dt != null && dt.Rows.Count > 0)
            //        {
            //            DataRow dr = dt.Rows[0];
            //            string price = Convert.ToDecimal(dr["SalePrice"]).ToString("#0.00");
            //            if (!string.IsNullOrEmpty(price))
            //            {
            //                txtPrice.Text = price;
            //            }
            //            string pprice = Convert.ToDecimal(dr["PurchasePrice"]).ToString("#0.00");
            //            if (!string.IsNullOrEmpty(pprice))
            //            {
            //                lblPurchasePrice.Text = pprice;
            //            }
            //            lblItemId.Text = Convert.ToString(dr["ItemId"]);
            //            txtQuantity.Text = "1";
            //            txtDiscount.Text = Convert.ToString(dr["Discount"]);
            //            lblItemName.Text = Convert.ToString(dr["ItemName"]);
            //            lblPacking.Text = Convert.ToString(dr["Packing"]);
            //            lblCompany.Text = Convert.ToString(dr["CompanyName"]);
            //            lblStock.Text = Convert.ToString(dr["ItemInStock"]);
            //            long stock = 0;
            //            long.TryParse(lblStock.Text, out stock);
            //            if (stock > 0)
            //            {
            //                Common.MarkNormal(label1);
            //                Common.MarkNormal(lblStock);
            //            }
            //            else
            //            {
            //                Common.MarkRed(label1);
            //                Common.MarkRed(lblStock);
            //            }

            //            //lblPurchasePrice.Text = Convert.ToString(dr["PurchasePrice"]);
            //        }
            //        else
            //        {
            //            EmptyFields(focus);
            //        }
            //    }
            //    else
            //    {
            //        EmptyFields(focus);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ExceptionLog.LogException(Modules.POS, "SelectItem", ex);
            //}
        }
        void EmptyFields(bool focus)
        {
            txtPrice.Text = string.Empty;
            //lblItemId.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            //lblItemName.Text = string.Empty;
            //lblCompany.Text = string.Empty;
            //lblStock.Text = string.Empty;
            //if (focus)
            //    cboItems.Focus();
        }
        void RemoveExistingRow(int ItemId, string code)
        {
            try
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
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "RemoveExistingRow", ex, "POS Exception");
            }
        }
        decimal GetGrandTotal()
        {
            decimal grandTotal = 0;
            try
            {
                int index = 1;
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    row.Cells["colSerial"].Value = index++;
                    grandTotal += Convert.ToDecimal(row.Cells["colFinalTotal"].Value);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "GetGrandTotal", ex, "POS Exception");
            }
            return grandTotal;

        }
        decimal GetTotalDiscount()
        {
            decimal grandTotal = 0;
            //try
            //{
            //    foreach (DataGridViewRow row in dgvItems.Rows)
            //    {
            //        grandTotal += Convert.ToDecimal(row.Cells["colDiscount"].Value);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ExceptionLog.LogException(Modules.POS, "GetTotalDiscount", ex);
            //}
            return grandTotal;

        }

        void Save(string CustomerId)
        {
            //try
            //{
            if (dgvItems.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(CustomerId) || Convert.ToInt32(CustomerId) < 1)
                    CustomerId = string.IsNullOrEmpty(cbCustomer.ValueMember) ? string.Empty : cbCustomer.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomer.SelectedItem)).Row[cbCustomer.ValueMember]);//Convert.ToString(cbCustomer.SelectedValue);
                string GrandTotal = lblGrandTotal.Text;
                string Discount = txtTotalDiscount.Text;
                string NetTotal = txtNetTotal.Text;
                string Payment = txtPayment.Text;
                decimal Arearrs = 0;
                decimal.TryParse(lblArearrs.Text, out Arearrs);
                if (chkCash.Checked || cbCustomer.Text.ToLower() == "cash")
                {
                    if (Arearrs > 0)
                    {
                        MessageBox.Show("Cash sale should have full payment.", "Cash Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (Arearrs < 0)
                    {
                        MessageBox.Show("Cash Customer can not pay more than Receipt Total.", "Cash Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                DataTable dt = item.SelectEmptyReceiptDetailTable();
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    decimal sprice = 0;
                    decimal qty = 0;
                    decimal total = 0;
                    decimal disc = 0;
                    decimal ftotal = 0;
                    decimal discPerItem = 0;

                    decimal.TryParse(Convert.ToString(row.Cells["colSalePrice"].Value), out sprice);
                    decimal.TryParse(Convert.ToString(row.Cells["colQuantity"].Value), out qty);
                    decimal.TryParse(Convert.ToString(row.Cells["colTotal"].Value), out total);
                    decimal.TryParse(Convert.ToString(row.Cells["colDiscount"].Value), out disc);
                    decimal.TryParse(Convert.ToString(row.Cells["colFinalTotal"].Value), out ftotal);
                    decimal.TryParse(Convert.ToString(row.Cells["colDiscountPerItem"].Value), out discPerItem);

                    DataRow dr = dt.NewRow();
                    dr["Id"] = row.Cells["colSerial"].Value;
                    dr["ItemId"] = row.Cells["colItemId"].Value;
                    dr["SalePrice"] = sprice;
                    dr["Quantity"] = qty;
                    dr["GrandTotal"] = total;
                    dr["Discount"] = disc;
                    dr["Total"] = ftotal;
                    dr["ItemDiscount"] = discPerItem;

                    dt.Rows.Add(dr);
                }
                long receiptId = item.SaveReceipt(
                    CustomerId,
                    GrandTotal,
                    Discount,
                    NetTotal,
                    Payment,
                    Arearrs.ToString(),
                    txtComments.Text, txtComments.Text,
                    dt,
                    chkIsReturn.Checked,"0");

                UserLog.Log(Common.CURRENT_USER.Id, chkIsReturn.Checked? UserActions.Made_A_Return_Receipt : UserActions.Made_A_Sale_Receipt ,
                    string.Format("Customer : {0} ,  Receipt No : {1}", chkCash.Checked?txtCashName.Text : lblCustomerName.Text, receiptId));

                DialogResult dialogue = MessageBox.Show("Receipt has been saved sucessfully." + Environment.NewLine + "Do you want to print ?", "Sale Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogue == DialogResult.Yes)
                {
                    ReceiptViewer receipt = new ReceiptViewer(new ReportInfo { Id = receiptId, Report = Report.Receipt });
                    receipt.ShowDialog();

                }
                else
                {
                }
                ResetReceipt();
                BindAllItemsGrid();
                lblNextReceiptNo.Text = Common.GetNextId(Modules.Receipt).ToString();

            }
            else
            {
                MessageBox.Show("Erroe! No Item for receipt...", "No Item for receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            //catch (Exception ex)
            //{
            //    ExceptionLog.LogException(Modules.POS, "Save", ex);
            //}
        }
        void ResetReceipt()
        {
            //lblCompany.Text = string.Empty;
            lblCustomerName.Text = string.Empty;
            lblGrandTotal.Text = "0.00";
            //lblItemName.Text = string.Empty;
            //lblStock.Text = string.Empty;
            txtComments.Text = string.Empty;
            txtPayment.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtTotalDiscount.Text = string.Empty;
            lblCustomerBalance.Text = string.Empty;
            txtReturnReceiptNo.Text = string.Empty;
            dgvItems.Rows.Clear();
            chkIsReturn.Checked = false;
        }
        void PopulateCustomer()
        {
            //try
            //{
            string value = string.IsNullOrEmpty(cbCustomer.ValueMember) ? string.Empty : cbCustomer.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomer.SelectedItem)).Row[cbCustomer.ValueMember]);//Convert.ToString(cbCustomer.SelectedValue);
            string text = Convert.ToString(cbCustomer.Text);
            if (value != text)
            {
                int customerId = 0;
                int.TryParse(string.IsNullOrEmpty(cbCustomer.ValueMember) ? string.Empty : cbCustomer.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCustomer.SelectedItem)).Row[cbCustomer.ValueMember]), out customerId);
                if (customerId == 0)
                    customerId = 1;
                Customer customer = new Customer();
                DataTable dt = customer.SelectCustomerById(customerId.ToString());
                if (dt != null)
                {
                    lblCustomerName.Text = Convert.ToString(dt.Rows[0]["CustomerName"]);
                    lblCustomerBalance.Text = Convert.ToDouble(dt.Rows[0]["CustomerBalance"]).ToString("#0.00");
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    ExceptionLog.LogException(Modules.POS, "PopulateCustomer", ex);
            //}
        }
        #endregion Method

        void SetArrears()
        {
            decimal discount = 0;
            decimal.TryParse(txtTotalDiscount.Text, out discount);
            decimal total = 0;
            decimal.TryParse(lblGrandTotal.Text, out total);
            decimal payment = 0;
            decimal.TryParse(txtPayment.Text, out payment);
            txtNetTotal.Text = (total - discount).ToString("0.00");
            lblArearrs.Text = (total - discount - payment).ToString("0.00");

        }




        #region Main Menu Events
        private void btnCompany_Click(object sender, EventArgs e)
        {
            frmCompany company = new frmCompany();
            company.ShowDialog();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.ShowDialog();
        }
        private void btnItem_Click(object sender, EventArgs e)
        {
            frmItem item = new frmItem();
            item.ShowDialog();
        }
        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop shop = new frmShop();
            shop.ShowDialog();
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            POS frmPOS = new POS();
            frmPOS.ShowDialog();
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice frm = new frmInvoice();
            frm.ShowDialog();
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock stock = new frmStock();
            stock.ShowDialog();
        }
        #endregion Main Menu Events





        #region Data Grid View Events
        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvItems.Columns[e.ColumnIndex].Name;
            if (colName == "colSalePrice" || colName == "colQuantity" || colName == "colDiscount")
            {
                try
                {
                    double Price = 0;
                    long Qty = 0;
                    double Discount = 0;
                    long stock = 0;

                    string strPrice = Convert.ToString(dgvItems.Rows[e.RowIndex].Cells["colSalePrice"].Value);
                    string strQty = Convert.ToString(dgvItems.Rows[e.RowIndex].Cells["colQuantity"].Value);
                    string strDiscount = Convert.ToString(dgvItems.Rows[e.RowIndex].Cells["colDiscount"].Value);
                    string strStock = Convert.ToString(dgvItems.Rows[e.RowIndex].Cells["colStock"].Value);
                    long.TryParse(strStock, out stock);


                    string errorMessage = string.Empty;
                    if (!double.TryParse(strPrice, out Price) || Price <= 0)
                    {
                        errorMessage = "Invalid Price...";

                    }
                    if (!long.TryParse(strQty, out Qty) || Qty <= 0)
                    {
                        if (string.IsNullOrEmpty(errorMessage))
                        {
                            errorMessage = "Invalid Quantity...";
                            return;
                        }
                        else
                            errorMessage += Environment.NewLine + "Invalid Quantity...";
                    }

                    if (!long.TryParse(strQty, out Qty) || Qty <= 0)
                    {
                        if (string.IsNullOrEmpty(errorMessage))
                        {
                            errorMessage = "Invalid Quantity...";
                            return;
                        }
                        else
                            errorMessage += Environment.NewLine + "Invalid Quantity...";
                    }


                    if (Qty > stock)
                    {
                        if (AllowShortStockSelling)
                        {
                            dgvItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                            dgvItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                        }
                        else
                        {
                            Qty = stock;
                            MessageBox.Show("Quantity can exceed items in stock.");
                        }
                    }
                    else
                    {
                        dgvItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        dgvItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (!double.TryParse(strDiscount, out Discount) || Discount < 0 || Discount >= 100)
                    {
                        if (string.IsNullOrEmpty(errorMessage))
                            errorMessage = "Invalid Discount. Plese use a value between 0 and 100";
                        else
                            errorMessage += Environment.NewLine + "Invalid Discount. Plese use a value between 0 and 100";
                    }
                    if (string.IsNullOrEmpty(errorMessage))
                    {
                        double gTotal = Qty * Price;
                        //double tDiscount = Qty * Discount;
                        double Total = gTotal - (gTotal * Discount / 100);
                        dgvItems.Rows[e.RowIndex].Cells["colSalePrice"].Value = Price.ToString("#0.00");
                        dgvItems.Rows[e.RowIndex].Cells["colTotal"].Value = gTotal.ToString("#0.00");
                        //dgvItems.Rows[e.RowIndex].Cells["colDiscount"].Value = tDiscount.ToString("#0.00");
                        dgvItems.Rows[e.RowIndex].Cells["colFinalTotal"].Value = Total.ToString("#0.00");

                        SetTotals();
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvItems.Rows[e.RowIndex].Cells[colName].Selected = true;
                    }
                }
                catch (Exception ex)
                {
                    ExceptionLog.LogException(Modules.POS, "dgvItems_CellEndEdit", ex, "POS Exception");
                }
            }
        }
        private void dgvItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }
        private void dgvItems_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvItems.Rows.Count - 1 && e.ColumnIndex == dgvItems.Columns.Count - 1)
            {
                cbCustomer.Focus();
            }
            else
            {
                //LeaveColIndex = e.ColumnIndex;
                //LeaveRowIndex = e.RowIndex;
            }

        }
        private void dgvItems_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //return;
            //string colPrice = "colSalePrice";
            //string colQuantity = "colQuantity";
            //string colDiscount = "colDiscount";
            //string colName = dgvItems.Columns[e.ColumnIndex].Name;
            //if (colName != colPrice && colName != colQuantity && colName != colDiscount)
            //{
            //    DataGridViewCell cell = null;
            //    if (e.ColumnIndex < 5)
            //    {
            //        if (LeaveRowIndex == 0)
            //        {
            //            LeaveRowIndex = -1;
            //            cboItems.Focus();
            //            return;
            //        }
            //        cell = dgvItems.Rows[e.RowIndex].Cells[5];

            //    }
            //    else if (e.ColumnIndex == 7 && LeaveColIndex == 6)
            //    {
            //        cell = dgvItems.Rows[e.RowIndex].Cells[8];
            //    }
            //    else if (e.ColumnIndex == 7 && LeaveColIndex == 8)
            //    {
            //        cell = dgvItems.Rows[e.RowIndex].Cells[6];
            //    }
            //    else if (e.ColumnIndex > 8)
            //    {
            //        if (LeaveRowIndex == dgvItems.Rows.Count - 1)
            //        {
            //            LeaveRowIndex = -1;
            //            cbCustomer.Focus();
            //            return;
            //        }
            //        cell = dgvItems.Rows[e.RowIndex].Cells[8];
            //    }
            //    if (cell != null)
            //    {
            //        this.BeginInvoke(new OverrideFocusDelegate(OverrideFocus), cell);
            //    }
            //}
        }
        #endregion Data Grid View Events



        private void txtTotalDiscount_Leave(object sender, EventArgs e)
        {


            decimal gtotal = 0;
            decimal discount = 0;
            decimal nettoal = 0;
            decimal payment = 0;

            decimal.TryParse(lblGrandTotal.Text, out gtotal);
            decimal.TryParse(txtTotalDiscount.Text, out discount);
            nettoal = gtotal - discount;
            decimal.TryParse(txtPayment.Text, out payment);

            txtNetTotal.Text = Convert.ToString(nettoal);
            //txtPayment.Text = Convert.ToString(payment);
            lblArearrs.Text = (nettoal - payment).ToString("0.00");


        }
        private void dgvItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
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
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "SetTotals", ex, "POS Exception");
            }
        }
        private void txtPayment_Leave(object sender, EventArgs e)
        {
            SetArrears();
            //decimal nettoal = 0;
            //decimal payment = 0;
            //decimal.TryParse(txtNetTotal.Text, out nettoal);
            //decimal.TryParse(txtPayment.Text, out payment);
            //lblArearrs.Text = Convert.ToString(nettoal - payment);
        }
        void BindAllItemsGrid()
        {
            AllItemsDataTable = item.SelectAllItem();
            dgvAllItems.AutoGenerateColumns = false;
            if (UseItemNames)
            {
                AllItemsDataTable.DefaultView.Sort = "ItemName";
            }
            else
            {
                AllItemsDataTable.DefaultView.Sort = "ItemCode";
            }

            dgvAllItems.DataSource = AllItemsDataTable;
            dgvAllItems.Columns["colItemId_All"].DataPropertyName = "ItemId";
            dgvAllItems.Columns["colItemCode_All"].DataPropertyName = "ItemCode";
            dgvAllItems.Columns["colItemName_All"].DataPropertyName = "ItemName";
            dgvAllItems.Columns["colPacking_All"].DataPropertyName = "Packing";
            dgvAllItems.Columns["colCompany_All"].DataPropertyName = "CompanyName";
            dgvAllItems.Columns["colStock_All"].DataPropertyName = "ItemInStock";
            dgvAllItems.Columns["colSalePrice_all"].DataPropertyName = "SalePrice";
            dgvAllItems.Columns["colDiscount_All"].DataPropertyName = "Discount%";
            dgvAllItems.Columns["colCost_All"].DataPropertyName = "PurchasePrice";
            dgvAllItems.Columns["colCost_All"].Visible = PurchasePrice;
            //if (ckPuchasePrice.Checked)
            //{

            //}
            Common.FormatCurrencyColumn(dgvAllItems, "colSalePrice_all,colCost_All");
            //dgvAllItems.Columns["colCost_All"].Visible = Common.ShowPurchasePrice;
        }
        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtItemSearch.Text;

            if (!string.IsNullOrEmpty(filter))
            {
                if (!filter.Contains(Environment.NewLine))
                {
                    if (UseItemNames)
                    {
                        filter = "ItemName like '%" + filter + "%'";
                    }
                    else
                    {
                        filter = "ItemCode like '%" + filter + "%'";
                    }

                }
            }
            AllItemsDataTable.DefaultView.RowFilter = filter;


            if (dgvAllItems.Rows.Count == 1)
            {
                decimal price = 0;
                decimal.TryParse(Convert.ToString(dgvAllItems.Rows[0].Cells["colSalePrice_All"].Value), out price);
                if (price > 0)
                    txtPrice.Text = price.ToString("0.00");
                dgvAllItems.Rows[0].Selected = true;
                //AddToGrid();
            }
        }
        private void dgvAllItems_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AddToGrid();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.POS, "AddtoGrid", ex, "POS Exception");
            }
        }
        private void dgvAllItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRecentReceipt_Click(object sender, EventArgs e)
        {
            //frmRecentReceipt recentreceipt = new frmRecentReceipt();
            //if (recentreceipt != null)
            //{
            //    this.Visible = false;
            //    recentreceipt.ShowDialog();
            //    if (!this.IsDisposed)
            //    {
            //        this.Visible = true;
            //    }
            //}
        }

        private void ckPuchasePrice_CheckedChanged(object sender, EventArgs e)
        {
            PurchasePrice = ckPuchasePrice.Checked;
            BindAllItemsGrid();
        }

        private void chkCash_CheckedChanged(object sender, EventArgs e)
        {
            if (Common.IsCashAddressRequired)
            {
                cbCustomer.Visible = !chkCash.Checked;
                lblNameCaption.Visible = !chkCash.Checked;
                lblCustomerName.Visible = !chkCash.Checked;

                lblCashAddress.Visible = chkCash.Checked;
                txtCashAddress.Visible = chkCash.Checked;
                txtCashName.Visible = chkCash.Checked;
                txtCashName.Text = string.Empty;
                txtCashAddress.Text = string.Empty;
                lblCustomerBalance.Visible = !chkCash.Checked;
                if (chkCash.Checked)
                {
                    Customer customer = new Customer();
                    DataTable dtCustomer = customer.SelectCustomerByCode("CASH");
                    if (dtCustomer != null && dtCustomer.Rows.Count > 0)
                    {
                        txtCashName.Text = Convert.ToString(dtCustomer.Rows[0]["CustomerName"]);
                        txtCashAddress.Text = Convert.ToString(dtCustomer.Rows[0]["Address"]);
                    }
                    txtCashName.Focus();
                }

            }
        }

        private void txtCashName_Leave(object sender, EventArgs e)
        {
            //txtCashAddress.Focus();
        }

        private void txtItemSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.AcceptReturnInItemCombo))
                {
                    if (e.KeyCode == Keys.Return)
                    {
                        AddToGrid();

                        txtItemSearch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Invoice, "ReadKeyBoolean", ex, "Invoice Exception");
            }

        }
    }
}