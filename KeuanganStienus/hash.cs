using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KeuanganStienus
{
    public class hash
    {
        public static string passwordHashing(string pass)
        {
            SHA256Managed MyHash = new SHA256Managed();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = MyHash.ComputeHash(data);
            string hashstr = System.Text.Encoding.ASCII.GetString(hash);
            return hashstr;
        }
    }
}
