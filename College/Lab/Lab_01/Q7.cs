using System;

namespace Lab01Q7
{
    public interface IShape
    {
        void Draw();
    }

    public abstract class Shape : IShape
    {
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    class Prog
    {
        static public void Run(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();

            Console.ReadKey();
        }
    }
}