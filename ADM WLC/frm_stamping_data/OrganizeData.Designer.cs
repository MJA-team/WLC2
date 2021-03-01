
namespace ADM_WLC
{
    partial class OrganizeData
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
            this.dataGridView_organizedata = new System.Windows.Forms.DataGridView();
            this.timePicker_enddate_organizedata = new System.Windows.Forms.DateTimePicker();
            this.timePicker_startdate_organizedata = new System.Windows.Forms.DateTimePicker();
            this.datePicker_enddate_organizedata = new System.Windows.Forms.DateTimePicker();
            this.lbl_enddate_organizedata = new System.Windows.Forms.Label();
            this.datePicker_startdate_organizedata = new System.Windows.Forms.DateTimePicker();
            this.lbl_startdate_organizedata = new System.Windows.Forms.Label();
            this.btn_refresh_organizedata = new System.Windows.Forms.Button();
            this.stamp_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.before_last_frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_frame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_no_1st_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_organizedata)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_organizedata
            // 
            this.dataGridView_organizedata.AllowUserToAddRows = false;
            this.dataGridView_organizedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_organizedata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stamp_type,
            this.before_last_frame,
            this.first_frame,
            this.last_frame,
            this.last_data,
            this.last_no_1st_no});
            this.dataGridView_organizedata.Location = new System.Drawing.Point(1, 102);
            this.dataGridView_organizedata.Name = "dataGridView_organizedata";
            this.dataGridView_organizedata.Size = new System.Drawing.Size(797, 691);
            this.dataGridView_organizedata.TabIndex = 0;
            // 
            // timePicker_enddate_organizedata
            // 
            this.timePicker_enddate_organizedata.CustomFormat = "HH:mm";
            this.timePicker_enddate_organizedata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker_enddate_organizedata.Location = new System.Drawing.Point(559, 60);
            this.timePicker_enddate_organizedata.Name = "timePicker_enddate_organizedata";
            this.timePicker_enddate_organizedata.ShowUpDown = true;
            this.timePicker_enddate_organizedata.Size = new System.Drawing.Size(95, 20);
            this.timePicker_enddate_organizedata.TabIndex = 11;
            this.timePicker_enddate_organizedata.Value = new System.DateTime(2021, 2, 2, 23, 59, 0, 0);
            // 
            // timePicker_startdate_organizedata
            // 
            this.timePicker_startdate_organizedata.CustomFormat = "HH:mm";
            this.timePicker_startdate_organizedata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker_startdate_organizedata.Location = new System.Drawing.Point(559, 24);
            this.timePicker_startdate_organizedata.Name = "timePicker_startdate_organizedata";
            this.timePicker_startdate_organizedata.ShowUpDown = true;
            this.timePicker_startdate_organizedata.Size = new System.Drawing.Size(95, 20);
            this.timePicker_startdate_organizedata.TabIndex = 10;
            this.timePicker_startdate_organizedata.Value = new System.DateTime(2021, 2, 2, 0, 0, 0, 0);
            // 
            // datePicker_enddate_organizedata
            // 
            this.datePicker_enddate_organizedata.CustomFormat = "yyyy/MM/dd";
            this.datePicker_enddate_organizedata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_enddate_organizedata.Location = new System.Drawing.Point(419, 60);
            this.datePicker_enddate_organizedata.Name = "datePicker_enddate_organizedata";
            this.datePicker_enddate_organizedata.Size = new System.Drawing.Size(112, 20);
            this.datePicker_enddate_organizedata.TabIndex = 9;
            // 
            // lbl_enddate_organizedata
            // 
            this.lbl_enddate_organizedata.AutoSize = true;
            this.lbl_enddate_organizedata.Location = new System.Drawing.Point(352, 60);
            this.lbl_enddate_organizedata.Name = "lbl_enddate_organizedata";
            this.lbl_enddate_organizedata.Size = new System.Drawing.Size(49, 13);
            this.lbl_enddate_organizedata.TabIndex = 8;
            this.lbl_enddate_organizedata.Text = "EndDate";
            // 
            // datePicker_startdate_organizedata
            // 
            this.datePicker_startdate_organizedata.CustomFormat = "yyyy/MM/dd";
            this.datePicker_startdate_organizedata.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_startdate_organizedata.Location = new System.Drawing.Point(419, 24);
            this.datePicker_startdate_organizedata.Name = "datePicker_startdate_organizedata";
            this.datePicker_startdate_organizedata.Size = new System.Drawing.Size(112, 20);
            this.datePicker_startdate_organizedata.TabIndex = 7;
            // 
            // lbl_startdate_organizedata
            // 
            this.lbl_startdate_organizedata.AutoSize = true;
            this.lbl_startdate_organizedata.Location = new System.Drawing.Point(352, 24);
            this.lbl_startdate_organizedata.Name = "lbl_startdate_organizedata";
            this.lbl_startdate_organizedata.Size = new System.Drawing.Size(52, 13);
            this.lbl_startdate_organizedata.TabIndex = 6;
            this.lbl_startdate_organizedata.Text = "StartDate";
            // 
            // btn_refresh_organizedata
            // 
            this.btn_refresh_organizedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh_organizedata.Location = new System.Drawing.Point(681, 32);
            this.btn_refresh_organizedata.Name = "btn_refresh_organizedata";
            this.btn_refresh_organizedata.Size = new System.Drawing.Size(107, 41);
            this.btn_refresh_organizedata.TabIndex = 94;
            this.btn_refresh_organizedata.Text = "Refresh";
            this.btn_refresh_organizedata.UseVisualStyleBackColor = true;
            // 
            // stamp_type
            // 
            this.stamp_type.HeaderText = "Stamp Type";
            this.stamp_type.Name = "stamp_type";
            this.stamp_type.ReadOnly = true;
            this.stamp_type.Width = 89;
            // 
            // before_last_frame
            // 
            this.before_last_frame.HeaderText = "Before Last";
            this.before_last_frame.Name = "before_last_frame";
            // 
            // first_frame
            // 
            this.first_frame.HeaderText = "First";
            this.first_frame.Name = "first_frame";
            // 
            // last_frame
            // 
            this.last_frame.HeaderText = "Last";
            this.last_frame.Name = "last_frame";
            // 
            // last_data
            // 
            this.last_data.HeaderText = "Last";
            this.last_data.Name = "last_data";
            // 
            // last_no_1st_no
            // 
            this.last_no_1st_no.HeaderText = "Last No";
            this.last_no_1st_no.Name = "last_no_1st_no";
            // 
            // OrganizeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 794);
            this.Controls.Add(this.btn_refresh_organizedata);
            this.Controls.Add(this.timePicker_enddate_organizedata);
            this.Controls.Add(this.timePicker_startdate_organizedata);
            this.Controls.Add(this.datePicker_enddate_organizedata);
            this.Controls.Add(this.lbl_enddate_organizedata);
            this.Controls.Add(this.datePicker_startdate_organizedata);
            this.Controls.Add(this.lbl_startdate_organizedata);
            this.Controls.Add(this.dataGridView_organizedata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrganizeData";
            this.ShowIcon = false;
            this.Text = "OrganizeData";
            this.Load += new System.EventHandler(this.OrganizeData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_organizedata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_organizedata;
        private System.Windows.Forms.DateTimePicker timePicker_enddate_organizedata;
        private System.Windows.Forms.DateTimePicker timePicker_startdate_organizedata;
        private System.Windows.Forms.DateTimePicker datePicker_enddate_organizedata;
        private System.Windows.Forms.Label lbl_enddate_organizedata;
        private System.Windows.Forms.DateTimePicker datePicker_startdate_organizedata;
        private System.Windows.Forms.Label lbl_startdate_organizedata;
        private System.Windows.Forms.Button btn_refresh_organizedata;
        private System.Windows.Forms.DataGridViewTextBoxColumn stamp_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn before_last_frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_frame;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_no_1st_no;
    }
}