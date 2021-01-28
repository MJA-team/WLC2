using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using ADM_WLC.SQLHelpers;

namespace ADM_WLC
{
    public partial class form_wlc_data : Form
    {
        private SqlConnection conn;
        private SqlDataReader drt;
        private DataTable dt;
        public static OpenFileDialog ofd;
        string line = "";
        string id = string.Empty;

        public enum Classification { Plan = 0, SendPLC = 1, Insert = 2, Delete = 3, Suspend = 4 };

        public form_wlc_data()
        {
            InitializeComponent();
        }

        private void SelectedRow()
        {
            if (dataGridView_wlc_data.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dataGridView_wlc_data.SelectedRows[0];
                id = selectedrow.Cells[1].Value.ToString();
            }
            if (id == "")
            {
                return; //Keluar dari perintah delete
            }
        }

        public void TampilAll()
        {
            try
            {
                string Query = @"SELECT pid, vin, plan_date, wlc_code, model_code, suffix, chassis_number, classification FROM wlc_data";

                dt = new DataTable();
                dt = Helpers.GetDatatable(Query);
                dataGridView_wlc_data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveAll()
        {
            try
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                while ((line = sr.ReadLine()) != null)
                {
                    //line = sr.ReadToEnd();
                    if (line != null)
                    {
                        Classification cl = Classification.Plan;
                        string classif = cl.ToString();
                        string sequence = line.Substring(0, 4);
                        string pid = line.Substring(4, 10);
                        string vin = line.Substring(14, 17);
                        string _1date = line.Substring(31, 8);
                        string wlc = line.Substring(39, 4);
                        string model = line.Substring(43, 4);
                        string suffix = line.Substring(47, 2);
                        string chasis = line.Substring(49, 19);
                        string _2date = _1date.Insert(2, "/");
                        string date = _2date.Insert(5, "/");
                        DateTime time = DateTime.Parse(date);
                        string _date = time.ToString("yyyy/MM/dd");

                        string data = @"SELECT * FROM wlc_data WHERE pid = '"+ pid + "' AND vin = '" + vin + "'";
                        dt = new DataTable();
                        dt = Helpers.GetDatatable(data);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("PID or VIN Already Exists!!", "ADM WL/C");
                            break;
                        }
                        else
                        {
                            string Query = @"INSERT INTO wlc_data (seq, pid, vin, plan_date, wlc_code, model_code, suffix, chassis_number, classification) 
                                            VALUES ('" + sequence + "', " +
                                                  "'" + pid + "', " +
                                                  "'" + vin + "'," +
                                                  "'" + _date + "'," +
                                                  "'" + wlc + "'," +
                                                  "'" + model + "'," +
                                                  "'" + suffix + "'," +
                                                  "'" + chasis + "'," +
                                                  "'" + classif + "')";

                            conn = new SqlConnection();
                            conn.ConnectionString = Helpers.connectionString;
                            SqlCommand cmd = new SqlCommand(Query, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void SaveTemp()
        {
            try
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                while ((line = sr.ReadLine()) != null)
                {
                    //line = sr.ReadToEnd();
                    if (line != null)
                    {
                        Classification cl = Classification.Plan;
                        string classif = cl.ToString();
                        string sequence = line.Substring(0, 4);
                        string pid = line.Substring(4, 10);
                        string vin = line.Substring(14, 17);
                        string _1date = line.Substring(31, 8);
                        string wlc = line.Substring(39, 4);
                        string model = line.Substring(43, 4);
                        string suffix = line.Substring(47, 2);
                        string chasis = line.Substring(49, 19);
                        string _2date = _1date.Insert(2, "/");
                        string date = _2date.Insert(5, "/");
                        DateTime time = DateTime.Parse(date);
                        string _date = time.ToString("yyyy/MM/dd");
                        string Query = @"INSERT INTO wlc_data_temp (seq, pid, vin, plan_date, wlc_code, model_code, suffix, chassis_number, classification) 
                                        VALUES ('" + sequence + "', " +
                                                    "'" + pid + "', " +
                                                    "'" + vin + "'," +
                                                    "'" + _date + "'," +
                                                    "'" + wlc + "'," +
                                                    "'" + model + "'," +
                                                    "'" + suffix + "'," +
                                                    "'" + chasis + "'," +
                                                    "'" + classif + "')";

                        conn = new SqlConnection();
                        conn.ConnectionString = Helpers.connectionString;
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void DeleteGrid()
        {
            SelectedRow();

            DialogResult dialogResult = MessageBox.Show("Delete data " + id + " ?", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow oneRow in dataGridView_wlc_data.SelectedRows)
                {
                    if (oneRow.Selected)
                    {
                        string Query = @"DELETE wlc_data WHERE pid ='" + id + "'";
                        conn = new SqlConnection();
                        conn.ConnectionString = Helpers.connectionString;
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    MessageBox.Show("Data Deleted Successfully !!!", "ADM WL/C");
                }
            }
        }

        public void DeleteAll()
        {
            try
            {
                string Query = @"DELETE FROM wlc_data";
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

        public void Insert()
        {
            try
            {
                DataTable dtTable = new DataTable();
                for (int i = 0; i < dataGridView_wlc_data.Rows.Count; i++)
                {
                    string sequence = "";
                    string pid = (string)dataGridView_wlc_data.Rows[i].Cells[1].Value;
                    string vin = (string)dataGridView_wlc_data.Rows[i].Cells[2].Value;
                    DateTime date = Convert.ToDateTime(dataGridView_wlc_data.Rows[i].Cells[3].Value);
                    string _date = date.ToString("yyyy/MM/dd");
                    string wlc = (string)dataGridView_wlc_data.Rows[i].Cells[4].Value;
                    string model = (string)dataGridView_wlc_data.Rows[i].Cells[5].Value;
                    string suffix = (string)dataGridView_wlc_data.Rows[i].Cells[6].Value;
                    string chasis = (string)dataGridView_wlc_data.Rows[i].Cells[7].Value;
                    string classif = (string)dataGridView_wlc_data.Rows[i].Cells[8].Value;
                    string Query = @"INSERT INTO wlc_data (seq, pid, vin, plan_date, wlc_code, model_code, suffix, chassis_number, classification) 
                                        VALUES ('" + sequence + "', " +
                                                "'" + pid + "', " +
                                                "'" + vin + "'," +
                                                "'" + _date + "'," +
                                                "'" + wlc + "'," +
                                                "'" + model + "'," +
                                                "'" + suffix + "'," +
                                                "'" + chasis + "'," +
                                                "'" + classif + "')";

                        conn = new SqlConnection();
                        conn.ConnectionString = Helpers.connectionString;
                        SqlCommand cmd = new SqlCommand(Query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void InsertAfter()
        {
            form_insert f = new form_insert(this);
            int index = dataGridView_wlc_data.SelectedRows[0].Index;
            int idx = index + 1;
            bool Itemfound = false;
            if (dataGridView_wlc_data.Rows.Count > 0)
            {
                foreach(DataGridViewRow NewItem in dataGridView_wlc_data.Rows)
                {
                    if (Convert.ToString(NewItem.Cells[1].Value) == GetText.pid || Convert.ToString(NewItem.Cells[2].Value) == GetText.vin)
                    {
                        Itemfound = true;
                        MessageBox.Show("PID or VIN Already Exists!!", "ADM WL/C");
                        break;
                    }
                }
            }
            if (Itemfound == false)
            {
                DataRow dr = dt.NewRow();
                dr[0] = GetText.pid;
                dr[1] = GetText.vin;
                dr[2] = GetText.date;
                dr[3] = GetText.wlc;
                dr[4] = GetText.model;
                dr[5] = GetText.suffix;
                dr[6] = GetText.chassis;
                dr[7] = "Insert";
                dt.Rows.InsertAt(dr, idx);
            }
        }

        public void InsertTop()
        {
            form_insert f = new form_insert(this);
            int index = dataGridView_wlc_data.Rows[0].Index;
            bool Itemfound = false;
            if (dataGridView_wlc_data.Rows.Count > 0)
            {
                foreach (DataGridViewRow NewItem in dataGridView_wlc_data.Rows)
                {
                    if (Convert.ToString(NewItem.Cells[1].Value) == GetText.pid || Convert.ToString(NewItem.Cells[2].Value) == GetText.vin)
                    {
                        Itemfound = true;
                        MessageBox.Show("PID or VIN Already Exists!!", "ADM WL/C");
                        break;
                    }
                }
            }
            if (Itemfound == false)
            {
                DataRow dr = dt.NewRow();
                dr[0] = GetText.pid;
                dr[1] = GetText.vin;
                dr[2] = GetText.date;
                dr[3] = GetText.wlc;
                dr[4] = GetText.model;
                dr[5] = GetText.suffix;
                dr[6] = GetText.chassis;
                dr[7] = "Insert";
                dt.Rows.InsertAt(dr, index);
            }
        }

        public void InsertAfterSuspend()
        {
            try
            {
                suspend_data_list f = new suspend_data_list(this);
                int index = dataGridView_wlc_data.SelectedRows[0].Index;
                int idx = index + 1;
                DataRow dr = dt.NewRow();
                string Query = @"SELECT * FROM wlc_data WHERE pid = '" + GetText.lb_pid + "'";
                conn = new SqlConnection();
                conn.ConnectionString = Helpers.connectionString;
                SqlCommand cmd = new SqlCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                drt = cmd.ExecuteReader();

                while (drt.Read())
                {
                    dr[0] = (drt["pid"]);
                    dr[1] = (drt["vin"]);
                    dr[2] = (drt["plan_date"]);
                    dr[3] = (drt["wlc_code"]);
                    dr[4] = (drt["model_code"]);
                    dr[5] = (drt["suffix"]);
                    dr[6] = (drt["chassis_number"]);
                    dr[7] = "Plan";
                    dt.Rows.InsertAt(dr, idx);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertTopSuspend()
        {
            try
            {
                suspend_data_list f = new suspend_data_list(this);
                int index = dataGridView_wlc_data.Rows[0].Index;
                DataRow dr = dt.NewRow();
                string Query = @"SELECT * FROM wlc_data WHERE pid = '" + GetText.lb_pid + "'";
                conn = new SqlConnection();
                conn.ConnectionString = Helpers.connectionString;
                SqlCommand cmd = new SqlCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                drt = cmd.ExecuteReader();

                while (drt.Read())
                {
                    dr[0] = (drt["pid"]);
                    dr[1] = (drt["vin"]);
                    dr[2] = (drt["plan_date"]);
                    dr[3] = (drt["wlc_code"]);
                    dr[4] = (drt["model_code"]);
                    dr[5] = (drt["suffix"]);
                    dr[6] = (drt["chassis_number"]);
                    dr[7] = "Plan";
                    dt.Rows.InsertAt(dr, index);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    
        }

        public void DeleteRow()
        {
            foreach (DataGridViewRow DeleteItem in dataGridView_wlc_data.Rows)
            {
                if (Convert.ToString(DeleteItem.Cells[1].Value) == GetText.lb_pid && Convert.ToString(DeleteItem.Cells[8].Value) == "Suspend")
                {
                    dataGridView_wlc_data.Rows.Remove(DeleteItem);
                }
            }
        }

        private void form_wlc_data_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;

            dataGridView_wlc_data.EnableHeadersVisualStyles = false;
            dataGridView_wlc_data.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            dataGridView_wlc_data.Columns[3].DefaultCellStyle.Format = "yyyy/MM/dd";

            TampilAll();
        }

        private void btn_close_wlc_data_Click(object sender, EventArgs e)
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
        
        private void btn_dataloading_wlc_data_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "TXT file|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int counter = File.ReadAllLines(ofd.FileName).Length;
                string last = File.ReadAllLines(ofd.FileName).Last();
                string first = File.ReadAllLines(ofd.FileName).First();
                string pidLast = last.Substring(4, 10);
                string pidFirst = first.Substring(4, 10);
                string cnt = counter.ToString();
                load_data f = new load_data(this);
                f.Show();
                f.tb_head_pid.Text = pidFirst;
                f.tb_last_pid.Text = pidLast;
                f.tb_numb_data.Text = cnt;
            }
        }

        private void btn_insert_wlc_data_Click(object sender, EventArgs e)
        {
            SelectedRow();
            pnl_suspend_data_list_wlc_data.Controls.Clear();
            form_insert f = new form_insert(this);
            f.TopLevel = false;
            pnl_suspend_data_list_wlc_data.Controls.Add(f);
            f.btn_insert_after_insert.Text = "Insert After " + id;
            f.Show();
        }

        private void dataGridView_wlc_data_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_wlc_data.Rows)
            {
                string Rdg = row.Cells[8].Value.ToString();
                if (Rdg == "Suspend")
                {
                    row.DefaultCellStyle.BackColor = Color.Fuchsia;
                }
                else if (Rdg == "SendPLC")
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                }
                else if (Rdg == "Insert")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (Rdg == "Delete")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dataGridView_wlc_data_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView_wlc_data.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void btn_alldelete_wlc_data_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete All PIDs", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteAll();
            }
            TampilAll();
        }

        private void btn_delete_wlc_data_Click(object sender, EventArgs e)
        {
            DeleteGrid();
            TampilAll();
        }

        private void btn_suspend_wlc_data_Click(object sender, EventArgs e)
        {
            SelectedRow();
            DialogResult dialogResult = MessageBox.Show("Suspend PID " + id + " ?", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SelectedRow();
                    string Query = @"UPDATE wlc_data SET classification = 'Suspend' WHERE pid = '" + id + "'";
                    dt = new DataTable();
                    dt = Helpers.GetDatatable(Query);
                    TampilAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_deleteplan_wlc_data_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("The logical delete the unset data plan all.", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SelectedRow();
                    string Query = @"UPDATE wlc_data SET classification = 'Delete' WHERE pid = '" + id + "'";
                    dt = new DataTable();
                    dt = Helpers.GetDatatable(Query);
                    TampilAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_suspenddatalist_wlc_data_Click(object sender, EventArgs e)
        {
            SelectedRow();
            pnl_suspend_data_list_wlc_data.Controls.Clear();
            suspend_data_list f = new suspend_data_list(this);
            f.TopLevel = false;
            pnl_suspend_data_list_wlc_data.Controls.Add(f);
            f.btn_insert_after_suspend_data_list.Text = "Insert After " + id;
            f.Show();
        }
    }
}
