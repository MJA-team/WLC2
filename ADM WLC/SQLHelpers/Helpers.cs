using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace ADM_WLC.SQLHelpers
{
    public static class Helpers
    {
        public static string connectionString = Properties.Settings.Default.LocalDB;

        public static DataTable GetDatatable(string pQuery, int pTimeOut = 0)
        {
            SQLiteDataAdapter da = null;
            DataTable dta = new DataTable();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    da = new SQLiteDataAdapter(pQuery, conn);
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

        public static int ExecQuery(string pQuery, int pTimeOut = 30)
        {
            int pRowAff = -1;
            try
            {
                    using (SqlConnection Conn = new SqlConnection())
                    {
                        Conn.ConnectionString = connectionString;
                        SqlCommand cmd = new SqlCommand(pQuery, Conn);
                        cmd.CommandTimeout = pTimeOut;
                        Conn.Open();
                        pRowAff = cmd.ExecuteNonQuery();
                    }
                return pRowAff;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class WLCDataDB
    {
        public DataTable GetFirstWLCDataPlan()
        {
            string qry = @"Select top 1 pid,vin,suffix,model_code,wlc_code,chassis_number from wlc_data where classification = 'Plan' order by seq asc";
            DataTable dta = new DataTable();
            dta = Helpers.GetDatatable(qry);
            return dta;
        }

        public void SetWLCDataSent(string pid)
        {
            string qry = @"Update wlc_data SET classification = 'Sent PLC' where pid = '" + pid + "'";
            Helpers.ExecQuery(qry);
        }
    }
}
