using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Core
{
    public class Hashing
    {

        public static string GenerateHash(string text, string salt)
        {
            // Check parameters
            Require.NotNullOrEmpty(text, "text");
            Require.NotNullOrEmpty(salt, "salt");

            string stringToHash = salt + text;
            byte[] bytesToHash = Encoding.UTF8.GetBytes(stringToHash);
            return HashBytes(bytesToHash);
        }

        public static string GenerateSalt()
        {
            // Generate a 24 byte random salt string
            using (var csprng = new RNGCryptoServiceProvider())
            {
                var salt = new byte[24];
                csprng.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }

        public static bool Verify(string text, string salt, string hash)
        {
            // Check parameters
            Require.NotNullOrEmpty(text, "text");
            Require.NotNullOrEmpty(salt, "salt");
            Require.NotNullOrEmpty(hash, "hash");

            // Check if the hashed value matches what our hashing algorithm would generate
            return hash == GenerateHash(text, salt);
        }

        private static string HashBytes(byte[] bytesToHash)
        {
            // Check parameters
            Require.NotNull(bytesToHash, "bytesToHash");

            // Hash the bytes into a web friendly string
            using (var hasher = SHA256.Create())
            {
                var hashBytes = hasher.ComputeHash(bytesToHash);
                string hash = Convert.ToBase64String(hashBytes);
                hasher.Clear();
                return hash;
            }
        }
    }
}
