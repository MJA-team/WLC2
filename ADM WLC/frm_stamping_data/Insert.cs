using ADM_WLC.SQLHelpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class Insert : Form
    {
        private readonly form_stamping_result _form;
        private SQLiteConnection conn;
        private DataTable dt;

        public Insert(form_stamping_result form)
        {
            InitializeComponent();
            _form = form;
        }

        private void InsertSR_temp()
        {
            try
            {
                string startDate = (string)datePicker_startdate_insert.Text;
                string endDate = (string)timePicker_starttime_insert.Text;
                string pid = tb_pid_insert.Text;
                string chassis = tb_chassis_number_insert.Text;

                string Query = @"INSERT INTO stamping_result_temp (date, time, pid, chassis_number)
                                                           VALUES ('" + startDate + "', " +
                                                                  "'" + endDate + "'," +
                                                                  "'" + pid + "'," +
                                                                  "'" + chassis + "')";
                conn = new SQLiteConnection();
                conn.ConnectionString = Helpers.connectionString;
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertSR()
        {
            try
            {
                string Query = @"INSERT INTO stamping_result SELECT * FROM stamping_result_temp";
                conn = new SQLiteConnection();
                conn.ConnectionString = Helpers.connectionString;
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidationSR()
        {
            try
            {
                string data = @"SELECT pid FROM stamping_result INTERSECT SELECT pid FROM stamping_result_temp";
                dt = new DataTable();
                dt = Helpers.GetDatatable(data);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("PID Already Exists!!", "ADM WL/C");
                }
                else
                {
                    InsertSR();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_close_insert_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            timePicker_starttime_insert.Value = System.DateTime.Now;
            datePicker_startdate_insert.Value = System.DateTime.Now;
        }

        private void btn_insert_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_pid_insert.Text))
            {
                MessageBox.Show("PID Cannot be empty!!", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty(tb_chassis_number_insert.Text))
            {
                MessageBox.Show("Chassis Number Cannot be empty!!", "ADM WL/C");
            }
            else
            {
                _form.CreateSR_Temp();
                InsertSR_temp();
                InsertSR();
                _form.DeleteSR_Temp();
                _form.TampilAll();
                this.Close();
            }
        }
    }
}
