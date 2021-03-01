using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADM_WLC.Models
{
    public class ConvResultTableData
    {
        public short Id { get; set; }
        public string pid { get; set; }
        public string vin { get; set; }
        public string wlc_code { get; set; }
        public string model_code { get; set; }
        public string suffix { get; set; }
        public string chassis_number { get; set; }     
        public List<JobCode> jobCode { get; set; }
    }
    public class JobCode
    {
        public short B1 { get; set; }
        public short B2 { get; set; }
    }
}
