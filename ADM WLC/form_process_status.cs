using DGVPrinterHelper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using ADM_WLC.SQLHelpers;

namespace ADM_WLC
{
    public partial class form_process_status : Form
    {
        DataTable dt;

        public form_process_status()
        {
            InitializeComponent();
        }



        private void btn_close_proccess_status_Click(object sender, EventArgs e)
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

        private void form_process_status_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;

            comboBox_cclink_no.SelectedIndex = 0;
            dataGridView_process_status.EnableHeadersVisualStyles = false;
            dataGridView_process_status.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;

        }

        private void TampilGrid()
        {
            try
            {
                if (comboBox_cclink_no.SelectedIndex == 0)
                {
                    string Query = @"SELECT *FROM process_status WHERE cc_link_no = '1'";

                    dt = new DataTable();
                    dt = Helpers.GetDatatable(Query);
                    dataGridView_process_status.DataSource = dt;
                }
                else if (comboBox_cclink_no.SelectedIndex == 1)
                {
                    string Query = @"SELECT *FROM process_status WHERE cc_link_no = '2'";

                    dt = new DataTable();
                    dt = Helpers.GetDatatable(Query);
                    dataGridView_process_status.DataSource = dt;
                }
                else if (comboBox_cclink_no.SelectedIndex == 2)
                {
                    string Query = @"SELECT *FROM process_status WHERE cc_link_no = '3'";

                    dt = new DataTable();
                    dt = Helpers.GetDatatable(Query);
                    dataGridView_process_status.DataSource = dt;
                }
                else if (comboBox_cclink_no.SelectedIndex == 3)
                {
                    string Query = @"SELECT *FROM process_status WHERE cc_link_no = '4'";

                    dt = new DataTable();
                    dt = Helpers.GetDatatable(Query);
                    dataGridView_process_status.DataSource = dt;
                }

                //Enable and Disable Button Next
                if (comboBox_cclink_no.SelectedIndex == 3)
                {
                    btn_next_process_status.Enabled = false;
                }
                else btn_next_process_status.Enabled = true;

                //Enable and Disable Button Prev
                if (comboBox_cclink_no.SelectedIndex == 0)
                {
                    btn_prev_process_status.Enabled = false;
                }
                else btn_prev_process_status.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_prev_process_status_Click(object sender, EventArgs e)
        {
            if (comboBox_cclink_no.SelectedIndex > 0)
                comboBox_cclink_no.SelectedIndex = comboBox_cclink_no.SelectedIndex - 1;
        }

        private void btn_next_process_status_Click(object sender, EventArgs e)
        {
            if (comboBox_cclink_no.SelectedIndex != comboBox_cclink_no.Items.Count - 1)
                comboBox_cclink_no.SelectedIndex = comboBox_cclink_no.SelectedIndex + 1;
        }

        private void btn_hardcopy_process_status_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Process Status Monitor";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("yyyy/MM/dd"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.Footer = "";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_process_status);
        }

        /*private void dataGridView_process_status_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int left = 5;
            int right = 7;
            DataGridViewColumn colleft =
                dataGridView_process_status.Columns[left];
            DataGridViewColumn colright =
                dataGridView_process_status.Columns[right];
            colleft.DividerWidth = 8;
            colright.DividerWidth = 8;
        }*/

        private void comboBox_cclink_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilGrid();
        }

        private void dataGridView_process_status_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
