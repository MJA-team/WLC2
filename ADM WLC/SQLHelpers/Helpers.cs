using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADM_WLC.SQLHelpers
{
    public static class Helpers
    {
        public static string connectionString = Properties.Settings.Default.connWlc;

        public static DataTable GetDatatable(string pQuery, int pTimeOut = 0)
        {
            SqlDataAdapter da = null;
            DataTable dta = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    da = new SqlDataAdapter(pQuery, conn);
                    da.Fill(dta);
                }
                da = null;
                return dta;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}
