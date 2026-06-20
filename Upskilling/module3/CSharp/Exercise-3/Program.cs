using System;

public class Person(string firstName, int age)
{
    public string FirstName { get; } = firstName;
    public int Age { get; } = age;

    public void Display()
    {
        Console.WriteLine($"Name: {FirstName}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new("Deepika", 21);
        person.Display();
    }
}
