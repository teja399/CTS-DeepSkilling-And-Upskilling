using System;

class Program
{
    static void Display(object obj)
    {
        if (obj is int number)
        {
            Console.WriteLine($"Integer: {number}");
        }
        else if (obj is string text)
        {
            Console.WriteLine($"String: {text}");
        }

        string result = obj switch
        {
            int => "It is an Integer",
            string => "It is a String",
            _ => "Unknown Type"
        };

        Console.WriteLine(result);
    }

    static void Main()
    {
        Display(100);
        Display("Hello");
    }
}
