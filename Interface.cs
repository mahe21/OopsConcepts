using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept 
{
    interface Interface_One
    {
        // Interface method does not have any body
        // We can create multiple types of bodies
        // •Interface is a complete abstract class because all the methods which are declared inside the interface are abstract methods.
        // •It cannot have method body.
        // •Interface methods are public or abstract by default.
        // •It's implementation must done by class or strut.
        // •It is used to achieve multiple inheritance which can't be achieved by class
        void one();
    }
    interface Interface_Two
    {
        void two();
    }
}
