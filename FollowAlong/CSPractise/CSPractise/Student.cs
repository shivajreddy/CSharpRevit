using System;

public class Student : Person
{

    // constructor
    public Student(string name)
        :base(name)
    {
        
    }

    // Methods
    public void GoToClasses()
    {
        Console.WriteLine($"{Name} is going to class");
    }

}

