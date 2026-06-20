using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        Trace.Listeners.Add(
            new TextWriterTraceListener("log.txt"));

        Trace.AutoFlush = true;

        Trace.WriteLine("Application Started");
        Trace.WriteLine("Logging using Trace");

        Console.WriteLine("Logs written to log.txt");
    }
}
