namespace EncryptionLib.Tests
{
    public class UnitEncryptLibTest
    {
        [Fact]
        public void EncryptDecrypt_Roundtrip()
        {
            // Arrange
            var crypto = new CryptoClass();
            var originalText = "Hello, world!";

            // Act
            var encryptedText = crypto.Encrypt(originalText);
            var decryptedText = crypto.Decrypt(encryptedText);

            // Assert
            Assert.Equal(originalText, decryptedText);
        }

        [Fact]
        public void EncryptDecrypt_NullInput()
        {
            // Arrange
            var crypto = new CryptoClass();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => crypto.Encrypt(null));
            Assert.Throws<ArgumentNullException>(() => crypto.Decrypt(null));
        }

        [Fact]
        public void EncryptDecrypt_EmptyInput()
        {
            // Arrange
            var crypto = new CryptoClass();

            // Act
            var encryptedText = crypto.Encrypt("");
            var decryptedText = crypto.Decrypt(encryptedText);

            // Assert
            Assert.Equal("", decryptedText);
        }
    }
}