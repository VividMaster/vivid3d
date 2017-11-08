using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
namespace Vivid.Crypto
{
    public class EncryptedString
    {
        public string Content = "";
        public string Key = "";
        public string IV = "";
    }
    public class DecryptedString
    {
        public string Content = "";
    }
    public class VCrypto
    {
        public static EncryptedString Encrypt(string con,string key="")
        {
            EncryptedString es = new EncryptedString();
            byte[] dat = Encoding.ASCII.GetBytes(con);
            byte[] ed = new byte[dat.Length];
            int ei = dat.Length - 1;
            for (int i = 0; i < dat.Length; i++)
            {
                ed[ei] = dat[i];
                ei--;
            }
            es.Content = Encoding.ASCII.GetString(ed);


            es.Key = key;
           
            return es;
        }
        public static DecryptedString Decrypt(string con,string key="")
        {
            DecryptedString ds = new DecryptedString();

            byte[] dat = Encoding.ASCII.GetBytes(con);
            byte[] ed = new byte[dat.Length];
            int ei = dat.Length - 1;
            for (int i = 0; i < dat.Length; i++)
            {
                ed[ei] = dat[i];
                ei--;
            }
            ds.Content = Encoding.ASCII.GetString(ed);
            return ds;
        }
    }
  
}
