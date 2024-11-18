namespace THBaoMat
{
    partial class Main
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.btn_cong = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(694, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.btn_nhan);
            this.main_panel.Controls.Add(this.btn_cong);
            this.main_panel.Location = new System.Drawing.Point(1, 44);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(811, 406);
            this.main_panel.TabIndex = 1;
            // 
            // btn_cong
            // 
            this.btn_cong.Location = new System.Drawing.Point(263, 76);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(146, 32);
            this.btn_cong.TabIndex = 0;
            this.btn_cong.Text = "Mã hóa cộng";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Location = new System.Drawing.Point(263, 154);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(146, 32);
            this.btn_nhan.TabIndex = 1;
            this.btn_nhan.Text = "Mã hóa Nhân";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 451);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.btnLogout);
            this.Name = "Main";
            this.Text = "Main";
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.Button btn_cong;
    }
}