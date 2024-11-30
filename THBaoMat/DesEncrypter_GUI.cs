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
    public partial class DesEncrypter_GUI : Form
    {

        OracleConnection conn;
        DesOracle DES;

        public DesEncrypter_GUI()
        {
            InitializeComponent(); 
            CenterToScreen();
            conn = Database.Get_Connect(); 
            DES = new DesOracle(conn);
        }

        private void btn_thuchien_Click(object sender, EventArgs e)
        {
            string text = txt_vanban.Text;
            string key = txt_key.Text;
            byte[] b = DES.EncryptDES(text, key);
            txt_ketqua.Text = Convert.ToBase64String(b);
            txt_vbgoc.Text = DES.DecryptDES(b, key);
        }

        private void DesEncrypter_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
