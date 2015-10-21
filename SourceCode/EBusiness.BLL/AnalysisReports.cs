using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EBusiness.DAL;
namespace EBusiness.BLL
{
    public class AnalysisReports
    {
        // Sales Report
        #region Sales Reports
        public DataTable ProductSalesPurchaseReport(DateTime? StartDate, DateTime? EndDate, string Id, bool IsPurchase)
        {
            DataTable dt = null;
            try
            {
                string[,] paramArray = { 
                                {"@StartDate", Common.FormateDateForDB(StartDate)},
                                {"@EndDate",  Common.FormateDateForDB(EndDate)},
                                {"@Id", Id},
                                {"@IsPurchase", IsPurchase?"1":"0"} 
                                       };
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "Report_ProductSalesPurchaseReport", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;

        }
        public DataTable CustomerSalesReport(DateTime? StartDate, DateTime? EndDate, string Id, bool IsDetailed)
        {
            DataTable dt = null;
            try
            {
                string[,] paramArray = { 
                                {"@StartDate", Common.FormateDateForDB(StartDate)},
                                {"@EndDate",  Common.FormateDateForDB(EndDate)},
                                {"@Id", Id},
                                {"@InDetail", IsDetailed?"1":"0"}
                                       };
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "Report_CustomerSalesReport", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable BuyerLedger(DateTime? StartDate, DateTime? EndDate, string Id)
        {
            DataTable dt = null;
            try
            {
                string[,] paramArray = { 
                                {"@StartDate", Common.FormateDateForDB(StartDate)},
                                {"@EndDate",  Common.FormateDateForDB(EndDate)},
                                {"@Id", Id}
                                       };
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "Report_BuyerLedger", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        public DataTable BuyerLedgerProductWise(DateTime? StartDate, DateTime? EndDate, string ItemId)
        {
            DataTable dt = null;
            try
            {
                string[,] paramArray = { 
                                {"@StartDate", Common.FormateDateForDB(StartDate)},
                                {"@EndDate",  Common.FormateDateForDB(EndDate)},
                                {"@ItemId", ItemId}
                                       };
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "Report_BuyerLedgerProductWise", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        #endregion Sales Reports

        // Purchase Report
        #region Purchase Reports
        public DataTable CompanyPurchaseReport(DateTime? StartDate, DateTime? EndDate, string Id, bool IsDetailed)
        {
            DataTable dt = null;
            try
            {
                string[,] paramArray = { 
                                {"@StartDate", Common.FormateDateForDB(StartDate)},
                                {"@EndDate",  Common.FormateDateForDB(EndDate)},
                                {"@Id", Id},
                                {"@InDetail", IsDetailed?"1":"0"}
                                       };
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "Report_CompanyPurchaseReport", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        #endregion Sales Reports

        //ProfitLoss
        #region Profit Loss Reports
        public DataTable ProfitLoassReport(DateTime? StartDate, DateTime? EndDate, string reportLevel)
        {
            DataTable dt = null;
            try
            {
                string[,] paramArray = { 
                                {"@StartDate", Common.FormateDateForDB(StartDate)},
                                {"@EndDate",  Common.FormateDateForDB(EndDate)},
                                {"@Level", reportLevel}
                                       };
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "Report_ProfitLost", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        #endregion Profit Loss Reports

        //Daily Sale Purchase Report
        #region Daily Sale Purchase Report
        public DataSet DailySalePurchaseReport(DateTime? StartDate, DateTime? EndDate, Int32 InDetail)
        {
            DataSet ds = null;

            try
            {
                string[,] paramArray = { 
                                {"@StartDate", Common.FormateDateForDB(StartDate)},
                                {"@EndDate",  Common.FormateDateForDB(EndDate)},
                                {"@InDetail", InDetail.ToString()}
                                       };
                DataAccessManager dam = new DataAccessManager();
                ds = dam.GetDataSet(CommandType.StoredProcedure, "Report_DailySalesPurchaseReport", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public DataSet DailySalePurchaseProductSummaryReport(DateTime? StartDate, DateTime? EndDate, string Id)
        {
            DataSet ds = null;

            try
            {
                if (string.IsNullOrEmpty(Id))
                    Id = "0";
                string[,] paramArray = { 
                                {"@StartDate", Common.FormateDateForDB(StartDate)},
                                {"@EndDate",  Common.FormateDateForDB(EndDate)},
                                {"@Id", Id}
                                       };
                DataAccessManager dam = new DataAccessManager();
                ds = dam.GetDataSet(CommandType.StoredProcedure, "Report_ProductTransactionReport", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        #endregion Daily Sale Purchase Report

        //Current Cash Report
        #region Current Cash Report
        public DataTable CurrentCashReport()
        {
            DataTable ds = null;
            try
            {
                DataAccessManager dam = new DataAccessManager();
                ds = dam.GetDataTable(CommandType.StoredProcedure, "Report_CurrentCashReport");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        #endregion Current Cash Report

        private DataTable SalesPurchaseReport(string report, string StartDate, string EndDate, string Id)
        {
            DataTable dt = null;
            try
            {
                string[,] paramArray = { 
                                {"@Report",report},
                                {"@StartDate",StartDate},
                                {"@EndDate", EndDate},
                                {"@Id", Id}
                                       };
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "Report_SalesPurchase", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable ProductTransactionDetailedReprot(string StartDate, string EndDate, string Id)
        {
            DataTable dt = null;
            try
            {
                string[,] paramArray = { 
                                {"@StartDate",StartDate},
                                {"@EndDate", EndDate},
                                {"@Id", Id}
                                       };
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "Report_ProductInOutDetailedReport", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable ProductTransactionSummaryReprot(string StartDate, string EndDate, string Id)
        {
            DataTable dt = null;
            try
            {
                string[,] paramArray = { 
                                {"@StartDate",StartDate},
                                {"@EndDate", EndDate},
                                {"@Id", Id}
                                       };
                DataAccessManager dam = new DataAccessManager();
                dt = dam.GetDataTable(CommandType.StoredProcedure, "Report_ProductInOutSummaryReport", paramArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }


    }

    public enum ReportLevel
    {
        AllBusiness,
        Yearly,
        Monthly,
        Daily,
        EveryReceipt,
        EveryReceiptDetail,
        AllProducts,
        CustomerWise,
        SupplierWise,
    }

    public enum Report
    {
        CustomerSalesReport,
        CustomerSalesReportDetailed,
        ProductSaleReport,
        ProductPurchaseReport,
        CompanyPurchaseReport,
        CompanyPurchaseReportDetailed,
        DailySalesPurchase,
        BuyerLedger,
        BuyerLedgerProductWise,
        CustomerTransactionsReport,
        CompanyTransactionsReport,
        CurrentCashReport,
        ProfitLoss,
        Receipt,
        Invoice,
        Order,
        Payment,
        CompanyCustomerList,
        ItemList,
        ItemListBySupplier,
        Stock,
        ProductDailySalePurchaseSummaryReport,
        ProductInOutDetailReport,
        ProductInOutSummaryReport,
    }

    public class ReportInfo
    {
        public long Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ReportLevel Level { get; set; }
        public Report Report { get; set; }
        public string Options { get; set; }
    }
}
