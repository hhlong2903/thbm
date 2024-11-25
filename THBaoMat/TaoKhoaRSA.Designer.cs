
namespace THBaoMat
{
    partial class TaoKhoaRSA
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.txtΦ = new System.Windows.Forms.TextBox();
            this.dgv_ketqua = new System.Windows.Forms.DataGridView();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "q:";
            // 
            // txt_p
            // 
            this.txt_p.Location = new System.Drawing.Point(73, 46);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(100, 22);
            this.txt_p.TabIndex = 2;
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(237, 46);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(100, 22);
            this.txt_q.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = " Φ(n)";
            // 
            // txt_n
            // 
            this.txt_n.Enabled = false;
            this.txt_n.Location = new System.Drawing.Point(74, 100);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(100, 22);
            this.txt_n.TabIndex = 7;
            // 
            // txtΦ
            // 
            this.txtΦ.Enabled = false;
            this.txtΦ.Location = new System.Drawing.Point(237, 100);
            this.txtΦ.Name = "txtΦ";
            this.txtΦ.Size = new System.Drawing.Size(100, 22);
            this.txtΦ.TabIndex = 8;
            // 
            // dgv_ketqua
            // 
            this.dgv_ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ketqua.Location = new System.Drawing.Point(1, 165);
            this.dgv_ketqua.Name = "dgv_ketqua";
            this.dgv_ketqua.RowHeadersWidth = 51;
            this.dgv_ketqua.RowTemplate.Height = 24;
            this.dgv_ketqua.Size = new System.Drawing.Size(787, 342);
            this.dgv_ketqua.TabIndex = 17;
            this.dgv_ketqua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ketqua_CellClick);
            // 
            // btn_Chon
            // 
            this.btn_Chon.Location = new System.Drawing.Point(675, 96);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(75, 30);
            this.btn_Chon.TabIndex = 18;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.UseVisualStyleBackColor = true;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // txt_d
            // 
            this.txt_d.Enabled = false;
            this.txt_d.Location = new System.Drawing.Point(556, 100);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(100, 22);
            this.txt_d.TabIndex = 22;
            // 
            // txt_e
            // 
            this.txt_e.Enabled = false;
            this.txt_e.Location = new System.Drawing.Point(393, 100);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(100, 22);
            this.txt_e.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "d";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "e";
            // 
            // TaoKhoaRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 542);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.txt_e);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Chon);
            this.Controls.Add(this.dgv_ketqua);
            this.Controls.Add(this.txtΦ);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_q);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaoKhoaRSA";
            this.Text = "TaoKhoaRSA";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.TextBox txtΦ;
        private System.Windows.Forms.DataGridView dgv_ketqua;
        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}