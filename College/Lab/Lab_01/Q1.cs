using System;
namespace Lab01Q1
{
    class Prog
    {
        static public void Run(string[] args)
        {
            int[][][] _3DArr = new int[1][][];
            int[,,] _3DArr2 = new int[3, 3, 3]{
              {
                {0,1,2},
                {1,2,3},
                {2,3,4}
              },
              {
                {3,4,5},
                {4,5,6},
                {5,6,7}
              },
              {
                {6,7,8},
                {7,8,9},
                {8,9,10}
              },
            };
            // foreach (int _2dArr in _3DArr2)
            // {
            //
            // }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("[");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[");
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{0}, ", _3DArr2[i, j, k]);
                    }
                    Console.Write("]");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
