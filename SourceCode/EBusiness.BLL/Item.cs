using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EBusiness.DAL;
using System.Data;
using System.Transactions;

namespace EBusiness.BLL
{
    public class Item
    {
        public DataTable Stock()
        {
            DataTable stockTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                stockTable = dam.GetDataTable(CommandType.StoredProcedure, "Stock");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return stockTable;
        }




        public DataTable SelectAllItem()
        {
            return SelectItem(null, null, null, null, null, "0", 0);
        }
        public DataTable SelectAllActiveItem()
        {
            return SelectItem(null, null, null, null, null, "1", 0);
        }
        public DataTable SelectAllStockActiveItem()
        {
            return SelectItem(null, null, null, null, null, "2", 0);
        }

        public DataTable SelectItemById(string Id)
        {
            return SelectItem(Id, null, null, null, null, "0", 0);
        }
        public DataTable SelectItemByCode(string Id)
        {
            return SelectItem(null, Id, null, null, null, "0", 0);
        }
        public DataTable SelectItemByName(string Name)
        {
            return SelectItem(null, null, Name, null, null, "1", 0);
        }
        public DataTable SelectItemByItemType(string Id)
        {
            return SelectItem(null, null, null, Id, null, "1", 0);
        }
        public DataTable SelectItemByCompany(string Id)
        {
            return SelectItem(null, null, null, null, Id, "1", 1);
        }
        /*

        @ItemId int=null,
@ItemCode nvarchar(500) = null,
@ItemName nvarchar(500) = null,
@ItemType int = null,
@CompanyId

        */

        public DataTable SelectItem(string ItemId, string ItemCode, string ItemName, string ItemType, string CompanyId, string isActive, int Operation)
        {
            DataTable companyTable = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {{"@ItemId", ItemId},
                                       {"@ItemCode", ItemCode },
                                       {"@ItemName", ItemName },
                                       {"@ItemType", ItemType },
                                       {"@CompanyId", CompanyId },
                                       {"@isActive", isActive },
                                        {"@Operation", Operation.ToString() }
                                       };
                companyTable = dam.GetDataTable(CommandType.StoredProcedure, "SelectItem", paramArray);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return companyTable;
        }

