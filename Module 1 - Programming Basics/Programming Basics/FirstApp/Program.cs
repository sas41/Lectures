using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "Hello World!";
            char oneLetter = 'a';

            int lessBits = 20000000;
            long lotsOfBits = 16000000000;

            float lessAccurate = 1.5f;
            double moreAccurate = 1.5495;
            decimal mostAccurate = 1.5494449m;

            Console.WriteLine("Let's Write some text!");
            Console.WriteLine(someText);

            string myText = Console.ReadLine();
            Console.WriteLine("This is your text:");
            Console.WriteLine(myText);

            Console.ReadLine();
        }
    }
}
