
namespace ADM_WLC
{
    partial class SaveDataRangeDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_startdate_savedata = new System.Windows.Forms.Label();
            this.datePicker_startdate_savedata = new System.Windows.Forms.DateTimePicker();
            this.lbl_enddate_savedate = new System.Windows.Forms.Label();
            this.datePicker_enddate_savedate = new System.Windows.Forms.DateTimePicker();
            this.timePicker_startdate_savedata = new System.Windows.Forms.DateTimePicker();
            this.timePicker_enddate_savedata = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel_savedata = new System.Windows.Forms.Button();
            this.btn_ok_savedata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_startdate_savedata
            // 
            this.lbl_startdate_savedata.AutoSize = true;
            this.lbl_startdate_savedata.Location = new System.Drawing.Point(26, 37);
            this.lbl_startdate_savedata.Name = "lbl_startdate_savedata";
            this.lbl_startdate_savedata.Size = new System.Drawing.Size(52, 13);
            this.lbl_startdate_savedata.TabIndex = 0;
            this.lbl_startdate_savedata.Text = "StartDate";
            // 
            // datePicker_startdate_savedata
            // 
            this.datePicker_startdate_savedata.CustomFormat = "yyyy/MM/dd";
            this.datePicker_startdate_savedata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_startdate_savedata.Location = new System.Drawing.Point(93, 37);
            this.datePicker_startdate_savedata.Name = "datePicker_startdate_savedata";
            this.datePicker_startdate_savedata.Size = new System.Drawing.Size(112, 20);
            this.datePicker_startdate_savedata.TabIndex = 1;
            // 
            // lbl_enddate_savedate
            // 
            this.lbl_enddate_savedate.AutoSize = true;
            this.lbl_enddate_savedate.Location = new System.Drawing.Point(26, 73);
            this.lbl_enddate_savedate.Name = "lbl_enddate_savedate";
            this.lbl_enddate_savedate.Size = new System.Drawing.Size(49, 13);
            this.lbl_enddate_savedate.TabIndex = 2;
            this.lbl_enddate_savedate.Text = "EndDate";
            // 
            // datePicker_enddate_savedate
            // 
            this.datePicker_enddate_savedate.CustomFormat = "yyyy/MM/dd";
            this.datePicker_enddate_savedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_enddate_savedate.Location = new System.Drawing.Point(93, 73);
            this.datePicker_enddate_savedate.Name = "datePicker_enddate_savedate";
            this.datePicker_enddate_savedate.Size = new System.Drawing.Size(112, 20);
            this.datePicker_enddate_savedate.TabIndex = 3;
            // 
            // timePicker_startdate_savedata
            // 
            this.timePicker_startdate_savedata.CustomFormat = "HH:mm";
            this.timePicker_startdate_savedata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker_startdate_savedata.Location = new System.Drawing.Point(233, 37);
            this.timePicker_startdate_savedata.Name = "timePicker_startdate_savedata";
            this.timePicker_startdate_savedata.ShowUpDown = true;
            this.timePicker_startdate_savedata.Size = new System.Drawing.Size(95, 20);
            this.timePicker_startdate_savedata.TabIndex = 4;
            this.timePicker_startdate_savedata.Value = new System.DateTime(2021, 2, 2, 0, 0, 0, 0);
            // 
            // timePicker_enddate_savedata
            // 
            this.timePicker_enddate_savedata.CustomFormat = "HH:mm";
            this.timePicker_enddate_savedata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker_enddate_savedata.Location = new System.Drawing.Point(233, 73);
            this.timePicker_enddate_savedata.Name = "timePicker_enddate_savedata";
            this.timePicker_enddate_savedata.ShowUpDown = true;
            this.timePicker_enddate_savedata.Size = new System.Drawing.Size(95, 20);
            this.timePicker_enddate_savedata.TabIndex = 5;
            this.timePicker_enddate_savedata.Value = new System.DateTime(2021, 2, 2, 23, 59, 0, 0);
            // 
            // btn_cancel_savedata
            // 
            this.btn_cancel_savedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_savedata.Location = new System.Drawing.Point(226, 115);
            this.btn_cancel_savedata.Name = "btn_cancel_savedata";
            this.btn_cancel_savedata.Size = new System.Drawing.Size(102, 41);
            this.btn_cancel_savedata.TabIndex = 94;
            this.btn_cancel_savedata.Text = "Cancel";
            this.btn_cancel_savedata.UseVisualStyleBackColor = true;
            this.btn_cancel_savedata.Click += new System.EventHandler(this.btn_cancel_savedata_Click);
            // 
            // btn_ok_savedata
            // 
            this.btn_ok_savedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_savedata.Location = new System.Drawing.Point(93, 115);
            this.btn_ok_savedata.Name = "btn_ok_savedata";
            this.btn_ok_savedata.Size = new System.Drawing.Size(102, 41);
            this.btn_ok_savedata.TabIndex = 93;
            this.btn_ok_savedata.Text = "OK";
            this.btn_ok_savedata.UseVisualStyleBackColor = true;
            this.btn_ok_savedata.Click += new System.EventHandler(this.btn_ok_savedata_Click);
            // 
            // SaveDataRangeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 191);
            this.Controls.Add(this.btn_cancel_savedata);
            this.Controls.Add(this.btn_ok_savedata);
            this.Controls.Add(this.timePicker_enddate_savedata);
            this.Controls.Add(this.timePicker_startdate_savedata);
            this.Controls.Add(this.datePicker_enddate_savedate);
            this.Controls.Add(this.lbl_enddate_savedate);
            this.Controls.Add(this.datePicker_startdate_savedata);
            this.Controls.Add(this.lbl_startdate_savedata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveDataRangeDialog";
            this.ShowIcon = false;
            this.Text = "SaveDataRangeDialog";
            this.Load += new System.EventHandler(this.SaveDataRangeDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_startdate_savedata;
        private System.Windows.Forms.DateTimePicker datePicker_startdate_savedata;
        private System.Windows.Forms.Label lbl_enddate_savedate;
        private System.Windows.Forms.DateTimePicker datePicker_enddate_savedate;
        private System.Windows.Forms.DateTimePicker timePicker_startdate_savedata;
        private System.Windows.Forms.DateTimePicker timePicker_enddate_savedata;
        private System.Windows.Forms.Button btn_cancel_savedata;
        private System.Windows.Forms.Button btn_ok_savedata;
    }
}