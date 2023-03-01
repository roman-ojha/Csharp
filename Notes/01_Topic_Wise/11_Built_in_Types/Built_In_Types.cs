using System;

/*
    *) Build in types
        -> built is types are an aliases of predefined type in the 'System' namespace
        -> aliases is an another name for somethings
        -> here 'bool', 'bytes' are the aliases of the 'System.Boolean', 'System.Byte'
        -> so we can use either of the one
            => Value types:
                c# types    .NET type
                bool	    System.Boolean
                byte	    System.Byte
                sbyte	    System.SByte
                char	    System.Char
                decimal	    System.Decimal
                double	    System.Double
                float	    System.Single
                int	        System.Int32
                uint	    System.UInt32
                nint	    System.IntPtr
                nuint	    System.UIntPtr
                long	    System.Int64
                ulong	    System.UInt64
                short	    System.Int16
                ushort	    System.UInt16
            => Reference types:
                object      System.Object
                string      System.String
                dynamic     System.Object
        -> C# uses the .NET framework, Dotnet give us the tools required to build applications
        -> one of these tools is the .NET class library
        -> so, these are the collection of code that we can reference and use it inside our programs
        -> this is what gives us access to all of different data types that they define and this is a part of .NET framework not a C#
        -> so, it means that any other language that use .NET framework they will also have these different data types
*/

namespace BuildInTypes
{
    class Prog{

        static public void Run(string[] args){
            int a = 5;
            Int32 b = 5;
            System.Int32 c = 5;

            string d = "roman";
            String e = "roman";
            // there is not any different between 'String' with upper case 'S' & 'string' with lower case 's'
            // where 'string' lower case 's' is an aliases
            // and 'String' upper case 'S' is an System Class

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}