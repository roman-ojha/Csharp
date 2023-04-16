using System;

namespace MethodOverloading
{
    /*
        *) Method Overloading
            - Method overloading is a feature that allows a class to have more than one method having the same name, if their argument lists are different.
            - It is similar to constructor overloading in Java.
            - It is also known as compile time polymorphism.
            - Method overloading increases the readability of the program.
            - Method overloading is used to perform different operations using the same method name.
            *) Method Signature:
                - The method signature consists of the method name and the parameter list.
                - The return type is not a part of the method signature.
                - The method signature must be unique.
            - So So Having different method signature with same method name is called method overloading.
    */
    class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Prog
    {
        static public void Run(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Add(10, 20));
            // The Add method with two parameters is called.
            Console.WriteLine(calculation.Add(10, 20, 30));
            // The Add method with three parameters is called.
            Console.WriteLine(calculation.Add(10.5, 20.5));
            // The Add method with two double parameters is called.
        }
    }
}