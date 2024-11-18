
namespace THBaoMat
{
    partial class SoNghichDao
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
            this.dgv_ketqua = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Thuchien = new System.Windows.Forms.Button();
            this.txt_b = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ketqua
            // 
            this.dgv_ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ketqua.Location = new System.Drawing.Point(7, 85);
            this.dgv_ketqua.Name = "dgv_ketqua";
            this.dgv_ketqua.RowHeadersWidth = 51;
            this.dgv_ketqua.RowTemplate.Height = 24;
            this.dgv_ketqua.Size = new System.Drawing.Size(787, 342);
            this.dgv_ketqua.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Z";
            // 
            // btn_Thuchien
            // 
            this.btn_Thuchien.Location = new System.Drawing.Point(591, 23);
            this.btn_Thuchien.Name = "btn_Thuchien";
            this.btn_Thuchien.Size = new System.Drawing.Size(75, 23);
            this.btn_Thuchien.TabIndex = 14;
            this.btn_Thuchien.Text = "Tìm";
            this.btn_Thuchien.UseVisualStyleBackColor = true;
            this.btn_Thuchien.Click += new System.EventHandler(this.btn_Thuchien_Click);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(393, 23);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 22);
            this.txt_b.TabIndex = 13;
            // 
            // SoNghichDao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Thuchien);
            this.Controls.Add(this.txt_b);
            this.Name = "SoNghichDao";
            this.Text = "SoNghichDao";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ketqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Thuchien;
        private System.Windows.Forms.TextBox txt_b;
    }
}