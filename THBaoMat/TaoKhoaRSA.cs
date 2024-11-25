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
    public partial class TaoKhoaRSA : Form
    {
        public TaoKhoaRSA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p, q;

            // Kiểm tra đầu vào của người dùng
            if (!int.TryParse(txt_p.Text, out p) || !int.TryParse(txt_q.Text, out q))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho p và q.");
                return;
            }

            // Kiểm tra xem p và q có phải là số nguyên tố không
            if (!IsPrime(p) || !IsPrime(q))
            {
                MessageBox.Show("Cả p và q đều phải là số nguyên tố.");
                return;
            }

            int n, n1;
            n = q * p;
            n1 = (q - 1) * (p - 1);
            txt_n.Text = n.ToString();
            txtΦ.Text = n1.ToString();

            Euclid euclib = new Euclid();

            DataTable dt = new DataTable();
            dt.Columns.Add("e", typeof(int));
            dt.Columns.Add("d", typeof(int));

            // Điền DataTable với các giá trị e và d
            for (int i = 1; i <= n1; i++)
            {
                if (euclib.gcd(i, n1) == -1)
                {
                    // Bỏ qua các giá trị mà gcd(i, n1) = -1
                }
                else
                {
                    dt.Rows.Add(i, euclib.gcd(i, n1));
                }
            }
            dgv_ketqua.DataSource = dt;
        }


        // Xử lý sự kiện khi người dùng nhấp chuột vào một ô trong DataGridView
        private void dgv_ketqua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra chỉ số dòng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị e và d từ dòng đã chọn
                int e_value = Convert.ToInt32(dgv_ketqua.Rows[e.RowIndex].Cells["e"].Value);
                int d_value = Convert.ToInt32(dgv_ketqua.Rows[e.RowIndex].Cells["d"].Value);

                // Gán giá trị vào các TextBox tương ứng
                txt_e.Text = e_value.ToString();
                txt_d.Text = d_value.ToString();
            }
        }

        // TaoKhoaRSA.cs

        public event Action<int, int, int> OnValuesSelected;

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_e.Text, out int e_value) &&
                int.TryParse(txt_d.Text, out int d_value) &&
                int.TryParse(txt_n.Text, out int phi_value))
            {
                // Gọi sự kiện để truyền giá trị sang form RSA
                OnValuesSelected?.Invoke(e_value, d_value, phi_value);
                this.Close();  // Đóng form TaoKhoaRSA sau khi đã truyền giá trị
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng giá trị cho e, d và phi!");
            }
        }
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

    }

}
