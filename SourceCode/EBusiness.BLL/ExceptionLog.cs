using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EBusiness.DAL;
using System.Data;

namespace EBusiness.BLL
{
    public class ExceptionLog
    {
       
        public static void LogException(Modules Module, string Method, Exception excp,string title)
        {
            try
            {
                if (excp != null)
                {
                    string Message = excp.Message;
                    string StackTrace = excp.StackTrace;
                    string InnerMessage = null;
                    if (excp.InnerException != null)
                    {
                        InnerMessage = excp.InnerException.Message;
                    }

                    bool result = false;

                    DataAccessManager dam = new DataAccessManager();
                    string[,] paramArray = { 
                        {"@Module", Module.ToString()},
                        {"@Method", Method},
                        {"@Message", Message},
                        {"@StackTrace", StackTrace},
                        {"@InnerMessage", InnerMessage}
                
                        };
                    dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertExceptionLog", paramArray);
                   
                    ExceptionMessageShow exception1 = new ExceptionMessageShow(title,Message);
                    exception1.ShowExceptionMessage();
                }
            }
            catch (Exception ex)
            {
                ExceptionMessageShow exception1 = new ExceptionMessageShow(title,ex.Message.ToString());
                exception1.ShowExceptionMessage();
            }
        }

        public static DataTable ViewExceptionLog(string startDate,string endDate,string Module)
        {
            DataTable datatableException = new DataTable();
            try
            {
                DataAccessManager dam = new DataAccessManager();
                string[,] pararray = {
                                     {"@StartDate",startDate},
                                     {"@EndDate",endDate},
                                     {"@Module",Module}
                                     };
                datatableException = dam.GetDataTable(CommandType.StoredProcedure, "SelectExceptionLog",pararray);
            }
            catch (Exception exe)
            {
                throw exe;
            }
            return datatableException;
        }
    }
}
