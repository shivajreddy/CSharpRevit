using System;

namespace CSharpPro1
{
    public class Text : PresentationObject
    {
        // Fields


        // Props
        public int FontSize { get; set; }
        public string FontName { get; set; }

        // Methods
        public void AddLink(string url)
        {
            Console.WriteLine("We added" + url);
        }
        

    }
}