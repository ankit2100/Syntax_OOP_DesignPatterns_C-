using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    public abstract class ShapeAbstract
    {
        public abstract void printShape();
    }

    class Circle : ShapeAbstract
    {

        public override void printShape()
        {
            Console.WriteLine("Abstraction::Circle");
        }
    }
    class Rectancle : ShapeAbstract
    {

        public override void printShape()
        {
            Console.WriteLine("Abstraction::Rectancle");
        }
    }

}
