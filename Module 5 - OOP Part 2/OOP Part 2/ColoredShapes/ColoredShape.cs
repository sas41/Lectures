using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredShapes
{
    abstract class ColoredShape
    {
        public string Color { get; set; }
        public float Size { get; set; }
        public ColoredShape(string color, float size)
        {
            Color = color;
            Size = size;
        }
        virtual public void Show()
        {
            Console.WriteLine(Color);
            Console.WriteLine(Size);
        }
        abstract public string GetName();
        abstract public float GetArea();
    }
}
