using System;
using System.IO;

namespace createtitpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string newPath = @"C:\Users\opilane\samples\titpe";
            Directory.CreateDirectory(newPath);
            bool directoryExists = Directory.Exists(newPath);

            if (directoryExists)
            {
                Console.WriteLine("The directory exists.");
            }
            else
            {
                Console.WriteLine("The directory does not exists.");
                Directory.CreateDirectory(newPath);
            }





        }
    }
}
