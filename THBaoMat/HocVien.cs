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
    public partial class HocVien : Form
    {
        public HocVien()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            try
            {
                OracleConnection conn = Database.Get_Connect();
                string query = "SELECT * FROM hocvien";

                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgv_hocvien.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void HocVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_hocvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
