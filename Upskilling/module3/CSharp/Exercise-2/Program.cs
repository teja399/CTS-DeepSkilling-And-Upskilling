using System;

class Student
{
    public string Name;
}

class Program
{
    static void ModifyValue(int number)
    {
        number = 100;
    }

    static void ModifyReference(Student student)
    {
        student.Name = "Modified Name";
    }

    static void Main()
    {
        int value = 10;
        Student student = new Student { Name = "Deepika" };

        Console.WriteLine("Before:");
        Console.WriteLine(value);
        Console.WriteLine(student.Name);

        ModifyValue(value);
        ModifyReference(student);

        Console.WriteLine("After:");
        Console.WriteLine(value);
        Console.WriteLine(student.Name);
    }
}
