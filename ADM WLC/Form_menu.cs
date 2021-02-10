using System;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class Form_menu : Form
    {
        private PLCCommunication plc;
        
        public Form_menu()
        {
            InitializeComponent();
            plc = new PLCCommunication();
            plc.ConnectionChanged += plc_ConnectionChanged;
            plc.StatusPLCLogChanged += plc_StatusPLCLogChanged;
            //plc.InitializeConnection();
        }

        private void plc_StatusPLCLogChanged(object sender, StatusPLCLogChangedEventArgs e)
        {
            StatusPLCLog(e.State);
        }

        private void plc_ConnectionChanged(object sender, ConnectionChangedEventArgs e)
        {
            if (e.State == true)
            {
                ButtonSendingStatus(true);
            }
            else ButtonSendingStatus(false);
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
                plc.InitializeConnection();
            }
        }

        private void btn_data_sending1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Start Sending Data", "ADM WL/C", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                plc.PLCClose();
            }
        }

        private void ButtonSendingStatus(bool state)
        {
            if (state == true)
            {
                btn_data_sending.Hide();
                btn_data_sending1.Show();
            }
            else
            {
                btn_data_sending.Show();
                btn_data_sending1.Hide();
            }
        }
        
        private void StatusPLCLog(string textLog)
        {
            var date = DateTime.Now;
            string formatString = String.Format("{0,-30:G}: {1}\n", date, textLog);
            listBox_form_menu.Items.Add(formatString);
        }
    }

}
