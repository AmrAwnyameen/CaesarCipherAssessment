using Encryption.CaesarCipher.CaesarMethodolgy;
using Encryption.CaesarCipher.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.CaesarCipher.Helper
{
   public static class Repetition
    {

       public static string TryAgain(IEncryption methodology)
        {
            Console.Write("Input from A-Z: ");
            string input = Console.ReadLine();

            var strategy = new EncryptionStrategy(methodology, input, 5);
            return strategy.Encrypt();
        }
    }
}
