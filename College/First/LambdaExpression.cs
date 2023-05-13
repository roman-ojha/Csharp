using System;
namespace LambdaExpression
{
    class LambdaExp
    {
        static public void Run(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Read all array values using lambda expression
            var results = arr.Select(a => a);

            foreach (var a in results)
            {
                Console.WriteLine(a);
            }

            // Find all the square values of an array
            var squareVal = arr.Select(r => r * r);

            foreach (var a in squareVal)
            {
                Console.WriteLine(a);
            }

            // Find even number

            // statement lambda
        }
    }
}
