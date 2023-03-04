using System;

namespace IfElseIfAndElse
{
    class Prog
    {
        static public void Run(string[] args)
        {
            int number = 10;
            if (number == 10)
            {
                Console.WriteLine("number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("number is 20");
            }
            else
            {
                Console.WriteLine("number is nether 10 not 20");
            }
        }
    }
}