using System;

/*
    -> https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-escape-sequences
    Escape sequence     Character represented
    \a	                Alert (bell, alarm)
    \b	                Backspace
    \f	                Form feed (new page)
    \n	                New-line
    \r	                Carriage return
    \t	                Horizontal tab
    \v	                Vertical tab
    \'	                Single quotation mark
    \"	                Double quotation mark
    \?	                Question mark
    \\	                Backslash
*/

namespace StringEscapeSequence
{
    class Prog{

        static public void Run(string[] args){
            string a = "hello my 'name' is \"roman\".";
            // we can use \' in case of char
            char b =  '\'';
            Console.WriteLine(a);
            Console.WriteLine(b);
            // if you want to print '\' then
            char c = '\\'; // \

            Console.WriteLine(c);
        }
    }
}