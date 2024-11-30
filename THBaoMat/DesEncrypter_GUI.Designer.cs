
namespace THBaoMat
{
    partial class DesEncrypter_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vanban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_vbgoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_thuchien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Văn bản cần mã hóa";
            // 
            // txt_vanban
            // 
            this.txt_vanban.Location = new System.Drawing.Point(53, 44);
            this.txt_vanban.Name = "txt_vanban";
            this.txt_vanban.Size = new System.Drawing.Size(715, 22);
            this.txt_vanban.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "key";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(112, 92);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(656, 22);
            this.txt_key.TabIndex = 3;
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Location = new System.Drawing.Point(53, 173);
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(715, 22);
            this.txt_ketqua.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "kết quả";
            // 
            // txt_vbgoc
            // 
            this.txt_vbgoc.Location = new System.Drawing.Point(53, 264);
            this.txt_vbgoc.Name = "txt_vbgoc";
            this.txt_vbgoc.Size = new System.Drawing.Size(715, 22);
            this.txt_vbgoc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "văn bản gốc";
            // 
            // btn_thuchien
            // 
            this.btn_thuchien.Location = new System.Drawing.Point(358, 344);
            this.btn_thuchien.Name = "btn_thuchien";
            this.btn_thuchien.Size = new System.Drawing.Size(96, 27);
            this.btn_thuchien.TabIndex = 8;
            this.btn_thuchien.Text = "Thực hiện";
            this.btn_thuchien.UseVisualStyleBackColor = true;
            this.btn_thuchien.Click += new System.EventHandler(this.btn_thuchien_Click);
            // 
            // DesEncrypter_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thuchien);
            this.Controls.Add(this.txt_vbgoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_vanban);
            this.Controls.Add(this.label1);
            this.Name = "DesEncrypter_GUI";
            this.Text = "DesEncrypter_GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesEncrypter_GUI_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vanban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_vbgoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_thuchien;
    }
}