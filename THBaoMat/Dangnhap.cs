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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        bool check_TextBox(string user, string pass)
        {
            if (user == "")
            {
                MessageBox.Show("Chua dien thong tin UserName");
                txt_Username.Focus();
                return false;
            }
            else if (pass == "")
            {
                MessageBox.Show("Chua dien thong tin Password");
                txt_Password.Focus();
                return false;
            }
            return true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_Username.Text;
            string pass = txt_Password.Text;
            if (check_TextBox(user, pass))
            {
                Database.Set_Database(user, pass);
                if (Database.Connect())
                {
                    OracleConnection c = Database.Get_Connect();
                    MessageBox.Show("Dang nhap thanh cong\nServerVersion: " + c.ServerVersion);
                    HocVien hv = new HocVien();
                    hv.Show();
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai");
                }
            }
        }
    }
}
