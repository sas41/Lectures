using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book depressingBook = new Book("Animal Farm", 1945, "George Orwell");
            Book jollyBook = new Book("The Tales Marlo Bundy", 2018, "John Oliver", "Mr. Shadow Writer");
            string[] authors = new string[] {"Test1", "Test2"};
            Book jollyBook2ElectricBoogaloo = new Book("Marlo Bundy The Reckoning", 2019, authors);

            Library publicLibrary = new Library(depressingBook, jollyBook, jollyBook2ElectricBoogaloo);

            foreach (var book in publicLibrary)
            {
                Console.WriteLine(book.Title);
            }

            Console.ReadLine();
        }
    }
}
