using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "0000";
            byte[] raw = UTF8Encoding.UTF8.GetBytes(password);

            byte[] hash;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = md5Hash.ComputeHash(raw);
            }

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sBuilder.Append(hash[i].ToString("x2"));

            Console.WriteLine(sBuilder.ToString());
            //f71dbe52628a3f83a77ab494817525c6
            //f71dbe52628a3f83a77ab494817525c6
            //f71dbe52628a3f83a77ab494817525c6
            //98f2ca614f219bdff9f3637a47338182
            //98f2ca614f219bdff9f3637a47338182
            //526f3d42819a87a512614593698d8f20
            //526f3d42819a87a512614593698d8f20
            //f1399139dc4473e67a9fbcd947fda517
            Console.ReadKey();
        }
    }
}
