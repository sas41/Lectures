using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //StandardForLoop();
            //ReverseForLoop();

            //NumbersEndingWithSeven();
            //Alphabet();

            //SumN();
            //LargestOfN();

            //NonStandardIncrement();
            //ChangeConditionMidLoop();

            //WhileLoopExample();
            //LoadingBar();

            Console.ReadLine();
        }


        // Стандартен "FOR" цикъл.
        static void StandardForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Обърнат "FOR" цикъл.
        static void ReverseForLoop()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Числа завършващи на 7.
        static void NumbersEndingWithSeven()
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Латинската азбука.
        static void Alphabet()
        {
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.WriteLine(letter);
                var test = Console.ReadLine();
            }
        }

        // Сума от N брой числа.
        static void SumN()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int index = 0; index < n; index++)
            {
                int current = int.Parse(Console.ReadLine());
                sum += current;
            }

            Console.WriteLine(sum);

        }

        // Най-голямто число от N брой числа.
        static void LargestOfN()
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current > max)
                {
                    max = current;
                }
            }
            Console.WriteLine("Largest Number:");
            Console.WriteLine(max);
        }

        // Нестандартно инкрементиране.
        static void NonStandardIncrement()
        {
            int end = 20;
            for (int i = 0; i < end; i = i +2)
            {
                Console.WriteLine(i);
            }
        }

        // Промяна на кондиция в движение/течение.
        static void ChangeConditionMidLoop()
        {
            int end = 10;
            for (int i = 0; i < end; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    end += 5;
                }
            }
        }

        // Пример за "WHILE" цикъл.
        static void WhileLoopExample()
        {
            int sum = 0;
            while (sum < 100)
            {
                int current = int.Parse(Console.ReadLine());
                sum += current;
                Console.WriteLine(sum);
            }

            Console.WriteLine("Final Sum: " + sum);
        }

        // Loading bar.
        static void LoadingBar()
        {
            int total_load = 0;
            int max_load = 100;
            while (total_load < max_load)
            {
                int current = int.Parse(Console.ReadLine());
                total_load += current;
                for (int i = 0; i < total_load; i++)
                {
                    Console.Write("█");
                }
                for (int i = 0; i < max_load - total_load; i++)
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine("Loading Done!");
        }
    }
}
