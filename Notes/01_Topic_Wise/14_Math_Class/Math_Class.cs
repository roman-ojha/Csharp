using System;

namespace MathClass
{
    class Prog{

        static public void Run(string[] args){
            double x = 50.5;
            // Math.Round(<floating_number>,<number_of_decimal_places_after>,<mid_point_rounding>)
            //  -> round to the nearest integer value, but return type is double
            Console.WriteLine(Math.Round(x)); // 50
            Console.WriteLine(Math.Round(x,1)); // 50.5
            Console.WriteLine(Math.Round(x,0,MidpointRounding.AwayFromZero)); // 51

            // Math.Floor()
            Console.WriteLine(Math.Floor(x)); // 50
            // Math.Ceiling
            Console.WriteLine(Math.Ceiling(x)); // 51

            // Math.Truncate()
            // -> remove digit after the decimal
            Console.WriteLine(Math.Truncate(x)); // 50

            // Math.Min()
            // -> get minimum value from two given number
            Console.WriteLine(Math.Min(1,2)); // 1
            // Math.Max()
            // -> get maximum value from the two given number
            Console.WriteLine(Math.Max(1,2)); // 2

            // Math.Abs()
            // -> give positive value from any number
            Console.WriteLine(Math.Abs(-10)); // 10
            Console.WriteLine(Math.Abs(10)); // 10

            // Math.Sign(x);
            // -> to check where the given number is negative, positive, or 0
            Console.WriteLine(Math.Sign(-100)); // -1
            Console.WriteLine(Math.Sign(100)); // 1
            Console.WriteLine(Math.Sign(0)); // 0
        }
    }
}