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
using THBaoMat;

namespace THBaoMat
{
    public partial class Sanpham : Form
    {
        public Sanpham()
        {
            InitializeComponent();
            LoadSanPham();
            LoadComboBoxNCC();
            LoadComboBoxLoaiHang();
        }

        private void LoadSanPham()
        {
            try
            {
                OracleConnection conn = Database.Get_Connect();
                string query = "SELECT * FROM manager.SanPham";
                OracleDataAdapter da = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSanPham.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text;
                string tenSP = txtTenSP.Text;
                int soLuong = int.Parse(txtSoLuongSP.Text);
                DateTime ngaySX = dtpNSX.Value;
                DateTime thoiGianBaoHanh = dtpTHBH.Value;
                decimal giaBan = decimal.Parse(txtGia.Text);
                string loaiHang = cboLoai.SelectedItem.ToString();
                string moTa = txtMoTa.Text;
                string maNCC = cboNCC.SelectedItem.ToString();

                OracleConnection conn = Database.Get_Connect();

                // ktra nếu sản phẩm tồn tại
                string checkQuery = "SELECT COUNT(*) FROM manager.SanPham WHERE MaSP = :MaSP";
                OracleCommand checkCmd = new OracleCommand(checkQuery, conn);
                checkCmd.Parameters.Add(new OracleParameter("MaSP", maSP));

                int existingProductCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (existingProductCount > 0)
                {
                    MessageBox.Show("Sản phẩm có mã này đã tồn tại!");
                    return;
                }

                string query = @"INSERT INTO manager.SanPham (MaSP, TenSP, SoLuong, NgaySX, ThoiGian_BaoHanh, GiaBan, LoaiHang, MoTa, MaNCC) 
                         VALUES (:MaSP, :TenSP, :SoLuong, :NgaySX, :ThoiGian_BaoHanh, :GiaBan, :LoaiHang, :MoTa, :MaNCC)";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("MaSP", maSP));
                cmd.Parameters.Add(new OracleParameter("TenSP", tenSP));
                cmd.Parameters.Add(new OracleParameter("SoLuong", soLuong));
                cmd.Parameters.Add(new OracleParameter("NgaySX", ngaySX));
                cmd.Parameters.Add(new OracleParameter("ThoiGian_BaoHanh", thoiGianBaoHanh));
                cmd.Parameters.Add(new OracleParameter("GiaBan", giaBan));
                cmd.Parameters.Add(new OracleParameter("LoaiHang", loaiHang));
                cmd.Parameters.Add(new OracleParameter("MoTa", moTa));
                cmd.Parameters.Add(new OracleParameter("MaNCC", maNCC));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sản phẩm đã được thêm thành công!");

                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text;
                string tenSP = txtTenSP.Text;
                int soLuong = int.Parse(txtSoLuongSP.Text);
                DateTime ngaySX = dtpNSX.Value;
                DateTime thoiGianBaoHanh = dtpTHBH.Value;
                decimal giaBan = decimal.Parse(txtGia.Text);
                string loaiHang = cboLoai.SelectedItem.ToString();
                string moTa = txtMoTa.Text;
                string maNCC = cboNCC.SelectedItem.ToString();

                OracleConnection conn = Database.Get_Connect();
                string query = @"UPDATE manager.SanPham SET TenSP = :TenSP, SoLuong = :SoLuong, NgaySX = :NgaySX, ThoiGian_BaoHanh = :ThoiGian_BaoHanh, GiaBan = :GiaBan,LoaiHang = :LoaiHang, MoTa = :MoTa, MaNCC = :MaNCC
                WHERE MaSP = :MaSP";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("TenSP", tenSP));
                cmd.Parameters.Add(new OracleParameter("SoLuong", soLuong));
                cmd.Parameters.Add(new OracleParameter("NgaySX", ngaySX));
                cmd.Parameters.Add(new OracleParameter("ThoiGian_BaoHanh", thoiGianBaoHanh));
                cmd.Parameters.Add(new OracleParameter("GiaBan", giaBan));
                cmd.Parameters.Add(new OracleParameter("LoaiHang", loaiHang));
                cmd.Parameters.Add(new OracleParameter("MoTa", moTa));
                cmd.Parameters.Add(new OracleParameter("MaNCC", maNCC));
                cmd.Parameters.Add(new OracleParameter("MaSP", maSP));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sản phẩm đã được cập nhật!");

                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sản phẩm: " + ex.Message);
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text;

                if (string.IsNullOrEmpty(maSP))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OracleConnection conn = Database.Get_Connect();
                    string query = "DELETE FROM manager.SanPham WHERE MaSP = :MaSP";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(new OracleParameter("MaSP", maSP));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sản phẩm đã được xóa thành công!");

                    LoadSanPham();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtSoLuongSP.Text = row.Cells["SoLuong"].Value.ToString();
                txtGia.Text = row.Cells["GiaBan"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();

                string NCC = row.Cells["MaNCC"].Value.ToString();
                if (cboNCC.Items.Contains(NCC))
                {
                    cboNCC.SelectedItem = NCC; 
                }

                string Loai = row.Cells["LoaiHang"].Value.ToString();
                if (cboLoai.Items.Contains(Loai))
                {
                    cboLoai.SelectedItem = Loai; 
                }

                DateTime NSX = Convert.ToDateTime(row.Cells["NgaySX"].Value);
                dtpNSX.Value = NSX;

                DateTime THBH = Convert.ToDateTime(row.Cells["ThoiGian_BaoHanh"].Value);
                dtpTHBH.Value = THBH;
            }
        }

        private void LoadComboBoxLoaiHang()
        {
            try
            {
                List<string> loaiHangList = new List<string>
                {
                    "Điện thoại",
                    "Laptop",
                    "Máy tính bảng",
                    "Phụ kiện"
                };
                cboLoai.DataSource = loaiHangList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại hàng: " + ex.Message);
            }
        }

        private void LoadComboBoxNCC()
        {
            try
            {
                List<string> nhaCungCapList = new List<string>
        {
            "NCC001",
            "NCC002",
            "NCC003",
        };
                cboNCC.DataSource = nhaCungCapList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải nhà cung cấp: " + ex.Message);
            }
        }

        private void dgvSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtSoLuongSP.Text = row.Cells["SoLuong"].Value.ToString();
                txtGia.Text = row.Cells["GiaBan"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();

                string NCC = row.Cells["MaNCC"].Value.ToString();
                if (cboNCC.Items.Contains(NCC))
                {
                    cboNCC.SelectedItem = NCC;
                }

                string Loai = row.Cells["LoaiHang"].Value.ToString();
                if (cboLoai.Items.Contains(Loai))
                {
                    cboLoai.SelectedItem = Loai;
                }

                DateTime NSX = Convert.ToDateTime(row.Cells["NgaySX"].Value);
                dtpNSX.Value = NSX;

                DateTime THBH = Convert.ToDateTime(row.Cells["ThoiGian_BaoHanh"].Value);
                dtpTHBH.Value = THBH;
            }
        }
    }

}
