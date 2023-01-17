using Encryption.CaesarCipher.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class TextEncryption
    {
        //
        [Fact]
        public void EncryptWithUpperCase_ShouldValidEncryptText()
        {
            var strategy = new EncryptionStrategy(new EncryptWithUpperCase(), "ABC", 5);
            var result = strategy.Encrypt();

            Assert.Equal("Encrypted text : FGH", result);
        }

        [Fact]
        public void EncryptNotValidText_ShouldValidNotValidMessage()
        {
            var strategy = new EncryptionStrategy(new EncryptWithUpperCase(), "abc", 5);
            var result = strategy.Encrypt();

            Assert.Equal(new EncryptWithUpperCase().NotValidMessage, result);
        }

        [Fact]
        public void EncryptNumbers_ShouldValidNotValidMessage()
        {
            var strategy = new EncryptionStrategy(new EncryptWithUpperCase(), "abc1234", 5);
            var result = strategy.Encrypt();

            Assert.Equal(new EncryptWithUpperCase().NotValidMessage, result);
        }


        [Fact]
        public void EncryptWithLoweerCase_ShouldValidEncryptText()
        {
            var strategy = new EncryptionStrategy(new EncryptWithLowerCase(), "abc", 5);
            var result = strategy.Encrypt();

            Assert.Equal("Encrypted text : fgh", result);
        }

    }
}
