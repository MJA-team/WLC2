using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADM_WLC.conv_result
{
    public partial class form_submit : Form
    {
        string pass;
        private string valid;

        private void Pass()
        {
            pass = (string)tb_password.Text;
            valid = "FFyIPbfu0qhn7+vt6MRbu5otTkWhNcbFqUTnMHPk34E=";

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            byte[] salt = new byte[128 / 8];           
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: pass,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            if (hashed == valid)
            {
                MessageBox.Show("Password OK!!!");
            }
            else
            {
                MessageBox.Show("Wrong Password!!!");
            }
        }

        public form_submit()
        {
            InitializeComponent();
        }


        private void btn_cancel_password_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_password_Click(object sender, EventArgs e)
        {
            Pass();
            this.Close();
        }
    }
}
