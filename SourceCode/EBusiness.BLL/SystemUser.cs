using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EBusiness.DAL;
using System.Data;
namespace EBusiness.BLL
{
    public class SystemUser
    {
        public static DataTable Login(string UserName, string Password)
        {
            DataTable dt = null;
            DataAccessManager dam = new DataAccessManager();
            string[,] paramArray = {
                                       {"@UserName",UserName},
                                       {"@Password",Password}
                                   };
            dt = dam.GetDataTable(System.Data.CommandType.StoredProcedure, "SystemUserLogin", paramArray);
            return dt;
        }
        public static bool CreateUpdateUser(string UserName
           , string Password, string Name, string ContactNumber, string Address, string IsActive
           , string AllowInvoice, string AllowStock, string AllowCompany, string AllowCustomer
           , string AllowItem, string AllowShop, string AllowReports, string AllowUserManagement,
            string AllowOrder, string AllowCompanyPayment, string AllowCustomerPayment,
            string AllowReturnSale, string AllowReturnPurchase, int Opertion)
        {
            bool result = false;
            try
            {

                DataAccessManager dam = new DataAccessManager();
                string[,] pararray = {{"@UserName",UserName},
                                     {"@Password",Password},
                                     {"@Name",Name},
                                     {"@ContactNumber",ContactNumber},
                                     {"@Address",Address},
                                     {"@IsActive",IsActive},
                                     {"@AllowInvoice",AllowInvoice},
                                     {"@AllowStock",AllowStock},
                                     {"@AllowCompany",AllowCompany},
                                     {"@AllowCustomer",AllowCustomer},
                                     {"@AllowItem",AllowItem},
                                     {"@AllowShop",AllowShop},
                                     {"@AllowReports",AllowReports},
                                     {"@AllowUserManagement",AllowUserManagement},
                                     {"@AllowOrder",AllowOrder},
                                     {"@AllowCompanyPayment",AllowCompanyPayment},
                                     {"@AllowCustomerPayment",AllowCustomerPayment},
                                     {"@AllowReturnSale",AllowReturnSale},
                                     {"@AllowReturnPurchase",AllowReturnPurchase},
                                     {"@Id",Opertion.ToString()}
                                 };
                result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteUser", pararray) > 0;
            }
            catch (Exception exe)
            {

                throw exe;
            }

            return result;
        }
        public static bool ChangePassword(string UserName, string Password, string NewPassword, int Operation)
        {
            try
            {
                bool result = false;
                DataAccessManager dam = new DataAccessManager();
                string[,] pararry = {{"@UserName",UserName},
                                {"@Password",Password},
                                {"@NewPassword",NewPassword},
                                {"@Operation",Operation.ToString()}
                                };
                result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "ChangePassword", pararry) > 0;
                return result;
            }
            catch (Exception exe)
            {

                throw exe;
            }

        }

        public static bool ResetPassword(string UserName, string NewPassword)
        {
            try
            {
                bool result = false;
                DataAccessManager dam = new DataAccessManager();
                string[,] pararry = {{"@UserName",UserName},
                                {"@NewPassword",NewPassword},
                                {"@IsReset","1"}
                                };
                result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "ChangePassword", pararry) > 0;
                return result;
            }
            catch (Exception exe)
            {

                throw exe;
            }

        }

        public static DataTable SelectUser(string Id, string UserName, string FullName)
        {
            DataTable dtUser = null;
            try
            {

                dtUser = new DataTable();
                DataAccessManager dam = new DataAccessManager();
                string[,] pararray = {
                                     {"@Id",Id},
                                      {"@UserName",UserName},
                                      {"@Name",FullName},
                                  
                                     };



                dtUser = dam.GetDataTable(CommandType.StoredProcedure, "SelectUser", pararray);
            }
            catch (Exception exe)
            {

                throw exe;
            }
            return dtUser;
        }
    }
}
