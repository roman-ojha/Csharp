using System;

/*
    *) String:
        -> string is a reference type
        -> work like a simple type but in back it work as a reference type
        -> simple type are store into stack
        -> reference type are store into the heap
        -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-string-type
*/

namespace StringTypes
{
    class Prog{

        static public void Run(string[] args){
            string name = "roman";
            name += " ojha";
            // here we are replacing "roman" with "roman ojha" so,
            // Strings are immutable--the contents of a string object can't be changed after the object is created. For example, when you write this code, the compiler actually creates a new string object to hold the new sequence of characters, and that new object is assigned to b. The memory that had been allocated for b (when it contained the string "h") is then eligible for garbage collection.

            // if we have character array, we can convert this into string
            char[] characters = {'r','o','m','a','n'};
            name = new string(characters);

            // String Interpolation:
            var a = 'o';
            name = $"r{a}man";

            // String Literals
            // String literals are of type string and can be written in three forms, raw, quoted, and verbatim.
            var message =  """
            This is a multi-line
                string literal with the second line indented.
            """;
            Console.WriteLine(message);
            message = """
            "This is a very important message."
            """;
            Console.WriteLine(message);
            // output: "This is a very important message."
        }
    }
}