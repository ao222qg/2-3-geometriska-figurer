using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Ellipse : Shape
    {
        public Ellipse(double length, double width) : base(length, width) // Konstruktor med 2 inparametrar
        {

        }

        public override double Area
        {
            get { return (Lenght / 2) * (Width / 2) * (Math.PI); }
        }

        public override double Perimeter
        {
            get { return Math.PI * Math.Sqrt(2 * (Lenght / 2) * (Lenght / 2) + 2 * (Width / 2) * (Width / 2)); }
        }

    }
}
