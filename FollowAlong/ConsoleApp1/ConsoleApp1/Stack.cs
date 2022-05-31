using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Stack
    {
        // Fields


        // Properties
        public ArrayList Arr { get; } = new ArrayList();


        // Constructor
        public Stack()
        {
        }

        // Methods
        public void Push(object newItem)
        {
            Arr.Add(newItem);
        }

        public object Pop()
        {
            var lastItem = Arr[Arr.Count - 1];
            Arr.RemoveAt(Arr.Count-1);
            return lastItem;
        }

        public void Clear()
        {
            Arr.Clear();
            Console.WriteLine("Stack emptied");
        }

        


    }
}