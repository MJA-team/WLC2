using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Windows.Forms;

namespace ADM_WLC.conv_result
{
    public partial class form_submit : Form
    {
        private readonly form_conv_result _form;
        public form_submit(form_conv_result form)
        {
            InitializeComponent();
            _form = form;
        }

        private void TBox()
        {
            GetText.psub = tb_password.Text;
        }

        private void btn_cancel_password_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_password_Click(object sender, EventArgs e)
        {
            TBox();
            _form.PassSubmit();
            this.Close();
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TBox();
                _form.PassSubmit();
                this.Close();
            }
        }
    }
}
