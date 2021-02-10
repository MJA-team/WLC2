using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADM_WLC.Models;

namespace ADM_WLC
{
    public class PLCCommunication
    {
        #region **** properties
        private static ActUtlTypeLib.ActUtlType plc = new ActUtlTypeLib.ActUtlType();

        private static SQLHelpers.WLCDataDB wlcDB = new SQLHelpers.WLCDataDB();

        private static int _plcConnectionStatus;

        private static bool _connected;
        public bool Connected
        {
            get
            {
                return _connected;
            }
            private set
            {
                _connected = value;
                ConnectionChangedEventArgs args = new ConnectionChangedEventArgs();
                args.State = _connected;
                OnConnectionChanged(args);
            }
        }

        private static string _statusPLCLog;
        public string StatusPLCLog
        {
            get
            {
                return _statusPLCLog;
            }
            private set
            {
                _statusPLCLog = value;
                StatusPLCLogChangedEventArgs args = new StatusPLCLogChangedEventArgs();
                args.State = _statusPLCLog;
                OnStatusPLCLogChanged(args);
            }
        }

        #endregion

        #region **** constructor
        public PLCCommunication()
        {
            //this.Connected = false;

        }
        #endregion

        #region **** method

        public void InitializeConnection()
        {
            PLCOpen();
            plc.OnDeviceStatus += new ActUtlTypeLib._IActUtlTypeEvents_OnDeviceStatusEventHandler(ActUtlType_OnDeviceStatus);
            EntryDeviceStatus();
        }

