using System;
using System.Text;

namespace Cryptography
{
    public class PasswordBasedKeyDerivationFunction
    {
        public static void Main(string[] args)
        {
            int numberOfIterations = 99;
            var hashFunction = new HashSaltWithRounds();

            string password = "Your Password Here";
            byte[] salt = hashFunction.GenerateSalt();

            var hashedPassword1 = hashFunction.HashDataWithRounds(Encoding.UTF8.GetBytes(password), salt, numberOfIterations);
            var hashedPassword2 = hashFunction.HashDataWithRounds(Encoding.UTF8.GetBytes(password), salt, numberOfIterations);

            Console.WriteLine($"hashedPassword1 :{hashedPassword1}");
            Console.WriteLine($"hashedPassword2 :{hashedPassword2}");
            Console.WriteLine(hashedPassword1.Equals(hashedPassword2));

            Console.ReadLine();

        }
    }
}
