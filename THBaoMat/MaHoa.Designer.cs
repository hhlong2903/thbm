
namespace THBaoMat
{
    partial class MaHoa
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
            this.content_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.btn_RSADB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_TaoKhoaRSA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_maHoaLai = new System.Windows.Forms.Button();
            this.btn_DESFile = new System.Windows.Forms.Button();
            this.btn_DES = new System.Windows.Forms.Button();
            this.btn_RSA = new System.Windows.Forms.Button();
            this.btn_maHoaNhan = new System.Windows.Forms.Button();
            this.btn_maHoaCongDB = new System.Windows.Forms.Button();
            this.btn_maHoaNhanDB = new System.Windows.Forms.Button();
            this.btn_maHoaCong = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // content_panel
            // 
            this.content_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content_panel.Location = new System.Drawing.Point(307, 4);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(1127, 657);
            this.content_panel.TabIndex = 3;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.btn_RSADB);
            this.main_panel.Controls.Add(this.button2);
            this.main_panel.Controls.Add(this.btn_TaoKhoaRSA);
            this.main_panel.Controls.Add(this.button1);
            this.main_panel.Controls.Add(this.btn_maHoaLai);
            this.main_panel.Controls.Add(this.btn_DESFile);
            this.main_panel.Controls.Add(this.btn_DES);
            this.main_panel.Controls.Add(this.btn_RSA);
            this.main_panel.Controls.Add(this.btn_maHoaNhan);
            this.main_panel.Controls.Add(this.btn_maHoaCongDB);
            this.main_panel.Controls.Add(this.content_panel);
            this.main_panel.Controls.Add(this.btn_maHoaNhanDB);
            this.main_panel.Controls.Add(this.btn_maHoaCong);
            this.main_panel.Location = new System.Drawing.Point(1, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1437, 664);
            this.main_panel.TabIndex = 3;
            // 
            // btn_RSADB
            // 
            this.btn_RSADB.Location = new System.Drawing.Point(3, 334);
            this.btn_RSADB.Name = "btn_RSADB";
            this.btn_RSADB.Size = new System.Drawing.Size(146, 60);
            this.btn_RSADB.TabIndex = 12;
            this.btn_RSADB.Text = "Mã hóa RSA DB";
            this.btn_RSADB.UseVisualStyleBackColor = true;
            this.btn_RSADB.Click += new System.EventHandler(this.btn_RSADB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "RSA Crypto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_TaoKhoaRSA
            // 
            this.btn_TaoKhoaRSA.Location = new System.Drawing.Point(155, 334);
            this.btn_TaoKhoaRSA.Name = "btn_TaoKhoaRSA";
            this.btn_TaoKhoaRSA.Size = new System.Drawing.Size(146, 60);
            this.btn_TaoKhoaRSA.TabIndex = 10;
            this.btn_TaoKhoaRSA.Text = "Tạo khoá RSA";
            this.btn_TaoKhoaRSA.UseVisualStyleBackColor = true;
            this.btn_TaoKhoaRSA.Click += new System.EventHandler(this.btn_TaoKhoaRSA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tìm số nghịch đảo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_maHoaLai
            // 
            this.btn_maHoaLai.Location = new System.Drawing.Point(3, 466);
            this.btn_maHoaLai.Name = "btn_maHoaLai";
            this.btn_maHoaLai.Size = new System.Drawing.Size(146, 60);
            this.btn_maHoaLai.TabIndex = 8;
            this.btn_maHoaLai.Text = "Mã hóa Lai";
            this.btn_maHoaLai.UseVisualStyleBackColor = true;
            this.btn_maHoaLai.Click += new System.EventHandler(this.btn_maHoaLai_Click);
            // 
            // btn_DESFile
            // 
            this.btn_DESFile.Location = new System.Drawing.Point(155, 400);
            this.btn_DESFile.Name = "btn_DESFile";
            this.btn_DESFile.Size = new System.Drawing.Size(146, 60);
            this.btn_DESFile.TabIndex = 7;
            this.btn_DESFile.Text = "Mã hóa DES File";
            this.btn_DESFile.UseVisualStyleBackColor = true;
            this.btn_DESFile.Click += new System.EventHandler(this.btn_DESFile_Click);
            // 
            // btn_DES
            // 
            this.btn_DES.Location = new System.Drawing.Point(3, 400);
            this.btn_DES.Name = "btn_DES";
            this.btn_DES.Size = new System.Drawing.Size(146, 60);
            this.btn_DES.TabIndex = 6;
            this.btn_DES.Text = "Mã hóa DES";
            this.btn_DES.UseVisualStyleBackColor = true;
            this.btn_DES.Click += new System.EventHandler(this.btn_DES_Click);
            // 
            // btn_RSA
            // 
            this.btn_RSA.Location = new System.Drawing.Point(3, 268);
            this.btn_RSA.Name = "btn_RSA";
            this.btn_RSA.Size = new System.Drawing.Size(146, 60);
            this.btn_RSA.TabIndex = 5;
            this.btn_RSA.Text = "Mã hóa RSA";
            this.btn_RSA.UseVisualStyleBackColor = true;
            this.btn_RSA.Click += new System.EventHandler(this.btn_RSA_Click);
            // 
            // btn_maHoaNhan
            // 
            this.btn_maHoaNhan.Location = new System.Drawing.Point(3, 136);
            this.btn_maHoaNhan.Name = "btn_maHoaNhan";
            this.btn_maHoaNhan.Size = new System.Drawing.Size(146, 60);
            this.btn_maHoaNhan.TabIndex = 2;
            this.btn_maHoaNhan.Text = "Mã hoá Nhân";
            this.btn_maHoaNhan.UseVisualStyleBackColor = true;
            this.btn_maHoaNhan.Click += new System.EventHandler(this.btn_maHoaNhan_Click);
            // 
            // btn_maHoaCongDB
            // 
            this.btn_maHoaCongDB.Location = new System.Drawing.Point(3, 70);
            this.btn_maHoaCongDB.Name = "btn_maHoaCongDB";
            this.btn_maHoaCongDB.Size = new System.Drawing.Size(146, 60);
            this.btn_maHoaCongDB.TabIndex = 4;
            this.btn_maHoaCongDB.Text = "Mã hóa cộng DB";
            this.btn_maHoaCongDB.UseVisualStyleBackColor = true;
            this.btn_maHoaCongDB.Click += new System.EventHandler(this.btn_maHoaCongDB_Click);
            // 
            // btn_maHoaNhanDB
            // 
            this.btn_maHoaNhanDB.Location = new System.Drawing.Point(3, 202);
            this.btn_maHoaNhanDB.Name = "btn_maHoaNhanDB";
            this.btn_maHoaNhanDB.Size = new System.Drawing.Size(146, 60);
            this.btn_maHoaNhanDB.TabIndex = 1;
            this.btn_maHoaNhanDB.Text = "Mã hóa Nhân DB";
            this.btn_maHoaNhanDB.UseVisualStyleBackColor = true;
            this.btn_maHoaNhanDB.Click += new System.EventHandler(this.btn_maHoaNhanDB_Click);
            // 
            // btn_maHoaCong
            // 
            this.btn_maHoaCong.Location = new System.Drawing.Point(3, 4);
            this.btn_maHoaCong.Name = "btn_maHoaCong";
            this.btn_maHoaCong.Size = new System.Drawing.Size(146, 60);
            this.btn_maHoaCong.TabIndex = 0;
            this.btn_maHoaCong.Text = "Mã hóa cộng";
            this.btn_maHoaCong.UseVisualStyleBackColor = true;
            this.btn_maHoaCong.Click += new System.EventHandler(this.btn_maHoaCong_Click);
            // 
            // MaHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 689);
            this.Controls.Add(this.main_panel);
            this.Name = "MaHoa";
            this.Text = "MaHoa";
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button btn_maHoaNhan;
        private System.Windows.Forms.Button btn_maHoaNhanDB;
        private System.Windows.Forms.Button btn_maHoaCong;
        private System.Windows.Forms.Button btn_maHoaCongDB;
        private System.Windows.Forms.Button btn_maHoaLai;
        private System.Windows.Forms.Button btn_DESFile;
        private System.Windows.Forms.Button btn_DES;
        private System.Windows.Forms.Button btn_RSA;
        private System.Windows.Forms.Button btn_TaoKhoaRSA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_RSADB;
    }
}