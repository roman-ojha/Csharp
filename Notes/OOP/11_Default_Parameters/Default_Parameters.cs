using System;

namespace DefaultParameters
{
    /*
        *) Default Parameters:
            - Default parameters are used to provide default values to the parameters of a method.
            - If we are calling a method by passing less number of arguments than the actual number of parameters, then the default values are assigned to the remaining parameters.
    */

    class Calculation
    {
        public int Add(int a, int b = 10)
        {
            return a + b;
        }

        public int Add(int a, int b, int c = 30)
        {
            return a + b + c;
        }
    }

    class Prog
    {
        static public void Run(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Add(10)); // 20
            // The Add method with two parameter is called.
            Console.WriteLine(calculation.Add(10, 20)); // 30
            // The Add method with two parameters is called.
            Console.WriteLine(calculation.Add(10, 20, 30)); // 60
            // The Add method with three parameters is called.
        }
    }
}