using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Data;

namespace THBaoMat
{
    public class RSAOracle
    {
        private readonly OracleConnection conn;

        public RSAOracle(OracleConnection connection)
        {
            conn = connection;
        }

        public string GenerateKey(int keySize)
        {
            try
            {
                string function = "CRYPTO.RSA_GENERATE_KEYS";

                using (OracleCommand cmd = new OracleCommand(function, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Return value
                    OracleParameter resultParam = new OracleParameter
                    {
                        ParameterName = "Result",
                        OracleDbType = OracleDbType.Varchar2,
                        Size = 10000,
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(resultParam);

                    // Input parameter
                    OracleParameter sizeParam = new OracleParameter
                    {
                        ParameterName = "Key_Size",
                        OracleDbType = OracleDbType.Int32,
                        Value = keySize,
                        Direction = ParameterDirection.Input
                    };
                    cmd.Parameters.Add(sizeParam);

                    cmd.ExecuteNonQuery();

                    return resultParam.Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating key: {ex.Message}");
                return null;
            }
        }

        public string Encrypt(string plainText, string publicKey)
        {
            try
            {
                string function = "CRYPTO.RSA_ENCRYPT";

                using (OracleCommand cmd = new OracleCommand(function, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Return value
                    OracleParameter resultParam = new OracleParameter
                    {
                        ParameterName = "Result",
                        OracleDbType = OracleDbType.Varchar2,
                        Size = 10000,
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(resultParam);

                    // Input parameters
                    cmd.Parameters.Add(new OracleParameter
                    {
                        ParameterName = "PLAIN_TEXT",
                        OracleDbType = OracleDbType.Varchar2,
                        Value = plainText,
                        Direction = ParameterDirection.Input
                    });

                    cmd.Parameters.Add(new OracleParameter
                    {
                        ParameterName = "PRIVATE_KEY",
                        OracleDbType = OracleDbType.Varchar2,
                        Value = publicKey,
                        Direction = ParameterDirection.Input
                    });

                    cmd.ExecuteNonQuery();

                    return resultParam.Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encrypting data: {ex.Message}");
                return null;
            }
        }

        public string Decrypt(string encryptedText, string privateKey)
        {
            try
            {
                string function = "CRYPTO.RSA_DECRYPT";

                using (OracleCommand cmd = new OracleCommand(function, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Return value
                    OracleParameter resultParam = new OracleParameter
                    {
                        ParameterName = "Result",
                        OracleDbType = OracleDbType.Varchar2,
                        Size = 10000,
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(resultParam);

                    // Input parameters
                    cmd.Parameters.Add(new OracleParameter
                    {
                        ParameterName = "ENCRYPTED_TEXT",
                        OracleDbType = OracleDbType.Varchar2,
                        Value = encryptedText,
                        Direction = ParameterDirection.Input
                    });

                    cmd.Parameters.Add(new OracleParameter
                    {
                        ParameterName = "PRIVATE_KEY",
                        OracleDbType = OracleDbType.Varchar2,
                        Value = privateKey,
                        Direction = ParameterDirection.Input
                    });

                    cmd.ExecuteNonQuery();

                    return resultParam.Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error decrypting data: {ex.Message}");
                return null;
            }
        }
    }
}
