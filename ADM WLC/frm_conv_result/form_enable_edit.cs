using System;
using System.Windows.Forms;

namespace ADM_WLC.conv_result
{
    public partial class form_enable_edit : Form
    {
        private readonly form_conv_result _form;
        public form_enable_edit(form_conv_result form)
        {
            InitializeComponent();
            _form = form;
        }

        private void TBox()
        {
            GetText.pedit = tb_password.Text;
        }

        private void btn_cancel_password_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_enable_edit_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_password_Click(object sender, EventArgs e)
        {
            TBox();
            _form.PassEdit();
            this.Close();
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TBox();
                _form.PassEdit();
                this.Close();
            }
        }
    }
}
