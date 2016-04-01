using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    abstract class Shape
    {
        private String name;
        private double length;

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public abstract double perimeter();

        public abstract double area();

        public abstract String dimensions();
    }
}
