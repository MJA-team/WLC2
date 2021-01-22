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
    public partial class suspend_data_list : Form
    {
        public suspend_data_list()
        {
            InitializeComponent();
        }

        private void suspend_data_list_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }

        private void btn_cancel_suspend_data_list_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_top_suspend_data_list_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_after_suspend_data_list_Click(object sender, EventArgs e)
        {

        }
    }
}
