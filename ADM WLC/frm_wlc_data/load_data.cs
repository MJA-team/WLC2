using ADM_WLC.SQLHelpers;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class load_data : Form
    {
        private readonly form_wlc_data _form;
        private SQLiteConnection conn;

        public load_data(form_wlc_data form)
        {
            InitializeComponent();
            _form = form;
        }

        private void InsertTb()
        {
            try
            {
                string Query = @"INSERT INTO wlc_data SELECT * FROM wlc_data_temp";
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

        private void btn_cancel_load_data_Click(object sender, EventArgs e)
        {
            _form.DeleteTb_Temp();
            this.Close();
        }

        private void btn_headpid_load_data_Click(object sender, EventArgs e)
        {
            load_data_specified f = new load_data_specified(this._form);
            f.ShowDialog();
            this.Close();
        }

        private void btn_loadall_load_data_Click(object sender, EventArgs e)
        {
            InsertTb();
            _form.DeleteTb_Temp();
            _form.TampilAll();
            this.Close();
        }

        private void load_data_Load(object sender, EventArgs e)
        {
            tb_head_pid.GotFocus += tb_head_pid_GotFocus;
            tb_last_pid.GotFocus += tb_last_pid_GotFocus;
            tb_numb_data.GotFocus += tb_numb_data_GotFocus;
            tb_head_pid.Text = GetText.PidFirst;
            tb_last_pid.Text = GetText.PidLast;
            tb_numb_data.Text = GetText.CounterPid;
        }

        private void tb_numb_data_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }

        private void tb_last_pid_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }

        private void tb_head_pid_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }
    }
}
