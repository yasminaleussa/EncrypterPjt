using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncrypterPjt
{
    class Encrypter
    {
        
        public static string Encrypt(string enc)
        {
            string encryptedString = "";
            int letterInt = 0;
            char a = ' ';

            for (int i = 0; i < enc.Length; i++)
            {
                letterInt = (int)enc[i]+ 1;
                a = (char) letterInt;
                encryptedString += a.ToString();
            }
            
            return encryptedString;
        }

        public static string Decrypt(string dec)
        {
            string decryptedString = "";
            int letterInt = 0;
            char d = ' ';
            for (int i = 0; i < dec.Length; i++)
            {
                letterInt = (int) dec[i] - 1;
                d = (char) letterInt;
                decryptedString += d.ToString();

            }
            return decryptedString;
        }
       
    }
}
