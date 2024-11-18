namespace THBaoMat
{
    partial class MaHoaCong
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
            this.btnKetqua = new System.Windows.Forms.Button();
            this.rd_btnDe = new System.Windows.Forms.RadioButton();
            this.rd_btnEn = new System.Windows.Forms.RadioButton();
            this.key = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(350, 314);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(167, 47);
            this.btnKetqua.TabIndex = 14;
            this.btnKetqua.Text = "Encrypt Message";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click_1);
            // 
            // rd_btnDe
            // 
            this.rd_btnDe.AutoSize = true;
            this.rd_btnDe.Location = new System.Drawing.Point(482, 191);
            this.rd_btnDe.Name = "rd_btnDe";
            this.rd_btnDe.Size = new System.Drawing.Size(75, 20);
            this.rd_btnDe.TabIndex = 12;
            this.rd_btnDe.TabStop = true;
            this.rd_btnDe.Text = "Decrypt";
            this.rd_btnDe.UseVisualStyleBackColor = true;
            this.rd_btnDe.CheckedChanged += new System.EventHandler(this.rd_btnDe_CheckedChanged_1);
            // 
            // rd_btnEn
            // 
            this.rd_btnEn.AutoSize = true;
            this.rd_btnEn.Location = new System.Drawing.Point(350, 191);
            this.rd_btnEn.Name = "rd_btnEn";
            this.rd_btnEn.Size = new System.Drawing.Size(73, 20);
            this.rd_btnEn.TabIndex = 11;
            this.rd_btnEn.TabStop = true;
            this.rd_btnEn.Text = "Encrypt";
            this.rd_btnEn.UseVisualStyleBackColor = true;
            this.rd_btnEn.CheckedChanged += new System.EventHandler(this.rd_btnEn_CheckedChanged_1);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(350, 138);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(120, 22);
            this.key.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Key";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(197, 96);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(64, 16);
            this.Message.TabIndex = 10;
            this.Message.Text = "Message";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(350, 247);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(253, 22);
            this.txtResult.TabIndex = 13;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(350, 90);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(253, 22);
            this.txtMes.TabIndex = 5;
            this.txtMes.Tag = "";
            // 
            // MaHoaCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.rd_btnDe);
            this.Controls.Add(this.rd_btnEn);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtMes);
            this.Name = "MaHoaCong";
            this.Text = "MaHoaCong";
            this.Load += new System.EventHandler(this.MaHoaCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKetqua;
        private System.Windows.Forms.RadioButton rd_btnDe;
        private System.Windows.Forms.RadioButton rd_btnEn;
        private System.Windows.Forms.NumericUpDown key;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtMes;
    }
}