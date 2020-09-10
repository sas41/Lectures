using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPatternCount();
            CensorBadWords();

            Console.ReadLine();
        }

        static void FindPatternCount()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            int count = 0;
            int lastFoundIndex = text.IndexOf(pattern);

            while(lastFoundIndex != -1)
            {
                count++;
                lastFoundIndex = text.IndexOf(pattern, lastFoundIndex + 1);
            }

            Console.WriteLine(count);

        }
        static void CensorBadWords()
        {
            string text = Console.ReadLine();
            string badWord = Console.ReadLine();

            text = text.Replace(badWord, new string('*', badWord.Length));

            Console.WriteLine(text);

        }
    }
}
