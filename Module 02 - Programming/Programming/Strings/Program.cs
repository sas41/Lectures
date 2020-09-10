using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello ";
            string second = "World!";
            
            Console.WriteLine(first + second);

            // This is the same as the previous
            // statement:
            string con = first + second;
            Console.WriteLine(con);

            //con[0] = 'M';

            // Special Characters as chars:
            char newLine = '\n';
            char returnCarriage = '\r';
            char nullTerminator = '\0';
            char space = ' ';
            char tab = '\t';


            // Chars and their codes:
            foreach (var character in first)
            {
                Console.WriteLine( (int)character );
            }


            string chat = "I went to the book store today!";

            // Find the index of a word:
            int indexOfBook = chat.IndexOf("book");
            Console.WriteLine(indexOfBook);

            // Find the index of a word starting from an index:
            // This will start looking after the 9th index,
            // so it will find the "to" in "store".
            int indexOfTo = chat.IndexOf("to", 10);
            Console.WriteLine(indexOfTo);


            // Find the last copy of a word's beggining index:
            // This will find the "to" in "today!".
            int lastIndexOfTo = chat.LastIndexOf("to");
            Console.WriteLine(lastIndexOfTo);

            // Replace text that matches a pattern:
            // Replace every instance of "book" with "****".
            chat = chat.Replace("book", "****");
            Console.WriteLine(chat);

            // Remove part of a text:
            // Start from index 24, remove 6 characters.
            chat = chat.Remove(24, 6);
            Console.WriteLine(chat);

            // Take part of a text:
            // Start from index 10, take 14 characters.
            chat = chat.Substring(10, 14);

            
            string helloWorld = "        Hello Word!      ";
            Console.WriteLine(helloWorld);

            // Trim empty spaces before and after the string:
            helloWorld = helloWorld.Trim();
            Console.WriteLine(helloWorld);

        }
    }
}
