namespace ADM_WLC
{
    partial class form_wlc_data
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_close_wlc_data = new System.Windows.Forms.Button();
            this.btn_alldelete_wlc_data = new System.Windows.Forms.Button();
            this.dataGridView_wlc_data = new System.Windows.Forms.DataGridView();
            this.btn_dataloading_wlc_data = new System.Windows.Forms.Button();
            this.btn_suspend_wlc_data = new System.Windows.Forms.Button();
            this.btn_suspenddatalist_wlc_data = new System.Windows.Forms.Button();
            this.btn_insert_wlc_data = new System.Windows.Forms.Button();
            this.btn_delete_wlc_data = new System.Windows.Forms.Button();
            this.btn_deleteplan_wlc_data = new System.Windows.Forms.Button();
            this.pnl_suspend_data_list_wlc_data = new System.Windows.Forms.Panel();
            this.seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wlc_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassis_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wlc_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close_wlc_data
            // 
            this.btn_close_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close_wlc_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_wlc_data.Location = new System.Drawing.Point(1163, 630);
            this.btn_close_wlc_data.Name = "btn_close_wlc_data";
            this.btn_close_wlc_data.Size = new System.Drawing.Size(121, 51);
            this.btn_close_wlc_data.TabIndex = 2;
            this.btn_close_wlc_data.Text = "Close";
            this.btn_close_wlc_data.UseVisualStyleBackColor = true;
            this.btn_close_wlc_data.Click += new System.EventHandler(this.btn_close_wlc_data_Click);
            // 
            // btn_alldelete_wlc_data
            // 
            this.btn_alldelete_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_alldelete_wlc_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alldelete_wlc_data.Location = new System.Drawing.Point(1036, 630);
            this.btn_alldelete_wlc_data.Name = "btn_alldelete_wlc_data";
            this.btn_alldelete_wlc_data.Size = new System.Drawing.Size(121, 51);
            this.btn_alldelete_wlc_data.TabIndex = 3;
            this.btn_alldelete_wlc_data.Text = "All Delete";
            this.btn_alldelete_wlc_data.UseVisualStyleBackColor = true;
            this.btn_alldelete_wlc_data.Click += new System.EventHandler(this.btn_alldelete_wlc_data_Click);
            // 
            // dataGridView_wlc_data
            // 
            this.dataGridView_wlc_data.AllowUserToAddRows = false;
            this.dataGridView_wlc_data.AllowUserToDeleteRows = false;
            this.dataGridView_wlc_data.AllowUserToOrderColumns = true;
            this.dataGridView_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_wlc_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_wlc_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wlc_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seq,
            this.pid,
            this.vin,
            this.plan_date,
            this.wlc_code,
            this.model_code,
            this.suffix,
            this.chassis_number,
            this.classification});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_wlc_data.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_wlc_data.Location = new System.Drawing.Point(2, 48);
            this.dataGridView_wlc_data.Name = "dataGridView_wlc_data";
            this.dataGridView_wlc_data.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_wlc_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_wlc_data.RowHeadersVisible = false;
            this.dataGridView_wlc_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_wlc_data.Size = new System.Drawing.Size(961, 576);
            this.dataGridView_wlc_data.TabIndex = 4;
            this.dataGridView_wlc_data.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_wlc_data_CellFormatting);
            this.dataGridView_wlc_data.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_wlc_data_RowPostPaint);
            // 
            // btn_dataloading_wlc_data
            // 
            this.btn_dataloading_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_dataloading_wlc_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dataloading_wlc_data.Location = new System.Drawing.Point(2, 630);
            this.btn_dataloading_wlc_data.Name = "btn_dataloading_wlc_data";
            this.btn_dataloading_wlc_data.Size = new System.Drawing.Size(127, 51);
            this.btn_dataloading_wlc_data.TabIndex = 5;
            this.btn_dataloading_wlc_data.Text = "Data Loading";
            this.btn_dataloading_wlc_data.UseVisualStyleBackColor = true;
            this.btn_dataloading_wlc_data.Click += new System.EventHandler(this.btn_dataloading_wlc_data_Click);
            // 
            // btn_suspend_wlc_data
            // 
            this.btn_suspend_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_suspend_wlc_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suspend_wlc_data.Location = new System.Drawing.Point(135, 630);
            this.btn_suspend_wlc_data.Name = "btn_suspend_wlc_data";
            this.btn_suspend_wlc_data.Size = new System.Drawing.Size(121, 51);
            this.btn_suspend_wlc_data.TabIndex = 6;
            this.btn_suspend_wlc_data.Text = "Suspend";
            this.btn_suspend_wlc_data.UseVisualStyleBackColor = true;
            this.btn_suspend_wlc_data.Click += new System.EventHandler(this.btn_suspend_wlc_data_Click);
            // 
            // btn_suspenddatalist_wlc_data
            // 
            this.btn_suspenddatalist_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_suspenddatalist_wlc_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suspenddatalist_wlc_data.Location = new System.Drawing.Point(262, 630);
            this.btn_suspenddatalist_wlc_data.Name = "btn_suspenddatalist_wlc_data";
            this.btn_suspenddatalist_wlc_data.Size = new System.Drawing.Size(170, 51);
            this.btn_suspenddatalist_wlc_data.TabIndex = 7;
            this.btn_suspenddatalist_wlc_data.Text = "Suspend Data List";
            this.btn_suspenddatalist_wlc_data.UseVisualStyleBackColor = true;
            this.btn_suspenddatalist_wlc_data.Click += new System.EventHandler(this.btn_suspenddatalist_wlc_data_Click);
            // 
            // btn_insert_wlc_data
            // 
            this.btn_insert_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_insert_wlc_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_wlc_data.Location = new System.Drawing.Point(438, 630);
            this.btn_insert_wlc_data.Name = "btn_insert_wlc_data";
            this.btn_insert_wlc_data.Size = new System.Drawing.Size(121, 51);
            this.btn_insert_wlc_data.TabIndex = 8;
            this.btn_insert_wlc_data.Text = "Insert";
            this.btn_insert_wlc_data.UseVisualStyleBackColor = true;
            this.btn_insert_wlc_data.Click += new System.EventHandler(this.btn_insert_wlc_data_Click);
            // 
            // btn_delete_wlc_data
            // 
            this.btn_delete_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete_wlc_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_wlc_data.Location = new System.Drawing.Point(565, 630);
            this.btn_delete_wlc_data.Name = "btn_delete_wlc_data";
            this.btn_delete_wlc_data.Size = new System.Drawing.Size(121, 51);
            this.btn_delete_wlc_data.TabIndex = 9;
            this.btn_delete_wlc_data.Text = "Delete";
            this.btn_delete_wlc_data.UseVisualStyleBackColor = true;
            this.btn_delete_wlc_data.Click += new System.EventHandler(this.btn_delete_wlc_data_Click);
            // 
            // btn_deleteplan_wlc_data
            // 
            this.btn_deleteplan_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deleteplan_wlc_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteplan_wlc_data.Location = new System.Drawing.Point(692, 630);
            this.btn_deleteplan_wlc_data.Name = "btn_deleteplan_wlc_data";
            this.btn_deleteplan_wlc_data.Size = new System.Drawing.Size(121, 51);
            this.btn_deleteplan_wlc_data.TabIndex = 10;
            this.btn_deleteplan_wlc_data.Text = "Delete Plan";
            this.btn_deleteplan_wlc_data.UseVisualStyleBackColor = true;
            this.btn_deleteplan_wlc_data.Click += new System.EventHandler(this.btn_deleteplan_wlc_data_Click);
            // 
            // pnl_suspend_data_list_wlc_data
            // 
            this.pnl_suspend_data_list_wlc_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_suspend_data_list_wlc_data.Location = new System.Drawing.Point(969, 49);
            this.pnl_suspend_data_list_wlc_data.Name = "pnl_suspend_data_list_wlc_data";
            this.pnl_suspend_data_list_wlc_data.Size = new System.Drawing.Size(314, 574);
            this.pnl_suspend_data_list_wlc_data.TabIndex = 12;
            // 
            // seq
            // 
            this.seq.HeaderText = "";
            this.seq.Name = "seq";
            this.seq.ReadOnly = true;
            this.seq.Width = 50;
            // 
            // pid
            // 
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "PID";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // vin
            // 
            this.vin.DataPropertyName = "vin";
            this.vin.HeaderText = "VIN";
            this.vin.Name = "vin";
            this.vin.ReadOnly = true;
            this.vin.Width = 150;
            // 
            // plan_date
            // 
            this.plan_date.DataPropertyName = "plan_date";
            this.plan_date.HeaderText = "Plan Date";
            this.plan_date.Name = "plan_date";
            this.plan_date.ReadOnly = true;
            this.plan_date.Width = 70;
            // 
            // wlc_code
            // 
            this.wlc_code.DataPropertyName = "wlc_code";
            this.wlc_code.HeaderText = "WLC Code";
            this.wlc_code.Name = "wlc_code";
            this.wlc_code.ReadOnly = true;
            this.wlc_code.Width = 70;
            // 
            // model_code
            // 
            this.model_code.DataPropertyName = "model_code";
            this.model_code.HeaderText = "Model Code";
            this.model_code.Name = "model_code";
            this.model_code.ReadOnly = true;
            this.model_code.Width = 70;
            // 
            // suffix
            // 
            this.suffix.DataPropertyName = "suffix";
            this.suffix.HeaderText = "Suffix";
            this.suffix.Name = "suffix";
            this.suffix.ReadOnly = true;
            this.suffix.Width = 70;
            // 
            // chassis_number
            // 
            this.chassis_number.DataPropertyName = "chassis_number";
            this.chassis_number.HeaderText = "Chassis Number";
            this.chassis_number.Name = "chassis_number";
            this.chassis_number.ReadOnly = true;
            this.chassis_number.Width = 150;
            // 
            // classification
            // 
            this.classification.DataPropertyName = "classification";
            this.classification.HeaderText = "Classification";
            this.classification.Name = "classification";
            this.classification.ReadOnly = true;
            this.classification.Width = 150;
            // 
            // form_wlc_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 400);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1287, 684);
            this.Controls.Add(this.pnl_suspend_data_list_wlc_data);
            this.Controls.Add(this.btn_deleteplan_wlc_data);
            this.Controls.Add(this.btn_delete_wlc_data);
            this.Controls.Add(this.btn_insert_wlc_data);
            this.Controls.Add(this.btn_suspenddatalist_wlc_data);
            this.Controls.Add(this.btn_suspend_wlc_data);
            this.Controls.Add(this.btn_dataloading_wlc_data);
            this.Controls.Add(this.dataGridView_wlc_data);
            this.Controls.Add(this.btn_alldelete_wlc_data);
            this.Controls.Add(this.btn_close_wlc_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_wlc_data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_wlc_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wlc_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_close_wlc_data;
        private System.Windows.Forms.Button btn_alldelete_wlc_data;
        public System.Windows.Forms.DataGridView dataGridView_wlc_data;
        private System.Windows.Forms.Button btn_dataloading_wlc_data;
        private System.Windows.Forms.Button btn_suspend_wlc_data;
        private System.Windows.Forms.Button btn_suspenddatalist_wlc_data;
        private System.Windows.Forms.Button btn_insert_wlc_data;
        private System.Windows.Forms.Button btn_delete_wlc_data;
        private System.Windows.Forms.Button btn_deleteplan_wlc_data;
        private System.Windows.Forms.Panel pnl_suspend_data_list_wlc_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vin;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn wlc_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn model_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn suffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassis_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn classification;
    }
}