using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string Email { get; set; } = "";
}

class Program
{
    static void Main()
    {
        User user = new()
        {
            Name = "Deepika",
            Age = 21,
            Email = "deepika@example.com"
        };

        string json = JsonSerializer.Serialize(user);

        File.WriteAllText("user.json", json);

        string content = File.ReadAllText("user.json");

        User? restored =
            JsonSerializer.Deserialize<User>(content);

        Console.WriteLine(restored?.Name);
        Console.WriteLine(restored?.Age);
        Console.WriteLine(restored?.Email);
    }
}
