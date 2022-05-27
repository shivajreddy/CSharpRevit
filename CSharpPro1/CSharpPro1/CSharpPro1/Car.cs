using System;
using System.Collections.Generic;



namespace CSharpPro1
{

    public class Car
    {
        // Properties
        public string Name { get; }
        public Dictionary<string, string> Parts = new Dictionary<string, string>();

        // Constructor
        public Car(string name)
        {
            Name = name;
        }

        // Indexer
        public string this[string key]
        {
            get => Parts[key];
            set => Parts[key] = value;
        }


    }
}