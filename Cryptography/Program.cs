using System;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var hashWithSalt = new HashWithSalt();

            var salt = hashWithSalt.GenerateSalt();
            string password = "anish";

            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            var hashedPassword = await hashWithSalt.ComputeHasWithSaltAsync(salt, Encoding.UTF8.GetBytes(password));
            var hashedPassword1 = await hashWithSalt.ComputeHasWithSaltAsync(salt, Encoding.UTF8.GetBytes(password));
       
            Console.WriteLine($"HashedPassword: {Convert.ToBase64String(hashedPassword)} ");
            Console.WriteLine($"HashedPassword1: {Convert.ToBase64String(hashedPassword1)} ");
            Console.WriteLine(Convert.ToBase64String(hashedPassword).Equals(Convert.ToBase64String(hashedPassword1)));
            Console.ReadLine();
        }
    }
}
