using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace THBaoMat
{
    public partial class FileEncryption : Form
    {
        private DesOracle desOracle;
        OracleConnection conn;

        public FileEncryption()
        {
            InitializeComponent();
            conn = Database.Get_Connect();  // Kết nối với cơ sở dữ liệu Oracle
            desOracle = new DesOracle(conn);  // Khởi tạo đối tượng DesOracle
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn file chưa
                if (string.IsNullOrEmpty(txt_cdEncrypt.Text))
                {
                    MessageBox.Show("Please select a file to encrypt.");
                    return;
                }

                // Đọc nội dung của file cần mã hóa
                string filePath = txt_cdEncrypt.Text;
                string fileContent = File.ReadAllText(filePath);

                // Tạo khóa DES ngẫu nhiên
                string privateKey = GenerateRandomKey();

                // Mã hóa dữ liệu với DES
                byte[] encryptedData = desOracle.EncryptDES(fileContent, privateKey);

                if (encryptedData != null)
                {
                    // Lưu dữ liệu mã hóa vào một file mới
                    string encryptedFilePath = filePath + ".encrypted";
                    File.WriteAllBytes(encryptedFilePath, encryptedData);
                    MessageBox.Show("File encrypted successfully! Encrypted file saved as: " + encryptedFilePath);

                    // Lưu khóa mã hóa vào một file riêng biệt (có thể là .key)
                    string keyFilePath = filePath + ".key";
                    File.WriteAllText(keyFilePath, privateKey);
                    MessageBox.Show("Encryption key saved successfully! Key file saved as: " + keyFilePath);
                }
                else
                {
                    MessageBox.Show("Encryption failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_cd_Click(object sender, EventArgs e)
        {
            // Mở cửa sổ chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đặt đường dẫn file vào textbox
                txt_cdEncrypt.Text = openFileDialog.FileName;
            }
        }

        // Hàm tạo khóa DES ngẫu nhiên
        private string GenerateRandomKey()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] keyBytes = new byte[8]; // DES key length is 8 bytes (64 bits)
                rng.GetBytes(keyBytes);

                // Chuyển đổi mảng byte thành chuỗi để dễ lưu trữ
                return Convert.ToBase64String(keyBytes);
            }
        }

        private void btn_cdDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Encrypted Files (*.encrypted)|*.encrypted|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đặt đường dẫn file vào textbox
                txt_cdDecrypt.Text = openFileDialog.FileName;
            }
        }

        private void btn_cdKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Key Files (*.key)|*.key|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đặt đường dẫn file khóa vào textbox
                txt_cdKey.Text = openFileDialog.FileName;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã chọn file mã hóa và khóa chưa
                if (string.IsNullOrEmpty(txt_cdDecrypt.Text) || string.IsNullOrEmpty(txt_cdKey.Text))
                {
                    MessageBox.Show("Please select both the encrypted file and the key file.");
                    return;
                }

                // Đọc nội dung của file mã hóa
                string encryptedFilePath = txt_cdDecrypt.Text;
                byte[] encryptedData = File.ReadAllBytes(encryptedFilePath);

                // Đọc khóa mã hóa từ file khóa
                string privateKey = File.ReadAllText(txt_cdKey.Text);

                // Giải mã dữ liệu với DES
                string decryptedData = desOracle.DecryptDES(encryptedData, privateKey);

                if (decryptedData != null)
                {
                    // Lưu dữ liệu giải mã vào một file mới
                    string decryptedFilePath = encryptedFilePath + ".decrypted";
                    File.WriteAllText(decryptedFilePath, decryptedData);
                    MessageBox.Show("File decrypted successfully! Decrypted file saved as: " + decryptedFilePath);
                }
                else
                {
                    MessageBox.Show("Decryption failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
