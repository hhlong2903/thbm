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
    public partial class MaHoa : Form
    {
        public Form currentFormChild;
        public MaHoa()
        {
            InitializeComponent();
        }
      
        public void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            content_panel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }


        private void btn_maHoaNhan_Click(object sender, EventArgs e)
        {
            openChildForm(new MaHoaCong());
        }

        private void btn_maHoaNhanDB_Click(object sender, EventArgs e)
        {
            openChildForm(new MaHoaNhan_Database());
        }

        private void btn_maHoaCong_Click(object sender, EventArgs e)
        {
            openChildForm(new MaHoaCong());
        }

        private void btn_maHoaCongDB_Click(object sender, EventArgs e)
        {
            openChildForm(new MaHoaCong_Database());
        }

        private void btn_DES_Click(object sender, EventArgs e)
        {
            openChildForm(new DesEncrypter_GUI());
        }

        private void btn_RSA_Click(object sender, EventArgs e)
        {
            openChildForm(new RSA());
        }

        private void btn_DESFile_Click(object sender, EventArgs e)
        {
            openChildForm(new FileEncryption());
        }

        private void btn_maHoaLai_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new SoNghichDao());
        }

        private void btn_TaoKhoaRSA_Click(object sender, EventArgs e)
        {
            openChildForm(new TaoKhoaRSA());
        }
    }
}
