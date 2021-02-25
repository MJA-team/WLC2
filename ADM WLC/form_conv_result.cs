using ADM_WLC.conv_result;
using DGVPrinterHelper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ADM_WLC.SQLHelpers;
using System.Data.SqlClient;
using System.Data.SQLite;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace ADM_WLC
{
    public partial class form_conv_result : Form
    {
        public static DataTable dtView;
        public static DataTable dtAll;
        private static int displayIndex;
        PLCCommunication plc = new PLCCommunication();
        private SqlConnection conn;
        private SqlDataReader dr;
        string pass;
        public string valid { get; private set; }

        //private string valid = "FFyIPbfu0qhn7+vt6MRbu5otTkWhNcbFqUTnMHPk34E="; //Password : 123456

        public form_conv_result()
        {
            InitializeComponent();
        }

        public void PassSubmit()
        {
            pass = (string)GetText.psub;

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            byte[] salt = new byte[128 / 8];
            string hashedsubmit = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: pass,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            if (hashedsubmit == valid)
            {
                UpdateChassis();
            }
            else
            {
                MessageBox.Show("Wrong Password!!!", "ADM WL/C");
            }
        }

        public void PassEdit()
        {
            pass = (string)GetText.pedit;

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            byte[] salt = new byte[128 / 8];
            string hashededit = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: pass,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            if (hashededit == valid)
            {
                textBox_chasisnumber_conv_result.ReadOnly = false;
                textBox_chasisnumber_conv_result.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Wrong Password!!!", "ADM WL/C");
            }
        }

        private void UpdateChassis()
        {
            string chassis = textBox_chasisnumber_conv_result.Text;
            string pid = textBox_pid_conv_result.Text;

            try
            {
                string Query = @"UPDATE wlc_data SET chassis_number = '" + chassis + "' WHERE pid = '" + pid + "'";
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

        public void ShowDetail()
        {
            string PidList = GetText.pidlist;
            try
            {
                string Query = @"SELECT * FROM wlc_data WHERE pid = '" + PidList + "'";
                conn = new SQLiteConnection();
                conn.ConnectionString = Helpers.connectionString;
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    textBox_pid_conv_result.Text = ((string)dr["pid"]);
                    textBox_vin_conv_result.Text = ((string)dr["vin"]);
                    textBox_wlccode_conv_result.Text = ((string)dr["wlc_code"]);
                    textBox_modelcode_conv_result.Text = ((string)dr["model_code"]);
                    textBox_sfx_conv_result.Text = ((string)dr["suffix"]);
                    textBox_chasisnumber_conv_result.Text = ((string)dr["chassis_number"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_close_conv_result_Click(object sender, EventArgs e)
        {
            ((Form_menu)Application.OpenForms["Form_menu"]).lbl_name_menu.Text = "";
            Panel p = this.Parent as Panel;
            if (p != null)
            {
                form_menu_button f0 = new form_menu_button() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f0.FormBorderStyle = FormBorderStyle.None;
                p.Controls.Add(f0);
                f0.Show();
                this.Close();
            }
        }

        private void form_conv_result_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            btn_enableedit1_conv_result.Visible = false;
            dataGridView_conv_result.EnableHeadersVisualStyles = false;
            dataGridView_conv_result.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            btn_enableedit1_conv_result.Enabled = false;
            btn_enableedit_conv_result.Enabled = false;
            GetConvResultTableDataAsync();
            //while (dtAll == null)
            //{

            try
            {
                String Valid = @"SELECT * FROM user_pass";
                conn = new SQLiteConnection();
                conn.ConnectionString = Helpers.connectionString;
                SQLiteCommand cmd = new SQLiteCommand(Valid, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    valid = (string)(dr["pass"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //TampilGrid();
        }

        private void TampilGrid(int pointer)
        {

            //TO DO masih salah
            try
            {
                if (dtView != null)
                {
                    dtView.Clear();
                }
                dtView = DataGrid2Datatable(ref dataGridView_conv_result);
                var row = GetRowbyId(pointer);
                if (row == null)
                {
                    dtView.Rows.Add(row);
                }
                
                dtView.Rows.Add(row["jobcode"]);                
                dataGridView_conv_result.DataSource = dtView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DataRow GetRowbyId(int pointer)
        {
            if (dtAll != null)
            {
                var expression = "Id = " + pointer;
                var f = dtAll.Select(expression);
                return f.FirstOrDefault();
            }
            else return null;
        }

        private void InitJobCode()
        {
            if (dtView.Rows.Count > 0)
            {
                dtView.Clear();
                for (var i = 0; i < 30; i++)
                {
                    dtView.Rows.Add(0, 0);
                }
            }
        }

        private DataTable DataGrid2Datatable(ref DataGridView dataGridView)
        {
            DataTable table = new DataTable();
            foreach(DataGridViewColumn d in dataGridView.Columns)
            {
                table.Columns.Add(d.HeaderText);
            }
            return table;
        }

        private void btn_notyetstarted_conv_result_Click(object sender, EventArgs e)
        {
            btn_notyetstarted_conv_result.Hide();
            btn_started_conv_result.Show();
            btn_enableedit1_conv_result.Show();
            btn_enableedit_conv_result.Enabled = true;
        }

        private void btn_started_conv_result_Click(object sender, EventArgs e)
        {
            btn_notyetstarted_conv_result.Show();
            btn_started_conv_result.Hide();
            btn_enableedit1_conv_result.Hide();
            btn_enableedit_conv_result.Enabled = false;
        }

        private void dataGridView_conv_result_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView_conv_result.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }

        private void btn_pidlist_conv_result_Click(object sender, EventArgs e)
        {
            pid_list f = new pid_list(this);
            f.ShowDialog();
        }

        private void btn_zeroofall_conv_result_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Change all Job code to '0'?", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                InitJobCode();
                dataGridView_conv_result.DataSource = dtView;
                //TampilGrid(displayIndex);
            }
        }

        private void btn_submit_conv_result_Click(object sender, EventArgs e)
        {
            form_submit f = new form_submit(this);
            f.ShowDialog();
        }

        private void btn_enableedit_conv_result_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_chasisnumber_conv_result.Text))
            {
                MessageBox.Show("Please Select PID!!!", "ADM WL/C");
            }
            else
            {
                form_enable_edit f = new form_enable_edit(this);
                f.ShowDialog();
            }
        }

        private void btn_hardcopy_conv_result_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Conversion Result Data Maintenance";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.Footer = "";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView_conv_result);
        }

        private async void GetConvResultTableDataAsync()
        {
            DataTable dta = new DataTable();
            int result = await Task.Run(() => plc.GetConvResultTable(ref dta));
            if (result != 0)
            {
                string msg = "Read from PLC error";
                MessageBox.Show(msg, "ADM WL/C");
            }

            dtAll = dta.Copy();
            displayIndex = 0;
            TampilGrid(displayIndex);
            //TampilGrid();
        }

        private async void WriteConvResultTableDataAsync(int pointer)
        {
            string msg;
            var row = GetRowbyId(pointer);
            DataTable dt = new DataTable();
            dt.Rows.Add(row);
            int result = await Task.Run(() => plc.WriteConvResultTable(ref dt));
            switch (result)
            {
                case 0:
                    msg = "Write to PLC Succeeded";
                    break;
                case 7:
                    msg = "Write to PLC Error - no Data to write";
                    break;
                case 8:
                    msg = "Write to PLC Error - no connection to PLC";
                    break;
                default:
                    msg = "Write to PLC Error";
                    break;
            }
            MessageBox.Show(msg, "ADM WL/C");
        }
    }
}
