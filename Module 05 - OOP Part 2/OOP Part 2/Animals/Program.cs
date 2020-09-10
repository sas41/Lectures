using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Golden Ret.", 100, 5, 5, "Goldy", "Gabriel", 100);
            Cat myCat = new Cat("Tubby", 150, 2, 3, "Sisi", "Dori", 50);
            Chicken myChicken = new Chicken("Tasty", 50, 1, 2);
            Rock myRock = new Rock("Hardy", "Getsoff", 0);

            // Rock does not inherit Animal, so it can't get in here.
            // You cannot play with them, because not all animals are pets.
            List<Animal> animals = new List<Animal> { myDog, myCat, myChicken};
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetSound());
            }
            Console.WriteLine("==================================");

            // Chicken does not implement IPet, so it can't get in here.
            // You cannot feed them, because not all pets are animals.
            List<IPet> pets = new List<IPet> { myDog, myCat, myRock };
            foreach (var pet in pets)
            {
                pet.Play();
            }
            Console.WriteLine("==================================");

            // Only Cat and Rock are yeetable
            // You can only yeet them.
            List<IYeetable> projectiles = new List<IYeetable> { myCat, myRock };
            foreach (var projectile in projectiles)
            {
                projectile.Yeet();
            }

            Console.ReadLine();
        }
    }
}
