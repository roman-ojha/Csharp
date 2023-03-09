using System;

namespace ForLoop
{
    class Prog
    {

        static public void Run(string[] args)
        {
            for (int i = 0; i < 30; i++) Console.Write(i + " ");

            for (int i = 0; i < 30; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}