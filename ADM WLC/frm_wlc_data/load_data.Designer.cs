namespace ADM_WLC
{
    partial class load_data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public string txtFileName;

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
            this.tb_head_pid = new System.Windows.Forms.TextBox();
            this.tb_last_pid = new System.Windows.Forms.TextBox();
            this.tb_numb_data = new System.Windows.Forms.TextBox();
            this.btn_cancel_load_data = new System.Windows.Forms.Button();
            this.btn_headpid_load_data = new System.Windows.Forms.Button();
            this.btn_loadall_load_data = new System.Windows.Forms.Button();
            this.lbl_haed_pid_load_data = new System.Windows.Forms.Label();
            this.lbl_last_pid_load_data = new System.Windows.Forms.Label();
            this.lbl_numb_data_load_data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_head_pid
            // 
            this.tb_head_pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_head_pid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_head_pid.Location = new System.Drawing.Point(312, 65);
            this.tb_head_pid.Name = "tb_head_pid";
            this.tb_head_pid.ReadOnly = true;
            this.tb_head_pid.Size = new System.Drawing.Size(144, 20);
            this.tb_head_pid.TabIndex = 0;
            // 
            // tb_last_pid
            // 
            this.tb_last_pid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_last_pid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_last_pid.Location = new System.Drawing.Point(312, 108);
            this.tb_last_pid.Name = "tb_last_pid";
            this.tb_last_pid.ReadOnly = true;
            this.tb_last_pid.Size = new System.Drawing.Size(144, 20);
            this.tb_last_pid.TabIndex = 1;
            // 
            // tb_numb_data
            // 
            this.tb_numb_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_numb_data.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_numb_data.Location = new System.Drawing.Point(312, 182);
            this.tb_numb_data.Name = "tb_numb_data";
            this.tb_numb_data.ReadOnly = true;
            this.tb_numb_data.Size = new System.Drawing.Size(144, 20);
            this.tb_numb_data.TabIndex = 2;
            // 
            // btn_cancel_load_data
            // 
            this.btn_cancel_load_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_load_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_load_data.Location = new System.Drawing.Point(420, 240);
            this.btn_cancel_load_data.Name = "btn_cancel_load_data";
            this.btn_cancel_load_data.Size = new System.Drawing.Size(105, 39);
            this.btn_cancel_load_data.TabIndex = 3;
            this.btn_cancel_load_data.Text = "Cancel";
            this.btn_cancel_load_data.UseVisualStyleBackColor = true;
            this.btn_cancel_load_data.Click += new System.EventHandler(this.btn_cancel_load_data_Click);
            // 
            // btn_headpid_load_data
            // 
            this.btn_headpid_load_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_headpid_load_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_headpid_load_data.Location = new System.Drawing.Point(244, 240);
            this.btn_headpid_load_data.Name = "btn_headpid_load_data";
            this.btn_headpid_load_data.Size = new System.Drawing.Size(161, 39);
            this.btn_headpid_load_data.TabIndex = 4;
            this.btn_headpid_load_data.Text = "Head PID Revice";
            this.btn_headpid_load_data.UseVisualStyleBackColor = true;
            this.btn_headpid_load_data.Click += new System.EventHandler(this.btn_headpid_load_data_Click);
            // 
            // btn_loadall_load_data
            // 
            this.btn_loadall_load_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loadall_load_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadall_load_data.Location = new System.Drawing.Point(121, 240);
            this.btn_loadall_load_data.Name = "btn_loadall_load_data";
            this.btn_loadall_load_data.Size = new System.Drawing.Size(105, 39);
            this.btn_loadall_load_data.TabIndex = 5;
            this.btn_loadall_load_data.Text = "Load ALL";
            this.btn_loadall_load_data.UseVisualStyleBackColor = true;
            this.btn_loadall_load_data.Click += new System.EventHandler(this.btn_loadall_load_data_Click);
            // 
            // lbl_haed_pid_load_data
            // 
            this.lbl_haed_pid_load_data.AutoSize = true;
            this.lbl_haed_pid_load_data.Location = new System.Drawing.Point(191, 65);
            this.lbl_haed_pid_load_data.Name = "lbl_haed_pid_load_data";
            this.lbl_haed_pid_load_data.Size = new System.Drawing.Size(54, 13);
            this.lbl_haed_pid_load_data.TabIndex = 6;
            this.lbl_haed_pid_load_data.Text = "Head PID";
            // 
            // lbl_last_pid_load_data
            // 
            this.lbl_last_pid_load_data.AutoSize = true;
            this.lbl_last_pid_load_data.Location = new System.Drawing.Point(191, 108);
            this.lbl_last_pid_load_data.Name = "lbl_last_pid_load_data";
            this.lbl_last_pid_load_data.Size = new System.Drawing.Size(48, 13);
            this.lbl_last_pid_load_data.TabIndex = 7;
            this.lbl_last_pid_load_data.Text = "Last PID";
            // 
            // lbl_numb_data_load_data
            // 
            this.lbl_numb_data_load_data.AutoSize = true;
            this.lbl_numb_data_load_data.Location = new System.Drawing.Point(191, 182);
            this.lbl_numb_data_load_data.Name = "lbl_numb_data_load_data";
            this.lbl_numb_data_load_data.Size = new System.Drawing.Size(76, 13);
            this.lbl_numb_data_load_data.TabIndex = 8;
            this.lbl_numb_data_load_data.Text = "Numb. of Data";
            // 
            // load_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 312);
            this.Controls.Add(this.lbl_numb_data_load_data);
            this.Controls.Add(this.lbl_last_pid_load_data);
            this.Controls.Add(this.lbl_haed_pid_load_data);
            this.Controls.Add(this.btn_loadall_load_data);
            this.Controls.Add(this.btn_headpid_load_data);
            this.Controls.Add(this.btn_cancel_load_data);
            this.Controls.Add(this.tb_numb_data);
            this.Controls.Add(this.tb_last_pid);
            this.Controls.Add(this.tb_head_pid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "load_data";
            this.ShowIcon = false;
            this.Text = "Loading Data";
            this.Load += new System.EventHandler(this.load_data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_head_pid;
        public System.Windows.Forms.TextBox tb_last_pid;
        public System.Windows.Forms.TextBox tb_numb_data;
        private System.Windows.Forms.Button btn_cancel_load_data;
        private System.Windows.Forms.Button btn_headpid_load_data;
        public System.Windows.Forms.Button btn_loadall_load_data;
        private System.Windows.Forms.Label lbl_haed_pid_load_data;
        private System.Windows.Forms.Label lbl_last_pid_load_data;
        private System.Windows.Forms.Label lbl_numb_data_load_data;
    }
}