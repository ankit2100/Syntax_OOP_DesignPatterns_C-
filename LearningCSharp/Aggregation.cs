using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    /*Aggregation is a specialised form of Association where all objects have their own lifecycle, but there is ownership and child objects can not belong to another parent object.

Let's take an example of Department and teacher. A single teacher can not belong to multiple departments, but if we delete the department, the teacher object will not be destroyed. We can think about it as a “has-a” relationship.
     * 
     * 
     */
    class AggregationA
    {
        static int a = 0;
        public AggregationA()
        {
            Console.WriteLine("Aggregation A class");
        }

      public void PrintMethod()
        {
            Console.WriteLine("Print method");
        }

    }

    class AggregationB
    {
        /// <summary>
        /// Aggregation:It is a special type of Association where one class has an object of another class. 
        /// AggregationB has an object of AggregationA class.If 
        /// </summary>
        /// <param name="assocObj"></param>
        private AggregationA aggregationAObj = Program.aggregationAObj;
        public AggregationB()
        {
            Console.WriteLine("Aggregation B class");
            //aggregationAObj = new AggregationA();
        }
        public void PrintBMethod()
        {
            aggregationAObj.PrintMethod();
        }

    }
}
