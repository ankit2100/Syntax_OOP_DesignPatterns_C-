using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    class Shape
    {
        protected double length;
        protected double width;
        public Shape(double wid,double len)
        {
            Console.WriteLine("Inheritance");
            this.length = len;
            this.width = wid;
        }
        protected void setLength(double len)
        {
            this.length = len;
        }
        protected void setWidth(double wid)
        {
            this.width = wid;
        }

        protected double getLength()
        {
            return length;
        }
        protected double getWidth()
        {
            return width;
        }
    }

    class Square : Shape
    {
        public Square(double l, double w) : base(l, w)
        { 
        }
       
        public void calculateArea()
        {
            Console.WriteLine("Area is {0}", length * width);
        }
    }
}
