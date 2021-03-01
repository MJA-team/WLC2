using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADM_WLC
{
    public partial class OrganizeData : Form
    {
        public OrganizeData()
        {
            InitializeComponent();
        }



        private void OrganizeData_Load(object sender, EventArgs e)
        {
            datePicker_startdate_organizedata.Value = System.DateTime.Now;
            datePicker_enddate_organizedata.Value = System.DateTime.Now;
            dataGridView_organizedata.EnableHeadersVisualStyles = false;
            dataGridView_organizedata.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
        }
    }
}
