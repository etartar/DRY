using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DRY.EncryptionAndDecryption
{
    public class DESAlgorithm
    {
        public static string EncryptData(string strData, string strEndDcKey)
        {
            byte[] key = { };
            byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };
            byte[] inputByteArray;

            try
            {
                key = Encoding.UTF8.GetBytes(strEndDcKey);
                DESCryptoServiceProvider objDES = new DESCryptoServiceProvider();
                inputByteArray = Encoding.UTF8.GetBytes(strData);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, objDES.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                cryptoStream.FlushFinalBlock();
                return Convert.ToBase64String(memoryStream.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string DecryptData(string strData, string strEndDcKey)
        {
            byte[] key = { };
            byte[] IV = { 10, 20, 30, 40, 50, 60, 70, 80 };
            byte[] inputByteArray = new byte[strData.Length];

            try
            {
                key = Encoding.UTF8.GetBytes(strEndDcKey);
                DESCryptoServiceProvider objDES = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(strData);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, objDES.CreateDecryptor(key, IV), CryptoStreamMode.Write);
                cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                cryptoStream.FlushFinalBlock();
                Encoding encoding = Encoding.UTF8;
                return encoding.GetString(memoryStream.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
