namespace ADM_WLC
{
    partial class form_menu_button
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_process_status = new System.Windows.Forms.Button();
            this.btn_stamping_result = new System.Windows.Forms.Button();
            this.btn_process_table = new System.Windows.Forms.Button();
            this.btn_wlc_maintenance = new System.Windows.Forms.Button();
            this.btn_conv_result = new System.Windows.Forms.Button();
            this.btn_prod_inst = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.89359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21282F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.89359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_stamping_result, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_prod_inst, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_process_table, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_process_status, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_wlc_maintenance, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_conv_result, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1287, 684);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_process_status
            // 
            this.btn_process_status.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_process_status.BackColor = System.Drawing.SystemColors.Control;
            this.btn_process_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_process_status.Location = new System.Drawing.Point(81, 74);
            this.btn_process_status.Name = "btn_process_status";
            this.btn_process_status.Size = new System.Drawing.Size(458, 79);
            this.btn_process_status.TabIndex = 41;
            this.btn_process_status.Text = "1: Process Status Monitor";
            this.btn_process_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_process_status.UseVisualStyleBackColor = false;
            this.btn_process_status.Click += new System.EventHandler(this.btn_process_status_Click);
            // 
            // btn_stamping_result
            // 
            this.btn_stamping_result.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_stamping_result.BackColor = System.Drawing.SystemColors.Control;
            this.btn_stamping_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stamping_result.Location = new System.Drawing.Point(747, 529);
            this.btn_stamping_result.Name = "btn_stamping_result";
            this.btn_stamping_result.Size = new System.Drawing.Size(458, 79);
            this.btn_stamping_result.TabIndex = 40;
            this.btn_stamping_result.Text = "6: Stamping Result Data Maintenance";
            this.btn_stamping_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stamping_result.UseVisualStyleBackColor = false;
            this.btn_stamping_result.Click += new System.EventHandler(this.btn_stamping_result_Click);
            // 
            // btn_process_table
            // 
            this.btn_process_table.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_process_table.BackColor = System.Drawing.SystemColors.Control;
            this.btn_process_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_process_table.Location = new System.Drawing.Point(747, 301);
            this.btn_process_table.Name = "btn_process_table";
            this.btn_process_table.Size = new System.Drawing.Size(458, 79);
            this.btn_process_table.TabIndex = 39;
            this.btn_process_table.Text = "5: [Master Setting] Process Table";
            this.btn_process_table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_process_table.UseVisualStyleBackColor = false;
            this.btn_process_table.Click += new System.EventHandler(this.btn_process_table_Click);
            // 
            // btn_wlc_maintenance
            // 
            this.btn_wlc_maintenance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_wlc_maintenance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_wlc_maintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wlc_maintenance.Location = new System.Drawing.Point(81, 301);
            this.btn_wlc_maintenance.Name = "btn_wlc_maintenance";
            this.btn_wlc_maintenance.Size = new System.Drawing.Size(458, 79);
            this.btn_wlc_maintenance.TabIndex = 38;
            this.btn_wlc_maintenance.Text = "2: WLC Data Maintenance";
            this.btn_wlc_maintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_wlc_maintenance.UseVisualStyleBackColor = false;
            this.btn_wlc_maintenance.Click += new System.EventHandler(this.btn_wlc_maintenance_Click);
            // 
            // btn_conv_result
            // 
            this.btn_conv_result.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_conv_result.BackColor = System.Drawing.SystemColors.Control;
            this.btn_conv_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conv_result.Location = new System.Drawing.Point(81, 529);
            this.btn_conv_result.Name = "btn_conv_result";
            this.btn_conv_result.Size = new System.Drawing.Size(458, 79);
            this.btn_conv_result.TabIndex = 36;
            this.btn_conv_result.Text = "3: Conversion Result Data Maintenace";
            this.btn_conv_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_conv_result.UseVisualStyleBackColor = false;
            this.btn_conv_result.Click += new System.EventHandler(this.btn_conv_result_Click);
            // 
            // btn_prod_inst
            // 
            this.btn_prod_inst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_prod_inst.BackColor = System.Drawing.SystemColors.Control;
            this.btn_prod_inst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod_inst.Location = new System.Drawing.Point(747, 74);
            this.btn_prod_inst.Name = "btn_prod_inst";
            this.btn_prod_inst.Size = new System.Drawing.Size(458, 79);
            this.btn_prod_inst.TabIndex = 37;
            this.btn_prod_inst.Text = "4: [Master Setting] Production Intruction Code";
            this.btn_prod_inst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prod_inst.UseVisualStyleBackColor = false;
            this.btn_prod_inst.Click += new System.EventHandler(this.btn_prod_inst_Click);
            // 
            // form_menu_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1287, 684);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_menu_button";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_menu_button_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_stamping_result;
        private System.Windows.Forms.Button btn_process_table;
        private System.Windows.Forms.Button btn_wlc_maintenance;
        private System.Windows.Forms.Button btn_conv_result;
        private System.Windows.Forms.Button btn_prod_inst;
        private System.Windows.Forms.Button btn_process_status;
    }
}