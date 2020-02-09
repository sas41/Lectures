using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is how to create
            // an array of integers.
            int[] myNumbers;

            // It is created, but
            // it's not initialized.
            // It cannot be used until
            // it has been initialized.

            // To initialize it, we need
            // to create a new array and
            // either give it a size or
            // a set of elements from
            // which it can deffer it's
            // size.

            myNumbers = new int[4];
            // myNumbers has 4 elements,
            // but the elments are all
            // un-initialized,
            // but integers are 0
            // when un-initialized.


            myNumbers = new int[] {5,8,12,16};
            // This was myNumbers
            // has 4 elements and
            // they are initialized.
            // myNumbers has valid
            // indexes from 0 to 3.

            // Max index of an array
            // is always the amount of
            // elements it has, -1.


            // To access elements we
            // look them up inside the
            // array by their index number.
            Console.WriteLine( myNumbers[0] );
            Console.WriteLine( myNumbers[1] );
            Console.WriteLine( myNumbers[2] );
            Console.WriteLine( myNumbers[3] );

            // The same can be done by
            // looping trough the array
            // using a variable as the index.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }


            // Defining a string array:
            string[] daysOfTheWeek = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            // Alternatively:
            daysOfTheWeek = new string[7];
            daysOfTheWeek[0] = "Monday";
            daysOfTheWeek[1] = "Tuesday";
            daysOfTheWeek[2] = "Wednesday";
            daysOfTheWeek[3] = "Thursday";
            daysOfTheWeek[4] = "Friday";
            daysOfTheWeek[5] = "Saturday";
            daysOfTheWeek[6] = "Sunday";




            Console.ReadLine();
        }
    }
}
