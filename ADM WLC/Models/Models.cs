using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADM_WLC.Models
{
    public class ProcessTableData
    {
        public int cc_link_no { get; set; }
        public int id { get; set; }
        public int stno { get; set; }
        public string sa_name { get; set; }
        public string process_name { get; set; }
        public int process_type { get; set; }
        public int normal_reverse { get; set; }
        public int margin_reverse { get; set; }
        public int depth { get; set; }
        public int margin_of_adv { get; set; }
        public int margin_of_delay { get; set; }
        public int cut_off { get; set; }
        public string memo { get; set; }
        public string end { get; set; }
    }

}
