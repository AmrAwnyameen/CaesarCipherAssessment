using Encryption.CaesarCipher.Encryption;
using Encryption.CaesarCipher.Helper;
using Serilog;
using System;

namespace Encryption.CaesarCipher
{
    class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                Log.Logger = new LoggerConfiguration()
                  .WriteTo.File("consoleapp.log")
                  .CreateLogger();


                Console.Write("Input from A-Z: ");
                string input = Console.ReadLine();

                var strategy = new EncryptionStrategy(new EncryptWithUpperCase(), input, 5);
                var result = strategy.Encrypt();

                while (result.Equals(new EncryptWithUpperCase().NotValidMessage))
                {
                    Console.WriteLine(result + " Please try again ");
                    result = Repetition.TryAgain(new EncryptWithUpperCase());
                }

                Console.WriteLine(result);
                Console.ReadLine();

              
            }
            catch (Exception ex)
            {
                Console.Write("Please try again ");
                Repetition.TryAgain(new EncryptWithUpperCase());

                Log.Information(ex.InnerException.InnerException.Message);
            }
        }


    }
}
