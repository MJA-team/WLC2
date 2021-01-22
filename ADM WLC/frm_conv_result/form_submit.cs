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
    public partial class form_submit : Form
    {
        public form_submit()
        {
            InitializeComponent();
        }

        private void btn_cancel_password_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
