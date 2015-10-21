using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EBusiness.DAL;

namespace EBusiness.BLL
{
    public class Shop
    {
        public DataTable SelectAllShop()
        {
                DataTable companyTable = new DataTable();
                DataAccessManager dam = new DataAccessManager();
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectShop");
                return companyTable;
        }
        public bool InsertNewShop(string Operation, string ShopName, string ShopSologon, string Registration,
                                  string Address, string PhoneNumber, string Properiter, string SaleNote)
        {
            bool result = false;
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                {"@Operation", Operation},
                {"@ShopName", ShopName},
                {"@ShopAddress", Address},
                {"@ShopNumber", PhoneNumber},
                {"@ShopSlogon", ShopSologon},
                {"@RegistrationNumber", Registration},
                {"@Properiter", Properiter},
                {"@SaleNote", SaleNote}
                
                
           };
                result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteShop", paramArray) > 0;
                return result;
        }

    }
}
