using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EBusiness.DAL;

namespace EBusiness.BLL
{
    public class UserLog
    {
        public static void Log(int? UserId, UserActions action , string ActionDetails)
        {
            string Ticks = DateTime.Now.Ticks.ToString();
            Log(Ticks, Convert.ToString(UserId), Convert.ToString((int)action), ActionDetails);
        }
        private static void Log(string Ticks, string UserId, string ActionId, string ActionDetails)
        {
            DataAccessManager dam = new DataAccessManager();
            string[,] paramArray = { {"@Ticks", Ticks},
                                   {"@UserId", UserId},
                                   {"@ActionId", ActionId},
                                   {"@ActionDetails", ActionDetails}};
            dam.ExecuteNonQuery(CommandType.StoredProcedure, "InsertUserLog", paramArray);
        }

        public static DataTable Select(string UserId, string StartTicks, string EndTicks)
        {
            DataTable dt = null;

            DataAccessManager dam = new DataAccessManager();
            string[,] paramArray = { {"@UserId", UserId},
                                   {"@StartTicks", StartTicks},
                                   {"@EndTicks", EndTicks}};
            dt = dam.GetDataTable(CommandType.StoredProcedure, "SelectUserLog", paramArray);

            return dt;
        }
    }
}
