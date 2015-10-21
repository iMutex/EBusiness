using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EBusiness.DAL;

namespace EBusiness.BLL
{
    public class Customer
    {
        public DataTable SelectAllCustomer()
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                           {"@OnlyActive", "0"}
                                       };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCustomer", paramArray);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }
        public DataTable SelectAllActiveCustomer()
        {
            DataTable companyTable = new DataTable();
            try
            {
                 DataAccessManager dam = new DataAccessManager();

                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCustomer");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }
        public DataTable SelectCustomerById(string Id)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                           {"@CustomerId", Id},
                                           {"@OnlyActive", "0"}
                                           
                                       };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCustomer", paramArray);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }
        public DataTable SelectCustomerByCode(string code)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                           {"@CustomerCode", code},
                                           {"@OnlyActive", "0"}
                                       };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCustomer", paramArray);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }
        public DataTable SelectCustomerByName(string name)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                           {"@CustomerName", name},
                                           {"@OnlyActive", "0"}
                                       };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCustomer", paramArray);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }


        public long MakePayment(string CompanyId, string datetime, string amount, string Comments)
        {
            long TransactionId = -1;
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                {"@CustomerCompanyId", CompanyId},
                {"@TransactionDate", datetime},
                {"@Amount", amount},
                {"@IsCustomer", "1"},
                {"@UserId", Common.CURRENT_USER.Id.ToString()},
                {"@Comments", Comments}
                
           };
                object obj= dam.ExecuteScalar(CommandType.StoredProcedure, "InsertUpdateDeleteTransaction", paramArray);
                TransactionId = Convert.ToInt64(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return TransactionId;
        }
        public DataTable SelectCustomerTransactions(string fromDate, string toDate, string Id)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                                        {"@CustomerCompanyId",Id},
                                        {"@FromTransactionDate",fromDate},
                                        {"@ToTransactionDate", toDate },
                                        {"@IsCustomer", "1"}
                                    };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectTransactions", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return companyTable;
        }
        public bool InsertUpdateCustomer(string Id, string code, string name, string contact, string address, string balance, string IsActive,
            string Remarks, string City, string ContactPerson, string Phone, string Fax, string Web, string Email)
        {
            bool result = false;
            try
            {
                //@Remarks ,@City ,@ContactPerson ,@Phone ,@Fax ,@Web ,@Email
                int operation = 0;
                int.TryParse(Id, out operation);

                if (operation > 0)
                    operation = 1;
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                {"@Operation", operation.ToString()},
                {"@CustomerId", Id},
                {"@CustomerCode", code},
                {"@CustomerName", name},
                {"@ContactNumber", contact},
                {"@Address", address},
                {"@CustomerBalance", balance},
                {"@Remarks", Remarks},
                {"@City", City},
                {"@ContactPerson", ContactPerson},
                {"@Phone", Phone},
                {"@Fax", Fax},
                {"@Web", Web},
                {"@Email", Email},
                {"@IsActive", IsActive}
           };
                result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteCustomer", paramArray) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

    }
}
