using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    class Circle : Shape
    {
        public Circle()
        {
            base.Name = "";
            base.Length = 0.0;
        }

        public Circle(String name, double length)
        {
            base.Name = name;
            base.Length = length;
        }

        public override double perimeter()
        {
            return 2 * Math.PI * base.Length;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(base.Length, 2);
        }

        public override String dimensions()
        {
            return "radius: " + base.Length.ToString();
        }
    }
}
