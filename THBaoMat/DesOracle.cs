using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace THBaoMat
{
    class DesOracle
    {
        private OracleConnection conn;

        public DesOracle(OracleConnection conn)
        {
            this.conn = conn;
        }

        // Mã hóa dữ liệu bằng DES
        public byte[] EncryptDES(string plainText, string priKey)
        {
            try
            {
                string function = "DES.encrypt";  // Tên thủ tục trong CSDL
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = function;
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số đầu ra (kết quả)
                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "Result"; // Tên tham số đầu ra trong thủ tục
                resultParam.OracleDbType = OracleDbType.Raw;
                resultParam.Size = 500;  // Điều chỉnh kích thước theo yêu cầu
                resultParam.Direction = ParameterDirection.ReturnValue;  // Tham số trả về
                cmd.Parameters.Add(resultParam);

                // Thêm tham số dữ liệu đầu vào (chuỗi cần mã hóa)
                OracleParameter p_plainText = new OracleParameter();
                p_plainText.ParameterName = "p_plainText";  // Tên tham số trong thủ tục
                p_plainText.OracleDbType = OracleDbType.Varchar2;
                p_plainText.Value = plainText;
                p_plainText.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p_plainText);

                // Thêm khóa mã hóa vào tham số
                OracleParameter p_key = new OracleParameter();
                p_key.ParameterName = "priKey";  // Tên tham số trong thủ tục
                p_key.OracleDbType = OracleDbType.Varchar2;
                p_key.Value = priKey;
                p_key.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p_key);

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Kiểm tra và trả về dữ liệu mã hóa
                if (resultParam.Value != DBNull.Value)
                {
                    OracleBinary ret = (OracleBinary)resultParam.Value;
                    return (byte[])ret.Value;  // Trả về dữ liệu mã hóa dưới dạng mảng byte
                }
                else
                {
                    MessageBox.Show("Encryption failed, no result returned.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show(ex.GetBaseException().ToString());
            }

            return null;  // Trả về null nếu mã hóa thất bại
        }

        // Giải mã dữ liệu bằng DES
        public string DecryptDES(byte[] encryptedData, string priKey)
        {
            try
            {
                string function = "DES.decrypt";  // Tên thủ tục trong CSDL
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = function;
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số đầu ra (kết quả giải mã)
                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "Result";  // Tên tham số trong thủ tục
                resultParam.OracleDbType = OracleDbType.Varchar2;
                resultParam.Size = 4000;  // Kích thước kết quả
                resultParam.Direction = ParameterDirection.ReturnValue;  // Tham số trả về
                cmd.Parameters.Add(resultParam);

                // Thêm dữ liệu mã hóa vào tham số đầu vào
                OracleParameter p_encryptedText = new OracleParameter();
                p_encryptedText.ParameterName = "p_encryptedText";  // Tên tham số trong thủ tục
                p_encryptedText.OracleDbType = OracleDbType.Raw;
                p_encryptedText.Value = encryptedData;
                p_encryptedText.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p_encryptedText);

                // Thêm khóa vào tham số
                OracleParameter p_key = new OracleParameter();
                p_key.ParameterName = "priKey";  // Tên tham số trong thủ tục
                p_key.OracleDbType = OracleDbType.Varchar2;
                p_key.Value = priKey;
                p_key.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p_key);

                // Thực thi thủ tục
                cmd.ExecuteNonQuery();

                // Kiểm tra và trả về kết quả giải mã
                if (resultParam.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultParam.Value;
                    return ret.ToString();  // Trả về kết quả giải mã dưới dạng chuỗi
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show(ex.GetBaseException().ToString());
            }
            return null;  // Trả về null nếu giải mã thất bại
        }
    }
}
