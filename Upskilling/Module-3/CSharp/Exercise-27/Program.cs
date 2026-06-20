using System;
using System.Threading;

class Program
{
    static readonly object lock1 = new();
    static readonly object lock2 = new();

    static void Task1()
    {
        if (Monitor.TryEnter(lock1, 1000))
        {
            try
            {
                Console.WriteLine("Task1 acquired lock1");

                if (Monitor.TryEnter(lock2, 1000))
                {
                    try
                    {
                        Console.WriteLine("Task1 acquired lock2");
                    }
                    finally
                    {
                        Monitor.Exit(lock2);
                    }
                }
            }
            finally
            {
                Monitor.Exit(lock1);
            }
        }
    }

    static void Main()
    {
        Thread thread = new Thread(Task1);

        thread.Start();

        thread.Join();
    }
}
