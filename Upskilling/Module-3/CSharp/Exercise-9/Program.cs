using System;

class Program
{
    static int CalculateFactorial(int number)
    {
        int Factorial(int n)
        {
            if (n <= 1)
                return 1;

            return n * Factorial(n - 1);
        }

        return Factorial(number);
    }

    static void Main()
    {
        Console.WriteLine(CalculateFactorial(5));
    }
}
