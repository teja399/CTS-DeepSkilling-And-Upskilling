using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> cities = new()
        {
            "Hyderabad",
            "Bangalore",
            "Chennai"
        };

        cities.Add("Mumbai");
        cities.Remove("Chennai");

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        Dictionary<int, string> students = new()
        {
            { 1, "Deepika" },
            { 2, "Rahul" }
        };

        students.Add(3, "Anjali");

        foreach (var item in students)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}
