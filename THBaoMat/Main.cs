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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn đăng xuất không?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Database.Logout(Database.User);
                Close();
            }
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            MaHoaCong mh = new MaHoaCong();
            mh.Show();
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            MaHoaNhan mh = new MaHoaNhan();
            mh.Show();
        }

        private void btn_congDB_Click(object sender, EventArgs e)
        {
            MaHoaCong_Database mh = new MaHoaCong_Database();
            mh.Show();
        }

        private void btn_nhanDB_Click(object sender, EventArgs e)
        {
            MaHoaNhan_Database mh = new MaHoaNhan_Database();
            mh.Show();
        }

        private void btn_des_Click(object sender, EventArgs e)
        {
            DesEncrypter_GUI des = new DesEncrypter_GUI();
            des.Show();
        }

        private void btn_desFile_Click(object sender, EventArgs e)
        {
            FileEncryption file = new FileEncryption();
            file.Show();
        }

        private void btn_RSA_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            rsa.Show();
        }
    }
}
