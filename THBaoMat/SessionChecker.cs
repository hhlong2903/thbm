using Oracle.ManagedDataAccess.Client;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using THBaoMat;

public class SessionChecker
{
    private static CancellationTokenSource cts = new CancellationTokenSource();

    public static void StartCheckingSession()
    {
        Task.Run(() =>
        {
            while (!cts.Token.IsCancellationRequested)
            {
                try
                {
                    using (OracleConnection conn = Database.GetSessionManagerConnection())
                    {
                        string query = @"SELECT IS_LOGGED_IN 
                                         FROM MANAGER.LOGIN_SESSIONS 
                                         WHERE SessionID = :sessionID";

                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.Parameters.Add(new OracleParameter(":sessionID", SessionManager.SessionID));
                            int isLoggedIn = Convert.ToInt32(cmd.ExecuteScalar());

                            if (isLoggedIn == 0) // Phiên đã hết hạn
                            {
                                LogoutAndCloseApp();
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kiểm tra phiên: {ex.Message}");
                }

                Thread.Sleep(5000); // Kiểm tra lại sau mỗi 5 giây
            }
        }, cts.Token);
    }

    public static void StopCheckingSession()
    {
        cts.Cancel();
    }

    private static void LogoutAndCloseApp()
    {
        MessageBox.Show("Phiên của bạn đã hết hạn.");
        Application.Exit(); // Đóng ứng dụng
    }
}
