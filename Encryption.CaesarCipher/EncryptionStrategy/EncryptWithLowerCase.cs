using Encryption.CaesarCipher.CaesarMethodolgy;
using System;
using System.Linq;
using System.Text;

namespace Encryption.CaesarCipher.Encryption
{
    public class EncryptWithLowerCase : IEncryption
    {
        const int minRange = 97;
        const int maxRange = 122;

        public string NotValidMessage { get; set; } = "Only a-z supported";

        public string EncryptText(string input, int shiftNumber)
        {
            if (IsValidInputs(input) && IsValidRange(input))
                return ShiftText(input, shiftNumber);

            else
                return NotValidMessage;
        }

        public bool IsValidInputs(string input)
        {
            return !string.IsNullOrEmpty(input) && !int.TryParse(input, out _) ? true : false;
        }

        public bool IsValidRange(string input)
        {
            return input.All(s => s >= minRange && s <= maxRange) ? true : false;
        }

        public string ShiftText(string inputs, int shiftNumber)
        {
            var builder = new StringBuilder(inputs.Length);

            foreach (char c in inputs)
            {
                int shifted = c + shiftNumber;
                if (shifted > maxRange)
                    shifted = minRange + shifted - (maxRange + 1);

                builder.AppendFormat("{0:N2}", (char)shifted);
            }
            return "Encrypted text : " + builder.ToString();
        }

    }
}
