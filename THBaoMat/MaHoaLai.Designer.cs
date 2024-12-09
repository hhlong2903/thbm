
namespace THBaoMat
{
    partial class MaHoaLai
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
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.btnLuuKhoa = new System.Windows.Forms.Button();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.btnOpenPrivateKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Doc = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_timK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.NumericUpDown();
            this.btnMaHoaKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_key)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(421, 190);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(167, 36);
            this.btnGiaiMa.TabIndex = 82;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // btnLuuKhoa
            // 
            this.btnLuuKhoa.Location = new System.Drawing.Point(421, 76);
            this.btnLuuKhoa.Name = "btnLuuKhoa";
            this.btnLuuKhoa.Size = new System.Drawing.Size(167, 36);
            this.btnLuuKhoa.TabIndex = 81;
            this.btnLuuKhoa.Text = "Lưu khoá";
            this.btnLuuKhoa.UseVisualStyleBackColor = true;
            this.btnLuuKhoa.Click += new System.EventHandler(this.btnLuuKhoa_Click);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(33, 195);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(381, 27);
            this.txtPrivateKey.TabIndex = 80;
            // 
            // btnOpenPrivateKey
            // 
            this.btnOpenPrivateKey.Location = new System.Drawing.Point(130, 157);
            this.btnOpenPrivateKey.Name = "btnOpenPrivateKey";
            this.btnOpenPrivateKey.Size = new System.Drawing.Size(127, 31);
            this.btnOpenPrivateKey.TabIndex = 79;
            this.btnOpenPrivateKey.Text = "open private key";
            this.btnOpenPrivateKey.UseVisualStyleBackColor = true;
            this.btnOpenPrivateKey.Click += new System.EventHandler(this.btnOpenPrivateKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Private key";
            // 
            // btn_Doc
            // 
            this.btn_Doc.Location = new System.Drawing.Point(636, 132);
            this.btn_Doc.Name = "btn_Doc";
            this.btn_Doc.Size = new System.Drawing.Size(167, 36);
            this.btn_Doc.TabIndex = 73;
            this.btn_Doc.Text = "Đọc";
            this.btn_Doc.UseVisualStyleBackColor = true;
            this.btn_Doc.Click += new System.EventHandler(this.btn_Doc_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(636, 76);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(167, 36);
            this.btn_luu.TabIndex = 72;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(421, 132);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(167, 36);
            this.btnMaHoa.TabIndex = 71;
            this.btnMaHoa.Text = "Mã hoá";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Location = new System.Drawing.Point(16, 248);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.RowHeadersWidth = 51;
            this.dgv_khachhang.RowTemplate.Height = 24;
            this.dgv_khachhang.Size = new System.Drawing.Size(787, 432);
            this.dgv_khachhang.TabIndex = 70;
            // 
            // txt_d
            // 
            this.txt_d.Enabled = false;
            this.txt_d.Location = new System.Drawing.Point(297, 35);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(55, 22);
            this.txt_d.TabIndex = 88;
            // 
            // txt_e
            // 
            this.txt_e.Enabled = false;
            this.txt_e.Location = new System.Drawing.Point(174, 35);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(56, 22);
            this.txt_e.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "d";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 85;
            this.label6.Text = "e";
            // 
            // txt_n1
            // 
            this.txt_n1.Enabled = false;
            this.txt_n1.Location = new System.Drawing.Point(69, 35);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(57, 22);
            this.txt_n1.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "n";
            // 
            // btn_timK
            // 
            this.btn_timK.Location = new System.Drawing.Point(421, 25);
            this.btn_timK.Name = "btn_timK";
            this.btn_timK.Size = new System.Drawing.Size(167, 36);
            this.btn_timK.TabIndex = 89;
            this.btn_timK.Text = "Tìm khóa";
            this.btn_timK.UseVisualStyleBackColor = true;
            this.btn_timK.Click += new System.EventHandler(this.btn_timK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "key";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(69, 115);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(120, 22);
            this.txt_key.TabIndex = 93;
            // 
            // btnMaHoaKey
            // 
            this.btnMaHoaKey.Location = new System.Drawing.Point(218, 111);
            this.btnMaHoaKey.Name = "btnMaHoaKey";
            this.btnMaHoaKey.Size = new System.Drawing.Size(115, 28);
            this.btnMaHoaKey.TabIndex = 94;
            this.btnMaHoaKey.Text = "Mã hoá khoá";
            this.btnMaHoaKey.UseVisualStyleBackColor = true;
            this.btnMaHoaKey.Click += new System.EventHandler(this.btnMaHoaKey_Click);
            // 
            // MaHoaLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 693);
            this.Controls.Add(this.btnMaHoaKey);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_timK);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.txt_e);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnLuuKhoa);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.btnOpenPrivateKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Doc);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.dgv_khachhang);
            this.Name = "MaHoaLai";
            this.Text = "MaHoaLai";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Button btnLuuKhoa;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Button btnOpenPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Doc;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.DataGridView dgv_khachhang;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_timK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_key;
        private System.Windows.Forms.Button btnMaHoaKey;
    }
}