using System;

/*
    -> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
    *) C# Simple data types:
        bool	System.Boolean
        byte	System.Byte
        sbyte	System.SByte
        char	System.Char
        decimal	System.Decimal
        double	System.Double
        float	System.Single
        int	System.Int32
        uint	System.UInt32
        nint	System.IntPtr
        nuint	System.UIntPtr
        long	System.Int64
        ulong	System.UInt64
        short	System.Int16
        ushort	System.UInt16
*/

namespace SimpleValueDataTypes
{
    class Prog{

        static public void Run(string[] args){
            // literal type
            // 5 : int type
            // 'C' : char type
            // "C" : string type
            // these literal get assign to the variable and this will determine the the data type that we need to use

            int a = -5; // store positive & negative int value
            uint b = 5; // store positive int value
            char c = 'C';
            float d = 5.5F; // every time we have to specify the float we need to use 'f' suffix
            double e = 5.5; // but we don't need to specify any suffix for double type
            decimal f = 5.5M; // decimal can be use if you want exact precision or precise number, double might give small wrong answers
            // we can use this for something like Money
            bool g = true; // store true or false
            bool h = false;

            // another type that we see lot is 'string' type but it is not a simple type
            // it act as a simple type & use it as a simple type
            // but the way it works & store is different
            string i = "Hello";
            // so it is called as a reference type
        }
    }
}