﻿
namespace THBaoMat
{
    partial class RSA
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
            this.btn_timK = new System.Windows.Forms.Button();
            this.btn_Doc = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.rd_btnDe = new System.Windows.Forms.RadioButton();
            this.rd_btnEn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_timK
            // 
            this.btn_timK.Location = new System.Drawing.Point(415, 25);
            this.btn_timK.Name = "btn_timK";
            this.btn_timK.Size = new System.Drawing.Size(167, 36);
            this.btn_timK.TabIndex = 47;
            this.btn_timK.Text = "Tìm khóa";
            this.btn_timK.UseVisualStyleBackColor = true;
            this.btn_timK.Click += new System.EventHandler(this.btn_timK_Click);
            // 
            // btn_Doc
            // 
            this.btn_Doc.Location = new System.Drawing.Point(415, 73);
            this.btn_Doc.Name = "btn_Doc";
            this.btn_Doc.Size = new System.Drawing.Size(167, 36);
            this.btn_Doc.TabIndex = 46;
            this.btn_Doc.Text = "Đọc";
            this.btn_Doc.UseVisualStyleBackColor = true;
            this.btn_Doc.Click += new System.EventHandler(this.btn_Doc_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(617, 73);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(167, 36);
            this.btn_luu.TabIndex = 45;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(617, 20);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(167, 47);
            this.btnKetqua.TabIndex = 44;
            this.btnKetqua.Text = "Encrypt Message";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // rd_btnDe
            // 
            this.rd_btnDe.AutoSize = true;
            this.rd_btnDe.Location = new System.Drawing.Point(240, 33);
            this.rd_btnDe.Name = "rd_btnDe";
            this.rd_btnDe.Size = new System.Drawing.Size(78, 21);
            this.rd_btnDe.TabIndex = 43;
            this.rd_btnDe.TabStop = true;
            this.rd_btnDe.Text = "Decrypt";
            this.rd_btnDe.UseVisualStyleBackColor = true;
            this.rd_btnDe.CheckedChanged += new System.EventHandler(this.rd_btnDe_CheckedChanged);
            // 
            // rd_btnEn
            // 
            this.rd_btnEn.AutoSize = true;
            this.rd_btnEn.Location = new System.Drawing.Point(108, 33);
            this.rd_btnEn.Name = "rd_btnEn";
            this.rd_btnEn.Size = new System.Drawing.Size(77, 21);
            this.rd_btnEn.TabIndex = 42;
            this.rd_btnEn.TabStop = true;
            this.rd_btnEn.Text = "Encrypt";
            this.rd_btnEn.UseVisualStyleBackColor = true;
            this.rd_btnEn.CheckedChanged += new System.EventHandler(this.rd_btnEn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Action";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Location = new System.Drawing.Point(12, 115);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.RowHeadersWidth = 51;
            this.dgv_khachhang.RowTemplate.Height = 24;
            this.dgv_khachhang.Size = new System.Drawing.Size(787, 432);
            this.dgv_khachhang.TabIndex = 38;
            this.dgv_khachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khachhang_CellContentClick);
            // 
            // txt_d
            // 
            this.txt_d.Enabled = false;
            this.txt_d.Location = new System.Drawing.Point(281, 73);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(55, 22);
            this.txt_d.TabIndex = 53;
            this.txt_d.TextChanged += new System.EventHandler(this.txt_d_TextChanged);
            // 
            // txt_e
            // 
            this.txt_e.Enabled = false;
            this.txt_e.Location = new System.Drawing.Point(158, 73);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(56, 22);
            this.txt_e.TabIndex = 52;
            this.txt_e.TextChanged += new System.EventHandler(this.txt_e_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "d";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "e";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_n1
            // 
            this.txt_n1.Enabled = false;
            this.txt_n1.Location = new System.Drawing.Point(53, 73);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(57, 22);
            this.txt_n1.TabIndex = 49;
            this.txt_n1.TextChanged += new System.EventHandler(this.txt_n1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 567);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.txt_e);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_timK);
            this.Controls.Add(this.btn_Doc);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.rd_btnDe);
            this.Controls.Add(this.rd_btnEn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_khachhang);
            this.Name = "RSA";
            this.Text = "RSA";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_timK;
        private System.Windows.Forms.Button btn_Doc;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btnKetqua;
        private System.Windows.Forms.RadioButton rd_btnDe;
        private System.Windows.Forms.RadioButton rd_btnEn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_khachhang;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label label4;
    }
}