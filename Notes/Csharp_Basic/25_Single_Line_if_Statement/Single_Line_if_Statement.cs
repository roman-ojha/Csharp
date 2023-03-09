using System;

namespace SingleLineIfStatement
{
    class Prog
    {
        static public void Run(string[] args)
        {
            string name = "roman";
            // if you want to execute only one statement for each if else statement in that case you can use this method
            if (name == "roman")
                Console.WriteLine("Hello roman");
            else if (name == "razz")
                Console.WriteLine("Hello razz");
            else
                Console.WriteLine("Hello everyone");

            name = "razz";
            if (name == "roman") Console.WriteLine("Hello roman");
            else if (name == "razz") Console.WriteLine("Hello razz");
            else Console.WriteLine("Hello everyone");
        }
    }
}