using System;

namespace Polymorphism
{
    /*
        *) Polymorphism:
            -> Polymorphism is the ability of an object to take on many forms.
            -> The word polymorphism means having many forms. In object-oriented programming paradigm, polymorphism is often expressed as 'one interface, multiple functions'.
            -> Polymorphism can be static or dynamic. In static polymorphism, the response to a function is determined at the compile time. In dynamic polymorphism, it is decided at run-time.
        *) Static Polymorphism:
            -> The mechanism of linking a function with an object during compile time is called early binding. It is also called static binding. C# provides two techniques to implement static polymorphism. They are −
                - Function overloading
                - Operator overloading
        *) Dynamic Polymorphism:
            -> The mechanism of linking a function with an object during runtime is called late binding. It is also called dynamic binding.
            -> C# provides two techniques to implement dynamic polymorphism. They are −
                - Method overriding
                - Virtual methods
    */
    class Prog
    {
        // Example of Static Polymorphism
        // Function Overloading
        static public void Add(int a, int b)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, a + b);
        }
        static public void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum of {0}, {1} and {2} is {3}", a, b, c, a + b + c);
        }
        static public void Add(double a, double b)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, a + b);
        }
        static public void Add(double a, double b, double c)
        {
            Console.WriteLine("Sum of {0}, {1} and {2} is {3}", a, b, c, a + b + c);
        }

        // Example of Dynamic Polymorphism
        // Method Overriding
        class Shape
        {
            protected int width, height;
            public Shape(int a = 0, int b = 0)
            {
                width = a;
                height = b;
            }
            public virtual int area()
            {
                Console.WriteLine("Parent class area :");
                return 0;
            }
        }

        class Rectangle : Shape
        {
            public Rectangle(int a = 0, int b = 0) : base(a, b)
            {

            }

            // here we are overriding the base class 'area' function and this function will get bind at runtime
            public override int area()
            {
                Console.WriteLine("Rectangle class area :");
                return (width * height);
            }
        }

        class Triangle : Shape
        {
            public Triangle(int a = 0, int b = 0) : base(a, b)
            {

            }
            public override int area()
            {
                Console.WriteLine("Triangle class area :");
                return (width * height / 2);
            }
        }
        static public void Run(string[] args)
        {
            Add(1, 2);
            Add(1, 2, 3);
            Add(1.1, 2.2);
            Add(1.1, 2.2, 3.3);
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            Shape s = new Shape(10, 5);
            Shape sh;
            sh = r;
            sh.area();
            sh = t;
            sh.area();
            sh = s;
            sh.area();
        }
    }
}