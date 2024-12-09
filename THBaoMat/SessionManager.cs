using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace THBaoMat
{
    public static class SessionManager
    {
        public static string SessionID { get; set; } // SessionID của user hiện tại
        public static string CurrentUsername { get; set; }

        public static void EndSession()
        {
            try
            {
                using (OracleConnection conn = Database.GetSessionManagerConnection())
                {
                    if (conn.State == System.Data.ConnectionState.Closed)
                    {
                        conn.Open(); 
                    }

                    //cập nhật trạng thái IS_LOGGED_IN cho tất cả các phiên của tài khoản
                    string query = @"UPDATE MANAGER.LOGIN_SESSIONS
                             SET IS_LOGGED_IN = 0, SessionEnd = SYSTIMESTAMP
                             WHERE Username = :username";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter(":username", CurrentUsername));
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng xuất thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phiên nào để đăng xuất.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng xuất: {ex.Message}");
            }
        }
    }
}
