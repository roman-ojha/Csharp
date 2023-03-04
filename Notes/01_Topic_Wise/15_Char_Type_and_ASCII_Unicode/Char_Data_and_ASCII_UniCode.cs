using System;

/*
    -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char
*/

namespace CharTypeAndASCII
{
    class Prog{

        static public void Run(string[] args){
            // Single quotes for character
            // double quotes for strings
            char letter = 'a';

            // Character are represented in memory using ASCII code
            // https://www.asciitable.com/
            // Ex: 'a' is represented as 97 in memory
            // what data type you use you will get that value
            // like:
            int number = 'a'; // 97

            // if you want a tab character
            char tab = '\t';
            int tabN = '\t'; // 9
            Console.WriteLine(tabN);
            Console.WriteLine("Hello\tWorld");

            // converting integer into char
            char letter2 = (char)97; // 'a'

            // Character in C# is of 16 bit & in ASCII table table it is of 8 bit
            // So ASCII Table can only represent from 0-255
            // 16 bit version of the table is called Unicode character
            // https://en.wikipedia.org/wiki/List_of_Unicode_characters

            Console.WriteLine(letter);
            Console.WriteLine(number);
            Console.WriteLine(tab);
            Console.WriteLine(letter2);
        }
    }
}