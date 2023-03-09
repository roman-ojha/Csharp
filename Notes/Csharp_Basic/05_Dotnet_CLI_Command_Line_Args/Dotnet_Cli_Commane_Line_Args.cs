using System;

namespace CLAOfDotnetCLI
{
    class Prog{
        // static void Main(string[] args){
            // here we are getting 'args' of type list of string as parameter where calling the 'Main' function we can pass the argument
            // and we can get the argument into 'args'
        // }

        static public void Run(string[] args){
            // we can pass the argument into the method which that particular method will use to do things about it

            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            // command to pass the argument into main method are:
            // -> dotnet run <arg1> <arg2>

            // we can pass the bunch of flag so that we can manipulate the way that the program runs
            // if we want the default flag for the dot net cli the we can do this
            // -> dotnet run --<flag>
            // but if we want our own flat then some args the we can do something like this:
            // -> dotnet run -- -<flag_name>

            // now we can get the flag name using 'args'

            // One method can take different type of arguments
            // like Console.WriteLine() can take an 'string', 'int', 'object',
        }



        void Print(string value){
        }
    }
}
