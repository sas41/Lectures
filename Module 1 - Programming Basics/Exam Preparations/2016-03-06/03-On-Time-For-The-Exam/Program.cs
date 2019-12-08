using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_On_Time_For_The_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = (examHour * 60) + examMinute;
            int arrivalTime = (arrivalHour * 60) + arrivalMinute;

            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");
            }
            else if (arrivalTime < examTime - 30)
            {
                Console.WriteLine("Early");
            }
            else
            {
                Console.WriteLine("On time");
            }

            // Ако студентът пристига с поне минута разлика от часа на изпита...
            if (arrivalTime != examTime)
            {
                double difference = Math.Abs(examTime - arrivalTime);
                if (arrivalTime < examTime && arrivalTime > examTime - 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if (arrivalTime <= examTime - 60)
                {
                    int differenceHours = (int) (difference / 60);
                    int differenceMinutes = (int)(difference % 60);
                    Console.WriteLine($"{differenceHours}:{differenceMinutes:00} hours before the start");
                }
                else if (arrivalTime > examTime && arrivalTime < examTime + 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    int differenceHours = (int)(difference / 60);
                    int differenceMinutes = (int)(difference % 60);
                    Console.WriteLine($"{differenceHours}:{differenceMinutes:00} hours after the start");
                }
            }

            Console.ReadLine();
        }
    }
}
