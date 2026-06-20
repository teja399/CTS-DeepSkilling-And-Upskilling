using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.Write("Enter Input: ");

        string input = Console.ReadLine() ?? "";

        string sanitized =
            WebUtility.HtmlEncode(input);

        Console.WriteLine("Sanitized Output:");

        Console.WriteLine(sanitized);
    }
}
