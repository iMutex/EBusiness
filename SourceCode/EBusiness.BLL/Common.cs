using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using EBusiness.DAL;
using System.Drawing;
using System.Management;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;



namespace EBusiness.BLL
{
    public class Common
    {
        public static bool UseItemNames = false;
        public static bool UseCompanyNames = false;
        public static bool UseCustomerNames = false;
        public static bool AcceptReturnInItemCombo = false;
        public static bool EnableEntryTimeEditing = false;
        public static bool ShowPurchasePrice = false;
        public static bool AllowShortStockSelling = false;
        public static bool IsCashAddressRequired = false;
        public static string DatabaseBackupLocation = string.Empty;
        public static bool ShowDashBoard = false;
        public static bool ShowModelDialogs = false;

        public static CurrentUser CURRENT_USER = new CurrentUser();

        public static string CalculateH(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static void MarkRed(Control ctrl)
        {
            ctrl.ForeColor = Color.Red;
        }
        public static bool IsMatch(string Text)
        {
            bool result = false;
            decimal amunt = 0;
            if (decimal.TryParse(Text, out amunt))
            {
                if (Text.Contains("."))
                {
                    int index = Text.IndexOf(".");
                    if (Text.Length - 3 > index)
                    {
                        result = false;
                    }
                    else
                        result = true;
                }
                else
                {
                    result = true;
                }
            }

            //Regex currencyReg = new Regex(@"^[-+]?[0-9]\d{0,9}(\.\d{1,2})?%?$");
            //new Regex(@"^(\d)*\.\d{2}$");
            //return (currencyReg.IsMatch(Text));
            return result;


        }


        public static void MarkNormal(Control ctrl)
        {
            ctrl.ForeColor = Color.Black;
        }
        public static string FormateDateForDB(DateTime? date)
        {
            if (date == DateTime.MinValue || date == DateTime.MaxValue || date == null)
                return null;
            return date.Value.ToString("yyyy/MM/dd");
        }

        public static void BindItemComboOnlyActive(ref ComboBox cbo, bool ALL)
        {
            bool UseNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseItemNames);
            Item item = new Item();
            DataTable dt = new DataTable();
            string valueMember = "ItemId";
            string displayMember = "ItemCode";
            if (UseNames)
                displayMember = "ItemName";
            dt = item.SelectAllActiveItem();
            BindCombo(ref cbo, dt, displayMember, valueMember, ALL);
            if (cbo.Items.Count > 0)
                cbo.SelectedIndex = 0;
        }
        public static void BindItemCombo(ref ComboBox cbo, bool ALL)
        {
            bool UseNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseItemNames);
            Item item = new Item();
            DataTable dt = new DataTable();
            string valueMember = "ItemId";
            string displayMember = "ItemCode";
            if (UseNames)
                displayMember = "ItemName";
            dt = item.SelectAllItem();
            BindCombo(ref cbo, dt, displayMember, valueMember, ALL);
            if (cbo.Items.Count > 0)
                cbo.SelectedIndex = 0;
        }
        public static void BindItemTypeCombo(ref ComboBox cbo, bool ALL)
        {
            ItemType item = new ItemType();
            DataTable dt = new DataTable();
            string valueMember = "ItemTypeId";
            string displayMember = "ItemTypeName";
            dt = item.SelectAllItemTypes();
            BindCombo(ref cbo, dt, displayMember, valueMember, ALL);
            if (cbo.Items.Count > 0)
                cbo.SelectedIndex = 0;
        }
        public static void BindCompanyCombo(ref ComboBox cbo, bool ALL)
        {
            bool UseNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseCompanyNames);
            Company item = new Company();
            DataTable dt = new DataTable();
            string valueMember = "CompanyId";
            string displayMember = "CompanyCode";
            if (UseNames)
                displayMember = "CompanyName";
            dt = item.SelectAllCompanies();
            BindCombo(ref cbo, dt, displayMember, valueMember, ALL);
            if (cbo.Items.Count > 0)
                cbo.SelectedIndex = 0;
        }
        public static void BindCompanyComboOnlyActive(ref ComboBox cbo, bool ALL)
        {
            bool UseNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseCompanyNames);
            Company item = new Company();
            DataTable dt = new DataTable();
            string valueMember = "CompanyId";
            string displayMember = "CompanyCode";
            if (UseNames)
                displayMember = "CompanyName";
            dt = item.SelectAllActiveCompanies();
            BindCombo(ref cbo, dt, displayMember, valueMember, ALL);
            if (cbo.Items.Count > 0)
                cbo.SelectedIndex = 0;
        }
        public static void BindCustomerCombo(ref ComboBox cbo, bool ALL)
        {
            bool UseNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseCustomerNames);
            Customer obj = new Customer();
            DataTable dt = new DataTable();
            string valueMember = "CustomerId";
            //string displayMember = "SupplierCode";
            string displayMember = "CustomerCode";
            if (UseNames)
                //displayMember = "SupplierName";
              displayMember = "CustomerName";
            dt = obj.SelectAllCustomer();
            BindCombo(ref cbo, dt, displayMember, valueMember, ALL);
            if (cbo.Items.Count > 0)
                cbo.SelectedIndex = 0;
        }
        public static void BindCustomerComboOnlyActive(ref ComboBox cbo, bool ALL)
        {
            bool UseNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseCustomerNames);
            Customer obj = new Customer();
            DataTable dt = new DataTable();
            string valueMember = "CustomerId";
            //string displayMember = "SupplierCode";
            string displayMember = "CustomerCode";
            if (UseNames)
                //displayMember = "SupplierName";
              displayMember = "CustomerName";
            dt = obj.SelectAllActiveCustomer();
            BindCombo(ref cbo, dt, displayMember, valueMember, ALL);
            if (cbo.Items.Count > 0)
                cbo.SelectedIndex = 0;
        }
        private static void BindCombo(ref ComboBox cbo, DataTable dt, string displayMember, string valueMember, bool ALL)
        {
            try
            {
                if (dt != null)
                {
                    if (ALL)
                    {
                        DataRow drAll = dt.NewRow();
                        drAll[displayMember] = "--ALL--";
                        drAll[valueMember] = "0";
                        dt.Rows.InsertAt(drAll, 0);
                    }
                    cbo.DisplayMember = displayMember;
                    cbo.ValueMember = valueMember;
                    cbo.DataSource = dt;
                    cbo.DisplayMember = displayMember;
                    cbo.ValueMember = valueMember;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static DataTable CheckCompanyItem(string companyId, string companyItem, string Packing)
        {
            try
            {

                //int result=0;
                DataTable dt = null;
                DataAccessManager dam = new DataAccessManager();
                string[,] parayy = { {@"CompanyId",companyId}
                               ,{@"CompanyItem",companyItem},
                               {@"Packing",Packing}};
                dt = dam.GetDataTable(CommandType.StoredProcedure, "CheckCompanyItem", parayy);
                return dt;
            }
            catch (Exception exe)
            {

                throw exe;
            }
        }
        public static void ShowHideColumns(DataGridView dgv, string cols)
        {
            if (dgv != null && !string.IsNullOrEmpty(cols))
            {
                string[] arrCols = cols.Split(',');
                foreach (string str in arrCols)
                {
                    dgv.Columns[str].Visible = false;
                }
            }
        }
        public static void RenameColumns(DataGridView dgv, IDictionary<string, string> dict)
        {
            if (dgv != null && dict != null && dict.Count > 0)
            {

                foreach (KeyValuePair<string, string> kvp in dict)
                {
                    dgv.Columns[kvp.Key].HeaderText = kvp.Value;
                }
            }
        }
        public static bool IsCodeExists(string code, Modules Table)
        {
            string[,] paramArray = { 
                                        {"@Code",code},
                                        {"@TableName",Table.ToString()}};
            DataAccessManager dam = new DataAccessManager();
            return Convert.ToInt64(dam.ExecuteScalar(CommandType.StoredProcedure, "IsCodeExists", paramArray)) > 0;
        }
        public static bool IsCodeExists(string code, Modules Table, bool AllActive)
        {
            string[,] paramArray = { 
                                        {"@Code",code},
                                        {"@TableName",Table.ToString()},
                                        {"@Active",AllActive?"1":"0"}

                                   };
            DataAccessManager dam = new DataAccessManager();
            return Convert.ToInt64(dam.ExecuteScalar(CommandType.StoredProcedure, "IsCodeExists", paramArray)) > 0;
        }
        public static long NoOfCodeExists(string code, Modules Table)
        {
            string[,] paramArray = { 
                                        {"@Code",code},
                                        {"@TableName",Table.ToString()},
                                        {"@Active","0"}

                                   };
            DataAccessManager dam = new DataAccessManager();
            return Convert.ToInt64(dam.ExecuteScalar(CommandType.StoredProcedure, "IsCodeExists", paramArray));
        }
        public static long GetNextId(Modules Table)
        {
            string[,] paramArray = { { "@TableName", Table.ToString() } };
            DataAccessManager dam = new DataAccessManager();
            return Convert.ToInt64(dam.ExecuteScalar(CommandType.StoredProcedure, "GetNextId", paramArray));
        }
        public static void FormatCurrencyColumn(DataGridView dgv, string cols)
        {
            if (dgv != null && !string.IsNullOrEmpty(cols))
            {
                string[] arrCols = cols.Split(',');
                foreach (string str in arrCols)
                {
                    if (dgv.Columns[str] != null)
                    {
                        dgv.Columns[str].DefaultCellStyle.Format = "0.00";
                        dgv.Columns[str].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
        }
        public static void BindUserCombo(ref ComboBox cbo, bool ALL)
        {
            bool UseNames = ConfigurationReader.ReadKeyBoolean(ConfigurationKeys.UseItemNames);

            DataTable dt = new DataTable();
            string valueMember = "Id";
            string displayMember = "UserName";
            if (UseNames)
                displayMember = "UserName";
            dt = SystemUser.SelectUser(null, null, null);
            BindCombo(ref cbo, dt, displayMember, valueMember, ALL);
            if (cbo.Items.Count > 0)
                cbo.SelectedIndex = 0;
        }

        public static void ShowInvlaidCodeMessage(ComboBox cbo, Modules module)
        {
            MessageBox.Show(string.Format("Error ! Invalid {0} Code" + Environment.NewLine + "Please Select a Valid {0} Code.", module.ToString()), module.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            cbo.Focus();
            if (cbo.Items.Count > 0)
                cbo.SelectedIndex = 0;
            cbo.Focus();

        }

        public static short IsValidCode(ComboBox cbo, Modules module, bool All)
        {
            short statusCode = 0;
            if (All && cbo.Text == "--ALL--")
            {
            }
            else if (!string.IsNullOrEmpty(cbo.Text) && !Common.IsCodeExists(cbo.Text, module))
            {
                statusCode = 1;
                Common.ShowInvlaidCodeMessage(cbo, module);
            }
            else if (string.IsNullOrEmpty(cbo.Text))
            {
                if (cbo.Items.Count > 0)
                {
                    cbo.SelectedIndex = 0;
                }
            }
            return statusCode;
        }
        public static short IsValidCode(ComboBox cbo, Modules module)
        {
            return IsValidCode(cbo, module, false);
        }

        public static bool IsCurrentDateValid()
        {
            bool result = false;
            DataAccessManager dam = new DataAccessManager();
            string[,] pararray = { { "@FromTransactionDate", FormateDateForDB(DateTime.Now.AddDays(1)) } };
            DataTable dt = dam.GetDataTable(CommandType.StoredProcedure, "SelectTransactions", pararray);

            if (dt != null)
                result = dt.Rows.Count > 1;
            return !result;
        }


    }

    public class CurrentUser
    {
        public int Id = -1;
        public string UserName = string.Empty;
        public string Name = string.Empty;
        public bool AllowInvoice = false;
        public bool AllowStock = false;
        public bool AllowCompany = false;
        public bool AllowCustomer = false;
        public bool AllowItem = false;
        public bool AllowShop = false;
        public bool AllowReports = false;
        public bool AllowUserManagement = false;
        public bool AllowOrder = false;
        public bool AllowCompanyPayment = false;
        public bool AllowCustomerPayment = false;
        public bool AllowReturnSale = false;
        public bool AllowReturnPurchase = false;

        public bool IsSuperAdmin = false;
    }


    public class EnumStringValueAttribute : Attribute
    {
        public EnumStringValueAttribute(string value)
        {
            this.StringValue = value;
        }
        public string StringValue { get; set; }
    }

    public class Registration
    {

        public static void CreateRegistration()
        {
        }
        public static bool ValidateRegistration()
        {
            bool isValid = false;

            return isValid;
        }
        public static void StartTrialPeriod()
        {
        }
        public static void EndTrialPeriod()
        {
        }
        public static void MakeVoid()
        {
        }
    }

    public class SuperAdmin
    {
        static string pass = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyyzZ`~1!2@3#4$5%6^7&8*9(0)=+-_.>,<?/';";

        public static DateTime LastRun
        {
            get
            {


                DateTime LRDate = DateTime.MinValue;
                try
                {

                    DataAccessManager dam = new DataAccessManager();
                    object val = dam.ExecuteScalar(CommandType.Text, "SELECT top 1 [A34C0CEC63EC0F1739FB5CB8F43A9CE1] from Shop");
                    if (val != null)
                    {
                        string strVal = Convert.ToString(val);
                        strVal = Decrypt(strVal, pass);
                        LRDate = Convert.ToDateTime(strVal, CultureInfo.InvariantCulture);
                        //result = LRDate < DateTime.Now.AddMinutes(5);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                return LRDate;
            }
        }

        #region Database Management
        public static void InitializeDatabase()
        {
            DataAccessManager dam = new DataAccessManager();
            dam.ExecuteNonQuery(CommandType.StoredProcedure, "Admin_InitializeDatabase");
        }
        public static void CreateBackup(string filePath)
        {
            DataAccessManager dam = new DataAccessManager();
            string[,] paramArray = { { "@FilePath", filePath } };
            dam.ExecuteNonQuery(CommandType.StoredProcedure, "Admin_CreateBackup", paramArray);
        }
        public static void RestoreBackup(string filePath)
        {
            try
            {


                string Query = string.Empty;
                Query = "USE [master]" + Environment.NewLine;
                Query += "ALTER DATABASE EBusiness" + Environment.NewLine;
                Query += "SET SINGLE_USER WITH" + Environment.NewLine;
                Query += "ROLLBACK IMMEDIATE" + Environment.NewLine;
                Query += "RESTORE DATABASE EBusiness FROM DISK = '" + filePath + "' WITH REPLACE" + Environment.NewLine;
                Query += "ALTER DATABASE EBusiness SET MULTI_USER" + Environment.NewLine;

                DataAccessManager dam = new DataAccessManager();
                //dam.ExecuteNonQuery(CommandType.Text, Query);
                dam.ExecuteNonQueryOnMaster(CommandType.Text, Query);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static void CreateDatabase()
        {
            string command = @" CREATE DATABASE [EBusiness];
        

        ALTER DATABASE [EBusiness] SET COMPATIBILITY_LEVEL = 90;
        

        IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
        begin
        EXEC [EBusiness].[dbo].[sp_fulltext_database] @action = 'enable';
        end
        

        ALTER DATABASE [EBusiness] SET ANSI_NULL_DEFAULT OFF ;
        

        ALTER DATABASE [EBusiness] SET ANSI_NULLS OFF ;
        

        ALTER DATABASE [EBusiness] SET ANSI_PADDING OFF ;
        

        ALTER DATABASE [EBusiness] SET ANSI_WARNINGS OFF ;
        

        ALTER DATABASE [EBusiness] SET ARITHABORT OFF ;
        

        ALTER DATABASE [EBusiness] SET AUTO_CLOSE ON ;
        

        ALTER DATABASE [EBusiness] SET AUTO_CREATE_STATISTICS ON ;
        

        ALTER DATABASE [EBusiness] SET AUTO_SHRINK OFF ;
        

        ALTER DATABASE [EBusiness] SET AUTO_UPDATE_STATISTICS ON ;
        

        ALTER DATABASE [EBusiness] SET CURSOR_CLOSE_ON_COMMIT OFF ;
        

        ALTER DATABASE [EBusiness] SET CURSOR_DEFAULT  GLOBAL ;
        

        ALTER DATABASE [EBusiness] SET CONCAT_NULL_YIELDS_NULL OFF ;
        

        ALTER DATABASE [EBusiness] SET NUMERIC_ROUNDABORT OFF ;
        

        ALTER DATABASE [EBusiness] SET QUOTED_IDENTIFIER OFF ;
        

        ALTER DATABASE [EBusiness] SET RECURSIVE_TRIGGERS OFF ;
        

        ALTER DATABASE [EBusiness] SET  DISABLE_BROKER ;
        

        ALTER DATABASE [EBusiness] SET AUTO_UPDATE_STATISTICS_ASYNC OFF ;
        

        ALTER DATABASE [EBusiness] SET DATE_CORRELATION_OPTIMIZATION OFF ;
        

        ALTER DATABASE [EBusiness] SET TRUSTWORTHY OFF ;
        

        ALTER DATABASE [EBusiness] SET ALLOW_SNAPSHOT_ISOLATION OFF ;
        

        ALTER DATABASE [EBusiness] SET PARAMETERIZATION SIMPLE ;
        

        ALTER DATABASE [EBusiness] SET READ_COMMITTED_SNAPSHOT OFF ;
        

        ALTER DATABASE [EBusiness] SET HONOR_BROKER_PRIORITY OFF ;
        

        ALTER DATABASE [EBusiness] SET  READ_WRITE ;
        

        ALTER DATABASE [EBusiness] SET RECOVERY FULL ;
        

        ALTER DATABASE [EBusiness] SET  MULTI_USER ;
        

        ALTER DATABASE [EBusiness] SET PAGE_VERIFY CHECKSUM  ;
        

        ALTER DATABASE [EBusiness] SET DB_CHAINING OFF ;
";
            try
            {
                DataAccessManager dam = new DataAccessManager();
                SqlConnection conn = dam.GetMasterConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = command;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to create Database due to following Exception : " + ex.Message);
            }

        }
        public static void CreateDatabaseSchema(string script)
        {
            try
            {
                DataAccessManager dam = new DataAccessManager();
                SqlConnection conn = dam.GetConnection();
                //conn.Close();
                //conn.ConnectionString = conn.ConnectionString.Replace("EBusiness", "EBusiness_New");
                //conn.Open();
                //script = script.Replace("EBusiness", "EBusiness_New");
                string[] commands = script.Split(new string[] { "GO\r\n", "\nGO\n", "Go", "Go\t" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string command in commands)
                {
                    if (!command.Contains("[EBusiness]"))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = command;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Schema Created successfully.");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        #region Registration and Trial
        private static string CreateUniqueKey()
        {
            string key = string.Empty;
            //Win32_USBController+Win32_IDEController+Win32_Processor 
            ManagementObjectSearcher usbSearcher = new ManagementObjectSearcher("select * from Win32_USBController");
            foreach (ManagementObject share in usbSearcher.Get())
            {
                if (share.Properties != null && share.Properties["DeviceID"] != null)
                {
                    key += Convert.ToString(share.Properties["DeviceID"].Value);
                    break;
                }

            }

            ManagementObjectSearcher ideSearcher = new ManagementObjectSearcher("select * from Win32_IDEController");
            foreach (ManagementObject share in ideSearcher.Get())
            {
                if (share.Properties != null && share.Properties["DeviceID"] != null)
                {
                    key += Convert.ToString(share.Properties["DeviceID"].Value);
                    break;
                }
            }

            ManagementObjectSearcher processorSearcher = new ManagementObjectSearcher("select * from Win32_Processor");
            ManagementObjectCollection coll2 = processorSearcher.Get();
            foreach (ManagementObject share in coll2)
            {
                if (share.Properties != null && share.Properties["ProcessorId"] != null)
                {
                    key += Convert.ToString(share.Properties["ProcessorId"].Value);
                    break;
                }
            }

            key = Encrypt(key, pass);
            return key;
        }
        public static bool CreateRegistration(int months)
        {
            string p1 = CreateUniqueKey();
            string p2 = Encrypt(DateTime.Now.ToString("MM-dd-yyyy"), pass);
            string p3 = Encrypt(DateTime.Now.AddMonths(months).ToString("MM-dd-yyyy"), pass);
            string p4 = Encrypt(DateTime.Now.ToString(), pass);

            bool result = false;
            DataAccessManager dam = new DataAccessManager();
            string[,] paramArray = {
                                       {"@P1", p1 },
                                       {"@P2", p2},
                                       {"@P3", p3},
                                       {"@P4", p4}
                                       };
            result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "Test", paramArray) > 0;
            return result;
        }
        public static bool CreateRegistration(DateTime expiryDate)
        {
            string p1 = CreateUniqueKey();
            string p2 = Encrypt(DateTime.Now.ToString("MM-dd-yyyy"), pass);
            string p3 = Encrypt(expiryDate.ToString("MM-dd-yyyy"), pass);
            string p4 = Encrypt(DateTime.Now.ToString(), pass);

            bool result = false;
            DataAccessManager dam = new DataAccessManager();
            string[,] paramArray = {
                                       {"@P1", p1 },
                                       {"@P2", p2},
                                       {"@P3", p3},
                                       {"@P4", p4}
                                       };
            result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "Test", paramArray) > 0;
            return result;
        }

        public static int NoOfRegisteredDaysLeft()
        {
            int days = 0;
            try
            {
                DateTime xpDate = DateTime.MinValue;
                DataAccessManager dam = new DataAccessManager();
                object val = dam.ExecuteScalar(CommandType.Text, "SELECT top 1 [1B29BA78A2DF965545C5A563B6E997AE] from Shop");
                if (val != null)
                {
                    string strVal = Convert.ToString(val);
                    strVal = Decrypt(strVal, pass);
                    xpDate = Convert.ToDateTime(strVal, CultureInfo.InvariantCulture);
                    DateTime dtNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, CultureInfo.InvariantCulture.Calendar);
                    TimeSpan ts = new TimeSpan(xpDate.Ticks - dtNow.Date.Ticks);
                    days = ts.Days;

                    CultureInfo cInfo = CultureInfo.InvariantCulture;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return days;
        }
        public static bool UnRegister()
        {
            bool result = false;
            DataAccessManager dam = new DataAccessManager();
            string[,] paramArray = {
                                       {"@P1", null },
                                       {"@P2", null},
                                       {"@P3", null},
                                       {"@P4", null}
                                       };
            result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "Test", paramArray) > 0;
            return result;
        }

        public static bool VerifyRegistration()
        {
            bool IsValid = false;
            try
            {
                DataAccessManager dam = new DataAccessManager();
                object val = dam.ExecuteScalar(CommandType.Text, "SELECT top 1 [AD97DC5D7E618288E63528CC5CC6F3AE] from Shop");
                if (val != null)
                {
                    string strVal = Convert.ToString(val);
                    string newKey = CreateUniqueKey();
                    IsValid = strVal == newKey;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return IsValid;
        }
        public static bool RegistrationExists()
        {
            bool Exists = true;
            try
            {
                DataAccessManager dam = new DataAccessManager();
                object val = dam.ExecuteScalar(CommandType.Text, "SELECT count(*) as cnt from Shop");
                if (val == null || Convert.ToInt32(val) == 0)
                    Exists = false;
            }
            catch (Exception ex)
            {
            }
            return Exists;
        }
        public static void UpdateLR()
        {
            DataAccessManager dam = new DataAccessManager();
            dam.ExecuteNonQuery(CommandType.Text, string.Format("UPDATE Shop  SET [A34C0CEC63EC0F1739FB5CB8F43A9CE1]='{0}'", Encrypt(DateTime.Now.ToString(), pass)));

        }

        public static bool VerifyLastRun()
        {
            bool result = false;
            try
            {
                DateTime LRDate = DateTime.MinValue;
                DataAccessManager dam = new DataAccessManager();
                object val = dam.ExecuteScalar(CommandType.Text, "SELECT top 1 [A34C0CEC63EC0F1739FB5CB8F43A9CE1] from Shop");
                if (val != null)
                {
                    string strVal = Convert.ToString(val);
                    strVal = Decrypt(strVal, pass);
                    LRDate = Convert.ToDateTime(strVal, CultureInfo.InvariantCulture);
                    DateTime dtNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, CultureInfo.InvariantCulture.Calendar);

                    result = LRDate < DateTime.Now.AddMinutes(5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }


        #endregion


        #region Encryption
        // Encrypt a byte array into a byte array using a key and an IV 
        private static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            // Create a MemoryStream to accept the encrypted bytes 
            MemoryStream ms = new MemoryStream();
            /*
             Create a symmetric algorithm. We are going to use Rijndael because it is strong and available on all platforms. 
            You can use other algorithms, to do so substitute the next line with something like TripleDES alg = TripleDES.Create(); 
            */
            Rijndael alg = Rijndael.Create();
            /*
             Now set the key and the IV. We need the IV (Initialization Vector) because the algorithm is operating in its default mode called CBC (Cipher Block Chaining).
             The IV is XORed with the first block (8 byte) of the data before it is encrypted, and then each encrypted block is XORed with the following block of plaintext.
             This is done to make encryption more secure. There is also a mode called ECB which does not need an IV, but it is much less secure. 
            */

            alg.Key = Key;
            alg.IV = IV;

            /*
             Create a CryptoStream through which we are going to be pumping our data. CryptoStreamMode.Write means that we are going to be 
             writing data to the stream and the output will be written in the MemoryStream we have provided. 
            */

            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

            // Write the data and make it do the encryption 

            cs.Write(clearData, 0, clearData.Length);
            /*
             Close the crypto stream (or do FlushFinalBlock). This will tell it that we have done our encryption and there is no more data coming in, 
             and it is now a good time to apply the padding and finalize the encryption process.
            */
            cs.Close();
            /*
             Now get the encrypted data from the MemoryStream. Some people make a mistake of using GetBuffer() here, which is not the right way. 
            */
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }
        // Encrypt a string into a string using a password 
        public static string Encrypt(string clearText, string Password)
        {
            // First we need to turn the input string into a byte array. 

            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);
            /*
              Then, we need to turn the password into Key and IV .We are using salt to make it harder to guess our key  using a dictionary attack - trying to guess a password by enumerating all possible words. 
             */
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            /*
            Now get the key/IV and do the encryption using the function that accepts byte arrays. 
            Using PasswordDeriveBytes object we are first getting 32 bytes for the Key (the default Rijndael key length is 256bit = 32bytes) and then 16 bytes for the IV. 
            IV should always be the block size, which is by default 16 bytes (128 bit) for Rijndael. 
            If you are using DES/TripleDES/RC2 the block size is 8 bytes and so should be the IV size. You can also read KeySize/BlockSize properties off the algorithm to find out the sizes. 
            */

            byte[] encryptedData = Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            /*
             Now we need to turn the resulting byte array into a string. A common mistake would be to use an Encoding class for that.It does not work because not all byte values can be
             represented by characters. We are going to be using Base64 encoding that is designed exactly for what we are trying to do. 
            */

            return Convert.ToBase64String(encryptedData);

        }

        private static byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            /*
            Create a symmetric algorithm. We are going to use Rijndael because it is strong and available on all platforms. 
            You can use other algorithms, to do so substitute the next line with something like TripleDES alg = TripleDES.Create();
            */
            Rijndael alg = Rijndael.Create();
            /*
            Now set the key and the IV. We need the IV (Initialization Vector) because the algorithm is operating in its default 
            mode called CBC (Cipher Block Chaining). The IV is XORed with the first block (8 byte) of the data after it is decrypted, and then each decrypted
            block is XORed with the previous  cipher block. This is done to make encryption more secure. 
            There is also a mode called ECB which does not need an IV, but it is much less secure. 
            */
            alg.Key = Key;
            alg.IV = IV;
            /*
             Create a CryptoStream through which we are going to be pumping our data. CryptoStreamMode.Write means that we are going to be writing data to the stream 
             and the output will be written in the MemoryStream we have provided.
            */
            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

            // Write the data and make it do the decryption 
            cs.Write(cipherData, 0, cipherData.Length);
            /*
             Close the crypto stream (or do FlushFinalBlock). This will tell it that we have done our decryption
             and there is no more data coming in, and it is now a good time to remove the padding and finalize the decryption process. 
            */
            cs.Close();

            // Now get the decrypted data from the MemoryStream. Some people make a mistake of using GetBuffer() here, which is not the right way. 
            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }
        // Decrypt a string into a string using a password 
        public static string Decrypt(string cipherText, string Password)
        {
            // First we need to turn the input string into a byte array. We presume that Base64 encoding was used 
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            // Then, we need to turn the password into Key and IV. We are using salt to make it harder to guess our key using a dictionary attack - 
            // trying to guess a password by enumerating all possible words. 

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

            // Now get the key/IV and do the decryption using the function that accepts byte arrays. 
            // Using PasswordDeriveBytes object we are first getting 32 bytes for the Key (the default Rijndael key length is 256bit = 32bytes) and then 16 bytes for the IV. 
            // IV should always be the block size, which is by default 16 bytes (128 bit) for Rijndael. 
            // If you are using DES/TripleDES/RC2 the block size is 8 bytes and so should be the IV size. 
            // You can also read KeySize/BlockSize properties off the algorithm to find out the sizes. 

            byte[] decryptedData = Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16));

            // Now we need to turn the resulting byte array into a string. A common mistake would be to use an Encoding class for that.
            // It does not work because not all byte values can be represented by characters. 
            // We are going to be using Base64 encoding that is designed exactly for what we are trying to do. 

            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }
        #endregion

        public static DataTable ExecuteSelectQuery(string query)
        {
            DataTable dt = null;
            try
            {

                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.Text, query);
            }
            catch (Exception ex)
            {
                throw;
            }
            return dt;
        }
        public static int ExecuteUpdateDeleteQuery(string query)
        {
            int count = 0;
            try
            {
                DataAccessManager dam = new DataAccessManager();
                count = dam.ExecuteNonQuery(CommandType.Text, query);
            }
            catch (Exception ex)
            {
                throw;
            }
            return count;
        }
    }

    public enum UserActions
    {
        Logged_In_Suceessfully = 1,
        Logged_Out_Sucessfully,
        Login_Faild,
        Made_A_Sale_Receipt,
        Made_A_Purchase_Invoice,
        Placed_An_Order,
        Made_Credit_Payment_To_Customer,
        Made_Debit_Payment_To_Customer,
        Made_Credit_Payment_To_Supplier,
        Made_Debit_Payment_To_Supplier,
        Made_A_Return_Receipt,
        Made_A_Return_Invoice,
    }

    public enum Modules
    {
        ALL,
        Login,
        POS,
        Invoice,
        [EnumStringValue("ItemType")]
        ItemType,
        [EnumStringValue("Item")]
        Item,
        [EnumStringValue("Supplier")]
        Supplier,
        [EnumStringValue("Customer")]
        Customer,
        [EnumStringValue("Payment")]
        Payment,
        Order,
        Stock,
        Shop,
        User,
        SystemLog,
        ItemsList,
        ParentForm,
        ReceiptViewer,
        WelcomeForm,
        TransactionReportControl,
        SalesPurchaseReportControl,
        ProfitLossReportControl,
        DailySalesPurchaseReport,
        CurrentCashReport,
        SystemUsers,
        Receipt
    }

    public enum AppSettings
    {
        [EnumStringValue("EBusinessConnectionString")]
        EBusinessConnectionString = 0,
        [EnumStringValue("UseItemNames")]
        UseItemNames = 1,
        [EnumStringValue("UseCompanyNames")]
        UseCompanyNames = 2,
        [EnumStringValue("UseCustomerNames")]
        UseCustomerNames = 3,
        [EnumStringValue("AcceptReturnInItemCombo")]
        AcceptReturnInItemCombo = 4,
        [EnumStringValue("EnableEntryTimeEditing")]
        EnableEntryTimeEditing = 5,
        [EnumStringValue("ShowPurchasePrice")]
        ShowPurchasePrice = 6,


    }

}
