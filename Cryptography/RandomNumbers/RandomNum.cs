using Cryptography.RandomNumbers;
using System;

Console.WriteLine(Convert.ToBase64String( RandomNumberGenerator.GetRandomNumberByLength(2)));
Console.ReadKey();