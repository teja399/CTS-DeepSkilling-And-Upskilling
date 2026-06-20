using System;

class Program
{
    static void RefMethod(ref int value)
    {
        value += 10;
    }

    static void OutMethod(out int value)
    {
        value = 100;
    }

    static void InMethod(in int value)
    {
        Console.WriteLine(value);
    }

    static void Main()
    {
        int a = 20;
        RefMethod(ref a);
        Console.WriteLine($"After ref: {a}");

        int b;
        OutMethod(out b);
        Console.WriteLine($"After out: {b}");

        InMethod(a);
    }
}
