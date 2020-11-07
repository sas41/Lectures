using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemShop
{
    class Program
    {
        static void Main(string[] args)
        {
			string product = Console.ReadLine();
			string city = Console.ReadLine();
			int count = int.Parse(Console.ReadLine());

			double total;

			if (city == "sofia")
			{
				if (product == "coffee")
					total = count * 0.50;
				else if (product == "water")
					total = count * 0.80;
				else if (product == "beer")
					total = count * 1.20;
				else if (product == "sweets")
					total = count * 1.45;
				else
					total = count * 1.60;
			}
			else if (city == "plovdiv")
			{
				if (product == "coffee")
					total = count * 0.40;
				else if (product == "water")
					total = count * 0.70;
				else if (product == "beer")
					total = count * 1.15;
				else if (product == "sweets")
					total = count * 1.30;
				else
					total = count * 1.50;
			}
			else
			{
				if (product == "coffee")
					total = count * 0.15;
				else if (product == "water")
					total = count * 0.70;
				else if (product == "beer")
					total = count * 1.10;
				else if (product == "sweets")
					total = count * 1.35;
				else
					total = count * 1.55;
			}

			Console.WriteLine(total);
			Console.ReadKey();
		}
    }
}
