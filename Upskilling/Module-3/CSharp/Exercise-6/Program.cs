using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("For Loop:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("\nForeach Loop:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nWhile Loop:");
        int index = 0;
        while (index < numbers.Length)
        {
            Console.WriteLine(numbers[index]);
            index++;
        }

        Console.WriteLine("\nDo-While Loop:");
        index = 0;
        do
        {
            Console.WriteLine(numbers[index]);
            index++;
        } while (index < numbers.Length);
    }
}
