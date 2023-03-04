using System;

namespace VerbatimIdentifier
{
    class Prog{

        static public void Run(string[] args){
            // Verbatim:
            // Verbatim string:
            // if we use @ before string then we can use string Escape sequence as it is and get render 
            // but we can use double quote in this case
            // to use double quote you need to put two double quote
            string d = @"hello \t roman ""\xyz""";
            Console.WriteLine(d);
            // Output: hello \t roman "\xyz"

            // There is other way to use Verbatim identifier
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/verbatim
        }
    }
}