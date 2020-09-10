using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //MultiplyEvensAndOdds();
            //DebugDateTimeEntry();
            BePositive();
            Console.ReadLine();
        }

        static void MultiplyEvensAndOdds()
        {
            int input = (int.Parse(Console.ReadLine()));
            int evens = 0, odds = 0;

            while (input != 0)
            {
                int current = input % 10;

                if (current % 2 == 0)
                {
                    evens += current;
                }
                else
                {
                    odds += current;
                }

                input = input / 10;
            }

            int result = evens * odds;

            Console.WriteLine($"Result = {result}");
        }

        static void DebugDateTimeEntry()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);

        }

        static void BePositive()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum > 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        currentNum += numbers[j + 1];

                        if (currentNum > 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}
