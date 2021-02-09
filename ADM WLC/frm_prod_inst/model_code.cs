using System;
using System.Windows.Forms;

namespace ADM_WLC.prod_inst
{
    public partial class model_code : Form
    {
        public model_code()
        {
            InitializeComponent();
        }

        private void btn_cancel_model_code_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_model_code_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Register OK?", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

            }
        }

        private void model_code_Load(object sender, EventArgs e)
        {

        }
    }
}
