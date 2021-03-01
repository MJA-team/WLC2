namespace ADM_WLC.conv_result
{
    partial class pid_list
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
            this.lb_pid_list = new System.Windows.Forms.ListBox();
            this.lbl_pid_list = new System.Windows.Forms.Label();
            this.btn_cancel_pid_list = new System.Windows.Forms.Button();
            this.btn_ok_pid_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_pid_list
            // 
            this.lb_pid_list.FormattingEnabled = true;
            this.lb_pid_list.Location = new System.Drawing.Point(12, 38);
            this.lb_pid_list.Name = "lb_pid_list";
            this.lb_pid_list.Size = new System.Drawing.Size(280, 433);
            this.lb_pid_list.TabIndex = 0;
            this.lb_pid_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_pid_list_DrawItem);
            // 
            // lbl_pid_list
            // 
            this.lbl_pid_list.AutoSize = true;
            this.lbl_pid_list.Location = new System.Drawing.Point(12, 9);
            this.lbl_pid_list.Name = "lbl_pid_list";
            this.lbl_pid_list.Size = new System.Drawing.Size(25, 13);
            this.lbl_pid_list.TabIndex = 1;
            this.lbl_pid_list.Text = "PID";
            // 
            // btn_cancel_pid_list
            // 
            this.btn_cancel_pid_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_pid_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_pid_list.Location = new System.Drawing.Point(171, 512);
            this.btn_cancel_pid_list.Name = "btn_cancel_pid_list";
            this.btn_cancel_pid_list.Size = new System.Drawing.Size(121, 51);
            this.btn_cancel_pid_list.TabIndex = 21;
            this.btn_cancel_pid_list.Text = "Cancel";
            this.btn_cancel_pid_list.UseVisualStyleBackColor = true;
            this.btn_cancel_pid_list.Click += new System.EventHandler(this.btn_cancel_pid_list_Click);
            // 
            // btn_ok_pid_list
            // 
            this.btn_ok_pid_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok_pid_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_pid_list.Location = new System.Drawing.Point(12, 512);
            this.btn_ok_pid_list.Name = "btn_ok_pid_list";
            this.btn_ok_pid_list.Size = new System.Drawing.Size(121, 51);
            this.btn_ok_pid_list.TabIndex = 22;
            this.btn_ok_pid_list.Text = "OK";
            this.btn_ok_pid_list.UseVisualStyleBackColor = true;
            this.btn_ok_pid_list.Click += new System.EventHandler(this.btn_ok_pid_list_Click);
            // 
            // pid_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 595);
            this.Controls.Add(this.btn_ok_pid_list);
            this.Controls.Add(this.btn_cancel_pid_list);
            this.Controls.Add(this.lbl_pid_list);
            this.Controls.Add(this.lb_pid_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pid_list";
            this.ShowIcon = false;
            this.Text = "PIDSelect";
            this.Load += new System.EventHandler(this.pid_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_pid_list;
        private System.Windows.Forms.Label lbl_pid_list;
        private System.Windows.Forms.Button btn_cancel_pid_list;
        private System.Windows.Forms.Button btn_ok_pid_list;
    }
}