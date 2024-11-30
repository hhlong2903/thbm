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
    public partial class RSA : Form
    {
        Euclid euclid;
        OracleDataAdapter adapter;
        DataTable dataTable;
        private OracleConnection conn;

        public RSA()
        {
            InitializeComponent();
            euclid = new Euclid();
            rd_btnEn.Checked = true;

       

        }

        void LoadData(int e, int n)
        {
            try
            {
                // Use 'using' statement for automatic disposal of resources
                using (OracleConnection conn = Database.Get_Connect())
                {
                    OracleCommand cmd = new OracleCommand("LoadKhachHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Set up the output parameter for the stored procedure
                    cmd.Parameters.Add("result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    // Use OracleDataAdapter to fill the data table
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check if the SDT_KH column exists and apply encryption
                        if (dataTable.Columns.Contains("SDT_KH"))
                        {
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string originalPhone = row["SDT_KH"].ToString();

                                // Encrypt the phone number with the provided key
                                row["SDT_KH"] = RSAEncrypt(originalPhone, e , n);
                            }
                        }

                        // Update the DataGridView with the encrypted data
                        dgv_khachhang.DataSource = null;  // Reset the DataSource
                        dgv_khachhang.DataSource = dataTable;  // Assign the new data source
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu: {ex.Message}");
            }
            finally
            {
                // Ensure the database connection is closed if not already done
                Database.Close_Connect();
            }
        }

        void LoadData1(int d, int n)
        {
            try
            {
                // Use 'using' statement for automatic disposal of resources
                using (OracleConnection conn = Database.Get_Connect())
                {
                    OracleCommand cmd = new OracleCommand("LoadKhachHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Set up the output parameter for the stored procedure
                    cmd.Parameters.Add("result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    // Use OracleDataAdapter to fill the data table
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check if the SDT_KH column exists and apply encryption
                        if (dataTable.Columns.Contains("SDT_KH"))
                        {
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string originalPhone = row["SDT_KH"].ToString();

                                // Encrypt the phone number with the provided key
                                row["SDT_KH"] = RSADecrypt(originalPhone, d, n);
                            }
                        }

                        // Update the DataGridView with the encrypted data
                        dgv_khachhang.DataSource = null;  // Reset the DataSource
                        dgv_khachhang.DataSource = dataTable;  // Assign the new data source
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu: {ex.Message}");
            }
            finally
            {
                // Ensure the database connection is closed if not already done
                Database.Close_Connect();
            }
        }

        private void btn_timK_Click(object sender, EventArgs e)
        {
            TaoKhoaRSA tao = new TaoKhoaRSA();
            tao.OnValuesSelected += (e_value, d_value, phi_value) =>
            {
                // Gán các giá trị vào các TextBox hoặc thực hiện xử lý khác
                txt_e.Text = e_value.ToString();
                txt_d.Text = d_value.ToString();
                txt_n1.Text = phi_value.ToString();
            };
            tao.Show();
        }

        private void LoadDataRaw()
        {
            try
            {
                using (OracleConnection conn = Database.Get_Connect())
                {
                    OracleCommand cmd = new OracleCommand("LoadKhachHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    adapter = new OracleDataAdapter(cmd);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_khachhang.DataSource = null;
                    dgv_khachhang.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        private void btn_Doc_Click(object sender, EventArgs e)
        {
            LoadDataRaw();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = Database.Get_Connect())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu.");
                        return;
                    }

                    foreach (DataGridViewRow row in dgv_khachhang.Rows)
                    {
                        if (row.Cells["SDT_KH"].Value != null && row.Cells["MAKH"].Value != null)
                        {
                            string originalPhone = row.Cells["SDT_KH"].Value.ToString();
                            string customerId = row.Cells["MAKH"].Value.ToString();

                            OracleCommand cmd = new OracleCommand("SaveEncryptedPhone", conn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = customerId;
                            cmd.Parameters.Add("p_encryptedPhone", OracleDbType.Varchar2).Value = originalPhone;

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Dữ liệu đã được lưu thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi lưu dữ liệu: {ex.Message}");
            }
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu e là số nguyên hợp lệ
            if (!int.TryParse(txt_e.Text, out int e1))
            {
                MessageBox.Show("Vui lòng chọn khóa e (số nguyên).");
                return;
            }

            // Kiểm tra nếu d là số nguyên hợp lệ
            if (!int.TryParse(txt_d.Text, out int d))
            {
                MessageBox.Show("Vui lòng chọn khóa d (số nguyên).");
                return;
            }

            // Kiểm tra nếu n1 là số nguyên hợp lệ
            if (!int.TryParse(txt_n1.Text, out int n1))
            {
                MessageBox.Show("Vui lòng chọn khóa n1 (số nguyên).");
                return;
            }

            // Nếu có vấn đề với kết nối cơ sở dữ liệu, kết nối lại
            if (conn == null || conn.State != ConnectionState.Open)
            {
                conn = Database.Get_Connect();
            }

            if (rd_btnEn.Checked)
            {
                LoadData(e1,n1);
            }
            else
            {
                LoadData1(d, n1);
            }



        }


        public string RSAEncrypt(string message, int e, int n)
        {
            StringBuilder encryptedMessage = new StringBuilder();

            foreach (char character in message)
            {
                // Lấy giá trị ASCII của ký tự
                int asciiValue = (int)character;

                // Thực hiện mã hóa: (ASCII^e) % n
                int encryptedValue = ModularExponentiation(asciiValue, e, n);

                // Thêm kết quả vào chuỗi mã hóa
                encryptedMessage.Append(encryptedValue.ToString() + " ");
            }

            return encryptedMessage.ToString().Trim();
        }





        public string RSADecrypt(string encryptedMessage, int d, int n)
        {
            StringBuilder decryptedMessage = new StringBuilder();

            // Tách các phần tử mã hóa (mỗi phần là một giá trị mã hóa của một ký tự)
            string[] encryptedValues = encryptedMessage.Split(' ');

            foreach (string encryptedValue in encryptedValues)
            {
                // Chuyển đổi giá trị mã hóa từ chuỗi thành số nguyên
                if (int.TryParse(encryptedValue, out int encryptedInt))
                {
                    // Giải mã: (encryptedValue^d) % n
                    int decryptedValue = ModularExponentiation(encryptedInt, d, n);

                    // Chuyển giá trị giải mã thành ký tự tương ứng và thêm vào chuỗi kết quả
                    decryptedMessage.Append((char)decryptedValue);
                }
                else
                {
                    // Nếu có giá trị không hợp lệ, bỏ qua
                    continue;
                }
            }

            return decryptedMessage.ToString();
        }


        // Giải thuật "Modular Exponentiation" để tính (base^exponent) % modulus
        private int ModularExponentiation(int baseValue, int exponent, int modulus)
        {
            int result = 1;
            baseValue = baseValue % modulus;

            while (exponent > 0)
            {
                // Nếu exponent lẻ, nhân base với result
                if (exponent % 2 == 1)
                {
                    result = (result * baseValue) % modulus;
                }

                // Chia exponent cho 2, bình phương base
                exponent = exponent >> 1;  // exponent = exponent / 2
                baseValue = (baseValue * baseValue) % modulus;
            }

            return result;
        }


    }
}
