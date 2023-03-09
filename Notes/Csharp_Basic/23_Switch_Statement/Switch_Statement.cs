using System;

namespace SwitchStatement
{
    class Prog
    {
        static public void Run(string[] args)
        {
            char Grade = 'A';
            switch (Grade)
            {
                case 'A':
                    Console.WriteLine("Great");
                    // break is required inside switch statement if you don't use return statement
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    // if you want to return from main method here you can do that
                    return;
                case 'C':
                    Console.WriteLine("Ok");
                    break;
                case 'D':
                    Console.WriteLine("Bad");
                    break;
                // if you want to run statement for multiple cases then you can do that like this:
                case 'E':
                case 'F':
                    Console.WriteLine("Very bad");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }
}