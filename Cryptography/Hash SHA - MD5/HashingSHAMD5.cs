using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Hash_SHA___MD5
{
    public class HashingSHAMD5
    {
        public static byte[] ComputeSha256(byte[] data)
        {
            using (var hasher = SHA256.Create())
                return hasher.ComputeHash(data);
        }

        public static byte[] ComputeSha512(byte[] data)
        {
            using (var hasher = SHA512.Create())
                return hasher.ComputeHash(data);
        }

        public static byte[] ComputeMD5(byte[] data)
        {
            using (var hasher = MD5.Create())
                return hasher.ComputeHash(data);
        }
    }
}
