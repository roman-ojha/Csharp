using System;

namespace VariablesInitializationAndDeclaration
{
    class Prog{

        static public void Run(string[] args){
            // create variable
            // <variable_types> <identifier> <assignment_operator(=)> <value>
            int x = 5; // declaration initialization

            int y; // declaration
            // declare variable so that we can use it in future

            y = 5; // initialization
            // here we assign value to a variable

            // C# is a compile language and it will given us error if we try to use uninitialized variable
            int z;
            // Console.WriteLine(z); // error

            // Sometime we don't want the variable to get uninitialized but you want to set the variable which doesn't have a value in that case we can use nul type
            int? a = null;
            // now we can use this variable
            Console.WriteLine(a);
        }
    }
}