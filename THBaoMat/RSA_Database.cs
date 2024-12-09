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
    public partial class RSA_Database : Form
    {
        Euclid euclid;
        OracleDataAdapter adapter;
        DataTable dataTable;
        private OracleConnection conn;
        public RSA_Database()
        {
            InitializeComponent();
            euclid = new Euclid();
            rd_btnEn.Checked = true;
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
                if(rd_btnEn.Checked == true)
                {
                    cmd = new OracleCommand("LoadKhachHangDB_RSA", conn);
                }
                else
                {
                    cmd = new OracleCommand("LoadKhachHangDB_RSA_Decrypt", conn);
                }
                
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
                LoadData(e1, n1);
            }
            else
            {
                LoadData(d, n1);
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
    }
}
