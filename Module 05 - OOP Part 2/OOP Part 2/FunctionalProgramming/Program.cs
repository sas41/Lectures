using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadAndFilterNumbers();
            SortShortWords();
            Console.ReadLine();
        }

        static void ReadAndFilterNumbers()
        {
            var collection = Console.ReadLine()
                                    .Split()
                                    .Select(x => int.Parse(x))
                                    .Where(y => y % 2 == 0)
                                    .OrderBy(y => y);

            Console.WriteLine(string.Join(" ", collection));
        }

        static void SortShortWords()
        {
            char[] separators = new char[] {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var resultCollection = words
                                    .Where(word => word.Length < 5)
                                    .Distinct()
                                    .OrderBy(word => word);

            Console.WriteLine(string.Join(", ", resultCollection));
        }
    }
}
