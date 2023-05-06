using System;

namespace Lab01Q5
{
    // 5. WAP to show the even, square of list of numbers using Lambda expression.
    class Prog
    {

        static public void Run(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evenSquares = numbers.FindAll(num => num % 2 == 0)
                                           .ConvertAll(num => num * num);

            foreach (int num in evenSquares)
            {
                Console.WriteLine(num);
            }
        }
    }
}