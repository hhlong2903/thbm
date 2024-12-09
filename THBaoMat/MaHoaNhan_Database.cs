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
    public partial class MaHoaNhan_Database : Form
    {
        Euclid euclid;
        OracleDataAdapter adapter;
        DataTable dataTable;
        private OracleConnection conn;

        public MaHoaNhan_Database()
        {
            InitializeComponent();
            euclid = new Euclid();
            rd_btnEn.Checked = true;
        }

        private void LoadData(int key)
        {
            conn = null;
            try
            {
                conn = Database.Get_Connect();
                OracleCommand cmd = new OracleCommand("LoadKhachHangDB_Multiplicative", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số p_key
                cmd.Parameters.Add("p_key", OracleDbType.Int32).Value = key;

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


        private void btnKetqua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_key.Text, out int key))
            {
                MessageBox.Show("Vui lòng nhập khóa hợp lệ (số nguyên).");
                return;
            }

            try
            {
                // Gọi hàm findInverse từ database nếu chế độ giải mã được chọn
                if (rd_btnDe.Checked)
                {
                    key = GetModularInverse(key);

                    if (key == -1)
                    {
                        MessageBox.Show("Không tìm thấy số nghịch đảo modular cho khóa đã nhập.");
                        return;
                    }
                }

                if (conn == null || conn.State != ConnectionState.Open)
                {
                    conn = Database.Get_Connect();
                }

                // Load dữ liệu với khóa đã tính
                LoadData(key);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi xử lý: {ex.Message}");
            }
        }


        private void FormClosing(object sender, FormClosingEventArgs e)
        {
            //conn?.Dispose();
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


        


    }
}
