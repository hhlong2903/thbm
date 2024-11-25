
namespace THBaoMat
{
    partial class MaHoaCong_Database
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
            this.btn_Doc = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.rd_btnDe = new System.Windows.Forms.RadioButton();
            this.rd_btnEn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.NumericUpDown();
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txt_key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Doc
            // 
            this.btn_Doc.Location = new System.Drawing.Point(415, 73);
            this.btn_Doc.Name = "btn_Doc";
            this.btn_Doc.Size = new System.Drawing.Size(167, 36);
            this.btn_Doc.TabIndex = 36;
            this.btn_Doc.Text = "Đọc";
            this.btn_Doc.UseVisualStyleBackColor = true;
            this.btn_Doc.Click += new System.EventHandler(this.btn_Doc_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(617, 73);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(167, 36);
            this.btn_luu.TabIndex = 35;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(617, 20);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(167, 47);
            this.btnKetqua.TabIndex = 34;
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
            this.rd_btnDe.TabIndex = 33;
            this.rd_btnDe.TabStop = true;
            this.rd_btnDe.Text = "Decrypt";
            this.rd_btnDe.UseVisualStyleBackColor = true;
            // 
            // rd_btnEn
            // 
            this.rd_btnEn.AutoSize = true;
            this.rd_btnEn.Location = new System.Drawing.Point(108, 33);
            this.rd_btnEn.Name = "rd_btnEn";
            this.rd_btnEn.Size = new System.Drawing.Size(77, 21);
            this.rd_btnEn.TabIndex = 32;
            this.rd_btnEn.TabStop = true;
            this.rd_btnEn.Text = "Encrypt";
            this.rd_btnEn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Key";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(431, 35);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(120, 22);
            this.txt_key.TabIndex = 29;
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Location = new System.Drawing.Point(12, 115);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.RowHeadersWidth = 51;
            this.dgv_khachhang.RowTemplate.Height = 24;
            this.dgv_khachhang.Size = new System.Drawing.Size(787, 432);
            this.dgv_khachhang.TabIndex = 28;
            // 
            // MaHoaCong_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 567);
            this.Controls.Add(this.btn_Doc);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.rd_btnDe);
            this.Controls.Add(this.rd_btnEn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.dgv_khachhang);
            this.Name = "MaHoaCong_Database";
            this.Text = "MaHoaCong_Database";
            ((System.ComponentModel.ISupportInitialize)(this.txt_key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Doc;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btnKetqua;
        private System.Windows.Forms.RadioButton rd_btnDe;
        private System.Windows.Forms.RadioButton rd_btnEn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_key;
        private System.Windows.Forms.DataGridView dgv_khachhang;
    }
}