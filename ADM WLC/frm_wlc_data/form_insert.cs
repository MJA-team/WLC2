using ADM_WLC.SQLHelpers;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class form_insert : Form
    {
        private readonly form_wlc_data _form;
        private SQLiteConnection conn;

        public enum Classification { Plan = 0, SendPLC = 1, Insert = 2, Delete = 3, Suspended = 4 };

        public form_insert(form_wlc_data form)
        {
            InitializeComponent();
            _form = form;
        }

        private void InsertDG()
        {
            GetText.pid = tb_pid_insert.Text;
            GetText.vin = tb_vin_insert.Text;
            GetText.date = dtPicker.Value.ToString("yyyy-MM-dd");
            GetText.wlc = (string)lb_wlc_code_insert.SelectedItem;
            GetText.model = tb_model_insert.Text;
            GetText.suffix = tb_suffix_insert.Text;
            GetText.chassis = tb_chassis_number.Text;
        }

        private void InsertNew()
        {
            try
            {
                string sequence = "";
                string pid = tb_pid_insert.Text;
                string _1pid = pid.Substring(2, 8);
                string _pid = "F1" + _1pid;
                string vin = tb_vin_insert.Text;
                DateTime date = dtPicker.Value.Date;
                string _date = date.ToString("yyyy-MM-dd");
                string wlc = (string)lb_wlc_code_insert.SelectedItem;
                string model = tb_model_insert.Text;
                string suffix = tb_suffix_insert.Text;
                string chasis = tb_chassis_number.Text;
                string classif = "Insert";
                string Query = @"INSERT INTO wlc_data (seq, pid, vin, plan_date, wlc_code, model_code, suffix, chassis_number, classification) 
                                   VALUES ('" + sequence + "', " +
                                          "'" + _pid + "', " +
                                          "'" + vin + "'," +
                                          "'" + _date + "'," +
                                          "'" + wlc + "'," +
                                          "'" + model + "'," +
                                          "'" + suffix + "'," +
                                          "'" + chasis + "'," +
                                          "'" + classif + "')";

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

        private void btn_close_insert_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_top_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_pid_insert.Text))
            {
                MessageBox.Show("PID Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty(tb_vin_insert.Text))
            {
                MessageBox.Show("VIN Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty((string)lb_wlc_code_insert.SelectedItem))
            {
                MessageBox.Show("WLC Code Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty(tb_model_insert.Text))
            {
                MessageBox.Show("Model Code Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty(tb_suffix_insert.Text))
            {
                MessageBox.Show("Suffix Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty(tb_chassis_number.Text))
            {
                MessageBox.Show("Chassis Number Cannot be empty", "ADM WL/C");
            }
            else
            {
                if (_form.dataGridView_wlc_data.Rows.Count < 0)
                {
                    InsertNew();
                    _form.TampilAll();
                    this.Close();
                }
                else
                {
                    InsertDG();
                    _form.InsertTop();
                    _form.DeleteAll();
                    _form.Insert();
                    this.Close();
                }
            }
        }

        private void btn_insert_after_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_pid_insert.Text))
            {
                MessageBox.Show("PID Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty(tb_vin_insert.Text))
            {
                MessageBox.Show("VIN Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty((string)lb_wlc_code_insert.SelectedItem))
            {
                MessageBox.Show("WLC Code Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty(tb_model_insert.Text))
            {
                MessageBox.Show("Model Code Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty(tb_suffix_insert.Text))
            {
                MessageBox.Show("Suffix Cannot be empty", "ADM WL/C");
            }
            else if (string.IsNullOrEmpty(tb_chassis_number.Text))
            {
                MessageBox.Show("Chassis Number Cannot be empty", "ADM WL/C");
            }
            else
            {
                if (_form.dataGridView_wlc_data.Rows.Count == 0)
                {
                    InsertNew();
                    _form.TampilAll();
                    this.Close();
                }
                else
                {
                    InsertDG();
                    _form.InsertAfter();
                    _form.DeleteAll();
                    _form.Insert();
                    this.Close();
                }
            }
        }

        private void form_insert_Load(object sender, EventArgs e)
        {
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
            btn_insert_after_insert.Text = GetText.txtinsert;
        }
    }
}
