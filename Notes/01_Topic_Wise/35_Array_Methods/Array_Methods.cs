using System;
using System.Linq;

namespace ArrayMethods
{
    class Prog
    {

        static public void Run(string[] args)
        {
            int[] arr = { 6, 3, 2, 5, 11, 99, 21 };

            // search particular element inside the array, return index of searched element from given array
            Array.IndexOf(arr, 30);

            // Sort the given array
            Array.Sort(arr);

            // Reversing array
            Array.Reverse(arr);

            // Comparing array
            int[] arr2 = { 6, 3, 2, 5, 11, 99, 21 };
            if (arr == arr2)
            {
                // we can't compare to array like this
                // here we are comparing the object references to see if they are the exact entity
                // but it will not check for the same value inside the array
                // but we can compare this for these things:
                int[] ar1 = { 1, 2 };
                int[] ar2 = ar1;
                if (ar1 == ar2)
                {
                    // here both of them are equal
                }
            }
            // rather we have to do this
            if (Enumerable.SequenceEqual(arr, arr2))
            {
                Console.WriteLine("Equal");
            }
        }
    }
}