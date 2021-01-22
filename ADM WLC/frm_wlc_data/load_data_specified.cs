using ADM_WLC.SQLHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class load_data_specified : Form
    {
        private readonly form_wlc_data _form;
        private DataTable dt;
        private SqlConnection conn;

        public load_data_specified(form_wlc_data form)
        {
            InitializeComponent();
            _form = form;
        }

        private void CreateTbTemp()
        {
            try
            {
                string Query = @"CREATE TABLE [adm_wlc].[dbo].[wlc_data_temp](
	                               [seq] INT
                                  ,[pid] VARCHAR(50)
                                  ,[vin] VARCHAR(50)
                                  ,[plan_date] VARCHAR(50)
                                  ,[wlc_code] VARCHAR(50)
                                  ,[model_code] VARCHAR(50)
                                  ,[suffix] VARCHAR(50)
                                  ,[chassis_number] VARCHAR(50)
                                  ,[classification] VARCHAR(50))";
                conn = new SqlConnection();
                conn.ConnectionString = Helpers.connectionString;
                SqlCommand cmd = new SqlCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtTable()
        {
            //string firstPID = tb_head_pid_load_data_specified.Text;
            //string lastPID = tb_last_pid_specified.Text;
            int numb = Convert.ToInt32(tb_numb_data_specified.Text);
            try
            {
                string Query = @"SELECT TOP "+ numb +" pid, vin, plan_date, wlc_code, model_code, suffix, chassis_number, classification FROM wlc_data_temp";

                dt = new DataTable();
                dt = Helpers.GetDatatable(Query);
                _form.dataGridView_wlc_data.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteTb_Temp()
        {
            string Query = @"DROP TABLE [adm_wlc].[dbo].[wlc_data_temp]";
            conn = new SqlConnection();
            conn.ConnectionString = Helpers.connectionString;
            SqlCommand cmd = new SqlCommand(Query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_cancel_load_data_specified_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_load_specified_Click(object sender, EventArgs e)
        {
            CreateTbTemp();
            _form.SaveTemp();
            dtTable();
            _form.LoadSpecific();
            _form.TampilAll();
            DeleteTb_Temp();
            this.Close();
        }

        private void load_data_specified_Load(object sender, EventArgs e)
        {
            tb_head_pid_load_data_specified.GotFocus += tb_head_pid_load_data_specified_GotFocus;
            tb_last_pid_specified.GotFocus += tb_last_pid_specified_GotFocus;
        }

        private void tb_last_pid_specified_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }

        private void tb_head_pid_load_data_specified_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }
    }
}
