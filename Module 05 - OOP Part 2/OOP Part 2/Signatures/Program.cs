using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signatures
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second= double.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());

            var result1 = MathHelper.Add(first, second);
            var result2 = MathHelper.Add(first, third);
            var result3 = MathHelper.Add(first, (int)Math.Round(second), third);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);


            Console.WriteLine(MathHelper.Power(second));
            Console.WriteLine(MathHelper.Power(second, first));

            Console.ReadLine();
        }
    }
}
