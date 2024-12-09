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

            if (KiemTraUserTonTai(username))
            {
                MessageBox.Show("User đã tồn tại.");
                return;
            }

            try
            {
                using (OracleConnection connection = Database.GetSessionManagerConnection())
                {
                    if (connection != null)
                    {
                        // Gọi stored procedure
                        OracleCommand cmd = new OracleCommand("pro_create_user", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        // Thêm tham số đầu vào
                        cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                        cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Tạo tài khoản mới thành công: {username}");

                        connection.Close();
                        new Dangnhap().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kết nối tới cơ sở dữ liệu thất bại.");
                    }
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

        private bool KiemTraUserTonTai(string username)
        {
            try
            {
                using (OracleConnection connection = Database.GetSessionManagerConnection())
                {
                    if (connection != null)
                    {
                        // Gọi hàm fun_check_account
                        string query = "SELECT fun_check_account(:username) FROM dual";
                        using (OracleCommand cmd = new OracleCommand(query, connection))
                        {
                            cmd.Parameters.Add(new OracleParameter(":username", username));
                            object result = cmd.ExecuteScalar();

                            int userExists = Convert.ToInt32(result);
                            return userExists == 1; // Trả về true nếu user tồn tại
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kết nối tới cơ sở dữ liệu thất bại.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                return false;
            }
        }

    }
}
