using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    /// <summary>
    ///Abstraction: hiding implementation using abstract classes and interfaces etc.
    /// </summary>
    public abstract class ShapeAbstract
    {
        //All Abstract methods must be overriden and implemented in child class.Abstract method can only reside in Abstract class.
        public abstract void printShape();
        public void visibleToOutsideWorldMethod()
        {
            //nothing
        }
    }

    class Circle : ShapeAbstract
    {
        public void hiddenToOutsideWorldMethod()
        {
            //nothing
        }
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
