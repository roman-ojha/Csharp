using System;

namespace NestedControlFlowAndLoop
{
    class Prog
    {

        static public void Run(string[] args)
        {
            bool logging = false;
            // Nested control flow
            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                {
                    if (logging)
                    {
                        Console.WriteLine("this is number 4");
                    }
                }
            }

            // Nested For loop
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

            {

                // Nested While loop
                int i = 9;
                while (i > 0)
                {
                    int j = i;
                    while (j >= 0)
                    {
                        Console.Write(j + " ");
                        j--;
                    }
                    Console.Write("\n");
                    i--;
                }
            }
        }
    }
}