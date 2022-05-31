using System;


public class Person
{

    // Props
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor 
    public Person(string name)
    {
        Name = name;
    }

    // Methods
    public int SetAge(int n)
    {
        Age = n;
        return n;
    }

    public void ShowAge()
    {
        Console.WriteLine($"{Name}'s age is {Age}");
    }

}
