using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practise
{
    /*
     * Association is a relationship where all objects have their own lifecycle and there is no owner.

Let's take an example of Teacher and Student. Multiple students can associate with single teacher and single student can associate with multiple teachers, but there is no ownership between the objects and both have their own lifecycle. Both can be created and deleted independently.
     */
    class AssociationA
    {
        public AssociationA()
        {
            Console.WriteLine("Association A class");
        }

    }
    
    class AssociationB
    {
        /// <summary>
        /// Association:It is a relationship between two classes. 
        /// AssociationB class uses object of AssociationA class.
        /// </summary>
        /// <param name="assocObj"></param>
        public AssociationB(AssociationA assocObj)
        {
            Console.WriteLine("Association B class");
        }

    }
}
