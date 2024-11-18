using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THBaoMat
{
    public partial class MaHoaCong : Form
    {
        public MaHoaCong()
        {
            InitializeComponent();
            CenterToScreen();
            rd_btnEn.Checked = true;
        }

        private void MaHoaCong_Load(object sender, EventArgs e)
        {

        }
        private char encryptChar(char c, int k)

        {
            if (Char.IsLetter(c))
            {
                return (char)('A' + (c - 'A' + k) % 26);
            }
            else
                return c;
        }

       
       
        private void EncryptMessage(string msg, int k)
        {
            string result = "";
            txtResult.Text = "";
            int len = msg.Length;
            for (int i = 0; i < len; i++)
            {
                result += encryptChar(msg[i], k);

            }
            txtResult.Text = result;
        }

       

        private void btnKetqua_Click_1(object sender, EventArgs e)
        {
            string msg = txtMes.Text;
            if (msg == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần mã hóa");
                return;
            }
            msg = msg.ToUpper();
            int k = (int)key.Value;
            if (rd_btnEn.Checked)
            {

            }
            else
            {
                k = 26 - k;
            }
            EncryptMessage(msg, k);
        }

        private void rd_btnDe_CheckedChanged_1(object sender, EventArgs e)
        {
            btnKetqua.Text = "Decrypt Message";
        }

        private void rd_btnEn_CheckedChanged_1(object sender, EventArgs e)
        {
            btnKetqua.Text = "Encrypt Message";
        }
    }
}
