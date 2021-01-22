using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADM_WLC.conv_result
{
    public partial class pid_list : Form
    {
        public pid_list()
        {
            InitializeComponent();
        }

        private void btn_cancel_pid_list_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
