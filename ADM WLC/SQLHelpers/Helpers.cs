using System;
using System.Data;
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
                    using (SQLiteConnection Conn = new SQLiteConnection())
                    {
                        Conn.ConnectionString = connectionString;
                        SQLiteCommand cmd = new SQLiteCommand(pQuery, Conn);
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
}
