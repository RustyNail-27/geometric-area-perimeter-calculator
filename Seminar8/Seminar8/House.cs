using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    class House : Shape
    {
        private double width;
        private double radius;

        public House()
        {
            base.Name = "";
            base.Length = 0.0;
            width = 0.0;
            radius = 0.0;
        }

        public House(String name, double length, double width, double radius)
        {
            base.Name = name;
            base.Length = length;
            this.width = width;
            this.radius = radius;
        }

        public override double perimeter()
        {
            return 2 * base.Length + 2 * width + (2 * Math.PI * radius)/2 + (radius-width);
        }

        public override double area()
        {
            return base.Length * width + (Math.PI * radius * radius)/2;
        }

        public override String dimensions()
        {
            String str;

            str = "length: " + base.Length + " width: " + width + " radius: " + radius;
 
            return str;
        }
    }
}
