using System;

public class Teacher : Person
{
    // Fields
    private readonly string _subject;
    // Props

    // Constructor
    public Teacher(string name, string subject)
        :base(name)
    {
        _subject = subject;
    }

    // Method
    public void Explain()
    {
        Console.WriteLine($"{Name} is explaining the class");
    }


}
