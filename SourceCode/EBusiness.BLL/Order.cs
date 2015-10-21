using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EBusiness.DAL;
using System.Data;
using System.Transactions;

namespace EBusiness.BLL
{
   public class Order
    {
        public int SaveOrder(string CompanyId, string GrandTotal, string Discount, string Payment, string Arrears, string Comments, DateTime DeliveryDate, DataTable OrderDetail, bool IsReturn)
        {
            int newId = 0;
            try
            {
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
                {
                    if (OrderDetail != null && OrderDetail.Rows.Count > 0)
                    {
                      
                        DataAccessManager dam = new DataAccessManager();
                        string[,] paramArray = {
                                       {"@CompanyId", CompanyId },
                                       {"@GrandTotal", GrandTotal },
                                       {"@Discount", Discount },
                                       {"@Payment", Payment },
                                       {"@Arrears", Arrears},
                                       {"@Comments", Comments},
                                       {"@DeliveryDate", Common.FormateDateForDB(DeliveryDate)},
                                       {"@Status", "1"}
                                       
                                       };
                        int id = Convert.ToInt32(dam.ExecuteScalar(CommandType.StoredProcedure, "InsertUpdateDeleteOrder", paramArray));
                        if (id > 0)
                        {
                            foreach (DataRow row in OrderDetail.Rows)
                            {
                                SaveOrderDetail(id.ToString(),
                                     Convert.ToString(row["ItemId"])
                                    , Convert.ToString(row["PurchasePrice"])
                                    , Convert.ToString(row["Quantity"])
                                    , Convert.ToString(row["Total"])
                                    , Convert.ToString(row["Discount"])
                                    , Convert.ToString(row["GrandTotal"])
                                    );
                            }
                            scope.Complete();
                            newId = id;
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
                                       {"@PurchasePrice", PurchasePrice },
                                       {"@Quantity", Quantity },
                                       {"@Total", Total },
                                       {"@Discount", Discount},
                                       {"@GrandTotal", GrandTotal}
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
            
             
            return ds;
        }
        public int DeleteOrder(int OrderID, int Operation) //New Method for Delete Order on OrderId 
        {
            int Result=0;
            //Operation=2;
                DataAccessManager dam= new DataAccessManager();
                string[,] paraArray =
            {
            {"@OrderId",OrderID.ToString()},
            {"@Operation",Operation.ToString()}
            };
                Result = dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUpdateDeleteOrder", paraArray);
                return Result;
        }
    }
}
