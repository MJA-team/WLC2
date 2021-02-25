using ADM_WLC.SQLHelpers;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class suspend_data_list : Form
    {
        private readonly form_wlc_data _form;
        private SQLiteConnection conn;
        private SQLiteDataReader dr;
        string delPid;

        public suspend_data_list(form_wlc_data form)
        {
            InitializeComponent();
            _form = form;
        }

        private void SuspendList()
        {
            try
            {
                string Query = @"SELECT pid FROM wlc_data WHERE classification = 'Suspend'";
                conn = new SQLiteConnection();
                conn.ConnectionString = Helpers.connectionString;
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lb_pid_suspend_data_list.Items.Add(dr["pid"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListPidSuspended()
        {
            delPid = (string)lb_pid_suspend_data_list.SelectedItem;
        }

        private void DelSelect()
        {
            try
            {
                ListPidSuspended();
                string Query = @"DELETE FROM wlc_data WHERE pid = '" + delPid + "' AND classification = 'Suspend'";
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

        private void LbSelect()
        {
            GetText.lb_pid = (string)lb_pid_suspend_data_list.SelectedItem;
        }

        private void suspend_data_list_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            SuspendList();

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;
            timer1.Tick += new System.EventHandler(timer_Tick);
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RefreshMyForm();
        }

        private void RefreshMyForm()
        {
            btn_insert_after_suspend_data_list.Text = GetText.txtinsert;
        }

        private void btn_cancel_suspend_data_list_Click(object sender, EventArgs e)
        {
            _form.pnl_suspend_data_list_wlc_data.Controls.Clear();
            this.Close();
        }

        private void btn_insert_top_suspend_data_list_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)lb_pid_suspend_data_list.SelectedItem))
            {
                MessageBox.Show("Please Select PID!!", "ADM WL/C");
            }
            else
            {
                LbSelect();
                _form.InsertTopSuspend();
                _form.DeleteRow();
                _form.DeleteAll();
                _form.Insert();
                this.Close();
            }
        }

        private void btn_insert_after_suspend_data_list_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)lb_pid_suspend_data_list.SelectedItem))
            {
                MessageBox.Show("Please Select PID!!", "ADM WL/C");
            }
            else
            {
                LbSelect();
                _form.InsertAfterSuspend();
                _form.DeleteRow();
                _form.DeleteAll();
                _form.Insert();
                this.Close();
            }
        }

        private void btn_delete_suspend_data_list_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)lb_pid_suspend_data_list.SelectedItem))
            {
                MessageBox.Show("Please Select PID!!", "ADM WL/C");
            }
            else
            {
                ListPidSuspended();
                DialogResult dialogResult = MessageBox.Show("Delete Suspended PID " + delPid + " ?", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DelSelect();
                    _form.TampilAll();
                    this.Close();
                }
            }
        }
    }
}
