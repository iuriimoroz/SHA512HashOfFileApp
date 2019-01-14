using System;
using System.IO;
using System.Security.Cryptography;

namespace SHA512HashOfFileApp
{
    public class SHA512CheckSumCalculation //Class with a method which calculates SHA512 hash of a file
    {
        public string SHA512CalculationMethod(string filePath)
        {
            using (SHA512 SHA512 = SHA512Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                    return Convert.ToBase64String(SHA512.ComputeHash(fileStream));
            }
        }
    }
}
