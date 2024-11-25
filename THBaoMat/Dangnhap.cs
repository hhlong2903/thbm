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

                Main mainForm = new Main();
                UpdateAndGetLastLogin(Database.Get_Connect(), user, mainForm.lb_time);

                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        //Cập nhật và lấy thời gian đăng nhập
        public static void UpdateAndGetLastLogin(OracleConnection connection, string username, Label lb_time)
        {
            try
            {
                string sessionID = Guid.NewGuid().ToString();

                // Truy vấn thời gian đăng nhập trước đó
                string selectLastLoginQuery = @"
                SELECT TO_CHAR(LastLogin, 'YYYY-MM-DD HH24:MI:SS') AS LastLogin 
                FROM MANAGER.LOGIN_SESSIONS 
                WHERE Username = :username";

                string lastLogin = null;
                using (OracleCommand cmd = new OracleCommand(selectLastLoginQuery, connection))
                {
                    cmd.Parameters.Add(new OracleParameter(":username", username));
                    object result = cmd.ExecuteScalar();
                    lastLogin = result?.ToString();
                }

                if (!string.IsNullOrEmpty(lastLogin))
                {
                    lb_time.Text = $"Thời gian đăng nhập lần cuối: {lastLogin}";
                }

                //MERGE để cập nhật tt đăng nhập mới
                string upsertQuery = @"
                MERGE INTO MANAGER.LOGIN_SESSIONS target
                USING (SELECT :username AS Username FROM dual) source
                ON (target.Username = source.Username)
                WHEN MATCHED THEN 
                    UPDATE SET LastLogin = SYSTIMESTAMP, SessionID = :sessionID, IS_LOGGED_IN = 1
                WHEN NOT MATCHED THEN 
                    INSERT (Username, LastLogin, SessionID, IS_LOGGED_IN) 
                    VALUES (:username, SYSTIMESTAMP, :sessionID, 1)";

                using (OracleCommand cmd = new OracleCommand(upsertQuery, connection))
                {
                    cmd.Parameters.Add(new OracleParameter(":username", username));
                    cmd.Parameters.Add(new OracleParameter(":sessionID", sessionID));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new DangKy().Show();
            this.Hide();
        }
    }
}