        public bool InsertUpdateItem(string Id, string ItemCode, string ItemName, string itemType, string packing, string CompanyId, string ItemInStock,
             string PurchasePrice, string SalePrice, string Discount, string IsActive,string BatchNo,DateTime ExpiryDate)
        {
            bool result = false;
            try
            {
                int operation = 0;
                int.TryParse(Id, out operation);

                if (operation > 0)
                    operation = 1;
                 
                DataAccessManager dam = new DataAccessManager();        //object of DataManager class
                string[,] paramArray = { 
                {"@Operation", operation.ToString()},
                {"@ItemId", Id},
                {"@ItemCode", ItemCode},
                {"@ItemName", ItemName},
                {"@ItemType", itemType},
                {"@Packing", packing},
                {"@CompanyId",CompanyId},
                {"@ItemInStock", ItemInStock},
                {"@PurchasePrice", PurchasePrice},
                {"@SalePrice", SalePrice},
                {"@Discount", Discount}, 
                {"@IsActive", IsActive},
                {"@ExpiryDate",Common.FormateDateForDB(ExpiryDate)},
                {"@BatchNo",BatchNo}
           };
                result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteItem", paramArray) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }



        #region Receipt and Invoice and Order
        //RECEIPT
        public DataTable SelectReceiptsDateWise(string CustomerId, DateTime StartDate, DateTime EndDate, bool All)
        {
            DataTable dt = new DataTable();
            try
            {
                StartDate = StartDate.Date.AddMilliseconds(-1);
                EndDate = EndDate.Date.AddDays(1).AddMilliseconds(-1);
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                        { "@CustomerId", All?null:CustomerId} ,
                        { "@StartDate", All?null:Common.FormateDateForDB(StartDate)} ,
                        { "@EndDate", All?null:Common.FormateDateForDB(EndDate)} 
                                           };

                dt = dam.GetDataTable(CommandType.StoredProcedure, "SelectReceiptSummary", paramArray, "Receipt");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable SelectEmptyReceiptDetailTable()
        {
            DataTable table = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { { "@TableName", "ReceiptDetail" } };
                table = dam.GetDataTable(CommandType.StoredProcedure, "SelectEmptyTable", paramArray);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return table;
        }
        public long SaveReceipt(
            string CustomerId,
            string GrandTotal,
            string TotalDiscount,
            string NetTotal,
            string Payment,
            string Arrears,
            string Comments,
string Purpose,

            DataTable ReceiptDetail,
            bool IsReturn, string PrevReceiptId)
        {
            long newId = 0;
            if (!IsReturn)
                PrevReceiptId = "0";

            try
            {
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
                {
                    long Id = 0;
                    if (ReceiptDetail != null && ReceiptDetail.Rows.Count > 0)
                    {
                        DataAccessManager dam = new DataAccessManager();
                        string[,] paramArray = {
                                       {"@CustomerId", CustomerId },
                                       {"@GrandTotal", string.IsNullOrEmpty(GrandTotal)?"0":GrandTotal  },
                                       {"@Discount", string.IsNullOrEmpty(TotalDiscount)?"0":TotalDiscount },
                                       {"@Total", string.IsNullOrEmpty(NetTotal)?"0":NetTotal  },
                                       {"@Payment", string.IsNullOrEmpty(Payment)?"0":Payment  },
                                       {"@Arearrs", string.IsNullOrEmpty(Arrears)?"0":Arrears  },
                                       {"@Comments", Comments },
                                       {"@Purpose", Purpose},
                                       {"@UserId", Common.CURRENT_USER.Id.ToString()},
                                       {"@IsReturn", IsReturn?"1":"0"}

                                       };
                        Id = Convert.ToInt64(dam.ExecuteScalar(CommandType.StoredProcedure, "InsertUpdateDeleteReceipt", paramArray));
                        if (Id > 0)
                        {
                            foreach (DataRow row in ReceiptDetail.Rows)
                            {
                                SaveReceiptDetail(
                                    Id.ToString(),
                                    Convert.ToString(row["ItemId"])
                                    , Convert.ToString(row["SalePrice"])
                                    , Convert.ToString(row["Quantity"])
                                    , Convert.ToString(row["GrandTotal"])
                                    , Convert.ToString(row["Discount"])
                                    , Convert.ToString(row["Total"])
                                    , Convert.ToString(row["ItemDiscount"])
                                    , IsReturn
                                     ,PrevReceiptId
                                    );
                            }

                            SetReceiptProfitLoss(Id);
                            scope.Complete();
                            newId = Id;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(Modules.Item, "SaveReceipt", ex, "Item Exception");
            }


            return newId;
        }
        private int SaveReceiptDetail(
            string ReceiptId,
            string ItemId,
            string SalePrice,
            string Quantity,
            string GrandTotal,
            string Discount,
            string Total,
            string ItemDiscount,
            bool IsReturn,
            string PrevReceiptId )
        {
            int count = 0;
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                       {"@ReceiptId", ReceiptId },
                                       {"@ItemId", ItemId },
                                       {"@SalePrice", string.IsNullOrEmpty(SalePrice)?"0":SalePrice },
                                       {"@Quantity", string.IsNullOrEmpty(Quantity)?"0":Quantity },
                                       {"@GrandTotal", string.IsNullOrEmpty(GrandTotal)?"0":GrandTotal },
                                       {"@Discount", string.IsNullOrEmpty(Discount)?"0":Discount },
                                       {"@Total", string.IsNullOrEmpty(Total)?"0":Total },
                                       {"@ItemDiscount", string.IsNullOrEmpty(ItemDiscount)?"0":ItemDiscount },
                                       {"@IsReturn", IsReturn?"1":"0"},
                                       {"@PrevReceiptId", PrevReceiptId}
                                       };
                count = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteReceiptDetail", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return count;
        }

        public DataSet SelectReceiptandReceiptDetails(string ReceiptId, string CustomerId, DateTime StartDate, DateTime EndDate, bool All)
        {
            DataSet ds = new DataSet();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                        { "@ReceiptId", All?null:ReceiptId }, 
                        { "@CustomerId", All?null:CustomerId} ,
                        { "@StartDate", All?null:Common.FormateDateForDB(StartDate)} ,
                        { "@EndDate", All?null:Common.FormateDateForDB(EndDate)} 
                                           };
                ds = dam.GetDataSet(CommandType.StoredProcedure, "SelectReceiptandReceiptDetails", paramArray);
                if (ds != null && ds.Tables.Count == 2)
                {
                    ds.Tables[0].TableName = "Receipt";
                    ds.Tables[1].TableName = "ReceiptDetail";
                    DataRelation relation = new DataRelation("Receipt_ReceiptDetail"
                        , ds.Tables["Receipt"].Columns["Id"], ds.Tables["ReceiptDetail"].Columns["ReceiptId"]);
                    ds.Relations.Add(relation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public static DataTable SelectReceipt(string ReceiptId)
        {
            DataTable dt = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                        { "@ReceiptId", ReceiptId }
                                           };
                dt = dam.GetDataTable(CommandType.StoredProcedure, "SelectReceipt", paramArray, "Receipt");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public static DataTable SelectRecentReceipt()
        {
            DataTable dt = null;
            try
            {
                dt = new DataTable();
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "RecentTopReceipt");
            }
            catch (Exception exe)
            {
                
                throw exe;
            }
            return dt;
        }
        private void SetReceiptProfitLoss(long ReceiptId)
        {
            try
            {
                DataAccessManager dam = new DataAccessManager();
                dam.ExecuteNonQuery(CommandType.Text, "exec SetReceiptProfitLoss " + ReceiptId.ToString());
            }
            catch (Exception exe)
            {

                throw exe;
            }
        }
        //INVOICE
        public DataTable SelectEmptyInvoiceDetailTable()
        {
            DataTable table = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { { "@TableName", "InvoiceDetail" } };
                table = dam.GetDataTable(CommandType.StoredProcedure, "SelectEmptyTable", paramArray);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return table;
        }

        public DataTable SelectItemShortInStock()
        {
            return SelectItem(null, null, null, null, null,"1", 2);
        }
        public DataTable SelectInvoicesDateWise(string CompanyId, DateTime StartDate, DateTime EndDate, bool All)
        {
            DataTable dt = new DataTable();
            try
            {
                StartDate = StartDate.Date.AddMilliseconds(-1);
                EndDate = EndDate.Date.AddDays(1).AddMilliseconds(-1);
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                        { "@CompanyId", All?null:CompanyId} ,
                        { "@StartDate", All?null:Common.FormateDateForDB(StartDate)} ,
                        { "@EndDate", All?null:Common.FormateDateForDB(EndDate)} 
                                           };

                dt = dam.GetDataTable(CommandType.StoredProcedure, "SelectInvoiceSummary", paramArray, "Invoice");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


        public long SaveInvoice(string CompanyId,string InvoiceNo, string GrandTotal, string Discount, string Payment, string Arrears, string Comments, string OrderNo, DataTable InvoiceDetail, bool IsReturn)
        {
            long newId = 0;
             
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
                {
                    if (InvoiceDetail != null && InvoiceDetail.Rows.Count > 0)
                    {
                        long Id = 0;
                        DataAccessManager dam = new DataAccessManager();
                        string[,] paramArray = {
                                       {"@CompanyId", CompanyId },
                                       {"@InvoiceNo", InvoiceNo },
                                       {"@GrandTotal", string.IsNullOrEmpty(GrandTotal)?"0":GrandTotal },
                                       {"@Discount", string.IsNullOrEmpty(Discount)?"0":Discount },
                                       {"@Payment", string.IsNullOrEmpty(Payment)?"0":Payment },
                                       {"@Arrears", string.IsNullOrEmpty(Arrears)?"0":Arrears},
                                       {"@Comments", Comments},
                                       {"@OrderNo", OrderNo},
                                       {"@UserId", Common.CURRENT_USER.Id.ToString()},
                                       {"@IsReturn", IsReturn?"1":"0"}
                                       };
                        Id = Convert.ToInt64(dam.ExecuteScalar(CommandType.StoredProcedure, "InsertUpdateDeleteInvoice", paramArray));
                        if (Id > 0)
                        {
                            foreach (DataRow row in InvoiceDetail.Rows)
                            {
                                SaveInvoiceDetail(Id.ToString(), Convert.ToString(row["ItemId"])
                                    , Convert.ToString(row["PurchasePrice"])
                                    , Convert.ToString(row["Quantity"])
                                    , Convert.ToString(row["Total"])
                                    , Convert.ToString(row["Discount"])
                                    , Convert.ToString(row["GrandTotal"])
                                    , IsReturn
                                    );
                            }
                            scope.Complete();
                            newId = Id;
                        }

                    }
                }
            


            return newId;
        }
        private int SaveInvoiceDetail(string InvoiceId, string ItemId, string PurchasePrice, string Quantity, string Total, string Discount, string GrandTotal, bool IsReturn)
        {
            int count = 0;
            
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                       {"@InvoiceId", InvoiceId },
                                       {"@ItemId", ItemId },
                                       {"@PurchasePrice", string.IsNullOrEmpty(PurchasePrice)?"0":PurchasePrice },
                                       {"@Quantity", string.IsNullOrEmpty(Quantity)?"0":Quantity },
                                       {"@Total", string.IsNullOrEmpty(Total)?"0":Total },
                                       {"@Discount", string.IsNullOrEmpty(Discount)?"0":Discount},
                                       {"@GrandTotal", string.IsNullOrEmpty(GrandTotal)?"0":GrandTotal},
                                       {"@IsReturn", IsReturn?"1":"0"}
                                       };
                count = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteInvoiceDetail", paramArray);
            //}
             


            return count;
        }

        public DataSet SelectInvoiceandInvoiceDetails(string InvoiceId, string CompanyId, string StartDate, string EndDate, bool All)
        {
            DataSet ds = new DataSet();
            try
            {
                if (string.IsNullOrEmpty(InvoiceId))
                    InvoiceId = null;
                if (string.IsNullOrEmpty(CompanyId))
                    CompanyId = null;

                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                        { "@InvoiceId", All?null:InvoiceId }, 
                        { "@CompanyId", All?null:CompanyId} ,
                        { "@StartDate", StartDate} ,
                        { "@EndDate", EndDate}
                                           };
                ds = dam.GetDataSet(CommandType.StoredProcedure, "SelectInvoiceandInvoiceDetails", paramArray);
                if (ds != null && ds.Tables.Count == 2)
                {
                    ds.Tables[0].TableName = "Invoice";
                    ds.Tables[1].TableName = "InvoiceDetail";
                    DataRelation relation = new DataRelation("Invoice_InvoiceDetail"
                        , ds.Tables["Invoice"].Columns["Id"], ds.Tables["InvoiceDetail"].Columns["InvoiceId"]);
                    ds.Relations.Add(relation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        public DataSet SelectInvoiceandInvoiceDetails(string InvoiceNo)
        {
            return SelectInvoiceandInvoiceDetails(InvoiceNo, null, null, null, false);
        }

        //ORDER

        public long SaveOrder(string CompanyId, string GrandTotal, string Discount, string Payment, string Arrears, string Comments, DateTime DeliveryDate, DataTable OrderDetail, bool IsReturn)
        {
            long newId = 0;
            try
            {
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
                {

                    if (OrderDetail != null && OrderDetail.Rows.Count > 0)
                    {
                        long Id = 0;
                        DataAccessManager dam = new DataAccessManager();
                        string[,] paramArray = {
                                       {"@CompanyId", CompanyId },
                                       {"@GrandTotal", string.IsNullOrEmpty(GrandTotal)?"0":GrandTotal },
                                       {"@Discount", string.IsNullOrEmpty(Discount)?"0":Discount },
                                       {"@Payment", string.IsNullOrEmpty(Payment)?"0":Payment },
                                       {"@Arrears", string.IsNullOrEmpty(Arrears)?"0":Arrears},
                                       {"@Comments", Comments},
                                       {"@DeliveryDate", Common.FormateDateForDB(DeliveryDate)},
                                       {"@Status", "1"}
                                       
                                       };
                        Id = Convert.ToInt32(dam.ExecuteScalar(CommandType.StoredProcedure, "InsertUpdateDeleteOrder", paramArray));
                        if (Id > 0)
                        {
                            foreach (DataRow row in OrderDetail.Rows)
                            {
                                SaveOrderDetail(Id.ToString(),
                                     Convert.ToString(row["ItemId"])
                                    , Convert.ToString(row["PurchasePrice"])
                                    , Convert.ToString(row["Quantity"])
                                    , Convert.ToString(row["Total"])
                                    , Convert.ToString(row["Discount"])
                                    , Convert.ToString(row["GrandTotal"])
                                    );
                            }
                            scope.Complete();
                            newId = Id;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return newId;
        }
        private int SaveOrderDetail(string OrderId, string ItemId, string PurchasePrice, string Quantity, string Total, string Discount, string GrandTotal)
        {
            int count = 0;
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                       {"@OrderId", OrderId },
                                       {"@ItemId", ItemId },
                                       {"@PurchasePrice", string.IsNullOrEmpty(PurchasePrice)?"0":PurchasePrice },
                                       {"@Quantity", string.IsNullOrEmpty(Quantity)?"0":Quantity },
                                       {"@Total", string.IsNullOrEmpty(Total)?"0":Total },
                                       {"@Discount", string.IsNullOrEmpty(Discount)?"0":Discount},
                                       {"@GrandTotal", string.IsNullOrEmpty(GrandTotal)?"0":GrandTotal}
                                       };
                count = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteOrderDetail", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return count;
        }

        public DataSet SelectOrderandOrderDetails(string OrderId, string CompanyId, DateTime StartDate, DateTime EndDate, bool All)
        {
            DataSet ds = new DataSet();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = { 
                        { "@OrderId", All?null:OrderId }, 
                        { "@CompanyId", All?null:CompanyId} ,
                        { "@StartDate", All?null:Common.FormateDateForDB(StartDate)} ,
                        { "@EndDate", All?null:Common.FormateDateForDB(EndDate)} 
                                           };
                ds = dam.GetDataSet(CommandType.StoredProcedure, "SelectOrderandOrderDetails", paramArray);
                if (ds != null && ds.Tables.Count == 2)
                {
                    ds.Tables[0].TableName = "Order";
                    ds.Tables[1].TableName = "OrderDetail";
                    DataRelation relation = new DataRelation("Order_OrderDetail"
                        , ds.Tables["Order"].Columns["Id"], ds.Tables["OrderDetail"].Columns["OrderId"]);
                    ds.Relations.Add(relation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }


        #endregion

        public bool IsDuplictaeInvoiceNo(string InvoiceNo, string CompanyId)
        {
            short count = 0;
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] paramArray = {
                                       {"@InvoiceNo", InvoiceNo},
                                       {"@CompanyId", CompanyId}};
                object obj = dam.ExecuteScalar(CommandType.StoredProcedure, "IsDuplictaeInvoiceNo", paramArray);
                if (obj != null)
                    count = Convert.ToInt16(obj);
                //count = Convert.ToInt16(dam.ExecuteScalar(CommandType.StoredProcedure, "IsDuplictaeInvoiceNo", paramArray));
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return count>0;
        }
    }
}
