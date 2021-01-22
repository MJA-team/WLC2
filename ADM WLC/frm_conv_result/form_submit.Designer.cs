namespace ADM_WLC.conv_result
{
    partial class form_submit
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
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_ok_password = new System.Windows.Forms.Button();
            this.btn_cancel_password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(53, 43);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(125, 40);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(178, 20);
            this.tb_password.TabIndex = 1;
            // 
            // btn_ok_password
            // 
            this.btn_ok_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_password.Location = new System.Drawing.Point(71, 93);
            this.btn_ok_password.Name = "btn_ok_password";
            this.btn_ok_password.Size = new System.Drawing.Size(95, 37);
            this.btn_ok_password.TabIndex = 21;
            this.btn_ok_password.Text = "OK";
            this.btn_ok_password.UseVisualStyleBackColor = true;
            // 
            // btn_cancel_password
            // 
            this.btn_cancel_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_password.Location = new System.Drawing.Point(185, 93);
            this.btn_cancel_password.Name = "btn_cancel_password";
            this.btn_cancel_password.Size = new System.Drawing.Size(95, 37);
            this.btn_cancel_password.TabIndex = 22;
            this.btn_cancel_password.Text = "Cancel";
            this.btn_cancel_password.UseVisualStyleBackColor = true;
            this.btn_cancel_password.Click += new System.EventHandler(this.btn_cancel_password_Click);
            // 
            // form_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 161);
            this.Controls.Add(this.btn_cancel_password);
            this.Controls.Add(this.btn_ok_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_password";
            this.ShowIcon = false;
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_ok_password;
        private System.Windows.Forms.Button btn_cancel_password;
    }
}