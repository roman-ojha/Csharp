using System;

namespace WhileLoop
{
    class Prog
    {

        static public void Run(string[] args)
        {

            int i = 0; // initialization
            while (i < 30) // condition
            {
                Console.Write(i + " ");
                i++; // increment | decrement
            }
            Console.Write("\n");

            i = 0;
            while (i < 30)
                Console.Write(i++ + " ");
        }
    }
}