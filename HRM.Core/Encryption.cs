using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace HRM.Core
{
    public static class Encryption
    {
        public static string Encrypt(string stringToEncrypt)
        {
            if (stringToEncrypt == null)
            {
                return null;
            }
            else if (stringToEncrypt == string.Empty)
            {
                return string.Empty;
            }
            else
            {
                return Convert.ToBase64String(StringToBytes_Aes(stringToEncrypt));
            }
        }

        public static string Decrypt(string stringToDecrypt)
        {
            // For nulls & empty strings, just return them back to caller
            if (stringToDecrypt == null)
            {
                return null;
            }
            if (stringToDecrypt == string.Empty)
            {
                return string.Empty;
            }

            try
            {
                return StringFromBytes_Aes(Convert.FromBase64String(stringToDecrypt));
            }
            catch (ArgumentNullException)
            {
                return null;
            }
            catch (FormatException)
            {
                return null;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
            catch (OverflowException)
            {
                return null;
            }
        }

        private static readonly byte[] Key = System.Text.Encoding.ASCII.GetBytes("%GLtiM7YuwyH#eBUuHAFuqjtUOYLReH8");   // 32 chars - 256 bit key
        private static readonly byte[] Iv = System.Text.Encoding.ASCII.GetBytes("E&naQSWy$QPY9K0d");                      // 16 chars - 128 bit vector

        private static byte[] StringToBytes_Aes(string plainText)
        {
            // Check arguments. 
            Require.NotNullOrEmpty(plainText, "plainText");

            // Create an AES (aka Rijndael) algorithm object 
            byte[] encryptedBytes;
            using (var aesAlgorithm = Aes.Create())
            {
                // Create a encryptor with the specified Key and Iv
                // to perform the stream transform.
                aesAlgorithm.Key = Key;
                aesAlgorithm.IV = Iv;
                using (var encryptor = aesAlgorithm.CreateEncryptor(aesAlgorithm.Key, aesAlgorithm.IV))
                {
                    // Create the streams used for encryption.
                    using (var encryptionStream = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(encryptionStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (var encryptionStreamWriter = new StreamWriter(cryptoStream))
                            {
                                // Write all data to the stream.
                                encryptionStreamWriter.Write(plainText);
                            }
                            encryptedBytes = encryptionStream.ToArray();

                        }
                    }
                }
            }

            // Return the encrypted bytes from the memory stream. 
            return encryptedBytes;
        }

        private static string StringFromBytes_Aes(byte[] cipherText)
        {
            // Check arguments. 
            Require.NotNull(cipherText, "ciperText");

            // Declare a string used to hold the decrypted text. 
            string decryptedText = null;

            // Create an AES (aka Rijndael) algorithm object 
            using (Aes aesAlgorithm = Aes.Create())
            {
                // Create a decryptor to perform the stream transform
                // with the specified key and IV. 
                aesAlgorithm.Key = Key;
                aesAlgorithm.IV = Iv;
                using (var decryptor = aesAlgorithm.CreateDecryptor(aesAlgorithm.Key, aesAlgorithm.IV))
                {
                    // Create the streams used for decryption. 
                    using (var decryptionStream = new MemoryStream(cipherText))
                    {
                        using (var cryptoStream = new CryptoStream(decryptionStream, decryptor, CryptoStreamMode.Read))
                        {
                            using (var decryptionStreamWriter = new StreamReader(cryptoStream))
                            {
                                // Read the decrypted bytes from the decrypting stream iont our output string.
                                decryptedText = decryptionStreamWriter.ReadToEnd();
                            }
                        }
                    }
                }
            }

            return decryptedText;
        }
    }
}
