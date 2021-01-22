using ADM_WLC.conv_result;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using ADM_WLC.SQLHelpers;
using System.Data.SqlClient;

namespace ADM_WLC
{
    public partial class form_conv_result : Form
    {
        DataTable dt;

        public form_conv_result()
        {
            InitializeComponent();
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

            TampilGrid();
        }

        private void TampilGrid()
        {
            try
            {
                string Query = @"SELECT *FROM conv_result";

                dt = new DataTable();
                dt = Helpers.GetDatatable(Query);
                dataGridView_conv_result.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            pid_list f = new pid_list();
            f.ShowDialog();
        }

        private void btn_zeroofall_conv_result_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Change all Job code to '0'?", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string Query = @"UPDATE conv_result SET b1 = 0, b2 = 0";
                dt = new DataTable();
                dt = Helpers.GetDatatable(Query);
                TampilGrid();
            }
        }

        private void btn_submit_conv_result_Click(object sender, EventArgs e)
        {
            form_submit f = new form_submit();
            f.ShowDialog();
        }

        private void btn_enableedit_conv_result_Click(object sender, EventArgs e)
        {
            form_enable_edit f = new form_enable_edit();
            f.ShowDialog();
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
    }
}
