using System;

namespace MultidimensionalAndJaggedArray
{
    class Prog
    {

        static public void Run(string[] args)
        {
            // Creating multidimensional array
            // array inside array
            // [<row>,<column>]
            int[,] arr1 = new int[2, 3];

            // Access & assign element:
            arr1[0, 1] = 5;


            // initialize 2d array with values
            int[,] arr2 = {
            };

            // another way to created 2d array
            int[,] arr3 = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Iterate 2d array
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                // iterating each array of rows
                // arr3.GetLength(0): number of rows
                // arr3.GetLength(1): number of columns
                // arr3.GetLength(<dimension>)

                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    // iterating each column of each array of row
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged array:
            // in normal 2d array we can't have array of different size
            // but if you want to have different column size for different row in that case you can use Jagged array
            // EX:
            /*
                | 1 | 2 | 3 |
                | 1 | 2 | 3 | 4 | 5 |
                | 1 | 2 |
            */
            int[][] arr4 = new int[3][];
            // Initializing Jagged array with values
            int[][] arr5 = new int[3][]{
                new int[]{1,2,3},
                new int[]{1,2,3,4,5},
                new int[]{1,2},
            };
            // Access Jagged array
            int arr5_1 = arr5[1][3];
            // Assign Jagged array
            arr5[0][2] = 5;

            // Iterate Jagged array
            for (int i = 0; i < arr5.Length; i++)
            {
                // iterating each array of rows
                // arr5.length gives us the length of the rows

                for (int j = 0; j < arr5[i].Length; j++)
                {
                    // iterating each column of each array of row
                    // arr5[i].length gives us the length of the column of each rows
                    Console.Write(arr5[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}