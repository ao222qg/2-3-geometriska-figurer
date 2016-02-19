using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{       
    abstract class Shape 
    {
        
        private double _width;
        private double _length;

        protected Shape(double lenght, double width)
        {
            Lenght = lenght;
            Width = width;
        }

        public abstract double Area
        {
            get;
        }
        public double Lenght
        {
            get { return _length; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }

        public abstract double Perimeter
        {
            get;
        }

        public double Width
        {
            get { return _width; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Length      : {0,10:f2}\nWidth       : {1, 10:f2}\nPerimeter   : {2, 10:f2}\nArea        : {3, 10:f2}", Lenght, Width, Perimeter, Area);
        }
    }


}
