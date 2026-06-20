using System;

class BaseClass
{
    public string PublicMessage = "Public Member";
    private string PrivateMessage = "Private Member";
    protected string ProtectedMessage = "Protected Member";

    public void ShowPrivate()
    {
        Console.WriteLine(PrivateMessage);
    }
}

class DerivedClass : BaseClass
{
    public void Display()
    {
        Console.WriteLine(PublicMessage);
        Console.WriteLine(ProtectedMessage);
    }
}

class Program
{
    static void Main()
    {
        BaseClass obj = new();
        Console.WriteLine(obj.PublicMessage);
        obj.ShowPrivate();

        DerivedClass derived = new();
        derived.Display();
    }
}
