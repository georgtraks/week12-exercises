using System;
using System.IO;

namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetRandomQuote());


        }
        public static string GetRandomQuote()
        {
            string filepath = @"C:\Users\opilane\samples\Quotes.txt";
            string[] Quotes = File.ReadAllLines(filepath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Quotes.Length);



            return Quotes[randomIndex];

        }
    }
}