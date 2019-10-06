using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredShapes
{
    public class Circle : ColoredShape
    {
        public Circle(string color, float size) : base(color, size)
        {

        }
        public override float GetArea()
        {
            return Size * Size * (float)Math.PI;
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}
