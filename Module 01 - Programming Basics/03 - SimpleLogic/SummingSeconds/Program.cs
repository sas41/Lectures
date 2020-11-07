using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummingSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            int secSum = sec1 + sec2 + sec3;
            int minutes = secSum / 60;
            int seconds = secSum % 60;

            string secStr = seconds.ToString();

            if (seconds < 10)
            {
                secStr = $"0{seconds}";
            }

            Console.WriteLine($"{minutes}:{secStr}");
            Console.ReadKey();
        }
    }
}
