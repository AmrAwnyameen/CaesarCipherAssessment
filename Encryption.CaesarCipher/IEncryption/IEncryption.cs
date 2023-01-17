using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.CaesarCipher.CaesarMethodolgy
{
    public interface IEncryption
    {
        public string EncryptText(string inputs, int shiftNumber);
        bool IsValidInputs(string input);
        bool IsValidRange(string input);
        string ShiftText(string input, int shiftNumber);
        public string NotValidMessage { get; set; }
    }
}
