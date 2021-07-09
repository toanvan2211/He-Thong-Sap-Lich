using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.Class
{
    class MaHoa
    {
        private static MaHoa instance;
        public static MaHoa Instance
        {
            get { if (instance == null) instance = new MaHoa(); return instance; }
            private set { instance = value; }
        }

        public MaHoa() { }

        public string GetHash(string password)
        {
            MD5 myMD5 = MD5.Create();

            byte[] bytePassword = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hash = myMD5.ComputeHash(bytePassword);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
