using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTop();

            PrintBody();

            PrintBottom();

            Console.ReadKey();
        }

        static void PrintTop()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintBody()
        {
            //Console.Write("Charged to ");
            //string name = Console.ReadLine();

            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintBottom()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
