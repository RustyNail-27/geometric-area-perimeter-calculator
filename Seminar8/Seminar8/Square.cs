using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    class Square : Shape
    {
        public Square()
        {
            base.Name = "";
            base.Length = 0.0;
        }

        public Square(String name, double length)
        {
            base.Name = name;
            base.Length = length;
        }

        public override double perimeter()
        {
            return 4 * base.Length;
        }

        public override double area()
        {
            return base.Length * base.Length;
        }

        public override String dimensions()
        {
            return "length: " + base.Length.ToString();
        }
    }
}
