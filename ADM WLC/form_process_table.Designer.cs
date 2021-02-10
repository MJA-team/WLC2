namespace ADM_WLC
{
    partial class form_process_table
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
            this.btn_close_process_table = new System.Windows.Forms.Button();
            this.dataGridView_process_table = new System.Windows.Forms.DataGridView();
            this.btn_prev_process_table = new System.Windows.Forms.Button();
            this.btn_next_process_table = new System.Windows.Forms.Button();
            this.btn_export_process_table = new System.Windows.Forms.Button();
            this.btn_import_process_table = new System.Windows.Forms.Button();
            this.btn_submit_process_table = new System.Windows.Forms.Button();
            this.btn_refreh_process_table = new System.Windows.Forms.Button();
            this.lbl_cclink_no_process_table = new System.Windows.Forms.Label();
            this.comboBox_cclink_no_process_table = new System.Windows.Forms.ComboBox();
            this.cc_link_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sa_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normal_reverse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin_reverse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin_of_adv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin_of_delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cut_off = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_process_table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close_process_table
            // 
            this.btn_close_process_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close_process_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_process_table.Location = new System.Drawing.Point(1163, 630);
            this.btn_close_process_table.Name = "btn_close_process_table";
            this.btn_close_process_table.Size = new System.Drawing.Size(121, 51);
            this.btn_close_process_table.TabIndex = 39;
            this.btn_close_process_table.Text = "Close";
            this.btn_close_process_table.UseVisualStyleBackColor = true;
            this.btn_close_process_table.Click += new System.EventHandler(this.btn_close_process_table_Click);
            // 
            // dataGridView_process_table
            // 
            this.dataGridView_process_table.AllowUserToAddRows = false;
            this.dataGridView_process_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_process_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_process_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cc_link_no,
            this.id,
            this.stno,
            this.sa_name,
            this.process_name,
            this.process_type,
            this.normal_reverse,
            this.margin_reverse,
            this.depth,
            this.margin_of_adv,
            this.margin_of_delay,
            this.cut_off,
            this.memo,
            this.end});
            this.dataGridView_process_table.Location = new System.Drawing.Point(2, 50);
            this.dataGridView_process_table.Name = "dataGridView_process_table";
            this.dataGridView_process_table.ReadOnly = true;
            this.dataGridView_process_table.Size = new System.Drawing.Size(1282, 574);
            this.dataGridView_process_table.TabIndex = 40;
            this.dataGridView_process_table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_process_table_CellEndEdit);
            this.dataGridView_process_table.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_process_table_RowPostPaint);
            // 
            // btn_prev_process_table
            // 
            this.btn_prev_process_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_prev_process_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev_process_table.Location = new System.Drawing.Point(2, 630);
            this.btn_prev_process_table.Name = "btn_prev_process_table";
            this.btn_prev_process_table.Size = new System.Drawing.Size(121, 51);
            this.btn_prev_process_table.TabIndex = 41;
            this.btn_prev_process_table.Text = "< Prev";
            this.btn_prev_process_table.UseVisualStyleBackColor = true;
            this.btn_prev_process_table.Click += new System.EventHandler(this.btn_prev_process_table_Click);
            // 
            // btn_next_process_table
            // 
            this.btn_next_process_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_next_process_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next_process_table.Location = new System.Drawing.Point(129, 630);
            this.btn_next_process_table.Name = "btn_next_process_table";
            this.btn_next_process_table.Size = new System.Drawing.Size(121, 51);
            this.btn_next_process_table.TabIndex = 42;
            this.btn_next_process_table.Text = "Next >";
            this.btn_next_process_table.UseVisualStyleBackColor = true;
            this.btn_next_process_table.Click += new System.EventHandler(this.btn_next_process_table_Click);
            // 
            // btn_export_process_table
            // 
            this.btn_export_process_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_export_process_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_process_table.Location = new System.Drawing.Point(256, 630);
            this.btn_export_process_table.Name = "btn_export_process_table";
            this.btn_export_process_table.Size = new System.Drawing.Size(121, 51);
            this.btn_export_process_table.TabIndex = 43;
            this.btn_export_process_table.Text = "Export";
            this.btn_export_process_table.UseVisualStyleBackColor = true;
            this.btn_export_process_table.Click += new System.EventHandler(this.btn_export_process_table_Click);
            // 
            // btn_import_process_table
            // 
            this.btn_import_process_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_import_process_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import_process_table.Location = new System.Drawing.Point(383, 630);
            this.btn_import_process_table.Name = "btn_import_process_table";
            this.btn_import_process_table.Size = new System.Drawing.Size(121, 51);
            this.btn_import_process_table.TabIndex = 44;
            this.btn_import_process_table.Text = "Import";
            this.btn_import_process_table.UseVisualStyleBackColor = true;
            this.btn_import_process_table.Click += new System.EventHandler(this.btn_import_process_table_Click);
            // 
            // btn_submit_process_table
            // 
            this.btn_submit_process_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_submit_process_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit_process_table.Location = new System.Drawing.Point(510, 630);
            this.btn_submit_process_table.Name = "btn_submit_process_table";
            this.btn_submit_process_table.Size = new System.Drawing.Size(121, 51);
            this.btn_submit_process_table.TabIndex = 45;
            this.btn_submit_process_table.Text = "Submit";
            this.btn_submit_process_table.UseVisualStyleBackColor = true;
            this.btn_submit_process_table.Click += new System.EventHandler(this.btn_submit_process_table_Click);
            // 
            // btn_refreh_process_table
            // 
            this.btn_refreh_process_table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refreh_process_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreh_process_table.Location = new System.Drawing.Point(637, 630);
            this.btn_refreh_process_table.Name = "btn_refreh_process_table";
            this.btn_refreh_process_table.Size = new System.Drawing.Size(121, 51);
            this.btn_refreh_process_table.TabIndex = 47;
            this.btn_refreh_process_table.Text = "Refresh";
            this.btn_refreh_process_table.UseVisualStyleBackColor = true;
            this.btn_refreh_process_table.Click += new System.EventHandler(this.btn_refreh_process_table_Click);
            // 
            // lbl_cclink_no_process_table
            // 
            this.lbl_cclink_no_process_table.AutoSize = true;
            this.lbl_cclink_no_process_table.Location = new System.Drawing.Point(-1, 20);
            this.lbl_cclink_no_process_table.Name = "lbl_cclink_no_process_table";
            this.lbl_cclink_no_process_table.Size = new System.Drawing.Size(64, 13);
            this.lbl_cclink_no_process_table.TabIndex = 50;
            this.lbl_cclink_no_process_table.Text = "CC Link No.";
            // 
            // comboBox_cclink_no_process_table
            // 
            this.comboBox_cclink_no_process_table.FormattingEnabled = true;
            this.comboBox_cclink_no_process_table.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_cclink_no_process_table.Location = new System.Drawing.Point(69, 17);
            this.comboBox_cclink_no_process_table.Name = "comboBox_cclink_no_process_table";
            this.comboBox_cclink_no_process_table.Size = new System.Drawing.Size(65, 21);
            this.comboBox_cclink_no_process_table.TabIndex = 51;
            this.comboBox_cclink_no_process_table.SelectedIndexChanged += new System.EventHandler(this.comboBox_cclink_no_process_table_SelectedIndexChanged);
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
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // stno
            // 
            this.stno.DataPropertyName = "stno";
            this.stno.HeaderText = "Station No";
            this.stno.Name = "stno";
            this.stno.ReadOnly = true;
            this.stno.Visible = false;
            // 
            // sa_name
            // 
            this.sa_name.DataPropertyName = "sa_name";
            this.sa_name.HeaderText = "S/A Name";
            this.sa_name.Name = "sa_name";
            this.sa_name.ReadOnly = true;
            this.sa_name.Width = 50;
            // 
            // process_name
            // 
            this.process_name.DataPropertyName = "process_name";
            this.process_name.HeaderText = "Process Name";
            this.process_name.Name = "process_name";
            this.process_name.ReadOnly = true;
            this.process_name.Width = 200;
            // 
            // process_type
            // 
            this.process_type.DataPropertyName = "process_type";
            this.process_type.HeaderText = "Process Type";
            this.process_type.Name = "process_type";
            this.process_type.ReadOnly = true;
            // 
            // normal_reverse
            // 
            this.normal_reverse.DataPropertyName = "normal_reverse";
            this.normal_reverse.HeaderText = "Normal Reverse";
            this.normal_reverse.Name = "normal_reverse";
            this.normal_reverse.ReadOnly = true;
            // 
            // margin_reverse
            // 
            this.margin_reverse.DataPropertyName = "margin_reverse";
            this.margin_reverse.HeaderText = "Margin Reverse";
            this.margin_reverse.Name = "margin_reverse";
            this.margin_reverse.ReadOnly = true;
            // 
            // depth
            // 
            this.depth.DataPropertyName = "depth";
            this.depth.HeaderText = "Depth";
            this.depth.Name = "depth";
            this.depth.ReadOnly = true;
            // 
            // margin_of_adv
            // 
            this.margin_of_adv.DataPropertyName = "margin_of_adv";
            this.margin_of_adv.HeaderText = "Margin of Advance";
            this.margin_of_adv.Name = "margin_of_adv";
            this.margin_of_adv.ReadOnly = true;
            // 
            // margin_of_delay
            // 
            this.margin_of_delay.DataPropertyName = "margin_of_delay";
            this.margin_of_delay.HeaderText = "Margin of Delay";
            this.margin_of_delay.Name = "margin_of_delay";
            this.margin_of_delay.ReadOnly = true;
            // 
            // cut_off
            // 
            this.cut_off.DataPropertyName = "cut_off";
            this.cut_off.HeaderText = "Cut Off";
            this.cut_off.Name = "cut_off";
            this.cut_off.ReadOnly = true;
            // 
            // memo
            // 
            this.memo.DataPropertyName = "memo";
            this.memo.HeaderText = "Memo";
            this.memo.Name = "memo";
            this.memo.ReadOnly = true;
            this.memo.Width = 150;
            // 
            // end
            // 
            this.end.DataPropertyName = "end";
            this.end.HeaderText = "";
            this.end.Name = "end";
            this.end.ReadOnly = true;
            this.end.Visible = false;
            // 
            // form_process_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1287, 684);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox_cclink_no_process_table);
            this.Controls.Add(this.lbl_cclink_no_process_table);
            this.Controls.Add(this.btn_refreh_process_table);
            this.Controls.Add(this.btn_submit_process_table);
            this.Controls.Add(this.btn_import_process_table);
            this.Controls.Add(this.btn_export_process_table);
            this.Controls.Add(this.btn_next_process_table);
            this.Controls.Add(this.btn_prev_process_table);
            this.Controls.Add(this.dataGridView_process_table);
            this.Controls.Add(this.btn_close_process_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_process_table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_process_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_process_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close_process_table;
        private System.Windows.Forms.DataGridView dataGridView_process_table;
        private System.Windows.Forms.Button btn_prev_process_table;
        private System.Windows.Forms.Button btn_next_process_table;
        private System.Windows.Forms.Button btn_export_process_table;
        private System.Windows.Forms.Button btn_import_process_table;
        private System.Windows.Forms.Button btn_submit_process_table;
        private System.Windows.Forms.Button btn_refreh_process_table;
        private System.Windows.Forms.Label lbl_cclink_no_process_table;
        private System.Windows.Forms.ComboBox comboBox_cclink_no_process_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc_link_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sa_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn normal_reverse;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin_reverse;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin_of_adv;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin_of_delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cut_off;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
    }
}