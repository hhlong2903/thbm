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
    }
}
