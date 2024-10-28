using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Database.Sid = "orcl2";  // Ensure this SID matches your Oracle database configuration
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
                // Log the exception message for debugging
                Console.WriteLine("Connection failed: " + ex.Message);
                return false;
            }
        }

        public static OracleConnection Get_Connect()
        {
            if (Conn == null)
            {
                Connect();
            }
            return Conn;
        }
    }
}
