using System;

namespace SHA512HashOfFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decraration of main variables
            string filePath;
            string SHA512Hash;

            
            Console.WriteLine("Input a path where the file located to calculate its SHA-512 hash and press [Enter] button:");
            filePath = Console.ReadLine();

            SHA512CheckSumCalculation SHA512 = new SHA512CheckSumCalculation();
            SHA512Hash = SHA512.SHA512CalculationMethod(filePath);

            //Conversion from Base 64 string to Hexadecimal
            byte[] bytes = Convert.FromBase64String(SHA512Hash);
            string hex = BitConverter.ToString(bytes);

            Console.WriteLine("The SHA-512 hash of the file provided in a hexadecimal string is:");
            Console.WriteLine(hex);
            Console.WriteLine("Press any key to close the screen...");
            Console.ReadKey();
        }
    }
}
