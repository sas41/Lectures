using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayStatistics();
            //MostCommonNumberSimple();
            //LetterIndexSimple();
            //LetterIndexComplex();
            //ArrayToNumber();
            RotateAndSum();

            Console.ReadLine();
        }

        static void ArrayStatistics()
        {
            Console.WriteLine();

            // Read a line of text and split it
            // in to words separated by spaces.
            // Save the words in a string array.
            string[] input = Console.ReadLine().Split();

            // Create an integer array, the same
            // size as the string array.
            int[] numbers = new int[input.Length];


            // Parse and copy each "word" from the
            // string array, to the integer array.
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            ///////////////////////////////
            // Calculating statistics... //
            ///////////////////////////////

            int sum = 0, min = 0, max = 0;
            double average = 0.0;

            // Sum: Add each number in the array
            // to the same variable to get the sum.
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            // Average: Add each number in the array
            // to the same variable and divide by the
            // ammount of variables to get the average.
            for (int i = 0; i < numbers.Length; i++)
            {
                average = average + numbers[i];
            }
            average = average / numbers.Length;

            // Min: Assume the number at index 0
            // is the lowest, starting from index 1,
            // compare each number to the lowest,
            // if the compared number is lower,
            // make it the lowest, future numbers
            // will be compared to it, since it is
            // now the lowest.
            min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            // Max: Just like Min, but we look for higher
            // numbers and save the highest.
            max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("Min number: " + min);
            Console.WriteLine("Max number: " + max);
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine();
        }

        static void MostCommonNumberSimple()
        {
            Console.WriteLine();

            // This is the simplest method of solving this problem.
            // There are other, more complex and efficient ways.

            // Read a line of text and split it
            // in to words separated by spaces.
            // Save the words in a string array.
            string[] input = Console.ReadLine().Split();

            // Create an integer array, the same
            // size as the string array.
            int[] numbers = new int[input.Length];


            // Parse and copy each "word" from the
            // string array, to the integer array.
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            // The exercise says all the numbers are
            // between 0 and 65535, so we make an
            // array that has indexes from 0 to 65535.
            int[] counts = new int[65536];

            // We go trough each number...
            for (int i = 0; i < numbers.Length; i++)
            {
                // for each number in "numbers"
                // we use the number as the index
                // for the "counts" array.
                // Inside the counts array,
                // we get the count on that index,
                // increment it up by one, and
                // save it back.
                int count = counts[ numbers[i] ];
                count++;
                counts[ numbers[i] ] = count;
            }
            // This way, each index of the "counts"
            // array holds the amount of times that
            // index has come up as a number, inside
            // the "numbers" array.

            // By finding which index of the "counts"
            // array holds the highest value, we find
            // which number inside the "numbers" array
            // comes up most often.

            // Assume index 0 comes up the most often
            // change it when another index beats it.

            int maxIndex = 0;
            for (int i = 0; i < 65536; i++)
            {
                // Note, we save the index and the number,
                // because the number is how many times
                // that number occurs, and the index
                // represents the number it self.

                // If one number is larger than the other,
                // the larger one is the new most common
                // number.

                // But if both numbers occur the same amount
                // of times, we need to search the "number"
                // array, and select the first one that we
                // find inside the "number" array.
                if (counts[i] > counts[maxIndex])
                {
                    maxIndex = i;
                }
                else if (counts[i] == counts[maxIndex])
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] == maxIndex)
                        {
                            // If the current max is found
                            // first, no change needed.

                            // End searching inside the
                            // "number" array.
                            break;
                        }
                        else if (numbers[j] == i)
                        {
                            // If the new index is found
                            // first, we change our max
                            // to the new index (i).
                            maxIndex = i;

                            // End searching inside the
                            // "number" array.
                            break;
                        }
                    }
                }
            }

            // In the end, max index is the number
            // that repeats the most amount of times
            // inside the "numbers" array.

            Console.WriteLine("The most common number is: " +  maxIndex);
            Console.WriteLine();
        }

        static void LetterIndexSimple()
        {
            Console.WriteLine();

            // Create an array of all chars, ordered alphabetically.
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string input = Console.ReadLine();

            // For each char in the input string...
            for (int i = 0; i < input.Length; i++)
            {
                // compare said char against the list of all chars.
                for (int j = 0; j < letters.Length; j++)
                {
                    // When the char from input matches the char
                    // from "letters", print the char and the
                    // position inside "letters" where they matched.
                    if (input[i] == letters[j])
                    {
                        Console.WriteLine(input[i] + " -> " + j);
                    }
                }
            }

            Console.WriteLine();
        }

        static void LetterIndexComplex()
        {
            Console.WriteLine();

            // Since chars are basically integeres in hiding,
            // we can find the each letters corresponding integer
            // using the ascii table.

            // The letters on the ascii table are ordered the same
            // way they are ordered in the alphabet, but there are
            // other characters that come before them.
            
            // There are 97 other characters before the lower case
            // letters, so by removing 97 (to make 'a' == 0) we 
            // can effectively convert any lower case letter to an
            // integer between 0 and 25.

            // But the first step is to convert the char to an int.
            // We do that by casting:
            //     char testChar = 'a';
            //     int testInt = (int) testChar;
            // The above example "casts" testChar to an int type.
            // In the example above, the resulting integer "testInt"
            // will be equal to 97, so by offsetting all lower-case
            // chars back by 97, we get them to equal a number between
            // 0 and 25.

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + " -> " + ((int) input[i] - 97 ));
            }

            Console.WriteLine();
        }

        static void ArrayToNumber()
        {
            // One-liner to read ints from a line of string.
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] temp = new int[numbers.Length - 1];

            // If the input is only one number, complain and end the sequence,
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0] + " is already condensed to number");
                return;
            }

            // Repeat until there is only one number left...
            while (numbers.Length > 1)
            {
                // For each number in "numbers" except the last one...
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    // Add current number with the next number
                    // and save it in the "temp" array.
                    temp[i] = numbers[i] + numbers[i + 1];
                }

                // Make "numbers" same length as temp.
                numbers = new int[temp.Length];
                // Copy numbers from "temp" to "numbers".
                temp.CopyTo(numbers, 0);
                // Shorten "temp" by one.
                temp = new int[temp.Length - 1];

                //Repeat the process.
            }

            Console.WriteLine("Final number: " + numbers[0]);
        }

        static void RotateAndSum()
        {
            // Read set of integers from the console.
            int[] initial = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            // Create an array to store the shifted/rotated array.
            // Create an array to store the sum of previous shifts.
            int[] rotateArray = new int[initial.Length];
            int[] sumArray = new int[initial.Length];

            // Shift and add k times.
            for (int i = 0; i < k; i++)
            {
                // Set the first integer of the rotated array
                // to that of the last integer of the initial array.
                rotateArray[0] = initial[initial.Length - 1];

                // starting from the first integer of the initial array
                // copy over all integers -1 to the rotated array, but
                // copy them over 1 position forward, since the inital
                // position of the rotated array is where the last int
                // of the initial array went to.
                Array.Copy(initial, 0, rotateArray, 1, initial.Length - 1);

                Console.WriteLine("Rotation " + i + ": [" + string.Join(", ", rotateArray) + "]");

                // Add each integer from the rotated array
                // to the sum array on their corresponding
                // index.
                for (int j = 0; j < rotateArray.Length; j++)
                {
                    sumArray[j] += rotateArray[j];
                }

                // copy the current rotated array over
                // as the next initial array, to repeat
                // the process.
                rotateArray.CopyTo(initial, 0);
            }

            Console.WriteLine("Final Sum Array: [" + string.Join(", ", sumArray) + "]");
        }
    }
}
