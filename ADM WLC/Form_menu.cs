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
    public partial class Form_menu : Form
    {
        
        public Form_menu()
        {
            InitializeComponent();
        }
        
        private void Form_menu_Load(object sender, EventArgs e)
        {
            form_menu_button f0 = new form_menu_button() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            f0.FormBorderStyle = FormBorderStyle.None;
            this.pnl_menu.Controls.Add(f0);
            f0.Show();
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_name_menu.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_data_sending_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Start Sending Data", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                btn_data_sending.Hide();
                btn_data_sending1.Show();
            }
        }

        private void btn_data_sending1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Start Sending Data", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                btn_data_sending.Show();
                btn_data_sending1.Hide();
            }
        }

    }

}
