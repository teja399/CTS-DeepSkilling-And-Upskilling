using System;

public record Employee
{
    public string Name { get; init; } = "";
    public int Age { get; init; }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new()
        {
            Name = "Deepika",
            Age = 21
        };

        Employee emp2 = emp1 with
        {
            Age = 22
        };

        Console.WriteLine(emp1);
        Console.WriteLine(emp2);
    }
}
