using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class form_stamping_result : Form
    {
        public form_stamping_result()
        {
            InitializeComponent();
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

       
        private void dateTimePicker_start_stamping_result_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_start_stamping_result.Format = DateTimePickerFormat.Custom;
            dateTimePicker_start_stamping_result.CustomFormat = "HH:mm";
        }

        private void dateTimePicker_end_stamping_result_ValueChanged(object sender, EventArgs e)
        {
            //TimePicker
            dateTimePicker_end_stamping_result.Format = DateTimePickerFormat.Custom;
            dateTimePicker_end_stamping_result.CustomFormat = "HH:mm";
        }

        private void dataGridView_stamping_result_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView_stamping_result.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
