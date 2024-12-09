using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace THBaoMat
{
    public partial class RSACrypto : Form
    {
        private RSACryptoServiceProvider rsa;
        public RSACrypto()
        {
            InitializeComponent();
        }

        private void btnOpenPublicKey_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPublicKey.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Tạo cặp khóa RSA mới
            rsa = new RSACryptoServiceProvider();
            // Lấy khóa công khai và hiển thị
            string publicKey = Convert.ToBase64String(rsa.ExportCspBlob(false));
            txtPublicKey.Text = publicKey;
            // Lấy khóa bí mật và hiển thị
            string privateKey = Convert.ToBase64String(rsa.ExportCspBlob(true));
            txtPrivateKey.Text = privateKey;
        }

        private void btnOpenPrivateKey_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPrivateKey.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
        }

        private void btnOpenPlainText_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPlainText.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
        }

        private void btnOpenEncrypt_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtEncrypt.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Lấy plaintext từ TextBox
            string plaintext = txtPlainText.Text;
            if (plaintext == "")

            {
                MessageBox.Show("Vui lòng nhập vào plain text.");
                return;
            }


            if (txtPublicKey.Text == "")
            {
                MessageBox.Show("Vui lòng tạo khóa và nhập khóa công khai.");
                return;
            }

            rsa = new RSACryptoServiceProvider();
            rsa.ImportCspBlob(Convert.FromBase64String(txtPublicKey.Text));

            byte[] data = Encoding.UTF8.GetBytes(plaintext);
            int maxBlockSize = rsa.KeySize / 8 - 42;
            List<byte> encryptedData = new List<byte>();


            for (int i = 0; i < data.Length; i += maxBlockSize)
            {
                int currentBlockSize = Math.Min(maxBlockSize, data.Length - i);
                byte[] dataBlock = new byte[currentBlockSize];
                Array.Copy(data, i, dataBlock, 0, currentBlockSize);
                byte[] encryptedBlock = rsa.Encrypt(dataBlock, true);
                encryptedData.AddRange(encryptedBlock);
            }
            txtEncrypt.Text = Convert.ToBase64String(encryptedData.ToArray());
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = txtEncrypt.Text;
            if (string.IsNullOrEmpty(ciphertext))
            {
                MessageBox.Show("Vui lòng nhập vào ciphertext.");
                return;
            }

            if (string.IsNullOrEmpty(txtPrivateKey.Text))
            {
                MessageBox.Show("Vui lòng tạo khóa và nhập khóa bí mật.");
                return;
            }

            try
            {
                rsa = new RSACryptoServiceProvider();
                rsa.ImportCspBlob(Convert.FromBase64String(txtPrivateKey.Text));

                byte[] encryptedData = Convert.FromBase64String(ciphertext);
                int blockSize = rsa.KeySize / 8;

                List<byte> decryptedData = new List<byte>();
                for (int i = 0; i < encryptedData.Length; i += blockSize)
                {
                    byte[] encryptedBlock = new byte[blockSize];
                    Array.Copy(encryptedData, i, encryptedBlock, 0, blockSize);
                    byte[] decryptedBlock = rsa.Decrypt(encryptedBlock, true);
                    decryptedData.AddRange(decryptedBlock);
                }
                string decryptedText = Encoding.UTF8.GetString(decryptedData.ToArray());
                txtDecrypt.Text = decryptedText;
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Lỗi giải mã: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnSaveKey_Click(object sender, EventArgs e)
        {

            if (txtPublicKey.Text == "" || txtPrivateKey.Text == "")

            {
                MessageBox.Show("Vui lòng tạo khóa và nhập cả khóa công khai và khóa bí mật.");
                return;
            }
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt) | *.txt";
                saveFileDialog.Title = "Save Keys";
                // Tạo tên file duy nhất
                string uniqueFileName = string.Format("Keys_{0}", Path.GetRandomFileName().Substring(0, 8));
                saveFileDialog.FileName = uniqueFileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string publicKeyFilePath = Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), uniqueFileName + "_publicKey.txt");
                    File.WriteAllText(publicKeyFilePath, txtPublicKey.Text);
                    string privateKeyFilePath = Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), uniqueFileName + "_privateKey.txt");
                    File.WriteAllText(privateKeyFilePath, txtPrivateKey.Text);
                    MessageBox.Show("Đã lưu khóa công khai và khóa bí mật thành công.");
                }
            }
        }

        private void btnEncrypted_Click(object sender, EventArgs e)
        {

            if (txtEncrypt.Text == "")
            {
                MessageBox.Show("Encrypted chưa có hãy tiến hành mã hóa!!");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt"; saveFileDialog.Title = "Save Keys";
                // Tạo tên file duy nhất
                string uniqueFileName = string.Format("EncryptedText_{0}", Path.GetRandomFileName().Substring(0, 8));
                saveFileDialog.FileName = uniqueFileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string publicKeyFilePath = Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), uniqueFileName);
                    File.WriteAllText(publicKeyFilePath, txtEncrypt.Text);
                    MessageBox.Show("Đã lưu EncryptedText thành công.");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDecrypt.Clear();
            txtEncrypt.Clear();
            txtPlainText.Clear();
            txtPrivateKey.Clear();
            txtPublicKey.Clear();
        }
    }
}
