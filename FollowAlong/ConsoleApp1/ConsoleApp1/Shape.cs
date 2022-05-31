using System;

namespace ConsoleApp1
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // methods that override the Draw method
            Console.WriteLine("Drew a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drew a rectangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }

}