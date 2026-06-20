using System;

class Program
{
    static (int, string) GetData()
    {
        return (101, "Deepika");
    }

    static void Main()
    {
        var (id, name) = GetData();

        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Name: {name}");
    }
}
