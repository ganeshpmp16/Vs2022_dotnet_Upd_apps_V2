using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_P2_Exception_W4_D5
{
    // abstract class cannot be instantiated, it can only be inherited by other classes. It can contain abstract methods (without implementation) that must be implemented by derived classes, as well as concrete methods (with implementation). Abstract classes are used to provide a common base for related classes and to enforce a certain structure or behavior in the derived classes.
    abstract class AbstractClass
    {
        // Abstract method (without implementation)
        public abstract void AbstractMethod();
        // Concrete method (with implementation)
        public void ConcreteMethod()
        {
            Console.WriteLine("This is a concrete method in the abstract class.");
        }
    }
     class DerivedClass : AbstractClass
    {
        // Implementing the abstract method from the base class
        public override void AbstractMethod()
        {
            Console.WriteLine("This is the implementation of the abstract method in the derived class.");
        }
    }
    internal class abstract_Sample
    {
        static void Main(string[] args)
        {
            //AbstractClass obj = new AbstractClass(); // This will cause a compile-time error because abstract classes cannot be instantiated.
            DerivedClass ObjDerivedClass = new DerivedClass();
            ObjDerivedClass.AbstractMethod(); // Calling the implemented abstract method
            ObjDerivedClass.ConcreteMethod(); // Calling the concrete method from the abstract class
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
