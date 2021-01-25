using Cryptography.Hash_SHA___MD5;
using System;
using System.Text;

Console.WriteLine("---------MD5---------");
Console.WriteLine($"MD5: {Convert.ToBase64String(HashingSHAMD5.ComputeMD5(Encoding.UTF8.GetBytes("test")))}");
Console.WriteLine($"MD5: {Convert.ToBase64String(HashingSHAMD5.ComputeMD5(Encoding.UTF8.GetBytes("test")))}");

Console.WriteLine("---------sha256---------");
Console.WriteLine($"MD5: {Convert.ToBase64String(HashingSHAMD5.ComputeSha256(Encoding.UTF8.GetBytes("test")))}");
Console.WriteLine($"MD5: {Convert.ToBase64String(HashingSHAMD5.ComputeSha256(Encoding.UTF8.GetBytes("test")))}");


Console.WriteLine("---------sha512---------");
Console.WriteLine($"MD5: {Convert.ToBase64String(HashingSHAMD5.ComputeSha512(Encoding.UTF8.GetBytes("test")))}");
Console.WriteLine($"MD5: {Convert.ToBase64String(HashingSHAMD5.ComputeSha512(Encoding.UTF8.GetBytes("test")))}");