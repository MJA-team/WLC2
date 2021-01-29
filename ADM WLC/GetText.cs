using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADM_WLC
{
    class GetText
    {
        static string tb_pid, tb_vin, dtPicker, lb_wlc, tb_model, tb_suffix, tb_chassis, lb_pid_suspend, number;
        public static string pid
        {
            get
            {
                return tb_pid;
            }
            set
            {
                tb_pid = value;
            }
        }
        public static string vin
        {
            get
            {
                return tb_vin;
            }
            set
            {
                tb_vin = value;
            }
        }
        public static string date
        {
            get
            {
                return dtPicker;
            }
            set
            {
                dtPicker = value;
            }
        }
        public static string wlc
        {
            get
            {
                return lb_wlc;
            }
            set
            {
                lb_wlc = value;
            }
        }
        public static string model
        {
            get
            {
                return tb_model;
            }
            set
            {
                tb_model = value;
            }
        }
        public static string suffix
        {
            get
            {
                return tb_suffix;
            }
            set
            {
                tb_suffix = value;
            }
        }
        public static string chassis
        {
            get
            {
                return tb_chassis;
            }
            set
            {
                tb_chassis = value;
            }
        }

        public static string lb_pid
        {
            get
            {
                return lb_pid_suspend;
            }
            set
            {
                lb_pid_suspend = value;
            }
        }

        public static string numb
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
