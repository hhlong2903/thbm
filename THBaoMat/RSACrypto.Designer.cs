
namespace THBaoMat
{
    partial class RSACrypto
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
            this.btnOpenPublicKey = new System.Windows.Forms.Button();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.btnOpenPrivateKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.btnOpenPlainText = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.btnOpenEncrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.btnEncrypted = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public key";
            // 
            // btnOpenPublicKey
            // 
            this.btnOpenPublicKey.Location = new System.Drawing.Point(126, 12);
            this.btnOpenPublicKey.Name = "btnOpenPublicKey";
            this.btnOpenPublicKey.Size = new System.Drawing.Size(156, 37);
            this.btnOpenPublicKey.TabIndex = 1;
            this.btnOpenPublicKey.Text = "open public key";
            this.btnOpenPublicKey.UseVisualStyleBackColor = true;
            this.btnOpenPublicKey.Click += new System.EventHandler(this.btnOpenPublicKey_Click);
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(29, 57);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(708, 41);
            this.txtPublicKey.TabIndex = 2;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(29, 151);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(708, 41);
            this.txtPrivateKey.TabIndex = 5;
            // 
            // btnOpenPrivateKey
            // 
            this.btnOpenPrivateKey.Location = new System.Drawing.Point(126, 106);
            this.btnOpenPrivateKey.Name = "btnOpenPrivateKey";
            this.btnOpenPrivateKey.Size = new System.Drawing.Size(156, 37);
            this.btnOpenPrivateKey.TabIndex = 4;
            this.btnOpenPrivateKey.Text = "open private key";
            this.btnOpenPrivateKey.UseVisualStyleBackColor = true;
            this.btnOpenPrivateKey.Click += new System.EventHandler(this.btnOpenPrivateKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Private key";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(29, 247);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(708, 41);
            this.txtPlainText.TabIndex = 8;
            // 
            // btnOpenPlainText
            // 
            this.btnOpenPlainText.Location = new System.Drawing.Point(126, 202);
            this.btnOpenPlainText.Name = "btnOpenPlainText";
            this.btnOpenPlainText.Size = new System.Drawing.Size(156, 37);
            this.btnOpenPlainText.TabIndex = 7;
            this.btnOpenPlainText.Text = "open plain text";
            this.btnOpenPlainText.UseVisualStyleBackColor = true;
            this.btnOpenPlainText.Click += new System.EventHandler(this.btnOpenPlainText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Plain text";
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(29, 339);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(345, 97);
            this.txtEncrypt.TabIndex = 11;
            // 
            // btnOpenEncrypt
            // 
            this.btnOpenEncrypt.Location = new System.Drawing.Point(126, 294);
            this.btnOpenEncrypt.Name = "btnOpenEncrypt";
            this.btnOpenEncrypt.Size = new System.Drawing.Size(156, 37);
            this.btnOpenEncrypt.TabIndex = 10;
            this.btnOpenEncrypt.Text = "open encrypted";
            this.btnOpenEncrypt.UseVisualStyleBackColor = true;
            this.btnOpenEncrypt.Click += new System.EventHandler(this.btnOpenEncrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Encrypted text";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(424, 339);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(313, 97);
            this.txtDecrypt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Decrypted text";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 491);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(114, 45);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Generate Key";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(173, 491);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(114, 45);
            this.btnEncrypt.TabIndex = 16;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(331, 491);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(114, 45);
            this.btnDecrypt.TabIndex = 17;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Location = new System.Drawing.Point(489, 491);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(114, 45);
            this.btnSaveKey.TabIndex = 18;
            this.btnSaveKey.Text = "Save Key";
            this.btnSaveKey.UseVisualStyleBackColor = true;
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // btnEncrypted
            // 
            this.btnEncrypted.Location = new System.Drawing.Point(647, 491);
            this.btnEncrypted.Name = "btnEncrypted";
            this.btnEncrypted.Size = new System.Drawing.Size(132, 45);
            this.btnEncrypted.TabIndex = 19;
            this.btnEncrypted.Text = "Save Encrypted";
            this.btnEncrypted.UseVisualStyleBackColor = true;
            this.btnEncrypted.Click += new System.EventHandler(this.btnEncrypted_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(623, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(156, 37);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // RSACrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEncrypted);
            this.Controls.Add(this.btnSaveKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.btnOpenEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.btnOpenPlainText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.btnOpenPrivateKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.btnOpenPublicKey);
            this.Controls.Add(this.label1);
            this.Name = "RSACrypto";
            this.Text = "RSACrypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenPublicKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Button btnOpenPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Button btnOpenPlainText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.Button btnOpenEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSaveKey;
        private System.Windows.Forms.Button btnEncrypted;
        private System.Windows.Forms.Button btnRefresh;
    }
}