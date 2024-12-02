using Oracle.ManagedDataAccess.Client;
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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text.Trim();
            string password = txt_Password.Text.Trim();

            if (!KiemTraTextbox(username, password))
                return;

            try
            {
                OracleConnection connection = Database.GetSessionManagerConnection();
                if (connection != null)
                {
                    string createUserQuery = $@"CREATE USER {username} IDENTIFIED BY {password}
                        DEFAULT TABLESPACE NhanVien
                        TEMPORARY TABLESPACE TEMP
                        QUOTA 50M ON NhanVien
                        PROFILE nhanvien";  //gán profile

                    OracleCommand cmd = new OracleCommand(createUserQuery, connection);
                    cmd.ExecuteNonQuery();

                    if (Database.GrantPermissionsForCreate(username))
                    {
                        MessageBox.Show($"Tạo tài khoản mới thành công: {username}");
                        connection.Close();
                        new Dangnhap().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi cấp quyền cho tài khoản: {username}");
                    }
                }
                else
                {
                    MessageBox.Show("Kết nối tới cơ sở dữ liệu thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            new Dangnhap().Show();
            this.Hide();
        }


        private bool KiemTraTextbox(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Chưa điền thông tin Username");
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Chưa điền thông tin Password");
                return false;
            }
            return true;
        }

    }
}
