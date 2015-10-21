using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;      //for Registry

namespace EBusiness.BLL
{
   public class RegistryHandler
    {
        private static string path = "SOFTWARE\\POS";       //registry path
        private static  string liencePath="Software\\EBusiness"; //licensed path
       #region Properties
        public string Status 
        {
            get;
            private set;
        }
        public string UserName
        {
            get;
            private set; 
        }
        public string Password
        {
            get;
            private set;
        }
        public string LisenceKey
        {
            get;
            private set;
        }
        #endregion
        #region Methods
       const string HKEY_LOCAL_MACHINE="HKEY_LOCAL_MACHINE";
        public static RegistryHandler ReadRegistry()
        {
            RegistryHandler registry = new RegistryHandler();
            RegistryKey regKeyAppRoot = Registry.CurrentUser.CreateSubKey(path);
            registry.Status = (string)regKeyAppRoot.GetValue("Status");
            registry.UserName = (string)regKeyAppRoot.GetValue("UserName");
            registry.Password = (string)regKeyAppRoot.GetValue("Password");
            return registry;
        }
       public void WriteRegistry(string username, string password)
       {
           RegistryKey regKeyAppRoot = Registry.CurrentUser.CreateSubKey(path);
           regKeyAppRoot.SetValue("UserName", username);
           regKeyAppRoot.SetValue("Password", password);
           regKeyAppRoot.SetValue("Status", true);
       }
       public void DeleteRegistry()
       {
           RegistryKey regKeyAppRoot = Registry.CurrentUser.CreateSubKey(path);
           regKeyAppRoot.SetValue("UserName", "");
           regKeyAppRoot.SetValue("Password", "");
           regKeyAppRoot.SetValue("Status", false);
       }
       public static RegistryHandler GetLienceKey()
       {
           RegistryHandler registry = new RegistryHandler();
           RegistryKey regkey = Registry.LocalMachine.CreateSubKey(liencePath);
           registry.LisenceKey =(string)regkey.GetValue("LienceKey");
           return registry;
       }
       private void firstTime()
       {
           RegistryKey key = Registry.CurrentUser;
           key = key.CreateSubKey("");
           DateTime dateTime = DateTime.Now;
           string currentDate = dateTime.ToString();
           key.SetValue("Install",currentDate);
           key.SetValue("Use", currentDate);
       }
       private string checkFirstDate()
       {
           RegistryKey key = Registry.CurrentUser;
           key = key.CreateSubKey("");
           string date = (string)key.GetValue("Install");
           if (key.GetValue("Install") == null)
           {
               return "First";

           }
           else
           {
               return date; 
           }
      }
     

        #endregion
    }
}
