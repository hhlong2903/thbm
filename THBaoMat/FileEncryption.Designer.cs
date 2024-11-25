
namespace THBaoMat
{
    partial class FileEncryption
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
            this.Con = new System.Windows.Forms.TabControl();
            this.tabEncrypt = new System.Windows.Forms.TabPage();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btn_cd = new System.Windows.Forms.Button();
            this.txt_cdEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDecrypt = new System.Windows.Forms.TabPage();
            this.btn_cdKey = new System.Windows.Forms.Button();
            this.txt_cdKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cdDecrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cdDecrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.Con.SuspendLayout();
            this.tabEncrypt.SuspendLayout();
            this.tabDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Con
            // 
            this.Con.Controls.Add(this.tabEncrypt);
            this.Con.Controls.Add(this.tabDecrypt);
            this.Con.Location = new System.Drawing.Point(0, -1);
            this.Con.Name = "Con";
            this.Con.SelectedIndex = 0;
            this.Con.Size = new System.Drawing.Size(801, 448);
            this.Con.TabIndex = 0;
            // 
            // tabEncrypt
            // 
            this.tabEncrypt.Controls.Add(this.btnEncrypt);
            this.tabEncrypt.Controls.Add(this.btn_cd);
            this.tabEncrypt.Controls.Add(this.txt_cdEncrypt);
            this.tabEncrypt.Controls.Add(this.label1);
            this.tabEncrypt.Location = new System.Drawing.Point(4, 25);
            this.tabEncrypt.Name = "tabEncrypt";
            this.tabEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncrypt.Size = new System.Drawing.Size(793, 419);
            this.tabEncrypt.TabIndex = 0;
            this.tabEncrypt.Text = "Encrypt";
            this.tabEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(323, 288);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(92, 30);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btn_cd
            // 
            this.btn_cd.Location = new System.Drawing.Point(709, 107);
            this.btn_cd.Name = "btn_cd";
            this.btn_cd.Size = new System.Drawing.Size(75, 23);
            this.btn_cd.TabIndex = 2;
            this.btn_cd.Text = "...";
            this.btn_cd.UseVisualStyleBackColor = true;
            this.btn_cd.Click += new System.EventHandler(this.btn_cd_Click);
            // 
            // txt_cdEncrypt
            // 
            this.txt_cdEncrypt.Location = new System.Drawing.Point(109, 107);
            this.txt_cdEncrypt.Name = "txt_cdEncrypt";
            this.txt_cdEncrypt.Size = new System.Drawing.Size(567, 22);
            this.txt_cdEncrypt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // tabDecrypt
            // 
            this.tabDecrypt.Controls.Add(this.btn_cdKey);
            this.tabDecrypt.Controls.Add(this.txt_cdKey);
            this.tabDecrypt.Controls.Add(this.label3);
            this.tabDecrypt.Controls.Add(this.txt_cdDecrypt);
            this.tabDecrypt.Controls.Add(this.label2);
            this.tabDecrypt.Controls.Add(this.btn_cdDecrypt);
            this.tabDecrypt.Controls.Add(this.btnDecrypt);
            this.tabDecrypt.Location = new System.Drawing.Point(4, 25);
            this.tabDecrypt.Name = "tabDecrypt";
            this.tabDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecrypt.Size = new System.Drawing.Size(793, 419);
            this.tabDecrypt.TabIndex = 1;
            this.tabDecrypt.Text = "Decrypt";
            this.tabDecrypt.UseVisualStyleBackColor = true;
            // 
            // btn_cdKey
            // 
            this.btn_cdKey.Location = new System.Drawing.Point(692, 192);
            this.btn_cdKey.Name = "btn_cdKey";
            this.btn_cdKey.Size = new System.Drawing.Size(75, 23);
            this.btn_cdKey.TabIndex = 6;
            this.btn_cdKey.Text = "...";
            this.btn_cdKey.UseVisualStyleBackColor = true;
            this.btn_cdKey.Click += new System.EventHandler(this.btn_cdKey_Click);
            // 
            // txt_cdKey
            // 
            this.txt_cdKey.Location = new System.Drawing.Point(131, 192);
            this.txt_cdKey.Name = "txt_cdKey";
            this.txt_cdKey.Size = new System.Drawing.Size(531, 22);
            this.txt_cdKey.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Key";
            // 
            // txt_cdDecrypt
            // 
            this.txt_cdDecrypt.Location = new System.Drawing.Point(131, 131);
            this.txt_cdDecrypt.Name = "txt_cdDecrypt";
            this.txt_cdDecrypt.Size = new System.Drawing.Size(531, 22);
            this.txt_cdDecrypt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "File";
            // 
            // btn_cdDecrypt
            // 
            this.btn_cdDecrypt.Location = new System.Drawing.Point(692, 131);
            this.btn_cdDecrypt.Name = "btn_cdDecrypt";
            this.btn_cdDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_cdDecrypt.TabIndex = 1;
            this.btn_cdDecrypt.Text = "...";
            this.btn_cdDecrypt.UseVisualStyleBackColor = true;
            this.btn_cdDecrypt.Click += new System.EventHandler(this.btn_cdDecrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(355, 321);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 28);
            this.btnDecrypt.TabIndex = 0;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // FileEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Con);
            this.Name = "FileEncryption";
            this.Text = "FileEncryption";
            this.Con.ResumeLayout(false);
            this.tabEncrypt.ResumeLayout(false);
            this.tabEncrypt.PerformLayout();
            this.tabDecrypt.ResumeLayout(false);
            this.tabDecrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Con;
        private System.Windows.Forms.TabPage tabEncrypt;
        private System.Windows.Forms.TabPage tabDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btn_cd;
        private System.Windows.Forms.TextBox txt_cdEncrypt;
        private System.Windows.Forms.Button btn_cdKey;
        private System.Windows.Forms.TextBox txt_cdKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cdDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cdDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}