using System;
using System.Security.Cryptography;

namespace Cryptography
{
    public class HashSaltWithRounds
    {
        int saltLength = 32;
        public byte[] GenerateSalt()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[saltLength];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        public string HashDataWithRounds(byte[] password, byte[] salt, int rounds)
        {
            using(var rfc2898= new Rfc2898DeriveBytes(password, salt, rounds))
            {
                return Convert.ToBase64String(rfc2898.GetBytes(32));
            }
        }
    }
}
