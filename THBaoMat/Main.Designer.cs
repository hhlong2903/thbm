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
            this.content_panel = new System.Windows.Forms.Panel();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btn_mahoa = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1324, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 35);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.content_panel);
            this.main_panel.Controls.Add(this.btnSanPham);
            this.main_panel.Controls.Add(this.btn_mahoa);
            this.main_panel.Location = new System.Drawing.Point(1, 44);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1437, 680);
            this.main_panel.TabIndex = 1;
            // 
            // content_panel
            // 
            this.content_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content_panel.Location = new System.Drawing.Point(153, 4);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(1281, 673);
            this.content_panel.TabIndex = 3;
            // 
            // btnSanPham
            // 
            this.btnSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(146, 60);
            this.btnSanPham.TabIndex = 2;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btn_mahoa
            // 
            this.btn_mahoa.Location = new System.Drawing.Point(0, 66);
            this.btn_mahoa.Name = "btn_mahoa";
            this.btn_mahoa.Size = new System.Drawing.Size(146, 60);
            this.btn_mahoa.TabIndex = 1;
            this.btn_mahoa.Text = "Mã hóa";
            this.btn_mahoa.UseVisualStyleBackColor = true;
            this.btn_mahoa.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 726);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.btnLogout);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button btn_mahoa;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Panel content_panel;
    }
}