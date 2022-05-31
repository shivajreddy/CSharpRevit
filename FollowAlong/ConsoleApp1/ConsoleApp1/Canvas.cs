using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Canvas
    {
        public void DrawShape(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}