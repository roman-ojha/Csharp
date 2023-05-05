using System;

namespace Lab01Q3
{
    enum Direction
    {
        North,
        East,
        South,
        West
    }

    struct Point
    {
        public int x;
        public int y;
    }
    class Prog
    {

        static public void Run(string[] args)
        {
            Point origin = new Point();
            origin.x = 0;
            origin.y = 0;

            Console.WriteLine($"The origin is located at ({origin.x}, {origin.y})");

            Direction heading = Direction.North;
            Console.WriteLine($"The initial heading is {heading}");

            Console.ReadKey();
        }
    }
}