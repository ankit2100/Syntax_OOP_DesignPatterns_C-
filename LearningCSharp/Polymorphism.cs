using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    public class FunctionOverloading
    {
        public FunctionOverloading()
        {
            Console.WriteLine("Polymorphism:FunctionOverloading");
        }
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum is {0}", a + b);
        }
        public void Sum(double a, double b)
        {
            Console.WriteLine("Sum is {0}", a + b);
        }
        public void Sum(int a, int b,int c)
        {
            Console.WriteLine("Sum is {0}", a + b + c);
        }
        public void Sum(double a, double b, double c)
        {
            Console.WriteLine("Sum is {0}", a + b + c);
        }

        public virtual void abstractsum()
        {
            Console.WriteLine("Abstract method in FunctionOverloading class");
        }

    }
    public class FunctionOverriding : FunctionOverloading
    {
        public FunctionOverriding()
        {
            Console.WriteLine("Polymorphism:FunctionOverriding");
        }
        public override void abstractsum()
        {
            Console.WriteLine("Abstract method in FunctionOverriding class");
        }
      

    }
}
