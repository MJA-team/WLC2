using ADM_WLC.SQLHelpers;
using System;
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
    public partial class form_process_table : Form
    {
        DataTable dt;
        DataTable dtAll;
        SqlConnection conn;
        PLCCommunication plc = new PLCCommunication();

        public form_process_table()
        {
            InitializeComponent();
        }

        private void btn_close_process_table_Click(object sender, EventArgs e)
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

        private void form_process_table_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;

            GetProcessTableDataAsync();
            comboBox_cclink_no_process_table.SelectedIndex = 0;
            dataGridView_process_table.EnableHeadersVisualStyles = false;
            dataGridView_process_table.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            //dataGridView_process_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async void GetProcessTableDataAsync()
        {
            DataTable dta = new DataTable();
            await Task.Run(() => plc.GetProcessTable(ref dta));
            dtAll = dta.Copy();
            TampilGrid();
        }

        private async void WriteProcessTableDataAsync()
        {
            int result = await Task.Run(() => plc.WriteProcessTable(ref dt));
            if (result!=0)
            {
                MessageBox.Show("Write to PLC Error", "ADM WL/C");
            }
        }

        private void TampilGrid()
        {
            Object cc_link = comboBox_cclink_no_process_table.SelectedItem;
            try
            {
                //string Query = @"SELECT *FROM process_table WHERE cc_link_no = '" + cc_link + "'";

                //dt = new DataTable();
                //dt = Helpers.GetDatatable(Query);
                if (dtAll != null)
                {
                    if (dt != null)
                    {
                        dt.Clear();
                    }
                    dt = dtAll.Clone();
                    // Filter expression
                    string expression = "cc_link_no = " + cc_link;

                    // Sort
                    //string sortOrder = "cc_link_no ASC, stno ASC";
                    string sortOrder = "cc_link_no ASC";
                    DataRow[] foundRows;

                    // Use the Select method to find all rows matching the filter.
                    foundRows = dtAll.Select(expression, sortOrder);
                    foreach (DataRow dr in foundRows)
                    {
                        dt.ImportRow(dr);
                    }
                }
                dataGridView_process_table.DataSource = dt;

                //Enable and Disable Button Next
                if (comboBox_cclink_no_process_table.SelectedIndex == 3)
                {
                    btn_next_process_table.Enabled = false;
                }
                else btn_next_process_table.Enabled = true;

                //Enable and Disable Button Prev
                if (comboBox_cclink_no_process_table.SelectedIndex == 0)
                {
                    btn_prev_process_table.Enabled = false;
                }
                else btn_prev_process_table.Enabled = true;

                //dataGridView_process_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TampilAll()
        {
            //try
            //{
            //    string Query = @"SELECT *FROM process_table";
            //    dt = new DataTable();
            //    dt = Helpers.GetDatatable(Query);
            //    dataGridView_process_table.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            if (dtAll != null)
            {
                if (dt != null)
                {
                    dt.Clear();
                }

                dt = dtAll.Copy();
            }
            dataGridView_process_table.DataSource = dt;
        }

        private DataTable ReadCsvFile(string file)
        {
            DataTable dt = new DataTable();
            using (StreamReader streamReader = new StreamReader(file))
            {
                while (!streamReader.EndOfStream)
                {
                    string text = streamReader.ReadToEnd();
                    string[] rows = text.Split('\n');
                    if (rows.Length > 0)
                    {
                        //Add columns
                        string[] columns = rows[0].Split(';');
                        for (int j = 0; j < columns.Count(); j++)
                        {
                            dt.Columns.Add(columns[j]);
                        }
                        //add rows
                        for (int i = 1; i < rows.Count() - 1; i++)
                        {
                            string[] data = rows[i].Split(';');
                            DataRow dr = dt.NewRow();
                            for (int k = 0; k < data.Count() - 1; k++)
                            {
                                dr[k] = data[k];
                            }
                            dt.
                                Rows.Add(dr);
                        }
                    }
                }
            }
            return dt;
        }

        private void ImportCSV()
        {
            try
            {
                DataTable dtTable = new DataTable();

                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV file|*.csv" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        dtTable = ReadCsvFile(ofd.FileName);
                    }
                }

                foreach (DataRow item in dtTable.Rows)
                {
                    string id = item["id"].ToString();
                    string col1 = item["S/A Name"].ToString();
                    string col2 = item["Process Name"].ToString();
                    string col3 = item["Process Type"].ToString();
                    string col4 = item["Normal Reverse"].ToString();
                    string col5 = item["Margin Reverse"].ToString();
                    string col6 = item["Depth"].ToString();
                    string col7 = item["Margin of Advance"].ToString();
                    string col8 = item["Margin of Delay"].ToString();
                    string col9 = item["Cut Off"].ToString();
                    string col10 = item["Memo"].ToString();
                    string col11 = item["\r"].ToString();
                    string Query = @"UPDATE process_table 
                                    SET sa_name = '" + col1 + "', " +
                                    "process_name ='" + col2 + "', " +
                                    "process_type ='" + col3 + "'," +
                                    "normal_reverse ='" + col4 + "', " +
                                    "margin_reverse ='" + col5 + "', " +
                                    "depth ='" + col6 + "'," +
                                    "margin_of_adv ='" + col7 + "'," +
                                    "margin_of_delay ='" + col8 + "'," +
                                    "cut_off ='" + col9 + "'," +
                                    "memo ='" + col10 + "'" +
                                    "WHERE id ='" + id + "'";
                    conn = new SqlConnection();
                    conn.ConnectionString = Helpers.connectionString;
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                TampilGrid();

                MessageBox.Show("Data Imported Successfully !!!", "ADM WL/C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportCSV()
        {
            if (dataGridView_process_table.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Process Table.csv";
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
                            int columnCount = dataGridView_process_table.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView_process_table.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView_process_table.Columns[i].HeaderText.ToString() + ";";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView_process_table.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView_process_table.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "ADM WL/C");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "ADM WL/C");
            }
        }

        private void btn_prev_process_table_Click(object sender, EventArgs e)
        {
            if (comboBox_cclink_no_process_table.SelectedIndex > 0)
                comboBox_cclink_no_process_table.SelectedIndex = comboBox_cclink_no_process_table.SelectedIndex - 1;
        }

        private void btn_next_process_table_Click(object sender, EventArgs e)
        {
            if (comboBox_cclink_no_process_table.SelectedIndex != comboBox_cclink_no_process_table.Items.Count - 1)
                comboBox_cclink_no_process_table.SelectedIndex = comboBox_cclink_no_process_table.SelectedIndex + 1;
        }

        private void btn_submit_process_table_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Register OK?", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                WriteProcessTableDataAsync();
            }
        }

        private void comboBox_cclink_no_process_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilGrid();
        }

        private void btn_import_process_table_Click(object sender, EventArgs e)
        {
            ImportCSV();
        }

        private void btn_export_process_table_Click(object sender, EventArgs e)
        {
            TampilAll();
            ExportCSV();
            TampilGrid();
        }

        private void dataGridView_process_table_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView_process_table.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }

        private void btn_refreh_process_table_Click(object sender, EventArgs e)
        {
            //while (dataGridView_process_table.Rows.Count > 0)
            //{
            //    dataGridView_process_table.Rows.Remove(dataGridView_process_table.Rows[0]);
            //}
            //dataGridView_process_table.Refresh();
            //TampilGrid();
            GetProcessTableDataAsync();
        }

        private void dataGridView_process_table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                int id = Convert.ToInt32(dataGridView_process_table.Rows[e.RowIndex].Cells[1].Value.ToString());
                string sa_name = dataGridView_process_table.Rows[e.RowIndex].Cells[2].Value.ToString();
                string process_name = dataGridView_process_table.Rows[e.RowIndex].Cells[3].Value.ToString();
                string process_type = dataGridView_process_table.Rows[e.RowIndex].Cells[4].Value.ToString();
                string normal_reverse = dataGridView_process_table.Rows[e.RowIndex].Cells[5].Value.ToString();
                string margin_reverse = dataGridView_process_table.Rows[e.RowIndex].Cells[6].Value.ToString();
                string depth = dataGridView_process_table.Rows[e.RowIndex].Cells[7].Value.ToString();
                string margin_of_adv = dataGridView_process_table.Rows[e.RowIndex].Cells[8].Value.ToString();
                string margin_of_delay = dataGridView_process_table.Rows[e.RowIndex].Cells[9].Value.ToString();
                string cut_off = dataGridView_process_table.Rows[e.RowIndex].Cells[10].Value.ToString();
                string memo = dataGridView_process_table.Rows[e.RowIndex].Cells[11].Value.ToString();
                string Query = @"UPDATE process_table
                                    SET sa_name = '" + sa_name + "', " +
                                   "process_name ='" + process_name + "', " +
                                   "process_type ='" + process_type + "'," +
                                   "normal_reverse ='" + normal_reverse + "', " +
                                   "margin_reverse ='" + margin_reverse + "', " +
                                   "depth ='" + depth + "'," +
                                   "margin_of_adv ='" + margin_of_adv + "'," +
                                   "margin_of_delay ='" + margin_of_delay + "'," +
                                   "cut_off ='" + cut_off + "'," +
                                   "memo ='" + memo + "'" +
                                   "WHERE id ='" + id + "'";
                conn = new SqlConnection();
                conn.ConnectionString = Helpers.connectionString;
                SqlCommand cmd = new SqlCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message, "ADM WL/C");
            }*/
        }
    }
}
