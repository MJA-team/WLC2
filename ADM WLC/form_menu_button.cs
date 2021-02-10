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
    public partial class form_menu_button : Form
    {
        public form_menu_button()
        {
            InitializeComponent();
        }

        private void form_menu_button_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }

        private void btn_process_status_Click(object sender, EventArgs e)
        {
            ((Form_menu)Application.OpenForms["Form_menu"]).lbl_name_menu.Text = "Process Status Monitor";
            Panel p = this.Parent as Panel;
            if (p != null)
            {
                form_process_status f1 = new form_process_status() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f1.FormBorderStyle = FormBorderStyle.None;
                p.Controls.Add(f1);
                f1.Show();
                this.Close();
            }

        }

        private void btn_wlc_maintenance_Click(object sender, EventArgs e)
        {
            ((Form_menu)Application.OpenForms["Form_menu"]).lbl_name_menu.Text = "WLC Data Maintenance";
            Panel p = this.Parent as Panel;
            if (p != null)
            {
                form_wlc_data f2 = new form_wlc_data() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f2.FormBorderStyle = FormBorderStyle.None;
                p.Controls.Add(f2);
                f2.Show();
                this.Close();
            }
        }

        private void btn_conv_result_Click(object sender, EventArgs e)
        {
            ((Form_menu)Application.OpenForms["Form_menu"]).lbl_name_menu.Text = "Conversion Result Data Maintenance";
            Panel p = this.Parent as Panel;
            if (p != null)
            {
                form_conv_result f3 = new form_conv_result() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f3.FormBorderStyle = FormBorderStyle.None;
                p.Controls.Add(f3);
                f3.Show();
                this.Close();
            }
        }

        private void btn_prod_inst_Click(object sender, EventArgs e)
        {
            ((Form_menu)Application.OpenForms["Form_menu"]).lbl_name_menu.Text = "[Master Setting] Production Instruction Code";
            Panel p = this.Parent as Panel;
            if (p != null)
            {
                form_prod_inst f4 = new form_prod_inst() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f4.FormBorderStyle = FormBorderStyle.None;
                p.Controls.Add(f4);
                f4.Show();
                this.Close();
            }
        }

        private void btn_process_table_Click(object sender, EventArgs e)
        {
            ((Form_menu)Application.OpenForms["Form_menu"]).lbl_name_menu.Text = "[Master Setting] Process Table";
            Panel p = this.Parent as Panel;
            if (p != null)
            {
                form_process_table f5 = new form_process_table() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f5.FormBorderStyle = FormBorderStyle.None;
                p.Controls.Add(f5);
                f5.Show();
                this.Close();
            }
        }

        private void btn_stamping_result_Click(object sender, EventArgs e)
        {
            ((Form_menu)Application.OpenForms["Form_menu"]).lbl_name_menu.Text = "Stamping Result Data Maintenance";
            Panel p = this.Parent as Panel;
            if (p != null)
            {
                form_stamping_result f6 = new form_stamping_result() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                f6.FormBorderStyle = FormBorderStyle.None;
                p.Controls.Add(f6);
                f6.Show();
                this.Close();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            btn_stamping_result.Visible = false;
        }
    }
}
