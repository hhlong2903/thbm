using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace THBaoMat
{
    public partial class MaHoaLai : Form
    {
        Euclid euclid;
        OracleDataAdapter adapter;
        DataTable dataTable;
        private OracleConnection conn;
        string mahoaKey;
        public MaHoaLai()
        {
            InitializeComponent();
            euclid = new Euclid();
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

        private void btn_Doc_Click(object sender, EventArgs e)
        {
            LoadDataRaw();
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

        private void LoadData(int e, int n)
        {
            conn = null;
            OracleCommand cmd;
            try
            {
                conn = Database.Get_Connect();

                cmd = new OracleCommand("LoadKhachHangDB_RSA", conn);

                cmd.CommandType = CommandType.StoredProcedure;


                // Thêm tham số p_key
                cmd.Parameters.Add("p_n", OracleDbType.Int32).Value = n;

                cmd.Parameters.Add("p_e", OracleDbType.Int32).Value = e;

                // Tham số kết quả trả về (ref cursor)
                cmd.Parameters.Add("result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                // Thực thi lệnh
                adapter = new OracleDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgv_khachhang.DataSource = null;
                dgv_khachhang.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu: {ex.Message}");
            }
            finally
            {
                conn?.Dispose(); // Đảm bảo đóng kết nối khi không sử dụng
            }
        }

        private void LoadData1(int e, int n)
        {
            conn = null;
            OracleCommand cmd;
            try
            {
                conn = Database.Get_Connect();

                cmd = new OracleCommand("LoadKhachHangDB_RSA_Decrypt", conn);

                cmd.CommandType = CommandType.StoredProcedure;


                // Thêm tham số p_key
                cmd.Parameters.Add("p_n", OracleDbType.Int32).Value = n;

                cmd.Parameters.Add("p_e", OracleDbType.Int32).Value = e;

                // Tham số kết quả trả về (ref cursor)
                cmd.Parameters.Add("result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                // Thực thi lệnh
                adapter = new OracleDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgv_khachhang.DataSource = null;
                dgv_khachhang.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu: {ex.Message}");
            }
            finally
            {
                conn?.Dispose(); // Đảm bảo đóng kết nối khi không sử dụng
            }
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
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


            LoadData(e1, n1);

        }

        private void btnOpenPrivateKey_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            string dulieu;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Đọc nội dung file
                dulieu = System.IO.File.ReadAllText(dlg.FileName);

                // Tách các dòng
                string[] lines = dulieu.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                // Biến để lưu trữ các giá trị
                int key = 0;
                string encryptedKey = string.Empty;
                int e1 = 0;
                int n = 0;

                // Duyệt từng dòng và lấy giá trị
                foreach (string line in lines)
                {
                    if (line.StartsWith("Key:"))
                    {
                        // Lấy giá trị sau dấu ':' và chuyển sang số nguyên
                        key = int.Parse(line.Split(':')[1].Trim());
                    }
                    else if (line.StartsWith("Encrypted Key:"))
                    {
                        // Lấy giá trị sau dấu ':' (dạng chuỗi)
                        encryptedKey = line.Split(':')[1].Trim();
                    }
                    else if (line.StartsWith("e:"))
                    {
                        // Lấy giá trị sau dấu ':' và chuyển sang số nguyên
                        e1 = int.Parse(line.Split(':')[1].Trim());
                    }
                    else if (line.StartsWith("n:"))
                    {
                        // Lấy giá trị sau dấu ':' và chuyển sang số nguyên
                        n = int.Parse(line.Split(':')[1].Trim());
                    }
                }

                // Hiển thị giá trị (hoặc gán vào các ô nhập liệu)
                MessageBox.Show($"Key: {key}\nEncrypted Key: {encryptedKey}\ne: {e1}\nn: {n}");

                // Gán giá trị vào các TextBox nếu cần
                txt_key.Value = key;
                txtPrivateKey.Text = encryptedKey;
                txt_e.Text = e1.ToString();
                txt_n1.Text = n.ToString();

                int key_1 = GetModularInverse(key);
                txt_d.Text = EncryptKey(encryptedKey, key_1);


            }
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

        private int GetModularInverse(int key)
        {
            try
            {
                using (OracleConnection conn = Database.Get_Connect())
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    // Sử dụng lệnh SELECT để gọi hàm
                    using (OracleCommand cmd = new OracleCommand("SELECT findInverse(:p_key) FROM dual", conn))
                    {
                        // Thêm tham số đầu vào
                        cmd.Parameters.Add(new OracleParameter("p_key", OracleDbType.Int32) { Value = key });

                        // Thực thi và lấy giá trị trả về
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy giá trị nghịch đảo modular.");
                            return -1;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi khi gọi hàm findInverse: {ex.Message}");
                return -1; // Trả về -1 nếu có lỗi
            }
        }

        private void btnMaHoaKey_Click(object sender, EventArgs e)
        {
            string privateKey = txt_d.Text;

            if (txt_d.Text == "")
            {
                MessageBox.Show("vui lòng tạo khoá d");
                return;
            }

            // Lấy giá trị từ `txt_key` và `privateKey`
            int key = (int)txt_key.Value;
            mahoaKey = EncryptKey(privateKey, key); // Gọi hàm mã hóa

            txtPrivateKey.Text = mahoaKey;
           
        }

        public string EncryptKey(string phone, int key)
        {
            string encryptedPhone = null;

            using (conn = Database.Get_Connect())
            {
                try
                {
                    // Kiểm tra trạng thái kết nối trước khi mở
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    // Câu truy vấn để gọi hàm Encrypt_Phone_Multiplicative
                    using (OracleCommand cmd = new OracleCommand("SELECT Encrypt_Phone_Multiplicative(:p_phone, :p_key) FROM dual", conn))
                    {
                        // Thêm tham số đầu vào
                        cmd.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = phone;
                        cmd.Parameters.Add("p_key", OracleDbType.Int32).Value = key;

                        // Thực thi và lấy kết quả trả về
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            encryptedPhone = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
                }
                finally
                {
                    // Đảm bảo đóng kết nối
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

            // Kiểm tra kết quả
            if (string.IsNullOrEmpty(encryptedPhone))
            {
                MessageBox.Show("Không thể mã hóa số điện thoại.");
                return null;
            }

            return encryptedPhone;
        }


       



        private void btnLuuKhoa_Click(object sender, EventArgs e)
        {
       

            int key = (int)txt_key.Value;
          

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt) | *.txt";
                saveFileDialog.Title = "Save Keys";

                // Tạo tên file duy nhất
                string uniqueFileName = string.Format("Keys_{0}", Path.GetRandomFileName().Substring(0, 8));
                saveFileDialog.FileName = uniqueFileName + ".txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đường dẫn file lưu
                    string filePath = saveFileDialog.FileName;

                    // Nội dung lưu vào file
                    string content = $"Key: {key}\n" +
                                     $"Encrypted Key: {mahoaKey}\n" +
                                     $"e: {txt_e.Text}\n" +
                                     $"n: {txt_n1.Text}"
                                     ;

                    // Ghi nội dung vào file
                    File.WriteAllText(filePath, content);

                    MessageBox.Show("Đã lưu khóa thành công.");
                }
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {

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


            LoadData1(d, n1);
        }
    }
}
