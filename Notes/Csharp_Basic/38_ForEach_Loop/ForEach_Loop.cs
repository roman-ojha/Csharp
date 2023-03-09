using System;
using System.Collections.Generic;

namespace ForEachLoop
{
    class Prog
    {

        static public void Run(string[] args)
        {
            List<int> grades = new List<int>() { 1, 6, 43, 2, 1, 87, 7, 4, 231, 1, 1, 1, 153, 3, 2, 1, 23 };

            // For iterate through list one by one
            foreach (int grade in grades)
            {
                // here 'grade' is the iteration variable
                // where we can get the value of every element using 'grade' but we can't change the value of element using 'grade'
                // So, foreach loop can be use to read the elements not to update the elements
                Console.Write(grade + " ");
            }

            // we also have the method 'ForEach' loop of the type of data like "List"
            grades.ForEach(grade => Console.Write(grade + " "));

            // So List implement the 'IEnumerable' Interface so because of that we can be able to use foreach for the List type
            // if some type that implement the 'IEnumerable' Interface then we can use foreach on those type as well
            // 'Array' type also implement 'IEnumerable' Interface
            // and We can convert the 'List' into arrayl
            // Example that implement 'IEnumerable' are:
            // HashSet<T>, Array, List<T>, LinkedList<T>, Queue<T>

            Console.WriteLine();
            foreach (int grade in grades.ToArray<int>())
            {
                Console.Write(grade + " ");
            }

            // Nested Foreach loop
            // 2D, Multidimensional array

            List<List<int>> m2d = new List<List<int>>(){
                new List<int>(){1,2},
                new List<int>(){3,4,5,6},
                new List<int>(){7,8,9},
            };

            Console.WriteLine();
            foreach (List<int> intList in m2d)
            {
                foreach (int elm in intList)
                {
                    Console.Write(elm + " ");
                }
                Console.WriteLine();
            }
        }
    }
}