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
    public partial class Login : Form
    {
        string SuperAdmin = "7D0CA46E298A8F0D977500BCFB4D6BE1";
        string SuperAdminPassword = "CE89FA6370AD3AE01B4469CDE5D97167";
        public string UserName = string.Empty;
        public bool AllowInvoice = false;
        public bool AllowStock = false;
        public bool AllowCompany = false;
        public bool AllowCustomer = false;
        public bool AllowItem = false;
        public bool AllowShop = false;
        public bool AllowReports = false;
        public bool AllowUserManagement = false;
        private bool IsValidRegistration = false;

        public DialogResult CustomResult = DialogResult.OK;

        #region Constructor
        public Login()
        {
            InitializeComponent();
            GetRegistryValues();
            PopulateCondifuration();
        }
        public Login(bool isValidRegistration)
        {
            IsValidRegistration = isValidRegistration;
            InitializeComponent();
            if (IsValidRegistration)
            {
                GetRegistryValues();
                PopulateCondifuration();
            }
            else
            {
                txtUserName.UseSystemPasswordChar = true;
            }
        }
        #endregion Constructor

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();

            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Login, "btnCancel", ex, "Login Exception");
            }
        }
        private void SetLoginFieldsNull()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        /*READ FROM REGISTRY*/
        private void GetRegistryValues()
        {
            try
            {
                RegistryHandler registry = RegistryHandler.ReadRegistry();
                if (registry != null && !string.IsNullOrEmpty(registry.Status))
                {
                    string Status = registry.Status.ToString();
                    if (Status == "True")
                    {
                        txtUserName.Text = registry.UserName.ToString();
                        txtPassword.Text = registry.Password.ToString();
                        ckRememberMe.Checked = true;
                    }
                    else
                    {
                        // SetLoginFieldsNull();
                    }
                }
                else
                {
                    // SetLoginFieldsNull();
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Login, "ReadRegistry", ex, "Login Exception");
            }
        }
        private void btnLgin_Click(object sender, EventArgs e)
        {
            try
            {
                this.CustomResult = System.Windows.Forms.DialogResult.No;
                if (!IsValidRegistration || Common.CalculateH(txtUserName.Text) == SuperAdmin)
                {
                    if (string.IsNullOrEmpty(txtUserName.Text))
                    {
                        lblError.Text = "Please enter the User Name...";
                        txtUserName.Focus();
                        lblError.Visible = true;
                    }
                    else if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        lblError.Text = "Please enter the Password...";
                        txtPassword.Focus();
                        lblError.Visible = true;
                    }
                    else if (Common.CalculateH(txtUserName.Text) == SuperAdmin && Common.CalculateH(txtPassword.Text) == SuperAdminPassword)
                    {
                        //if (IsValidRegistration)
                            CustomResult = DialogResult.Ignore;
                            this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Not Valid.");
                        //this.CustomResult = System.Windows.Forms.DialogResult.No;
                    }
                }
                else
                {
                    bool result = false;
                    string GetLienceKey = string.Empty;
                    string GetLienceReg = string.Empty;
                    //int comparedRegisterValue = 0;
                    //GetLienceReg = Convert.ToString(RegistryHandler.GetLienceKey());
                    ////GetLienceKey = Common.CreateUniqueKey();
                    //comparedRegisterValue = string.Compare(GetLienceKey, GetLienceReg);
                    //if (comparedRegisterValue>0)
                    //{
                    lblError.Visible = false;
                    if (string.IsNullOrEmpty(txtUserName.Text))
                    {
                        lblError.Text = "Please enter the User Name...";
                        txtUserName.Focus();
                        lblError.Visible = true;
                    }
                    else if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        lblError.Text = "Please enter the Password...";
                        txtPassword.Focus();
                        lblError.Visible = true;
                    }
                    else
                    {
                        DataTable dt = null;
                        dt = SystemUser.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                        result = SetUserSetting(dt);
                        if (result)
                        {
                            UserLog.Log(Common.CURRENT_USER.Id, UserActions.Logged_In_Suceessfully, "UserName:" + Common.CURRENT_USER.UserName );
                            if (ckRememberMe.Checked)
                            {
                                RegistryHandler registry = new RegistryHandler();
                                registry.WriteRegistry(txtUserName.Text, txtPassword.Text);
                            }
                            this.CustomResult = System.Windows.Forms.DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            this.CustomResult = System.Windows.Forms.DialogResult.No;
                            UserLog.Log(null, UserActions.Login_Faild, "UserName:" + txtUserName.Text);
                            SetLoginFieldsNull();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.CustomResult = System.Windows.Forms.DialogResult.No;
                ExceptionLog.LogException(Modules.Login, "Login", ex, "Login Exception");
            }
        }

        bool SetUserSetting(DataTable dt)
        {
            bool valid = false;

            if (dt != null && dt.Rows.Count > 0)
            {
                Common.CURRENT_USER.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                Common.CURRENT_USER.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                Common.CURRENT_USER.Name = Convert.ToString(dt.Rows[0]["Name"]);
                Common.CURRENT_USER.AllowCompany = Convert.ToBoolean(dt.Rows[0]["AllowCompany"]);
                Common.CURRENT_USER.AllowCustomer = Convert.ToBoolean(dt.Rows[0]["AllowCustomer"]);
                Common.CURRENT_USER.AllowInvoice = Convert.ToBoolean(dt.Rows[0]["AllowInvoice"]);
                Common.CURRENT_USER.AllowItem = Convert.ToBoolean(dt.Rows[0]["AllowItem"]);
                Common.CURRENT_USER.AllowReports = Convert.ToBoolean(dt.Rows[0]["AllowReports"]);
                Common.CURRENT_USER.AllowShop = Convert.ToBoolean(dt.Rows[0]["AllowShop"]);
                Common.CURRENT_USER.AllowStock = Convert.ToBoolean(dt.Rows[0]["AllowStock"]);
                Common.CURRENT_USER.AllowOrder = Convert.ToBoolean(dt.Rows[0]["AllowOrder"]);
                Common.CURRENT_USER.AllowUserManagement = Convert.ToBoolean(dt.Rows[0]["AllowUserManagement"]);
                Common.CURRENT_USER.AllowCompanyPayment = Convert.ToBoolean(dt.Rows[0]["AllowCompanyPayment"]);
                Common.CURRENT_USER.AllowCustomerPayment = Convert.ToBoolean(dt.Rows[0]["AllowCustomerPayment"]);

                Common.CURRENT_USER.AllowReturnSale= Convert.ToBoolean(dt.Rows[0]["AllowReturnSale"]);
                Common.CURRENT_USER.AllowReturnPurchase= Convert.ToBoolean(dt.Rows[0]["AllowReturnPurchase"]);
                valid = true;
                //this.Close();
            }
            else
            {
                //Common.CURRENT_USER = new CurrentUser();
                lblError.Text = "Invalid User Name and Password combination..";
                txtUserName.Focus();
                lblError.Visible = true;
            }
            return valid;
        }

        void PopulateCondifuration()
        {
            Common.UseItemNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseItemNames);
            Common.UseCompanyNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseCompanyNames);
            Common.UseCustomerNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseCustomerNames);
            Common.AcceptReturnInItemCombo = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.AcceptReturnInItemCombo);
            Common.EnableEntryTimeEditing = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.EnableEntryTimeEditing);
            Common.ShowPurchasePrice = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.ShowPurchasePrice);
            Common.AllowShortStockSelling = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.AllowShortStockSelling);
            Common.IsCashAddressRequired = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.IsCashAddressRequired);
            
        }
    }
}
