using System;

class Person
{
    public string? Name { get; set; }
}

class Program
{
    static void Main()
    {
        Person? person = null;

        Console.WriteLine(person?.Name ?? "Name not available");

        person = new Person
        {
            Name = "Deepika"
        };

        Console.WriteLine(person?.Name ?? "Name not available");
    }
}
