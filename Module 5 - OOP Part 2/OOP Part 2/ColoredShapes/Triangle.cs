using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredShapes
{
    public class Triangle : ColoredShape
    {
        public Triangle(string color, float size) : base(color, size)
        {

        }
        public override float GetArea()
        {
            return ((Size * Size) * (float)Math.Sqrt(3)) / 4;
        }

        public override string GetName()
        {
            return "Triangle";
        }
    }
}
