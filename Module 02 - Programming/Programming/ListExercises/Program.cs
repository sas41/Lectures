using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowEvenNumbers();
            //ShowMaxAndMin();
            //MostCommonOccurrence();
            ReverseNumberSum();
            Console.ReadLine();
        }

        static void ShowEvenNumbers()
        {
            // Read text from console, split it in to words.
            List<string> input = Console.ReadLine().Split().ToList();

            // Create a list for numbers.
            List<int> numbers = new List<int>();

            // Convert each word we read to an int and add them
            // to the list.
            foreach (var item in input)
            {
                numbers.Add(int.Parse(item));
            }

            // For each number in the list...
            foreach (var number in numbers)
            {
                // Check if the number is even.
                if (number % 2 == 0)
                {
                    // Print if it is.
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }
        static void ShowMaxAndMin()
        {
            // Read text from console, split it in to words.
            List<string> input = Console.ReadLine().Split().ToList();

            // Create a list for numbers.
            List<int> numbers = new List<int>();

            // Convert each word we read to an int and add them
            // to the list.
            foreach (var item in input)
            {
                numbers.Add(int.Parse(item));
            }


            // Assume the first numbers is both the min and max
            // of the entire list.
            int max = numbers[0];
            int min = numbers[0];

            // For each number in the list...
            foreach (var number in numbers)
            {

                // Check if the number is higher than max.
                if (number > max)
                {
                    // If it is, make it the new max.
                    max = number;
                }

                // Also check if the number is lower than min.
                if (number < min)
                {
                    // If it is, make it the new min.
                    min = number;
                }
            }


            // For each number in numbers...
            foreach (var number in numbers)
            {
                // If the number is the same as min...
                if (number == min)
                {
                    // Print it.
                    Console.Write(number + " ");
                }
            }

            // For each number in numbers...
            foreach (var number in numbers)
            {
                // If the number is the same as max...
                if (number == max)
                {
                    // Print it.
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();

        }
        static void MostCommonOccurrence()
        {
            // One-liner to read text, split, convert to int and save it to a list.
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            // The longest streak and the number.
            int longestNumber = 0;
            int longestStreak = 0;

            // Current number and it's streak.
            int currentNumber = numbers[0];
            int currentStreak = 0;

            // For each number in numbers...
            foreach (var number in numbers)
            {
                // If the number is the same as the one
                // in the current streak, increase it's
                // streak.
                if (number == currentNumber)
                {
                    currentStreak++;
                }
                else
                {
                    // If the number is not part of the
                    // current streak, the streak has ended.
                    // Check if the streak that is ending was
                    // longer than the longest one.
                    if (currentStreak > longestStreak)
                    {
                        // If it was, make it the longest one
                        // and it's number the longest streaking
                        // number.
                        longestStreak = currentStreak;
                        longestNumber = currentNumber;
                    }

                    // Reset the current streak to 1 with the new number.
                    currentNumber = number;
                    currentStreak = 1;
                }
            }

            // Print how many numbers were in the longest streak and what number it was.
            Console.WriteLine($"Longest streak was {longestStreak} times {longestNumber}.");

        }

        static void ReverseNumberSum()
        {
            // Read a line of text.
            string inputText = Console.ReadLine();

            // Reverse it in to a char array.
            char[] reversedText = inputText.Reverse().ToArray(); 

            // Create a new string from the char array.
            string reversedInput = new string(reversedText);

            // Split the reversed input text in to "words"
            List<string> input = reversedInput.Split().ToList();
            List<int> reverseNumbers = new List<int>();

            // Parse and add each "word" as a number to a int List.
            foreach (var item in input)
            {
                reverseNumbers.Add(int.Parse(item));
            }

            // Sum all the elements of the int List.
            int total = 0;
            foreach (var number in reverseNumbers)
            {
                total += number;
            }

            Console.WriteLine($"Total: {total}");

        }
    }
}
