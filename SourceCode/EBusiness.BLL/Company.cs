using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using EBusiness.DAL;


namespace EBusiness.BLL
{
    public class Company
    {
        public DataSet SelectAllCompaniesWithItems()
        {
            DataSet ds = new DataSet();
                DataAccessManager dam = new DataAccessManager();
                ds = dam.GetDataSet(CommandType.StoredProcedure, "SelectCompanyProducts");
                if (ds != null && ds.Tables.Count == 2)
                {
                    ds.Tables[0].TableName = "Company";
                    ds.Tables[1].TableName = "Item";
                    DataRelation relation = new DataRelation("Company_Item"
                        , ds.Tables["Company"].Columns["CompanyId"], ds.Tables["Item"].Columns["CompanyId"]);
                    ds.Relations.Add(relation);
                }
 
            return ds;
        }

        public DataTable SelectAllCompanies()
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                {"@OnlyActive", "0"}
           };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCompany", paramArray);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }
        public DataTable SelectAllActiveCompanies()
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
               
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCompany");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }
        public DataTable SelectCompanyById(string Id)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                {"@CompanyId", Id},
                {"@OnlyActive", "0"}
           };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCompany", paramArray);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }
        public DataTable SelectCompanyByCode(string code)
        {
            DataTable companyTable = new DataTable();
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                {"@CompanyCode", code}
           };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCompany", paramArray);
            return companyTable;
        }
        public DataTable SelectCompanyByName(string name)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                {"@CompanyName", name}
           };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectCompany", paramArray);
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
                {"@IsCustomer", "0"},
                {"@UserId", Common.CURRENT_USER.Id.ToString()},
                {"@Comments", Comments}
                
           };
                object obj =dam.ExecuteScalar(CommandType.StoredProcedure, "InsertUpdateDeleteTransaction", paramArray) ;
                TransactionId = Convert.ToInt64(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return TransactionId;
        }
        public DataTable SelectCompanyTransactions(string fromDate, string toDate, string Id)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                                        {"@CustomerCompanyId",Id},
                                        {"@FromTransactionDate",fromDate},
                                        {"@ToTransactionDate", toDate },
                                        {"@IsCustomer", "0"}
                                    };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectTransactions", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return companyTable;
        }
        public bool InsertUpdateCompany(string Id, string code, string name, string balance, string IsActive,
            string ContactPerson,string Remarks,string Address,string City,string Phone,string Fax,string Web,string Email)
        {
            bool result = false;
            try
            {
                int operation = 0;
                int.TryParse(Id, out operation);

                if (operation > 0)
                    operation = 1;
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                {"@Operation", operation.ToString()},
                {"@CompanyId", Id},
                {"@CompanyCode", code},
                {"@CompanyName", name},
                {"@CompanyBalance", balance},
                {"@IsActive", IsActive },
                {"@ContactPerson", ContactPerson},
                {"@Remarks", Remarks},
                {"@Address", Address},
                {"@City", City},
                {"@Phone", Phone},
                {"@Fax", Fax},
                {"@Web", Web},
                {"@Email", Email}
           };
                result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteCompany", paramArray) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
