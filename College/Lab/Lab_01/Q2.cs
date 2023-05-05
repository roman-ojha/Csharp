using System;

namespace Lab01Q2
{
    // 2. WAP to show the example of using method hiding and method overriding.
    class Base
    {
        public void Hello()
        {
            Console.WriteLine("Hello world from base class");
        }
    }
    class Derived : Base
    {
        public new void Hello()
        {
            Console.WriteLine("Hello world from derived class");
        }
    }
    class Prog
    {
        static public void Run(string[] args)
        {
            Base b = new Base();
            b.Hello();
            Derived d = new Derived();
            d.Hello();
        }
    }
}