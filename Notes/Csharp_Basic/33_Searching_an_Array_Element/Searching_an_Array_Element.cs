using System;

namespace SearchingAnArrayElement
{
    class Prog
    {
        static public void Run(string[] args)
        {
            int[] array = { 3, 6, 2, 5, 11, 99, 21 };

            // manually searching using for loop
            int searchingElm = 21;
            int searchedIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchingElm)
                {
                    searchedIndex = i;
                    break;
                }
            }
            Console.WriteLine(searchedIndex > 0 ? "Found element in index " + searchedIndex : "Not found given element");

            // we can search for the index of the element inside the array using method
            // return -1 if not found
            searchedIndex = Array.IndexOf(array, 23);
            Console.WriteLine(searchedIndex);
        }
    }
}