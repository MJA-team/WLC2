namespace ADM_WLC
{
    partial class Form_menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_name_menu = new System.Windows.Forms.Label();
            this.btn_data_sending = new System.Windows.Forms.Button();
            this.listBox_form_menu = new System.Windows.Forms.ListBox();
            this.btn_data_sending1 = new System.Windows.Forms.Button();
            this.pictureBox_form_menu = new System.Windows.Forms.PictureBox();
            this.lbl_data_sending = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_form_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_header.Controls.Add(this.tableLayoutPanel1);
            this.pnl_header.Controls.Add(this.btn_data_sending);
            this.pnl_header.Controls.Add(this.listBox_form_menu);
            this.pnl_header.Controls.Add(this.btn_data_sending1);
            this.pnl_header.Controls.Add(this.pictureBox_form_menu);
            this.pnl_header.Controls.Add(this.lbl_data_sending);
            this.pnl_header.Controls.Add(this.lbl_time);
            this.pnl_header.Controls.Add(this.lbl_date);
            this.pnl_header.Controls.Add(this.button1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1271, 134);
            this.pnl_header.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_name_menu, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(213, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 128);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // lbl_name_menu
            // 
            this.lbl_name_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_name_menu.AutoSize = true;
            this.lbl_name_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_menu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_name_menu.Location = new System.Drawing.Point(3, 0);
            this.lbl_name_menu.Name = "lbl_name_menu";
            this.lbl_name_menu.Size = new System.Drawing.Size(15, 128);
            this.lbl_name_menu.TabIndex = 40;
            this.lbl_name_menu.Text = "-";
            this.lbl_name_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_data_sending
            // 
            this.btn_data_sending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_data_sending.BackColor = System.Drawing.Color.Red;
            this.btn_data_sending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_sending.Location = new System.Drawing.Point(1040, 64);
            this.btn_data_sending.Name = "btn_data_sending";
            this.btn_data_sending.Size = new System.Drawing.Size(114, 46);
            this.btn_data_sending.TabIndex = 3;
            this.btn_data_sending.Text = "STOP";
            this.btn_data_sending.UseVisualStyleBackColor = false;
            this.btn_data_sending.Click += new System.EventHandler(this.btn_data_sending_Click);
            // 
            // listBox_form_menu
            // 
            this.listBox_form_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_form_menu.FormattingEnabled = true;
            this.listBox_form_menu.Location = new System.Drawing.Point(400, 12);
            this.listBox_form_menu.Name = "listBox_form_menu";
            this.listBox_form_menu.Size = new System.Drawing.Size(575, 108);
            this.listBox_form_menu.TabIndex = 0;
            // 
            // btn_data_sending1
            // 
            this.btn_data_sending1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_data_sending1.BackColor = System.Drawing.Color.Blue;
            this.btn_data_sending1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_sending1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_data_sending1.Location = new System.Drawing.Point(1040, 64);
            this.btn_data_sending1.Name = "btn_data_sending1";
            this.btn_data_sending1.Size = new System.Drawing.Size(114, 46);
            this.btn_data_sending1.TabIndex = 38;
            this.btn_data_sending1.Text = "SENDING";
            this.btn_data_sending1.UseVisualStyleBackColor = false;
            this.btn_data_sending1.Click += new System.EventHandler(this.btn_data_sending1_Click);
            // 
            // pictureBox_form_menu
            // 
            this.pictureBox_form_menu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_form_menu.Image")));
            this.pictureBox_form_menu.Location = new System.Drawing.Point(12, 47);
            this.pictureBox_form_menu.Name = "pictureBox_form_menu";
            this.pictureBox_form_menu.Size = new System.Drawing.Size(183, 43);
            this.pictureBox_form_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_form_menu.TabIndex = 37;
            this.pictureBox_form_menu.TabStop = false;
            // 
            // lbl_data_sending
            // 
            this.lbl_data_sending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_data_sending.AutoSize = true;
            this.lbl_data_sending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data_sending.Location = new System.Drawing.Point(1056, 14);
            this.lbl_data_sending.Name = "lbl_data_sending";
            this.lbl_data_sending.Size = new System.Drawing.Size(84, 13);
            this.lbl_data_sending.TabIndex = 7;
            this.lbl_data_sending.Text = "Data Sending";
            this.lbl_data_sending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(1184, 65);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(30, 13);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "Time";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(1184, 14);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1040, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 46);
            this.button1.TabIndex = 39;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_menu
            // 
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_menu.Location = new System.Drawing.Point(0, 134);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(1271, 511);
            this.pnl_menu.TabIndex = 37;
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1271, 645);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form_menu";
            this.Text = "ADM WL/C Ver. 1.0.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_menu_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_form_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_data_sending;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_data_sending;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_data_sending1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox_form_menu;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.ListBox listBox_form_menu;
        public System.Windows.Forms.Label lbl_name_menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

