using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace THBaoMat
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private bool KiemTraTextbox(string user, string pass)
        {
            if (string.IsNullOrEmpty(user))
            {
                HienThongBao("Chưa điền thông tin UserName", txt_Username);
                return false;
            }
            if (string.IsNullOrEmpty(pass))
            {
                HienThongBao("Chưa điền thông tin Password", txt_Password);
                return false;
            }
            return true;
        }

        private void HienThongBao(string message, Control control)
        {
            MessageBox.Show(message);
            control.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_Username.Text.Trim();
            string pass = txt_Password.Text.Trim();

            if (!KiemTraTextbox(user, pass))
                return;

            try
            {
                Database.Set_Database(user, pass);
                if (!Database.Connect())
                {
                    MessageBox.Show("Username hoặc mật khẩu không chính xác.");
                    return;
                }
                Database.GrantPermissions(user);
                UpdateAndGetLastLogin(Database.Get_Connect(), user);

                new Main().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        //Cập nhật và lấy thời gian đăng nhập
        public static void UpdateAndGetLastLogin(OracleConnection connection, string username)
        {
            try
            {
                string sessionID = Guid.NewGuid().ToString();

                string upsertQuery = @"MERGE INTO MANAGER.LOGIN_SESSIONS target USING (SELECT :username AS Username FROM dual) source
                               ON (target.Username = source.Username)
                               WHEN MATCHED THEN UPDATE SET LastLogin = SYSTIMESTAMP, SessionID = :sessionID, IS_LOGGED_IN = 1
                               WHEN NOT MATCHED THEN INSERT (Username, LastLogin, SessionID, IS_LOGGED_IN) 
                               VALUES (:username, SYSTIMESTAMP, :sessionID, 1)";

                OracleCommand cmd = new OracleCommand(upsertQuery, connection);
                cmd.Parameters.Add(new OracleParameter(":username", username));
                cmd.Parameters.Add(new OracleParameter(":sessionID", sessionID));
                cmd.ExecuteNonQuery(); 

                cmd.CommandText = "SELECT LastLogin FROM MANAGER.LOGIN_SESSIONS WHERE Username = :username";
                cmd.Parameters.Clear(); 
                cmd.Parameters.Add(new OracleParameter(":username", username));  
                object result = cmd.ExecuteScalar(); 

                string lastLogin = result?.ToString() ?? "Không có thông tin đăng nhập trước đó.";
                MessageBox.Show($"Thời gian đăng nhập lần cuối của tài khoản '{username}': {lastLogin}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new DangKy().Show();
            this.Hide();
        }
    }
}