        private bool GetLogicalStationNumber(out int iGottenIntValue)
        {
            iGottenIntValue = 0;
            //Get the value as 32bit integer from a TextBox
            try
            {
                iGottenIntValue = Convert.ToInt32(Properties.Settings.Default.LogicalStationNumber);
            }

            //Exception processing
            catch (Exception exExcepion)
            {
                MessageBox.Show(exExcepion.Message,
                                  "GetLogicalStationNumber Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Normal End
            return true;
        }

        private void ActUtlType_OnDeviceStatus(String szDevice, int iData, int iReturnCode)
        {
            if (iReturnCode == 0)
            {
                if (szDevice == "M1001")
                {
                    if (iData == 0)
                    {
                        SetDataSendingBit(false);
                    }
                    if (iData == 1)
                    {
                        //Siapkan data yang mau dikirim
                        string pid = "";
                        string vin = "";
                        string suffix = "";
                        string model_code = "";
                        string wlc_code = "";
                        string chassis_number = "";

                        DataTable dta = new DataTable();
                        dta = wlcDB.GetFirstWLCDataPlan();
                        if (dta.Rows.Count > 0)
                        {
                            foreach (DataRow row in dta.Rows)
                            {
                                //pid,vin,suffix,model_code,wlc_code,chassis_number
                                pid = row["pid"].ToString();
                                vin = row["vin"].ToString();
                                suffix = row["suffix"].ToString();
                                model_code = row["model_code"].ToString();
                                wlc_code = row["wlc_code"].ToString();
                                chassis_number = row["chassis_number"].ToString();
                            }
                            if (SetPLCWLCData(pid, vin, suffix, model_code, wlc_code, chassis_number))
                            {
                                SetDataSendingBit(true);
                                wlcDB.SetWLCDataSent(pid);
                            }
                        }
                        //SetDataSendingBit(false);
                    }
                }
                if (szDevice == "M1002")
                {
                    if (iData == 1)
                    {
                        SetDataSendingBit(false);
                        ResetPLCWLCData();
                    }
                }
            }

            //string stringFormat = string.Format("{0}:{1}:{2:x8}\n", szDevice, iData, iReturnCode);
            //StatusPLCLog(stringFormat);
        }

        public void PLCOpen()
        {
            int iReturnCode;                //Return code
                                            //LogicalStationNumber for ActUtlType

            //
            //Processing of Open method
            //
            try
            {
                //Form_menu.StatusPLCLog("Open PLC Connection");
                StatusPLCLog = "Open PLC Connection";
                //Check the 'LogicalStationNumber'.(If succeeded, the value is gotten.)
                if (GetLogicalStationNumber(out int iLogicalStationNumber) != true)
                {
                    //If failed, this process is end.				
                    return;
                }

                //Set the value of 'LogicalStationNumber' to the property.
                plc.ActLogicalStationNumber = iLogicalStationNumber;

                //Set the value of 'Password'.
                //plc.ActPassword = txt_Password.Text;

                //The Open method is executed.
                iReturnCode = plc.Open();

                //When the Open method is succeeded, set the connected status.
                if (iReturnCode == 0)
                {
                    Connected = true;
                    //Form_menu.StatusPLCLog("Open PLC Connection Succeed");
                    StatusPLCLog = "Open PLC Connection Succeed";
                    //ButtonSendingStatus(true);
                }
                else
                {
                    Connected = false;
                    //Form_menu.StatusPLCLog("Open PLC Connection Failed");
                    StatusPLCLog = "Open PLC Connection Failed";
                    //ButtonSendingStatus(false);
                }
                _plcConnectionStatus = iReturnCode;
            }
            //Exception processing
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                //MessageBox.Show(exception.Message,
                //                  "Open Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void PLCClose()
        {
            int iReturnCode;	//Return code

            //
            //Processing of Close method
            //
            try
            {
                //Form_menu.StatusPLCLog("Close PLC Connection");
                StatusPLCLog = "Close PLC Connection";
                //The Close method is executed.
                iReturnCode = plc.Close();
            }

            //Exception processing
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return;
            }
            Connected = false;
            //ButtonSendingStatus(false);


            //The return code of the method is displayed by the hexadecimal.
            //txt_ReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode);
        }

        private void EntryDeviceStatus()
        {
            int iReturnCode;				//Return code
            String szDeviceName = "M1001\nM1001\nM1002";		//List data for 'DeviceName'
            int iNumberOfData = 3;			//Data for 'DeviceSize'
            int iMonitorCycle = 1;			//Data for 'MonitorCycle'
            int[] arrDeviceValue;		    //Data for 'DeviceValue'

            //Check the 'DeviceValue'.(If succeeded, the value is gotten.)
            arrDeviceValue = new int[iNumberOfData];
            arrDeviceValue[0] = 1;
            arrDeviceValue[1] = 0;
            arrDeviceValue[2] = 1;

            //
            //Processing of EntryDeviceStatus method
            //
            try
            {
                ///The EntryDeviceStatus method is executed.
                iReturnCode = plc.EntryDeviceStatus(szDeviceName,
                                                                iNumberOfData,
                                                                iMonitorCycle,
                                                                ref arrDeviceValue[0]);
            }
            //Exception processing			
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return;
            }

            //The return code of the method is displayed by the hexadecimal.
            //txt_ReturnCode.Text = String.Format("0x{0:x8} [HEX]", iReturnCode);
            string stringFormat = string.Format("{0}:{1:x8}:{2}\n", "EntryDeviceStatus", iReturnCode, "");
            //Form_menu.StatusPLCLog(stringFormat);
            StatusPLCLog = stringFormat;
        }

        private void SetDataSendingBit(bool condition)
        {
            int iReturnCode;				//Return code
            String szDeviceName = "M1000";		//List data for 'DeviceName'
            int iNumberOfData = 1;			//Data for 'DeviceSize'
            short[] arrDeviceValue;		    //Data for 'DeviceValue'

            //Assign the array for 'DeviceValue'.
            arrDeviceValue = new short[iNumberOfData];
            if (condition == true)
            {
                arrDeviceValue[0] = 1;
            }
            else
            {
                arrDeviceValue[0] = 0;
            }

            try
            {
                //The WriteDeviceRandom2 method is executed.
                iReturnCode = plc.WriteDeviceRandom2(szDeviceName,
                                                              iNumberOfData,
                                                              ref arrDeviceValue[0]);
            }
            //Exception processing
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return;
            }
        }

