using System;

namespace VariableScopeWithNestedControlFlow
{
    class Prog
    {
        int x = 5; // class variable
        static public void Run(string[] args)
        {
            // Variable have only scope inside the block
            // here i can be able to access only inside the 'Run' function
            int i = 9;

            // we can again create the 'x' variable inside this function which will acts or only have scope inside this function
            // but this local variable 'x' hide field or class variable 'x'
            int x = 10;
            while (i > 0)
            {
                int j = i;
                // here j variable can be able to access only inside this while loop block
                while (j >= 0)
                {
                    Console.Write(j + " ");
                    j--;
                }
                Console.Write("\n");
                i--;
            }
            // we can't access 'j' variable here
            Console.WriteLine(x); // 10
        }
    }
}