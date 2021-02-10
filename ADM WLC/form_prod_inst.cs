using ADM_WLC.prod_inst;
using ADM_WLC.SQLHelpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class form_prod_inst : Form
    {
        DataTable dt;
        SQLiteConnection conn;

        public form_prod_inst()
        {
            InitializeComponent();
        }

        private void form_prod_inst_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            lbl_processbox_prod_inst.Enabled = false;
            comboBox_cclink_no_prod_inst.SelectedIndex = 0;
            comboBox_cclink_no1_prod_inst.SelectedIndex = 0;
            dataGridView_prod_inst.EnableHeadersVisualStyles = false;
            dataGridView_prod_inst.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            //dataGridView_prod_inst.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindData();
        }

        private void TampilGrid()
        {
            Object cc_link = comboBox_cclink_no_prod_inst.SelectedItem;
            try
            {
                string Query = @"SELECT *FROM prod_inst WHERE cc_link_no = '" + cc_link + "'";
                dt = new DataTable();
                dt = Helpers.GetDatatable(Query);
                dataGridView_prod_inst.DataSource = dt;

                //Enable and Disable Button Next
                if (comboBox_cclink_no_prod_inst.SelectedIndex == 3)
                {
                    btn_next_prod_inst.Enabled = false;
                }
                else btn_next_prod_inst.Enabled = true;

                //Enable and Disable Button Prev
                if (comboBox_cclink_no_prod_inst.SelectedIndex == 0)
                {
                    btn_prev_prod_inst.Enabled = false;
                }
                else btn_prev_prod_inst.Enabled = true;

                //dataGridView_prod_inst.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TampilAll()
        {
            try
            {
                string Query = @"SELECT *FROM prod_inst";
                dt = new DataTable();
                dt = Helpers.GetDatatable(Query);
                dataGridView_prod_inst.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindData()
        {
            try
            {
                string Query = @"SELECT DISTINCT model_code FROM prod_inst WHERE model_code IS NOT NULL and model_code != ''";
                conn = new SQLiteConnection();
                conn.ConnectionString = Helpers.connectionString;
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                conn.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_cclink_no1_prod_inst.Items.Add(reader[0].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshBind()
        {
            comboBox_cclink_no1_prod_inst.Items.Clear();
            comboBox_cclink_no1_prod_inst.Items.Add("ALL");
            comboBox_cclink_no1_prod_inst.Text = "ALL";
            TampilGrid();
            BindData();
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
                    string delete = item["Delete"].ToString();
                    string wlc = item["WLC Code"].ToString();
                    string katashiki = item["KATASHIKI"].ToString();
                    string model = item["Model Code"].ToString();
                    string _1b1 = item["1  B1"].ToString();
                    string _1b2 = item["1  B2"].ToString();
                    string _2b1 = item["2  B1"].ToString();
                    string _2b2 = item["2  B2"].ToString();
                    string _3b1 = item["3  B1"].ToString();
                    string _3b2 = item["3  B2"].ToString();
                    string _4b1 = item["4  B1"].ToString();
                    string _4b2 = item["4  B2"].ToString();
                    string _5b1 = item["5  B1"].ToString();
                    string _5b2 = item["5  B2"].ToString();
                    string _6b1 = item["6  B1"].ToString();
                    string _6b2 = item["6  B2"].ToString();
                    string _7b1 = item["7  B1"].ToString();
                    string _7b2 = item["7  B2"].ToString();
                    string _8b1 = item["8  B1"].ToString();
                    string _8b2 = item["8  B2"].ToString();
                    string _9b1 = item["9  B1"].ToString();
                    string _9b2 = item["9  B2"].ToString();
                    string _10b1 = item["10  B1"].ToString();
                    string _10b2 = item["10  B2"].ToString();
                    string _11b1 = item["11  B1"].ToString();
                    string _11b2 = item["11  B2"].ToString();
                    string _12b1 = item["12  B1"].ToString();
                    string _12b2 = item["12  B2"].ToString();
                    string _13b1 = item["13  B1"].ToString();
                    string _13b2 = item["13  B2"].ToString();
                    string _14b1 = item["14  B1"].ToString();
                    string _14b2 = item["14  B2"].ToString();
                    string _15b1 = item["15  B1"].ToString();
                    string _15b2 = item["15  B2"].ToString();
                    string _16b1 = item["16  B1"].ToString();
                    string _16b2 = item["16  B2"].ToString();
                    string _17b1 = item["17  B1"].ToString();
                    string _17b2 = item["17  B2"].ToString();
                    string _18b1 = item["18  B1"].ToString();
                    string _18b2 = item["18  B2"].ToString();
                    string _19b1 = item["19  B1"].ToString();
                    string _19b2 = item["19  B2"].ToString();
                    string _20b1 = item["20  B1"].ToString();
                    string _20b2 = item["20  B2"].ToString();
                    string _21b1 = item["21  B1"].ToString();
                    string _21b2 = item["21  B2"].ToString();
                    string _22b1 = item["22  B1"].ToString();
                    string _22b2 = item["22  B2"].ToString();
                    string _23b1 = item["23  B1"].ToString();
                    string _23b2 = item["23  B2"].ToString();
                    string _24b1 = item["24  B1"].ToString();
                    string _24b2 = item["24  B2"].ToString();
                    string _25b1 = item["25  B1"].ToString();
                    string _25b2 = item["25  B2"].ToString();
                    string _26b1 = item["26  B1"].ToString();
                    string _26b2 = item["26  B2"].ToString();
                    string _27b1 = item["27  B1"].ToString();
                    string _27b2 = item["27  B2"].ToString();
                    string _28b1 = item["28  B1"].ToString();
                    string _28b2 = item["28  B2"].ToString();
                    string _29b1 = item["29  B1"].ToString();
                    string _29b2 = item["29  B2"].ToString();
                    string _30b1 = item["30  B1"].ToString();
                    string _30b2 = item["30  B2"].ToString();
                    string _31b1 = item["\r"].ToString();
                    string Query = @"UPDATE prod_inst 
                            SET del = '" + delete + "', " +
                                    "wlc_code ='" + wlc + "', " +
                                    "katashiki ='" + katashiki + "'," +
                                    "model_code ='" + model + "', " +
                                    "[1_b1] ='" + _1b1 + "', " +
                                    "[1_b2] ='" + _1b2 + "'," +
                                    "[2_b1] ='" + _2b1 + "'," +
                                    "[2_b2] ='" + _2b2 + "'," +
                                    "[3_b1] ='" + _3b1 + "'," +
                                    "[3_b2] ='" + _3b2 + "'," +
                                    "[4_b1] ='" + _4b1 + "'," +
                                    "[4_b2] ='" + _4b2 + "'," +
                                    "[5_b1] ='" + _5b1 + "'," +
                                    "[5_b2] ='" + _5b2 + "'," +
                                    "[6_b1] ='" + _6b1 + "'," +
                                    "[6_b2] ='" + _6b2 + "'," +
                                    "[7_b1] ='" + _7b1 + "'," +
                                    "[7_b2] ='" + _7b2 + "'," +
                                    "[8_b1] ='" + _8b1 + "'," +
                                    "[8_b2] ='" + _8b2 + "'," +
                                    "[9_b1] ='" + _9b1 + "'," +
                                    "[9_b2] ='" + _9b2 + "'," +
                                    "[10_b1] ='" + _10b1 + "'," +
                                    "[10_b2] ='" + _10b2 + "'," +
                                    "[11_b1] ='" + _11b1 + "'," +
                                    "[11_b2] ='" + _11b2 + "'," +
                                    "[12_b1] ='" + _12b1 + "'," +
                                    "[12_b2] ='" + _12b2 + "'," +
                                    "[13_b1] ='" + _13b1 + "'," +
                                    "[13_b2] ='" + _13b2 + "'," +
                                    "[14_b1] ='" + _14b1 + "'," +
                                    "[14_b2] ='" + _14b2 + "'," +
                                    "[15_b1] ='" + _15b1 + "'," +
                                    "[15_b2] ='" + _15b2 + "'," +
                                    "[16_b1] ='" + _16b1 + "'," +
                                    "[16_b2] ='" + _16b2 + "'," +
                                    "[17_b1] ='" + _17b1 + "'," +
                                    "[17_b2] ='" + _17b2 + "'," +
                                    "[18_b1] ='" + _18b1 + "'," +
                                    "[18_b2] ='" + _18b2 + "'," +
                                    "[19_b1] ='" + _19b1 + "'," +
                                    "[19_b2] ='" + _19b2 + "'," +
                                    "[20_b1] ='" + _20b1 + "'," +
                                    "[20_b2] ='" + _20b2 + "'," +
                                    "[21_b1] ='" + _21b1 + "'," +
                                    "[21_b2] ='" + _21b2 + "'," +
                                    "[22_b1] ='" + _22b1 + "'," +
                                    "[22_b2] ='" + _22b2 + "'," +
                                    "[23_b1] ='" + _23b1 + "'," +
                                    "[23_b2] ='" + _23b2 + "'," +
                                    "[24_b1] ='" + _24b1 + "'," +
                                    "[24_b2] ='" + _24b2 + "'," +
                                    "[25_b1] ='" + _25b1 + "'," +
                                    "[25_b2] ='" + _25b2 + "'," +
                                    "[26_b1] ='" + _26b1 + "'," +
                                    "[26_b2] ='" + _26b2 + "'," +
                                    "[27_b1] ='" + _27b1 + "'," +
                                    "[27_b2] ='" + _27b2 + "'," +
                                    "[28_b1] ='" + _28b1 + "'," +
                                    "[28_b2] ='" + _28b2 + "'," +
                                    "[29_b1] ='" + _29b1 + "'," +
                                    "[29_b2] ='" + _29b2 + "'," +
                                    "[30_b1] ='" + _30b1 + "'," +
                                    "[30_b2] ='" + _30b2 + "'" +
                                    "WHERE id ='" + id + "'";
                    conn = new SQLiteConnection();
                    conn.ConnectionString = Helpers.connectionString;
                    SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                RefreshBind();
                MessageBox.Show("Data Imported Successfully !!!", "ADM WL/C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportCSV()
        {
            if (dataGridView_prod_inst.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Production Instruction Code.csv";
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
                            int columnCount = dataGridView_prod_inst.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView_prod_inst.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView_prod_inst.Columns[i].HeaderText.ToString() + ";";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView_prod_inst.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView_prod_inst.Rows[i - 1].Cells[j].Value.ToString() + ";";
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

        private void DeleteGrid()
        {
            string id = string.Empty;
            if (dataGridView_prod_inst.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dataGridView_prod_inst.SelectedRows[0];
                id = selectedrow.Cells[1].Value.ToString();
            }
            if (id == "")
            {
                return; //Keluar dari perintah delete
            }

            DialogResult dialogResult = MessageBox.Show("Delete Data?", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow oneRow in dataGridView_prod_inst.SelectedRows)
                {
                    if (oneRow.Selected)
                    {
                        string delete = "";
                        string wlc = "";
                        string katashiki = "";
                        string model = "";
                        string _1b1 = "";
                        string _1b2 = "";
                        string _2b1 = "";
                        string _2b2 = "";
                        string _3b1 = "";
                        string _3b2 = "";
                        string _4b1 = "";
                        string _4b2 = "";
                        string _5b1 = "";
                        string _5b2 = "";
                        string _6b1 = "";
                        string _6b2 = "";
                        string _7b1 = "";
                        string _7b2 = "";
                        string _8b1 = "";
                        string _8b2 = "";
                        string _9b1 = "";
                        string _9b2 = "";
                        string _10b1 = "";
                        string _10b2 = "";
                        string _11b1 = "";
                        string _11b2 = "";
                        string _12b1 = "";
                        string _12b2 = "";
                        string Query = @"UPDATE prod_inst 
                                   SET del = '" + delete + "', " +
                                   "wlc_code ='" + wlc + "', " +
                                   "katashiki ='" + katashiki + "'," +
                                   "model_code ='" + model + "', " +
                                   "[1_b1] ='" + _1b1 + "', " +
                                   "[1_b2] ='" + _1b2 + "'," +
                                   "[2_b1] ='" + _2b1 + "'," +
                                   "[2_b2] ='" + _2b2 + "'," +
                                   "[3_b1] ='" + _3b1 + "'," +
                                   "[3_b2] ='" + _3b2 + "'," +
                                   "[4_b1] ='" + _4b1 + "'," +
                                   "[4_b2] ='" + _4b2 + "'," +
                                   "[5_b1] ='" + _5b1 + "'," +
                                   "[5_b2] ='" + _5b2 + "'," +
                                   "[6_b1] ='" + _6b1 + "'," +
                                   "[6_b2] ='" + _6b2 + "'," +
                                   "[7_b1] ='" + _7b1 + "'," +
                                   "[7_b2] ='" + _7b2 + "'," +
                                   "[8_b1] ='" + _8b1 + "'," +
                                   "[8_b2] ='" + _8b2 + "'," +
                                   "[9_b1] ='" + _9b1 + "'," +
                                   "[9_b2] ='" + _9b2 + "'," +
                                   "[10_b1] ='" + _10b1 + "'," +
                                   "[10_b2] ='" + _10b2 + "'," +
                                   "[11_b1] ='" + _11b1 + "'," +
                                   "[11_b2] ='" + _11b2 + "'," +
                                   "[12_b1] ='" + _12b1 + "'," +
                                   "[12_b2] ='" + _12b2 + "'" +
                                   "WHERE id ='" + id + "'";
                        conn = new SQLiteConnection();
                        conn.ConnectionString = Helpers.connectionString;
                        SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    RefreshBind();
                    MessageBox.Show("Data Deleted Successfully !!!", "ADM WL/C");
                }
            }
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

        private void btn_close_prod_inst_Click(object sender, EventArgs e)
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

        private void dataGridView_prod_inst_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView_prod_inst.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }

        private void btn_prev_prod_inst_Click(object sender, EventArgs e)
        {
            if (comboBox_cclink_no_prod_inst.SelectedIndex > 0)
                comboBox_cclink_no_prod_inst.SelectedIndex = comboBox_cclink_no_prod_inst.SelectedIndex - 1;
            comboBox_cclink_no1_prod_inst.Text = "ALL";
        }

        private void btn_next_prod_inst_Click(object sender, EventArgs e)
        {
            if (comboBox_cclink_no_prod_inst.SelectedIndex != comboBox_cclink_no_prod_inst.Items.Count - 1)
                comboBox_cclink_no_prod_inst.SelectedIndex = comboBox_cclink_no_prod_inst.SelectedIndex + 1;
            comboBox_cclink_no1_prod_inst.Text = "ALL";
        }

        private void btn_modelcode_prod_inst_Click(object sender, EventArgs e)
        {
            model_code f = new model_code();
            f.ShowDialog();
        }

        private void btn_import_prod_inst_Click(object sender, EventArgs e)
        {
            ImportCSV();
        }

        private void btn_export_prod_inst_Click(object sender, EventArgs e)
        {
            TampilAll();
            ExportCSV();
            TampilGrid();
        }

        private void comboBox_cclink_no_prod_inst_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilGrid();
            comboBox_cclink_no1_prod_inst.Text = "ALL";
        }

        private void btn_submit_prod_inst_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_prod_inst_Click(object sender, EventArgs e)
        {
            DeleteGrid();
        }

        private void btn_refreh_prod_inst_Click(object sender, EventArgs e)
        {
            while (dataGridView_prod_inst.Rows.Count > 0)
            {
                dataGridView_prod_inst.Rows.Remove(dataGridView_prod_inst.Rows[0]);
            }
            RefreshBind();
        }

        private void comboBox_cclink_no1_prod_inst_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object mod = comboBox_cclink_no1_prod_inst.SelectedItem;
            Object cc_link = comboBox_cclink_no_prod_inst.SelectedItem;
            if (comboBox_cclink_no1_prod_inst.SelectedIndex == 0)
            {
                TampilGrid();
            }
            else if (comboBox_cclink_no1_prod_inst.SelectedItem == mod)
            {
                string Query = @"SELECT *FROM prod_inst WHERE model_code = '" + mod + "' AND  cc_link_no = '" + cc_link +"'";
                dt = new DataTable();
                dt = Helpers.GetDatatable(Query);
                dataGridView_prod_inst.DataSource = dt;
            }   
        }

        private void dataGridView_prod_inst_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                int id = Convert.ToInt32(dataGridView_prod_inst.Rows[e.RowIndex].Cells[1].Value.ToString());
                string delete = dataGridView_prod_inst.Rows[e.RowIndex].Cells[2].Value.ToString();
                string wlc = dataGridView_prod_inst.Rows[e.RowIndex].Cells[3].Value.ToString();
                string katashiki = dataGridView_prod_inst.Rows[e.RowIndex].Cells[4].Value.ToString();
                string model = dataGridView_prod_inst.Rows[e.RowIndex].Cells[5].Value.ToString();
                string _1b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[6].Value.ToString();
                string _1b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[7].Value.ToString();
                string _2b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[8].Value.ToString();
                string _2b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[9].Value.ToString();
                string _3b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[10].Value.ToString();
                string _3b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[11].Value.ToString();
                string _4b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[12].Value.ToString();
                string _4b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[13].Value.ToString();
                string _5b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[14].Value.ToString();
                string _5b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[15].Value.ToString();
                string _6b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[16].Value.ToString();
                string _6b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[17].Value.ToString();
                string _7b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[18].Value.ToString();
                string _7b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[19].Value.ToString();
                string _8b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[20].Value.ToString();
                string _8b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[21].Value.ToString();
                string _9b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[22].Value.ToString();
                string _9b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[23].Value.ToString();
                string _10b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[24].Value.ToString();
                string _10b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[25].Value.ToString();
                string _11b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[26].Value.ToString();
                string _11b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[27].Value.ToString();
                string _12b1 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[28].Value.ToString();
                string _12b2 = dataGridView_prod_inst.Rows[e.RowIndex].Cells[29].Value.ToString();
                string Query = @"UPDATE prod_inst 
                                    SET del = '" + delete + "', " +
                                   "wlc_code ='" + wlc + "', " +
                                   "katashiki ='" + katashiki + "'," +
                                   "model_code ='" + model + "', " +
                                   "[1_b1] ='" + _1b1 + "', " +
                                   "[1_b2] ='" + _1b2 + "'," +
                                   "[2_b1] ='" + _2b1 + "'," +
                                   "[2_b2] ='" + _2b2 + "'," +
                                   "[3_b1] ='" + _3b1 + "'," +
                                   "[3_b2] ='" + _3b2 + "'," +
                                   "[4_b1] ='" + _4b1 + "'," +
                                   "[4_b2] ='" + _4b2 + "'," +
                                   "[5_b1] ='" + _5b1 + "'," +
                                   "[5_b2] ='" + _5b2 + "'," +
                                   "[6_b1] ='" + _6b1 + "'," +
                                   "[6_b2] ='" + _6b2 + "'," +
                                   "[7_b1] ='" + _7b1 + "'," +
                                   "[7_b2] ='" + _7b2 + "'," +
                                   "[8_b1] ='" + _8b1 + "'," +
                                   "[8_b2] ='" + _8b2 + "'," +
                                   "[9_b1] ='" + _9b1 + "'," +
                                   "[9_b2] ='" + _9b2 + "'," +
                                   "[10_b1] ='" + _10b1 + "'," +
                                   "[10_b2] ='" + _10b2 + "'," +
                                   "[11_b1] ='" + _11b1 + "'," +
                                   "[11_b2] ='" + _11b2 + "'," +
                                   "[12_b1] ='" + _12b1 + "'," +
                                   "[12_b2] ='" + _12b2 + "'" +
                                   "WHERE id ='" + id + "'";
                conn = new SQLiteConnection();
                conn.ConnectionString = Helpers.connectionString;
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                comboBox_cclink_no1_prod_inst.Items.Clear();
                comboBox_cclink_no1_prod_inst.Items.Add("ALL");
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message, "ADM WL/C");
            }*/
        }
    }
}

