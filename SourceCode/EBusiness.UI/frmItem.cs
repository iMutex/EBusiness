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
    public partial class frmItem : EBusiness.ParentForm
    {
        #region Variables
        ItemType type = new ItemType();
        Item item = new Item();                 //object of Item class (bussisness layer)
        private Int16 flag;                     //flag used to check for Insertion or Updation
        private Int16 Status;               //STATUS USED FOR ITEMTYPE COMBOBOX
        private Int16 Status_Company;        //STATUS_COMPANY USED FOR COMPANY COMBO
        private Int16 Status_Item;                 //USED FOR SELECT ITEM COMBO
        #endregion Variables


        #region Constructor
        public frmItem()
        {
            InitializeComponent();
            chkitemView.Visible = false;
            rbSearchByCode.Checked = true;
            cbItemSearch.Visible = false;
            dgvItemTypesData.DataSource = type.SelectAllItemTypes();
            dgvItemTypesData.Columns["ItemTypeId"].Visible = false;
            txtBatchNo.Visible = false;
            dtExpiryDate.Visible = false;
            lblBatchNo.Visible = false;
            lblExpiryDate.Visible = false;
            flag = 0;
            Status = 0;
            Status_Item = 0;
            lblCompanyName.Visible = false;
            try
            {
                Common.BindItemCombo(ref cbSearchByCode, false);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "BindItemTypeCombo", ex, "Search By Code");
            }

        }
        #endregion Constructor


        #region Events
        private void tpNew_Enter(object sender, EventArgs e)
        {
            try
            {
                Common.BindCompanyComboOnlyActive(ref cbCompany, false);
                Common.BindItemCombo(ref cbAllNewUpdate, true);
                Common.BindItemTypeCombo(ref cbItemType, false);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "tpNew_Enter", ex, "Item Exception");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status == 0 && Status_Company == 0 && Status_Item == 0)
                {
                    MySaveNewUpdate();

                }
                else
                {
                    if (Status != 0)
                    {
                        Common.ShowInvlaidCodeMessage(cbItemType, Modules.Item);
                    }
                    else if (Status_Company != 0)
                    {
                        Common.ShowInvlaidCodeMessage(cbCompany, Modules.Supplier);

                    }
                    else if (Status_Item != 0)
                    {
                        MessageBox.Show("Error ! Invalid Item Name" + Environment.NewLine + "Please Select a Valid Item Name", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "SaveNewUpdate", ex, "Item Exception");
            }

        }
        private void cbAllNewUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PopulateDetail();
            }
            catch (Exception exe)
            {
                ExceptionLog.LogException(Modules.Item, "PopulateDetail", exe, "Item Exception");
            }

        }
        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                PopulateDetail();
                flag = 1;
            }
            catch (Exception exe)
            {
                ExceptionLog.LogException(Modules.Item, "PopulateDetail", exe, "Item Exception");
            }
        }
        private void btnCancelItemType_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                ExceptionLog.LogException(Modules.Item, "btnCancelItemType", ex, "Item Exception");
            }
        }
        //Item Type Events
        private void rbUpdateItemType_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PopulateItemTypeDetail();
                flag = 1;
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "PopulateItemTypeDetail", ex, "Item Exception");
            }

        }
        private void cboAllItemTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PopulateItemTypeDetail();
                flag = 1;
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "PopulateItemTypeDetail", ex, "Item Exception");
            }
        }
        private void btnNewItemType_Click(object sender, EventArgs e)
        {
            try
            {
                if (Status == 0)
                {
                    if (!string.IsNullOrEmpty(txtItemTypeName.Text))
                    {
                        if (rbNewItemType.Checked)
                        {
                            if (!Common.IsCodeExists(txtItemTypeName.Text, Modules.ItemType))//New
                            {
                                // if (type.InsertUpdateItemType("0", txtItemTypeName.Text, chkIsActive.Checked ? "1" : "0"))
                                if (type.InsertUpdateItemType("0", txtItemTypeName.Text, chkITemTypeIsActive.Checked ? "1" : "0")) ;
                                {
                                    MessageBox.Show("Item Type Save sucessfully.", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    PopulateItemTypeCombo();
                                    dgvItemTypesData.DataSource = type.SelectAllItemTypes();
                                    txtItemTypeName.Text = string.Empty;
                                }

                            }
                            else
                            {
                                MessageBox.Show("An item type already exists with code [" + txtItemTypeName.Text + "]." + Environment.NewLine +
                                    "Please try some other code.", "Item Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtItemTypeName.Focus();
                            }
                        }
                        else if (rbUpdateItemType.Checked)
                        {
                            string newvalue = txtItemTypeName.Text;

                            if (newvalue.Trim().ToLower() != cboAllItemTypes.Text.Trim().ToLower())
                            {
                                if (Common.IsCodeExists(txtItemTypeName.Text, Modules.ItemType))//New
                                {
                                    MessageBox.Show("An Item type with [" + txtItemTypeName.Text + "] already exists." + Environment.NewLine +
                                    "Please select correct item type.", "Item type incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtItemTypeName.Focus();
                                    ////if (type.InsertUpdateItemType(lblItemTypeId.Text , txtItemTypeName.Text, chkIsActive.Checked ? "1" : "0"))
                                    //if (type.InsertUpdateItemType(lblItemTypeId.Text, txtItemTypeName.Text, chkITemTypeIsActive.Checked ? "1" : "0"))
                                    //{
                                    //    MessageBox.Show("Item Type Update sucessfully.", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //    PopulateItemTypeCombo();
                                    //    dgvItemTypesData.DataSource = type.SelectAllItemTypes();
                                    //    txtItemTypeName.Text = string.Empty;
                                    //}
                                }
                                else
                                {
                                    if (type.InsertUpdateItemType(lblItemTypeId.Text, txtItemTypeName.Text, chkITemTypeIsActive.Checked ? "1" : "0"))
                                    {
                                        MessageBox.Show("Item Type Update sucessfully.", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        PopulateItemTypeCombo();
                                        dgvItemTypesData.DataSource = type.SelectAllItemTypes();
                                        txtItemTypeName.Text = string.Empty;
                                    }
                                }


                            }


                        }


                        //if (flag != 0)
                        //{
                        //    UpdateItems();
                        //}
                        //else if (!Common.IsCodeExists(txtItemTypeName.Text, Modules.ItemType) || flag == 0)
                        //{

                        //    if (type.InsertUpdateItemType(lblItemTypeId.Text, txtItemTypeName.Text, chkIsActive.Checked ? "1" : "0"))
                        //    {
                        //        MessageBox.Show("Item Type saved sucessfully.", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        PopulateItemTypeCombo();
                        //        dgvItemTypesData.DataSource = type.SelectAllItemTypes();
                        //        txtItemTypeName.Text = string.Empty;
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Error ocurred while saving sucessfully.");
                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("An item already exists with code [" + txtItemTypeName.Text + "]." +
                        //        "Please try some other code.");
                        //    txtItemCode.Focus();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Please enter the Item Type Name");
                    }
                }
                else
                {
                    //MessageBox.Show("Error ! Invalid Item Type" + Environment.NewLine + "Please Type a Valid Item Type", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "btnNewItem", ex, "Item Exception");
            }
        }
        private void tpNewItemType_Enter(object sender, EventArgs e)
        {
            //rbSearchByName.Visible = false;
            try
            {
                PopulateItemTypeCombo();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "PopulateItemTypeCombo", ex, "Item Exception");
            }
        }
        private void rbSearchOption_CheckedChanged(object sender, EventArgs e)
        {
            chkitemView.Visible = false;
            btnItemListPrint.Visible = rbAll.Checked || rbSearchByCompany.Checked;
            if (rbAll.Checked)
            {
                cbSearchByCode.Visible = false;
                label1.Visible = false;
                txtSearch.Visible = false;
                cbItemSearch.Visible = false;
                txtSearch.Visible = false;
                btnFind.Visible = false;
                cbSearchByCode.Visible = false;
                try
                {
                    BindItemSearchGrid(null, null, null, null, null, "1");
                }
                catch (Exception ex)
                {
                    ExceptionLog.LogException(Modules.Item, "BindItemSearchGrid", ex, "Item Exception");
                }
            }
            else if (rbSearchByCode.Checked)
            {
                cbSearchByCode.Visible = true;
                label1.Visible = true;
                txtSearch.Visible = false;
                cbSearchByCode.Visible = true;
                cbItemSearch.Visible = false;
                btnFind.Visible = true;
                txtSearch.Text = "";
                dgvData.DataSource = null;
                try
                {
                    Common.BindItemCombo(ref cbSearchByCode, false);
                }
                catch (Exception ex)
                {

                    ExceptionLog.LogException(Modules.Item, "BindItemTypeCombo", ex, "Search By Code");
                }
            }
            else if (rbSearchByName.Checked)
            {
                cbSearchByCode.Visible = false;
                label1.Visible = true;
                txtSearch.Visible = true;
                cbItemSearch.Visible = false;
                btnFind.Visible = true;
                cbSearchByCode.Visible = false;
                dgvData.DataSource = null;
            }
            else if (rbSearchByItemType.Checked)
            {
                cbSearchByCode.Visible = false;
                label1.Visible = true;
                txtSearch.Visible = false;
                cbItemSearch.Visible = true;
                btnFind.Visible = true;
                cbSearchByCode.Visible = false;
                cbItemSearch.DataSource = null;
                dgvData.DataSource = null;
                try
                {
                    Common.BindItemTypeCombo(ref cbItemSearch, false);
                }
                catch (Exception ex)
                {
                    ExceptionLog.LogException(Modules.Item, "BindItemTypeCombo", ex, "Item Exception");
                }
            }
            else if (rbSearchByCompany.Checked)
            {
                cbSearchByCode.Visible = false;
                label1.Visible = true;
                txtSearch.Visible = false;
                cbItemSearch.Visible = true;
                btnFind.Visible = true;
                cbSearchByCode.Visible = false;
                cbItemSearch.DataSource = null;
                dgvData.DataSource = null;
                try
                {
                    Common.BindCompanyComboOnlyActive(ref cbItemSearch, false);
                }
                catch (Exception ex)
                {
                    ExceptionLog.LogException(Modules.Item, "BindCompanyCombo", ex, "Item Exception");
                }
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            SearchView();
        }


        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvItemTypesData.DataSource = type.SelectAllItemTypes();
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "SelectItemTypes", ex, "Item Exception");
            }
        }
        private void gbMain_Enter(object sender, EventArgs e)
        {
            flag = 1;
        }
        private void chkitemView_CheckedChanged(object sender, EventArgs e)
        {
            string isActive = chkitemView.Checked ? "1" : "0";
            BindItemSearchGrid(null, null, null, null, null, isActive);
        }
        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCompanyName.Visible = true;
            Company comp = new Company();
            DataTable dt = null;

            string companyId = string.IsNullOrEmpty(cbCompany.ValueMember) ? string.Empty : Convert.ToString(((DataRowView)(cbCompany.SelectedItem)).Row[cbCompany.ValueMember]);
            if (!string.IsNullOrEmpty(companyId))
            {
                dt = comp.SelectCompanyById(companyId);
                lblCompanyName.Text = dt.Rows[0]["CompanyName"].ToString();
            }

        }
        //COMBO BOX ITEM TYPE LEAVE FOCUS
        private void cbItemType_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cbItemType.Items == null || cbItemType.Items.Count<1 || !Common.IsCodeExists(cbItemType.Text, Modules.ItemType))
                {
                    Status = 1;
                    Common.ShowInvlaidCodeMessage(cbItemType, Modules.ItemType);
                }
                else
                {
                    Status = 0;
                }
            }
            catch (Exception)
            {
            }
        }
        //COMBO BOX all ITEM TYPE LEAVE FOCUS
        private void cboAllItemTypes_Leave(object sender, EventArgs e)
        {
            if (rbUpdateItemType.Checked && !string.IsNullOrEmpty(cboAllItemTypes.Text) && !Common.IsCodeExists(cboAllItemTypes.Text, Modules.ItemType))
            {
                Status = 1;
                Common.ShowInvlaidCodeMessage(cboAllItemTypes, Modules.ItemType);
            }
            else if (rbUpdateItemType.Checked && string.IsNullOrEmpty(cboAllItemTypes.Text))
            {
                if (cboAllItemTypes.Items.Count > 0)
                    cboAllItemTypes.SelectedIndex = 0;
            }
            else
            {
                Status = 0;
            }
        }
        //COMBO BOX ITEM TYPE SEARCH LEAVE FOCUS
        private void cbItemSearch_Leave(object sender, EventArgs e)
        {
            if (rbSearchByCompany.Checked)
            {
                if (!string.IsNullOrEmpty(cbItemSearch.Text) && !Common.IsCodeExists(cbItemSearch.Text, Modules.Supplier))
                {
                    Status = 1;
                    dgvData.DataSource = null;
                    Common.ShowInvlaidCodeMessage(cbItemSearch, Modules.Supplier);
                }
                else if (string.IsNullOrEmpty(cbItemSearch.Text))
                {
                    if (cbItemSearch.Items.Count > 0)
                        cbItemSearch.SelectedIndex = 0;
                }
                else
                {
                    Status = 0;
                }

            }
            else if (rbSearchByItemType.Checked)
            {
                if (!string.IsNullOrEmpty(cbItemSearch.Text) && !Common.IsCodeExists(cbItemSearch.Text, Modules.ItemType))
                {
                    Status = 1;
                    dgvData.DataSource = null;
                    Common.ShowInvlaidCodeMessage(cbItemSearch, Modules.ItemType);
                }
                else if (string.IsNullOrEmpty(cbItemSearch.Text))
                {
                    if (cbItemSearch.Items.Count > 0)
                        cbItemSearch.SelectedIndex = 0;
                }
                else
                {
                    Status = 0;
                }

            }
        }
        //COMBO BOX SEARCH BY CODE LEAVE FOCUS
        private void cbSearchByCode_Leave(object sender, EventArgs e)
        {
            Status = 0;
            if (rbSearchByCode.Checked)
            {
                Status = Common.IsValidCode(cbSearchByCode, Modules.Item);


            }

            //if (rbUpdate.Checked && !string.IsNullOrEmpty(cbSearchByCode.Text) && !Common.IsCodeExists(cbSearchByCode.Text, Modules.Item))
            //{
            //    Status = 1;
            //    dgvData.DataSource = null;
            //    Common.ShowInvlaidCodeMessage(cbSearchByCode, Modules.Item);
            //}
            //else if (rbUpdate.Checked && string.IsNullOrEmpty(cbSearchByCode.Text)) 
            //{
            //    if (cbSearchByCode.Items.Count > 0)
            //        cbSearchByCode.SelectedIndex = 0;
            //}
            //else
            //{
            //    Status = 0;
            //}
        }
        //COMBO BOX VIEW ALL ITEMS LEAVE FOCUS
        private void ckViewAllItems_CheckedChanged(object sender, EventArgs e)
        {
            string isActive = ckViewAllItems.Checked ? "1" : "0";
            dgvItemTypesData.DataSource = type.SelectAllItemTypes(isActive);
            dgvItemTypesData.Columns["ItemTypeId"].Visible = false;

        }
        //ITEM LIST PRINT BUTTON
        private void btnItemListPrint_Click(object sender, EventArgs e)
        {
            ReportInfo info = null;
            if (rbAll.Checked)
                info = new ReportInfo() { Report = Report.ItemList, Options = chkitemView.Checked ? "1" : "0" };
            else
            {
                string CompanyId = cbItemSearch.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbItemSearch.SelectedItem)).Row[cbItemSearch.ValueMember]);
                info = new ReportInfo() { Report = Report.ItemListBySupplier, Options = CompanyId };
            }
            ReceiptViewer print = new ReceiptViewer(info);
            print.ShowDialog();
        }
        private void cbCompany_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cbCompany.Items == null || cbCompany.Items.Count < 1 || !Common.IsCodeExists(cbCompany.Text, Modules.Supplier))
                {
                    Status_Company = 1;
                    Common.ShowInvlaidCodeMessage(cbCompany, Modules.Supplier);
                }
                else
                {
                    Status_Company = 0;
                }
            }
            catch (Exception)
            {
            }
        }
        private void cbAllNewUpdate_Leave(object sender, EventArgs e)
        {
            if (rbUpdate.Checked && !string.IsNullOrEmpty(cbAllNewUpdate.Text) && !Common.IsCodeExists(cbAllNewUpdate.Text, Modules.Item, false))
            {
                Status_Item = 1;
                Common.ShowInvlaidCodeMessage(cbAllNewUpdate, Modules.Item);
            }
            else if (rbUpdate.Checked && string.IsNullOrEmpty(cbAllNewUpdate.Text))
            {
                if (cbAllNewUpdate.Items.Count > 0)
                    cbAllNewUpdate.SelectedIndex = 0;
            }
            else
            {
                Status_Item = 0;
            }


        }
        private void tcMain_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tpSearchItemType.Focus())
            {
                //if (rbAll.Checked)
                if (ckViewAllItems.Checked)
                {
                    try
                    {
                        string isActive = ckViewAllItems.Checked ? "1" : "0";
                        dgvItemTypesData.DataSource = type.SelectAllItemTypes(isActive);
                        dgvItemTypesData.Columns["ItemTypeId"].Visible = false;
                        //BindItemSearchGrid(null, null, null, null, null, "1");
                    }
                    catch (Exception ex)
                    {
                        ExceptionLog.LogException(Modules.Item, "BindItemSearchGrid", ex, "Item Exception");
                    }
                }
            }
            //if (tpSearchItemType.Focus())
            //    MessageBox.Show("Search Item Type");

        }
        #endregion Events

        #region Methods
        private void PopulateItemTypeCombo()
        {
            cboAllItemTypes.DataSource = type.SelectAllItemTypes("0");

            cboAllItemTypes.DisplayMember = "ItemTypeName";
            cboAllItemTypes.ValueMember = "ItemTypeId";
        }

        private void MySaveNewUpdate()
        {
            string itemCode = txtItemCode.Text;
            if (!string.IsNullOrEmpty(itemCode))
            {
                if (Common.IsCodeExists(txtItemCode.Text, Modules.Item) && rbNew.Checked)
                {
                    MessageBox.Show("An Item already exists with code [" + txtItemCode.Text + "]." + Environment.NewLine
                        + "Please try some other code.", "Error.Item [" + txtItemCode.Text + "]+ Already exits",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txtItemCode.Focus();
                    return;
                }
                string companyId = string.IsNullOrEmpty(cbCompany.ValueMember) ? string.Empty : cbCompany.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompany.SelectedItem)).Row[cbCompany.ValueMember]);
                string itemName = txtItemName.Text;
                string packing = txtPacking.Text;
                int packingValue = 0;
                if ((string.IsNullOrEmpty(txtPacking.Text)) || (int.TryParse(txtPacking.Text, out packingValue) && packingValue <= 0))
                {
                    MessageBox.Show("Error! Invalid Packing." + Environment.NewLine
                                         + "Please Enter a Positive Value.", "Invalid Packing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt = null;
                dt = Common.CheckCompanyItem(companyId, itemName, packing);
                if (dt.Rows.Count > 0 && rbNew.Checked)
                {
                    MessageBox.Show(string.Format("Item[{0}] Alraedy exit with for Supplier[{1}] with Packing[{2}]",
                        itemName, lblCompanyName.Text, packing));
                    return;
                }

                if (!string.IsNullOrEmpty(itemName))
                {
                    decimal purchasePrice = 0;
                    if (Common.IsMatch(txtPurchasePrice.Text) && decimal.TryParse(txtPurchasePrice.Text, out purchasePrice) && purchasePrice > 0)
                    {
                        decimal salePrice = 0;
                        if (Common.IsMatch(txtSalePrice.Text) & decimal.TryParse(txtSalePrice.Text, out salePrice) && salePrice > 0 && salePrice > purchasePrice)
                        {
                            decimal discount = 0;
                            if (string.IsNullOrEmpty(txtDiscount.Text) || (decimal.TryParse(txtDiscount.Text, out discount) && (discount >= 0 && discount <= 100)))
                            {
                                int stockLimit = 0;
                                if ((string.IsNullOrEmpty(txtMinStock.Text)) || (int.TryParse(txtMinStock.Text, out stockLimit) && stockLimit >= 0))
                                {

                                    string itemType = string.IsNullOrEmpty(cbItemType.ValueMember) ? string.Empty : cbItemType.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbItemType.SelectedItem)).Row[cbItemType.ValueMember]);
                                    if (item.InsertUpdateItem(
                                        rbNew.Checked ? "0" : lblId.Text,
                                            itemCode,
                                            itemName,
                                            itemType,
                                            packing,
                                            companyId,
                                            stockLimit.ToString(),
                                            purchasePrice.ToString(),
                                            salePrice.ToString(),
                                            discount.ToString(),
                                            chkIsActive.Checked ? "1" : "0",
                                            string.Empty,
                                            DateTime.Now.AddYears(50)
                                            )
                                      )
                                    {
                                        MessageBox.Show("Item record saved sucessfully.", "Item Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Common.BindItemCombo(ref cbAllNewUpdate, true);
                                        Common.BindItemCombo(ref cbSearchByCode, false);
                                        PopulateDetail();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error ocurred while saving Item record.", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Stock Limit." + Environment.NewLine
                                        + "Please use a valid value.", "Invalid Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Discount." + Environment.NewLine
                                    + "Please range between 0 and 100.", "Invalid Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //       MessageBox.Show("Please Enter the Correct formate for Sale Price" + Environment.NewLine +
                            //"It only allow maxmuim two  digit decimal like 99.99", "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Erro! Sale Price" + Environment.NewLine +
                                "Sale Price is greater then Purchase Price OR  It only allow maxmuim two  digit decimal like 99.99", "Format Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Correct formate for Purchase Price" + Environment.NewLine +
                     "It only allow maxmuim two  digit decimal like 99.99", "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Item Name is Required.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Item Code is Required.", "Code Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Commented Code
        //private void SaveNewUpdate()
        //{
        //    if (!string.IsNullOrEmpty(txtItemCode.Text))
        //    {
        //        if (!string.IsNullOrEmpty(txtItemName.Text))
        //        {
        //            if (Common.IsMatch(txtPurchasePrice.Text))
        //            {
        //                if (Common.IsMatch(txtSalePrice.Text))
        //                {
        //                    if (flag != 0)
        //                    {
        //                        SaveUpdates();

        //                        //SaveNew();
        //                    }
        //                    else
        //                    {
        //                        SaveNew();
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Please Enter the Correct formate for Sale Price" + Environment.NewLine +
        //             "It only allow maxmuim two  digit decimal like 99.99", "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Please Enter the Correct formate for Purchase Price" + Environment.NewLine +
        //             "It only allow maxmuim two  digit decimal like 99.99", "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Item Name is Required.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Item Code is Required.", "Code Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void SaveUpdates()
        //{
        //    decimal discount = 0;
        //    if (string.IsNullOrEmpty(txtDiscount.Text) || (decimal.TryParse(txtDiscount.Text, out discount) && (discount > 0 || discount < 100)))
        //    {
        //        decimal purchasePrice = 0;
        //        if (decimal.TryParse(txtPurchasePrice.Text, out purchasePrice) && purchasePrice > 0)
        //        {
        //            decimal salePrice = 0;
        //            if (decimal.TryParse(txtSalePrice.Text, out salePrice) && salePrice > 0 && salePrice > purchasePrice)
        //            {
        //                int stockLimit = 0;
        //                if ((string.IsNullOrEmpty(txtMinStock.Text)) || (int.TryParse(txtMinStock.Text, out stockLimit) && stockLimit >= 0))
        //                {
        //                    string ExpiryDate = Common.FormateDateForDB(dtExpiryDate.Value);
        //                    if (item.InsertUpdateItem(lblId.Text, txtItemCode.Text, txtItemName.Text, string.IsNullOrEmpty(cbItemType.ValueMember) ? string.Empty : cbItemType.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbItemType.SelectedItem)).Row[cbItemType.ValueMember]), txtPacking.Text
        //                            , string.IsNullOrEmpty(cbCompany.ValueMember) ? string.Empty : cbCompany.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompany.SelectedItem)).Row[cbCompany.ValueMember]), txtMinStock.Text, "0", txtPurchasePrice.Text, txtSalePrice.Text,
        //                            txtDiscount.Text, chkIsActive.Checked ? "1" : "0", txtBatchNo.Text, dtExpiryDate.Value))
        //                    {
        //                        MessageBox.Show("Item record saved sucessfully.", "Item Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        Common.BindItemCombo(ref cbAllNewUpdate, false);
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Error ocurred while saving Item record.", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Invalid Stock Limit." + Environment.NewLine
        //                        + "Please use a valid value.", "Invalid Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid Sales Price." + Environment.NewLine
        //                    + "Please use a valid amount.", "Invalid Sales Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }

        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid Purchase Price." + Environment.NewLine
        //                + "Please use a valid amount.", "Invalid Purchase Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid Discount." + Environment.NewLine
        //            + "Please range between 0 and 100.", "Invalid Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
        //private void SaveNew()
        //{
        //    int Companyid;
        //    int.TryParse(string.IsNullOrEmpty(cbCompany.ValueMember) ? string.Empty : cbCompany.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompany.SelectedItem)).Row[cbCompany.ValueMember]), out Companyid);
        //    DataTable dt = null;
        //    dt = Common.CheckCompanyItem(Companyid.ToString(), txtItemName.Text, txtPacking.Text);


        //    if (dt.Rows.Count > 0)
        //    {
        //        MessageBox.Show("Item Alraedy exit with Company Name");
        //    }
        //    else
        //    {
        //        if (!Common.IsCodeExists(txtItemCode.Text, Modules.Item))
        //        {
        //            decimal discount = 0;

        //            if (string.IsNullOrEmpty(txtDiscount.Text) || (decimal.TryParse(txtDiscount.Text, out discount) && (discount > 0 || discount < 100)))
        //            {
        //                decimal purchasePrice = 0;
        //                if (decimal.TryParse(txtPurchasePrice.Text, out purchasePrice) && purchasePrice > 0)
        //                {
        //                    decimal salePrice = 0;
        //                    if (decimal.TryParse(txtSalePrice.Text, out salePrice) && salePrice > 0 && salePrice > purchasePrice)
        //                    {
        //                        int stockLimit = 0;
        //                        //if(!(string.IsNullOrEmpty(txtMinStock.Text) && !(Convert.ToInt32(txtMinStock.Text)<0))){
        //                        if (txtMinStock.Text != "" && !(Convert.ToInt32(txtMinStock.Text) < 0))
        //                        {
        //                            string ExpiryDate = Common.FormateDateForDB(dtExpiryDate.Value);

        //                            if (Convert.ToInt32(txtPacking.Text) > 0)
        //                            {
        //                                if (item.InsertUpdateItem(lblId.Text, txtItemCode.Text, txtItemName.Text, string.IsNullOrEmpty(cbItemType.ValueMember) ? string.Empty : cbItemType.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbItemType.SelectedItem)).Row[cbItemType.ValueMember]), txtPacking.Text
        //                                    , string.IsNullOrEmpty(cbCompany.ValueMember) ? string.Empty : cbCompany.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbCompany.SelectedItem)).Row[cbCompany.ValueMember]), txtMinStock.Text, "0", txtPurchasePrice.Text, txtSalePrice.Text,
        //                                    txtDiscount.Text, chkIsActive.Checked ? "1" : "0", txtBatchNo.Text, dtExpiryDate.Value))
        //                                {
        //                                    if (flag == 0)
        //                                    {
        //                                        MessageBox.Show("Item record saved sucessfully.", "Item Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                                    }
        //                                    else
        //                                    {
        //                                        MessageBox.Show("Item record Update Successfully", "Item Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                                    }
        //                                    Common.BindItemCombo(ref cbAllNewUpdate, false);
        //                                    txtItemCode.Text = "";
        //                                    txtItemName.Text = "";
        //                                    txtPacking.Text = "0";
        //                                    txtPurchasePrice.Text = "";
        //                                    txtSalePrice.Text = "";
        //                                    txtDiscount.Text = "0.00";
        //                                    txtMinStock.Text = "0";
        //                                }
        //                                else
        //                                {
        //                                    MessageBox.Show("Error ocurred while saving Item record.", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                                }

        //                            }
        //                            else
        //                            {
        //                                MessageBox.Show("Invalid Packing Value." + Environment.NewLine + "Please use a Valid Value", "Invalid Packing Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                            }
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Invalid Stock Limit." + Environment.NewLine
        //                                + "Please use a valid value.", "Invalid Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                            txtMinStock.Focus();
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Invalid Sales Price." + Environment.NewLine
        //                            + "Please use a valid amount.", "Invalid Sales Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        txtSalePrice.Focus();
        //                    }

        //                }
        //                else
        //                {
        //                    MessageBox.Show("Invalid Purchase Price." + Environment.NewLine
        //                        + "Please use a valid amount.", "Invalid Purchase Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    txtPurchasePrice.Focus();
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid Discount." + Environment.NewLine
        //                    + "Please range between 0 and 100.", "Invalid Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                txtDiscount.Focus();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("An item already exists with code [" + txtItemCode.Text + "].", "An item [" + txtItemCode.Text + "] already exits", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            txtItemCode.Focus();
        //        }

        //    }
        //}
        #endregion

        void PopulateDetail()
        {

            if (rbUpdate.Checked)
            {
                try
                {
                    lblSelectCompany.Visible = true;
                    cbAllNewUpdate.Visible = true;
                    string Id = string.IsNullOrEmpty(cbAllNewUpdate.ValueMember) ? string.Empty : (cbAllNewUpdate.SelectedItem != null ? Convert.ToString(((DataRowView)(cbAllNewUpdate.SelectedItem)).Row[cbAllNewUpdate.ValueMember]) : string.Empty);//;
                    lblId.Text = Id;
                    if (!string.IsNullOrEmpty(Id))
                    {
                        DataTable dt = item.SelectItemById(Id);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            txtItemCode.Text = Convert.ToString(row["ItemCode"]);
                            txtItemCode.Enabled = false;
                            txtItemName.Text = Convert.ToString(row["ItemName"]);
                            txtMinStock.Text = Convert.ToString(row["StockLimit"]);
                            txtPurchasePrice.Text = Convert.ToDecimal(row["PurchasePrice"]).ToString("0.00");
                            txtSalePrice.Text = Convert.ToDecimal(row["SalePrice"]).ToString("0.00");
                            txtPacking.Text = Convert.ToString(row["Packing"].ToString());
                            txtDiscount.Text = Convert.ToString(row["Discount%"].ToString());
                            cbCompany.SelectedIndex = cbCompany.FindString(Convert.ToString(row[cbCompany.DisplayMember]));
                            cbItemType.SelectedIndex = cbItemType.FindString(Convert.ToString(row[cbItemType.DisplayMember])); // cbItemType.SelectedValue = Convert.ToString(row["ItemType"]);
                            chkIsActive.Checked = Convert.ToBoolean(row["IsActive"]);
                            int stock = 0;
                            int.TryParse(Convert.ToString(row["ItemInStock"]), out stock);
                            chkIsActive.Enabled = stock == 0;

                        }
                        else
                        {
                            Reset(true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                Reset(false);

            }
        }
        void Reset(bool Update)
        {
            txtItemCode.Text = string.Empty;
            txtItemCode.Enabled = true;
            txtItemName.Text = string.Empty;
            txtMinStock.Text = string.Empty;
            txtPurchasePrice.Text = string.Empty;
            txtSalePrice.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtPacking.Text = "0";
            txtDiscount.Text = "0.00";
            txtMinStock.Text = "0";

            chkIsActive.Checked = true;

            lblId.Text = "0";

            lblSelectCompany.Visible = Update;
            cbAllNewUpdate.Visible = Update;
        }
        private void UpdateItems()
        {
            if (type.InsertUpdateItemType(lblItemTypeId.Text, txtItemTypeName.Text, chkITemTypeIsActive.Checked ? "1" : "0"))
            {
                if (flag == 0)
                {
                    MessageBox.Show("Item Type saved sucessfully.", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Item Type Update sucessfully.", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = 0;

                }
                PopulateItemTypeCombo();
                dgvItemTypesData.DataSource = type.SelectAllItemTypes();
            }

        }
        void PopulateItemTypeDetail()
        {
            if (rbUpdateItemType.Checked)
            {
                lblSelectItemType.Visible = true;
                cboAllItemTypes.Visible = true;
                string Id = string.IsNullOrEmpty(cboAllItemTypes.ValueMember) ? string.Empty : (cboAllItemTypes.SelectedItem != null ? Convert.ToString(((DataRowView)(cboAllItemTypes.SelectedItem)).Row[cboAllItemTypes.ValueMember]) : string.Empty);
                lblItemTypeId.Text = Id;
                if (!string.IsNullOrEmpty(Id))
                {
                    DataTable dt = type.SelectItemTypeById(Id);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        txtItemTypeName.Text = Convert.ToString(row["ItemTypeName"]);
                        chkITemTypeIsActive.Checked = Convert.ToBoolean(row["IsActive"]);
                    }
                }
            }
            else
            {
                txtItemTypeName.Text = string.Empty;
                chkITemTypeIsActive.Checked = true;
                lblSelectItemType.Visible = false;
                cboAllItemTypes.Visible = false;
                lblItemTypeId.Text = "0";
            }
        }
        void BindItemSearchGrid(string ItemId, string ItemCode, string ItemName, string ItemType, string CompanyId, string isActive)
        {
            chkitemView.Visible = true;
            dgvData.DataSource = null;
            DataTable dt = item.SelectItem(ItemId, ItemCode, ItemName, ItemType, CompanyId, isActive, 0);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvData.DataSource = dt;
                if (dt.Columns.Count > 3)
                {
                    dgvData.Columns[0].Visible = false; //ItemId
                    dgvData.Columns[1].Visible = false; //Item.CompanyId
                    dgvData.Columns[2].Visible = false; //Item.ItemTypeId
                    dgvData.Columns[8].Visible = false;
                    dgvData.Columns[9].Visible = false;



                    dgvData.Columns[3].HeaderText = "Code"; //Item.ItemTypeId
                    dgvData.Columns[4].HeaderText = "Name"; //Item.ItemTypeId
                    dgvData.Columns[5].HeaderText = "Packing"; //Item.ItemTypeId
                    dgvData.Columns[6].HeaderText = "Supplier"; //Item.ItemTypeId
                    dgvData.Columns[7].HeaderText = "Type"; //Item.ItemTypeId
                    dgvData.Columns[8].HeaderText = "Stock"; //Item.ItemTypeId
                    dgvData.Columns[9].HeaderText = "OnOrder"; //Item.ItemTypeId
                    dgvData.Columns[10].HeaderText = "P.Price"; //Item.ItemTypeId
                    dgvData.Columns[11].HeaderText = "S.Price"; //Item.ItemTypeId
                    dgvData.Columns[13].HeaderText = "Limit"; //Item.ItemTypeId

                    Common.FormatCurrencyColumn(dgvData, "PurchasePrice,SalePrice,Discount%,StockLimit");
                }
            }
        }
        private void SearchView()
        {
            string ItemId = null;
            string ItemCode = null;
            string ItemName = null;
            string ItemType = null;
            string CompanyId = null;

            if (rbSearchByCode.Checked)
            {
                if (cbSearchByCode.SelectedIndex > -1)
                {
                    ItemId = string.IsNullOrEmpty(cbSearchByCode.ValueMember) ? string.Empty : cbSearchByCode.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSearchByCode.SelectedItem)).Row[cbSearchByCode.ValueMember]);
                }
                else
                {
                    MessageBox.Show("Error ! Invalid Item Code" + Environment.NewLine + "Please Select a Valid Item Code for Search", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (rbSearchByName.Checked)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    ItemName = txtSearch.Text;
                }
                else
                {
                    MessageBox.Show("Error ! Invalid Item Name" + Environment.NewLine + "Please Select a Valid Item Name for Search", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (rbSearchByItemType.Checked)
            {
                if (Status == 0)
                {
                    if (cbItemSearch.SelectedIndex > -1)
                    {
                        ItemType = string.IsNullOrEmpty(cbItemSearch.ValueMember) ? string.Empty : cbItemSearch.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbItemSearch.SelectedItem)).Row[cbItemSearch.ValueMember]);//Convert.ToString(cbItemSearch.SelectedValue);
                    }
                }
                else
                {
                    MessageBox.Show("Error ! Invalid Item Type" + Environment.NewLine + "Please Enter a Valid Item Type for Search", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            else if (rbSearchByCompany.Checked)
            {
                if (cbItemSearch.SelectedIndex > -1)
                {
                    CompanyId = cbItemSearch.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbItemSearch.SelectedItem)).Row[cbItemSearch.ValueMember]);

                }
                else if (cbItemSearch.Items.Count > 0)
                {
                    cbItemSearch.SelectedIndex = 0;
                    CompanyId = cbItemSearch.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbItemSearch.SelectedItem)).Row[cbItemSearch.ValueMember]);
                }
                else
                {
                    MessageBox.Show("Error ! Invalid Supplier Name" + Environment.NewLine + "Please Enter a Valid Supplier Name for Search", "Item Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                BindItemSearchGrid(ItemId, ItemCode, ItemName, ItemType, CompanyId, "1");
                chkitemView.Visible = false;
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "BindItemSearchGrid", ex, "Item Exception");
            }
        }
        #endregion Methods

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab.Name == "tpView")
                SearchView();
        }
    }
}
