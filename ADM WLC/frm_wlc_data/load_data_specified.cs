using ADM_WLC.SQLHelpers;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class load_data_specified : Form
    {
        private readonly form_wlc_data _form;
        private SQLiteConnection conn;

        public load_data_specified(form_wlc_data form)
        {
            InitializeComponent();
            _form = form;
        }

        private void InsertTb()
        {
            //string firstPID = tb_head_pid_load_data_specified.Text;
            //string lastPID = tb_last_pid_specified.Text;
            int numb = Convert.ToInt32(tb_numb_data_specified.Text);
            try
            {
                string Query = @"INSERT INTO wlc_data SELECT * FROM wlc_data_temp LIMIT '" + numb + "'";
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
                
        private void btn_cancel_load_data_specified_Click(object sender, EventArgs e)
        {
            _form.DeleteTb_Temp();
            this.Close();
        }

        private void btn_load_specified_Click(object sender, EventArgs e)
        {
            InsertTb();
            _form.DeleteTb_Temp();
            _form.TampilAll();
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
