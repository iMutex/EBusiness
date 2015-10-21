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
    public partial class frmUser : ParentForm
    {
        public frmUser()
        {
            InitializeComponent();
            Common.BindUserCombo(ref cbSelectUser, false);
            EmptyField();

            //PopulateGrid();
            //ComboBind();

        }

        void SaveNewUser()
        {
            try
            {
                if (Common.IsCodeExists(txtUserName.Text, Modules.SystemUsers))
                {
                    MessageBox.Show("Error! User Name is Already exits." + Environment.NewLine + " Please try with other user Name "
                                   , "User Name Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else
                {


                    if (!string.IsNullOrEmpty(txtFullName.Text))
                    {

                        //if (!string.IsNullOrEmpty(txtContactNumber.Text))
                        //{

                        //    if (!string.IsNullOrEmpty(txtAddress.Text))
                        //    {

                        if (txtPassword.Text == txtRePassword.Text && !string.IsNullOrEmpty(txtPassword.Text))
                        {

                            if (SystemUser.CreateUpdateUser(txtUserName.Text, txtPassword.Text, txtFullName.Text, txtContactNumber.Text,
                                   txtAddress.Text, chkIsActive.Checked ? "1" : "0", chkInvoice.Checked ? "1" : "0", chkStock.Checked ? "1" : "0",
                                   chkCompany.Checked ? "1" : "0", chkCustomer.Checked ? "1" : "0", chkItem.Checked ? "1" : "0", chkShop.Checked ? "1" : "0", chkReports.Checked ? "1" : "0",
                                   chkUserManagement.Checked ? "1" : "0", chkOrder.Checked ? "1" : "0",
                                   chkCompanyPayment.Checked ? "1" : "0", chkCustomerPayment.Checked ? "1" : "0", chkReturnSale.Checked ? "1" : "0"
                         , chkReturnPurchase.Checked ? "1" : "0" , 0))
                            {
                                MessageBox.Show("New User is Saved Suceesfully", "Save Successfully"
                                                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error! Fail to create the new user." + Environment.NewLine + " Please contact to administrator"
                                                , "Error Fail to Create new User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error! Password is mismatch" + Environment.NewLine + "Try Again!"
                                            , "Error Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Error! Address is invalid","Invalid Address",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Error! Contact Number is invalid ","Invalid Contact Number",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Error! Full Name is invalid", "Invalid Full Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFullName.Focus();
                    }
                }

            }
            catch (Exception ex)
            {

                ExceptionLog.LogException(Modules.User, "New User", ex, " New User Exception");
            }
        }
        void UpdateUser()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtFullName.Text))
                {

                    //if (!string.IsNullOrEmpty(txtContactNumber.Text))
                    //{d

                    //    if (!string.IsNullOrEmpty(txtAddress.Text))
                    //    {

                    if (txtPassword.Text == txtRePassword.Text)
                    {
                        int Id = Convert.ToInt32(cbSelectUser.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSelectUser.SelectedItem)).Row[cbSelectUser.ValueMember]));
                        if (SystemUser.CreateUpdateUser(txtUserName.Text
                        , txtPassword.Text
                        , txtFullName.Text,
                         txtContactNumber.Text
                         , txtAddress.Text
                         , chkIsActive.Checked ? "1" : "0"
                         , chkInvoice.Checked ? "1" : "0"
                         , chkStock.Checked ? "1" : "0"
                         , chkCompany.Checked ? "1" : "0"
                         , chkCustomer.Checked ? "1" : "0"
                         , chkItem.Checked ? "1" : "0"
                         , chkShop.Checked ? "1" : "0"
                         , chkReports.Checked ? "1" : "0"
                         , chkUserManagement.Checked ? "1" : "0"
                         , chkOrder.Checked ? "1" : "0"
                         , chkCompanyPayment.Checked ? "1" : "0"
                         , chkCustomerPayment.Checked ? "1" : "0"
                         , chkReturnSale.Checked ? "1" : "0"
                         , chkReturnPurchase.Checked ? "1" : "0"
                         , Id))
                        {
                            MessageBox.Show("User is Suceesfully Updated", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error! Fail to save to new user infomation" + Environment.NewLine + "Try Again"
                                            , "Error Save New User Informaiton", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! Password is mismatch" + Environment.NewLine + "Try Again", "Mismatch Password"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Focus();
                    }


                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Error! Address is invalid", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error! Contact Number is invalid ", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    MessageBox.Show("Error! Full Name is invalid", "Invalid Full Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                }
            }
            catch (Exception ex)
            {

                ExceptionLog.LogException(Modules.User, "Update User", ex, "User Updated Exception");
            }

        }
        void PopulateDetail()
        {

            DataTable dtUser = null;

            //  int id = Convert.ToInt32(cbSelectUser.SelectedValue);
            int id = 0;
            if (int.TryParse(string.IsNullOrEmpty(cbSelectUser.ValueMember) ? string.Empty : cbSelectUser.SelectedItem == null ? string.Empty : Convert.ToString(((DataRowView)(cbSelectUser.SelectedItem)).Row[cbSelectUser.ValueMember]), out id) && id > 0)
            {
                dtUser = SystemUser.SelectUser(id.ToString(), null, null);

                if (dtUser != null && dtUser.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtUser.Rows)
                    {
                        txtFullName.Text = Convert.ToString(dr["Name"]);
                        txtAddress.Text = Convert.ToString(dr["Address"]);
                        txtContactNumber.Text = Convert.ToString(dr["ContactNumber"]);
                        txtUserName.Text = Convert.ToString(dr["UserName"]);
                        txtPassword.Text = Convert.ToString(dr["Password"]);
                        txtRePassword.Text = Convert.ToString(dr["Password"]);
                        chkCustomer.Checked = Convert.ToBoolean(dr["AllowCustomer"]);
                        chkCompany.Checked = Convert.ToBoolean(dr["AllowCompany"]);
                        chkInvoice.Checked = Convert.ToBoolean(dr["AllowInvoice"]);
                        chkIsActive.Checked = Convert.ToBoolean(dr["IsActive"]);
                        chkItem.Checked = Convert.ToBoolean(dr["AllowItem"]);
                        chkReports.Checked = Convert.ToBoolean(dr["AllowReports"]);
                        chkShop.Checked = Convert.ToBoolean(dr["AllowShop"]);
                        chkStock.Checked = Convert.ToBoolean(dr["AllowStock"]);
                        chkOrder.Checked = Convert.ToBoolean(dr["AllowOrder"]);
                        chkUserManagement.Checked = Convert.ToBoolean(dr["AllowUserManagement"]);
                        
                        chkCompanyPayment.Checked = Convert.ToBoolean(dr["AllowCompanyPayment"]);
                        chkCustomerPayment.Checked = Convert.ToBoolean(dr["AllowCustomerPayment"]);

                        chkReturnSale.Checked = Convert.ToBoolean(dr["AllowReturnSale"]);
                        chkReturnPurchase.Checked = Convert.ToBoolean(dr["AllowReturnPurchase"]);
                    }
                }
            }
        }

        void HideShowNewUpdate()
        {

            if (rbNew.Checked)
            {
                cbSelectUser.Visible = false;
                lblSelectCompany.Visible = false;

            }
            if (rbUpdate.Checked)
            {
                cbSelectUser.Visible = true;
                lblSelectCompany.Visible = true;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbNew.Checked)
            {
                try
                {

                    SaveNewUser();
                    EmptyField();
                }
                catch (Exception ex)
                {

                    ExceptionLog.LogException(Modules.User, "Save New User", ex, "Save New User Exception");
                }
            }
            else if (rbUpdate.Checked)
            {
                try
                {

                    UpdateUser();

                }
                catch (Exception exe)
                {

                    ExceptionLog.LogException(Modules.User, "User Update", exe, "Update User Exception");
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            HideShowNewUpdate();
            try
            {

                PopulateDetail();

            }
            catch (Exception exe)
            {

                ExceptionLog.LogException(Modules.User, "Populate User Detail", exe, "Populate User Detail Exception");
            }
        }

        private void EmptyField()
        {
            txtAddress.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRePassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
        }

        private void cbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                PopulateDetail();

            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.User, "Populate User Detail", ex, "User Populate Detail");

            }
        }

        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            EmptyField();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            dgvData.Columns.Clear();
            if (rbAll.Checked)
            {
                txtSearch.Visible = false;
                label1.Visible = false;
                
                PopulateGrid();
            }
            else if (rbSearchByCode.Checked || rbSearchByName.Checked)
            {
                txtSearch.Visible = true;
                label1.Visible = true;
            }
        }
        void PopulateGrid()
        {

            DataTable dt = null;
            if (rbAll.Checked)
            {
                dt = SystemUser.SelectUser(null, null, null);
            }
            else if (rbSearchByName.Checked)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    dt = SystemUser.SelectUser(null, txtSearch.Text, null);
                }
                else
                {
                    MessageBox.Show("Enter the Username for search ", "Type User Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbSearchByCode.Checked)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    dt = SystemUser.SelectUser(null, null, txtSearch.Text);
                }
                else
                {
                    MessageBox.Show("Enter the Name for search", "Type User Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                AddColumnGrid();
                foreach (DataRow dr in dt.Rows)
                {
                    string UserName = Convert.ToString(dr["UserName"]);
                    string Name = Convert.ToString(dr["Name"]);
                    bool AllowCustomer = Convert.ToBoolean(dr["AllowCustomer"]);
                    bool AllowCompany = Convert.ToBoolean(dr["AllowCompany"]);
                    bool AllowShop = Convert.ToBoolean(dr["AllowShop"]);
                    bool AllowReports = Convert.ToBoolean(dr["AllowReports"]);
                    bool AllowItem = Convert.ToBoolean(dr["AllowItem"]);
                    bool AllowInvoice = Convert.ToBoolean(dr["AllowInvoice"]);
                    bool AllowStock = Convert.ToBoolean(dr["AllowStock"]);
                    bool AllowUserManagement = Convert.ToBoolean(dr["AllowUserManagement"]);
                    dgvData.Rows.Add(UserName, Name, AllowCustomer, AllowCompany
                        , AllowShop, AllowReports, AllowItem, AllowInvoice, AllowStock
                        , AllowUserManagement);
                }
            }
        }
        void AddColumnGrid()
        {
            dgvData.AutoGenerateColumns = false;
            DataGridViewColumn colUserName = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            colUserName.CellTemplate = cell;
            colUserName.HeaderText = "UserName";
            colUserName.Name = "colUserName";
            colUserName.Visible = true;
            colUserName.Width = 60;
            dgvData.Columns.Add(colUserName);

            DataGridViewColumn colName = new DataGridViewColumn();
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            colName.CellTemplate = cell1;
            colName.HeaderText = "FullName";
            colName.Name = "colName";
            colName.Visible = true;
            colName.Width = 60;
            dgvData.Columns.Add(colName);

            DataGridViewCheckBoxColumn cbAllowCustomer = new DataGridViewCheckBoxColumn();
            cbAllowCustomer.HeaderText = "AllowCustomer";
            cbAllowCustomer.Name = "colAllowCustomer";
            cbAllowCustomer.Visible = true;
            cbAllowCustomer.Width = 40;
            dgvData.Columns.Add(cbAllowCustomer);

            DataGridViewCheckBoxColumn cbAllowCompany = new DataGridViewCheckBoxColumn();
            cbAllowCompany.HeaderText = "AllowCompany";
            cbAllowCompany.Name = "colAllowCompany";
            cbAllowCompany.Visible = true;
            cbAllowCompany.Width = 40;
            dgvData.Columns.Add(cbAllowCompany);

            DataGridViewCheckBoxColumn cbAllowShop = new DataGridViewCheckBoxColumn();
            cbAllowShop.HeaderText = "AllowShop";
            cbAllowShop.Name = "colAllowShop";
            cbAllowShop.Visible = true;
            cbAllowShop.Width = 40;
            dgvData.Columns.Add(cbAllowShop);
            DataGridViewCheckBoxColumn cbAllowReports = new DataGridViewCheckBoxColumn();
            cbAllowReports.HeaderText = "AllowReports";
            cbAllowReports.Name = "colAllowReports";
            cbAllowReports.Visible = true;
            cbAllowReports.Width = 40;
            dgvData.Columns.Add(cbAllowReports);

            DataGridViewCheckBoxColumn cbAllowItem = new DataGridViewCheckBoxColumn();
            cbAllowItem.HeaderText = "AllowItem";
            cbAllowItem.Name = "colAllowItem";
            cbAllowItem.Visible = true;
            cbAllowItem.Width = 40;
            dgvData.Columns.Add(cbAllowItem);

            DataGridViewCheckBoxColumn cbAllowInvoice = new DataGridViewCheckBoxColumn();
            cbAllowInvoice.HeaderText = "AllowInvoice";
            cbAllowInvoice.Name = "colAllowInvoice";
            cbAllowInvoice.Visible = true;
            cbAllowInvoice.Width = 40;
            dgvData.Columns.Add(cbAllowInvoice);

            DataGridViewCheckBoxColumn cbAllowStock = new DataGridViewCheckBoxColumn();
            cbAllowStock.HeaderText = "AllowStock";
            cbAllowStock.Name = "colAllowStock";
            cbAllowStock.Visible = true;
            cbAllowStock.Width = 40;
            dgvData.Columns.Add(cbAllowStock);

            DataGridViewCheckBoxColumn cbAllowUserMangement = new DataGridViewCheckBoxColumn();
            cbAllowUserMangement.HeaderText = "AllowUserManagement";
            cbAllowUserMangement.Name = "colAllowUser";
            cbAllowUserMangement.Visible = true;
            cbAllowUserMangement.Width = 40;
            dgvData.Columns.Add(cbAllowUserMangement);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            try
            {
                dgvData.Columns.Clear();
                PopulateGrid();
            }
            catch (Exception exe)
            {

                ExceptionLog.LogException(Modules.User, "Populate User Detail", exe, "Populate User Detail Excepion");
            }
        }




    }
}
