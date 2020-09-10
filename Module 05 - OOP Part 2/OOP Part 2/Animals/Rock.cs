using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Rock : IPet, IYeetable
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public float Joy { get; set; }
        public Rock(string name, string owner, float initialJoy)
        {
            Name = name;
            Owner = owner;
            Joy = initialJoy;
        }
        public void Play()
        {
            Console.WriteLine("You pet the rock, it doesn't care.");
        }

        public void Yeet()
        {
            Console.WriteLine("You throw the rock, it doesn't care.");
        }
    }
}
