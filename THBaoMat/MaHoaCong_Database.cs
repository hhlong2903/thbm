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
    public partial class MaHoaCong_Database : Form
    {
        Euclid euclid;
        OracleDataAdapter adapter;
        DataTable dataTable;
        private OracleConnection conn;

        public MaHoaCong_Database()
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
                OracleCommand cmd = new OracleCommand("LoadKhachHangDB", conn);
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

            if (rd_btnEn.Checked)
            {
                key = 95 - key;
            }

            if (conn == null || conn.State != ConnectionState.Open)
            {
                conn = Database.Get_Connect();
            }

            LoadData(key);
        }

        private void FormClosing(object sender, FormClosingEventArgs e)
        {
            conn?.Dispose();
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
    }
}
