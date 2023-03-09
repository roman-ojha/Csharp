using System;

namespace ArrayType
{
    class Prog
    {
        static public void Run(string[] args)
        {
            // Array:
            // store groups of information
            // in c# we have to specify what type of information you want to store
            // and also we have to specify the size of the array
            // we can access the value or element of the array using index start from 0 upto (size of array - 1)
            // syntax:
            int[] grades = new int[10];
            // assigning value
            grades[0] = 10;
            grades[1] = 30;
            // getting value
            int grade1 = grades[3]; // 4th element

            // we can get the length of the array using property 'length'
            int gradesLength = grades.Length;

            // if you know the value of the array while write the program in that case you can assign the value at the start
            int[] arr = { 1, 2, 3, 4, 5 };
            // the size of the array will be determine by the number of element that we put inside curly bracket

            // arr[5] // error, output of bound exception


            // Fill Array from User Input
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.In.ReadLine());
            }
            // Array output:
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}