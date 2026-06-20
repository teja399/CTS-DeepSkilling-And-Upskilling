using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        File.WriteAllText("sample.txt", "Hello C#");

        using FileStream fs =
            new FileStream("sample.txt", FileMode.Open);

        using StreamReader reader =
            new StreamReader(fs);

        Console.WriteLine(reader.ReadToEnd());

        using MemoryStream ms = new();

        byte[] data =
            Encoding.UTF8.GetBytes("Memory Stream Data");

        ms.Write(data, 0, data.Length);

        Console.WriteLine($"Bytes Written: {ms.Length}");
    }
}
