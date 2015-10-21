using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EBusiness.DAL;

namespace EBusiness.BLL
{
    public class ItemType
    {
        public DataTable SelectAllItemTypes()
        {
            DataTable companyTable = new DataTable();
             
                DataAccessManager dam = new DataAccessManager();
                
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectItemType");
            return companyTable;
        }
        public DataTable SelectAllItemTypes(string isActive)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                           {"@isActive",isActive}
                                       };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectItemType", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return companyTable;
        }
        public DataTable SelectItemTypeById(string Id)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                       {"@ItemTypeId", Id }
                                       };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectItemType", paramArray);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }
        public bool InsertUpdateItemType(string Id, string Name, string IsActive)
        {
            bool result = false;
            
                int operation = 0;
                int.TryParse(Id, out operation);

                if (operation > 0)
                    operation = 1;
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                {"@Operation", operation.ToString()},
                {"@ItemTypeId", Id},
                {"@ItemTypeName", Name},
                {"@IsActive", IsActive}
           };
                result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteItemType", paramArray) > 0;
            return result;
        }

    }
}
