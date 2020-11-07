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
            while (true)
            {
                Console.WriteLine("Select Loop type:");
                Console.WriteLine("    1: For Loop");
                Console.WriteLine("    2: Reverse For Loop");
                Console.WriteLine("    3: While Loop");
                Console.WriteLine("    4: Numbers Ending With Seven");
                Console.WriteLine("    5: Iterate with Letters");
                Console.WriteLine("    6: Sum of N Numbers");
                Console.WriteLine("    7: Largest Of N Numbers");
                Console.WriteLine("    8: Non Standard Increment");
                Console.WriteLine("    9: Change Condition Mid-Loop");
                Console.WriteLine("    0: Loading Bar");
                Console.WriteLine("    Any other number to Quit.");
                Console.WriteLine("    Any letter to crash.");
                Console.Write("Selection: ");

                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1: StandardForLoop(); break;
                    case 2: ReverseForLoop(); break;
                    case 3: WhileLoopExample(); break;
                    case 4: NumbersEndingWithSeven(); break;
                    case 5: IterateWithLetters(); break;
                    case 6: SumN(); break;
                    case 7: LargestOfN(); break;
                    case 8: NonStandardIncrement(); break;
                    case 9: ChangeConditionMidLoop(); break;
                    case 0: LoadingBar(); break;
                    default: return;
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }


        // Стандартен "FOR" цикъл.
        static void StandardForLoop()
        {
            Console.WriteLine("~====: For Loop :====~");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " ");
            }
        }

        // Обърнат "FOR" цикъл.
        static void ReverseForLoop()
        {
            Console.WriteLine("~====: Reverse For Loop :====~");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i + " ");
            }
        }

        // Числа завършващи на 7.
        static void NumbersEndingWithSeven()
        {
            Console.WriteLine("~====: Numbers ending in 7 :====~");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 10 == 7)
                {
                    Console.Write(i + " ");
                }
            }
        }

        // Латинската азбука.
        static void IterateWithLetters()
        {
            Console.WriteLine("~====: Iterate with Letters :====~");
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(letter + " ");
            }
        }

        // Сума от N брой числа.
        static void SumN()
        {
            Console.WriteLine("~====: Sum of N Numbers :====~");
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int index = 1; index <= n; index++)
            {
                Console.Write($"Enter {index}: ");
                int current = int.Parse(Console.ReadLine());
                sum += current;
            }

            Console.WriteLine(sum);

        }

        // Най-голямто число от N брой числа.
        static void LargestOfN()
        {
            Console.WriteLine("~====: Largest of N Numbers :====~");
            Console.Write("Enter N: ");
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
            Console.WriteLine("~====: Non Standard Incrementation :====~");
            int end = 20;
            for (int i = 0; i < end; i = i +2)
            {
                Console.WriteLine(i);
            }
        }

        // Промяна на кондиция в движение/течение.
        static void ChangeConditionMidLoop()
        {
            Console.WriteLine("~====: Change Condition Mid-Loop :====~");
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
            Console.WriteLine("~====: While Loop :====~");
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
            Console.WriteLine("~====: Loading Bar :====~");
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
