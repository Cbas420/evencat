using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;


namespace evencat.Helpers
{
    public static class Encryption
    {
        private static readonly string secretKey = "999a999ale469993"; // misma clave que en Android

        public static string encrypt(string plainText)
        {
            var engine = new BlowfishEngine();
            var cipher = new PaddedBufferedBlockCipher(engine);
            var keyBytes = Encoding.UTF8.GetBytes(secretKey);
            var inputBytes = Encoding.UTF8.GetBytes(plainText);

            cipher.Init(true, new KeyParameter(keyBytes));

            var outputBytes = new byte[cipher.GetOutputSize(inputBytes.Length)];
            int length = cipher.ProcessBytes(inputBytes, 0, inputBytes.Length, outputBytes, 0);
            length += cipher.DoFinal(outputBytes, length);

            return Convert.ToBase64String(outputBytes, 0, length);
        }

        // Verificar contraseña con hash

        public static string decrypt(string base64CipherText)
        {
            var cipherData = Convert.FromBase64String(base64CipherText);
            var engine = new BlowfishEngine();
            var cipher = new PaddedBufferedBlockCipher(engine);
            var keyBytes = Encoding.UTF8.GetBytes(secretKey);

            cipher.Init(false, new KeyParameter(keyBytes));

            var outputBytes = new byte[cipher.GetOutputSize(cipherData.Length)];
            int length = cipher.ProcessBytes(cipherData, 0, cipherData.Length, outputBytes, 0);
            length += cipher.DoFinal(outputBytes, length);

            return Encoding.UTF8.GetString(outputBytes, 0, length);
        }

    }
}
