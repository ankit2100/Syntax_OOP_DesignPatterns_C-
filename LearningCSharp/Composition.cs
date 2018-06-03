using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    /*
     * Composition is again specialised form of Aggregation and we can call this as a “death” relationship. It is a strong type of Aggregation. Child object does not have its lifecycle and if parent object is deleted, all child objects will also be deleted.

Let's take again an example of relationship between House and Rooms. House can contain multiple rooms - there is no independent life of room and any room can not belong to two different houses. If we delete the house - room will automatically be deleted.

Let's take another example relationship between Questions and Options. Single questions can have multiple options and option can not belong to multiple questions. If we delete the questions, options will automatically be deleted.
     */
    class CompositionA
    {
        public CompositionA()
        {
            Console.WriteLine("Composition A class");
        }

        public void PrintMethod()
        {
            Console.WriteLine("Print method");
        }

    }

    class CompositionB
    {
        /// <summary>
        /// Composition:It is a special type of Aggregation where one class has an object of another class. 
        /// CompositionB has an object of CompositionA class.If CompositionB is deleted then CompositionA will be also deleted.
        /// </summary>
        /// <param name="assocObj"></param>
        private CompositionA compositionAObj = new CompositionA();
        public CompositionB()
        {
            Console.WriteLine("Composition B class");
            compositionAObj.PrintMethod();
        }

    }
}
