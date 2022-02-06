using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public abstract class ExampleAbstract // In an abstract class, you can define abstract methods and normal methods.
    {
        public abstract void exampleAbstrackMethod(); // Abstrack methods doesn't have a body. You must declare body in child class.
        public void exampleNormalMethod() // In an abstract class, you can define normal methods.
        {
            Console.WriteLine("It's a normal method.");
        }
        public virtual void exampleVirtualMethod() { // When you define a virtual method, child classes of this method can override this method.
            Console.WriteLine("It's a virtual method in base class.");
        }
    }

    public class ChildClass : ExampleAbstract
    {
        public override void exampleAbstrackMethod()
        {
            Console.WriteLine("Abstract method implemented");
        }
        public override void exampleVirtualMethod() // We don't have to implement virtual method but if you want to change body then you must implement it.
        {
            base.exampleVirtualMethod();// This line runs the base class' method.
            Console.WriteLine("It's a virtual method in child class.");
        }
    }
}
