using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    class Shape1
    {
        protected double length = 5;
        protected double width = 5;

        public void setLength(double len)
        {
            this.length = len;
        }
        public void setWidth(double wid)
        {
            this.width = wid;
        }

        public double getLength()
        {
            return length;
        }
        public double getWidth()
        {
            return width;
        }
    }

    class Square1 : Shape1
    {

        public void calculateArea()
        {
            Console.WriteLine("Area is {0}", length * width);
        }
    }
}
