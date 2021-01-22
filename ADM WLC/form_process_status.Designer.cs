namespace ADM_WLC
{
    partial class form_process_status
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
            this.btn_close_proccess_status = new System.Windows.Forms.Button();
            this.pnl_porcess_status_1 = new System.Windows.Forms.Panel();
            this.lbl_pid = new System.Windows.Forms.Label();
            this.lbl_processname = new System.Windows.Forms.Label();
            this.lbl_processno = new System.Windows.Forms.Label();
            this.lbl_linkno = new System.Windows.Forms.Label();
            this.lbl_most_adv = new System.Windows.Forms.Label();
            this.lbl_slow_process = new System.Windows.Forms.Label();
            this.textBox_linkno_most_adv = new System.Windows.Forms.TextBox();
            this.textBox_linkno_slow_process = new System.Windows.Forms.TextBox();
            this.textBox_processno_most_adv = new System.Windows.Forms.TextBox();
            this.textBox_processno_slow_process = new System.Windows.Forms.TextBox();
            this.textBox_pocessname_most_adv = new System.Windows.Forms.TextBox();
            this.textBox_processname_slow_process = new System.Windows.Forms.TextBox();
            this.textBox_pid_most_adv = new System.Windows.Forms.TextBox();
            this.textBox_pid_slow_process = new System.Windows.Forms.TextBox();
            this.dataGridView_process_status = new System.Windows.Forms.DataGridView();
            this.cc_link_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_code_b1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_code_b2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standard_progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin_of_delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin_of_adv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cut_off = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cclink_no = new System.Windows.Forms.Label();
            this.comboBox_cclink_no = new System.Windows.Forms.ComboBox();
            this.btn_hardcopy_process_status = new System.Windows.Forms.Button();
            this.btn_prev_process_status = new System.Windows.Forms.Button();
            this.btn_next_process_status = new System.Windows.Forms.Button();
            this.pnl_porcess_status_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_process_status)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close_proccess_status
            // 
            this.btn_close_proccess_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close_proccess_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_proccess_status.Location = new System.Drawing.Point(1164, 631);
            this.btn_close_proccess_status.Name = "btn_close_proccess_status";
            this.btn_close_proccess_status.Size = new System.Drawing.Size(121, 51);
            this.btn_close_proccess_status.TabIndex = 0;
            this.btn_close_proccess_status.Text = "Close";
            this.btn_close_proccess_status.UseVisualStyleBackColor = true;
            this.btn_close_proccess_status.Click += new System.EventHandler(this.btn_close_proccess_status_Click);
            // 
            // pnl_porcess_status_1
            // 
            this.pnl_porcess_status_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_porcess_status_1.BackColor = System.Drawing.Color.SkyBlue;
            this.pnl_porcess_status_1.Controls.Add(this.lbl_pid);
            this.pnl_porcess_status_1.Controls.Add(this.lbl_processname);
            this.pnl_porcess_status_1.Controls.Add(this.lbl_processno);
            this.pnl_porcess_status_1.Controls.Add(this.lbl_linkno);
            this.pnl_porcess_status_1.Controls.Add(this.lbl_most_adv);
            this.pnl_porcess_status_1.Controls.Add(this.lbl_slow_process);
            this.pnl_porcess_status_1.Controls.Add(this.textBox_linkno_most_adv);
            this.pnl_porcess_status_1.Controls.Add(this.textBox_linkno_slow_process);
            this.pnl_porcess_status_1.Controls.Add(this.textBox_processno_most_adv);
            this.pnl_porcess_status_1.Controls.Add(this.textBox_processno_slow_process);
            this.pnl_porcess_status_1.Controls.Add(this.textBox_pocessname_most_adv);
            this.pnl_porcess_status_1.Controls.Add(this.textBox_processname_slow_process);
            this.pnl_porcess_status_1.Controls.Add(this.textBox_pid_most_adv);
            this.pnl_porcess_status_1.Controls.Add(this.textBox_pid_slow_process);
            this.pnl_porcess_status_1.Location = new System.Drawing.Point(455, 4);
            this.pnl_porcess_status_1.Name = "pnl_porcess_status_1";
            this.pnl_porcess_status_1.Size = new System.Drawing.Size(830, 83);
            this.pnl_porcess_status_1.TabIndex = 1;
            // 
            // lbl_pid
            // 
            this.lbl_pid.AutoSize = true;
            this.lbl_pid.Location = new System.Drawing.Point(625, 14);
            this.lbl_pid.Name = "lbl_pid";
            this.lbl_pid.Size = new System.Drawing.Size(25, 13);
            this.lbl_pid.TabIndex = 13;
            this.lbl_pid.Text = "PID";
            // 
            // lbl_processname
            // 
            this.lbl_processname.AutoSize = true;
            this.lbl_processname.Location = new System.Drawing.Point(362, 14);
            this.lbl_processname.Name = "lbl_processname";
            this.lbl_processname.Size = new System.Drawing.Size(76, 13);
            this.lbl_processname.TabIndex = 12;
            this.lbl_processname.Text = "Process Name";
            // 
            // lbl_processno
            // 
            this.lbl_processno.AutoSize = true;
            this.lbl_processno.Location = new System.Drawing.Point(275, 14);
            this.lbl_processno.Name = "lbl_processno";
            this.lbl_processno.Size = new System.Drawing.Size(62, 13);
            this.lbl_processno.TabIndex = 11;
            this.lbl_processno.Text = "Process No";
            // 
            // lbl_linkno
            // 
            this.lbl_linkno.AutoSize = true;
            this.lbl_linkno.Location = new System.Drawing.Point(192, 14);
            this.lbl_linkno.Name = "lbl_linkno";
            this.lbl_linkno.Size = new System.Drawing.Size(44, 13);
            this.lbl_linkno.TabIndex = 10;
            this.lbl_linkno.Text = "Link No";
            // 
            // lbl_most_adv
            // 
            this.lbl_most_adv.AutoSize = true;
            this.lbl_most_adv.Location = new System.Drawing.Point(74, 30);
            this.lbl_most_adv.Name = "lbl_most_adv";
            this.lbl_most_adv.Size = new System.Drawing.Size(117, 13);
            this.lbl_most_adv.TabIndex = 9;
            this.lbl_most_adv.Text = "Most Advance Process";
            // 
            // lbl_slow_process
            // 
            this.lbl_slow_process.AutoSize = true;
            this.lbl_slow_process.Location = new System.Drawing.Point(74, 59);
            this.lbl_slow_process.Name = "lbl_slow_process";
            this.lbl_slow_process.Size = new System.Drawing.Size(71, 13);
            this.lbl_slow_process.TabIndex = 8;
            this.lbl_slow_process.Text = "Slow Process";
            // 
            // textBox_linkno_most_adv
            // 
            this.textBox_linkno_most_adv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_linkno_most_adv.Location = new System.Drawing.Point(193, 30);
            this.textBox_linkno_most_adv.Name = "textBox_linkno_most_adv";
            this.textBox_linkno_most_adv.Size = new System.Drawing.Size(70, 20);
            this.textBox_linkno_most_adv.TabIndex = 7;
            // 
            // textBox_linkno_slow_process
            // 
            this.textBox_linkno_slow_process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_linkno_slow_process.Location = new System.Drawing.Point(193, 56);
            this.textBox_linkno_slow_process.Name = "textBox_linkno_slow_process";
            this.textBox_linkno_slow_process.Size = new System.Drawing.Size(70, 20);
            this.textBox_linkno_slow_process.TabIndex = 6;
            // 
            // textBox_processno_most_adv
            // 
            this.textBox_processno_most_adv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_processno_most_adv.Location = new System.Drawing.Point(278, 30);
            this.textBox_processno_most_adv.Name = "textBox_processno_most_adv";
            this.textBox_processno_most_adv.Size = new System.Drawing.Size(70, 20);
            this.textBox_processno_most_adv.TabIndex = 5;
            // 
            // textBox_processno_slow_process
            // 
            this.textBox_processno_slow_process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_processno_slow_process.Location = new System.Drawing.Point(278, 56);
            this.textBox_processno_slow_process.Name = "textBox_processno_slow_process";
            this.textBox_processno_slow_process.Size = new System.Drawing.Size(70, 20);
            this.textBox_processno_slow_process.TabIndex = 4;
            // 
            // textBox_pocessname_most_adv
            // 
            this.textBox_pocessname_most_adv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pocessname_most_adv.Location = new System.Drawing.Point(365, 30);
            this.textBox_pocessname_most_adv.Name = "textBox_pocessname_most_adv";
            this.textBox_pocessname_most_adv.Size = new System.Drawing.Size(247, 20);
            this.textBox_pocessname_most_adv.TabIndex = 3;
            // 
            // textBox_processname_slow_process
            // 
            this.textBox_processname_slow_process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_processname_slow_process.Location = new System.Drawing.Point(365, 56);
            this.textBox_processname_slow_process.Name = "textBox_processname_slow_process";
            this.textBox_processname_slow_process.Size = new System.Drawing.Size(247, 20);
            this.textBox_processname_slow_process.TabIndex = 2;
            // 
            // textBox_pid_most_adv
            // 
            this.textBox_pid_most_adv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pid_most_adv.Location = new System.Drawing.Point(628, 30);
            this.textBox_pid_most_adv.Name = "textBox_pid_most_adv";
            this.textBox_pid_most_adv.Size = new System.Drawing.Size(192, 20);
            this.textBox_pid_most_adv.TabIndex = 1;
            // 
            // textBox_pid_slow_process
            // 
            this.textBox_pid_slow_process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pid_slow_process.Location = new System.Drawing.Point(628, 56);
            this.textBox_pid_slow_process.Name = "textBox_pid_slow_process";
            this.textBox_pid_slow_process.Size = new System.Drawing.Size(192, 20);
            this.textBox_pid_slow_process.TabIndex = 0;
            // 
            // dataGridView_process_status
            // 
            this.dataGridView_process_status.AllowUserToAddRows = false;
            this.dataGridView_process_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_process_status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_process_status.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cc_link_no,
            this.process_no,
            this.process_name,
            this.pid,
            this.model_code,
            this.job_code_b1,
            this.job_code_b2,
            this.standard_progress,
            this.current_progress,
            this.margin_of_delay,
            this.margin_of_adv,
            this.cut_off});
            this.dataGridView_process_status.Location = new System.Drawing.Point(1, 93);
            this.dataGridView_process_status.Name = "dataGridView_process_status";
            this.dataGridView_process_status.ReadOnly = true;
            this.dataGridView_process_status.RowHeadersVisible = false;
            this.dataGridView_process_status.Size = new System.Drawing.Size(1284, 532);
            this.dataGridView_process_status.TabIndex = 2;
            this.dataGridView_process_status.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_process_status_RowPostPaint);
            // 
            // cc_link_no
            // 
            this.cc_link_no.DataPropertyName = "cc_link_no";
            this.cc_link_no.HeaderText = "CC-Link No";
            this.cc_link_no.Name = "cc_link_no";
            this.cc_link_no.ReadOnly = true;
            this.cc_link_no.Visible = false;
            this.cc_link_no.Width = 50;
            // 
            // process_no
            // 
            this.process_no.HeaderText = "Process No";
            this.process_no.Name = "process_no";
            this.process_no.ReadOnly = true;
            this.process_no.Width = 50;
            // 
            // process_name
            // 
            this.process_name.DataPropertyName = "process_name";
            this.process_name.HeaderText = "Process Name";
            this.process_name.Name = "process_name";
            this.process_name.ReadOnly = true;
            this.process_name.Width = 400;
            // 
            // pid
            // 
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "PID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            this.pid.Width = 200;
            // 
            // model_code
            // 
            this.model_code.DataPropertyName = "model_code";
            this.model_code.DividerWidth = 8;
            this.model_code.HeaderText = "Model Code";
            this.model_code.Name = "model_code";
            this.model_code.ReadOnly = true;
            this.model_code.Width = 80;
            // 
            // job_code_b1
            // 
            this.job_code_b1.DataPropertyName = "job_code_b1";
            this.job_code_b1.HeaderText = "Job Code B1";
            this.job_code_b1.Name = "job_code_b1";
            this.job_code_b1.ReadOnly = true;
            this.job_code_b1.Width = 90;
            // 
            // job_code_b2
            // 
            this.job_code_b2.DataPropertyName = "job_code_b2";
            this.job_code_b2.DividerWidth = 8;
            this.job_code_b2.HeaderText = "Job Code B2";
            this.job_code_b2.Name = "job_code_b2";
            this.job_code_b2.ReadOnly = true;
            this.job_code_b2.Width = 90;
            // 
            // standard_progress
            // 
            this.standard_progress.DataPropertyName = "standard_progress";
            this.standard_progress.HeaderText = "Standard Progress";
            this.standard_progress.Name = "standard_progress";
            this.standard_progress.ReadOnly = true;
            // 
            // current_progress
            // 
            this.current_progress.DataPropertyName = "current_progress";
            this.current_progress.HeaderText = "Current Progress";
            this.current_progress.Name = "current_progress";
            this.current_progress.ReadOnly = true;
            // 
            // margin_of_delay
            // 
            this.margin_of_delay.DataPropertyName = "margin_of_delay";
            this.margin_of_delay.HeaderText = "Margin of Delay";
            this.margin_of_delay.Name = "margin_of_delay";
            this.margin_of_delay.ReadOnly = true;
            this.margin_of_delay.Width = 150;
            // 
            // margin_of_adv
            // 
            this.margin_of_adv.DataPropertyName = "margin_of_adv";
            this.margin_of_adv.HeaderText = "Margin of Advance";
            this.margin_of_adv.Name = "margin_of_adv";
            this.margin_of_adv.ReadOnly = true;
            this.margin_of_adv.Width = 150;
            // 
            // cut_off
            // 
            this.cut_off.DataPropertyName = "cut_off";
            this.cut_off.HeaderText = "Cut Off";
            this.cut_off.Name = "cut_off";
            this.cut_off.ReadOnly = true;
            // 
            // lbl_cclink_no
            // 
            this.lbl_cclink_no.AutoSize = true;
            this.lbl_cclink_no.Location = new System.Drawing.Point(17, 51);
            this.lbl_cclink_no.Name = "lbl_cclink_no";
            this.lbl_cclink_no.Size = new System.Drawing.Size(64, 13);
            this.lbl_cclink_no.TabIndex = 3;
            this.lbl_cclink_no.Text = "CC Link No.";
            // 
            // comboBox_cclink_no
            // 
            this.comboBox_cclink_no.FormattingEnabled = true;
            this.comboBox_cclink_no.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_cclink_no.Location = new System.Drawing.Point(87, 48);
            this.comboBox_cclink_no.Name = "comboBox_cclink_no";
            this.comboBox_cclink_no.Size = new System.Drawing.Size(65, 21);
            this.comboBox_cclink_no.TabIndex = 4;
            this.comboBox_cclink_no.SelectedIndexChanged += new System.EventHandler(this.comboBox_cclink_no_SelectedIndexChanged);
            // 
            // btn_hardcopy_process_status
            // 
            this.btn_hardcopy_process_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_hardcopy_process_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hardcopy_process_status.Location = new System.Drawing.Point(1037, 631);
            this.btn_hardcopy_process_status.Name = "btn_hardcopy_process_status";
            this.btn_hardcopy_process_status.Size = new System.Drawing.Size(121, 51);
            this.btn_hardcopy_process_status.TabIndex = 5;
            this.btn_hardcopy_process_status.Text = "Hard Copy";
            this.btn_hardcopy_process_status.UseVisualStyleBackColor = true;
            this.btn_hardcopy_process_status.Click += new System.EventHandler(this.btn_hardcopy_process_status_Click);
            // 
            // btn_prev_process_status
            // 
            this.btn_prev_process_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_prev_process_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev_process_status.Location = new System.Drawing.Point(1, 631);
            this.btn_prev_process_status.Name = "btn_prev_process_status";
            this.btn_prev_process_status.Size = new System.Drawing.Size(121, 51);
            this.btn_prev_process_status.TabIndex = 6;
            this.btn_prev_process_status.Text = "< Prev";
            this.btn_prev_process_status.UseVisualStyleBackColor = true;
            this.btn_prev_process_status.Click += new System.EventHandler(this.btn_prev_process_status_Click);
            // 
            // btn_next_process_status
            // 
            this.btn_next_process_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_next_process_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next_process_status.Location = new System.Drawing.Point(128, 631);
            this.btn_next_process_status.Name = "btn_next_process_status";
            this.btn_next_process_status.Size = new System.Drawing.Size(121, 51);
            this.btn_next_process_status.TabIndex = 7;
            this.btn_next_process_status.Text = "Next >";
            this.btn_next_process_status.UseVisualStyleBackColor = true;
            this.btn_next_process_status.Click += new System.EventHandler(this.btn_next_process_status_Click);
            // 
            // form_process_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 500);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1287, 684);
            this.ControlBox = false;
            this.Controls.Add(this.btn_next_process_status);
            this.Controls.Add(this.btn_prev_process_status);
            this.Controls.Add(this.btn_hardcopy_process_status);
            this.Controls.Add(this.comboBox_cclink_no);
            this.Controls.Add(this.lbl_cclink_no);
            this.Controls.Add(this.dataGridView_process_status);
            this.Controls.Add(this.pnl_porcess_status_1);
            this.Controls.Add(this.btn_close_proccess_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_process_status";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_process_status_Load);
            this.pnl_porcess_status_1.ResumeLayout(false);
            this.pnl_porcess_status_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_process_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close_proccess_status;
        private System.Windows.Forms.Panel pnl_porcess_status_1;
        private System.Windows.Forms.DataGridView dataGridView_process_status;
        private System.Windows.Forms.Label lbl_cclink_no;
        private System.Windows.Forms.ComboBox comboBox_cclink_no;
        private System.Windows.Forms.TextBox textBox_processname_slow_process;
        private System.Windows.Forms.TextBox textBox_pid_most_adv;
        private System.Windows.Forms.TextBox textBox_pid_slow_process;
        private System.Windows.Forms.TextBox textBox_pocessname_most_adv;
        private System.Windows.Forms.TextBox textBox_linkno_most_adv;
        private System.Windows.Forms.TextBox textBox_linkno_slow_process;
        private System.Windows.Forms.TextBox textBox_processno_most_adv;
        private System.Windows.Forms.TextBox textBox_processno_slow_process;
        private System.Windows.Forms.Label lbl_pid;
        private System.Windows.Forms.Label lbl_processname;
        private System.Windows.Forms.Label lbl_processno;
        private System.Windows.Forms.Label lbl_linkno;
        private System.Windows.Forms.Label lbl_most_adv;
        private System.Windows.Forms.Label lbl_slow_process;
        private System.Windows.Forms.Button btn_hardcopy_process_status;
        private System.Windows.Forms.Button btn_prev_process_status;
        private System.Windows.Forms.Button btn_next_process_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc_link_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_code_b1;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_code_b2;
        private System.Windows.Forms.DataGridViewTextBoxColumn standard_progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin_of_delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin_of_adv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cut_off;
    }
}