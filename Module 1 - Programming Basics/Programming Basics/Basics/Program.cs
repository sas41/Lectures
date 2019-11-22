using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // "string" is text of any length.
            //
            // "string" е текст с не-определена дължина.
            string someText = "Hello World!";

            // "char" is a single character/letter,
            // it can be any letter, number or sign.
            //
            // "char" е една единствена
            // буква, знак или число.
            char oneLetter = 'a';

            // "int" is an integer (whole number)
            // that is 32 bits, it can be between 
            // (-2,147,483,648) and (2,147,483,647)
            //
            // "int" е цяло число от 32 бита,
            // то може де е междо
            // (-2,147,483,648) и (2,147,483,647)
            int lessBits = 20000000;

            // "long" is an integer (whole number)
            // that is 64 bits, it can be between 
            // (-9,223,372,036,854,775,808) and 
            // (9,223,372,036,854,775,807)
            //
            // "long" е цяло число от 64 бита,
            // то може де е междо 
            // (-9,223,372,036,854,775,808) и 
            // (9,223,372,036,854,775,807)
            long lotsOfBits = 16000000000;

            // "float", "double" and "decimal"
            // are real numbers, they have
            // different levels of accuracy:
            // float < double < decimal (most accurate)
            //
            // "float", "double" и "decimal"
            // са реални числа, те имат
            // различни нива на точност:
            // float < double < decimal (най-точен)
            float lessAccurate = 1.5f;
            double moreAccurate = 1.5495;
            decimal mostAccurate = 1.5494449m;

            // Writing to the console:
            //
            // Писане на конзолата:
            Console.WriteLine("Let's Write some text!");

            // Writing to the console with a variable:
            // 
            // Писане на конзолата чрез променлива:
            string hello = "Hello World";
            Console.WriteLine(someText);

            // Reading from the console in to a variable:
            //
            // Четене от конзолата в променлива:
            string myText = Console.ReadLine();
            Console.WriteLine("This is your text:");
            Console.WriteLine(myText);

            //
            //
            //
            string myString = "Hello";
            string rest = myString + " World!";
            Console.WriteLine(rest);

            double myNumber = 1.5;
            string yourNumberIs = "The number is: " + myNumber;
            Console.WriteLine(yourNumberIs);
            
            string alternative = $"The number is: {myNumber}";

            Console.ReadLine();
        }
    }
}
