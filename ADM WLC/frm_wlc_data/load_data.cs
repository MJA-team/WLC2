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
    public partial class load_data : Form
    {
        private readonly form_wlc_data _form;
        
        public load_data(form_wlc_data form)
        {
            InitializeComponent();
            _form = form;
        }

        private void btn_cancel_load_data_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_headpid_load_data_Click(object sender, EventArgs e)
        {
            load_data_specified f = new load_data_specified(this._form);
            f.tb_head_pid_load_data_specified.Text = tb_head_pid.Text;
            f.tb_last_pid_specified.Text = tb_last_pid.Text;
            f.tb_numb_data_specified.Text = tb_numb_data.Text;
            f.Show();
            this.Close();
        }

        private void btn_loadall_load_data_Click(object sender, EventArgs e)
        {
            _form.SaveAll();
            _form.TampilAll();
            this.Close();
        }

        private void load_data_Load(object sender, EventArgs e)
        {
            tb_head_pid.GotFocus += tb_head_pid_GotFocus;
            tb_last_pid.GotFocus += tb_last_pid_GotFocus;
            tb_numb_data.GotFocus += tb_numb_data_GotFocus;
        }

        private void tb_numb_data_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }

        private void tb_last_pid_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }

        private void tb_head_pid_GotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).Parent.Focus();
        }
    }
}
