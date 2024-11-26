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
        public Form currentFormChild;

        public Label lb_time;
        public Main()
        {
            InitializeComponent();
            ShowSanpham();
            lb_time = new Label();
            lb_time.Location = new Point(10, 10);
            lb_time.Size = new Size(300, 30);
            this.Controls.Add(lb_time);
        }

        private void ShowSanpham()
        {
            openChildForm(new Sanpham());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Database.Logout(Database.User);
                Close();
            }
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            openChildForm(new MaHoaCong());
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            openChildForm(new MaHoaNhan());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new Sanpham());
        }

        public void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            content_panel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
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
