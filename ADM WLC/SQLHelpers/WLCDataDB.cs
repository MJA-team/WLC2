using System.Data;

namespace ADM_WLC.SQLHelpers
{
    public class WLCDataDB
    {
        public static void CheckWLCDataTable()
        {
            string quer = @"CREATE TABLE [IF NOT EXISTS] wlc_data (
	column_1 data_type PRIMARY KEY,
   	column_2 data_type NOT NULL,
	column_3 data_type DEFAULT 0,
	table_constraints
) [WITHOUT ROWID];";
        }
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
