using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncrypterPjt
{
    class Program
    {
        static void Main(string[] args)
        {
            string newText = Encrypter.Encrypt("Smart");
            Console.WriteLine("Text encrypt: "+newText);
            string decText = Encrypter.Decrypt(newText);
            Console.WriteLine("Text decrypt: " + decText);
            Console.Read();
        }
    }
}
