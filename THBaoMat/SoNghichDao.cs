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
    public partial class SoNghichDao : Form
    {
        public SoNghichDao()
        {
            InitializeComponent();
        }

        private void btn_Thuchien_Click(object sender, EventArgs e)
        {
            int b = int.Parse(txt_b.Text);
            Euclid euclib = new Euclid();


            DataTable dt = new DataTable();
            dt.Columns.Add("k", typeof(int));
            dt.Columns.Add("k-1", typeof(int));


            for (int i = 1; i <= b; i++)
            {
                if (euclib.gcd(i, b) == -1)
                {

                }
                else
                {
                    dt.Rows.Add(i, euclib.gcd(i, b));
                }




            }


            dgv_ketqua.DataSource = dt;
        }

    }
}
