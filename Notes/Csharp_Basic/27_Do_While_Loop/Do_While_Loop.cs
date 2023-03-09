using System;

namespace DoWhileLoop
{
    class Prog
    {

        static public void Run(string[] args)
        {
            int i = 0;
            do
            {
                // this statement will get run alway atleast at once
                Console.Write(i + " ");
                i++;
            } while (i < 30);
        }
    }
}