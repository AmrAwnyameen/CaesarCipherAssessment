using Encryption.CaesarCipher.CaesarMethodolgy;

namespace Encryption.CaesarCipher.Encryption
{
    public class EncryptionStrategy
    {
        private readonly string _inputs;
        private readonly int _shiftNumber;
        private readonly IEncryption _encryption;

        public EncryptionStrategy(IEncryption encryption, string inputs, int shiftNumber)
        {
            _inputs = inputs;
            _encryption = encryption;
            _shiftNumber = shiftNumber;
        }
        public string Encrypt()
        {
          return  _encryption.EncryptText(_inputs, _shiftNumber);
        }

    }
}
