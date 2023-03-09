using System;

/*
    *) List<T>:
        -> The List<T> is a collection of strongly typed objects that can be accessed by index and having methods for sorting, searching, and modifying list. It is the generic version of the ArrayList that comes under System.Collections.Generic namespace.
        -> List<T> is the dynamic size array and automatically increase the as as per requirement. so, it means that we don't have to declare the size of the List.
    *) List<T> Characteristics
        -> List<T> equivalent of the ArrayList, which implements IList<T>.
        -> It comes under System.Collections.Generic namespace.
        -> List<T> can contain elements of the specified type. It provides compile-time type checking and doesn't perform boxing-unboxing because it is generic.
        -> Elements can be added using the Add(), AddRange() methods or collection-initializer syntax.
        -> Elements can be accessed by passing an index e.g. myList[0]. Indexes start from zero.
        List<T> performs faster and less error-prone than the ArrayList.
        -> Syntax:
            -> List that can store integer data type
                -> List<int> grades = new List<int>();
*/
using System.Collections.Generic;
using System.Linq;

namespace ListGeneric
{
    class Prog
    {
        static public void Run(string[] args)
        {
            List<int> grades = new List<int>();
            // add the element or push the element on the backside
            grades.Add(5);
            grades.Add(6);

            // get the number of element in the list
            // or the size of list
            int size = grades.Count;

            // get the element from the list using index
            int elm = grades[0];

            // Iterating through list
            for (int i = 0; i < grades.Count; i++)
            {
                Console.Write(grades[i] + " ");
            }

            // Iterate list using forEach:
            Console.WriteLine();
            grades.ForEach(grade => Console.Write(grade + " "));

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            // Methods:
            // Inserting to the particular index, where it will shift the remaining index to forward
            grades.Insert(1, 23);
            grades.Insert(2, 33);
            grades.Insert(3, 41);


            // remove the given element
            grades.Remove(6);
            Console.WriteLine();

            // remove the element by index
            grades.RemoveAt(1);
            Console.WriteLine();

            // Searching element in the list
            // grades.Contains(<item>)
            Console.WriteLine(grades.Contains(33)); // True

            // If you want to know where the element is then you can use IndexOf()
            // it return -1 if it doesn't exist
            Console.WriteLine(grades.IndexOf(41)); // 2

            // Clear or delete all the element from the list
            grades.Clear();
            // or we can use another method to create the list
            grades = new List<int>();


            grades = new List<int>() { 1, 6, 43, 2, 1, 87, 7, 4, 231, 1, 1, 1, 153, 3, 2, 1, 23 };
            // If you have multiple element of same value and you want to last index of the element then:
            Console.WriteLine(grades.LastIndexOf(1)); // 15

            // Comparing List for same value sequentially
            // SequenceEqual method
            grades = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> grades2 = new List<int>() { 1, 2, 3, 4, 5 };
            // you  can't use ==(comparison operator)
            // and also we can use 'Equals()' method
            // So here these method will check where they have to same entity rather then the same value, means are they referencing the same list or not

            // But if you want to compare the sequence of value in the two list then you have to do this
            if (grades.SequenceEqual<int>(grades2))
            {
                Console.WriteLine("Equals!");
            }
        }
    }
}