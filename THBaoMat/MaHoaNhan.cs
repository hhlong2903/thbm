using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace THBaoMat
{
    public partial class MaHoaNhan : Form
    {
        Euclid euclid;
        OracleDataAdapter adapter;
        DataTable dataTable;
        public MaHoaNhan()
        {
            InitializeComponent();
            euclid = new Euclid();
            rd_btnEn.Checked = true;
        }

        void LoadData(int key)
        {
            try
            {
                OracleConnection conn = Database.Get_Connect();
                OracleCommand cmd = new OracleCommand("LoadKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                adapter = new OracleDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Kiểm tra nếu cột tồn tại và mã hóa
                if (dataTable.Columns.Contains("SDT_KH"))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string originalPhone = row["SDT_KH"].ToString();

                        row["SDT_KH"] = EncryptPhone(originalPhone, key); // Mã hóa SDT_KH

                    }
                }

                // Cập nhật lại DataSource
                dgv_khachhang.DataSource = null;
                dgv_khachhang.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu: {ex.Message}");
            }
            finally
            {
                Database.Close_Connect();
            }
        }


        // Hàm mã hóa số điện thoại
        private string EncryptPhone(string msg, int key)
        {
            if (string.IsNullOrEmpty(msg)) return msg;

            string result = "";
            int len = msg.Length;
            for (int i = 0; i < len; i++)
            {
                result += encryptChar(msg[i], key);
            }

            return result;
        }


        private char encryptChar(char c, int k)
        {
            // Kiểm tra nếu ký tự là ký tự có thể in được trong phạm vi từ 32 đến 126
            if (c >= 32 && c <= 126)
            {
                // Mã hóa nhân: (old_char * k) % 95 + 32
                return (char)((((c - 32) * k) % 95) + 32);
            }
            else
            {
                return c; 
            }
        }




        private void HocVien_Load(object sender, EventArgs e)
        {

        }

        private void dgv_hocvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            int key = int.Parse(txt_key.Text);
            if (rd_btnEn.Checked)
            {

            }
            else
            {
                key = euclid.gcd(key, 95);
            }
            LoadData(key);
        }

        private void rd_btnEn_CheckedChanged(object sender, EventArgs e)
        {
            btnKetqua.Text = "Encrypt Message";
        }

        private void rd_btnDe_CheckedChanged(object sender, EventArgs e)
        {
            btnKetqua.Text = "Decrypt Message";
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối với cơ sở dữ liệu
                OracleConnection conn = Database.Get_Connect();

                // Kiểm tra kết nối
                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu.");
                    return;
                }

                // Lặp qua từng dòng trong DataGridView và mã hóa số điện thoại
                foreach (DataGridViewRow row in dgv_khachhang.Rows)
                {
                    if (row.Cells["SDT_KH"].Value != null)
                    {
                        string originalPhone = row.Cells["SDT_KH"].Value.ToString();


                        string customerId = row.Cells["MaKH"].Value.ToString();


                        OracleCommand cmd = new OracleCommand("SaveEncryptedPhone", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số vào thủ tục
                        cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = customerId; // Cập nhật tham số kiểu string
                        cmd.Parameters.Add("p_encryptedPhone", OracleDbType.Varchar2).Value = originalPhone;

                        // Thực thi thủ tục và kiểm tra số dòng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Cập nhật thành công cho khách hàng {customerId}");
                        }
                        else
                        {
                            Console.WriteLine($"Không có thay đổi nào cho khách hàng {customerId}");
                        }
                    }
                }

                MessageBox.Show("Dữ liệu đã được lưu thành công!");
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi chi tiết hơn
                MessageBox.Show($"Có lỗi khi lưu dữ liệu: {ex.Message}\n{ex.StackTrace}");
            }
            finally
            {
                Database.Close_Connect();
            }
        }


        private void btn_Doc_Click(object sender, EventArgs e)
        {
            LoadDataWithoutEncrypt();
        }

        void LoadDataWithoutEncrypt()
        {
            try
            {
                OracleConnection conn = Database.Get_Connect();
                OracleCommand cmd = new OracleCommand("LoadKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số OUT cho con trỏ kết quả
                OracleParameter resultParam = new OracleParameter("result", OracleDbType.RefCursor);
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                // Tạo adapter và lấy dữ liệu từ con trỏ
                adapter = new OracleDataAdapter(cmd);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Kiểm tra nếu cột "SDT_KH" tồn tại, nhưng không mã hóa dữ liệu
                if (dataTable.Columns.Contains("SDT_KH"))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string originalPhone = row["SDT_KH"].ToString();
                        // Giữ nguyên giá trị cột SDT_KH
                        row["SDT_KH"] = originalPhone;
                    }
                }

                // Cập nhật lại DataSource cho DataGridView
                dgv_khachhang.DataSource = null;
                dgv_khachhang.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải dữ liệu: {ex.Message}");
            }
            finally
            {
                Database.Close_Connect();
            }
        }


        private void btn_timK_Click(object sender, EventArgs e)
        {
            SoNghichDao nd = new SoNghichDao();
            nd.Show();
        }
    }
}
