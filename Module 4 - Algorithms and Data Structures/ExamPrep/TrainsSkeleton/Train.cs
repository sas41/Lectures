using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    class Train
    {
        public string Name  { get; private set; }
        public string Type  { get; private set; }
        public int Cars     { get; private set; }
        public int Number   { get; private set; }

        public Train(int number, string name, string type, int cars)
        {
            Name = name;
            Type = type;
            Cars = cars;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number} {Name} {Type} {Cars}";
        }
    }
}