        private bool SetPLCWLCData(string pid, string vin, string suffix, string modelcode, string plccode, string chassis)
        {
            int iReturnCode;				//Return code
            String szDeviceName = "ZR1101";		//List data for 'DeviceName'
            int iNumberOfData = 29;			//Data for 'DeviceSize'
            short[] arrDeviceValue;		    //Data for 'DeviceValue'
            char[] chpid = new char[10];
            char[] chvin = new char[18];
            char[] chsuffix = new char[2];
            char[] chmodelcode = new char[4];
            char[] chplccode = new char[4];
            char[] chchassis = new char[20];

            chpid = pid.ToCharArray();
            chvin = vin.ToCharArray();
            chsuffix = suffix.ToCharArray();
            chmodelcode = modelcode.ToCharArray();
            chplccode = plccode.ToCharArray();
            chchassis = chassis.ToCharArray();

            //var listch = chpid.ToList();
            //listch.Add(chvin.ToList());

            //Char[] cr = chpid + chvin + chsuffix + chmodelcode + chplccode + chchassis;
            //Char[] cr = str.ToCharArray(); //Kumpulkan data dalam bentuk byte array

            //Assign the array for 'DeviceValue'.
            arrDeviceValue = new short[iNumberOfData];

            int k = 0;
            //int l = cr.Length;
            byte[] byt = new byte[58];
            foreach (var ea in chpid)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chvin)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chsuffix)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chmodelcode)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chplccode)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chchassis)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }

            var a = 0;
            var b = 0;
            while (a < byt.Count())
            {
                //var txt = "ZR" + j;
                Int16 value = byt[a + 1];
                value <<= 8;
                value += Convert.ToInt16(byt[a]);
                //plc.WriteDeviceBlock(txt, 1, Convert.ToInt32(value));
                //nilai[k] = ;
                arrDeviceValue[b] = value;
                a += 2;
                b += 1;
                //j++;
            }

            try
            {
                //The WriteDeviceRandom2 method is executed.
                iReturnCode = plc.WriteDeviceBlock2(szDeviceName,
                                                              iNumberOfData,
                                                              ref arrDeviceValue[0]);
            }
            //Exception processing
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                string stringFormat = "Send WLC Data; PID = " + pid + " Failed";
                StatusPLCLog = stringFormat;
                return false;
            }
            if (iReturnCode == 0)
            {
                string stringFormat = "Send WLC Data; PID = " + pid + " Success";
                StatusPLCLog = stringFormat;
                return true;
            }
            else return false;
        }

        private bool ResetPLCWLCData()
        {
            int iReturnCode;				//Return code
            String szDeviceName = "ZR1001";		//List data for 'DeviceName'
            int iNumberOfData = 29;			//Data for 'DeviceSize'
            short[] arrDeviceValue;		    //Data for 'DeviceValue'
            char[] chpid = new char[10];
            char[] chvin = new char[18];
            char[] chsuffix = new char[2];
            char[] chmodelcode = new char[4];
            char[] chplccode = new char[4];
            char[] chchassis = new char[20];

            //chpid = pid.ToCharArray();
            //chvin = vin.ToCharArray();
            //chsuffix = suffix.ToCharArray();
            //chmodelcode = modelcode.ToCharArray();
            //chplccode = plccode.ToCharArray();
            //chchassis = chassis.ToCharArray();

            //var listch = chpid.ToList();
            //listch.Add(chvin.ToList());

            //Char[] cr = chpid + chvin + chsuffix + chmodelcode + chplccode + chchassis;
            //Char[] cr = str.ToCharArray(); //Kumpulkan data dalam bentuk byte array

            //Assign the array for 'DeviceValue'.
            arrDeviceValue = new short[iNumberOfData];

            int k = 0;
            //int l = cr.Length;
            byte[] byt = new byte[58];
            foreach (var ea in chpid)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chvin)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chsuffix)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chmodelcode)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chplccode)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }
            foreach (var ea in chchassis)
            {
                byt[k] = Convert.ToByte(ea);
                k++;
            }

            var a = 0;
            var b = 0;
            while (a < byt.Count())
            {
                //var txt = "ZR" + j;
                Int16 value = byt[a + 1];
                value <<= 8;
                value += Convert.ToInt16(byt[a]);
                //plc.WriteDeviceBlock(txt, 1, Convert.ToInt32(value));
                //nilai[k] = ;
                arrDeviceValue[b] = value;
                a += 2;
                b += 1;
                //j++;
            }

            try
            {
                //The WriteDeviceRandom2 method is executed.
                iReturnCode = plc.WriteDeviceBlock2(szDeviceName,
                                                              iNumberOfData,
                                                              ref arrDeviceValue[0]);
            }
            //Exception processing
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                string stringFormat = "Reset WLC Data Failed";
                StatusPLCLog = stringFormat;
                return false;
            }
            if (iReturnCode == 0)
            {
                string stringFormat = "Reset WLC Data Success";
                StatusPLCLog = stringFormat;
                return true;
            }
            else return false;
        }

        public void GetProcessTable(ref DataTable dta)
        {
            int iReturnCode;				//Return code
            int iStartAddr;
            int iStart;
            string szAdd = "ZR";
            string szDeviceName;		//List data for 'DeviceName'
            int iNumberOfData = 32;			//Data for 'DeviceSize'
            short[] arrDeviceValue = new short[iNumberOfData];
            int iProcessType = 0;
            int iProcessDepth = 0;
            int iNormalReverse = 0;
            int iReverseWidth = 0;
            int iMarginofAdvance = 0;
            int iMarginofDelay = 0;
            int iCutOff = 0;
            string szProcessName = "";
            List<ProcessTableData> processtables = new List<ProcessTableData>();
            //DataTable dta = new DataTable();

            try
            {
                int idx = 0;
                for (int cclink = 1; cclink <= 4; cclink++)
                {
                    iStart = ((cclink - 1) * 1000) + 3000;
                    for (int stno = 1; stno <= 30; stno++)
                    {
                        iStartAddr = ((stno - 1) * 32) + iStart;
                        szDeviceName = szAdd + iStartAddr.ToString();
                        iReturnCode = 0;
                        if (Connected == true)
                        {
                            iReturnCode = plc.ReadDeviceBlock2(szDeviceName, iNumberOfData, out arrDeviceValue[0]);
                        }
                        if (iReturnCode == 0)
                        {
                            int k = 0;
                            foreach (var baca in arrDeviceValue)
                            {
                                if (k < 16)
                                {
                                    switch (k)
                                    {
                                        case 0:
                                            iProcessType = baca;
                                            break;
                                        case 1:
                                            iProcessDepth = baca;
                                            break;
                                        case 2:
                                            iNormalReverse = baca;
                                            break;
                                        case 3:
                                            iReverseWidth = baca;
                                            break;
                                        case 4:
                                            iMarginofAdvance = baca;
                                            break;
                                        case 5:
                                            iMarginofDelay = baca;
                                            break;
                                        case 6:
                                            iCutOff = baca;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else
                                {
                                    byte[] kon = BitConverter.GetBytes(baca);

                                    foreach (byte m in kon)
                                    {
                                        char tchar = Convert.ToChar(m);
                                        szProcessName += tchar.ToString();
                                    }
                                }
                                k++;
                            }
                            //insert to datatable
                            processtables.Add(new ProcessTableData { id = idx, cc_link_no = cclink, stno = stno, process_type = iProcessType, depth = iProcessDepth, normal_reverse = iNormalReverse, margin_reverse = iReverseWidth, margin_of_adv = iMarginofAdvance, margin_of_delay = iMarginofDelay, cut_off = iCutOff, process_name = szProcessName });
                        }
                        idx++;
                    }
                }
                ListtoDataTable lsttodt = new ListtoDataTable();
                dta = lsttodt.ToDataTable(processtables);
            }
            //Exception processing
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                string stringFormat = "Read Process Table Failed";
                StatusPLCLog = stringFormat;
            }
            //return dta;
        }
        public void WriteProcessTable(ref DataTable dta)
        {
            int iReturnCode;				//Return code
            int iStartAddr;
            int iStart;
            string szAdd = "ZR";
            string szDeviceName;		//List data for 'DeviceName'
            int iNumberOfData = 32;			//Data for 'DeviceSize'
            short[] arrDeviceValue = new short[iNumberOfData];
            int iProcessType = 0;
            int iProcessDepth = 0;
            int iNormalReverse = 0;
            int iReverseWidth = 0;
            int iMarginofAdvance = 0;
            int iMarginofDelay = 0;
            int iCutOff = 0;
            string szProcessName = "";
            List<ProcessTableData> processtables = new List<ProcessTableData>();
            //DataTable dta = new DataTable();

            try
            {
                if (Connected == false)
                {
                }
                    if (dta != null)
                    {
                        foreach (DataRow dr in dta.Rows)
                        {
                            iProcessType = (int)dr["UserName"];

                        }
                        int idx = 0;
                        for (int cclink = 1; cclink <= 4; cclink++)
                        {
                            iStart = ((cclink - 1) * 1000) + 3000;
                            for (int stno = 1; stno <= 30; stno++)
                            {
                                iStartAddr = ((stno - 1) * 32) + iStart;
                                szDeviceName = szAdd + iStartAddr.ToString();
                                iReturnCode = 0;
                                if (Connected == true)
                                {
                                    iReturnCode = plc.WriteDeviceBlock2(szDeviceName, iNumberOfData, ref arrDeviceValue[0]);
                                }
                                if (iReturnCode == 0)
                                {
                                    int k = 0;
                                    foreach (var baca in arrDeviceValue)
                                    {
                                        if (k < 16)
                                        {
                                            switch (k)
                                            {
                                                case 0:
                                                    iProcessType = baca;
                                                    break;
                                                case 1:
                                                    iProcessDepth = baca;
                                                    break;
                                                case 2:
                                                    iNormalReverse = baca;
                                                    break;
                                                case 3:
                                                    iReverseWidth = baca;
                                                    break;
                                                case 4:
                                                    iMarginofAdvance = baca;
                                                    break;
                                                case 5:
                                                    iMarginofDelay = baca;
                                                    break;
                                                case 6:
                                                    iCutOff = baca;
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            byte[] kon = BitConverter.GetBytes(baca);

                                            foreach (byte m in kon)
                                            {
                                                char tchar = Convert.ToChar(m);
                                                szProcessName += tchar.ToString();
                                            }
                                        }
                                        k++;
                                    }
                                    //insert to datatable
                                    processtables.Add(new ProcessTableData { id = idx, cc_link_no = cclink, stno = stno, process_type = iProcessType, depth = iProcessDepth, normal_reverse = iNormalReverse, margin_reverse = iReverseWidth, margin_of_adv = iMarginofAdvance, margin_of_delay = iMarginofDelay, cut_off = iCutOff, process_name = szProcessName });
                                }
                                idx++;
                            }
                        }
                    }
                
            }
            //Exception processing
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                string stringFormat = "Read Process Table Failed";
                StatusPLCLog = stringFormat;
            }
            //return dta;
        }

        public static UInt16 BytesToUInt16(Byte B1, Byte B2)
        {
            UInt16 value = B1;
            value <<= 8;
            value += Convert.ToUInt16(B2);
            return value;
        }

        #endregion

        #region **** event
        protected virtual void OnConnectionChanged(ConnectionChangedEventArgs e)
        {
            EventHandler<ConnectionChangedEventArgs> handler = ConnectionChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnStatusPLCLogChanged(StatusPLCLogChangedEventArgs e)
        {
            EventHandler<StatusPLCLogChangedEventArgs> handler = StatusPLCLogChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<StatusPLCLogChangedEventArgs> StatusPLCLogChanged;

        public event EventHandler<ConnectionChangedEventArgs> ConnectionChanged;

        #endregion
    }

    public class ConnectionChangedEventArgs : EventArgs
    {
        public bool State { get; set; }
    }

    public class StatusPLCLogChangedEventArgs : EventArgs
    {
        public string State { get; set; }
    }
}
