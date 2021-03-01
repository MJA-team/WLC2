using ADM_WLC.SQLHelpers;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ADM_WLC.conv_result
{
    public partial class pid_list : Form
    {
        private readonly form_conv_result _form;
        private SQLiteConnection conn;
        private SQLiteDataReader dr;

        public pid_list(form_conv_result form)
        {
            InitializeComponent();
            _form = form;
        }

        private void PidList()
        {
            try
            {
                string Query = @"SELECT pid FROM wlc_data";
                conn = new SQLiteConnection();
                conn.ConnectionString = Helpers.connectionString;
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lb_pid_list.Items.Add(dr["pid"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btn_cancel_pid_list_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pid_list_Load(object sender, EventArgs e)
        {
            PidList();
        }

        private void btn_ok_pid_list_Click(object sender, EventArgs e)
        {
            GetText.pidlist = (string)lb_pid_list.SelectedItem;
            _form.ShowDetail();
            this.Close();
        }

        private void lb_pid_list_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }
    }
}
