using ADM_WLC.SQLHelpers;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ADM_WLC.prod_inst
{
    public partial class model_code : Form
    {
        private SQLiteConnection conn;
        private SQLiteDataReader dr;

        public model_code()
        {
            InitializeComponent();
        }

        private void ModelCode()
        {
            try
            {
                string Query = @"SELECT DISTINCT model_code FROM prod_inst WHERE model_code IS NOT NULL and model_code != ''";
                conn = new SQLiteConnection();
                conn.ConnectionString = Helpers.connectionString;
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lb_modelcode.Items.Add(dr["model_code"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            ModelCode();
        }
    }
}
