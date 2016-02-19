using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Rectangle : Shape
    {
        public Rectangle(double length, double width) : base(length, width) 
        {

        }

        public override double Area
        {
            get { return (Lenght * Width); }
        }
        public override double Perimeter
        {
            get { return (2 * Lenght) + (2 * Width); }

        }

    }
}
