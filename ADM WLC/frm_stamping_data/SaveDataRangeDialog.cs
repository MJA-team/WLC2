using System;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class SaveDataRangeDialog : Form
    {
        private readonly form_stamping_result _form;

        public SaveDataRangeDialog(form_stamping_result form)
        {
            InitializeComponent();
            _form = form;
        }

        private void textSaveData()
        {
            GetText.dateStart = (string)datePicker_startdate_savedata.Text;
            GetText.dateEnd = (string)datePicker_enddate_savedate.Text;
            GetText.timeStart = (string)timePicker_startdate_savedata.Text;
            GetText.timeEnd = (string)timePicker_enddate_savedata.Text;
        }

        private void SaveDataRangeDialog_Load(object sender, EventArgs e)
        {
            datePicker_startdate_savedata.Value = System.DateTime.Now;
            datePicker_enddate_savedate.Value = System.DateTime.Now;
        }

        private void btn_cancel_savedata_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_savedata_Click(object sender, EventArgs e)
        {
            textSaveData();
            _form.Tampil_Temp();
            _form.ExportCSV();
            _form.TampilAll();
            this.Close();
        }
    }
}
