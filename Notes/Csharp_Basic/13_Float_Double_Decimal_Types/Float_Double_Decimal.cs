using System;

/*
    *) Floating-point numeric types
        -> The floating-point numeric types represent real numbers. All floating-point numeric types are value types. They are also simple types and can be initialized with literals. All floating-point numeric types support arithmetic, comparison, and equality operators.
        -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#characteristics-of-the-floating-point-types
        type/keyword	Size	    .NET type
        float	        4 bytes	    System.Single
        double	        8 bytes	    System.Double
        decimal	        16 bytes	System.Decimal
*/

namespace FloatDoubleDecimalTypes
{
    class Prog{

        static public void Run(string[] args){
            // 5.5f - float number
            // 5.5 - double number
            float a = 5.5f;
            // we can cast double into float as well
            float b = (float)5.5;

            // storing float into double is not a problem
            double c = 5.5f;
            double d = 5.5;
            // 99% of the time you might need to use double
            // you might want to use float if you really restricted to memory

            // floating point data types can't be trusted for precisions
            // but in case of double it precise

            // if you are working with something like money in that case we can use decimal
            decimal e = 10.5M;

            // properties and methods:
            // we can assign NaN(not a number) using property
            double f = double.NaN;
            // now we can check where double is number of not
            Console.WriteLine(double.IsNaN(f)); // true
            // we can check for the infinity
            Console.WriteLine(double.IsInfinity(double.PositiveInfinity)); // true
            // generating infinity
            double g = Math.Pow(9999,999999999999);
            Console.WriteLine(double.IsInfinity(g)); // true

            // get decimal maximum store value
            decimal h = decimal.MaxValue;
            Console.WriteLine(h);


            // Removing warning
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}