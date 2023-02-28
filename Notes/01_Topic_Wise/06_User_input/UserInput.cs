using System;

namespace UserInput
{
    class Prog{

        static public void Run(string[] args){
            // read like take an input
            // and it have the return type and it return an string
            // we now we can store that return value into th variable
            // to simple type to get the return type variable is 'var'
            var first_name = Console.ReadLine();
            // we can use the the 'var' type if we don't know the type of the return value is.
            // but c# is the statically type language
            // and it will figure out for us the type of the variable it is

            // because Console.ReadLine() return the 'string' type we can use 'string' type as a variable to take the return value
            string? last_name = Console.ReadLine();
            // it might also return null so we can use '?' for that

            Console.WriteLine($"Hello {first_name} {last_name}");
        }
    }
}