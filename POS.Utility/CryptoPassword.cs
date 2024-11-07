using System.Security.Cryptography;
using System.Text;

namespace POS.Utility
{
    public class CryptoPassword
    {
        public string HasPassword(string password)
        {
            return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password)));
        }
    }
}
