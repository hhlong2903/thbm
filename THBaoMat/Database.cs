using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace THBaoMat
{
    class Database
    {
        public static OracleConnection Conn;
        public static string Host;
        public static string Port;
        public static string Sid;
        public static string User;
        public static string Password;

        public static void Set_Database(string user, string pass)
        {
            Database.Host = "localhost";
            Database.Port = "1521";
            Database.Sid = "orcl2"; 
            Database.User = user;
            Database.Password = pass;
        }

        public static bool Connect()
        {
            string connsys = "";
            try
            {
                if (User.ToUpper().Equals("SYS"))
                {
                    connsys = ";DBA Privilege=SYSDBA;";
                }

                string connString = String.Format("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1}))" +
                                                  "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={2}))); User ID={3}; Password={4}{5}",
                                                  Host, Port, Sid, User, Password, connsys);

                Conn = new OracleConnection(connString);
                Conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("kết nối thất bại: " + ex.Message);
                return false;
            }
        }



        //kết nối tài khoản manager
        public static OracleConnection GetSessionManagerConnection()
        {
            try
            {
                string connString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                    "(CONNECT_DATA=(SERVICE_NAME=orcl2)));User Id=manager;Password=123;";


                var sessionManagerConn = new OracleConnection(connString);
                sessionManagerConn.Open();
                return sessionManagerConn;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi kết nối: {ex.Message}");
                MessageBox.Show($"Không thể kết nối đến cơ sở dữ liệu: {ex.Message}");
                return null;
            }
        }

        //cấp quyền
        public static bool GrantPermissions(string username)
        {
            try
            {
                using (OracleConnection sessionManagerConn = GetSessionManagerConnection())
                {
                    if (sessionManagerConn != null)
                    {
                        string grantQuery = $@"GRANT SELECT, INSERT, UPDATE ON MANAGER.LOGIN_SESSIONS TO {username}";

                        using (OracleCommand cmd = new OracleCommand(grantQuery, sessionManagerConn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi cấp quyền: {ex.Message}");
                return false;
            }
        }

        public static bool GrantPermissionsForCreate(string username)
        {
            try
            {
                OracleConnection connection = Database.GetSessionManagerConnection();
                if (connection != null)
                {
                    string grantQuery = $"GRANT CONNECT, RESOURCE TO {username}";
                    OracleCommand cmd = new OracleCommand(grantQuery, connection);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                    return true; 
                }
                else
                {
                    MessageBox.Show("Kết nối tới cơ sở dữ liệu thất bại.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cấp quyền: " + ex.Message);
                return false;
            }
        }

        public static OracleConnection Get_Connect()
        {
            if (Conn == null)
            {
                Connect();
            }

            if (Conn.State != System.Data.ConnectionState.Open)
            {
                Conn.Open();
            }

            return Conn;
        }

        public static void Close_Connect()
        {
            if (Conn != null && Conn.State == System.Data.ConnectionState.Open)
            {
                Conn.Close();
                Conn = null; // Đảm bảo tài nguyên được giải phóng
            }
        }

        //Đăng xuất
        public static void Logout(string username)
        {
            using (OracleConnection sessionConn = GetSessionManagerConnection())
            {
                if (sessionConn != null)
                {
                    try
                    {
                        string query = "UPDATE MANAGER.LOGIN_SESSIONS SET IS_LOGGED_IN = 0 WHERE USERNAME = :username";
                        using (OracleCommand cmd = new OracleCommand(query, sessionConn))
                        {
                            cmd.Parameters.Add(new OracleParameter("username", username));
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Đăng xuất thành công");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi đăng xuất: " + ex.Message);
                    }
                }
            }
        }
    }
}
