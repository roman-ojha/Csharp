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
        }
    }
}