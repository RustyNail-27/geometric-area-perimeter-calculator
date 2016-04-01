using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    class Rectangle : Shape
    {
        private double width;

        public Rectangle()
        {
            base.Name = "";
            base.Length = 0.0;
            width = 0.0;
        }

        public Rectangle(String name, double length, double width)
        {
            base.Name = name;
            base.Length = length;
            this.width = width;
        }

        public override double perimeter()
        {
            return 2 * base.Length + 2 * width;
        }

        public override double area()
        {
            return base.Length * width;
        }

        public override String dimensions()
        {
            String str;

            str = "length: " + base.Length + " width: " + width;
 
            return str;
        }
    }
}
