using System;

namespace ArraySort
{
    class Prog
    {

        static public void Run(string[] args)
        {
            int[] arr = { 6, 3, 2, 5, 11, 99, 21 };

            // this function will modify the original array and sort inside the 'arr'
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}