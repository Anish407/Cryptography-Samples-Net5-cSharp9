using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class HashWithSalt
    {
        public byte[] GenerateSalt()
        {
            int saltLength= 32;

            using(var randomNumberGenerator= new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[saltLength];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        public async Task<byte[]> ComputeHasWithSaltAsync(byte[] password, byte[] salt)
        {
            using(var sha512 = SHA512.Create())
                return  await sha512.ComputeHashAsync(new MemoryStream(Combine(salt, password)));
        }

        private byte[] Combine(byte[] salt, byte[] password)
        {
            var ret = new byte[salt.Length + password.Length];

            Buffer.BlockCopy(salt, 0, ret, 0,salt.Length);
            Buffer.BlockCopy(password, 0, ret, salt.Length,password.Length);

            return ret;
        }



    }
}
