using System;

class Student
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student student = new()
        {
            Name = "Deepika",
            Age = 21
        };

        Console.WriteLine($"{student.Name} - {student.Age}");
    }
}
