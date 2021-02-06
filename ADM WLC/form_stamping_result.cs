using ADM_WLC.SQLHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class form_stamping_result : Form
    {
        private DataTable dt;
        private SqlConnection conn;
        string id = string.Empty;

        public form_stamping_result()
        {
            InitializeComponent();
        }

        public void CreateSR_Temp()
        {
            try
            {
                string Query = @"CREATE TABLE [adm_wlc].[dbo].[stamping_result_temp](
	                               [date] VARCHAR(50)
                                  ,[time] VARCHAR(50)
                                  ,[pid] VARCHAR(50)
                                  ,[chassis_number] VARCHAR(50))";
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

        public void DeleteSR_Temp()
        {
            try
            {
                string Query = @"DROP TABLE [adm_wlc].[dbo].[stamping_result_temp]";
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

        private void SelectedRow()
        {
            if (dataGridView_stamping_result.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dataGridView_stamping_result.SelectedRows[0];
                id = selectedrow.Cells[2].Value.ToString();
            }
            if (id == "")
            {
                return; //Keluar dari perintah delete
            }
        }

        public void Tampil_Temp()
        {
            try
            {
                string DateStart = GetText.dateStart;
                string DateEnd = GetText.dateEnd;
                string TimeStart = GetText.timeStart;
                string TimeEnd = GetText.timeEnd;
                string Query = @"SELECT * FROM stamping_result WHERE date BETWEEN '" + DateStart + "' AND '" + DateEnd + "' " +
                                "AND time  BETWEEN '" + TimeStart + "' AND '" + TimeEnd + "' ORDER BY date, time ASC";
                dt = new DataTable();
                dt = Helpers.GetDatatable(Query);
                dataGridView_stamping_result.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void TampilAll()
        {
            try
            {
                string InitialTimeStart = (string)dateTimePicker_start_stamping_result.Text;
                string InitialTimeEnd = (string)dateTimePicker_end_stamping_result.Text;
                string Query = @"SELECT * FROM stamping_result WHERE time BETWEEN '" + InitialTimeStart + "' AND '" + InitialTimeEnd + "' ORDER BY date, time ASC";
                dt = new DataTable();
                dt = Helpers.GetDatatable(Query);
                dataGridView_stamping_result.DataSource = dt;
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
                foreach (DataGridViewRow oneRow in dataGridView_stamping_result.SelectedRows)
                {
                    if (oneRow.Selected)
                    {
                        string Query = @"DELETE stamping_result WHERE pid ='" + id + "'";
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

        public void ExportCSV()
        {
            if (dataGridView_stamping_result.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Stamping Result.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message, "ADM WL/C");
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView_stamping_result.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView_stamping_result.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView_stamping_result.Columns[i].HeaderText.ToString() + ";";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView_stamping_result.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView_stamping_result.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "ADM WL/C");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message, "ADM WL/C");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "ADM WL/C");
            }
        }

        private void form_stamping_result_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            dataGridView_stamping_result.EnableHeadersVisualStyles = false;
            dataGridView_stamping_result.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;

            TampilAll();
        }

        private void btn_close_stamping_result_Click(object sender, EventArgs e)
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

        private void dataGridView_stamping_result_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView_stamping_result.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }

        private void btn_insert_stamping_result_Click(object sender, EventArgs e)
        {
            pnl_stamping_data.Controls.Clear();
            Insert f = new Insert(this);
            f.TopLevel = false;
            pnl_stamping_data.Controls.Add(f);
            f.Show();
        }

        private void btn_fivesave_stamping_result_Click(object sender, EventArgs e)
        {
            SaveDataRangeDialog f = new SaveDataRangeDialog(this);
            f.ShowDialog();
        }

        private void btn_organizedata_stamping_result_Click(object sender, EventArgs e)
        {
            OrganizeData f = new OrganizeData();
            f.ShowDialog();
        }

        private void dateTimePicker_start_stamping_result_ValueChanged(object sender, EventArgs e)
        {
            TampilAll();
        }

        private void dateTimePicker_end_stamping_result_ValueChanged(object sender, EventArgs e)
        {
            TampilAll();
        }

        private void btn_delete_stamping_result_Click(object sender, EventArgs e)
        {
            DeleteGrid();
            TampilAll();
        }
    }
}
