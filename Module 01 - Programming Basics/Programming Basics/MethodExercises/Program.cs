using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "exit")
                {
                    break;
                }
                else if (command == "triangle")
                {
                    Console.Write("B: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("hB: ");
                    int hb = int.Parse(Console.ReadLine());

                    Console.WriteLine("Traingle Surface Area: " + TriangleSurface(b, hb) + "m²");
                }
                else if (command == "power")
                {
                    Console.Write("Number: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("Power: ");
                    int power = int.Parse(Console.ReadLine());
                    Console.WriteLine(Power(num, power));
                }
            }

        }



        ///////////////////////////
        // Surface of a Triangle //
        ///////////////////////////
        static double TriangleSurface(double b, double hb)
        {
            return (hb * b) / 2;
        }



        ///////////////////////////////
        // Bring X to the power of Y //
        ///////////////////////////////
        static int Power(int num, int pow)
        {
            int result = num;
            for (int i = 1; i < pow; i++)
            {
                result = result * num;
            }
            return result;
        }



        //////////////////////////////////////
        // Get Max of, Int, Char and String //
        //////////////////////////////////////
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetMax(string a, string b)
        {
            if ( a.CompareTo(b) == 1 )
            {
                return a;
            }
            else
            {
                return b;
            }
        }



        ////////////////////////////////////////////
        // Product of Sums of Odd and Even Digits //
        ////////////////////////////////////////////
        static int GetProductOfOddsAndEvens(int num)
        {
            return SumOfEvens(num) * SumOfOdds(num);
        }

        static int SumOfOdds(int num)
        {
            int result = 1;
            int currentNumber = num;
            int currentDigit;
            while (currentNumber != 0)
            {
                currentDigit = currentNumber % 10;
                currentNumber = currentNumber / 10;
                if (IsOdd(currentNumber))
                {
                    result = result + currentDigit;
                }
            }
            return result;
        }

        static int SumOfEvens(int num)
        {
            int result = 1;
            int currentNumber = num;
            int currentDigit;
            while (currentNumber != 0)
            {
                currentDigit = currentNumber % 10;
                currentNumber = currentNumber / 10;
                if (!IsOdd(currentNumber))
                {
                    result = result + currentDigit;
                }
            }
            return result;
        }

        static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
    }
}
