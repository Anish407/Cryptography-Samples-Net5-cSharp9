using System.Security.Cryptography;

namespace Cryptography.RandomNumbers
{
    public class RandomNumberGenerator
    {
        public static  byte[] GetRandomNumberByLength(int length)
        {
            // system.random is predicatable.. this is better but slower 
            byte[] randomNumber = new byte[length];

            using (var random = new RNGCryptoServiceProvider())
                random.GetBytes(randomNumber);

            return randomNumber;
        }
    }
}
