using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;


namespace EBusiness.BLL
{
    public class ConfigurationReader
    {
        public static string ReadKey(string key)
        {
            string value = null;
            if (!string.IsNullOrEmpty(key))
            {

                value = ConfigurationManager.AppSettings[key];
            }
            return value;
        }
        public static bool ReadKeyBoolean(string key)
        {
            return Convert.ToBoolean(ReadKey(key));
        }
        public static int ReadKeyInt(string key)
        {
            return Convert.ToInt32(ReadKey(key));
        }
    }

    public class ConfigurationKeys
    {
        public static string UseItemNames = "UseItemNames";
        public static string UseCompanyNames = "UseCompanyNames";
        public static string UseCustomerNames = "UseCustomerNames";
        public static string AcceptReturnInItemCombo = "AcceptReturnInItemCombo";
        public static string EBusinessConnectionString = "EBusinessConnectionString";
        public static string AllowShortStockSelling = "AllowShortStockSelling";
        public static string EnableEntryTimeEditing = "EnableEntryTimeEditing";
        public static string ShowPurchasePrice = "ShowPurchasePrice";
        public static string IsCashAddressRequired = "IsCashAddressRequired";
        public static string DatabaseBackupLocation = "DatabaseBackupLocation";
        public static string ShowDashBoard = "ShowDashBoard";
        public static string ShowModelDialogs = "ShowModelDialogs";
    
         
        
        
        
    }

}
