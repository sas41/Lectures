using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredShapes
{
    public class Square : ColoredShape
    {
        public Square(string color, float size) : base(color, size)
        {

        }
        public override float GetArea()
        {
            return Size * Size;
        }

        public override string GetName()
        {
            return "Square";
        }
    }
}
