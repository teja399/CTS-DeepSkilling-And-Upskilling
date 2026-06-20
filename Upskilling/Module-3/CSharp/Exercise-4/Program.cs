using System;

class Employee
{
    public string Name { get; set; } = "";
}

class Program
{
    static void Main()
    {
        var number = 100;
        var text = "Hello";

        Employee employee = new()
        {
            Name = "Deepika"
        };

        Console.WriteLine($"{number} : {number.GetType()}");
        Console.WriteLine($"{text} : {text.GetType()}");
        Console.WriteLine($"{employee.Name} : {employee.GetType()}");
    }
}
