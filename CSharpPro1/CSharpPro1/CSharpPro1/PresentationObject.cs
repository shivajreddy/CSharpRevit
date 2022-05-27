using System;

namespace CSharpPro1
{
    public class PresentationObject
    {
        // Fields


        // Props
        public int Width { get; set; }
        public int Height { get; set; }

        // Methods
        public void Copy() => Console.WriteLine("Object is copied to clipboard");
        public void Duplicate() => Console.WriteLine("Item is duplicated");

    }
}