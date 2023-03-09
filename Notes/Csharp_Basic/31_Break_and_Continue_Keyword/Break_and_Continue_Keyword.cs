using System;

namespace BreakAndContinueKeyword
{
    class Prog
    {

        static public void Run(string[] args)
        {
            // Break keyword help to exit a loop that it is in
            // It can also help to break from executing all the switch statements
            for (int i = 1; i <= 5; i++)
            {
                if (i == 4)
                {
                    // this break will only help to break from current loop
                    break;
                }
                for (int j = 0; j < i; j++)
                {
                    if (j == 3)
                    {
                        // this break will only help to break from current loop
                        break;
                    }
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

            // Continue break from one iteration of loop
            for (int i = 1; i <= 5; i++)
            {
                if (i == 4)
                {
                    // this continue will only help to break from current loop one iteration
                    continue;
                }
                for (int j = 0; j < i; j++)
                {
                    if (j == 3)
                    {
                        // this continue will only help to break from current loop one iteration
                        continue;
                    }
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}