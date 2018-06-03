using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    class Encapsulation
    {
        private double length;
        private double width;
        public Encapsulation()
        {
            Console.WriteLine("Encapsulation");
        }
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
        public void calculateArea()
        {
            Console.WriteLine("The area is {0}", length * width);
        }

    }
}
