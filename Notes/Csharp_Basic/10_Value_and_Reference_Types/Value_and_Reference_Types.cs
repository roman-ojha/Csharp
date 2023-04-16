using System;

namespace ValueAndReferenceTypes
{
    class Prog
    {

        static public void Run(string[] args)
        {
            // value type:
            // the main things that we need to know about value types is that, when we have a variable that is of a value type directly contain what ever it get assign to
            int a = -5;

            // reference type:
            // but in case of reference type it get store the reference of whatever we are trying to assign

            // let's say that we have an array [] of length 100000000000 and get assign to one variable, but we want the value array into another variable
            // if it is of value type it have to copy the entire array into the new variable
            // but if it is a reference type then we can point to the same array and can access the same array with different variable 

            int b = a;
            // here we are assigning value type to the another variable
            // because of that now two different variable point/reference to the different value or memory address
            b = 10;
            Console.WriteLine(a); // -5
            Console.WriteLine(b); // 10

            // So, Array type is one of the Reference type
            int[] c = { -5 };
            int[] d = c;
            // here 'd' point to the same array
            Console.WriteLine(c[0]); // -5
            Console.WriteLine(d[0]); // -5
            d[0] = 10;
            // changing in 'd' will get reflected to 'c' as well
            Console.WriteLine(c[0]); // 10
            Console.WriteLine(d[0]); // 10

            Test(c);
            Console.WriteLine(c[0]); // 100
            Console.WriteLine(d[0]); // 100

            // Also Every time we pass objects and return object from methods, we are passing the reference of the object
        }

        static private void Test(int[] x)
        {
            x[0] = 100;
        }
    }
}